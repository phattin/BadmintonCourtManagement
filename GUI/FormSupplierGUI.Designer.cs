namespace BadmintonCourtManagement.GUI
{
    partial class FormSupplierGUI
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
            lblSupplierId = new Label();
            txtSupplierId = new TextBox();
            lblSupplierName = new Label();
            txtSupplierName = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 215F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(lblSupplierId, 0, 1);
            tableLayoutPanel1.Controls.Add(txtSupplierId, 1, 1);
            tableLayoutPanel1.Controls.Add(lblSupplierName, 0, 2);
            tableLayoutPanel1.Controls.Add(txtSupplierName, 1, 2);
            tableLayoutPanel1.Controls.Add(lblAddress, 0, 3);
            tableLayoutPanel1.Controls.Add(txtAddress, 1, 3);
            tableLayoutPanel1.Controls.Add(lblEmail, 0, 4);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 4);
            tableLayoutPanel1.Controls.Add(btnSave, 0, 5);
            tableLayoutPanel1.Controls.Add(btnCancel, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(12);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.Size = new Size(418, 350);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblTitle, 2);
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(15, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(158, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CẬP NHẬT";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSupplierId
            // 
            lblSupplierId.Location = new Point(15, 60);
            lblSupplierId.Name = "lblSupplierId";
            lblSupplierId.Size = new Size(100, 23);
            lblSupplierId.TabIndex = 1;
            lblSupplierId.Text = "Mã nhà cung cấp";
            lblSupplierId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSupplierId
            // 
            txtSupplierId.BackColor = Color.FromArgb(245, 245, 245);
            txtSupplierId.Enabled = false;
            txtSupplierId.Location = new Point(230, 63);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(157, 31);
            txtSupplierId.TabIndex = 2;
            // 
            // lblSupplierName
            // 
            lblSupplierName.Location = new Point(15, 108);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(100, 23);
            lblSupplierName.TabIndex = 3;
            lblSupplierName.Text = "Tên nhà cung cấp";
            lblSupplierName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Segoe UI", 10F);
            txtSupplierName.Location = new Point(230, 111);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(157, 34);
            txtSupplierName.TabIndex = 4;
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(15, 161);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 23);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Địa chỉ";
            lblAddress.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.Location = new Point(230, 164);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(157, 31);
            txtAddress.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(15, 216);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(230, 219);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(157, 34);
            txtEmail.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 142, 123);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(15, 282);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 41);
            btnSave.TabIndex = 9;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(220, 53, 69);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(230, 282);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 41);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormSupplierGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 350);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSupplierGUI";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nhà cung cấp";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitle;
        private Label lblSupplierId;
        private TextBox txtSupplierId;
        private Label lblSupplierName;
        private TextBox txtSupplierName;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnSave;
        private Button btnCancel;
    }
}