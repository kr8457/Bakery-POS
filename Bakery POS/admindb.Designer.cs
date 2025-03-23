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
            panel4 = new Panel();
            label6 = new Label();
            label2 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel5 = new Panel();
            label15 = new Label();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            btn_ok.Location = new Point(593, 4);
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
            panel1.Size = new Size(513, 77);
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
            chart1.Location = new Point(15, 141);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(862, 274);
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
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(882, 141);
            chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart2.Series.Add(series2);
            chart2.Size = new Size(435, 563);
            chart2.TabIndex = 16;
            chart2.Text = "chart2";
            title2.Alignment = ContentAlignment.TopLeft;
            title2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title2.Name = "Title1";
            title2.Text = "Top 5 Products";
            chart2.Titles.Add(title2);
            // 
            // panel4
            // 
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(15, 430);
            panel4.Name = "panel4";
            panel4.Size = new Size(275, 279);
            panel4.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(196, 41);
            label6.TabIndex = 13;
            label6.Text = "Total Counter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 50);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 11;
            label2.Text = "Number of Customers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 70);
            label4.Name = "label4";
            label4.Size = new Size(130, 41);
            label4.TabIndex = 12;
            label4.Text = "1000000";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(17, 128);
            label7.Name = "label7";
            label7.Size = new Size(146, 20);
            label7.TabIndex = 14;
            label7.Text = "Number of Suppliers";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(41, 148);
            label8.Name = "label8";
            label8.Size = new Size(130, 41);
            label8.TabIndex = 15;
            label8.Text = "1000000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(17, 213);
            label9.Name = "label9";
            label9.Size = new Size(142, 20);
            label9.TabIndex = 16;
            label9.Text = "Number of Products";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(41, 233);
            label10.Name = "label10";
            label10.Size = new Size(130, 41);
            label10.TabIndex = 17;
            label10.Text = "1000000";
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridView1);
            panel5.Controls.Add(label15);
            panel5.Location = new Point(331, 430);
            panel5.Name = "panel5";
            panel5.Size = new Size(546, 279);
            panel5.TabIndex = 18;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(3, 0);
            label15.Name = "label15";
            label15.Size = new Size(297, 41);
            label15.TabIndex = 13;
            label15.Text = "Products UnderStock";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(500, 188);
            dataGridView1.TabIndex = 19;
            // 
            // admindb
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 119, 182);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel5);
            Controls.Add(panel4);
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
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Panel panel4;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label9;
        private Label label10;
        private Label label7;
        private Label label8;
        private Panel panel5;
        private DataGridView dataGridView1;
        private Label label15;
    }
}
