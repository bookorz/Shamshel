namespace Adam.Menu.SystemSetting
{
    partial class FormAccountSetting
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccountSetting));
            this.palMenu = new System.Windows.Forms.Panel();
            this.tlpAccountMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnModifyUser = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.tlpAccount = new System.Windows.Forms.TableLayoutPanel();
            this.palContainer = new System.Windows.Forms.Panel();
            this.gbAccount = new System.Windows.Forms.GroupBox();
            this.tlpAccountCreate = new System.Windows.Forms.TableLayoutPanel();
            this.gbAccountCondition = new System.Windows.Forms.GroupBox();
            this.trvAccount = new System.Windows.Forms.TreeView();
            this.gbAccountSetting = new System.Windows.Forms.GroupBox();
            this.tlpAccountSetting = new System.Windows.Forms.TableLayoutPanel();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.labUserID = new System.Windows.Forms.Label();
            this.labUserName = new System.Windows.Forms.Label();
            this.labUserGroup = new System.Windows.Forms.Label();
            this.labUserPassword = new System.Windows.Forms.Label();
            this.chbActive = new System.Windows.Forms.CheckBox();
            this.txbUserID = new System.Windows.Forms.TextBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.labUserPasswordNewAgain = new System.Windows.Forms.Label();
            this.labUserPasswordNew = new System.Windows.Forms.Label();
            this.txbPasswordNew = new System.Windows.Forms.TextBox();
            this.txbPasswordNewAgain = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.palMenu.SuspendLayout();
            this.tlpAccountMenu.SuspendLayout();
            this.tlpAccount.SuspendLayout();
            this.palContainer.SuspendLayout();
            this.gbAccount.SuspendLayout();
            this.tlpAccountCreate.SuspendLayout();
            this.gbAccountCondition.SuspendLayout();
            this.gbAccountSetting.SuspendLayout();
            this.tlpAccountSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // palMenu
            // 
            this.palMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.palMenu.Controls.Add(this.tlpAccountMenu);
            resources.ApplyResources(this.palMenu, "palMenu");
            this.palMenu.Name = "palMenu";
            // 
            // tlpAccountMenu
            // 
            resources.ApplyResources(this.tlpAccountMenu, "tlpAccountMenu");
            this.tlpAccountMenu.Controls.Add(this.btnModifyUser, 0, 0);
            this.tlpAccountMenu.Controls.Add(this.btnCreateUser, 0, 0);
            this.tlpAccountMenu.Controls.Add(this.btnChangePassword, 2, 0);
            this.tlpAccountMenu.Name = "tlpAccountMenu";
            // 
            // btnModifyUser
            // 
            this.btnModifyUser.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.btnModifyUser, "btnModifyUser");
            this.btnModifyUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModifyUser.FlatAppearance.BorderSize = 2;
            this.btnModifyUser.Name = "btnModifyUser";
            this.btnModifyUser.UseVisualStyleBackColor = false;
            this.btnModifyUser.Click += new System.EventHandler(this.btnModifyUser_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.btnCreateUser, "btnCreateUser");
            this.btnCreateUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateUser.FlatAppearance.BorderSize = 2;
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Silver;
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.btnChangePassword, "btnChangePassword");
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // tlpAccount
            // 
            resources.ApplyResources(this.tlpAccount, "tlpAccount");
            this.tlpAccount.Controls.Add(this.palMenu, 0, 0);
            this.tlpAccount.Controls.Add(this.palContainer, 0, 1);
            this.tlpAccount.Name = "tlpAccount";
            // 
            // palContainer
            // 
            this.palContainer.Controls.Add(this.gbAccount);
            resources.ApplyResources(this.palContainer, "palContainer");
            this.palContainer.Name = "palContainer";
            // 
            // gbAccount
            // 
            this.gbAccount.Controls.Add(this.tlpAccountCreate);
            resources.ApplyResources(this.gbAccount, "gbAccount");
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.TabStop = false;
            // 
            // tlpAccountCreate
            // 
            resources.ApplyResources(this.tlpAccountCreate, "tlpAccountCreate");
            this.tlpAccountCreate.Controls.Add(this.gbAccountCondition, 0, 0);
            this.tlpAccountCreate.Controls.Add(this.gbAccountSetting, 1, 0);
            this.tlpAccountCreate.Name = "tlpAccountCreate";
            // 
            // gbAccountCondition
            // 
            this.gbAccountCondition.Controls.Add(this.trvAccount);
            resources.ApplyResources(this.gbAccountCondition, "gbAccountCondition");
            this.gbAccountCondition.Name = "gbAccountCondition";
            this.gbAccountCondition.TabStop = false;
            // 
            // trvAccount
            // 
            resources.ApplyResources(this.trvAccount, "trvAccount");
            this.trvAccount.Name = "trvAccount";
            this.trvAccount.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvAccount_AfterSelect);
            // 
            // gbAccountSetting
            // 
            this.gbAccountSetting.Controls.Add(this.tlpAccountSetting);
            this.gbAccountSetting.Controls.Add(this.btnSave);
            resources.ApplyResources(this.gbAccountSetting, "gbAccountSetting");
            this.gbAccountSetting.Name = "gbAccountSetting";
            this.gbAccountSetting.TabStop = false;
            // 
            // tlpAccountSetting
            // 
            resources.ApplyResources(this.tlpAccountSetting, "tlpAccountSetting");
            this.tlpAccountSetting.Controls.Add(this.txbPassword, 1, 3);
            this.tlpAccountSetting.Controls.Add(this.txbUserName, 1, 1);
            this.tlpAccountSetting.Controls.Add(this.labUserID, 0, 0);
            this.tlpAccountSetting.Controls.Add(this.labUserName, 0, 1);
            this.tlpAccountSetting.Controls.Add(this.labUserGroup, 0, 2);
            this.tlpAccountSetting.Controls.Add(this.labUserPassword, 0, 3);
            this.tlpAccountSetting.Controls.Add(this.chbActive, 1, 8);
            this.tlpAccountSetting.Controls.Add(this.txbUserID, 1, 0);
            this.tlpAccountSetting.Controls.Add(this.cmbGroup, 1, 2);
            this.tlpAccountSetting.Controls.Add(this.labUserPasswordNewAgain, 0, 6);
            this.tlpAccountSetting.Controls.Add(this.labUserPasswordNew, 0, 5);
            this.tlpAccountSetting.Controls.Add(this.txbPasswordNew, 1, 5);
            this.tlpAccountSetting.Controls.Add(this.txbPasswordNewAgain, 1, 6);
            this.tlpAccountSetting.Name = "tlpAccountSetting";
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txbPassword, "txbPassword");
            this.txbPassword.Name = "txbPassword";
            // 
            // txbUserName
            // 
            this.txbUserName.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txbUserName, "txbUserName");
            this.txbUserName.Name = "txbUserName";
            // 
            // labUserID
            // 
            resources.ApplyResources(this.labUserID, "labUserID");
            this.labUserID.Name = "labUserID";
            // 
            // labUserName
            // 
            resources.ApplyResources(this.labUserName, "labUserName");
            this.labUserName.Name = "labUserName";
            // 
            // labUserGroup
            // 
            resources.ApplyResources(this.labUserGroup, "labUserGroup");
            this.labUserGroup.Name = "labUserGroup";
            // 
            // labUserPassword
            // 
            resources.ApplyResources(this.labUserPassword, "labUserPassword");
            this.labUserPassword.Name = "labUserPassword";
            // 
            // chbActive
            // 
            resources.ApplyResources(this.chbActive, "chbActive");
            this.chbActive.Name = "chbActive";
            this.chbActive.UseVisualStyleBackColor = true;
            // 
            // txbUserID
            // 
            this.txbUserID.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txbUserID, "txbUserID");
            this.txbUserID.Name = "txbUserID";
            // 
            // cmbGroup
            // 
            this.cmbGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGroup.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.cmbGroup, "cmbGroup");
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Name = "cmbGroup";
            // 
            // labUserPasswordNewAgain
            // 
            resources.ApplyResources(this.labUserPasswordNewAgain, "labUserPasswordNewAgain");
            this.labUserPasswordNewAgain.Name = "labUserPasswordNewAgain";
            // 
            // labUserPasswordNew
            // 
            resources.ApplyResources(this.labUserPasswordNew, "labUserPasswordNew");
            this.labUserPasswordNew.Name = "labUserPasswordNew";
            // 
            // txbPasswordNew
            // 
            this.txbPasswordNew.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txbPasswordNew, "txbPasswordNew");
            this.txbPasswordNew.Name = "txbPasswordNew";
            // 
            // txbPasswordNewAgain
            // 
            this.txbPasswordNewAgain.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txbPasswordNewAgain, "txbPasswordNewAgain");
            this.txbPasswordNewAgain.Name = "txbPasswordNewAgain";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormAccountSetting
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tlpAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccountSetting";
            this.Load += new System.EventHandler(this.FormAccountSetting_Load);
            this.palMenu.ResumeLayout(false);
            this.tlpAccountMenu.ResumeLayout(false);
            this.tlpAccount.ResumeLayout(false);
            this.palContainer.ResumeLayout(false);
            this.gbAccount.ResumeLayout(false);
            this.tlpAccountCreate.ResumeLayout(false);
            this.gbAccountCondition.ResumeLayout(false);
            this.gbAccountSetting.ResumeLayout(false);
            this.tlpAccountSetting.ResumeLayout(false);
            this.tlpAccountSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel palMenu;
        private System.Windows.Forms.TableLayoutPanel tlpAccountMenu;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.TableLayoutPanel tlpAccount;
        private System.Windows.Forms.Panel palContainer;
        private System.Windows.Forms.GroupBox gbAccount;
        private System.Windows.Forms.TableLayoutPanel tlpAccountCreate;
        private System.Windows.Forms.GroupBox gbAccountCondition;
        private System.Windows.Forms.TreeView trvAccount;
        private System.Windows.Forms.GroupBox gbAccountSetting;
        private System.Windows.Forms.TableLayoutPanel tlpAccountSetting;
        private System.Windows.Forms.Label labUserID;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Label labUserPassword;
        private System.Windows.Forms.Label labUserGroup;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.CheckBox chbActive;
        private System.Windows.Forms.TextBox txbUserID;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labUserPasswordNewAgain;
        private System.Windows.Forms.Label labUserPasswordNew;
        private System.Windows.Forms.TextBox txbPasswordNew;
        private System.Windows.Forms.TextBox txbPasswordNewAgain;
        private System.Windows.Forms.Button btnModifyUser;
        private System.Windows.Forms.Button btnChangePassword;
    }
}
