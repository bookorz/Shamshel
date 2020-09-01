//using SorterControl.Management;
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
            
            foreach (Node each in NodeManagement.GetList())
            {
                if (each.Enable)
                {
                    string Message = "";
                    Transaction Txn = new Transaction();
                    Txn.Method = Transaction.Command.RobotType.Reset;
                    Txn.TaskId = "";
                    //NodeManagement.Get(group.First().NodeName).State = "Alarm";
                    each.SendCommand(Txn, out Message);
                }
            }
            
        }

        private void AlarmFrom_Load(object sender, EventArgs e)
        {
            AlarmUpdate.UpdateAlarmList(AlarmManagement.GetCurrent());
        }

        private void AlarmFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
    }
}
