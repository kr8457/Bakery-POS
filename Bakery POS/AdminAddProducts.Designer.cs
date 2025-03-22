namespace Bakery_POS
{
    partial class AdminAddProducts
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel2 = new Panel();
            dgvProducts = new DataGridView();
            label4 = new Label();
            panel1 = new Panel();
            button4 = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            cmbStatus = new ComboBox();
            label3 = new Label();
            txtStock = new TextBox();
            label6 = new Label();
            txtPrice = new TextBox();
            label7 = new Label();
            cmbCategory = new ComboBox();
            label2 = new Label();
            txtProductName = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            txtProductID = new TextBox();
            label5 = new Label();
            imageList1 = new ImageList(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvProducts);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(37, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(1219, 342);
            panel2.TabIndex = 5;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(20, 158, 132);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(34, 36);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1140, 275);
            dgvProducts.TabIndex = 11;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 10);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 10;
            label4.Text = "All Products";
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(cmbStatus);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtStock);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cmbCategory);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtProductName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txtProductID);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(45, 392);
            panel1.Name = "panel1";
            panel1.Size = new Size(1211, 335);
            panel1.TabIndex = 6;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(144, 224, 239);
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(1062, 184);
            button4.Name = "button4";
            button4.Size = new Size(79, 41);
            button4.TabIndex = 36;
            button4.Text = "Import";
            button4.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(144, 224, 239);
            btnClear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnClear.Location = new Point(792, 251);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(137, 41);
            btnClear.TabIndex = 35;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(144, 224, 239);
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnUpdate.Location = new Point(382, 251);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(137, 41);
            btnUpdate.TabIndex = 34;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(144, 224, 239);
            btnRemove.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnRemove.Location = new Point(584, 251);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(137, 41);
            btnRemove.TabIndex = 33;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(144, 224, 239);
            btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnAdd.Location = new Point(144, 251);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 41);
            btnAdd.TabIndex = 32;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(584, 118);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(292, 28);
            cmbStatus.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(454, 121);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 30;
            label3.Text = "Status:";
            // 
            // txtStock
            // 
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtStock.Location = new Point(584, 64);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(292, 27);
            txtStock.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(454, 64);
            label6.Name = "label6";
            label6.Size = new Size(61, 23);
            label6.TabIndex = 28;
            label6.Text = "Stock:";
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtPrice.Location = new Point(584, 13);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(292, 27);
            txtPrice.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(454, 13);
            label7.Name = "label7";
            label7.Size = new Size(98, 23);
            label7.TabIndex = 26;
            label7.Text = "Price(PKR):";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(144, 118);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(292, 28);
            cmbCategory.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 121);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 24;
            label2.Text = "Category:";
            // 
            // txtProductName
            // 
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtProductName.Location = new Point(144, 64);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(292, 27);
            txtProductName.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 64);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 22;
            label1.Text = "Product Name:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(1021, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(145, 141);
            panel3.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 141);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtProductID
            // 
            txtProductID.BorderStyle = BorderStyle.FixedSingle;
            txtProductID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtProductID.Location = new Point(144, 13);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(292, 27);
            txtProductID.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 13);
            label5.Name = "label5";
            label5.Size = new Size(101, 23);
            label5.TabIndex = 9;
            label5.Text = "Product ID:";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // AdminAddProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 119, 182);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminAddProducts";
            Size = new Size(1300, 753);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dgvProducts;
        private Label label4;
        private Panel panel1;
        private TextBox txtProductID;
        private Label label5;
        private Panel panel3;
        private TextBox txtProductName;
        private Label label1;
        private ComboBox cmbStatus;
        private Label label3;
        private TextBox txtStock;
        private Label label6;
        private TextBox txtPrice;
        private Label label7;
        private ComboBox cmbCategory;
        private Label label2;
        private ImageList imageList1;
        private Button button4;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnAdd;
        private PictureBox pictureBox1;
    }
}
