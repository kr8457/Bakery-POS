namespace Bakery_POS
{
    partial class admindb
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            DtpStartDate = new DateTimePicker();
            DtpEndDate = new DateTimePicker();
            btn_thismonth = new Button();
            btn_Last30days = new Button();
            btn_last7days = new Button();
            btn_today = new Button();
            btn_custom = new Button();
            btn_ok = new Button();
            panel2 = new Panel();
            label1 = new Label();
            lbl_numberoforders = new Label();
            panel3 = new Panel();
            label5 = new Label();
            lbl_totalrevenue = new Label();
            panel1 = new Panel();
            label3 = new Label();
            lbl_totalprofit = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            SuspendLayout();
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // cuiLabel1
            // 
            cuiLabel1.Content = "Dash\\ Board";
            cuiLabel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            cuiLabel1.Location = new Point(0, 0);
            cuiLabel1.Margin = new Padding(4, 5, 4, 5);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(186, 40);
            cuiLabel1.TabIndex = 1;
            // 
            // DtpStartDate
            // 
            DtpStartDate.CustomFormat = "MMM dd,yyyy";
            DtpStartDate.Format = DateTimePickerFormat.Custom;
            DtpStartDate.Location = new Point(264, 6);
            DtpStartDate.Name = "DtpStartDate";
            DtpStartDate.Size = new Size(139, 27);
            DtpStartDate.TabIndex = 3;
            // 
            // DtpEndDate
            // 
            DtpEndDate.CustomFormat = "MMM dd,yyyy";
            DtpEndDate.Format = DateTimePickerFormat.Custom;
            DtpEndDate.Location = new Point(409, 6);
            DtpEndDate.Name = "DtpEndDate";
            DtpEndDate.Size = new Size(139, 27);
            DtpEndDate.TabIndex = 4;
            // 
            // btn_thismonth
            // 
            btn_thismonth.Location = new Point(1188, 4);
            btn_thismonth.Name = "btn_thismonth";
            btn_thismonth.Size = new Size(129, 29);
            btn_thismonth.TabIndex = 5;
            btn_thismonth.Text = "This Month";
            btn_thismonth.UseVisualStyleBackColor = true;
            // 
            // btn_Last30days
            // 
            btn_Last30days.Location = new Point(1053, 4);
            btn_Last30days.Name = "btn_Last30days";
            btn_Last30days.Size = new Size(129, 29);
            btn_Last30days.TabIndex = 6;
            btn_Last30days.Text = "Last 30 Days";
            btn_Last30days.UseVisualStyleBackColor = true;
            // 
            // btn_last7days
            // 
            btn_last7days.Location = new Point(918, 4);
            btn_last7days.Name = "btn_last7days";
            btn_last7days.Size = new Size(129, 29);
            btn_last7days.TabIndex = 7;
            btn_last7days.Text = "Last 7 Days";
            btn_last7days.UseVisualStyleBackColor = true;
            // 
            // btn_today
            // 
            btn_today.Location = new Point(783, 4);
            btn_today.Name = "btn_today";
            btn_today.Size = new Size(129, 29);
            btn_today.TabIndex = 8;
            btn_today.Text = "Today";
            btn_today.UseVisualStyleBackColor = true;
            // 
            // btn_custom
            // 
            btn_custom.Location = new Point(648, 4);
            btn_custom.Name = "btn_custom";
            btn_custom.Size = new Size(129, 29);
            btn_custom.TabIndex = 9;
            btn_custom.Text = "Custom";
            btn_custom.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(592, 4);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(50, 29);
            btn_ok.TabIndex = 10;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lbl_numberoforders);
            panel2.Location = new Point(14, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 77);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 11;
            label1.Text = "Number of Orders";
            // 
            // lbl_numberoforders
            // 
            lbl_numberoforders.AutoSize = true;
            lbl_numberoforders.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_numberoforders.Location = new Point(43, 20);
            lbl_numberoforders.Name = "lbl_numberoforders";
            lbl_numberoforders.Size = new Size(130, 41);
            lbl_numberoforders.TabIndex = 12;
            lbl_numberoforders.Text = "1000000";
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(lbl_totalrevenue);
            panel3.Location = new Point(309, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(468, 77);
            panel3.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(43, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 11;
            label5.Text = "Total Revenue";
            // 
            // lbl_totalrevenue
            // 
            lbl_totalrevenue.AutoSize = true;
            lbl_totalrevenue.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_totalrevenue.Location = new Point(43, 20);
            lbl_totalrevenue.Name = "lbl_totalrevenue";
            lbl_totalrevenue.Size = new Size(130, 41);
            lbl_totalrevenue.TabIndex = 12;
            lbl_totalrevenue.Text = "1000000";
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbl_totalprofit);
            panel1.Location = new Point(804, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 77);
            panel1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 11;
            label3.Text = "Total Profit";
            // 
            // lbl_totalprofit
            // 
            lbl_totalprofit.AutoSize = true;
            lbl_totalprofit.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_totalprofit.Location = new Point(43, 20);
            lbl_totalprofit.Name = "lbl_totalprofit";
            lbl_totalprofit.Size = new Size(130, 41);
            lbl_totalprofit.TabIndex = 12;
            lbl_totalprofit.Text = "1000000";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(14, 141);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(736, 274);
            chart1.TabIndex = 15;
            chart1.Text = "chart1";
            title1.Alignment = ContentAlignment.TopLeft;
            title1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title1.Name = "Title1";
            title1.Text = "Gross Revenue";
            chart1.Titles.Add(title1);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(770, 141);
            chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart2.Series.Add(series2);
            chart2.Size = new Size(381, 274);
            chart2.TabIndex = 16;
            chart2.Text = "chart2";
            title2.Alignment = ContentAlignment.TopLeft;
            title2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title2.Name = "Title1";
            title2.Text = "Gross Revenue";
            chart2.Titles.Add(title2);
            // 
            // admindb
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 119, 182);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(chart2);
            Controls.Add(chart1);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btn_ok);
            Controls.Add(btn_custom);
            Controls.Add(btn_today);
            Controls.Add(btn_last7days);
            Controls.Add(btn_Last30days);
            Controls.Add(btn_thismonth);
            Controls.Add(DtpEndDate);
            Controls.Add(DtpStartDate);
            Controls.Add(cuiLabel1);
            Name = "admindb";
            Size = new Size(1320, 751);
            Load += admindb_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private DateTimePicker DtpStartDate;
        private DateTimePicker DtpEndDate;
        private Button btn_thismonth;
        private Button btn_Last30days;
        private Button btn_last7days;
        private Button btn_today;
        private Button btn_custom;
        private Button btn_ok;
        private Panel panel2;
        private Label label1;
        private Label lbl_numberoforders;
        private Panel panel3;
        private Label label5;
        private Label lbl_totalrevenue;
        private Panel panel1;
        private Label label3;
        private Label lbl_totalprofit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}
