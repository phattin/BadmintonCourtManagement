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
            EmployeeID.Location = new Point(160, 112);
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Size = new Size(66, 30);
            EmployeeID.TabIndex = 17;
            EmployeeID.Text = "E00001";
            EmployeeID.UseCompatibleTextRendering = true;
            // 
            // lblEmployeeID
            // 
            lblEmployeeID.AutoSize = true;
            lblEmployeeID.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeID.Location = new Point(23, 112);
            lblEmployeeID.Name = "lblEmployeeID";
            lblEmployeeID.Size = new Size(123, 30);
            lblEmployeeID.TabIndex = 16;
            lblEmployeeID.Text = "Mã nhân viên";
            lblEmployeeID.UseCompatibleTextRendering = true;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DimGray;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(203, 406);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 30);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.IndianRed;
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(74, 406);
            btnAccept.Margin = new Padding(3, 2, 3, 2);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(93, 30);
            btnAccept.TabIndex = 14;
            btnAccept.Text = "Xác nhận";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(160, 172);
            txtEmployeeName.Margin = new Padding(3, 2, 3, 2);
            txtEmployeeName.Multiline = true;
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(183, 22);
            txtEmployeeName.TabIndex = 12;
            // 
            // lblEmployeeSDT
            // 
            lblEmployeeSDT.AutoSize = true;
            lblEmployeeSDT.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeSDT.Location = new Point(23, 224);
            lblEmployeeSDT.Name = "lblEmployeeSDT";
            lblEmployeeSDT.Size = new Size(120, 30);
            lblEmployeeSDT.TabIndex = 11;
            lblEmployeeSDT.Text = "Số điện thoại";
            lblEmployeeSDT.UseCompatibleTextRendering = true;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeName.Location = new Point(23, 172);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(127, 30);
            lblEmployeeName.TabIndex = 10;
            lblEmployeeName.Text = "Tên nhân viên";
            lblEmployeeName.UseCompatibleTextRendering = true;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(87, 29);
            Title.Name = "Title";
            Title.Size = new Size(173, 38);
            Title.TabIndex = 9;
            Title.Text = "Sửa nhân viên";
            Title.UseCompatibleTextRendering = true;
            // 
            // txtEmployeeAddress
            // 
            txtEmployeeAddress.Location = new Point(160, 271);
            txtEmployeeAddress.Margin = new Padding(3, 2, 3, 2);
            txtEmployeeAddress.Multiline = true;
            txtEmployeeAddress.Name = "txtEmployeeAddress";
            txtEmployeeAddress.Size = new Size(183, 22);
            txtEmployeeAddress.TabIndex = 20;
            // 
            // lblEmployeeRole
            // 
            lblEmployeeRole.AutoSize = true;
            lblEmployeeRole.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeRole.Location = new Point(23, 323);
            lblEmployeeRole.Name = "lblEmployeeRole";
            lblEmployeeRole.Size = new Size(64, 30);
            lblEmployeeRole.TabIndex = 19;
            lblEmployeeRole.Text = "Vai trò";
            lblEmployeeRole.UseCompatibleTextRendering = true;
            // 
            // lblEmployeeAddress
            // 
            lblEmployeeAddress.AutoSize = true;
            lblEmployeeAddress.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeAddress.Location = new Point(23, 271);
            lblEmployeeAddress.Name = "lblEmployeeAddress";
            lblEmployeeAddress.Size = new Size(65, 30);
            lblEmployeeAddress.TabIndex = 18;
            lblEmployeeAddress.Text = "Địa chỉ";
            lblEmployeeAddress.UseCompatibleTextRendering = true;
            // 
            // txtEmployeeSDT
            // 
            txtEmployeeSDT.Location = new Point(160, 224);
            txtEmployeeSDT.Margin = new Padding(3, 2, 3, 2);
            txtEmployeeSDT.Multiline = true;
            txtEmployeeSDT.Name = "txtEmployeeSDT";
            txtEmployeeSDT.Size = new Size(183, 22);
            txtEmployeeSDT.TabIndex = 21;
            // 
            // RoleOption
            // 
            RoleOption.FormattingEnabled = true;
            RoleOption.Location = new Point(160, 328);
            RoleOption.Margin = new Padding(3, 2, 3, 2);
            RoleOption.Name = "RoleOption";
            RoleOption.Size = new Size(183, 23);
            RoleOption.TabIndex = 22;
            // 
            // FormEmployeeGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Name = "FormEmployeeGUI";
            Size = new Size(367, 496);
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
