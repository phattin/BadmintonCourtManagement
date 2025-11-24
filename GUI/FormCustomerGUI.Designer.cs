// FormCustomerGUI.Designer.cs
namespace BadmintonCourtManagement.GUI
{
    partial class FormCustomerGUI
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
            txtCustomerId = new TextBox();
            label2 = new Label();
            txtCustomerName = new TextBox();
            label3 = new Label();
            txtCustomerPhone = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 252F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(txtCustomerId, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(txtCustomerName, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(txtCustomerPhone, 1, 3);
            tableLayoutPanel1.Controls.Add(btnSave, 0, 5);
            tableLayoutPanel1.Controls.Add(btnCancel, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(30, 20, 30, 30);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.Size = new Size(580, 460);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblTitle, 2);
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(33, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(415, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THÊM KHÁCH HÀNG MỚI";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(33, 110);
            label1.Name = "label1";
            label1.Size = new Size(157, 28);
            label1.TabIndex = 1;
            label1.Text = "Mã khách hàng";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCustomerId
            // 
            txtCustomerId.BackColor = Color.FromArgb(245, 245, 245);
            txtCustomerId.Enabled = false;
            txtCustomerId.Font = new Font("Segoe UI", 11F);
            txtCustomerId.Location = new Point(285, 113);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(128, 37);
            txtCustomerId.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(33, 170);
            label2.Name = "label2";
            label2.Size = new Size(160, 28);
            label2.TabIndex = 3;
            label2.Text = "Tên khách hàng";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 11F);
            txtCustomerName.Location = new Point(285, 173);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(128, 37);
            txtCustomerName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(33, 230);
            label3.Name = "label3";
            label3.Size = new Size(138, 28);
            label3.TabIndex = 5;
            label3.Text = "Số điện thoại";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Font = new Font("Segoe UI", 11F);
            txtCustomerPhone.Location = new Point(285, 233);
            txtCustomerPhone.MaxLength = 11;
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(128, 37);
            txtCustomerPhone.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 142, 123);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(33, 323);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 39);
            btnSave.TabIndex = 7;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(220, 53, 69);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(285, 323);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 39);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormCustomerGUI
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(550, 450);
            Name = "FormCustomerGUI";
            Padding = new Padding(10);
            Size = new Size(600, 480);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitle;
        private Label label1;
        private TextBox txtCustomerId;
        private Label label2;
        private TextBox txtCustomerName;
        private Label label3;
        private TextBox txtCustomerPhone;
        private Button btnSave;
        private Button btnCancel;
    }
}