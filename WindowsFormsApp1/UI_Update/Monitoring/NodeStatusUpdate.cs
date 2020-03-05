using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TransferControl.Comm;
using TransferControl.Config.SignalTower;
using TransferControl.Engine;
using TransferControl.Management;

namespace Adam.UI_Update.Monitoring
{
    class NodeStatusUpdate
    {
        static ILog logger = LogManager.GetLogger(typeof(NodeStatusUpdate));
        delegate void UpdateNode(string Device_ID, string State);
        delegate void UpdateState(string State);
        static List<SignalTowerSetting> SignalSetting;
        

        public static void InitialSetting()
        {
          

            
           

            
            SignalSetting = SignalTowerSetting.GetAll();

        }

        public static void UpdateNodeState(string Device_ID, string State)
        {
            try
            {
                Form form = Application.OpenForms["FormMain"];
                TextBox State_tb;
                if (form == null)
                    return;

                State_tb = form.Controls.Find(Device_ID + "_State", true).FirstOrDefault() as TextBox;
                if (State_tb == null)
                    return;

                if (State_tb.InvokeRequired)
                {
                    UpdateNode ph = new UpdateNode(UpdateNodeState);
                    State_tb.BeginInvoke(ph, Device_ID, State);
                }
                else
                {
                    State_tb.Text = State;
                    switch (State)
                    {
                        case "Run":
                            State_tb.BackColor = Color.Lime;
                            //UpdateCurrentState();
                            break;
                        case "Idle":
                            State_tb.BackColor = Color.Orange;
                            //UpdateCurrentState();
                            break;
                        case "Ready To Load":
                            State_tb.BackColor = Color.DarkGray;
                            break;
                        case "Load Complete":
                            State_tb.BackColor = Color.Green;
                            break;
                        case "Ready To UnLoad":
                            State_tb.BackColor = Color.DarkOrange;
                            break;
                        case "UnLoad Complete":
                            State_tb.BackColor = Color.Blue;
                            break;
                        case "Alarm":
                            State_tb.BackColor = Color.Red;
                            //UpdateCurrentState();
                            break;
                    }

                }


            }
            catch
            {
                logger.Error("UpdateControllerStatus: Update fail.");
            }
        }

        public static void UpdateCurrentState(string State)
        {
            try
            {
                Form form = Application.OpenForms["FormMain"];

                if (form == null)
                    return;

                Button state_btn = form.Controls.Find("EQP_State", true).FirstOrDefault() as Button;

                if (state_btn == null)
                    return;

                if (state_btn.InvokeRequired)
                {
                    UpdateState ph = new UpdateState(UpdateCurrentState);
                    state_btn.BeginInvoke(ph, State);
                }
                else
                {
                    if (SignalSetting == null)
                    {
                        InitialSetting();
                    }
                    state_btn.Text = State;
                    Dictionary<string, string> Params = new Dictionary<string, string>();

                    var findSetting = from Setting in SignalSetting
                                      where Setting.eqpStatus.Equals(State.ToUpper()) && Setting.hasAlarm == (AlarmManagement.GetCurrentAlarm().Count!=0)
                                      select Setting;

                    if (findSetting.Count() != 0)
                    {
                        SignalTowerSetting each = findSetting.First();
                        if (!each.blue.Equals("BLINK"))
                        {
                            Params.Add("BLUE", each.blue);
                        }
                        else
                        {
                            RouteControl.Instance.DIO.SetBlink("BLUE", "True");
                        }
                        if (!each.green.Equals("BLINK"))
                        {
                            Params.Add("GREEN", each.green);
                        }
                        else
                        {
                            RouteControl.Instance.DIO.SetBlink("GREEN", "True");
                        }
                        if (!each.red.Equals("BLINK"))
                        {
                            Params.Add("RED", each.red);
                        }
                        else
                        {
                            RouteControl.Instance.DIO.SetBlink("RED", "True");
                        }
                        if (!each.orange.Equals("BLINK"))
                        {
                            Params.Add("ORANGE", each.orange);
                        }
                        else
                        {
                            RouteControl.Instance.DIO.SetBlink("ORANGE", "True");
                        }

                        RouteControl.Instance.DIO.SetIO(Params);
                    }

                }


            }
            catch (Exception e)
            {
                logger.Error("UpdateCurrentState: Update fail.:" + e.StackTrace);
            }
        }

    }
}
