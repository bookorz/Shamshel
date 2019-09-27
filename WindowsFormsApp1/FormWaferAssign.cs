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
using TransferControl.Config;
using TransferControl.Management;
using TransferControl.Operation;
using System.IO;
using TransferControl.Digital_IO.Config;

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
                            DstSlot.BackColor = Color.DarkGoldenrod;
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
            FormMain.RunMode = "SEMIAUTO";
            DIOUpdate.UpdateControlButton("Start_btn", false);
            DIOUpdate.UpdateControlButton("ManualTranfer_btn", false);
            DIOUpdate.UpdateControlButton("Stop_btn", true);
            DIOUpdate.UpdateControlButton("ALL_INIT_btn", false);
            DIOUpdate.UpdateControlButton("Mode_btn", false);
            if (AssignInfo.GetAssignList().Count != 0)
            {
                foreach (AssignInfo each in AssignInfo.GetAssignList())
                {
                    Node LD = NodeManagement.Get(each.FromPort);
                    LD.JobList[each.FromSlot].AssignPort(each.ToPort, each.ToSlot);
                }
                //tmp change config
                Recipe.Get(SystemConfig.Get().CurrentRecipe).robot1_speed = tbR1_speed.Text;
                Recipe.Get(SystemConfig.Get().CurrentRecipe).is_use_aligner1 = cbUseA1.Checked;
                Recipe.Get(SystemConfig.Get().CurrentRecipe).is_use_aligner2 = cbUseA2.Checked;
                Recipe.Get(SystemConfig.Get().CurrentRecipe).aligner1_speed = tbA1_speed.Text;
                Recipe.Get(SystemConfig.Get().CurrentRecipe).aligner2_speed = tbA2_speed.Text;
                Recipe.Get(SystemConfig.Get().CurrentRecipe).is_use_ocr_ttl = cbUseOcrTTL.Checked;
                Recipe.Get(SystemConfig.Get().CurrentRecipe).is_use_ocr_m12 = cbUseOcrM12.Checked;
                Recipe.Get(SystemConfig.Get().CurrentRecipe).is_use_ocr_t7 = cbUseOcrT7.Checked;
                Recipe.Get(SystemConfig.Get().CurrentRecipe).ocr_ttl_config = tbOcrTTL.Text;
                Recipe.Get(SystemConfig.Get().CurrentRecipe).ocr_m12_config = tbOcrM12.Text;
                Recipe.Get(SystemConfig.Get().CurrentRecipe).ocr_t7_config = tbOcrT7.Text;
                Recipe.Get(SystemConfig.Get().CurrentRecipe).ocr_check_Rule = cbOcrCheckRule.Text;

                if (!FormMain.xfe.Start(Source_cb.Text, true))
                {
                    MessageBox.Show("xfe.Start fail!");
                }
            }
            this.Close();
        }

        private void RenderSourceAssign()
        {
            foreach (AssignInfo each in AssignInfo.GetAssignList())
            {
                if (each.FromPort.Equals(Source_cb.Text))
                {
                    Label SrcSlot = this.Controls.Find("From_Slot_" + each.FromSlot, true).FirstOrDefault() as Label;
                    SrcSlot.BackColor = Color.Brown;
                }
                if (each.ToPort.Equals(Source_cb.Text))
                {
                    Label SrcSlot = this.Controls.Find("From_Slot_" + each.ToSlot, true).FirstOrDefault() as Label;
                    SrcSlot.BackColor = Color.DarkGoldenrod;
                    SrcSlot.Text = NodeManagement.Get(each.FromPort).JobList[each.FromSlot].Host_Job_Id;
                }
            }
        }
        private void RenderToAssign()
        {
            foreach (AssignInfo each in AssignInfo.GetAssignList())
            {
                if (each.ToPort.Equals(To_cb.Text))
                {
                    Label DstSlot = this.Controls.Find("To_Slot_" + each.ToSlot, true).FirstOrDefault() as Label;
                    DstSlot.BackColor = Color.DarkGoldenrod;
                    DstSlot.Text = NodeManagement.Get(each.FromPort).JobList[each.FromSlot].Host_Job_Id;
                }
                if (each.FromPort.Equals(To_cb.Text))
                {
                    Label DstSlot = this.Controls.Find("To_Slot_" + each.FromSlot, true).FirstOrDefault() as Label;
                    DstSlot.BackColor = Color.Brown;
                }
            }
        }

        private void Source_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssignInfo.ClearList();
            AssignRecipe_cb.Text = "";
            WaferAssignUpdate.UpdateNodesJob(Source_cb.Text, "From");
            WaferAssignUpdate.UpdateNodesJob(To_cb.Text, "To");
            RenderSourceAssign();


        }

        private void To_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssignInfo.ClearList();
            AssignRecipe_cb.Text = "";
            WaferAssignUpdate.UpdateNodesJob(Source_cb.Text, "From");
            WaferAssignUpdate.UpdateNodesJob(To_cb.Text, "To");
            RenderToAssign();
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
                if (!port.JobList.ContainsKey(slot))
                {
                    return;
                }
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
                                    if (To_cb.Text.Equals(assignData.ToPort))
                                    {
                                        DstSlot = this.Controls.Find("To_Slot_" + assignData.ToSlot, true).FirstOrDefault() as Label;
                                        DstSlot.Text = "No wafer";
                                        DstSlot.BackColor = Color.DimGray;
                                        DstSlot.ForeColor = Color.White;
                                    }
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
                                    if (Source_cb.Text.Equals(assignData.FromPort))
                                    {
                                        SrcSlot = this.Controls.Find("From_Slot_" + assignData.FromSlot, true).FirstOrDefault() as Label;
                                        SrcSlot.BackColor = Color.Green;
                                        SrcSlot.ForeColor = Color.White;
                                    }
                                    assignData.RemoveFromList();
                                }
                                else
                                {
                                    if (slotDataSrc != null)
                                    {//來源已選                                    
                                     //選取目的
                                        ((Label)sender).Text = slotDataSrc.Host_Job_Id;
                                        ((Label)sender).BackColor = Color.DarkGoldenrod;
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

        private void FormWaferAssign_Load(object sender, EventArgs e)
        {
            if (Global.userGroup.Equals("OP"))
            {
                tbR1_speed.Enabled = false;
                tbA1_speed.Enabled = false;
                tbA2_speed.Enabled = false;
            }
            AssignInfo.ClearList();
            Node Target;
            if ((Target = NodeManagement.Get("ROBOT01")) != null)
            {
                tbR1_speed.Text = Recipe.Get(SystemConfig.Get().CurrentRecipe).robot1_speed;
            }
            if ((Target = NodeManagement.Get("ALIGNER01")) != null)
            {
                cbUseA1.Checked = !Target.ByPass;
                tbA1_speed.Text = Recipe.Get(SystemConfig.Get().CurrentRecipe).aligner1_speed;
            }
            else
            {
                gbA1.Visible = false;
            }
            if ((Target = NodeManagement.Get("ALIGNER02")) != null)
            {
                cbUseA2.Checked = !Target.ByPass;
                tbA2_speed.Text = Recipe.Get(SystemConfig.Get().CurrentRecipe).aligner2_speed;
            }
            else
            {
                gbA2.Visible = false;
            }
            if (NodeManagement.Get("OCR01") != null && NodeManagement.Get("OCR02") != null)
            {
                cbUseOcrTTL.Checked = Recipe.Get(SystemConfig.Get().CurrentRecipe).is_use_ocr_ttl;
                cbUseOcrM12.Checked = Recipe.Get(SystemConfig.Get().CurrentRecipe).is_use_ocr_m12;
                cbUseOcrT7.Checked = Recipe.Get(SystemConfig.Get().CurrentRecipe).is_use_ocr_t7;
                tbOcrTTL.Text = Recipe.Get(SystemConfig.Get().CurrentRecipe).ocr_ttl_config;
                tbOcrM12.Text = Recipe.Get(SystemConfig.Get().CurrentRecipe).ocr_m12_config;
                tbOcrT7.Text = Recipe.Get(SystemConfig.Get().CurrentRecipe).ocr_t7_config;
                cbOcrCheckRule.Text = Recipe.Get(SystemConfig.Get().CurrentRecipe).ocr_check_Rule;
            }
            else
            {
                gbOCR.Visible = false;
            }
            if (!Directory.Exists("assign_recipe"))
            {
                Directory.CreateDirectory("assign_recipe");
            }
            foreach (string each in Directory.GetFiles("assign_recipe"))
            {
                AssignRecipe_cb.Items.Add(Path.GetFileNameWithoutExtension(each));
            }
            AssignRecipe_cb.Text = "";
        }

        private void AssignRecipe_Save_Click(object sender, EventArgs e)
        {
            if (AssignRecipe_cb.Text.Trim().Equals(""))
            {
                MessageBox.Show("Name is empty", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists("assign_recipe"))
            {
                Directory.CreateDirectory("assign_recipe");
            }
            ConfigTool<AssignInfo> SysCfg = new ConfigTool<AssignInfo>();
            SysCfg.WriteFileByList("assign_recipe/" + AssignRecipe_cb.Text.Trim() + ".json", AssignInfo.GetAssignList());
            AssignRecipe_cb.Items.Clear();
            foreach (string each in Directory.GetFiles("assign_recipe"))
            {
                AssignRecipe_cb.Items.Add(Path.GetFileNameWithoutExtension(each));
            }
            AssignRecipe_cb.Text = "";
            MessageBox.Show("ok", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AssignRecipe_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AssignRecipe_cb.Text.Trim().Equals(""))
            {
                return;
            }
            ConfigTool<AssignInfo> SysCfg = new ConfigTool<AssignInfo>();
            List<AssignInfo> Content = SysCfg.ReadFileByList("assign_recipe/" + AssignRecipe_cb.Text.Trim() + ".json");
            AssignInfo.ClearList();
            Node Src = NodeManagement.Get(Source_cb.Text);
            Node Dst = NodeManagement.Get(To_cb.Text);
            if (Src == null)
            {
                MessageBox.Show("Source port is empty", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Dst == null)
            {
                MessageBox.Show("Destination port is empty", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            WaferAssignUpdate.UpdateNodesJob(Source_cb.Text, "From");
            WaferAssignUpdate.UpdateNodesJob(To_cb.Text, "To");
            foreach (AssignInfo each in Content)
            {
                if (!Src.JobList[Convert.ToInt16(each.FromSlot).ToString()].MapFlag || Src.JobList[Convert.ToInt16(each.FromSlot).ToString()].ErrPosition)
                {
                    MessageBox.Show("Source slot " + each.FromSlot + " is empty", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Dst.JobList[Convert.ToInt16(each.ToSlot).ToString()].MapFlag || Dst.JobList[Convert.ToInt16(each.ToSlot).ToString()].ErrPosition)
                {
                    MessageBox.Show("Destination slot " + each.ToSlot + " is not empty", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            foreach (AssignInfo each in Content)
            {
                Label SrcSlot = this.Controls.Find("From_Slot_" + each.FromSlot, true).FirstOrDefault() as Label;
                SrcSlot.BackColor = Color.Brown;
                SrcSlot.ForeColor = Color.White;

                Label DstSlot = this.Controls.Find("To_Slot_" + each.ToSlot, true).FirstOrDefault() as Label;
                DstSlot.BackColor = Color.DarkGoldenrod;
                DstSlot.ForeColor = Color.White;
                DstSlot.Text = Src.JobList[Convert.ToInt16(each.FromSlot).ToString()].Host_Job_Id;
                each.AddToList();
            }
        }

        private void AssignRecipe_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (AssignRecipe_cb.Text.Trim().Equals(""))
            {
                MessageBox.Show("Name is empty", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            File.Delete("assign_recipe/" + AssignRecipe_cb.Text.Trim() + ".json");

            AssignRecipe_cb.Items.Clear();
            foreach (string each in Directory.GetFiles("assign_recipe"))
            {
                AssignRecipe_cb.Items.Add(Path.GetFileNameWithoutExtension(each));
            }
            AssignRecipe_cb.Text = "";
            AssignInfo.ClearList();
            WaferAssignUpdate.UpdateNodesJob(Source_cb.Text, "From");
            WaferAssignUpdate.UpdateNodesJob(To_cb.Text, "To");
            MessageBox.Show("ok", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
