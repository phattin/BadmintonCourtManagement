// FormSupplierGUI.Designer.cs
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
            label1 = new Label();
            txtSupplierId = new TextBox();
            label2 = new Label();
            txtSupplierName = new TextBox();
            label3 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(txtSupplierId, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(txtSupplierName, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(txtAddress, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 4);
            tableLayoutPanel1.Controls.Add(btnSave, 0, 6);
            tableLayoutPanel1.Controls.Add(btnCancel, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(30, 20, 30, 30);
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.Size = new Size(508, 434);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblTitle, 2);
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Margin = new Padding(0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(366, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THÊM NHÀ CUNG CẤP";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(33, 110);
            label1.Name = "label1";
            label1.Size = new Size(174, 28);
            label1.TabIndex = 1;
            label1.Text = "Mã nhà cung cấp";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSupplierId
            // 
            txtSupplierId.BackColor = Color.FromArgb(245, 245, 245);
            txtSupplierId.Enabled = false;
            txtSupplierId.Font = new Font("Segoe UI", 11F);
            txtSupplierId.Location = new Point(257, 113);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(218, 37);
            txtSupplierId.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(33, 170);
            label2.Name = "label2";
            label2.Size = new Size(177, 28);
            label2.TabIndex = 3;
            label2.Text = "Tên nhà cung cấp";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Segoe UI", 11F);
            txtSupplierName.Location = new Point(257, 173);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(218, 37);
            txtSupplierName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(33, 230);
            label3.Name = "label3";
            label3.Size = new Size(78, 28);
            label3.TabIndex = 5;
            label3.Text = "Địa chỉ";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.Location = new Point(257, 233);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(218, 37);
            txtAddress.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(33, 290);
            label4.Name = "label4";
            label4.Size = new Size(64, 28);
            label4.TabIndex = 7;
            label4.Text = "Email";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(257, 293);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 37);
            txtEmail.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(0, 142, 123);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(33, 383);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(218, 39);
            btnSave.TabIndex = 9;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(220, 53, 69);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(257, 383);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(218, 39);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormSupplierGUI
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(528, 454);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(550, 510);
            Name = "FormSupplierGUI";
            Padding = new Padding(10);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitle;
        private Label label1;
        private TextBox txtSupplierId;
        private Label label2;
        private TextBox txtSupplierName;
        private Label label3;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtEmail;
        private Button btnSave;
        private Button btnCancel;
    }
}