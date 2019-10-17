namespace Adam.Menu.DifferentialMonitor
{
    partial class FormDifferentialMonitor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDifferential = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CurrentVal_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FFU_rpm_lb = new System.Windows.Forms.Label();
            this.FFU_RPM_tb = new System.Windows.Forms.TextBox();
            this.FFU_Set_btn = new System.Windows.Forms.Button();
            this.FFU_Start_btn = new System.Windows.Forms.Button();
            this.FFU_Stop_btn = new System.Windows.Forms.Button();
            this.FFU_AlarmBypass_btn = new System.Windows.Forms.Button();
            this.ControlGrop = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartDifferential)).BeginInit();
            this.ControlGrop.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartDifferential
            // 
            chartArea2.BorderColor = System.Drawing.Color.DarkGray;
            chartArea2.Name = "ChartArea1";
            this.chartDifferential.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDifferential.Legends.Add(legend2);
            this.chartDifferential.Location = new System.Drawing.Point(12, 12);
            this.chartDifferential.Name = "chartDifferential";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDifferential.Series.Add(series2);
            this.chartDifferential.Size = new System.Drawing.Size(1596, 736);
            this.chartDifferential.TabIndex = 0;
            this.chartDifferential.Text = "chart1";
            // 
            // CurrentVal_lb
            // 
            this.CurrentVal_lb.AutoSize = true;
            this.CurrentVal_lb.Location = new System.Drawing.Point(1536, 79);
            this.CurrentVal_lb.Name = "CurrentVal_lb";
            this.CurrentVal_lb.Size = new System.Drawing.Size(54, 20);
            this.CurrentVal_lb.TabIndex = 1;
            this.CurrentVal_lb.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1424, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current(Pa):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1424, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "FFU(rpm):";
            // 
            // FFU_rpm_lb
            // 
            this.FFU_rpm_lb.AutoSize = true;
            this.FFU_rpm_lb.Location = new System.Drawing.Point(1536, 142);
            this.FFU_rpm_lb.Name = "FFU_rpm_lb";
            this.FFU_rpm_lb.Size = new System.Drawing.Size(40, 20);
            this.FFU_rpm_lb.TabIndex = 3;
            this.FFU_rpm_lb.Text = "N/A";
            // 
            // FFU_RPM_tb
            // 
            this.FFU_RPM_tb.Location = new System.Drawing.Point(8, 145);
            this.FFU_RPM_tb.Name = "FFU_RPM_tb";
            this.FFU_RPM_tb.Size = new System.Drawing.Size(73, 29);
            this.FFU_RPM_tb.TabIndex = 5;
            // 
            // FFU_Set_btn
            // 
            this.FFU_Set_btn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.FFU_Set_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FFU_Set_btn.Location = new System.Drawing.Point(87, 145);
            this.FFU_Set_btn.Name = "FFU_Set_btn";
            this.FFU_Set_btn.Size = new System.Drawing.Size(83, 28);
            this.FFU_Set_btn.TabIndex = 6;
            this.FFU_Set_btn.Text = "Set RPM";
            this.FFU_Set_btn.UseVisualStyleBackColor = false;
            this.FFU_Set_btn.Click += new System.EventHandler(this.FFU_Set_btn_Click);
            // 
            // FFU_Start_btn
            // 
            this.FFU_Start_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.FFU_Start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FFU_Start_btn.Location = new System.Drawing.Point(87, 28);
            this.FFU_Start_btn.Name = "FFU_Start_btn";
            this.FFU_Start_btn.Size = new System.Drawing.Size(83, 28);
            this.FFU_Start_btn.TabIndex = 7;
            this.FFU_Start_btn.Text = "Start";
            this.FFU_Start_btn.UseVisualStyleBackColor = false;
            this.FFU_Start_btn.Click += new System.EventHandler(this.FFU_Start_btn_Click);
            // 
            // FFU_Stop_btn
            // 
            this.FFU_Stop_btn.BackColor = System.Drawing.Color.DarkRed;
            this.FFU_Stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FFU_Stop_btn.ForeColor = System.Drawing.Color.White;
            this.FFU_Stop_btn.Location = new System.Drawing.Point(87, 87);
            this.FFU_Stop_btn.Name = "FFU_Stop_btn";
            this.FFU_Stop_btn.Size = new System.Drawing.Size(83, 28);
            this.FFU_Stop_btn.TabIndex = 8;
            this.FFU_Stop_btn.Text = "Stop";
            this.FFU_Stop_btn.UseVisualStyleBackColor = false;
            this.FFU_Stop_btn.Click += new System.EventHandler(this.FFU_Stop_btn_Click);
            // 
            // FFU_AlarmBypass_btn
            // 
            this.FFU_AlarmBypass_btn.BackColor = System.Drawing.Color.Orange;
            this.FFU_AlarmBypass_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FFU_AlarmBypass_btn.Location = new System.Drawing.Point(49, 194);
            this.FFU_AlarmBypass_btn.Name = "FFU_AlarmBypass_btn";
            this.FFU_AlarmBypass_btn.Size = new System.Drawing.Size(121, 28);
            this.FFU_AlarmBypass_btn.TabIndex = 9;
            this.FFU_AlarmBypass_btn.Text = "Alarm Bypass";
            this.FFU_AlarmBypass_btn.UseVisualStyleBackColor = false;
            this.FFU_AlarmBypass_btn.Click += new System.EventHandler(this.FFU_AlarmBypass_btn_Click);
            // 
            // ControlGrop
            // 
            this.ControlGrop.BackColor = System.Drawing.Color.White;
            this.ControlGrop.Controls.Add(this.FFU_Start_btn);
            this.ControlGrop.Controls.Add(this.FFU_AlarmBypass_btn);
            this.ControlGrop.Controls.Add(this.FFU_RPM_tb);
            this.ControlGrop.Controls.Add(this.FFU_Stop_btn);
            this.ControlGrop.Controls.Add(this.FFU_Set_btn);
            this.ControlGrop.Location = new System.Drawing.Point(1424, 207);
            this.ControlGrop.Name = "ControlGrop";
            this.ControlGrop.Size = new System.Drawing.Size(179, 248);
            this.ControlGrop.TabIndex = 10;
            this.ControlGrop.TabStop = false;
            // 
            // FormDifferentialMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 760);
            this.Controls.Add(this.ControlGrop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FFU_rpm_lb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentVal_lb);
            this.Controls.Add(this.chartDifferential);
            this.Name = "FormDifferentialMonitor";
            this.Text = "FormTestMode";
            ((System.ComponentModel.ISupportInitialize)(this.chartDifferential)).EndInit();
            this.ControlGrop.ResumeLayout(false);
            this.ControlGrop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDifferential;
        private System.Windows.Forms.Label CurrentVal_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FFU_rpm_lb;
        private System.Windows.Forms.TextBox FFU_RPM_tb;
        private System.Windows.Forms.Button FFU_Set_btn;
        private System.Windows.Forms.Button FFU_Start_btn;
        private System.Windows.Forms.Button FFU_Stop_btn;
        private System.Windows.Forms.Button FFU_AlarmBypass_btn;
        private System.Windows.Forms.GroupBox ControlGrop;
    }
}