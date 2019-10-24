namespace Adam.Menu.SystemSetting
{
    partial class FormSysConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSysConfig));
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPreMapping = new System.Windows.Forms.CheckBox();
            this.cbMappingDataCheck = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbNoticeProcFin = new System.Windows.Forms.ComboBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.cbNoticeInitFin = new System.Windows.Forms.ComboBox();
            this.cbFakeData = new System.Windows.Forms.CheckBox();
            this.cbChkBypass = new System.Windows.Forms.CheckBox();
            this.tbOcr2Exe = new System.Windows.Forms.TextBox();
            this.tbOcr1Exe = new System.Windows.Forms.TextBox();
            this.tbOcr2ImgBak = new System.Windows.Forms.TextBox();
            this.tbOcr1ImgBak = new System.Windows.Forms.TextBox();
            this.tbTxfLogPath = new System.Windows.Forms.TextBox();
            this.cbRecipe = new System.Windows.Forms.ComboBox();
            this.tbEqpId = new System.Windows.Forms.TextBox();
            this.tbSysMode = new System.Windows.Forms.TextBox();
            this.tbOcr2ImgSrc = new System.Windows.Forms.TextBox();
            this.tbConnString = new System.Windows.Forms.TextBox();
            this.tbOcr1ImgSrc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Setting_Port_lb = new System.Windows.Forms.Label();
            this.setting_Address_lb = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGray;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPreMapping);
            this.groupBox2.Controls.Add(this.cbMappingDataCheck);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbNoticeProcFin);
            this.groupBox2.Controls.Add(this.cbLanguage);
            this.groupBox2.Controls.Add(this.cbNoticeInitFin);
            this.groupBox2.Controls.Add(this.cbFakeData);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.cbChkBypass);
            this.groupBox2.Controls.Add(this.tbOcr2Exe);
            this.groupBox2.Controls.Add(this.tbOcr1Exe);
            this.groupBox2.Controls.Add(this.tbOcr2ImgBak);
            this.groupBox2.Controls.Add(this.tbOcr1ImgBak);
            this.groupBox2.Controls.Add(this.tbTxfLogPath);
            this.groupBox2.Controls.Add(this.cbRecipe);
            this.groupBox2.Controls.Add(this.tbEqpId);
            this.groupBox2.Controls.Add(this.tbSysMode);
            this.groupBox2.Controls.Add(this.tbOcr2ImgSrc);
            this.groupBox2.Controls.Add(this.tbConnString);
            this.groupBox2.Controls.Add(this.tbOcr1ImgSrc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Setting_Port_lb);
            this.groupBox2.Controls.Add(this.setting_Address_lb);
            this.groupBox2.Controls.Add(this.label10);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // cbPreMapping
            // 
            resources.ApplyResources(this.cbPreMapping, "cbPreMapping");
            this.cbPreMapping.BackColor = System.Drawing.SystemColors.Control;
            this.cbPreMapping.Checked = true;
            this.cbPreMapping.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPreMapping.Name = "cbPreMapping";
            this.cbPreMapping.UseVisualStyleBackColor = false;
            // 
            // cbMappingDataCheck
            // 
            resources.ApplyResources(this.cbMappingDataCheck, "cbMappingDataCheck");
            this.cbMappingDataCheck.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbMappingDataCheck.Checked = true;
            this.cbMappingDataCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMappingDataCheck.Name = "cbMappingDataCheck";
            this.cbMappingDataCheck.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.Brown;
            this.label11.Name = "label11";
            // 
            // cbNoticeProcFin
            // 
            this.cbNoticeProcFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNoticeProcFin.FormattingEnabled = true;
            this.cbNoticeProcFin.Items.AddRange(new object[] {
            resources.GetString("cbNoticeProcFin.Items"),
            resources.GetString("cbNoticeProcFin.Items1"),
            resources.GetString("cbNoticeProcFin.Items2")});
            resources.ApplyResources(this.cbNoticeProcFin, "cbNoticeProcFin");
            this.cbNoticeProcFin.Name = "cbNoticeProcFin";
            // 
            // cbLanguage
            // 
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            resources.GetString("cbLanguage.Items"),
            resources.GetString("cbLanguage.Items1")});
            resources.ApplyResources(this.cbLanguage, "cbLanguage");
            this.cbLanguage.Name = "cbLanguage";
            // 
            // cbNoticeInitFin
            // 
            this.cbNoticeInitFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNoticeInitFin.FormattingEnabled = true;
            this.cbNoticeInitFin.Items.AddRange(new object[] {
            resources.GetString("cbNoticeInitFin.Items"),
            resources.GetString("cbNoticeInitFin.Items1"),
            resources.GetString("cbNoticeInitFin.Items2")});
            resources.ApplyResources(this.cbNoticeInitFin, "cbNoticeInitFin");
            this.cbNoticeInitFin.Name = "cbNoticeInitFin";
            // 
            // cbFakeData
            // 
            resources.ApplyResources(this.cbFakeData, "cbFakeData");
            this.cbFakeData.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbFakeData.Checked = true;
            this.cbFakeData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFakeData.Name = "cbFakeData";
            this.cbFakeData.UseVisualStyleBackColor = false;
            // 
            // cbChkBypass
            // 
            resources.ApplyResources(this.cbChkBypass, "cbChkBypass");
            this.cbChkBypass.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbChkBypass.Checked = true;
            this.cbChkBypass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbChkBypass.Name = "cbChkBypass";
            this.cbChkBypass.UseVisualStyleBackColor = false;
            // 
            // tbOcr2Exe
            // 
            this.tbOcr2Exe.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.tbOcr2Exe, "tbOcr2Exe");
            this.tbOcr2Exe.Name = "tbOcr2Exe";
            // 
            // tbOcr1Exe
            // 
            this.tbOcr1Exe.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.tbOcr1Exe, "tbOcr1Exe");
            this.tbOcr1Exe.Name = "tbOcr1Exe";
            // 
            // tbOcr2ImgBak
            // 
            this.tbOcr2ImgBak.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.tbOcr2ImgBak, "tbOcr2ImgBak");
            this.tbOcr2ImgBak.Name = "tbOcr2ImgBak";
            // 
            // tbOcr1ImgBak
            // 
            this.tbOcr1ImgBak.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.tbOcr1ImgBak, "tbOcr1ImgBak");
            this.tbOcr1ImgBak.Name = "tbOcr1ImgBak";
            // 
            // tbTxfLogPath
            // 
            this.tbTxfLogPath.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.tbTxfLogPath, "tbTxfLogPath");
            this.tbTxfLogPath.Name = "tbTxfLogPath";
            // 
            // cbRecipe
            // 
            this.cbRecipe.BackColor = System.Drawing.SystemColors.Info;
            this.cbRecipe.FormattingEnabled = true;
            this.cbRecipe.Items.AddRange(new object[] {
            resources.GetString("cbRecipe.Items"),
            resources.GetString("cbRecipe.Items1")});
            resources.ApplyResources(this.cbRecipe, "cbRecipe");
            this.cbRecipe.Name = "cbRecipe";
            // 
            // tbEqpId
            // 
            this.tbEqpId.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.tbEqpId, "tbEqpId");
            this.tbEqpId.Name = "tbEqpId";
            // 
            // tbSysMode
            // 
            this.tbSysMode.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.tbSysMode, "tbSysMode");
            this.tbSysMode.Name = "tbSysMode";
            // 
            // tbOcr2ImgSrc
            // 
            this.tbOcr2ImgSrc.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.tbOcr2ImgSrc, "tbOcr2ImgSrc");
            this.tbOcr2ImgSrc.Name = "tbOcr2ImgSrc";
            // 
            // tbConnString
            // 
            this.tbConnString.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.tbConnString, "tbConnString");
            this.tbConnString.Name = "tbConnString";
            // 
            // tbOcr1ImgSrc
            // 
            this.tbOcr1ImgSrc.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.tbOcr1ImgSrc, "tbOcr1ImgSrc");
            this.tbOcr1ImgSrc.Name = "tbOcr1ImgSrc";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // Setting_Port_lb
            // 
            resources.ApplyResources(this.Setting_Port_lb, "Setting_Port_lb");
            this.Setting_Port_lb.Name = "Setting_Port_lb";
            // 
            // setting_Address_lb
            // 
            resources.ApplyResources(this.setting_Address_lb, "setting_Address_lb");
            this.setting_Address_lb.Name = "setting_Address_lb";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // FormSysConfig
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSysConfig";
            this.Load += new System.EventHandler(this.FormSysConfig_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbSysMode;
        private System.Windows.Forms.TextBox tbOcr1ImgSrc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRecipe;
        private System.Windows.Forms.Label Setting_Port_lb;
        private System.Windows.Forms.Label setting_Address_lb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbOcr1Exe;
        private System.Windows.Forms.TextBox tbOcr1ImgBak;
        private System.Windows.Forms.TextBox tbTxfLogPath;
        private System.Windows.Forms.TextBox tbConnString;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbFakeData;
        private System.Windows.Forms.CheckBox cbChkBypass;
        private System.Windows.Forms.TextBox tbEqpId;
        private System.Windows.Forms.TextBox tbOcr2Exe;
        private System.Windows.Forms.TextBox tbOcr2ImgBak;
        private System.Windows.Forms.TextBox tbOcr2ImgSrc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbNoticeInitFin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbNoticeProcFin;
        private System.Windows.Forms.CheckBox cbMappingDataCheck;
        private System.Windows.Forms.CheckBox cbPreMapping;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Label label14;
    }
}