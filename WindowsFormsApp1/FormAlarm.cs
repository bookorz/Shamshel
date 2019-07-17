﻿//using SorterControl.Management;
using Adam.UI_Update.Alarm;
using Adam.UI_Update.Monitoring;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferControl.Management;

namespace Adam
{
    public partial class FormAlarm : Form
    {
        public FormAlarm()
        {
            InitializeComponent();
        }

        private void ResetAll_bt_Click(object sender, EventArgs e)
        {
            Transaction Txn;

            foreach (AlarmInfo eachA in AlarmManagement.GetAll())
            {
                if (!eachA.NeedReset)
                {
                    AlarmManagement.Remove(eachA);
                }
            }

            

            //foreach (Node node in NodeManagement.GetList())
            //{
            //    node.State = node.LastState;
            //}

            var NodeList = AlarmManagement.GetAll().GroupBy(t => t.NodeName);
            foreach (var group in NodeList)
            {
                string Message = "";
                Txn = new Transaction();
                Txn.Method = Transaction.Command.RobotType.Reset;
                Txn.TaskId = "";
                //NodeManagement.Get(group.First().NodeName).State = "Alarm";
                NodeManagement.Get(group.First().NodeName).SendCommand(Txn, out Message);
                AlarmManagement.Remove(group.First().NodeName);
            }
            //NodeStatusUpdate.UpdateCurrentState("Idle");
            AlarmUpdate.UpdateAlarmList(AlarmManagement.GetAll());
        }

        private void AlarmFrom_Load(object sender, EventArgs e)
        {
            AlarmUpdate.UpdateAlarmList(AlarmManagement.GetAll());
        }

        private void AlarmFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
    }
}
