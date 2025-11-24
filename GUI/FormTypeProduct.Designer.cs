namespace BadmintonCourtManagement.GUI
{
    partial class FormTypeProduct
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitle = new Label();
            lblId = new Label();
            txtTypeId = new TextBox();
            lblName = new Label();
            txtTypeName = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 241F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(lblId, 0, 1);
            tableLayoutPanel1.Controls.Add(txtTypeId, 1, 1);
            tableLayoutPanel1.Controls.Add(lblName, 0, 2);
            tableLayoutPanel1.Controls.Add(txtTypeName, 1, 2);
            tableLayoutPanel1.Controls.Add(btnSave, 0, 3);
            tableLayoutPanel1.Controls.Add(btnCancel, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(38, 25, 38, 38);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 194F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(453, 266);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblTitle, 2);
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(42, 25);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(268, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THÊM LOẠI MỚI";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // lblId
            // 
            lblId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblId.Location = new Point(42, 96);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(125, 29);
            lblId.TabIndex = 1;
            lblId.Text = "Mã loại sản phẩm";
            lblId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTypeId
            // 
            txtTypeId.BackColor = Color.FromArgb(245, 245, 245);
            txtTypeId.Enabled = false;
            txtTypeId.Font = new Font("Segoe UI", 11F);
            txtTypeId.Location = new Point(283, 100);
            txtTypeId.Margin = new Padding(4);
            txtTypeId.Name = "txtTypeId";
            txtTypeId.Size = new Size(124, 37);
            txtTypeId.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblName.Location = new Point(42, 152);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(125, 29);
            lblName.TabIndex = 3;
            lblName.Text = "Tên loại sản phẩm";
            lblName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTypeName
            // 
            txtTypeName.Font = new Font("Segoe UI", 11F);
            txtTypeName.Location = new Point(283, 156);
            txtTypeName.Margin = new Padding(4);
            txtTypeName.Name = "txtTypeName";
            txtTypeName.Size = new Size(124, 37);
            txtTypeName.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 142, 123);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(42, 211);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 37);
            btnSave.TabIndex = 7;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(220, 53, 69);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(283, 211);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 37);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormTypeProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 290);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTypeProduct";
            Padding = new Padding(12);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Loại sản phẩm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitle;
        private Label lblId;
        private TextBox txtTypeId;
        private Label lblName;
        private TextBox txtTypeName;
        private Button btnSave;
        private Button btnCancel;
    }
}