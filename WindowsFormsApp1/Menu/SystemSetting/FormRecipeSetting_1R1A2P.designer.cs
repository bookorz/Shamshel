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
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.cbManualFin1 = new System.Windows.Forms.ComboBox();
            this.cbAutoFin1 = new System.Windows.Forms.ComboBox();
            this.cbManualFin2 = new System.Windows.Forms.ComboBox();
            this.cbAutoFin2 = new System.Windows.Forms.ComboBox();
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
            this.lblMode = new System.Windows.Forms.Label();
            this.cbUseBurnIn = new System.Windows.Forms.CheckBox();
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
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
            this.groupBox8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbAccount.SuspendLayout();
            this.palMenu.SuspendLayout();
            this.tlpAccountMenu.SuspendLayout();
            this.palContainer.SuspendLayout();
            this.tlpAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvRecipe
            // 
            this.trvRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvRecipe.Location = new System.Drawing.Point(3, 29);
            this.trvRecipe.Name = "trvRecipe";
            this.trvRecipe.Size = new System.Drawing.Size(140, 603);
            this.trvRecipe.TabIndex = 0;
            this.trvRecipe.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvRecipe_AfterSelect);
            this.trvRecipe.Validating += new System.ComponentModel.CancelEventHandler(this.trvRecipe_Validating);
            // 
            // gbAccountCondition
            // 
            this.gbAccountCondition.Controls.Add(this.trvRecipe);
            this.gbAccountCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAccountCondition.Location = new System.Drawing.Point(3, 3);
            this.gbAccountCondition.Name = "gbAccountCondition";
            this.gbAccountCondition.Size = new System.Drawing.Size(146, 635);
            this.gbAccountCondition.TabIndex = 0;
            this.gbAccountCondition.TabStop = false;
            this.gbAccountCondition.Text = "Recipe List";
            // 
            // tlpAccountCreate
            // 
            this.tlpAccountCreate.ColumnCount = 2;
            this.tlpAccountCreate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
            this.tlpAccountCreate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.28571F));
            this.tlpAccountCreate.Controls.Add(this.gbAccountCondition, 0, 0);
            this.tlpAccountCreate.Controls.Add(this.gbRecipe, 1, 0);
            this.tlpAccountCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAccountCreate.Location = new System.Drawing.Point(3, 29);
            this.tlpAccountCreate.Name = "tlpAccountCreate";
            this.tlpAccountCreate.RowCount = 1;
            this.tlpAccountCreate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAccountCreate.Size = new System.Drawing.Size(1420, 641);
            this.tlpAccountCreate.TabIndex = 0;
            // 
            // gbRecipe
            // 
            this.gbRecipe.Controls.Add(this.gbRecipeHeader);
            this.gbRecipe.Controls.Add(this.btnCancel);
            this.gbRecipe.Controls.Add(this.btnSave);
            this.gbRecipe.Controls.Add(this.gbRecipeBody);
            this.gbRecipe.Location = new System.Drawing.Point(155, 3);
            this.gbRecipe.Name = "gbRecipe";
            this.gbRecipe.Size = new System.Drawing.Size(1259, 635);
            this.gbRecipe.TabIndex = 1;
            this.gbRecipe.TabStop = false;
            this.gbRecipe.Text = "Recipe body";
            // 
            // gbRecipeHeader
            // 
            this.gbRecipeHeader.Controls.Add(this.tbRecipeID);
            this.gbRecipeHeader.Controls.Add(this.label1);
            this.gbRecipeHeader.Controls.Add(this.label2);
            this.gbRecipeHeader.Controls.Add(this.tbRecipeName);
            this.gbRecipeHeader.Location = new System.Drawing.Point(6, 24);
            this.gbRecipeHeader.Margin = new System.Windows.Forms.Padding(1);
            this.gbRecipeHeader.Name = "gbRecipeHeader";
            this.gbRecipeHeader.Padding = new System.Windows.Forms.Padding(1);
            this.gbRecipeHeader.Size = new System.Drawing.Size(761, 68);
            this.gbRecipeHeader.TabIndex = 10;
            this.gbRecipeHeader.TabStop = false;
            // 
            // tbRecipeID
            // 
            this.tbRecipeID.Location = new System.Drawing.Point(463, 26);
            this.tbRecipeID.Name = "tbRecipeID";
            this.tbRecipeID.ReadOnly = true;
            this.tbRecipeID.Size = new System.Drawing.Size(201, 33);
            this.tbRecipeID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipe ID*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Recipe Name*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbRecipeName
            // 
            this.tbRecipeName.Location = new System.Drawing.Point(148, 26);
            this.tbRecipeName.Name = "tbRecipeName";
            this.tbRecipeName.ReadOnly = true;
            this.tbRecipeName.Size = new System.Drawing.Size(201, 33);
            this.tbRecipeName.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(968, 34);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 38);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(1100, 34);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 38);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbRecipeBody
            // 
            this.gbRecipeBody.Controls.Add(this.label6);
            this.gbRecipeBody.Controls.Add(this.groupBox9);
            this.gbRecipeBody.Controls.Add(this.groupBox2);
            this.gbRecipeBody.Controls.Add(this.lblMode);
            this.gbRecipeBody.Controls.Add(this.cbUseBurnIn);
            this.gbRecipeBody.Controls.Add(this.groupBox3);
            this.gbRecipeBody.Controls.Add(this.cbActive);
            this.gbRecipeBody.Controls.Add(this.groupBox4);
            this.gbRecipeBody.Location = new System.Drawing.Point(6, 81);
            this.gbRecipeBody.Name = "gbRecipeBody";
            this.gbRecipeBody.Size = new System.Drawing.Size(1247, 551);
            this.gbRecipeBody.TabIndex = 8;
            this.gbRecipeBody.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(310, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "目前模式:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label11);
            this.groupBox9.Controls.Add(this.groupBox8);
            this.groupBox9.Location = new System.Drawing.Point(310, 249);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(494, 244);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "完工處置";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.Color.Brown;
            this.label11.Location = new System.Drawing.Point(289, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 140);
            this.label11.TabIndex = 6;
            this.label11.Text = "0: Red light\r\n1: Orange light\r\n2: Green light\r\n3: Blue light\r\n4: Buzzer 1\r\n5: Buz" +
    "zer 2\r\nN: 無動作";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.label22);
            this.groupBox8.Controls.Add(this.label34);
            this.groupBox8.Controls.Add(this.label24);
            this.groupBox8.Controls.Add(this.cbManualFin1);
            this.groupBox8.Controls.Add(this.cbAutoFin1);
            this.groupBox8.Controls.Add(this.cbManualFin2);
            this.groupBox8.Controls.Add(this.cbAutoFin2);
            this.groupBox8.Location = new System.Drawing.Point(6, 34);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(277, 204);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "整機完工";
            this.groupBox8.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.Chocolate;
            this.label10.Location = new System.Drawing.Point(199, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Buzzer";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label22.ForeColor = System.Drawing.Color.Chocolate;
            this.label22.Location = new System.Drawing.Point(138, 29);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 24);
            this.label22.TabIndex = 0;
            this.label22.Text = "Light";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label34.Location = new System.Drawing.Point(2, 99);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(135, 24);
            this.label34.TabIndex = 0;
            this.label34.Text = "Manual Mode";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label24.Location = new System.Drawing.Point(25, 61);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(112, 24);
            this.label24.TabIndex = 0;
            this.label24.Text = "Auto Mode";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbManualFin1
            // 
            this.cbManualFin1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbManualFin1.FormattingEnabled = true;
            this.cbManualFin1.Items.AddRange(new object[] {
            "N",
            "0",
            "1",
            "2",
            "3"});
            this.cbManualFin1.Location = new System.Drawing.Point(143, 96);
            this.cbManualFin1.Name = "cbManualFin1";
            this.cbManualFin1.Size = new System.Drawing.Size(43, 32);
            this.cbManualFin1.TabIndex = 2;
            this.cbManualFin1.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbManualFin1.Click += new System.EventHandler(this.modeCheck);
            // 
            // cbAutoFin1
            // 
            this.cbAutoFin1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutoFin1.FormattingEnabled = true;
            this.cbAutoFin1.Items.AddRange(new object[] {
            "N",
            "0",
            "1",
            "2",
            "3"});
            this.cbAutoFin1.Location = new System.Drawing.Point(143, 61);
            this.cbAutoFin1.Name = "cbAutoFin1";
            this.cbAutoFin1.Size = new System.Drawing.Size(43, 32);
            this.cbAutoFin1.TabIndex = 2;
            this.cbAutoFin1.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbAutoFin1.Click += new System.EventHandler(this.modeCheck);
            // 
            // cbManualFin2
            // 
            this.cbManualFin2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbManualFin2.FormattingEnabled = true;
            this.cbManualFin2.Items.AddRange(new object[] {
            "N",
            "4",
            "5"});
            this.cbManualFin2.Location = new System.Drawing.Point(213, 96);
            this.cbManualFin2.Name = "cbManualFin2";
            this.cbManualFin2.Size = new System.Drawing.Size(43, 32);
            this.cbManualFin2.TabIndex = 2;
            this.cbManualFin2.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbManualFin2.Click += new System.EventHandler(this.modeCheck);
            // 
            // cbAutoFin2
            // 
            this.cbAutoFin2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutoFin2.FormattingEnabled = true;
            this.cbAutoFin2.Items.AddRange(new object[] {
            "N",
            "4",
            "5"});
            this.cbAutoFin2.Location = new System.Drawing.Point(213, 61);
            this.cbAutoFin2.Name = "cbAutoFin2";
            this.cbAutoFin2.Size = new System.Drawing.Size(43, 32);
            this.cbAutoFin2.TabIndex = 2;
            this.cbAutoFin2.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbAutoFin2.Click += new System.EventHandler(this.modeCheck);
            // 
            // groupBox2
            // 
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
            this.groupBox2.Location = new System.Drawing.Point(6, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 213);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Area 1 Port Setting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(75, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label29.Location = new System.Drawing.Point(9, 156);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(123, 24);
            this.label29.TabIndex = 0;
            this.label29.Text = "Notch Angle";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label26.ForeColor = System.Drawing.Color.Chocolate;
            this.label26.Location = new System.Drawing.Point(138, 29);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(119, 24);
            this.label26.TabIndex = 0;
            this.label26.Text = "Carrier Type";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbNotch_angle
            // 
            this.tbNotch_angle.Location = new System.Drawing.Point(138, 151);
            this.tbNotch_angle.Name = "tbNotch_angle";
            this.tbNotch_angle.Size = new System.Drawing.Size(109, 33);
            this.tbNotch_angle.TabIndex = 1;
            this.tbNotch_angle.Text = "0";
            this.tbNotch_angle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNotch_angle.Click += new System.EventHandler(this.modeCheck);
            this.tbNotch_angle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_KeyPress);
            this.tbNotch_angle.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.modeCheck);
            // 
            // cbP2LoadType
            // 
            this.cbP2LoadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbP2LoadType.FormattingEnabled = true;
            this.cbP2LoadType.Items.AddRange(new object[] {
            "L",
            "U",
            "N"});
            this.cbP2LoadType.Location = new System.Drawing.Point(77, 97);
            this.cbP2LoadType.Name = "cbP2LoadType";
            this.cbP2LoadType.Size = new System.Drawing.Size(52, 32);
            this.cbP2LoadType.TabIndex = 2;
            this.cbP2LoadType.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbP2LoadType.Click += new System.EventHandler(this.modeCheck);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label35.ForeColor = System.Drawing.Color.Brown;
            this.label35.Location = new System.Drawing.Point(282, 19);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(244, 180);
            this.label35.TabIndex = 0;
            this.label35.Text = "Port type\r\nL: Load port\r\nU: Unload port\r\nN: No use\r\n\r\nCarrier Type\r\nFOUP: 12吋前開式晶" +
    "圓傳送盒\r\nFOSB: 12吋前開式出貨盒\r\nADAPT_8: 8吋 Cassette Adapter";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbP1LoadType
            // 
            this.cbP1LoadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbP1LoadType.FormattingEnabled = true;
            this.cbP1LoadType.Items.AddRange(new object[] {
            "L",
            "U",
            "N"});
            this.cbP1LoadType.Location = new System.Drawing.Point(77, 57);
            this.cbP1LoadType.Name = "cbP1LoadType";
            this.cbP1LoadType.Size = new System.Drawing.Size(52, 32);
            this.cbP1LoadType.TabIndex = 2;
            this.cbP1LoadType.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbP1LoadType.Click += new System.EventHandler(this.modeCheck);
            // 
            // cbP2CstType
            // 
            this.cbP2CstType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbP2CstType.FormattingEnabled = true;
            this.cbP2CstType.Items.AddRange(new object[] {
            "FOUP",
            "FOSB",
            "ADAPT_8"});
            this.cbP2CstType.Location = new System.Drawing.Point(142, 97);
            this.cbP2CstType.Name = "cbP2CstType";
            this.cbP2CstType.Size = new System.Drawing.Size(115, 32);
            this.cbP2CstType.TabIndex = 2;
            this.cbP2CstType.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbP2CstType.Click += new System.EventHandler(this.modeCheck);
            // 
            // cbP1CstType
            // 
            this.cbP1CstType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbP1CstType.FormattingEnabled = true;
            this.cbP1CstType.Items.AddRange(new object[] {
            "FOUP",
            "FOSB",
            "ADAPT_8"});
            this.cbP1CstType.Location = new System.Drawing.Point(142, 57);
            this.cbP1CstType.Name = "cbP1CstType";
            this.cbP1CstType.Size = new System.Drawing.Size(115, 32);
            this.cbP1CstType.TabIndex = 2;
            this.cbP1CstType.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbP1CstType.Click += new System.EventHandler(this.modeCheck);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label13.Location = new System.Drawing.Point(9, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "Port2";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(9, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Port1";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.BackColor = System.Drawing.Color.Yellow;
            this.lblMode.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMode.ForeColor = System.Drawing.Color.Red;
            this.lblMode.Location = new System.Drawing.Point(431, 496);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(110, 31);
            this.lblMode.TabIndex = 0;
            this.lblMode.Text = "瀏覽模式";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbUseBurnIn
            // 
            this.cbUseBurnIn.AutoSize = true;
            this.cbUseBurnIn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbUseBurnIn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cbUseBurnIn.Location = new System.Drawing.Point(1144, 517);
            this.cbUseBurnIn.Name = "cbUseBurnIn";
            this.cbUseBurnIn.Size = new System.Drawing.Size(97, 28);
            this.cbUseBurnIn.TabIndex = 4;
            this.cbUseBurnIn.Text = "Burn-In";
            this.cbUseBurnIn.UseVisualStyleBackColor = true;
            this.cbUseBurnIn.Click += new System.EventHandler(this.modeCheck);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.tbR1Speed);
            this.groupBox3.Controls.Add(this.cbPutSlotOrder);
            this.groupBox3.Controls.Add(this.cbGetSlotOrder);
            this.groupBox3.Controls.Add(this.cbUserBothArm);
            this.groupBox3.Controls.Add(this.cbUseLArm);
            this.groupBox3.Controls.Add(this.cbUseRArm);
            this.groupBox3.Location = new System.Drawing.Point(6, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 180);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Robot  Setting";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label38.Location = new System.Drawing.Point(6, 137);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(86, 24);
            this.label38.TabIndex = 0;
            this.label38.Text = "放片順序";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "取片順序";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label30.Location = new System.Drawing.Point(5, 32);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(143, 24);
            this.label30.TabIndex = 0;
            this.label30.Text = "Robot 1 Speed";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbR1Speed
            // 
            this.tbR1Speed.Location = new System.Drawing.Point(154, 27);
            this.tbR1Speed.Name = "tbR1Speed";
            this.tbR1Speed.Size = new System.Drawing.Size(61, 33);
            this.tbR1Speed.TabIndex = 1;
            this.tbR1Speed.Text = "100";
            this.tbR1Speed.Click += new System.EventHandler(this.modeCheck);
            this.tbR1Speed.TextChanged += new System.EventHandler(this.modeCheck);
            this.tbR1Speed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_KeyPress);
            this.tbR1Speed.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.modeCheck);
            // 
            // cbPutSlotOrder
            // 
            this.cbPutSlotOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPutSlotOrder.FormattingEnabled = true;
            this.cbPutSlotOrder.Items.AddRange(new object[] {
            "BOTTOM_UP",
            "TOP_DOWN"});
            this.cbPutSlotOrder.Location = new System.Drawing.Point(102, 134);
            this.cbPutSlotOrder.Name = "cbPutSlotOrder";
            this.cbPutSlotOrder.Size = new System.Drawing.Size(160, 32);
            this.cbPutSlotOrder.TabIndex = 2;
            this.cbPutSlotOrder.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbPutSlotOrder.Click += new System.EventHandler(this.modeCheck);
            // 
            // cbGetSlotOrder
            // 
            this.cbGetSlotOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGetSlotOrder.FormattingEnabled = true;
            this.cbGetSlotOrder.Items.AddRange(new object[] {
            "BOTTOM_UP",
            "TOP_DOWN"});
            this.cbGetSlotOrder.Location = new System.Drawing.Point(102, 97);
            this.cbGetSlotOrder.Name = "cbGetSlotOrder";
            this.cbGetSlotOrder.Size = new System.Drawing.Size(160, 32);
            this.cbGetSlotOrder.TabIndex = 2;
            this.cbGetSlotOrder.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbGetSlotOrder.Click += new System.EventHandler(this.modeCheck);
            // 
            // cbUserBothArm
            // 
            this.cbUserBothArm.AutoSize = true;
            this.cbUserBothArm.Enabled = false;
            this.cbUserBothArm.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbUserBothArm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cbUserBothArm.Location = new System.Drawing.Point(193, 66);
            this.cbUserBothArm.Name = "cbUserBothArm";
            this.cbUserBothArm.Size = new System.Drawing.Size(81, 28);
            this.cbUserBothArm.TabIndex = 4;
            this.cbUserBothArm.Text = "上+下";
            this.cbUserBothArm.UseVisualStyleBackColor = true;
            this.cbUserBothArm.CheckedChanged += new System.EventHandler(this.cbUserBothArm_CheckedChanged);
            this.cbUserBothArm.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbUserBothArm.Click += new System.EventHandler(this.modeCheck);
            // 
            // cbUseLArm
            // 
            this.cbUseLArm.AutoSize = true;
            this.cbUseLArm.Enabled = false;
            this.cbUseLArm.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbUseLArm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cbUseLArm.Location = new System.Drawing.Point(102, 66);
            this.cbUseLArm.Name = "cbUseLArm";
            this.cbUseLArm.Size = new System.Drawing.Size(89, 28);
            this.cbUseLArm.TabIndex = 4;
            this.cbUseLArm.Text = "下臂(L)";
            this.cbUseLArm.UseVisualStyleBackColor = true;
            this.cbUseLArm.CheckedChanged += new System.EventHandler(this.cbUseLArm_CheckedChanged);
            this.cbUseLArm.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbUseLArm.Click += new System.EventHandler(this.modeCheck);
            // 
            // cbUseRArm
            // 
            this.cbUseRArm.AutoSize = true;
            this.cbUseRArm.Checked = true;
            this.cbUseRArm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseRArm.Enabled = false;
            this.cbUseRArm.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbUseRArm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cbUseRArm.Location = new System.Drawing.Point(5, 66);
            this.cbUseRArm.Name = "cbUseRArm";
            this.cbUseRArm.Size = new System.Drawing.Size(91, 28);
            this.cbUseRArm.TabIndex = 4;
            this.cbUseRArm.Text = "上臂(R)";
            this.cbUseRArm.UseVisualStyleBackColor = true;
            this.cbUseRArm.CheckedChanged += new System.EventHandler(this.cbUseRArm_CheckedChanged);
            this.cbUseRArm.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbUseRArm.Click += new System.EventHandler(this.modeCheck);
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbActive.ForeColor = System.Drawing.Color.Red;
            this.cbActive.Location = new System.Drawing.Point(585, 32);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(176, 34);
            this.cbActive.TabIndex = 4;
            this.cbActive.Text = "生產參數生效";
            this.cbActive.UseVisualStyleBackColor = true;
            this.cbActive.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbActive.Click += new System.EventHandler(this.modeCheck);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.tbA1_speed);
            this.groupBox4.Controls.Add(this.cbUseA1);
            this.groupBox4.Location = new System.Drawing.Point(6, 423);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 104);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aligner Setting";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(99, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Speed";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbA1_speed
            // 
            this.tbA1_speed.Location = new System.Drawing.Point(111, 54);
            this.tbA1_speed.Name = "tbA1_speed";
            this.tbA1_speed.Size = new System.Drawing.Size(46, 33);
            this.tbA1_speed.TabIndex = 1;
            this.tbA1_speed.Text = "100";
            this.tbA1_speed.Click += new System.EventHandler(this.modeCheck);
            this.tbA1_speed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_KeyPress);
            this.tbA1_speed.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.modeCheck);
            // 
            // cbUseA1
            // 
            this.cbUseA1.AutoSize = true;
            this.cbUseA1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbUseA1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cbUseA1.Location = new System.Drawing.Point(6, 61);
            this.cbUseA1.Name = "cbUseA1";
            this.cbUseA1.Size = new System.Drawing.Size(105, 28);
            this.cbUseA1.TabIndex = 4;
            this.cbUseA1.Text = "Aligner1";
            this.cbUseA1.UseVisualStyleBackColor = true;
            this.cbUseA1.TextChanged += new System.EventHandler(this.modeCheck);
            this.cbUseA1.Click += new System.EventHandler(this.modeCheck);
            // 
            // gbAccount
            // 
            this.gbAccount.Controls.Add(this.tlpAccountCreate);
            this.gbAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAccount.Location = new System.Drawing.Point(0, 0);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.Size = new System.Drawing.Size(1426, 673);
            this.gbAccount.TabIndex = 65;
            this.gbAccount.TabStop = false;
            this.gbAccount.Text = "Recipe  setting";
            // 
            // palMenu
            // 
            this.palMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.palMenu.Controls.Add(this.tlpAccountMenu);
            this.palMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palMenu.Location = new System.Drawing.Point(3, 3);
            this.palMenu.Name = "palMenu";
            this.palMenu.Padding = new System.Windows.Forms.Padding(5);
            this.palMenu.Size = new System.Drawing.Size(1426, 67);
            this.palMenu.TabIndex = 20;
            // 
            // tlpAccountMenu
            // 
            this.tlpAccountMenu.ColumnCount = 7;
            this.tlpAccountMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpAccountMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpAccountMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpAccountMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpAccountMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpAccountMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpAccountMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpAccountMenu.Controls.Add(this.btnModifyRecipe, 0, 0);
            this.tlpAccountMenu.Controls.Add(this.btnCreateRecipe, 0, 0);
            this.tlpAccountMenu.Controls.Add(this.btnDeleteRecipe, 2, 0);
            this.tlpAccountMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAccountMenu.Location = new System.Drawing.Point(5, 5);
            this.tlpAccountMenu.Name = "tlpAccountMenu";
            this.tlpAccountMenu.RowCount = 1;
            this.tlpAccountMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAccountMenu.Size = new System.Drawing.Size(1412, 53);
            this.tlpAccountMenu.TabIndex = 64;
            // 
            // btnModifyRecipe
            // 
            this.btnModifyRecipe.BackColor = System.Drawing.Color.Silver;
            this.btnModifyRecipe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModifyRecipe.FlatAppearance.BorderSize = 2;
            this.btnModifyRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifyRecipe.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.btnModifyRecipe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModifyRecipe.Location = new System.Drawing.Point(204, 3);
            this.btnModifyRecipe.Name = "btnModifyRecipe";
            this.btnModifyRecipe.Size = new System.Drawing.Size(191, 45);
            this.btnModifyRecipe.TabIndex = 65;
            this.btnModifyRecipe.Text = "Modify Recipe";
            this.btnModifyRecipe.UseVisualStyleBackColor = false;
            this.btnModifyRecipe.Click += new System.EventHandler(this.btnModifyRecipe_Click);
            // 
            // btnCreateRecipe
            // 
            this.btnCreateRecipe.BackColor = System.Drawing.Color.Silver;
            this.btnCreateRecipe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateRecipe.FlatAppearance.BorderSize = 2;
            this.btnCreateRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateRecipe.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.btnCreateRecipe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCreateRecipe.Location = new System.Drawing.Point(3, 3);
            this.btnCreateRecipe.Name = "btnCreateRecipe";
            this.btnCreateRecipe.Size = new System.Drawing.Size(191, 45);
            this.btnCreateRecipe.TabIndex = 50;
            this.btnCreateRecipe.Text = "Create Recipe";
            this.btnCreateRecipe.UseVisualStyleBackColor = false;
            this.btnCreateRecipe.Click += new System.EventHandler(this.btnCreateRecipe_Click);
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.BackColor = System.Drawing.Color.Silver;
            this.btnDeleteRecipe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteRecipe.FlatAppearance.BorderSize = 2;
            this.btnDeleteRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteRecipe.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.btnDeleteRecipe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteRecipe.Location = new System.Drawing.Point(405, 3);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(191, 45);
            this.btnDeleteRecipe.TabIndex = 65;
            this.btnDeleteRecipe.Text = "Delete Recipe";
            this.btnDeleteRecipe.UseVisualStyleBackColor = false;
            this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
            // 
            // palContainer
            // 
            this.palContainer.Controls.Add(this.gbAccount);
            this.palContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palContainer.Location = new System.Drawing.Point(3, 76);
            this.palContainer.Name = "palContainer";
            this.palContainer.Size = new System.Drawing.Size(1426, 673);
            this.palContainer.TabIndex = 21;
            // 
            // tlpAccount
            // 
            this.tlpAccount.ColumnCount = 1;
            this.tlpAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAccount.Controls.Add(this.palMenu, 0, 0);
            this.tlpAccount.Controls.Add(this.palContainer, 0, 1);
            this.tlpAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAccount.Location = new System.Drawing.Point(0, 0);
            this.tlpAccount.Name = "tlpAccount";
            this.tlpAccount.RowCount = 2;
            this.tlpAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.791991F));
            this.tlpAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.20801F));
            this.tlpAccount.Size = new System.Drawing.Size(1432, 752);
            this.tlpAccount.TabIndex = 23;
            // 
            // FormRecipeSetting_1R1A2P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 752);
            this.Controls.Add(this.tlpAccount);
            this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormRecipeSetting_1R1A2P";
            this.Text = "FormRecipeSetting";
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
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbManualFin1;
        private System.Windows.Forms.ComboBox cbAutoFin1;
        private System.Windows.Forms.ComboBox cbManualFin2;
        private System.Windows.Forms.ComboBox cbAutoFin2;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbA1_speed;
        private System.Windows.Forms.CheckBox cbUseA1;
    }
}