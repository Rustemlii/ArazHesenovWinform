namespace ArazHesenovWinform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            cmbName = new ComboBox();
            btnAdd = new Button();
            numericUpDown1 = new NumericUpDown();
            cmbType = new ComboBox();
            txtPrice = new TextBox();
            label1 = new Label();
            lblPrice = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAdminPanel = new Button();
            btnClean = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            dataGridView1.Location = new Point(441, 285);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(910, 391);
            dataGridView1.TabIndex = 0;
            // 
            // cmbName
            // 
            cmbName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cmbName.FormattingEnabled = true;
            cmbName.Location = new Point(168, 68);
            cmbName.Name = "cmbName";
            cmbName.Size = new Size(170, 31);
            cmbName.TabIndex = 1;
            cmbName.SelectedIndexChanged += cmbName_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Cyan;
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(168, 265);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(170, 41);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Əlavə et";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(168, 164);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(170, 30);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // cmbType
            // 
            cmbType.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(168, 115);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(170, 31);
            cmbType.TabIndex = 4;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            cmbType.SelectedValueChanged += cmbType_SelectedIndexChanged;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(168, 214);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(170, 30);
            txtPrice.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(938, 39);
            label1.Name = "label1";
            label1.Size = new Size(146, 46);
            label1.TabIndex = 7;
            label1.Text = "Qiymət:";
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(1086, 42);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 41);
            lblPrice.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 68);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 9;
            label2.Text = "Malın adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(74, 115);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 9;
            label3.Text = "Növü";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(85, 163);
            label4.Name = "label4";
            label4.Size = new Size(52, 28);
            label4.TabIndex = 9;
            label4.Text = "Sayı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(66, 210);
            label5.Name = "label5";
            label5.Size = new Size(86, 28);
            label5.TabIndex = 9;
            label5.Text = "Qiyməti";
            // 
            // btnAdminPanel
            // 
            btnAdminPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdminPanel.BackColor = Color.FromArgb(255, 128, 255);
            btnAdminPanel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdminPanel.Location = new Point(21, 632);
            btnAdminPanel.Name = "btnAdminPanel";
            btnAdminPanel.Size = new Size(172, 44);
            btnAdminPanel.TabIndex = 10;
            btnAdminPanel.Text = "Admin";
            btnAdminPanel.UseVisualStyleBackColor = false;
            btnAdminPanel.Click += btnAdminPanel_Click;
            // 
            // btnClean
            // 
            btnClean.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClean.BackColor = Color.Red;
            btnClean.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClean.ForeColor = SystemColors.Control;
            btnClean.Location = new Point(1142, 230);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(183, 49);
            btnClean.TabIndex = 11;
            btnClean.Text = "Ekranı Təmizlə";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.Lime;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(938, 230);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(183, 49);
            btnSave.TabIndex = 12;
            btnSave.Text = "Sat";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1363, 688);
            Controls.Add(btnSave);
            Controls.Add(btnClean);
            Controls.Add(btnAdminPanel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblPrice);
            Controls.Add(label1);
            Controls.Add(txtPrice);
            Controls.Add(cmbType);
            Controls.Add(numericUpDown1);
            Controls.Add(btnAdd);
            Controls.Add(cmbName);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        public ComboBox cmbName;
        private Button btnAdd;
        private NumericUpDown numericUpDown1;
        private ComboBox cmbType;
        private TextBox txtPrice;
        private Label label1;
        private Label lblPrice;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAdminPanel;
        private Button btnClean;
        private Button btnSave;
    }
}
