using Adam.Util;
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
    public partial class FormChgPwd : Form
    {
        public FormChgPwd()
        {
            InitializeComponent();
        }
        public FormChgPwd(string userid)
        {
            InitializeComponent();
            tbUserID.Text = userid;
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (tbNewPwd.Text.Trim().Equals(""))
            {
                MessageBox.Show("New Password is empty!", "Error");
            }
            else if (!tbNewPwd.Text.Equals(tbConfirmPwd.Text))
            {
                MessageBox.Show("New password and confirm password does not match!", "Error");
            }
            else if (!checkOldPwd(tbUserID.Text, tbOldPwd.Text))
            {
                MessageBox.Show("Old password do not match.", "Check Password Fail");
            }
            else
            {
                UserAccount usr = UserAccount.Get(tbUserID.Text.Trim());
                usr.password = tbNewPwd.Text.Trim();
                UserAccount.Update(usr);

                //SanwaUtil.addActionLog("GUI.FormChgPwd", "Change password", Global.currentUser, "變更本人密碼");
                MessageBox.Show("Password has been changed!!", "Success");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private bool checkOldPwd(string userid, string password)
        {
            Boolean result = false;

            if (UserAccount.Verification(userid, password) != null)
            {
                result = true;
            }
            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
