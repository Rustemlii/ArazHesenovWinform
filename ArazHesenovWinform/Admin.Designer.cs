namespace ArazHesenovWinform
{
    partial class Admin
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            btnUpdate = new Button();
            btnShow = new Button();
            txtSearch = new TextBox();
            txtType = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbCategory = new ComboBox();
            btnGetcategory = new Button();
            btnDeleteCategory = new Button();
            label1 = new Label();
            btnCleanAdmin = new Button();
            button1 = new Button();
            dateStart = new DateTimePicker();
            dateEnd = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblYekun = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(321, 260);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(964, 426);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(1097, 201);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(179, 40);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Cyan;
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(321, 201);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(176, 40);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Əlavə et";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(255, 128, 255);
            btnSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(1067, 60);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(151, 38);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Axtar";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 224, 192);
            btnUpdate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(54, 607);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(148, 41);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Redaktə et";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.Lime;
            btnShow.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(319, 154);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(178, 41);
            btnShow.TabIndex = 2;
            btnShow.Text = "Anbarı göstər";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(1022, 12);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(216, 42);
            txtSearch.TabIndex = 3;
            // 
            // txtType
            // 
            txtType.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtType.Location = new Point(39, 386);
            txtType.Multiline = true;
            txtType.Name = "txtType";
            txtType.Size = new Size(184, 34);
            txtType.TabIndex = 6;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(39, 466);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(184, 34);
            txtQuantity.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(39, 544);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(184, 34);
            txtPrice.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 268);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 9;
            label2.Text = "Malın adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(94, 346);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 9;
            label3.Text = "Növü";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(65, 435);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 9;
            label4.Text = "Anbar sayı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(78, 513);
            label5.Name = "label5";
            label5.Size = new Size(86, 28);
            label5.TabIndex = 9;
            label5.Text = "Qiyməti";
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(51, 299);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 31);
            cmbCategory.TabIndex = 10;
            // 
            // btnGetcategory
            // 
            btnGetcategory.BackColor = Color.Lime;
            btnGetcategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGetcategory.Location = new Point(39, 25);
            btnGetcategory.Name = "btnGetcategory";
            btnGetcategory.Size = new Size(184, 38);
            btnGetcategory.TabIndex = 12;
            btnGetcategory.Text = "Kateqoriya göstər";
            btnGetcategory.UseVisualStyleBackColor = false;
            btnGetcategory.Click += btnGetcategory_Click;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.BackColor = Color.Red;
            btnDeleteCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDeleteCategory.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteCategory.Location = new Point(239, 25);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(184, 38);
            btnDeleteCategory.TabIndex = 13;
            btnDeleteCategory.Text = "Kateqoriya Sil";
            btnDeleteCategory.UseVisualStyleBackColor = false;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(560, 12);
            label1.Name = "label1";
            label1.Size = new Size(266, 54);
            label1.TabIndex = 14;
            label1.Text = "Admin Panel";
            // 
            // btnCleanAdmin
            // 
            btnCleanAdmin.BackColor = Color.Yellow;
            btnCleanAdmin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCleanAdmin.Location = new Point(319, 107);
            btnCleanAdmin.Name = "btnCleanAdmin";
            btnCleanAdmin.Size = new Size(178, 41);
            btnCleanAdmin.TabIndex = 15;
            btnCleanAdmin.Text = "Ekranı Təmizlə";
            btnCleanAdmin.UseVisualStyleBackColor = false;
            btnCleanAdmin.Click += btnCleanAdmin_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(681, 204);
            button1.Name = "button1";
            button1.Size = new Size(166, 37);
            button1.TabIndex = 16;
            button1.Text = "Satışlar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateStart
            // 
            dateStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dateStart.Location = new Point(572, 154);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(156, 27);
            dateStart.TabIndex = 17;
            // 
            // dateEnd
            // 
            dateEnd.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dateEnd.Location = new Point(794, 154);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(154, 27);
            dateEnd.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(607, 128);
            label6.Name = "label6";
            label6.Size = new Size(80, 23);
            label6.TabIndex = 18;
            label6.Text = "Tarixdən";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(832, 125);
            label7.Name = "label7";
            label7.Size = new Size(89, 23);
            label7.TabIndex = 18;
            label7.Text = "Tarixədək";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(900, 204);
            label8.Name = "label8";
            label8.Size = new Size(147, 28);
            label8.TabIndex = 18;
            label8.Text = "Toplam Satış :";
            // 
            // lblYekun
            // 
            lblYekun.AutoSize = true;
            lblYekun.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblYekun.Location = new Point(1047, 207);
            lblYekun.Name = "lblYekun";
            lblYekun.Size = new Size(0, 28);
            lblYekun.TabIndex = 18;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1288, 686);
            Controls.Add(lblYekun);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dateEnd);
            Controls.Add(dateStart);
            Controls.Add(button1);
            Controls.Add(btnCleanAdmin);
            Controls.Add(label1);
            Controls.Add(btnDeleteCategory);
            Controls.Add(btnGetcategory);
            Controls.Add(cmbCategory);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtType);
            Controls.Add(txtSearch);
            Controls.Add(btnShow);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            WindowState = FormWindowState.Maximized;
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnSearch;
        private Button btnUpdate;
        private Button btnShow;
        private TextBox txtSearch;
        private TextBox txtType;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public ComboBox cmbCategory;
        private Button btnGetcategory;
        private Button btnDeleteCategory;
        private Label label1;
        private Button btnCleanAdmin;
        private Button button1;
        private DateTimePicker dateStart;
        private DateTimePicker dateEnd;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblYekun;
    }
}