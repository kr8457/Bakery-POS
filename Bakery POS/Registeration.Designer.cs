namespace Bakery_POS
{
    partial class Registeration
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
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            label6 = new Label();
            confirmpassword = new TextBox();
            label5 = new Label();
            label4 = new Label();
            sign_in_here = new Label();
            alr_account = new Label();
            signup = new Button();
            password = new TextBox();
            username = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(confirmpassword);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(sign_in_here);
            panel1.Controls.Add(alr_account);
            panel1.Controls.Add(signup);
            panel1.Controls.Add(password);
            panel1.Controls.Add(username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(597, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 744);
            panel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(262, 356);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(134, 24);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(46, 295);
            label6.Name = "label6";
            label6.Size = new Size(156, 23);
            label6.TabIndex = 10;
            label6.Text = "Confirm Password";
            // 
            // confirmpassword
            // 
            confirmpassword.BorderStyle = BorderStyle.FixedSingle;
            confirmpassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            confirmpassword.Location = new Point(104, 323);
            confirmpassword.Name = "confirmpassword";
            confirmpassword.Size = new Size(292, 27);
            confirmpassword.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 162);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 8;
            label5.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 226);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // sign_in_here
            // 
            sign_in_here.AutoSize = true;
            sign_in_here.ForeColor = Color.RoyalBlue;
            sign_in_here.Location = new Point(290, 456);
            sign_in_here.Name = "sign_in_here";
            sign_in_here.Size = new Size(87, 20);
            sign_in_here.TabIndex = 5;
            sign_in_here.Text = "Sign in here";
            sign_in_here.Click += label3_Click;
            // 
            // alr_account
            // 
            alr_account.AutoSize = true;
            alr_account.Location = new Point(104, 456);
            alr_account.Name = "alr_account";
            alr_account.Size = new Size(178, 20);
            alr_account.TabIndex = 4;
            alr_account.Text = "Already have an account?";
            // 
            // signup
            // 
            signup.BackColor = Color.RosyBrown;
            signup.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            signup.Location = new Point(92, 404);
            signup.Name = "signup";
            signup.Size = new Size(304, 49);
            signup.TabIndex = 3;
            signup.Text = "Sign up";
            signup.UseVisualStyleBackColor = false;
            signup.Click += button2_Click;
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.FixedSingle;
            password.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            password.Location = new Point(104, 255);
            password.Name = "password";
            password.Size = new Size(292, 27);
            password.TabIndex = 2;
            password.TextChanged += password_TextChanged;
            // 
            // username
            // 
            username.BorderStyle = BorderStyle.FixedSingle;
            username.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            username.Location = new Point(104, 196);
            username.Name = "username";
            username.Size = new Size(292, 27);
            username.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(-2, 1);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 744);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(1072, 1);
            button1.Name = "button1";
            button1.Size = new Size(39, 29);
            button1.TabIndex = 2;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += closebutton;
            // 
            // Registeration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 158, 132);
            ClientSize = new Size(1123, 745);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registeration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label sign_in_here;
        private Label alr_account;
        private Button signup;
        private TextBox password;
        private TextBox username;
        private Label label1;
        private Button button1;
        private Label label6;
        private TextBox confirmpassword;
        private CheckBox checkBox1;
    }
}