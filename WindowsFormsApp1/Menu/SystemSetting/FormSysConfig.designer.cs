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
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbNoticeProcFin = new System.Windows.Forms.ComboBox();
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
            this.cbMappingDataCheck = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGray;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(1055, 439);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(201, 46);
            this.btnSave.TabIndex = 95;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMappingDataCheck);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbNoticeProcFin);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1278, 518);
            this.groupBox2.TabIndex = 96;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System Config";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label13.Location = new System.Drawing.Point(418, 342);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 24);
            this.label13.TabIndex = 98;
            this.label13.Text = "搬送工作完成";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(259, 342);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 24);
            this.label12.TabIndex = 98;
            this.label12.Text = "初始化完畢";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.Color.Brown;
            this.label11.Location = new System.Drawing.Point(604, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(256, 20);
            this.label11.TabIndex = 97;
            this.label11.Text = "4: Buzzer 1, 5: Buzzer 2, N: 無動作";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbNoticeProcFin
            // 
            this.cbNoticeProcFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNoticeProcFin.FormattingEnabled = true;
            this.cbNoticeProcFin.Items.AddRange(new object[] {
            "4",
            "5",
            "N"});
            this.cbNoticeProcFin.Location = new System.Drawing.Point(542, 338);
            this.cbNoticeProcFin.Name = "cbNoticeProcFin";
            this.cbNoticeProcFin.Size = new System.Drawing.Size(42, 32);
            this.cbNoticeProcFin.TabIndex = 96;
            // 
            // cbNoticeInitFin
            // 
            this.cbNoticeInitFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNoticeInitFin.FormattingEnabled = true;
            this.cbNoticeInitFin.Items.AddRange(new object[] {
            "4",
            "5",
            "N"});
            this.cbNoticeInitFin.Location = new System.Drawing.Point(369, 338);
            this.cbNoticeInitFin.Name = "cbNoticeInitFin";
            this.cbNoticeInitFin.Size = new System.Drawing.Size(42, 32);
            this.cbNoticeInitFin.TabIndex = 96;
            // 
            // cbFakeData
            // 
            this.cbFakeData.AutoSize = true;
            this.cbFakeData.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbFakeData.Checked = true;
            this.cbFakeData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFakeData.Enabled = false;
            this.cbFakeData.Location = new System.Drawing.Point(399, 304);
            this.cbFakeData.Name = "cbFakeData";
            this.cbFakeData.Size = new System.Drawing.Size(143, 28);
            this.cbFakeData.TabIndex = 12;
            this.cbFakeData.Text = "使用虛擬資料";
            this.cbFakeData.UseVisualStyleBackColor = false;
            // 
            // cbChkBypass
            // 
            this.cbChkBypass.AutoSize = true;
            this.cbChkBypass.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbChkBypass.Checked = true;
            this.cbChkBypass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbChkBypass.Enabled = false;
            this.cbChkBypass.Location = new System.Drawing.Point(250, 304);
            this.cbChkBypass.Name = "cbChkBypass";
            this.cbChkBypass.Size = new System.Drawing.Size(143, 28);
            this.cbChkBypass.TabIndex = 12;
            this.cbChkBypass.Text = "忽略安全檢查";
            this.cbChkBypass.UseVisualStyleBackColor = false;
            // 
            // tbOcr2Exe
            // 
            this.tbOcr2Exe.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbOcr2Exe.Enabled = false;
            this.tbOcr2Exe.Location = new System.Drawing.Point(250, 187);
            this.tbOcr2Exe.Name = "tbOcr2Exe";
            this.tbOcr2Exe.Size = new System.Drawing.Size(894, 33);
            this.tbOcr2Exe.TabIndex = 11;
            // 
            // tbOcr1Exe
            // 
            this.tbOcr1Exe.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbOcr1Exe.Enabled = false;
            this.tbOcr1Exe.Location = new System.Drawing.Point(250, 109);
            this.tbOcr1Exe.Name = "tbOcr1Exe";
            this.tbOcr1Exe.Size = new System.Drawing.Size(894, 33);
            this.tbOcr1Exe.TabIndex = 11;
            // 
            // tbOcr2ImgBak
            // 
            this.tbOcr2ImgBak.BackColor = System.Drawing.SystemColors.Info;
            this.tbOcr2ImgBak.Location = new System.Drawing.Point(831, 226);
            this.tbOcr2ImgBak.Name = "tbOcr2ImgBak";
            this.tbOcr2ImgBak.Size = new System.Drawing.Size(368, 33);
            this.tbOcr2ImgBak.TabIndex = 11;
            // 
            // tbOcr1ImgBak
            // 
            this.tbOcr1ImgBak.BackColor = System.Drawing.SystemColors.Info;
            this.tbOcr1ImgBak.Location = new System.Drawing.Point(831, 148);
            this.tbOcr1ImgBak.Name = "tbOcr1ImgBak";
            this.tbOcr1ImgBak.Size = new System.Drawing.Size(368, 33);
            this.tbOcr1ImgBak.TabIndex = 11;
            // 
            // tbTxfLogPath
            // 
            this.tbTxfLogPath.BackColor = System.Drawing.SystemColors.Info;
            this.tbTxfLogPath.Location = new System.Drawing.Point(250, 265);
            this.tbTxfLogPath.Name = "tbTxfLogPath";
            this.tbTxfLogPath.Size = new System.Drawing.Size(368, 33);
            this.tbTxfLogPath.TabIndex = 11;
            // 
            // cbRecipe
            // 
            this.cbRecipe.BackColor = System.Drawing.SystemColors.Info;
            this.cbRecipe.FormattingEnabled = true;
            this.cbRecipe.Items.AddRange(new object[] {
            "Socket",
            "Comport"});
            this.cbRecipe.Location = new System.Drawing.Point(250, 71);
            this.cbRecipe.Name = "cbRecipe";
            this.cbRecipe.Size = new System.Drawing.Size(368, 32);
            this.cbRecipe.TabIndex = 9;
            // 
            // tbEqpId
            // 
            this.tbEqpId.BackColor = System.Drawing.SystemColors.Info;
            this.tbEqpId.Location = new System.Drawing.Point(542, 32);
            this.tbEqpId.Name = "tbEqpId";
            this.tbEqpId.Size = new System.Drawing.Size(161, 33);
            this.tbEqpId.TabIndex = 11;
            // 
            // tbSysMode
            // 
            this.tbSysMode.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbSysMode.Enabled = false;
            this.tbSysMode.Location = new System.Drawing.Point(250, 32);
            this.tbSysMode.Name = "tbSysMode";
            this.tbSysMode.Size = new System.Drawing.Size(161, 33);
            this.tbSysMode.TabIndex = 11;
            // 
            // tbOcr2ImgSrc
            // 
            this.tbOcr2ImgSrc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbOcr2ImgSrc.Enabled = false;
            this.tbOcr2ImgSrc.Location = new System.Drawing.Point(250, 226);
            this.tbOcr2ImgSrc.Name = "tbOcr2ImgSrc";
            this.tbOcr2ImgSrc.Size = new System.Drawing.Size(368, 33);
            this.tbOcr2ImgSrc.TabIndex = 10;
            // 
            // tbConnString
            // 
            this.tbConnString.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbConnString.Enabled = false;
            this.tbConnString.Location = new System.Drawing.Point(250, 376);
            this.tbConnString.Name = "tbConnString";
            this.tbConnString.Size = new System.Drawing.Size(894, 33);
            this.tbConnString.TabIndex = 10;
            // 
            // tbOcr1ImgSrc
            // 
            this.tbOcr1ImgSrc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbOcr1ImgSrc.Enabled = false;
            this.tbOcr1ImgSrc.Location = new System.Drawing.Point(250, 148);
            this.tbOcr1ImgSrc.Name = "tbOcr1ImgSrc";
            this.tbOcr1ImgSrc.Size = new System.Drawing.Size(368, 33);
            this.tbOcr1ImgSrc.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "SystemMode:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "生產 Recipe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "機台名稱:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "OCR2 程式路徑:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "生產檔案輸出路徑:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(108, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "鈴聲提示功能:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(629, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "OCR2 照片備份路徑:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "OCR1 程式路徑:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "OCR2 照片來源:";
            // 
            // Setting_Port_lb
            // 
            this.Setting_Port_lb.AutoSize = true;
            this.Setting_Port_lb.Location = new System.Drawing.Point(629, 151);
            this.Setting_Port_lb.Name = "Setting_Port_lb";
            this.Setting_Port_lb.Size = new System.Drawing.Size(184, 24);
            this.Setting_Port_lb.TabIndex = 8;
            this.Setting_Port_lb.Text = "OCR1 照片備份路徑:";
            // 
            // setting_Address_lb
            // 
            this.setting_Address_lb.AutoSize = true;
            this.setting_Address_lb.Location = new System.Drawing.Point(86, 151);
            this.setting_Address_lb.Name = "setting_Address_lb";
            this.setting_Address_lb.Size = new System.Drawing.Size(146, 24);
            this.setting_Address_lb.TabIndex = 2;
            this.setting_Address_lb.Text = "OCR1 照片來源:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 24);
            this.label10.TabIndex = 6;
            this.label10.Text = "DB connect:";
            // 
            // cbMappingDataCheck
            // 
            this.cbMappingDataCheck.AutoSize = true;
            this.cbMappingDataCheck.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbMappingDataCheck.Checked = true;
            this.cbMappingDataCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMappingDataCheck.Enabled = false;
            this.cbMappingDataCheck.Location = new System.Drawing.Point(548, 304);
            this.cbMappingDataCheck.Name = "cbMappingDataCheck";
            this.cbMappingDataCheck.Size = new System.Drawing.Size(186, 28);
            this.cbMappingDataCheck.TabIndex = 99;
            this.cbMappingDataCheck.Text = "Mapping結果檢查";
            this.cbMappingDataCheck.UseVisualStyleBackColor = false;
            // 
            // FormSysConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 752);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormSysConfig";
            this.Text = "FormSysConfig";
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
    }
}