namespace Adam.Menu.SystemSetting
{
    partial class FormRecipeSetting_1R1A2P
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecipeSetting_1R1A2P));
            this.lblMode = new System.Windows.Forms.Label();
            this.trvRecipe = new System.Windows.Forms.TreeView();
            this.gbAccountCondition = new System.Windows.Forms.GroupBox();
            this.tlpAccountCreate = new System.Windows.Forms.TableLayoutPanel();
            this.gbRecipe = new System.Windows.Forms.GroupBox();
            this.gbRecipeHeader = new System.Windows.Forms.GroupBox();
            this.tbRecipeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRecipeName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbRecipeBody = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cbOutputFin1 = new System.Windows.Forms.ComboBox();
            this.cbOutputFin2 = new System.Windows.Forms.ComboBox();
            this.cbOutputFin3 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbInputFin1 = new System.Windows.Forms.ComboBox();
            this.cbInputFin2 = new System.Windows.Forms.ComboBox();
            this.cbInputFin3 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tbNotch_angle = new System.Windows.Forms.TextBox();
            this.cbP2LoadType = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.cbP1LoadType = new System.Windows.Forms.ComboBox();
            this.cbP2CstType = new System.Windows.Forms.ComboBox();
            this.cbP1CstType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbUseBurnIn = new System.Windows.Forms.CheckBox();
            this.cbWaferSize = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.tbR1Speed = new System.Windows.Forms.TextBox();
            this.cbPutSlotOrder = new System.Windows.Forms.ComboBox();
            this.cbGetSlotOrder = new System.Windows.Forms.ComboBox();
            this.cbUserBothArm = new System.Windows.Forms.CheckBox();
            this.cbUseLArm = new System.Windows.Forms.CheckBox();
            this.cbUseRArm = new System.Windows.Forms.CheckBox();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.Aligner_gb = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbA1_speed = new System.Windows.Forms.TextBox();
            this.cbUseA1 = new System.Windows.Forms.CheckBox();
            this.gbAccount = new System.Windows.Forms.GroupBox();
            this.palMenu = new System.Windows.Forms.Panel();
            this.tlpAccountMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnModifyRecipe = new System.Windows.Forms.Button();
            this.btnCreateRecipe = new System.Windows.Forms.Button();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            this.palContainer = new System.Windows.Forms.Panel();
            this.tlpAccount = new System.Windows.Forms.TableLayoutPanel();
            this.gbAccountCondition.SuspendLayout();
            this.tlpAccountCreate.SuspendLayout();
            this.gbRecipe.SuspendLayout();
            this.gbRecipeHeader.SuspendLayout();
            this.gbRecipeBody.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Aligner_gb.SuspendLayout();
            this.gbAccount.SuspendLayout();
            this.palMenu.SuspendLayout();
            this.tlpAccountMenu.SuspendLayout();
            this.palContainer.SuspendLayout();
            this.tlpAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMode
            // 
            resources.ApplyResources(this.lblMode, "lblMode");
            this.lblMode.BackColor = System.Drawing.Color.Yellow;
            this.lblMode.ForeColor = System.Drawing.Color.Red;
            this.lblMode.Name = "lblMode";
            // 
            // trvRecipe
            // 
            resources.ApplyResources(this.trvRecipe, "trvRecipe");
            this.trvRecipe.Name = "trvRecipe";
            this.trvRecipe.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvRecipe_AfterSelect);
            this.trvRecipe.Validating += new System.ComponentModel.CancelEventHandler(this.trvRecipe_Validating);
            // 
            // gbAccountCondition
            // 
            resources.ApplyResources(this.gbAccountCondition, "gbAccountCondition");
            this.gbAccountCondition.Controls.Add(this.trvRecipe);
            this.gbAccountCondition.Name = "gbAccountCondition";
            this.gbAccountCondition.TabStop = false;
            // 
            // tlpAccountCreate
            // 
            resources.ApplyResources(this.tlpAccountCreate, "tlpAccountCreate");
            this.tlpAccountCreate.Controls.Add(this.gbAccountCondition, 0, 0);
            this.tlpAccountCreate.Controls.Add(this.gbRecipe, 1, 0);
            this.tlpAccountCreate.Name = "tlpAccountCreate";
            // 
            // gbRecipe
            // 
            resources.ApplyResources(this.gbRecipe, "gbRecipe");
            this.gbRecipe.Controls.Add(this.gbRecipeHeader);
            this.gbRecipe.Controls.Add(this.btnCancel);
            this.gbRecipe.Controls.Add(this.btnSave);
            this.gbRecipe.Controls.Add(this.gbRecipeBody);
            this.gbRecipe.Name = "gbRecipe";
            this.gbRecipe.TabStop = false;
            // 
            // gbRecipeHeader
            // 
            resources.ApplyResources(this.gbRecipeHeader, "gbRecipeHeader");
            this.gbRecipeHeader.Controls.Add(this.tbRecipeID);
            this.gbRecipeHeader.Controls.Add(this.label1);
            this.gbRecipeHeader.Controls.Add(this.label2);
            this.gbRecipeHeader.Controls.Add(this.tbRecipeName);
            this.gbRecipeHeader.Name = "gbRecipeHeader";
            this.gbRecipeHeader.TabStop = false;
            // 
            // tbRecipeID
            // 
            resources.ApplyResources(this.tbRecipeID, "tbRecipeID");
            this.tbRecipeID.Name = "tbRecipeID";
            this.tbRecipeID.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Name = "label2";
            // 
            // tbRecipeName
            // 
            resources.ApplyResources(this.tbRecipeName, "tbRecipeName");
            this.tbRecipeName.Name = "tbRecipeName";
            this.tbRecipeName.ReadOnly = true;
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbRecipeBody
            // 
            resources.ApplyResources(this.gbRecipeBody, "gbRecipeBody");
            this.gbRecipeBody.Controls.Add(this.label6);
            this.gbRecipeBody.Controls.Add(this.label4);
            this.gbRecipeBody.Controls.Add(this.groupBox9);
            this.gbRecipeBody.Controls.Add(this.groupBox2);
            this.gbRecipeBody.Controls.Add(this.lblMode);
            this.gbRecipeBody.Controls.Add(this.cbUseBurnIn);
            this.gbRecipeBody.Controls.Add(this.cbWaferSize);
            this.gbRecipeBody.Controls.Add(this.groupBox3);
            this.gbRecipeBody.Controls.Add(this.cbActive);
            this.gbRecipeBody.Controls.Add(this.Aligner_gb);
            this.gbRecipeBody.Name = "gbRecipeBody";
            this.gbRecipeBody.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Name = "label6";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Name = "label4";
            // 
            // groupBox9
            // 
            resources.ApplyResources(this.groupBox9, "groupBox9");
            this.groupBox9.Controls.Add(this.groupBox6);
            this.groupBox9.Controls.Add(this.label11);
            this.groupBox9.Controls.Add(this.groupBox7);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.TabStop = false;
            // 
            // groupBox6
            // 
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.cbOutputFin1);
            this.groupBox6.Controls.Add(this.cbOutputFin2);
            this.groupBox6.Controls.Add(this.cbOutputFin3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.ForeColor = System.Drawing.Color.Chocolate;
            this.label19.Name = "label19";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.ForeColor = System.Drawing.Color.Chocolate;
            this.label20.Name = "label20";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.ForeColor = System.Drawing.Color.Chocolate;
            this.label21.Name = "label21";
            // 
            // cbOutputFin1
            // 
            resources.ApplyResources(this.cbOutputFin1, "cbOutputFin1");
            this.cbOutputFin1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutputFin1.FormattingEnabled = true;
            this.cbOutputFin1.Items.AddRange(new object[] {
            resources.GetString("cbOutputFin1.Items"),
            resources.GetString("cbOutputFin1.Items1"),
            resources.GetString("cbOutputFin1.Items2")});
            this.cbOutputFin1.Name = "cbOutputFin1";
            // 
            // cbOutputFin2
            // 
            resources.ApplyResources(this.cbOutputFin2, "cbOutputFin2");
            this.cbOutputFin2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutputFin2.FormattingEnabled = true;
            this.cbOutputFin2.Items.AddRange(new object[] {
            resources.GetString("cbOutputFin2.Items"),
            resources.GetString("cbOutputFin2.Items1"),
            resources.GetString("cbOutputFin2.Items2"),
            resources.GetString("cbOutputFin2.Items3"),
            resources.GetString("cbOutputFin2.Items4")});
            this.cbOutputFin2.Name = "cbOutputFin2";
            // 
            // cbOutputFin3
            // 
            resources.ApplyResources(this.cbOutputFin3, "cbOutputFin3");
            this.cbOutputFin3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutputFin3.FormattingEnabled = true;
            this.cbOutputFin3.Items.AddRange(new object[] {
            resources.GetString("cbOutputFin3.Items"),
            resources.GetString("cbOutputFin3.Items1"),
            resources.GetString("cbOutputFin3.Items2")});
            this.cbOutputFin3.Name = "cbOutputFin3";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.Brown;
            this.label11.Name = "label11";
            // 
            // groupBox7
            // 
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.cbInputFin1);
            this.groupBox7.Controls.Add(this.cbInputFin2);
            this.groupBox7.Controls.Add(this.cbInputFin3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.ForeColor = System.Drawing.Color.Chocolate;
            this.label16.Name = "label16";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.ForeColor = System.Drawing.Color.Chocolate;
            this.label17.Name = "label17";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.ForeColor = System.Drawing.Color.Chocolate;
            this.label18.Name = "label18";
            // 
            // cbInputFin1
            // 
            resources.ApplyResources(this.cbInputFin1, "cbInputFin1");
            this.cbInputFin1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInputFin1.FormattingEnabled = true;
            this.cbInputFin1.Items.AddRange(new object[] {
            resources.GetString("cbInputFin1.Items"),
            resources.GetString("cbInputFin1.Items1"),
            resources.GetString("cbInputFin1.Items2")});
            this.cbInputFin1.Name = "cbInputFin1";
            // 
            // cbInputFin2
            // 
            resources.ApplyResources(this.cbInputFin2, "cbInputFin2");
            this.cbInputFin2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInputFin2.FormattingEnabled = true;
            this.cbInputFin2.Items.AddRange(new object[] {
            resources.GetString("cbInputFin2.Items"),
            resources.GetString("cbInputFin2.Items1"),
            resources.GetString("cbInputFin2.Items2"),
            resources.GetString("cbInputFin2.Items3"),
            resources.GetString("cbInputFin2.Items4")});
            this.cbInputFin2.Name = "cbInputFin2";
            // 
            // cbInputFin3
            // 
            resources.ApplyResources(this.cbInputFin3, "cbInputFin3");
            this.cbInputFin3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInputFin3.FormattingEnabled = true;
            this.cbInputFin3.Items.AddRange(new object[] {
            resources.GetString("cbInputFin3.Items"),
            resources.GetString("cbInputFin3.Items1"),
            resources.GetString("cbInputFin3.Items2")});
            this.cbInputFin3.Name = "cbInputFin3";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.tbNotch_angle);
            this.groupBox2.Controls.Add(this.cbP2LoadType);
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.Controls.Add(this.cbP1LoadType);
            this.groupBox2.Controls.Add(this.cbP2CstType);
            this.groupBox2.Controls.Add(this.cbP1CstType);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Name = "label3";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.ForeColor = System.Drawing.Color.Chocolate;
            this.label26.Name = "label26";
            // 
            // tbNotch_angle
            // 
            resources.ApplyResources(this.tbNotch_angle, "tbNotch_angle");
            this.tbNotch_angle.Name = "tbNotch_angle";
            this.tbNotch_angle.Click += new System.EventHandler(this.modeCheck);
            this.tbNotch_angle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_KeyPress);
            this.tbNotch_angle.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.modeCheck);
            // 
            // cbP2LoadType
            // 
            resources.ApplyResources(this.cbP2LoadType, "cbP2LoadType");
            this.cbP2LoadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbP2LoadType.FormattingEnabled = true;
            this.cbP2LoadType.Items.AddRange(new object[] {
            resources.GetString("cbP2LoadType.Items"),
            resources.GetString("cbP2LoadType.Items1"),
            resources.GetString("cbP2LoadType.Items2")});
            this.cbP2LoadType.Name = "cbP2LoadType";
            this.cbP2LoadType.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbP2LoadType.Click += new System.EventHandler(this.modeCheck);
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.ForeColor = System.Drawing.Color.Brown;
            this.label35.Name = "label35";
            // 
            // cbP1LoadType
            // 
            resources.ApplyResources(this.cbP1LoadType, "cbP1LoadType");
            this.cbP1LoadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbP1LoadType.FormattingEnabled = true;
            this.cbP1LoadType.Items.AddRange(new object[] {
            resources.GetString("cbP1LoadType.Items"),
            resources.GetString("cbP1LoadType.Items1"),
            resources.GetString("cbP1LoadType.Items2")});
            this.cbP1LoadType.Name = "cbP1LoadType";
            this.cbP1LoadType.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbP1LoadType.Click += new System.EventHandler(this.modeCheck);
            // 
            // cbP2CstType
            // 
            resources.ApplyResources(this.cbP2CstType, "cbP2CstType");
            this.cbP2CstType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbP2CstType.FormattingEnabled = true;
            this.cbP2CstType.Items.AddRange(new object[] {
            resources.GetString("cbP2CstType.Items"),
            resources.GetString("cbP2CstType.Items1"),
            resources.GetString("cbP2CstType.Items2")});
            this.cbP2CstType.Name = "cbP2CstType";
            this.cbP2CstType.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbP2CstType.Click += new System.EventHandler(this.modeCheck);
            // 
            // cbP1CstType
            // 
            resources.ApplyResources(this.cbP1CstType, "cbP1CstType");
            this.cbP1CstType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbP1CstType.FormattingEnabled = true;
            this.cbP1CstType.Items.AddRange(new object[] {
            resources.GetString("cbP1CstType.Items"),
            resources.GetString("cbP1CstType.Items1"),
            resources.GetString("cbP1CstType.Items2")});
            this.cbP1CstType.Name = "cbP1CstType";
            this.cbP1CstType.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbP1CstType.Click += new System.EventHandler(this.modeCheck);
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
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Name = "label12";
            // 
            // cbUseBurnIn
            // 
            resources.ApplyResources(this.cbUseBurnIn, "cbUseBurnIn");
            this.cbUseBurnIn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cbUseBurnIn.Name = "cbUseBurnIn";
            this.cbUseBurnIn.UseVisualStyleBackColor = true;
            this.cbUseBurnIn.Click += new System.EventHandler(this.modeCheck);
            // 
            // cbWaferSize
            // 
            resources.ApplyResources(this.cbWaferSize, "cbWaferSize");
            this.cbWaferSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWaferSize.FormattingEnabled = true;
            this.cbWaferSize.Items.AddRange(new object[] {
            resources.GetString("cbWaferSize.Items"),
            resources.GetString("cbWaferSize.Items1")});
            this.cbWaferSize.Name = "cbWaferSize";
            this.cbWaferSize.SelectedIndexChanged += new System.EventHandler(this.cbWaferSize_SelectedIndexChanged);
            this.cbWaferSize.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbWaferSize.Click += new System.EventHandler(this.modeCheck);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.tbR1Speed);
            this.groupBox3.Controls.Add(this.cbPutSlotOrder);
            this.groupBox3.Controls.Add(this.cbGetSlotOrder);
            this.groupBox3.Controls.Add(this.cbUserBothArm);
            this.groupBox3.Controls.Add(this.cbUseLArm);
            this.groupBox3.Controls.Add(this.cbUseRArm);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label38
            // 
            resources.ApplyResources(this.label38, "label38");
            this.label38.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label38.Name = "label38";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Name = "label5";
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label30.Name = "label30";
            // 
            // tbR1Speed
            // 
            resources.ApplyResources(this.tbR1Speed, "tbR1Speed");
            this.tbR1Speed.Name = "tbR1Speed";
            this.tbR1Speed.Click += new System.EventHandler(this.modeCheck);
            this.tbR1Speed.TextChanged += new System.EventHandler(this.modeCheck);
            this.tbR1Speed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_KeyPress);
            this.tbR1Speed.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.modeCheck);
            // 
            // cbPutSlotOrder
            // 
            resources.ApplyResources(this.cbPutSlotOrder, "cbPutSlotOrder");
            this.cbPutSlotOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPutSlotOrder.FormattingEnabled = true;
            this.cbPutSlotOrder.Items.AddRange(new object[] {
            resources.GetString("cbPutSlotOrder.Items"),
            resources.GetString("cbPutSlotOrder.Items1")});
            this.cbPutSlotOrder.Name = "cbPutSlotOrder";
            this.cbPutSlotOrder.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbPutSlotOrder.Click += new System.EventHandler(this.modeCheck);
            // 
            // cbGetSlotOrder
            // 
            resources.ApplyResources(this.cbGetSlotOrder, "cbGetSlotOrder");
            this.cbGetSlotOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGetSlotOrder.FormattingEnabled = true;
            this.cbGetSlotOrder.Items.AddRange(new object[] {
            resources.GetString("cbGetSlotOrder.Items"),
            resources.GetString("cbGetSlotOrder.Items1")});
            this.cbGetSlotOrder.Name = "cbGetSlotOrder";
            this.cbGetSlotOrder.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbGetSlotOrder.Click += new System.EventHandler(this.modeCheck);
            // 
            // cbUserBothArm
            // 
            resources.ApplyResources(this.cbUserBothArm, "cbUserBothArm");
            this.cbUserBothArm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cbUserBothArm.Name = "cbUserBothArm";
            this.cbUserBothArm.UseVisualStyleBackColor = true;
            this.cbUserBothArm.CheckedChanged += new System.EventHandler(this.cbUserBothArm_CheckedChanged);
            this.cbUserBothArm.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbUserBothArm.Click += new System.EventHandler(this.modeCheck);
            // 
            // cbUseLArm
            // 
            resources.ApplyResources(this.cbUseLArm, "cbUseLArm");
            this.cbUseLArm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cbUseLArm.Name = "cbUseLArm";
            this.cbUseLArm.UseVisualStyleBackColor = true;
            this.cbUseLArm.CheckedChanged += new System.EventHandler(this.cbUseLArm_CheckedChanged);
            this.cbUseLArm.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbUseLArm.Click += new System.EventHandler(this.modeCheck);
            // 
            // cbUseRArm
            // 
            resources.ApplyResources(this.cbUseRArm, "cbUseRArm");
            this.cbUseRArm.Checked = true;
            this.cbUseRArm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseRArm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cbUseRArm.Name = "cbUseRArm";
            this.cbUseRArm.UseVisualStyleBackColor = true;
            this.cbUseRArm.CheckedChanged += new System.EventHandler(this.cbUseRArm_CheckedChanged);
            this.cbUseRArm.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbUseRArm.Click += new System.EventHandler(this.modeCheck);
            // 
            // cbActive
            // 
            resources.ApplyResources(this.cbActive, "cbActive");
            this.cbActive.ForeColor = System.Drawing.Color.Red;
            this.cbActive.Name = "cbActive";
            this.cbActive.UseVisualStyleBackColor = true;
            this.cbActive.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbActive.Click += new System.EventHandler(this.modeCheck);
            // 
            // Aligner_gb
            // 
            resources.ApplyResources(this.Aligner_gb, "Aligner_gb");
            this.Aligner_gb.Controls.Add(this.label9);
            this.Aligner_gb.Controls.Add(this.tbA1_speed);
            this.Aligner_gb.Controls.Add(this.cbUseA1);
            this.Aligner_gb.Name = "Aligner_gb";
            this.Aligner_gb.TabStop = false;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // tbA1_speed
            // 
            resources.ApplyResources(this.tbA1_speed, "tbA1_speed");
            this.tbA1_speed.Name = "tbA1_speed";
            this.tbA1_speed.Click += new System.EventHandler(this.modeCheck);
            this.tbA1_speed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_KeyPress);
            this.tbA1_speed.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.modeCheck);
            // 
            // cbUseA1
            // 
            resources.ApplyResources(this.cbUseA1, "cbUseA1");
            this.cbUseA1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cbUseA1.Name = "cbUseA1";
            this.cbUseA1.UseVisualStyleBackColor = true;
            this.cbUseA1.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbUseA1.Click += new System.EventHandler(this.modeCheck);
            // 
            // gbAccount
            // 
            resources.ApplyResources(this.gbAccount, "gbAccount");
            this.gbAccount.Controls.Add(this.tlpAccountCreate);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.TabStop = false;
            // 
            // palMenu
            // 
            resources.ApplyResources(this.palMenu, "palMenu");
            this.palMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.palMenu.Controls.Add(this.tlpAccountMenu);
            this.palMenu.Name = "palMenu";
            // 
            // tlpAccountMenu
            // 
            resources.ApplyResources(this.tlpAccountMenu, "tlpAccountMenu");
            this.tlpAccountMenu.Controls.Add(this.btnModifyRecipe, 0, 0);
            this.tlpAccountMenu.Controls.Add(this.btnCreateRecipe, 0, 0);
            this.tlpAccountMenu.Controls.Add(this.btnDeleteRecipe, 2, 0);
            this.tlpAccountMenu.Name = "tlpAccountMenu";
            // 
            // btnModifyRecipe
            // 
            resources.ApplyResources(this.btnModifyRecipe, "btnModifyRecipe");
            this.btnModifyRecipe.BackColor = System.Drawing.Color.Silver;
            this.btnModifyRecipe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModifyRecipe.FlatAppearance.BorderSize = 2;
            this.btnModifyRecipe.Name = "btnModifyRecipe";
            this.btnModifyRecipe.UseVisualStyleBackColor = false;
            this.btnModifyRecipe.Click += new System.EventHandler(this.btnModifyRecipe_Click);
            // 
            // btnCreateRecipe
            // 
            resources.ApplyResources(this.btnCreateRecipe, "btnCreateRecipe");
            this.btnCreateRecipe.BackColor = System.Drawing.Color.Silver;
            this.btnCreateRecipe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateRecipe.FlatAppearance.BorderSize = 2;
            this.btnCreateRecipe.Name = "btnCreateRecipe";
            this.btnCreateRecipe.UseVisualStyleBackColor = false;
            this.btnCreateRecipe.Click += new System.EventHandler(this.btnCreateRecipe_Click);
            // 
            // btnDeleteRecipe
            // 
            resources.ApplyResources(this.btnDeleteRecipe, "btnDeleteRecipe");
            this.btnDeleteRecipe.BackColor = System.Drawing.Color.Silver;
            this.btnDeleteRecipe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteRecipe.FlatAppearance.BorderSize = 2;
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.UseVisualStyleBackColor = false;
            this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
            // 
            // palContainer
            // 
            resources.ApplyResources(this.palContainer, "palContainer");
            this.palContainer.Controls.Add(this.gbAccount);
            this.palContainer.Name = "palContainer";
            // 
            // tlpAccount
            // 
            resources.ApplyResources(this.tlpAccount, "tlpAccount");
            this.tlpAccount.Controls.Add(this.palMenu, 0, 0);
            this.tlpAccount.Controls.Add(this.palContainer, 0, 1);
            this.tlpAccount.Name = "tlpAccount";
            // 
            // FormRecipeSetting_1R1A2P
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRecipeSetting_1R1A2P";
            this.Load += new System.EventHandler(this.FormRecipeSetting_Load);
            this.gbAccountCondition.ResumeLayout(false);
            this.tlpAccountCreate.ResumeLayout(false);
            this.gbRecipe.ResumeLayout(false);
            this.gbRecipeHeader.ResumeLayout(false);
            this.gbRecipeHeader.PerformLayout();
            this.gbRecipeBody.ResumeLayout(false);
            this.gbRecipeBody.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Aligner_gb.ResumeLayout(false);
            this.Aligner_gb.PerformLayout();
            this.gbAccount.ResumeLayout(false);
            this.palMenu.ResumeLayout(false);
            this.tlpAccountMenu.ResumeLayout(false);
            this.palContainer.ResumeLayout(false);
            this.tlpAccount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView trvRecipe;
        private System.Windows.Forms.GroupBox gbAccountCondition;
        private System.Windows.Forms.TableLayoutPanel tlpAccountCreate;
        private System.Windows.Forms.GroupBox gbAccount;
        private System.Windows.Forms.Panel palMenu;
        private System.Windows.Forms.TableLayoutPanel tlpAccountMenu;
        private System.Windows.Forms.Button btnModifyRecipe;
        private System.Windows.Forms.Button btnCreateRecipe;
        private System.Windows.Forms.Panel palContainer;
        private System.Windows.Forms.TableLayoutPanel tlpAccount;
        private System.Windows.Forms.GroupBox gbRecipe;
        private System.Windows.Forms.TextBox tbRecipeID;
        private System.Windows.Forms.TextBox tbRecipeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbRecipeHeader;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeleteRecipe;
        private System.Windows.Forms.GroupBox gbRecipeBody;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbNotch_angle;
        private System.Windows.Forms.ComboBox cbP2LoadType;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox cbP1LoadType;
        private System.Windows.Forms.ComboBox cbP2CstType;
        private System.Windows.Forms.ComboBox cbP1CstType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.CheckBox cbUseBurnIn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tbR1Speed;
        private System.Windows.Forms.ComboBox cbPutSlotOrder;
        private System.Windows.Forms.ComboBox cbGetSlotOrder;
        private System.Windows.Forms.CheckBox cbUserBothArm;
        private System.Windows.Forms.CheckBox cbUseLArm;
        private System.Windows.Forms.CheckBox cbUseRArm;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.GroupBox Aligner_gb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbA1_speed;
        private System.Windows.Forms.CheckBox cbUseA1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbOutputFin1;
        private System.Windows.Forms.ComboBox cbOutputFin2;
        private System.Windows.Forms.ComboBox cbOutputFin3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbInputFin1;
        private System.Windows.Forms.ComboBox cbInputFin2;
        private System.Windows.Forms.ComboBox cbInputFin3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbWaferSize;
    }
}