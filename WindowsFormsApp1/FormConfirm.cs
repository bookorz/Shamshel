using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TransferControl.Comm;
using TransferControl.Config;
using TransferControl.Config.Authorization;

namespace GUI
{
    public partial class FormConfirm : Form
    {
        //ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        ILog log = LogManager.GetLogger("Database");
        public FormConfirm(string message)
        {
            InitializeComponent();
            if (SystemConfig.Get().Language.Equals("CN"))
            {
                message = message.Replace("生產", "生产");
                message = message.Replace("變更", "变更");
                message = message.Replace("確認", "确认");
                message = message.Replace("刪除", "删除");
                message = message.Replace("儲存", "储存");
            }
            lblMessage.Text = message;
            tbUserID.Text = Global.currentUser;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Boolean result = false;
            UserAccount usr = UserAccount.Verification(tbUserID.Text, tbPassword.Text);

            if (usr != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //this.DialogResult = DialogResult.Cancel; //不能加這行，會跳出
                MessageBox.Show("Password error.", "Check Fail");
                tbPassword.Focus();
                return;
            }

        }

        private void FormLogin_Activated(object sender, EventArgs e)
        {
            tbPassword.Focus();
        }

    }
}
