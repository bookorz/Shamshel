﻿using Adam.UI_Update.Barcode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TransferControl.Config;
using TransferControl.Engine;
using TransferControl.Management;

namespace Adam.Menu.Monitoring
{
    public partial class FormMonitoring4P : Adam.Menu.FormFrame
    {
        public FormMonitoring4P()
        {
            InitializeComponent();
        }

       
        private void LoadPort_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:
                    List<Job> JobList = (sender as DataGridView).DataSource as List<Job>;
                    
                    switch (JobList[e.RowIndex].NeedProcess)
                    {
                        case true:  
                            e.CellStyle.BackColor = Color.Green;
                            e.CellStyle.ForeColor = Color.White;
                            break;

                    }

                    switch (e.Value)
                    {
                        case "No wafer":
                            e.CellStyle.BackColor = Color.Gray;
                            e.CellStyle.ForeColor = Color.White;
                            break;
                        case "Crossed":
                        case "Undefined":
                        case "Double":
                            e.CellStyle.BackColor = Color.Red;
                            e.CellStyle.ForeColor = Color.White;
                            break;
                       

                    }
                    break;

            }
        }

        private void label142_Click(object sender, EventArgs e)
        {

        }

        private void label140_Click(object sender, EventArgs e)
        {

        }

        private void label138_Click(object sender, EventArgs e)
        {

        }

        private void label136_Click(object sender, EventArgs e)
        {

        }

        private void label134_Click(object sender, EventArgs e)
        {

        }

        private void label132_Click(object sender, EventArgs e)
        {

        }

        private void label130_Click(object sender, EventArgs e)
        {

        }

        private void label128_Click(object sender, EventArgs e)
        {

        }

        private void label126_Click(object sender, EventArgs e)
        {

        }

        private void label124_Click(object sender, EventArgs e)
        {

        }

        private void label122_Click(object sender, EventArgs e)
        {

        }

        private void label120_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label118_Click(object sender, EventArgs e)
        {

        }

        private void Slot_Click(object sender, EventArgs e)
        {

            string[] ary = (sender as Label).Name.Split('_');
            if (ary.Length == 3)
            {
                string Port = ary[0];
                string Slot = ary[2];
                Node p = NodeManagement.Get(Port);
                if (p != null)
                {
                    Job j;
                    if(p.JobList.TryGetValue(Slot,out j))
                    {
                        if(j.OCRImgPath.Equals("")&& j.OCR_M12_ImgPath.Equals("")&& j.OCR_T7_ImgPath.Equals(""))
                        {
                            MessageBox.Show("未找到OCR紀錄");
                        }
                        else
                        {
                            OCRResult form2 = new OCRResult(j);
                            form2.ShowDialog();
                            //// open image in default viewer
                            //System.Diagnostics.Process.Start(j.OCRImgPath);
                        }
                    }
                    else
                    {
                        MessageBox.Show("未找到Wafer");
                    }
                }

            }
        }

        private void OCR01_Pic_DoubleClick(object sender, EventArgs e)
        {
            OCRResult form2 = new OCRResult((sender as PictureBox).Tag as Job);
            form2.ShowDialog();
        }

        private void OCR02_Pic_DoubleClick(object sender, EventArgs e)
        {
            OCRResult form2 = new OCRResult((sender as PictureBox).Tag as Job);
            form2.ShowDialog();
        }

        private void OCR02Read_Tb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string Message = "";
            Transaction t = new Transaction();
            Node ocr2 = NodeManagement.Get("OCR02");
            t.Method = Transaction.Command.OCRType.ReadConfig;
            t.Value = "0";
            ocr2.SendCommand(t,out Message);
        }

        private void OCR02ReadT7_Tb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string Message = "";
            Transaction t = new Transaction();
            Node ocr2 = NodeManagement.Get("OCR02");
            t.Method = Transaction.Command.OCRType.ReadConfig;
            t.Value = "1";
            ocr2.SendCommand(t, out Message);
        }

        private void Ocr2_lb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string Message = "";
            Transaction t = new Transaction();
            Node ocr2 = NodeManagement.Get("OCR02");
            t.Method = Transaction.Command.OCRType.Read;
           
            ocr2.SendCommand(t, out Message);
        }

        private void Ocr1_lb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string Message = "";
            Transaction t = new Transaction();
            Node ocr1 = NodeManagement.Get("OCR01");
            t.Method = Transaction.Command.OCRType.Read;

            ocr1.SendCommand(t, out Message);
        }

        private void Node_Disable_Click(object sender, EventArgs e)
        {
            string NodeName = (sender as CheckBox).Name.Replace("_disable_ck", "");
            Node node = NodeManagement.Get(NodeName);
            node.SetEnable(!((sender as CheckBox).Checked));

        }

        private void FormMonitoring_Load(object sender, EventArgs e)
        {
            
            Form form = this;
            foreach (Node port in NodeManagement.GetLoadPortList())
            {

                for (int i = 1; i <= 25; i++)
                {
                    Label present = form.Controls.Find(port.Name + "_Slot_" + i.ToString(), true).FirstOrDefault() as Label;
                    if (present != null)
                    {
                        switch (port.CarrierType.ToUpper())
                        {
                            case "FOSB":
                            case "FOUP":
                                present.Visible = true;
                                break;
                            case "OPEN":
                                if (i > 13)
                                {
                                    present.Visible = false;
                                }
                                else
                                {
                                    present.Visible = true;
                                }
                                break;
                        }

                    }
                }


            }
            gbA1.Visible = NodeManagement.Get("ALIGNER01") != null ? true : false;
            gbA2.Visible = NodeManagement.Get("ALIGNER01") != null ? true : false;
            gbOCR1.Visible = NodeManagement.Get("OCR01") != null ? true : false;
            gbOCR2.Visible = NodeManagement.Get("OCR02") != null ? true : false;
            gbPort1.Visible = NodeManagement.Get("LOADPORT01") != null ? true : false;
            gbPort2.Visible = NodeManagement.Get("LOADPORT02") != null ? true : false;
            gbPort3.Visible = NodeManagement.Get("LOADPORT03") != null ? true : false;
            gbPort4.Visible = NodeManagement.Get("LOADPORT04") != null ? true : false;
            

        }

        private void Unload_btn(object sender, EventArgs e)
        {
            string PortName = ((Button)sender).Name.Substring(0, ((Button)sender).Name.IndexOf("_"));
            Node port = NodeManagement.Get(PortName);
            if (port == null)
            {
                MessageBox.Show(PortName+" not found");
            }
            if (port.Enable)
            {

                //FoupInfo foup = FoupInfo.Get(port.Name);
                //if (foup != null)
                //{
                //    foup.SetAllUnloadTime(DateTime.Now);
                //}
                //else
                //{
                //    foup = new Adam.FoupInfo(SystemConfig.Get().CurrentRecipe, Global.currentUser, port.FoupID);
                //    foreach (Job j in port.JobList.Values)
                //    {
                //        if (j.MapFlag && !j.ErrPosition)
                //        {
                //            int slot = Convert.ToInt16(j.Slot);
                //            foup.record[slot - 1] = new Adam.waferInfo(port.Name, port.FoupID, j.Slot, j.FromPort, j.FromFoupID, j.FromPortSlot, j.ToPort, j.ToFoupID, j.ToPortSlot);
                //            foup.record[slot - 1].SetStartTime(j.StartTime);
                //            foup.record[slot - 1].setM12(j.OCR_M12_Result);
                //            foup.record[slot - 1].setT7(j.OCR_T7_Result);
                //            foup.record[slot - 1].SetEndTime(j.EndTime);
                //            foup.record[slot - 1].SetLoadTime(port.LoadTime);
                //            foup.record[slot - 1].SetUnloadTime(DateTime.Now);
                //            foup.record[slot - 1].setM12Score(j.OCR_M12_Score);
                //            foup.record[slot - 1].setT7Score(j.OCR_T7_Score);
                //        }
                //    }
                //}
                //foup.Save();
                if (port.Foup_Placement)
                {
                    ((Button)sender).Enabled = false;
                    string TaskName = "LOADPORT_CLOSE_NOMAP";
                    string Message = "";
                    Dictionary<string, string> param1 = new Dictionary<string, string>();
                    param1.Add("@Target", port.Name);
                    TaskFlowManagement.CurrentProcessTask task = TaskFlowManagement.Excute(Guid.NewGuid().ToString(), (TaskFlowManagement.Command)Enum.Parse(typeof(TaskFlowManagement.Command), TaskName), param1);
                }
                else
                {
                    MessageBox.Show("No cassette detected!");
                }
            }
            else
            {
                MessageBox.Show(PortName+" is disabled");
            }
        }

        private void FoupID_Click(object sender, EventArgs e)
        {
            string PortName = ((TextBox)sender).Name.Substring(0, ((TextBox)sender).Name.IndexOf("_"));
            Node port = NodeManagement.Get(PortName);
            if (port.OrgSearchComplete && port.Foup_Placement)
            {
                Barcodeupdate.UpdateLoadport(PortName,true);
            }
            else
            {
                if (!port.OrgSearchComplete)
                {
                    MessageBox.Show("Please excute org search");
                }
                if (!port.Foup_Placement)
                {
                    MessageBox.Show("No Foup exist");
                }
                
            }
        }
    }
}
