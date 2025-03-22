namespace Bakery_POS
{
    partial class AdminAddUsers
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            remove = new Button();
            clear = new Button();
            update = new Button();
            add = new Button();
            role = new ComboBox();
            status = new ComboBox();
            password = new TextBox();
            username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(remove);
            panel1.Controls.Add(clear);
            panel1.Controls.Add(update);
            panel1.Controls.Add(add);
            panel1.Controls.Add(role);
            panel1.Controls.Add(status);
            panel1.Controls.Add(password);
            panel1.Controls.Add(username);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 739);
            panel1.TabIndex = 0;
            // 
            // remove
            // 
            remove.BackColor = Color.IndianRed;
            remove.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            remove.Location = new Point(18, 531);
            remove.Name = "remove";
            remove.Size = new Size(137, 41);
            remove.TabIndex = 20;
            remove.Text = "Remove";
            remove.UseVisualStyleBackColor = false;
            // 
            // clear
            // 
            clear.BackColor = Color.IndianRed;
            clear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            clear.Location = new Point(184, 531);
            clear.Name = "clear";
            clear.Size = new Size(137, 41);
            clear.TabIndex = 19;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = false;
            // 
            // update
            // 
            update.BackColor = Color.IndianRed;
            update.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            update.Location = new Point(184, 462);
            update.Name = "update";
            update.Size = new Size(137, 41);
            update.TabIndex = 18;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            // 
            // add
            // 
            add.BackColor = Color.IndianRed;
            add.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            add.Location = new Point(18, 462);
            add.Name = "add";
            add.Size = new Size(137, 41);
            add.TabIndex = 17;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            add.Click += AdminAddUsers_Load;
            // 
            // role
            // 
            role.BackColor = Color.Honeydew;
            role.FormattingEnabled = true;
            role.Items.AddRange(new object[] { "Admin", "Cashier" });
            role.Location = new Point(29, 293);
            role.Name = "role";
            role.Size = new Size(292, 28);
            role.TabIndex = 16;
            // 
            // status
            // 
            status.BackColor = Color.Honeydew;
            status.FormattingEnabled = true;
            status.Items.AddRange(new object[] { "Active", "Inactive", "Approval" });
            status.Location = new Point(29, 398);
            status.Name = "status";
            status.Size = new Size(292, 28);
            status.TabIndex = 15;
            status.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // password
            // 
            password.BackColor = Color.Honeydew;
            password.BorderStyle = BorderStyle.FixedSingle;
            password.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            password.Location = new Point(29, 208);
            password.Name = "password";
            password.Size = new Size(292, 27);
            password.TabIndex = 14;
            // 
            // username
            // 
            username.BackColor = Color.Honeydew;
            username.BorderStyle = BorderStyle.FixedSingle;
            username.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            username.Location = new Point(29, 111);
            username.Name = "username";
            username.Size = new Size(292, 27);
            username.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 166);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 253);
            label2.Name = "label2";
            label2.Size = new Size(45, 23);
            label2.TabIndex = 11;
            label2.Text = "Role";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 356);
            label1.Name = "label1";
            label1.Size = new Size(60, 23);
            label1.TabIndex = 10;
            label1.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 71);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 9;
            label5.Text = "Username";
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(378, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(845, 749);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Honeydew;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(20, 158, 132);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(767, 606);
            dataGridView1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 71);
            label4.Name = "label4";
            label4.Size = new Size(143, 23);
            label4.TabIndex = 10;
            label4.Text = "All User's Details";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // AdminAddUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1300, 753);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminAddUsers";
            ShowInTaskbar = false;
            Text = "AdminAddUsers";
            Load += AdminAddUsers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox role;
        private ComboBox status;
        private TextBox password;
        private TextBox username;
        private ContextMenuStrip contextMenuStrip1;
        private Button add;
        private Button remove;
        private Button clear;
        private Button update;
        private DataGridView dataGridView1;
        private Label label4;
    }
}