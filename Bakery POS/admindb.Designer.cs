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
            panel4 = new Panel();
            label6 = new Label();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            label8 = new Label();
            label9 = new Label();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(2, 62, 138);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(671, 48);
            panel4.Name = "panel4";
            panel4.Size = new Size(252, 110);
            panel4.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(130, 81);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 15;
            label6.Text = "Today's Income";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(142, 11);
            label7.Name = "label7";
            label7.Size = new Size(17, 20);
            label7.TabIndex = 14;
            label7.Text = "0";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Cash;
            pictureBox3.Location = new Point(0, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(108, 110);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(2, 62, 138);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(pictureBox4);
            panel5.Location = new Point(1029, 48);
            panel5.Name = "panel5";
            panel5.Size = new Size(252, 110);
            panel5.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(142, 83);
            label8.Name = "label8";
            label8.Size = new Size(95, 20);
            label8.TabIndex = 15;
            label8.Text = "Total Income";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(142, 11);
            label9.Name = "label9";
            label9.Size = new Size(17, 20);
            label9.TabIndex = 14;
            label9.Text = "0";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Cash1;
            pictureBox4.Location = new Point(0, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(108, 110);
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(2, 62, 138);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(342, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(252, 110);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 81);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 15;
            label3.Text = "All Customers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 11);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 14;
            label4.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Conference_Skin_Type_7;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(108, 110);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(2, 62, 138);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(19, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(252, 110);
            panel3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 81);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 12;
            label2.Text = "All Users";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 11);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 11;
            label1.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.People;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 110);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // admindb
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 119, 182);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "admindb";
            Size = new Size(1300, 753);
            Load += admindb_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel4;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox3;
        private Panel panel5;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox4;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private PictureBox pictureBox1;
    }
}
