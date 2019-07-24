using Adam.UI_Update.Layout;
using Adam.UI_Update.WaferMapping;
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
using TransferControl.Operation;

namespace Adam
{
    public partial class FormWaferAssign : Form
    {
        class AssignInfo
        {
            private static List<AssignInfo> assignList = new List<AssignInfo>();
            public string FromPort = "";
            public string FromSlot = "";
            public string ToPort = "";
            public string ToSlot = "";

            public void AddToList()
            {
                assignList.Add(this);
            }

            public void RemoveFromList()
            {
                assignList.Remove(this);
            }

            public static void ClearList()
            {
                assignList.Clear();
            }
            public static List<AssignInfo> GetAssignList()
            {
                return assignList;
            }

            public static AssignInfo SearchByFrom(string FromPort, string FromSlot)
            {
                AssignInfo result = null;
                var Assigns = from each in assignList
                              where each.FromPort.Equals(FromPort) && each.FromSlot.Equals(FromSlot)
                              select each;
                if (Assigns.Count() != 0)
                {
                    result = Assigns.First();
                }
                return result;
            }
            public static AssignInfo SearchByTo(string ToPort, string ToSlot)
            {
                AssignInfo result = null;
                var Assigns = from each in assignList
                              where each.ToPort.Equals(ToPort) && each.ToSlot.Equals(ToSlot)
                              select each;
                if (Assigns.Count() != 0)
                {
                    result = Assigns.First();
                }
                return result;
            }
        }

        public FormWaferAssign()
        {
            InitializeComponent();
        }

        private void AutoAssign_btn_Click(object sender, EventArgs e)
        {
            Node fromPort = NodeManagement.Get(Source_cb.Text);
            Node toPort = NodeManagement.Get(To_cb.Text);
            if (fromPort != null && toPort != null)
            {
                var from_Jobs = (from wafer in fromPort.JobList.Values
                                 where wafer.MapFlag && !wafer.ErrPosition
                                 select wafer).OrderBy(x => Convert.ToInt16(x.Slot));

                var to_Jobs = (from wafer in toPort.JobList.Values
                               where !wafer.MapFlag && !wafer.ErrPosition
                               select wafer).OrderBy(x => Convert.ToInt16(x.Slot));
                if (rbTopDown.Checked)
                {
                    to_Jobs = (from wafer in toPort.JobList.Values
                               where !wafer.MapFlag && !wafer.ErrPosition
                               select wafer).OrderByDescending(x => Convert.ToInt16(x.Slot));
                }
                foreach (Job wafer in from_Jobs)
                {
                    if (AssignInfo.SearchByFrom(wafer.Position, wafer.Slot) != null)
                    {
                        continue;
                    }
                    foreach (Job emptySlot in to_Jobs)
                    {
                        if (!emptySlot.Slot.Equals(wafer.Slot) && rbSlotToSlot.Checked)
                        {
                            continue;
                        }
                        if (AssignInfo.SearchByTo(emptySlot.Position, emptySlot.Slot) == null)
                        {
                            Label SrcSlot = this.Controls.Find("From_Slot_" + wafer.Slot, true).FirstOrDefault() as Label;
                            SrcSlot.BackColor = Color.Brown;

                            Label DstSlot = this.Controls.Find("To_Slot_" + emptySlot.Slot, true).FirstOrDefault() as Label;
                            DstSlot.Text = wafer.Host_Job_Id;
                            DstSlot.BackColor = Color.Brown;
                            AssignInfo newAssign = new AssignInfo();
                            newAssign.FromPort = wafer.Position;
                            newAssign.FromSlot = wafer.Slot;
                            newAssign.ToPort = emptySlot.Position;
                            newAssign.ToSlot = emptySlot.Slot;
                            newAssign.AddToList();
                            break;
                        }
                    }
                }
            }
        }

        private void Excute_btn_Click(object sender, EventArgs e)
        {
            if (XfeCrossZone.Running)
            {
                MessageBox.Show("Error: still runnung.");
                return;
            }
            DIOUpdate.UpdateControlButton("Start_btn", false);
            DIOUpdate.UpdateControlButton("ManualTranfer_btn", false);
            DIOUpdate.UpdateControlButton("Stop_btn", true);
            DIOUpdate.UpdateControlButton("ALL_INIT_btn", false);
            DIOUpdate.UpdateControlButton("Mode_btn", false);
            if (AssignInfo.GetAssignList().Count != 0)
            {
                foreach(AssignInfo each in AssignInfo.GetAssignList())
                {
                    Node LD = NodeManagement.Get(each.FromPort);
                    LD.JobList[each.FromSlot].AssignPort(each.ToPort, each.ToSlot);
                }
                if (!FormMain.xfe.Start(Source_cb.Text))
                {
                    MessageBox.Show("xfe.Start fail!");
                }
            }
            this.Close();
        }

