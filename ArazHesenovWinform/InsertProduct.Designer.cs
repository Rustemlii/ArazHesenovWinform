namespace ArazHesenovWinform
{
    partial class InsertProduct
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
            txtCategory = new TextBox();
            txtProduct = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            btnAddCategory = new Button();
            cmbCategoryAdd = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtCategory
            // 
            txtCategory.Anchor = AnchorStyles.Top;
            txtCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCategory.Location = new Point(286, 54);
            txtCategory.Multiline = true;
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(173, 34);
            txtCategory.TabIndex = 0;
            // 
            // txtProduct
            // 
            txtProduct.Anchor = AnchorStyles.Top;
            txtProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtProduct.Location = new Point(286, 240);
            txtProduct.Multiline = true;
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(173, 34);
            txtProduct.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Anchor = AnchorStyles.Top;
            txtQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(286, 299);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(173, 34);
            txtQuantity.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Top;
            txtPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(286, 358);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(173, 34);
            txtPrice.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top;
            btnAdd.BackColor = Color.Lime;
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(286, 415);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(173, 41);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Əlavə et";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Anchor = AnchorStyles.Top;
            btnAddCategory.BackColor = Color.Lime;
            btnAddCategory.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAddCategory.Location = new Point(497, 54);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(128, 34);
            btnAddCategory.TabIndex = 6;
            btnAddCategory.Text = "Əlavə et";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // cmbCategoryAdd
            // 
            cmbCategoryAdd.Anchor = AnchorStyles.Top;
            cmbCategoryAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cmbCategoryAdd.FormattingEnabled = true;
            cmbCategoryAdd.Location = new Point(286, 187);
            cmbCategoryAdd.Name = "cmbCategoryAdd";
            cmbCategoryAdd.Size = new Size(173, 31);
            cmbCategoryAdd.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(317, 23);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 7;
            label1.Text = "Malın adı";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(130, 187);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 8;
            label2.Text = "Kateqoriya seç";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(217, 240);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 9;
            label3.Text = "Növü";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(228, 299);
            label4.Name = "label4";
            label4.Size = new Size(52, 28);
            label4.TabIndex = 10;
            label4.Text = "Sayı";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(194, 358);
            label5.Name = "label5";
            label5.Size = new Size(86, 28);
            label5.TabIndex = 11;
            label5.Text = "Qiyməti";
            // 
            // InsertProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 621);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCategoryAdd);
            Controls.Add(btnAddCategory);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtProduct);
            Controls.Add(txtCategory);
            Name = "InsertProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InsertProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCategory;
        private TextBox txtProduct;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Button btnAdd;
        private Button btnAddCategory;
        public ComboBox cmbCategoryAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}