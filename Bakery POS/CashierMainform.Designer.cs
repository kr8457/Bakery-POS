namespace Bakery_POS
{
    partial class CashierMainform
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
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            button9 = new Button();
            button8 = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button1 = new Button();
            admindb1 = new admindb();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 37, 38);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(0, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 792);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Administrator_Male;
            pictureBox1.Location = new Point(64, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 110);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(53, 122);
            label5.Name = "label5";
            label5.Size = new Size(143, 23);
            label5.TabIndex = 9;
            label5.Text = "Welcome Admin";
            // 
            // button9
            // 
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Bahnschrift", 9.75F);
            button9.ForeColor = Color.White;
            button9.Location = new Point(-4, 723);
            button9.Name = "button9";
            button9.Size = new Size(234, 35);
            button9.TabIndex = 7;
            button9.Text = "Log Out";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Bahnschrift", 9.75F);
            button8.ForeColor = Color.White;
            button8.Location = new Point(6, 402);
            button8.Name = "button8";
            button8.Size = new Size(234, 35);
            button8.TabIndex = 6;
            button8.Text = "Customers";
            button8.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Bahnschrift", 9.75F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(6, 301);
            button5.Name = "button5";
            button5.Size = new Size(234, 35);
            button5.TabIndex = 3;
            button5.Text = "Add Products";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Bahnschrift", 9.75F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(6, 225);
            button4.Name = "button4";
            button4.Size = new Size(234, 35);
            button4.TabIndex = 2;
            button4.Text = "Add Categories";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bahnschrift", 9.75F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 148);
            button2.Name = "button2";
            button2.Size = new Size(234, 35);
            button2.TabIndex = 0;
            button2.Text = "Dashboard";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 158, 132);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1629, 38);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(1590, 0);
            button1.Name = "button1";
            button1.Size = new Size(39, 29);
            button1.TabIndex = 3;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // admindb1
            // 
            admindb1.Location = new Point(246, 41);
            admindb1.Name = "admindb1";
            admindb1.Size = new Size(1379, 900);
            admindb1.TabIndex = 3;
            // 
            // CashierMainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1625, 941);
            Controls.Add(admindb1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashierMainform";
            Text = "CashierMainform";
            Load += CashierMainform_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label5;
        private Button button9;
        private Button button8;
        private Button button5;
        private Button button4;
        private Button button2;
        private Panel panel1;
        private Button button1;
        private admindb admindb1;
    }
}