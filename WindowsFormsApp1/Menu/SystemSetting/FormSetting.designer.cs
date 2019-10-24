namespace Adam.Menu.SystemSetting
{
    partial class FormSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetting));
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.btnDeviceManager = new System.Windows.Forms.Button();
            this.btnOnlineSettings = new System.Windows.Forms.Button();
            this.btnAccountSetting = new System.Windows.Forms.Button();
            this.btnSignalTtower = new System.Windows.Forms.Button();
            this.btnSECSSetting = new System.Windows.Forms.Button();
            this.btnRecipeSetting = new System.Windows.Forms.Button();
            this.btnDIOSetting = new System.Windows.Forms.Button();
            this.btnSysConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlSetting
            // 
            resources.ApplyResources(this.pnlSetting, "pnlSetting");
            this.pnlSetting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSetting.Name = "pnlSetting";
            // 
            // btnDeviceManager
            // 
            resources.ApplyResources(this.btnDeviceManager, "btnDeviceManager");
            this.btnDeviceManager.Name = "btnDeviceManager";
            this.btnDeviceManager.UseVisualStyleBackColor = true;
            this.btnDeviceManager.Click += new System.EventHandler(this.btnDeviceManager_Click);
            // 
            // btnOnlineSettings
            // 
            resources.ApplyResources(this.btnOnlineSettings, "btnOnlineSettings");
            this.btnOnlineSettings.Name = "btnOnlineSettings";
            this.btnOnlineSettings.UseVisualStyleBackColor = true;
            this.btnOnlineSettings.Click += new System.EventHandler(this.btnOnlineSettings_Click);
            // 
            // btnAccountSetting
            // 
            resources.ApplyResources(this.btnAccountSetting, "btnAccountSetting");
            this.btnAccountSetting.Name = "btnAccountSetting";
            this.btnAccountSetting.UseVisualStyleBackColor = true;
            this.btnAccountSetting.Click += new System.EventHandler(this.btnAccountSetting_Click);
            // 
            // btnSignalTtower
            // 
            resources.ApplyResources(this.btnSignalTtower, "btnSignalTtower");
            this.btnSignalTtower.Name = "btnSignalTtower";
            this.btnSignalTtower.UseVisualStyleBackColor = true;
            this.btnSignalTtower.Click += new System.EventHandler(this.btnSignalTtower_Click);
            // 
            // btnSECSSetting
            // 
            resources.ApplyResources(this.btnSECSSetting, "btnSECSSetting");
            this.btnSECSSetting.Name = "btnSECSSetting";
            this.btnSECSSetting.UseVisualStyleBackColor = true;
            this.btnSECSSetting.Click += new System.EventHandler(this.btnSECSSetting_Click);
            // 
            // btnRecipeSetting
            // 
            resources.ApplyResources(this.btnRecipeSetting, "btnRecipeSetting");
            this.btnRecipeSetting.Name = "btnRecipeSetting";
            this.btnRecipeSetting.UseVisualStyleBackColor = true;
            this.btnRecipeSetting.Click += new System.EventHandler(this.btnRecipeSetting_Click);
            // 
            // btnDIOSetting
            // 
            resources.ApplyResources(this.btnDIOSetting, "btnDIOSetting");
            this.btnDIOSetting.Name = "btnDIOSetting";
            this.btnDIOSetting.UseVisualStyleBackColor = true;
            this.btnDIOSetting.Click += new System.EventHandler(this.btnDIOSetting_Click);
            // 
            // btnSysConfig
            // 
            resources.ApplyResources(this.btnSysConfig, "btnSysConfig");
            this.btnSysConfig.Name = "btnSysConfig";
            this.btnSysConfig.UseVisualStyleBackColor = true;
            this.btnSysConfig.Click += new System.EventHandler(this.btnSysConfig_Click);
            // 
            // FormSetting
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRecipeSetting);
            this.Controls.Add(this.btnDIOSetting);
            this.Controls.Add(this.btnSECSSetting);
            this.Controls.Add(this.btnSignalTtower);
            this.Controls.Add(this.btnSysConfig);
            this.Controls.Add(this.btnAccountSetting);
            this.Controls.Add(this.btnOnlineSettings);
            this.Controls.Add(this.btnDeviceManager);
            this.Controls.Add(this.pnlSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSetting";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.Leave += new System.EventHandler(this.FormSetting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.Button btnDeviceManager;
        private System.Windows.Forms.Button btnOnlineSettings;
        private System.Windows.Forms.Button btnAccountSetting;
        private System.Windows.Forms.Button btnSignalTtower;
        private System.Windows.Forms.Button btnSECSSetting;
        private System.Windows.Forms.Button btnRecipeSetting;
        private System.Windows.Forms.Button btnDIOSetting;
        private System.Windows.Forms.Button btnSysConfig;
    }
}