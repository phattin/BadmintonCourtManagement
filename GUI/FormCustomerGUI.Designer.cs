namespace BadmintonCourtManagement.GUI
{
    partial class FormCustomerGUI
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
            Title = new Label();
            lblCustomerName = new Label();
            lblCustomerPhone = new Label();
            txtCustomerName = new TextBox();
            txtCustomerPhone = new TextBox();
            btnAccept = new Button();
            btnCancel = new Button();
            lblCustomerID = new Label();
            CustomerID = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(59, -12);
            Title.Margin = new Padding(4, 0, 4, 0);
            Title.Name = "Title";
            Title.Size = new Size(322, 56);
            Title.TabIndex = 0;
            Title.Text = "Thêm khách hàng";
            Title.UseCompatibleTextRendering = true;
            Title.Click += Title_Click;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(-3, 144);
            lblCustomerName.Margin = new Padding(4, 0, 4, 0);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(214, 44);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "Tên khách hàng";
            lblCustomerName.UseCompatibleTextRendering = true;
            // 
            // lblCustomerPhone
            // 
            lblCustomerPhone.AutoSize = true;
            lblCustomerPhone.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerPhone.Location = new Point(4, 216);
            lblCustomerPhone.Margin = new Padding(4, 0, 4, 0);
            lblCustomerPhone.Name = "lblCustomerPhone";
            lblCustomerPhone.Size = new Size(180, 44);
            lblCustomerPhone.TabIndex = 2;
            lblCustomerPhone.Text = "Số điện thoại";
            lblCustomerPhone.UseCompatibleTextRendering = true;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(232, 154);
            txtCustomerName.Margin = new Padding(4, 3, 4, 3);
            txtCustomerName.Multiline = true;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(191, 34);
            txtCustomerName.TabIndex = 3;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Location = new Point(232, 224);
            txtCustomerPhone.Margin = new Padding(4, 3, 4, 3);
            txtCustomerPhone.Multiline = true;
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(191, 34);
            txtCustomerPhone.TabIndex = 4;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.IndianRed;
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(60, 299);
            btnAccept.Margin = new Padding(4, 3, 4, 3);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(133, 50);
            btnAccept.TabIndex = 5;
            btnAccept.Text = "Xác nhận";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DimGray;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(247, 299);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 50);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerID.Location = new Point(0, 71);
            lblCustomerID.Margin = new Padding(4, 0, 4, 0);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(208, 44);
            lblCustomerID.TabIndex = 7;
            lblCustomerID.Text = "Mã khách hàng";
            lblCustomerID.UseCompatibleTextRendering = true;
            lblCustomerID.Click += lblCustomerID_Click;
            // 
            // CustomerID
            // 
            CustomerID.AutoSize = true;
            CustomerID.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerID.Location = new Point(232, 71);
            CustomerID.Margin = new Padding(4, 0, 4, 0);
            CustomerID.Name = "CustomerID";
            CustomerID.Size = new Size(122, 44);
            CustomerID.TabIndex = 8;
            CustomerID.Text = "CUS0001";
            CustomerID.UseCompatibleTextRendering = true;
            // 
            // FormCustomerGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustomerID);
            Controls.Add(lblCustomerID);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(txtCustomerPhone);
            Controls.Add(txtCustomerName);
            Controls.Add(lblCustomerPhone);
            Controls.Add(lblCustomerName);
            Controls.Add(Title);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormCustomerGUI";
            Size = new Size(524, 638);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label lblCustomerName;
        private Label lblCustomerPhone;
        private TextBox txtCustomerName;
        private TextBox txtCustomerPhone;
        private Button btnAccept;
        private Button btnCancel;
        private Label lblCustomerID;
        private Label CustomerID;
    }
}