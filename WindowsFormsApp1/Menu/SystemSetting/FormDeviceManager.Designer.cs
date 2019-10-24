namespace Adam.Menu.SystemSetting
{
    partial class FormDeviceManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeviceManager));
            this.gbNodeManager = new System.Windows.Forms.GroupBox();
            this.splitContainerNode = new System.Windows.Forms.SplitContainer();
            this.gbCondition = new System.Windows.Forms.GroupBox();
            this.lstNodeList = new System.Windows.Forms.ListBox();
            this.splitContainerSetting = new System.Windows.Forms.SplitContainer();
            this.lbDeviceNodeManager = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Setting_Port_tb = new System.Windows.Forms.TextBox();
            this.Setting_Address_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Setting_connectType_cb = new System.Windows.Forms.ComboBox();
            this.Setting_ControllerName_lb = new System.Windows.Forms.Label();
            this.Setting_Port_lb = new System.Windows.Forms.Label();
            this.setting_Address_lb = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Setting_Mode_cb = new System.Windows.Forms.ComboBox();
            this.Setting_Mode_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Setting_CarrierType_cb = new System.Windows.Forms.ComboBox();
            this.Setting_NodeName_lb = new System.Windows.Forms.Label();
            this.Setting_CarrierType_lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Setting_NodeType_lb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Setting_NodeDisable_rb = new System.Windows.Forms.RadioButton();
            this.Setting_NodeEnable_rb = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbNodeManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNode)).BeginInit();
            this.splitContainerNode.Panel1.SuspendLayout();
            this.splitContainerNode.Panel2.SuspendLayout();
            this.splitContainerNode.SuspendLayout();
            this.gbCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSetting)).BeginInit();
            this.splitContainerSetting.Panel1.SuspendLayout();
            this.splitContainerSetting.Panel2.SuspendLayout();
            this.splitContainerSetting.SuspendLayout();
            this.lbDeviceNodeManager.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNodeManager
            // 
            resources.ApplyResources(this.gbNodeManager, "gbNodeManager");
            this.gbNodeManager.Controls.Add(this.splitContainerNode);
            this.gbNodeManager.Name = "gbNodeManager";
            this.gbNodeManager.TabStop = false;
            // 
            // splitContainerNode
            // 
            resources.ApplyResources(this.splitContainerNode, "splitContainerNode");
            this.splitContainerNode.Name = "splitContainerNode";
            // 
            // splitContainerNode.Panel1
            // 
            resources.ApplyResources(this.splitContainerNode.Panel1, "splitContainerNode.Panel1");
            this.splitContainerNode.Panel1.Controls.Add(this.gbCondition);
            // 
            // splitContainerNode.Panel2
            // 
            resources.ApplyResources(this.splitContainerNode.Panel2, "splitContainerNode.Panel2");
            this.splitContainerNode.Panel2.Controls.Add(this.splitContainerSetting);
            // 
            // gbCondition
            // 
            resources.ApplyResources(this.gbCondition, "gbCondition");
            this.gbCondition.Controls.Add(this.lstNodeList);
            this.gbCondition.Name = "gbCondition";
            this.gbCondition.TabStop = false;
            // 
            // lstNodeList
            // 
            resources.ApplyResources(this.lstNodeList, "lstNodeList");
            this.lstNodeList.FormattingEnabled = true;
            this.lstNodeList.Name = "lstNodeList";
            this.lstNodeList.Click += new System.EventHandler(this.lstNodeList_Click);
            // 
            // splitContainerSetting
            // 
            resources.ApplyResources(this.splitContainerSetting, "splitContainerSetting");
            this.splitContainerSetting.Name = "splitContainerSetting";
            // 
            // splitContainerSetting.Panel1
            // 
            resources.ApplyResources(this.splitContainerSetting.Panel1, "splitContainerSetting.Panel1");
            this.splitContainerSetting.Panel1.Controls.Add(this.lbDeviceNodeManager);
            // 
            // splitContainerSetting.Panel2
            // 
            resources.ApplyResources(this.splitContainerSetting.Panel2, "splitContainerSetting.Panel2");
            this.splitContainerSetting.Panel2.Controls.Add(this.tlpButton);
            // 
            // lbDeviceNodeManager
            // 
            resources.ApplyResources(this.lbDeviceNodeManager, "lbDeviceNodeManager");
            this.lbDeviceNodeManager.Controls.Add(this.groupBox2);
            this.lbDeviceNodeManager.Controls.Add(this.groupBox1);
            this.lbDeviceNodeManager.Name = "lbDeviceNodeManager";
            this.lbDeviceNodeManager.TabStop = false;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.Setting_Port_tb);
            this.groupBox2.Controls.Add(this.Setting_Address_tb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Setting_connectType_cb);
            this.groupBox2.Controls.Add(this.Setting_ControllerName_lb);
            this.groupBox2.Controls.Add(this.Setting_Port_lb);
            this.groupBox2.Controls.Add(this.setting_Address_lb);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // Setting_Port_tb
            // 
            resources.ApplyResources(this.Setting_Port_tb, "Setting_Port_tb");
            this.Setting_Port_tb.Name = "Setting_Port_tb";
            // 
            // Setting_Address_tb
            // 
            resources.ApplyResources(this.Setting_Address_tb, "Setting_Address_tb");
            this.Setting_Address_tb.Name = "Setting_Address_tb";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Setting_connectType_cb
            // 
            resources.ApplyResources(this.Setting_connectType_cb, "Setting_connectType_cb");
            this.Setting_connectType_cb.FormattingEnabled = true;
            this.Setting_connectType_cb.Items.AddRange(new object[] {
            resources.GetString("Setting_connectType_cb.Items"),
            resources.GetString("Setting_connectType_cb.Items1")});
            this.Setting_connectType_cb.Name = "Setting_connectType_cb";
            this.Setting_connectType_cb.SelectedIndexChanged += new System.EventHandler(this.Setting_connectType_cb_SelectedIndexChanged);
            // 
            // Setting_ControllerName_lb
            // 
            resources.ApplyResources(this.Setting_ControllerName_lb, "Setting_ControllerName_lb");
            this.Setting_ControllerName_lb.Name = "Setting_ControllerName_lb";
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
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.Setting_Mode_cb);
            this.groupBox1.Controls.Add(this.Setting_Mode_lb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Setting_CarrierType_cb);
            this.groupBox1.Controls.Add(this.Setting_NodeName_lb);
            this.groupBox1.Controls.Add(this.Setting_CarrierType_lb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Setting_NodeType_lb);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // Setting_Mode_cb
            // 
            resources.ApplyResources(this.Setting_Mode_cb, "Setting_Mode_cb");
            this.Setting_Mode_cb.FormattingEnabled = true;
            this.Setting_Mode_cb.Items.AddRange(new object[] {
            resources.GetString("Setting_Mode_cb.Items"),
            resources.GetString("Setting_Mode_cb.Items1")});
            this.Setting_Mode_cb.Name = "Setting_Mode_cb";
            // 
            // Setting_Mode_lb
            // 
            resources.ApplyResources(this.Setting_Mode_lb, "Setting_Mode_lb");
            this.Setting_Mode_lb.Name = "Setting_Mode_lb";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Setting_CarrierType_cb
            // 
            resources.ApplyResources(this.Setting_CarrierType_cb, "Setting_CarrierType_cb");
            this.Setting_CarrierType_cb.FormattingEnabled = true;
            this.Setting_CarrierType_cb.Items.AddRange(new object[] {
            resources.GetString("Setting_CarrierType_cb.Items"),
            resources.GetString("Setting_CarrierType_cb.Items1"),
            resources.GetString("Setting_CarrierType_cb.Items2")});
            this.Setting_CarrierType_cb.Name = "Setting_CarrierType_cb";
            // 
            // Setting_NodeName_lb
            // 
            resources.ApplyResources(this.Setting_NodeName_lb, "Setting_NodeName_lb");
            this.Setting_NodeName_lb.Name = "Setting_NodeName_lb";
            // 
            // Setting_CarrierType_lb
            // 
            resources.ApplyResources(this.Setting_CarrierType_lb, "Setting_CarrierType_lb");
            this.Setting_CarrierType_lb.Name = "Setting_CarrierType_lb";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Setting_NodeType_lb
            // 
            resources.ApplyResources(this.Setting_NodeType_lb, "Setting_NodeType_lb");
            this.Setting_NodeType_lb.Name = "Setting_NodeType_lb";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.Setting_NodeDisable_rb);
            this.panel1.Controls.Add(this.Setting_NodeEnable_rb);
            this.panel1.Name = "panel1";
            // 
            // Setting_NodeDisable_rb
            // 
            resources.ApplyResources(this.Setting_NodeDisable_rb, "Setting_NodeDisable_rb");
            this.Setting_NodeDisable_rb.Name = "Setting_NodeDisable_rb";
            this.Setting_NodeDisable_rb.TabStop = true;
            this.Setting_NodeDisable_rb.UseVisualStyleBackColor = true;
            // 
            // Setting_NodeEnable_rb
            // 
            resources.ApplyResources(this.Setting_NodeEnable_rb, "Setting_NodeEnable_rb");
            this.Setting_NodeEnable_rb.Name = "Setting_NodeEnable_rb";
            this.Setting_NodeEnable_rb.TabStop = true;
            this.Setting_NodeEnable_rb.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tlpButton
            // 
            resources.ApplyResources(this.tlpButton, "tlpButton");
            this.tlpButton.Controls.Add(this.btnSave, 4, 0);
            this.tlpButton.Name = "tlpButton";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormDeviceManager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.gbNodeManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDeviceManager";
            this.Load += new System.EventHandler(this.FormDeviceManager_Load);
            this.gbNodeManager.ResumeLayout(false);
            this.splitContainerNode.Panel1.ResumeLayout(false);
            this.splitContainerNode.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNode)).EndInit();
            this.splitContainerNode.ResumeLayout(false);
            this.gbCondition.ResumeLayout(false);
            this.splitContainerSetting.Panel1.ResumeLayout(false);
            this.splitContainerSetting.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSetting)).EndInit();
            this.splitContainerSetting.ResumeLayout(false);
            this.lbDeviceNodeManager.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tlpButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNodeManager;
        private System.Windows.Forms.SplitContainer splitContainerNode;
        private System.Windows.Forms.GroupBox gbCondition;
        private System.Windows.Forms.ListBox lstNodeList;
        private System.Windows.Forms.SplitContainer splitContainerSetting;
        private System.Windows.Forms.GroupBox lbDeviceNodeManager;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label Setting_NodeName_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Setting_CarrierType_cb;
        private System.Windows.Forms.Label Setting_CarrierType_lb;
        private System.Windows.Forms.Label Setting_NodeType_lb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Setting_NodeDisable_rb;
        private System.Windows.Forms.RadioButton Setting_NodeEnable_rb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Setting_Address_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Setting_connectType_cb;
        private System.Windows.Forms.Label Setting_ControllerName_lb;
        private System.Windows.Forms.Label Setting_Port_lb;
        private System.Windows.Forms.Label setting_Address_lb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Setting_Port_tb;
        private System.Windows.Forms.ComboBox Setting_Mode_cb;
        private System.Windows.Forms.Label Setting_Mode_lb;
    }
}
