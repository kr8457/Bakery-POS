namespace Bakery_POS
{
    partial class AdminAddCategories
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel2 = new Panel();
            dgvCategories = new DataGridView();
            label4 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            signup = new Button();
            category = new TextBox();
            label5 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Honeydew;
            panel2.Controls.Add(dgvCategories);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(411, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(845, 698);
            panel2.TabIndex = 3;
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.BackgroundColor = Color.Honeydew;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(20, 158, 132);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(34, 82);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowHeadersVisible = false;
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.Size = new Size(767, 606);
            dgvCategories.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 37);
            label4.Name = "label4";
            label4.Size = new Size(122, 23);
            label4.TabIndex = 10;
            label4.Text = "All Categories";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(signup);
            panel1.Controls.Add(category);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(45, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 688);
            panel1.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(144, 224, 239);
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button3.Location = new Point(18, 250);
            button3.Name = "button3";
            button3.Size = new Size(137, 41);
            button3.TabIndex = 20;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnRemove_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(144, 224, 239);
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button2.Location = new Point(184, 250);
            button2.Name = "button2";
            button2.Size = new Size(137, 41);
            button2.TabIndex = 19;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnClear_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(144, 224, 239);
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button1.Location = new Point(184, 181);
            button1.Name = "button1";
            button1.Size = new Size(137, 41);
            button1.TabIndex = 18;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnUpdate_Click;
            // 
            // signup
            // 
            signup.BackColor = Color.FromArgb(144, 224, 239);
            signup.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            signup.Location = new Point(18, 181);
            signup.Name = "signup";
            signup.Size = new Size(137, 41);
            signup.TabIndex = 17;
            signup.Text = "Add";
            signup.UseVisualStyleBackColor = false;
            signup.Click += btnAdd_Click;
            // 
            // category
            // 
            category.BorderStyle = BorderStyle.FixedSingle;
            category.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            category.Location = new Point(29, 111);
            category.Name = "category";
            category.Size = new Size(292, 27);
            category.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 71);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 9;
            label5.Text = "Category";
            // 
            // AdminAddCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 119, 182);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminAddCategories";
            Size = new Size(1300, 753);
            Load += AdminAddCategories_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dgvCategories;
        private Label label4;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button signup;
        private TextBox category;
        private Label label5;
    }
}
