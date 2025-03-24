namespace Bakery_POS
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            cuiGradientBorder1 = new CuoreUI.Controls.cuiGradientBorder();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            loginbutton = new CuoreUI.Controls.cuiButton();
            label4 = new CuoreUI.Controls.cuiLabel();
            label5 = new CuoreUI.Controls.cuiLabel();
            showpasswordcheckBox = new CheckBox();
            label1 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            SuspendLayout();
            // 
            // cuiGradientBorder1
            // 
            cuiGradientBorder1.BackColor = Color.Transparent;
            cuiGradientBorder1.ForeColor = Color.Crimson;
            cuiGradientBorder1.GradientAngle = 0F;
            cuiGradientBorder1.Location = new Point(7, 2);
            cuiGradientBorder1.Name = "cuiGradientBorder1";
            cuiGradientBorder1.OutlineThickness = 1F;
            cuiGradientBorder1.PanelColor1 = Color.FromArgb(3, 4, 94);
            cuiGradientBorder1.PanelColor2 = Color.FromArgb(3, 4, 94);
            cuiGradientBorder1.PanelOutlineColor1 = Color.Transparent;
            cuiGradientBorder1.PanelOutlineColor2 = Color.Transparent;
            cuiGradientBorder1.Rounding = new Padding(40);
            cuiGradientBorder1.Size = new Size(485, 573);
            cuiGradientBorder1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(102, 306);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(291, 38);
            textBox2.TabIndex = 71;
            textBox2.PasswordChar = '\u2022';
            textBox2.Click += showpasswordcheckBox_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 194);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 38);
            textBox1.TabIndex = 70;
            // 
            // loginbutton
            // 
            loginbutton.BackColor = Color.FromArgb(3, 4, 94);
            loginbutton.CheckButton = false;
            loginbutton.Checked = false;
            loginbutton.CheckedBackground = Color.Khaki;
            loginbutton.CheckedForeColor = SystemColors.WindowFrame;
            loginbutton.CheckedImageTint = Color.White;
            loginbutton.CheckedOutline = Color.FromArgb(255, 106, 0);
            loginbutton.Content = "Login";
            loginbutton.DialogResult = DialogResult.None;
            loginbutton.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbutton.ForeColor = Color.FromArgb(3, 4, 94);
            loginbutton.HoverBackground = Color.FromArgb(29, 45, 68);
            loginbutton.HoveredImageTint = Color.White;
            loginbutton.HoverForeColor = Color.White;
            loginbutton.HoverOutline = Color.Empty;
            loginbutton.Image = null;
            loginbutton.ImageAutoCenter = true;
            loginbutton.ImageExpand = new Point(0, 0);
            loginbutton.ImageOffset = new Point(0, 0);
            loginbutton.ImageTint = Color.White;
            loginbutton.Location = new Point(128, 403);
            loginbutton.Name = "loginbutton";
            loginbutton.NormalBackground = Color.FromArgb(144, 224, 239);
            loginbutton.NormalOutline = Color.Empty;
            loginbutton.OutlineThickness = 1.6F;
            loginbutton.PressedBackground = Color.FromArgb(255, 106, 0);
            loginbutton.PressedForeColor = Color.White;
            loginbutton.PressedImageTint = Color.White;
            loginbutton.PressedOutline = Color.Empty;
            loginbutton.Rounding = new Padding(8);
            loginbutton.Size = new Size(229, 56);
            loginbutton.TabIndex = 69;
            loginbutton.TextOffset = new Point(0, 0);
            loginbutton.Click += loginbutton_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(3, 4, 94);
            label4.Content = "Password";
            label4.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 180, 216);
            label4.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            label4.Location = new Point(87, 270);
            label4.Margin = new Padding(4, 5, 4, 5);
            label4.Name = "label4";
            label4.Size = new Size(129, 28);
            label4.TabIndex = 68;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(3, 4, 94);
            label5.Content = "Username";
            label5.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 180, 216);
            label5.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            label5.Location = new Point(87, 158);
            label5.Margin = new Padding(4, 5, 4, 5);
            label5.Name = "label5";
            label5.Size = new Size(129, 28);
            label5.TabIndex = 67;
            // 
            // showpasswordcheckBox
            // 
            showpasswordcheckBox.AutoSize = true;
            showpasswordcheckBox.BackColor = Color.FromArgb(3, 4, 94);
            showpasswordcheckBox.ForeColor = Color.FromArgb(0, 180, 216);
            showpasswordcheckBox.Location = new Point(259, 350);
            showpasswordcheckBox.Name = "showpasswordcheckBox";
            showpasswordcheckBox.Size = new Size(134, 24);
            showpasswordcheckBox.TabIndex = 64;
            showpasswordcheckBox.Text = "Show password";
            showpasswordcheckBox.UseVisualStyleBackColor = false;
            showpasswordcheckBox.Click += showpasswordcheckBox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(3, 4, 94);
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 180, 216);
            label1.Location = new Point(113, 42);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(271, 66);
            label1.TabIndex = 63;
            label1.Text = "Login Account";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // Login
            // 
            BackColor = Color.FromArgb(3, 4, 94);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(495, 570);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(loginbutton);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(showpasswordcheckBox);
            Controls.Add(label1);
            Controls.Add(cuiGradientBorder1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CuoreUI.Controls.cuiTextBox2 cuiTextBox21;
        private CuoreUI.Controls.cuiTextBox2 cuiTextBox22;
        private PictureBox pictureBox1;
        private CuoreUI.Controls.cuiGradientBorder cuiGradientBorder1;
        private TextBox textBox2;
        private TextBox textBox1;
        private CuoreUI.Controls.cuiButton loginbutton;
        private CuoreUI.Controls.cuiLabel label4;
        private CuoreUI.Controls.cuiLabel label5;
        private CheckBox showpasswordcheckBox;
        private Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}