        private void Source_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            WaferAssignUpdate.UpdateNodesJob(Source_cb.Text, "From");
            WaferAssignUpdate.UpdateNodesJob(To_cb.Text, "To");
            AssignInfo.ClearList();
        }

        private void To_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            WaferAssignUpdate.UpdateNodesJob(Source_cb.Text, "From");
            WaferAssignUpdate.UpdateNodesJob(To_cb.Text, "To");
            AssignInfo.ClearList();
        }
        Job slotDataSrc = null;

        private void SlotSelect(object sender, EventArgs e)
        {
            string[] SlotInfo = ((Label)sender).Name.Split(new string[] { "_" }, StringSplitOptions.None);
            string type = SlotInfo[0];
            string slot = SlotInfo[2];
            Label SrcSlot;
            Label DstSlot;
            Node port = null;
            switch (type)
            {
                case "From":
                    port = NodeManagement.Get(Source_cb.Text);
                    break;
                case "To":
                    port = NodeManagement.Get(To_cb.Text);
                    break;
            }
            if (port != null)
            {
                Job slotData = port.JobList[slot];
                if (slotData != null)
                {
                    switch (type)
                    {
                        case "From":
                            if (slotData.MapFlag && !slotData.ErrPosition)
                            {
                                AssignInfo assignData = AssignInfo.SearchByFrom(slotData.Position, slotData.Slot);
                                if (assignData != null)
                                {//取消選擇已選的Slot                   
                                    DstSlot = this.Controls.Find("To_Slot_" + assignData.ToSlot, true).FirstOrDefault() as Label;
                                    DstSlot.Text = "No wafer";
                                    DstSlot.BackColor = Color.DimGray;
                                    DstSlot.ForeColor = Color.White;

                                    ((Label)sender).BackColor = Color.Green;
                                    ((Label)sender).ForeColor = Color.White;
                                    assignData.RemoveFromList();
                                }
                                else
                                {
                                    if (slotDataSrc != null)
                                    {//已選來源
                                     //取消選取來源


                                        if (slotData.Equals(slotDataSrc))
                                        {
                                            ((Label)sender).BackColor = Color.Green;
                                            ((Label)sender).ForeColor = Color.White;
                                            slotDataSrc = null;
                                        }
                                        else
                                        {
                                            SrcSlot = this.Controls.Find("From_Slot_" + slotDataSrc.Slot, true).FirstOrDefault() as Label;
                                            SrcSlot.BackColor = Color.Green;
                                            SrcSlot.ForeColor = Color.White;
                                            slotDataSrc = slotData;//更新選取來源
                                            ((Label)sender).BackColor = Color.Brown;
                                        }

                                    }
                                    else
                                    {//還沒選來源
                                        slotDataSrc = slotData;//更新選取來源
                                        ((Label)sender).BackColor = Color.Brown;

                                    }
                                }
                            }

                            break;
                        case "To":
                            if (!slotData.MapFlag && !slotData.ErrPosition)
                            {
                                AssignInfo assignData = AssignInfo.SearchByTo(slotData.Position, slotData.Slot);
                                if (assignData != null)
                                {//取消選擇已選的Slot                   
                                    ((Label)sender).Text = "No wafer";
                                    ((Label)sender).BackColor = Color.DimGray;
                                    ((Label)sender).ForeColor = Color.White;
                                    SrcSlot = this.Controls.Find("From_Slot_" + assignData.FromSlot, true).FirstOrDefault() as Label;
                                    SrcSlot.BackColor = Color.Green;
                                    SrcSlot.ForeColor = Color.White;
                                    assignData.RemoveFromList();
                                }
                                else
                                {
                                    if (slotDataSrc != null)
                                    {//來源已選                                    
                                     //選取目的
                                        ((Label)sender).Text = slotDataSrc.Host_Job_Id;
                                        ((Label)sender).BackColor = Color.Brown;
                                        AssignInfo newAssign = new AssignInfo();
                                        newAssign.FromPort = slotDataSrc.Position;
                                        newAssign.FromSlot = slotDataSrc.Slot;
                                        newAssign.ToPort = slotData.Position;
                                        newAssign.ToSlot = slotData.Slot;
                                        newAssign.AddToList();
                                        slotDataSrc = null;
                                    }
                                }
                            }

                            break;
                    }
                }

            }
        }
    }
}
