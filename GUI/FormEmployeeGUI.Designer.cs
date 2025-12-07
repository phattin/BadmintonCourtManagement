namespace BadmintonCourtManagement.GUI

{
    partial class FormEmployeeGUI
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
            EmployeeID = new Label();
            lblEmployeeID = new Label();
            btnCancel = new Button();
            btnAccept = new Button();
            txtEmployeeName = new TextBox();
            lblEmployeeSDT = new Label();
            lblEmployeeName = new Label();
            Title = new Label();
            txtEmployeeAddress = new TextBox();
            lblEmployeeRole = new Label();
            lblEmployeeAddress = new Label();
            txtEmployeeSDT = new TextBox();
            RoleOption = new ComboBox();
            SuspendLayout();
            // 
            // EmployeeID
            // 
            EmployeeID.AutoSize = true;
            EmployeeID.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeeID.Location = new Point(229, 187);
            EmployeeID.Margin = new Padding(4, 0, 4, 0);
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Size = new Size(99, 44);
            EmployeeID.TabIndex = 17;
            EmployeeID.Text = "E00001";
            EmployeeID.UseCompatibleTextRendering = true;
            // 
            // lblEmployeeID
            // 
            lblEmployeeID.AutoSize = true;
            lblEmployeeID.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeID.Location = new Point(33, 187);
            lblEmployeeID.Margin = new Padding(4, 0, 4, 0);
            lblEmployeeID.Name = "lblEmployeeID";
            lblEmployeeID.Size = new Size(185, 44);
            lblEmployeeID.TabIndex = 16;
            lblEmployeeID.Text = "Mã nhân viên";
            lblEmployeeID.UseCompatibleTextRendering = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.DimGray;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(290, 733);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 50);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAccept
            // 
            btnAccept.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAccept.BackColor = Color.IndianRed;
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(106, 733);
            btnAccept.Margin = new Padding(4, 3, 4, 3);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(133, 50);
            btnAccept.TabIndex = 14;
            btnAccept.Text = "Xác nhận";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmployeeName.Location = new Point(229, 287);
            txtEmployeeName.Margin = new Padding(4, 3, 4, 3);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(260, 31);
            txtEmployeeName.TabIndex = 12;
            // 
            // lblEmployeeSDT
            // 
            lblEmployeeSDT.AutoSize = true;
            lblEmployeeSDT.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeSDT.Location = new Point(33, 373);
            lblEmployeeSDT.Margin = new Padding(4, 0, 4, 0);
            lblEmployeeSDT.Name = "lblEmployeeSDT";
            lblEmployeeSDT.Size = new Size(180, 44);
            lblEmployeeSDT.TabIndex = 11;
            lblEmployeeSDT.Text = "Số điện thoại";
            lblEmployeeSDT.UseCompatibleTextRendering = true;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeName.Location = new Point(33, 287);
            lblEmployeeName.Margin = new Padding(4, 0, 4, 0);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(191, 44);
            lblEmployeeName.TabIndex = 10;
            lblEmployeeName.Text = "Tên nhân viên";
            lblEmployeeName.UseCompatibleTextRendering = true;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(320, 48);
            Title.Margin = new Padding(4, 0, 4, 0);
            Title.Name = "Title";
            Title.Size = new Size(259, 56);
            Title.TabIndex = 9;
            Title.Text = "Sửa nhân viên";
            Title.UseCompatibleTextRendering = true;
            // 
            // txtEmployeeAddress
            // 
            txtEmployeeAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmployeeAddress.Location = new Point(229, 452);
            txtEmployeeAddress.Margin = new Padding(4, 3, 4, 3);
            txtEmployeeAddress.Name = "txtEmployeeAddress";
            txtEmployeeAddress.Size = new Size(260, 31);
            txtEmployeeAddress.TabIndex = 20;
            // 
            // lblEmployeeRole
            // 
            lblEmployeeRole.AutoSize = true;
            lblEmployeeRole.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeRole.Location = new Point(33, 538);
            lblEmployeeRole.Margin = new Padding(4, 0, 4, 0);
            lblEmployeeRole.Name = "lblEmployeeRole";
            lblEmployeeRole.Size = new Size(96, 44);
            lblEmployeeRole.TabIndex = 19;
            lblEmployeeRole.Text = "Vai trò";
            lblEmployeeRole.UseCompatibleTextRendering = true;
            // 
            // lblEmployeeAddress
            // 
            lblEmployeeAddress.AutoSize = true;
            lblEmployeeAddress.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeAddress.Location = new Point(33, 452);
            lblEmployeeAddress.Margin = new Padding(4, 0, 4, 0);
            lblEmployeeAddress.Name = "lblEmployeeAddress";
            lblEmployeeAddress.Size = new Size(98, 44);
            lblEmployeeAddress.TabIndex = 18;
            lblEmployeeAddress.Text = "Địa chỉ";
            lblEmployeeAddress.UseCompatibleTextRendering = true;
            // 
            // txtEmployeeSDT
            // 
            txtEmployeeSDT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmployeeSDT.Location = new Point(229, 373);
            txtEmployeeSDT.Margin = new Padding(4, 3, 4, 3);
            txtEmployeeSDT.Name = "txtEmployeeSDT";
            txtEmployeeSDT.Size = new Size(260, 31);
            txtEmployeeSDT.TabIndex = 21;
            // 
            // RoleOption
            // 
            RoleOption.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RoleOption.FormattingEnabled = true;
            RoleOption.Location = new Point(229, 547);
            RoleOption.Margin = new Padding(4, 3, 4, 3);
            RoleOption.Name = "RoleOption";
            RoleOption.Size = new Size(260, 33);
            RoleOption.TabIndex = 22;
            // 
            // FormEmployeeGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RoleOption);
            Controls.Add(txtEmployeeSDT);
            Controls.Add(txtEmployeeAddress);
            Controls.Add(lblEmployeeRole);
            Controls.Add(lblEmployeeAddress);
            Controls.Add(EmployeeID);
            Controls.Add(lblEmployeeID);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(txtEmployeeName);
            Controls.Add(lblEmployeeSDT);
            Controls.Add(lblEmployeeName);
            Controls.Add(Title);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormEmployeeGUI";
            Size = new Size(524, 827);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EmployeeID;
        private Label lblEmployeeID;
        private Button btnCancel;
        private Button btnAccept;
        private TextBox txtEmployeeName;
        private Label lblEmployeeSDT;
        private Label lblEmployeeName;
        private Label Title;
        private TextBox txtEmployeeAddress;
        private Label lblEmployeeRole;
        private Label lblEmployeeAddress;
        private TextBox txtEmployeeSDT;
        private ComboBox RoleOption;
    }
}
