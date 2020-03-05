using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using TransferControl.Config.Authorization;

namespace Adam.Menu.SystemSetting
{
    public partial class FormAccountSetting : Form
    {
        public FormAccountSetting()
        {
            InitializeComponent();
        }
        
       

 

        private string strUserID = string.Empty;
        private string strUserName = string.Empty;
        private string strUserGroup = string.Empty;

        private void FormAccountSetting_Load(object sender, EventArgs e)
        {
            StringBuilder sbAllGroup = new StringBuilder();
            StringBuilder sbLowerGroup = new StringBuilder();
            Form form = null;
            Label Signal = null;

            try
            {
                form = Application.OpenForms["FormMain"];
                Signal = form.Controls.Find("lbl_login_id", true).FirstOrDefault() as Label;
                strUserID = Signal.Text;
                Signal = form.Controls.Find("lbl_login_name", true).FirstOrDefault() as Label;
                strUserName = Signal.Text;
                Signal = form.Controls.Find("lbl_login_group", true).FirstOrDefault() as Label;
                strUserGroup = Signal.Text;

                trvAccount.Nodes.Clear();

                foreach (UserAccount each in UserAccount.GetList())
                {
                    trvAccount.Nodes.Add(each.userId, each.userId);
                }

                UIChange(strUserGroup);
                    
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void trvAccount_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }


        private void UIChange(string Mode)
        {
            try
            {
                switch (Mode)
                {
                    case "ADMIN":
                        btnCreateUser.Enabled = true;
                        btnModifyUser.Enabled = true;
                        btnChangePassword.Enabled = true;
                        break;

                    default:
                        btnCreateUser.Enabled = false;
                        btnModifyUser.Enabled = false;
                        btnChangePassword.Enabled = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                gbAccount.Enabled = true;
                trvAccount.Enabled = false;
                trvAccount.Refresh();
                trvAccount.SelectedNode = trvAccount.Nodes[0];

                txbUserID.Text = string.Empty;
                txbUserID.Enabled = true;
                txbUserID.BackColor = Color.LemonChiffon;
                txbUserName.Text = string.Empty;
                txbUserName.Enabled = true;
                txbUserName.BackColor = Color.LemonChiffon;
                cmbGroup.SelectedIndex = -1;
                cmbGroup.Enabled = true;
                cmbGroup.BackColor = Color.LemonChiffon;
                txbPassword.Text = string.Empty;
                txbPassword.Enabled = true;
                txbPassword.BackColor = Color.LemonChiffon;
                labUserPasswordNew.Enabled = false;
                labUserPasswordNewAgain.Enabled = false;
                txbPasswordNew.Enabled = false;
                txbPasswordNewAgain.Enabled = false;
                txbPasswordNew.BackColor = Color.White;
                txbPasswordNewAgain.BackColor = Color.White;
                chbActive.Checked = false;
                chbActive.Enabled = true;
                chbActive.BackColor = Color.LemonChiffon;

                btnCreateUser.BackColor = Color.RoyalBlue;
                btnModifyUser.BackColor = Color.Silver;
                btnChangePassword.BackColor = Color.Silver;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void btnModifyUser_Click(object sender, EventArgs e)
        {
            try
            {
                gbAccount.Enabled = true;
                trvAccount.Enabled = true;
                trvAccount.SelectedNode = trvAccount.Nodes[0];

                txbUserID.Text = string.Empty;
                txbUserID.Enabled = false;
                txbUserID.BackColor = Color.White;
                txbUserName.Text = string.Empty;
                txbUserName.Enabled = true;
                txbUserName.BackColor = Color.LemonChiffon;
                cmbGroup.SelectedIndex = -1;
                cmbGroup.Enabled = true;
                cmbGroup.BackColor = Color.LemonChiffon;
                txbPassword.Text = string.Empty;
                txbPassword.Enabled = false;
                txbPassword.BackColor = Color.White;
                labUserPasswordNew.Enabled = false;
                labUserPasswordNewAgain.Enabled = false;
                txbPasswordNew.Enabled = false;
                txbPasswordNewAgain.Enabled = false;
                txbPasswordNew.BackColor = Color.White;
                txbPasswordNewAgain.BackColor = Color.White;
                chbActive.Checked = false;
                chbActive.Enabled = true;
                chbActive.BackColor = Color.LemonChiffon;

                btnCreateUser.BackColor = Color.Silver;
                btnModifyUser.BackColor = Color.RoyalBlue;
                btnChangePassword.BackColor = Color.Silver;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                gbAccount.Enabled = true;
                trvAccount.Enabled = true;
                trvAccount.SelectedNode = trvAccount.Nodes[0];

                txbUserID.Text = string.Empty;
                txbUserID.Enabled = false;
                txbUserID.BackColor = Color.White;
                txbUserName.Text = string.Empty;
                txbUserName.Enabled = false;
                txbUserName.BackColor = Color.White;
                cmbGroup.SelectedIndex = -1;
                cmbGroup.Enabled = false;
                cmbGroup.BackColor = Color.White;
                txbPassword.Text = string.Empty;
                txbPassword.Enabled = false;
                txbPassword.BackColor = Color.White;
                labUserPasswordNew.Enabled = true;
                labUserPasswordNewAgain.Enabled = true;
                txbPasswordNew.Enabled = true;
                txbPasswordNewAgain.Enabled = true;
                txbPasswordNew.BackColor = Color.LemonChiffon;
                txbPasswordNewAgain.BackColor = Color.LemonChiffon;
                chbActive.Checked = false;
                chbActive.Enabled = false;
                chbActive.BackColor = SystemColors.Control;

                btnCreateUser.BackColor = Color.Silver;
                btnModifyUser.BackColor = Color.Silver;
                btnChangePassword.BackColor = Color.RoyalBlue;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
