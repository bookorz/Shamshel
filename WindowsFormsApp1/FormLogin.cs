using Adam.UI_Update.Authority;
using Adam.Util;
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
    public partial class FormLogin : Form
    {
        //ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        ILog log = LogManager.GetLogger("Database");
        public FormLogin()
        {
            InitializeComponent();
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
                //Console.Write("\n ID:" + rs["user_id"] + " Password:" + rs["password"] + " MD5:" + rs["md5"]);

               
               
                    AuthorityUpdate.UpdateLoginInfo(usr.userId, usr.userId, usr.groupId);
                    string msg = "{\"user_id\": " + usr.userId + ", \"name\": \"" + usr.userId + "\", \"action\": \"Login\"}";
                    log.Info(msg);
                    //SanwaUtil.addActionLog("Authority", "Login", user_id);// add record to log_system_action
                    //SanwaUtil.addActionLog("Authority", "Login", user_id, "使用者登錄");// add record to log_system_action
                    Global.currentUser = usr.userId;
                    this.DialogResult = DialogResult.OK;
                    //log.Debug(msg);
                    this.Close();
                
                
            }
            else
                {
                    //this.DialogResult = DialogResult.Cancel; //不能加這行，會跳出
                    MessageBox.Show("Please check data and login again.", "Login Fail");
                    return;
                }

        }

        private void FormLogin_Activated(object sender, EventArgs e)
        {
            tbUserID.Focus();
        }

        private void tbUserID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbUserID.Text.Trim().Equals(string.Empty))
                {
                    tbUserID.Focus();
                }

                if (tbUserID.Text.Trim().Equals(string.Empty))
                {
                    tbPassword.Focus();
                }

                btnLogin.Focus();
                btnLogin_Click(this, e);
            }
        }
    }
}
