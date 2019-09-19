using Adam.UI_Update.DifferentialMonitor;
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
using TransferControl.Config;
using TransferControl.Management;

namespace Adam.Menu.DifferentialMonitor
{
    public partial class FormDifferentialMonitor : Adam.Menu.FormFrame
    {

       

        public FormDifferentialMonitor()
        {
            InitializeComponent();
        }

        private void FFU_Start_btn_Click(object sender, EventArgs e)
        {
            Node ffu = NodeManagement.Get("FFU01");
            if (ffu != null)
            {
                if (ffu.Enable)
                {
                    Dictionary<string, string> param1 = new Dictionary<string, string>();
                    param1.Add("@Target", ffu.Name);

                    TaskFlowManagement.Excute(Guid.NewGuid().ToString(), TaskFlowManagement.Command.FFU_START, param1);
                }
            }
        }

        private void FFU_Stop_btn_Click(object sender, EventArgs e)
        {
            Node ffu = NodeManagement.Get("FFU01");
            if (ffu != null)
            {
                if (ffu.Enable)
                {
                    Dictionary<string, string> param1 = new Dictionary<string, string>();
                    param1.Add("@Target", ffu.Name);

                    TaskFlowManagement.Excute(Guid.NewGuid().ToString(), TaskFlowManagement.Command.FFU_STOP, param1);
                }
            }
        }

        private void FFU_AlarmBypass_btn_Click(object sender, EventArgs e)
        {
            Node ffu = NodeManagement.Get("FFU01");
            if (ffu != null)
            {
                if (ffu.Enable)
                {
                    Dictionary<string, string> param1 = new Dictionary<string, string>();
                    param1.Add("@Target", ffu.Name);

                    TaskFlowManagement.Excute(Guid.NewGuid().ToString(), TaskFlowManagement.Command.FFU_ALARM_BYPASS, param1);
                }
            }
        }

        private void FFU_Set_btn_Click(object sender, EventArgs e)
        {
            int rpm = 0;
            if(!int.TryParse(FFU_RPM_tb.Text,out rpm))
            {
                MessageBox.Show("Please input numeric!");
                return;
            }
            Node ffu = NodeManagement.Get("FFU01");
            if (ffu != null)
            {
                if (ffu.Enable)
                {
                    Dictionary<string, string> param1 = new Dictionary<string, string>();
                    param1.Add("@Target", ffu.Name);
                    param1.Add("@Value", FFU_RPM_tb.Text);
                    TaskFlowManagement.Excute(Guid.NewGuid().ToString(), TaskFlowManagement.Command.FFU_SET_SPEED, param1);
                }
            }
        }
    }
}
