namespace GUI
{
    partial class FormConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfirm));
            this.panel40 = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label80 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel40.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel40
            // 
            resources.ApplyResources(this.panel40, "panel40");
            this.panel40.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel40.Controls.Add(this.tbPassword);
            this.panel40.Controls.Add(this.tbUserID);
            this.panel40.Controls.Add(this.btnCancel);
            this.panel40.Controls.Add(this.label80);
            this.panel40.Controls.Add(this.lblMessage);
            this.panel40.Controls.Add(this.label84);
            this.panel40.Controls.Add(this.btnSubmit);
            this.panel40.Name = "panel40";
            // 
            // tbPassword
            // 
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.Name = "tbPassword";
            // 
            // tbUserID
            // 
            resources.ApplyResources(this.tbUserID, "tbUserID");
            this.tbUserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbUserID.Name = "tbUserID";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label80
            // 
            resources.ApplyResources(this.label80, "label80");
            this.label80.Name = "label80";
            // 
            // lblMessage
            // 
            resources.ApplyResources(this.lblMessage, "lblMessage");
            this.lblMessage.Name = "lblMessage";
            // 
            // label84
            // 
            resources.ApplyResources(this.label84, "label84");
            this.label84.Name = "label84";
            // 
            // btnSubmit
            // 
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.BackColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.FlatAppearance.BorderSize = 2;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FormConfirm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel40);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfirm";
            this.Activated += new System.EventHandler(this.FormLogin_Activated);
            this.panel40.ResumeLayout(false);
            this.panel40.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.Label lblMessage;
    }
}