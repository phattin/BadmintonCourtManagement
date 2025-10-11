namespace BadmintonCourtManagement.GUI
{
    partial class InsertPermissionGUI
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
            draftPanel = new Panel();
            btnCancel = new Label();
            btnConfirm = new Label();
            tPermission = new TableLayoutPanel();
            chbViewStatistic = new CheckBox();
            chbDeletePermission = new CheckBox();
            chbUpdatePermission = new CheckBox();
            chbInsertPermission = new CheckBox();
            chbViewPermission = new CheckBox();
            chbDeleteAccount = new CheckBox();
            chbUpdateAccount = new CheckBox();
            chbInsertAccount = new CheckBox();
            chbViewAccount = new CheckBox();
            DeleteEmployee = new CheckBox();
            chbUpdateEmployee = new CheckBox();
            chbInsertEmployee = new CheckBox();
            chbViewEmployee = new CheckBox();
            chbUpdateCustomer = new CheckBox();
            chbInsertCustomer = new CheckBox();
            chbViewCustomer = new CheckBox();
            chbDeleteSupplier = new CheckBox();
            chbUpdateSupplier = new CheckBox();
            chbInsertSupplier = new CheckBox();
            chbViewSupplier = new CheckBox();
            chbDeleteProduct = new CheckBox();
            chbUpdateProduct = new CheckBox();
            chbInsertProduct = new CheckBox();
            chbViewProduct = new CheckBox();
            chbInsertImport = new CheckBox();
            chbViewImport = new CheckBox();
            chbViewBill = new CheckBox();
            chbInserSell = new CheckBox();
            chbViewSell = new CheckBox();
            chbDeleteCourt = new CheckBox();
            chbUpdateCourt = new CheckBox();
            chbInsertCourt = new CheckBox();
            cbInsertBooking = new CheckBox();
            lblBooking = new Label();
            lblDelete = new Label();
            lblUpdate = new Label();
            lblInsert = new Label();
            lblView = new Label();
            lblFuctionName = new Label();
            lblCourt = new Label();
            lblSell = new Label();
            lblBill = new Label();
            lblImport = new Label();
            lblProduct = new Label();
            lblSupplier = new Label();
            lblCustomer = new Label();
            label1 = new Label();
            lblAccount = new Label();
            lblPermission = new Label();
            label2 = new Label();
            chbViewBooking = new CheckBox();
            chbViewCourt = new CheckBox();
            txtPermissionName = new TextBox();
            lblPermissionName = new Label();
            txtPermissionId = new TextBox();
            lblPermissionId = new Label();
            lblTitle = new Label();
            draftPanel.SuspendLayout();
            tPermission.SuspendLayout();
            SuspendLayout();
            // 
            // draftPanel
            // 
            draftPanel.Controls.Add(btnCancel);
            draftPanel.Controls.Add(btnConfirm);
            draftPanel.Controls.Add(tPermission);
            draftPanel.Controls.Add(txtPermissionName);
            draftPanel.Controls.Add(lblPermissionName);
            draftPanel.Controls.Add(txtPermissionId);
            draftPanel.Controls.Add(lblPermissionId);
            draftPanel.Controls.Add(lblTitle);
            draftPanel.Dock = DockStyle.Fill;
            draftPanel.Location = new Point(0, 0);
            draftPanel.Name = "draftPanel";
            draftPanel.Size = new Size(900, 850);
            draftPanel.TabIndex = 0;
            draftPanel.Paint += draftPanel_Paint;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.BackColor = Color.Red;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(483, 778);
            btnCancel.Margin = new Padding(4, 0, 4, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(12, 14, 12, 16);
            btnCancel.Size = new Size(127, 58);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Hủy";
            btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConfirm.AutoSize = true;
            btnConfirm.BackColor = Color.FromArgb(0, 192, 0);
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(260, 778);
            btnConfirm.Margin = new Padding(4, 0, 4, 0);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Padding = new Padding(12, 14, 12, 16);
            btnConfirm.Size = new Size(127, 58);
            btnConfirm.TabIndex = 8;
            btnConfirm.Text = "Thêm sân";
            btnConfirm.TextAlign = ContentAlignment.MiddleCenter;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // tPermission
            // 
            tPermission.ColumnCount = 5;
            tPermission.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tPermission.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tPermission.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tPermission.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tPermission.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tPermission.Controls.Add(chbViewStatistic, 1, 12);
            tPermission.Controls.Add(chbDeletePermission, 4, 11);
            tPermission.Controls.Add(chbUpdatePermission, 3, 11);
            tPermission.Controls.Add(chbInsertPermission, 2, 11);
            tPermission.Controls.Add(chbViewPermission, 1, 11);
            tPermission.Controls.Add(chbDeleteAccount, 4, 10);
            tPermission.Controls.Add(chbUpdateAccount, 3, 10);
            tPermission.Controls.Add(chbInsertAccount, 2, 10);
            tPermission.Controls.Add(chbViewAccount, 1, 10);
            tPermission.Controls.Add(DeleteEmployee, 4, 9);
            tPermission.Controls.Add(chbUpdateEmployee, 3, 9);
            tPermission.Controls.Add(chbInsertEmployee, 2, 9);
            tPermission.Controls.Add(chbViewEmployee, 1, 9);
            tPermission.Controls.Add(chbUpdateCustomer, 3, 8);
            tPermission.Controls.Add(chbInsertCustomer, 2, 8);
            tPermission.Controls.Add(chbViewCustomer, 1, 8);
            tPermission.Controls.Add(chbDeleteSupplier, 4, 7);
            tPermission.Controls.Add(chbUpdateSupplier, 3, 7);
            tPermission.Controls.Add(chbInsertSupplier, 2, 7);
            tPermission.Controls.Add(chbViewSupplier, 1, 7);
            tPermission.Controls.Add(chbDeleteProduct, 4, 6);
            tPermission.Controls.Add(chbUpdateProduct, 3, 6);
            tPermission.Controls.Add(chbInsertProduct, 2, 6);
            tPermission.Controls.Add(chbViewProduct, 1, 6);
            tPermission.Controls.Add(chbInsertImport, 2, 5);
            tPermission.Controls.Add(chbViewImport, 1, 5);
            tPermission.Controls.Add(chbViewBill, 1, 4);
            tPermission.Controls.Add(chbInserSell, 2, 3);
            tPermission.Controls.Add(chbViewSell, 1, 3);
            tPermission.Controls.Add(chbDeleteCourt, 4, 2);
            tPermission.Controls.Add(chbUpdateCourt, 3, 2);
            tPermission.Controls.Add(chbInsertCourt, 2, 2);
            tPermission.Controls.Add(cbInsertBooking, 2, 1);
            tPermission.Controls.Add(lblBooking, 0, 1);
            tPermission.Controls.Add(lblDelete, 4, 0);
            tPermission.Controls.Add(lblUpdate, 3, 0);
            tPermission.Controls.Add(lblInsert, 2, 0);
            tPermission.Controls.Add(lblView, 1, 0);
            tPermission.Controls.Add(lblFuctionName, 0, 0);
            tPermission.Controls.Add(lblCourt, 0, 2);
            tPermission.Controls.Add(lblSell, 0, 3);
            tPermission.Controls.Add(lblBill, 0, 4);
            tPermission.Controls.Add(lblImport, 0, 5);
            tPermission.Controls.Add(lblProduct, 0, 6);
            tPermission.Controls.Add(lblSupplier, 0, 7);
            tPermission.Controls.Add(lblCustomer, 0, 8);
            tPermission.Controls.Add(label1, 0, 9);
            tPermission.Controls.Add(lblAccount, 0, 10);
            tPermission.Controls.Add(lblPermission, 0, 11);
            tPermission.Controls.Add(label2, 0, 12);
            tPermission.Controls.Add(chbViewBooking, 1, 1);
            tPermission.Controls.Add(chbViewCourt, 1, 2);
            tPermission.Location = new Point(42, 130);
            tPermission.Name = "tPermission";
            tPermission.RowCount = 13;
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tPermission.Size = new Size(806, 633);
            tPermission.TabIndex = 5;
            // 
            // chbViewStatistic
            // 
            chbViewStatistic.Anchor = AnchorStyles.None;
            chbViewStatistic.Appearance = Appearance.Button;
            chbViewStatistic.BackColor = SystemColors.ButtonHighlight;
            chbViewStatistic.BackgroundImageLayout = ImageLayout.None;
            chbViewStatistic.CheckAlign = ContentAlignment.MiddleCenter;
            chbViewStatistic.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbViewStatistic.Location = new Point(362, 584);
            chbViewStatistic.Name = "chbViewStatistic";
            chbViewStatistic.Size = new Size(40, 40);
            chbViewStatistic.TabIndex = 61;
            chbViewStatistic.Tag = "ViewStatistic";
            chbViewStatistic.UseVisualStyleBackColor = false;
            // 
            // chbDeletePermission
            // 
            chbDeletePermission.Anchor = AnchorStyles.None;
            chbDeletePermission.Appearance = Appearance.Button;
            chbDeletePermission.BackColor = SystemColors.ButtonHighlight;
            chbDeletePermission.BackgroundImageLayout = ImageLayout.None;
            chbDeletePermission.CheckAlign = ContentAlignment.MiddleCenter;
            chbDeletePermission.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbDeletePermission.Location = new Point(724, 532);
            chbDeletePermission.Name = "chbDeletePermission";
            chbDeletePermission.Size = new Size(40, 40);
            chbDeletePermission.TabIndex = 60;
            chbDeletePermission.Tag = "DeletePermission";
            chbDeletePermission.UseVisualStyleBackColor = false;
            // 
            // chbUpdatePermission
            // 
            chbUpdatePermission.Anchor = AnchorStyles.None;
            chbUpdatePermission.Appearance = Appearance.Button;
            chbUpdatePermission.BackColor = SystemColors.ButtonHighlight;
            chbUpdatePermission.BackgroundImageLayout = ImageLayout.None;
            chbUpdatePermission.CheckAlign = ContentAlignment.MiddleCenter;
            chbUpdatePermission.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbUpdatePermission.Location = new Point(602, 532);
            chbUpdatePermission.Name = "chbUpdatePermission";
            chbUpdatePermission.Size = new Size(40, 40);
            chbUpdatePermission.TabIndex = 59;
            chbUpdatePermission.Tag = "UpdatePermission";
            chbUpdatePermission.UseVisualStyleBackColor = false;
            // 
            // chbInsertPermission
            // 
            chbInsertPermission.Anchor = AnchorStyles.None;
            chbInsertPermission.Appearance = Appearance.Button;
            chbInsertPermission.BackColor = SystemColors.ButtonHighlight;
            chbInsertPermission.BackgroundImageLayout = ImageLayout.None;
            chbInsertPermission.CheckAlign = ContentAlignment.MiddleCenter;
            chbInsertPermission.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbInsertPermission.Location = new Point(482, 532);
            chbInsertPermission.Name = "chbInsertPermission";
            chbInsertPermission.Size = new Size(40, 40);
            chbInsertPermission.TabIndex = 58;
            chbInsertPermission.Tag = "InsertPermission";
            chbInsertPermission.UseVisualStyleBackColor = false;
            // 
            // chbViewPermission
            // 
            chbViewPermission.Anchor = AnchorStyles.None;
            chbViewPermission.Appearance = Appearance.Button;
            chbViewPermission.BackColor = SystemColors.ButtonHighlight;
            chbViewPermission.BackgroundImageLayout = ImageLayout.None;
            chbViewPermission.CheckAlign = ContentAlignment.MiddleCenter;
            chbViewPermission.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbViewPermission.Location = new Point(362, 532);
            chbViewPermission.Name = "chbViewPermission";
            chbViewPermission.Size = new Size(40, 40);
            chbViewPermission.TabIndex = 57;
            chbViewPermission.Tag = "ViewPermission";
            chbViewPermission.UseVisualStyleBackColor = false;
            // 
            // chbDeleteAccount
            // 
            chbDeleteAccount.Anchor = AnchorStyles.None;
            chbDeleteAccount.Appearance = Appearance.Button;
            chbDeleteAccount.BackColor = SystemColors.ButtonHighlight;
            chbDeleteAccount.BackgroundImageLayout = ImageLayout.None;
            chbDeleteAccount.CheckAlign = ContentAlignment.MiddleCenter;
            chbDeleteAccount.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbDeleteAccount.Location = new Point(724, 484);
            chbDeleteAccount.Name = "chbDeleteAccount";
            chbDeleteAccount.Size = new Size(40, 40);
            chbDeleteAccount.TabIndex = 56;
            chbDeleteAccount.Tag = "DeleteAccount";
            chbDeleteAccount.UseVisualStyleBackColor = false;
            // 
            // chbUpdateAccount
            // 
            chbUpdateAccount.Anchor = AnchorStyles.None;
            chbUpdateAccount.Appearance = Appearance.Button;
            chbUpdateAccount.BackColor = SystemColors.ButtonHighlight;
            chbUpdateAccount.BackgroundImageLayout = ImageLayout.None;
            chbUpdateAccount.CheckAlign = ContentAlignment.MiddleCenter;
            chbUpdateAccount.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbUpdateAccount.Location = new Point(602, 484);
            chbUpdateAccount.Name = "chbUpdateAccount";
            chbUpdateAccount.Size = new Size(40, 40);
            chbUpdateAccount.TabIndex = 55;
            chbUpdateAccount.Tag = "UpdateAccount";
            chbUpdateAccount.UseVisualStyleBackColor = false;
            // 
            // chbInsertAccount
            // 
            chbInsertAccount.Anchor = AnchorStyles.None;
            chbInsertAccount.Appearance = Appearance.Button;
            chbInsertAccount.BackColor = SystemColors.ButtonHighlight;
            chbInsertAccount.BackgroundImageLayout = ImageLayout.None;
            chbInsertAccount.CheckAlign = ContentAlignment.MiddleCenter;
            chbInsertAccount.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbInsertAccount.Location = new Point(482, 484);
            chbInsertAccount.Name = "chbInsertAccount";
            chbInsertAccount.Size = new Size(40, 40);
            chbInsertAccount.TabIndex = 54;
            chbInsertAccount.Tag = "InsertAccount";
            chbInsertAccount.UseVisualStyleBackColor = false;
            // 
            // chbViewAccount
            // 
            chbViewAccount.Anchor = AnchorStyles.None;
            chbViewAccount.Appearance = Appearance.Button;
            chbViewAccount.BackColor = SystemColors.ButtonHighlight;
            chbViewAccount.BackgroundImageLayout = ImageLayout.None;
            chbViewAccount.CheckAlign = ContentAlignment.MiddleCenter;
            chbViewAccount.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbViewAccount.Location = new Point(362, 484);
            chbViewAccount.Name = "chbViewAccount";
            chbViewAccount.Size = new Size(40, 40);
            chbViewAccount.TabIndex = 53;
            chbViewAccount.Tag = "ViewAccount";
            chbViewAccount.UseVisualStyleBackColor = false;
            // 
            // DeleteEmployee
            // 
            DeleteEmployee.Anchor = AnchorStyles.None;
            DeleteEmployee.Appearance = Appearance.Button;
            DeleteEmployee.BackColor = SystemColors.ButtonHighlight;
            DeleteEmployee.BackgroundImageLayout = ImageLayout.None;
            DeleteEmployee.CheckAlign = ContentAlignment.MiddleCenter;
            DeleteEmployee.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteEmployee.Location = new Point(724, 436);
            DeleteEmployee.Name = "DeleteEmployee";
            DeleteEmployee.Size = new Size(40, 40);
            DeleteEmployee.TabIndex = 52;
            DeleteEmployee.Tag = "DeleteEmployee";
            DeleteEmployee.UseVisualStyleBackColor = false;
            // 
            // chbUpdateEmployee
            // 
            chbUpdateEmployee.Anchor = AnchorStyles.None;
            chbUpdateEmployee.Appearance = Appearance.Button;
            chbUpdateEmployee.BackColor = SystemColors.ButtonHighlight;
            chbUpdateEmployee.BackgroundImageLayout = ImageLayout.None;
            chbUpdateEmployee.CheckAlign = ContentAlignment.MiddleCenter;
            chbUpdateEmployee.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbUpdateEmployee.Location = new Point(602, 436);
            chbUpdateEmployee.Name = "chbUpdateEmployee";
            chbUpdateEmployee.Size = new Size(40, 40);
            chbUpdateEmployee.TabIndex = 51;
            chbUpdateEmployee.Tag = "UpdateEmployee";
            chbUpdateEmployee.UseVisualStyleBackColor = false;
            // 
            // chbInsertEmployee
            // 
            chbInsertEmployee.Anchor = AnchorStyles.None;
            chbInsertEmployee.Appearance = Appearance.Button;
            chbInsertEmployee.BackColor = SystemColors.ButtonHighlight;
            chbInsertEmployee.BackgroundImageLayout = ImageLayout.None;
            chbInsertEmployee.CheckAlign = ContentAlignment.MiddleCenter;
            chbInsertEmployee.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbInsertEmployee.Location = new Point(482, 436);
            chbInsertEmployee.Name = "chbInsertEmployee";
            chbInsertEmployee.Size = new Size(40, 40);
            chbInsertEmployee.TabIndex = 50;
            chbInsertEmployee.Tag = "InsertEmployee";
            chbInsertEmployee.UseVisualStyleBackColor = false;
            // 
            // chbViewEmployee
            // 
            chbViewEmployee.Anchor = AnchorStyles.None;
            chbViewEmployee.Appearance = Appearance.Button;
            chbViewEmployee.BackColor = SystemColors.ButtonHighlight;
            chbViewEmployee.BackgroundImageLayout = ImageLayout.None;
            chbViewEmployee.CheckAlign = ContentAlignment.MiddleCenter;
            chbViewEmployee.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbViewEmployee.Location = new Point(362, 436);
            chbViewEmployee.Name = "chbViewEmployee";
            chbViewEmployee.Size = new Size(40, 40);
            chbViewEmployee.TabIndex = 49;
            chbViewEmployee.Tag = "ViewEmployee";
            chbViewEmployee.UseVisualStyleBackColor = false;
            // 
            // chbUpdateCustomer
            // 
            chbUpdateCustomer.Anchor = AnchorStyles.None;
            chbUpdateCustomer.Appearance = Appearance.Button;
            chbUpdateCustomer.BackColor = SystemColors.ButtonHighlight;
            chbUpdateCustomer.BackgroundImageLayout = ImageLayout.None;
            chbUpdateCustomer.CheckAlign = ContentAlignment.MiddleCenter;
            chbUpdateCustomer.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbUpdateCustomer.Location = new Point(602, 388);
            chbUpdateCustomer.Name = "chbUpdateCustomer";
            chbUpdateCustomer.Size = new Size(40, 40);
            chbUpdateCustomer.TabIndex = 47;
            chbUpdateCustomer.Tag = "UpdateCustomer";
            chbUpdateCustomer.UseVisualStyleBackColor = false;
            // 
            // chbInsertCustomer
            // 
            chbInsertCustomer.Anchor = AnchorStyles.None;
            chbInsertCustomer.Appearance = Appearance.Button;
            chbInsertCustomer.BackColor = SystemColors.ButtonHighlight;
            chbInsertCustomer.BackgroundImageLayout = ImageLayout.None;
            chbInsertCustomer.CheckAlign = ContentAlignment.MiddleCenter;
            chbInsertCustomer.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbInsertCustomer.Location = new Point(482, 388);
            chbInsertCustomer.Name = "chbInsertCustomer";
            chbInsertCustomer.Size = new Size(40, 40);
            chbInsertCustomer.TabIndex = 46;
            chbInsertCustomer.Tag = "InsertCustomer";
            chbInsertCustomer.UseVisualStyleBackColor = false;
            // 
            // chbViewCustomer
            // 
            chbViewCustomer.Anchor = AnchorStyles.None;
            chbViewCustomer.Appearance = Appearance.Button;
            chbViewCustomer.BackColor = SystemColors.ButtonHighlight;
            chbViewCustomer.BackgroundImageLayout = ImageLayout.None;
            chbViewCustomer.CheckAlign = ContentAlignment.MiddleCenter;
            chbViewCustomer.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbViewCustomer.Location = new Point(362, 388);
            chbViewCustomer.Name = "chbViewCustomer";
            chbViewCustomer.Size = new Size(40, 40);
            chbViewCustomer.TabIndex = 45;
            chbViewCustomer.Tag = "ViewCustomer";
            chbViewCustomer.UseVisualStyleBackColor = false;
            // 
            // chbDeleteSupplier
            // 
            chbDeleteSupplier.Anchor = AnchorStyles.None;
            chbDeleteSupplier.Appearance = Appearance.Button;
            chbDeleteSupplier.BackColor = SystemColors.ButtonHighlight;
            chbDeleteSupplier.BackgroundImageLayout = ImageLayout.None;
            chbDeleteSupplier.CheckAlign = ContentAlignment.MiddleCenter;
            chbDeleteSupplier.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbDeleteSupplier.Location = new Point(724, 340);
            chbDeleteSupplier.Name = "chbDeleteSupplier";
            chbDeleteSupplier.Size = new Size(40, 40);
            chbDeleteSupplier.TabIndex = 44;
            chbDeleteSupplier.Tag = "DeleteSupplier";
            chbDeleteSupplier.UseVisualStyleBackColor = false;
            // 
            // chbUpdateSupplier
            // 
            chbUpdateSupplier.Anchor = AnchorStyles.None;
            chbUpdateSupplier.Appearance = Appearance.Button;
            chbUpdateSupplier.BackColor = SystemColors.ButtonHighlight;
            chbUpdateSupplier.BackgroundImageLayout = ImageLayout.None;
            chbUpdateSupplier.CheckAlign = ContentAlignment.MiddleCenter;
            chbUpdateSupplier.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbUpdateSupplier.Location = new Point(602, 340);
            chbUpdateSupplier.Name = "chbUpdateSupplier";
            chbUpdateSupplier.Size = new Size(40, 40);
            chbUpdateSupplier.TabIndex = 43;
            chbUpdateSupplier.Tag = "UpdateSupplier";
            chbUpdateSupplier.UseVisualStyleBackColor = false;
            // 
            // chbInsertSupplier
            // 
            chbInsertSupplier.Anchor = AnchorStyles.None;
            chbInsertSupplier.Appearance = Appearance.Button;
            chbInsertSupplier.BackColor = SystemColors.ButtonHighlight;
            chbInsertSupplier.BackgroundImageLayout = ImageLayout.None;
            chbInsertSupplier.CheckAlign = ContentAlignment.MiddleCenter;
            chbInsertSupplier.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbInsertSupplier.Location = new Point(482, 340);
            chbInsertSupplier.Name = "chbInsertSupplier";
            chbInsertSupplier.Size = new Size(40, 40);
            chbInsertSupplier.TabIndex = 42;
            chbInsertSupplier.Tag = "InsertSupplier";
            chbInsertSupplier.UseVisualStyleBackColor = false;
            // 
            // chbViewSupplier
            // 
            chbViewSupplier.Anchor = AnchorStyles.None;
            chbViewSupplier.Appearance = Appearance.Button;
            chbViewSupplier.BackColor = SystemColors.ButtonHighlight;
            chbViewSupplier.BackgroundImageLayout = ImageLayout.None;
            chbViewSupplier.CheckAlign = ContentAlignment.MiddleCenter;
            chbViewSupplier.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbViewSupplier.Location = new Point(362, 340);
            chbViewSupplier.Name = "chbViewSupplier";
            chbViewSupplier.Size = new Size(40, 40);
            chbViewSupplier.TabIndex = 41;
            chbViewSupplier.Tag = "ViewSupplier";
            chbViewSupplier.UseVisualStyleBackColor = false;
            // 
            // chbDeleteProduct
            // 
            chbDeleteProduct.Anchor = AnchorStyles.None;
            chbDeleteProduct.Appearance = Appearance.Button;
            chbDeleteProduct.BackColor = SystemColors.ButtonHighlight;
            chbDeleteProduct.BackgroundImageLayout = ImageLayout.None;
            chbDeleteProduct.CheckAlign = ContentAlignment.MiddleCenter;
            chbDeleteProduct.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbDeleteProduct.Location = new Point(724, 292);
            chbDeleteProduct.Name = "chbDeleteProduct";
            chbDeleteProduct.Size = new Size(40, 40);
            chbDeleteProduct.TabIndex = 40;
            chbDeleteProduct.Tag = "DeleteProduct";
            chbDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // chbUpdateProduct
            // 
            chbUpdateProduct.Anchor = AnchorStyles.None;
            chbUpdateProduct.Appearance = Appearance.Button;
            chbUpdateProduct.BackColor = SystemColors.ButtonHighlight;
            chbUpdateProduct.BackgroundImageLayout = ImageLayout.None;
            chbUpdateProduct.CheckAlign = ContentAlignment.MiddleCenter;
            chbUpdateProduct.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbUpdateProduct.Location = new Point(602, 292);
            chbUpdateProduct.Name = "chbUpdateProduct";
            chbUpdateProduct.Size = new Size(40, 40);
            chbUpdateProduct.TabIndex = 39;
            chbUpdateProduct.Tag = "UpdateProduct";
            chbUpdateProduct.UseVisualStyleBackColor = false;
            // 
            // chbInsertProduct
            // 
            chbInsertProduct.Anchor = AnchorStyles.None;
            chbInsertProduct.Appearance = Appearance.Button;
            chbInsertProduct.BackColor = SystemColors.ButtonHighlight;
            chbInsertProduct.BackgroundImageLayout = ImageLayout.None;
            chbInsertProduct.CheckAlign = ContentAlignment.MiddleCenter;
            chbInsertProduct.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbInsertProduct.Location = new Point(482, 292);
            chbInsertProduct.Name = "chbInsertProduct";
            chbInsertProduct.Size = new Size(40, 40);
            chbInsertProduct.TabIndex = 38;
            chbInsertProduct.Tag = "InsertProduct";
            chbInsertProduct.UseVisualStyleBackColor = false;
            // 
            // chbViewProduct
            // 
            chbViewProduct.Anchor = AnchorStyles.None;
            chbViewProduct.Appearance = Appearance.Button;
            chbViewProduct.BackColor = SystemColors.ButtonHighlight;
            chbViewProduct.BackgroundImageLayout = ImageLayout.None;
            chbViewProduct.CheckAlign = ContentAlignment.MiddleCenter;
            chbViewProduct.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbViewProduct.Location = new Point(362, 292);
            chbViewProduct.Name = "chbViewProduct";
            chbViewProduct.Size = new Size(40, 40);
            chbViewProduct.TabIndex = 37;
            chbViewProduct.Tag = "ViewProduct";
            chbViewProduct.UseVisualStyleBackColor = false;
            // 
            // chbInsertImport
            // 
            chbInsertImport.Anchor = AnchorStyles.None;
            chbInsertImport.Appearance = Appearance.Button;
            chbInsertImport.BackColor = SystemColors.ButtonHighlight;
            chbInsertImport.BackgroundImageLayout = ImageLayout.None;
            chbInsertImport.CheckAlign = ContentAlignment.MiddleCenter;
            chbInsertImport.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbInsertImport.Location = new Point(482, 244);
            chbInsertImport.Name = "chbInsertImport";
            chbInsertImport.Size = new Size(40, 40);
            chbInsertImport.TabIndex = 34;
            chbInsertImport.Tag = "InsertImport";
            chbInsertImport.UseVisualStyleBackColor = false;
            // 
            // chbViewImport
            // 
            chbViewImport.Anchor = AnchorStyles.None;
            chbViewImport.Appearance = Appearance.Button;
            chbViewImport.BackColor = SystemColors.ButtonHighlight;
            chbViewImport.BackgroundImageLayout = ImageLayout.None;
            chbViewImport.CheckAlign = ContentAlignment.MiddleCenter;
            chbViewImport.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbViewImport.Location = new Point(362, 244);
            chbViewImport.Name = "chbViewImport";
            chbViewImport.Size = new Size(40, 40);
            chbViewImport.TabIndex = 33;
            chbViewImport.Tag = "ViewImport";
            chbViewImport.UseVisualStyleBackColor = false;
            // 
            // chbViewBill
            // 
            chbViewBill.Anchor = AnchorStyles.None;
            chbViewBill.Appearance = Appearance.Button;
            chbViewBill.BackColor = SystemColors.ButtonHighlight;
            chbViewBill.BackgroundImageLayout = ImageLayout.None;
            chbViewBill.CheckAlign = ContentAlignment.MiddleCenter;
            chbViewBill.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbViewBill.Location = new Point(362, 196);
            chbViewBill.Name = "chbViewBill";
            chbViewBill.Size = new Size(40, 40);
            chbViewBill.TabIndex = 29;
            chbViewBill.Tag = "ViewBill";
            chbViewBill.UseVisualStyleBackColor = false;
            // 
            // chbInserSell
            // 
            chbInserSell.Anchor = AnchorStyles.None;
            chbInserSell.Appearance = Appearance.Button;
            chbInserSell.BackColor = SystemColors.ButtonHighlight;
            chbInserSell.BackgroundImageLayout = ImageLayout.None;
            chbInserSell.CheckAlign = ContentAlignment.MiddleCenter;
            chbInserSell.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbInserSell.Location = new Point(482, 148);
            chbInserSell.Name = "chbInserSell";
            chbInserSell.Size = new Size(40, 40);
            chbInserSell.TabIndex = 26;
            chbInserSell.Tag = "InsertSell";
            chbInserSell.UseVisualStyleBackColor = false;
            // 
            // chbViewSell
            // 
            chbViewSell.Anchor = AnchorStyles.None;
            chbViewSell.Appearance = Appearance.Button;
            chbViewSell.BackColor = SystemColors.ButtonHighlight;
            chbViewSell.BackgroundImageLayout = ImageLayout.None;
            chbViewSell.CheckAlign = ContentAlignment.MiddleCenter;
            chbViewSell.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbViewSell.Location = new Point(362, 148);
            chbViewSell.Name = "chbViewSell";
            chbViewSell.Size = new Size(40, 40);
            chbViewSell.TabIndex = 25;
            chbViewSell.Tag = "ViewSell";
            chbViewSell.UseVisualStyleBackColor = false;
            // 
            // chbDeleteCourt
            // 
            chbDeleteCourt.Anchor = AnchorStyles.None;
            chbDeleteCourt.Appearance = Appearance.Button;
            chbDeleteCourt.BackColor = SystemColors.ButtonHighlight;
            chbDeleteCourt.BackgroundImageLayout = ImageLayout.None;
            chbDeleteCourt.CheckAlign = ContentAlignment.MiddleCenter;
            chbDeleteCourt.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbDeleteCourt.Location = new Point(724, 100);
            chbDeleteCourt.Name = "chbDeleteCourt";
            chbDeleteCourt.Size = new Size(40, 40);
            chbDeleteCourt.TabIndex = 24;
            chbDeleteCourt.Tag = "DeleteCourt";
            chbDeleteCourt.UseVisualStyleBackColor = false;
            // 
            // chbUpdateCourt
            // 
            chbUpdateCourt.Anchor = AnchorStyles.None;
            chbUpdateCourt.Appearance = Appearance.Button;
            chbUpdateCourt.BackColor = SystemColors.ButtonHighlight;
            chbUpdateCourt.BackgroundImageLayout = ImageLayout.None;
            chbUpdateCourt.CheckAlign = ContentAlignment.MiddleCenter;
            chbUpdateCourt.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbUpdateCourt.Location = new Point(602, 100);
            chbUpdateCourt.Name = "chbUpdateCourt";
            chbUpdateCourt.Size = new Size(40, 40);
            chbUpdateCourt.TabIndex = 23;
            chbUpdateCourt.Tag = "UpdateCourt";
            chbUpdateCourt.UseVisualStyleBackColor = false;
            // 
            // chbInsertCourt
            // 
            chbInsertCourt.Anchor = AnchorStyles.None;
            chbInsertCourt.Appearance = Appearance.Button;
            chbInsertCourt.BackColor = SystemColors.ButtonHighlight;
            chbInsertCourt.BackgroundImageLayout = ImageLayout.None;
            chbInsertCourt.CheckAlign = ContentAlignment.MiddleCenter;
            chbInsertCourt.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbInsertCourt.Location = new Point(482, 100);
            chbInsertCourt.Name = "chbInsertCourt";
            chbInsertCourt.Size = new Size(40, 40);
            chbInsertCourt.TabIndex = 22;
            chbInsertCourt.Tag = "InsertCourt";
            chbInsertCourt.UseVisualStyleBackColor = false;
            // 
            // cbInsertBooking
            // 
            cbInsertBooking.Anchor = AnchorStyles.None;
            cbInsertBooking.Appearance = Appearance.Button;
            cbInsertBooking.BackColor = SystemColors.ButtonHighlight;
            cbInsertBooking.BackgroundImageLayout = ImageLayout.None;
            cbInsertBooking.CheckAlign = ContentAlignment.MiddleCenter;
            cbInsertBooking.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbInsertBooking.Location = new Point(482, 52);
            cbInsertBooking.Name = "cbInsertBooking";
            cbInsertBooking.Size = new Size(40, 40);
            cbInsertBooking.TabIndex = 18;
            cbInsertBooking.Tag = "InsertBooking";
            cbInsertBooking.UseVisualStyleBackColor = false;
            // 
            // lblBooking
            // 
            lblBooking.Anchor = AnchorStyles.None;
            lblBooking.AutoSize = true;
            lblBooking.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBooking.Location = new Point(111, 56);
            lblBooking.Name = "lblBooking";
            lblBooking.Size = new Size(100, 32);
            lblBooking.TabIndex = 5;
            lblBooking.Text = "Đặt sân";
            // 
            // lblDelete
            // 
            lblDelete.Anchor = AnchorStyles.None;
            lblDelete.AutoSize = true;
            lblDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDelete.Location = new Point(715, 8);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new Size(58, 32);
            lblDelete.TabIndex = 4;
            lblDelete.Text = "Xóa";
            // 
            // lblUpdate
            // 
            lblUpdate.Anchor = AnchorStyles.None;
            lblUpdate.AutoSize = true;
            lblUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdate.Location = new Point(594, 8);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(56, 32);
            lblUpdate.TabIndex = 3;
            lblUpdate.Text = "Sửa";
            // 
            // lblInsert
            // 
            lblInsert.Anchor = AnchorStyles.None;
            lblInsert.AutoSize = true;
            lblInsert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInsert.Location = new Point(463, 8);
            lblInsert.Name = "lblInsert";
            lblInsert.Size = new Size(77, 32);
            lblInsert.TabIndex = 2;
            lblInsert.Text = "Thêm";
            // 
            // lblView
            // 
            lblView.Anchor = AnchorStyles.None;
            lblView.AutoSize = true;
            lblView.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblView.Location = new Point(349, 8);
            lblView.Name = "lblView";
            lblView.Size = new Size(65, 32);
            lblView.TabIndex = 1;
            lblView.Text = "Xem";
            // 
            // lblFuctionName
            // 
            lblFuctionName.Anchor = AnchorStyles.None;
            lblFuctionName.AutoSize = true;
            lblFuctionName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFuctionName.Location = new Point(71, 8);
            lblFuctionName.Name = "lblFuctionName";
            lblFuctionName.Size = new Size(180, 32);
            lblFuctionName.TabIndex = 0;
            lblFuctionName.Text = "Tên chức năng";
            // 
            // lblCourt
            // 
            lblCourt.Anchor = AnchorStyles.None;
            lblCourt.AutoSize = true;
            lblCourt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCourt.Location = new Point(87, 104);
            lblCourt.Name = "lblCourt";
            lblCourt.Size = new Size(148, 32);
            lblCourt.TabIndex = 6;
            lblCourt.Text = "Quản lý sân";
            // 
            // lblSell
            // 
            lblSell.Anchor = AnchorStyles.None;
            lblSell.AutoSize = true;
            lblSell.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSell.Location = new Point(100, 152);
            lblSell.Name = "lblSell";
            lblSell.Size = new Size(121, 32);
            lblSell.TabIndex = 7;
            lblSell.Text = "Bán hàng";
            // 
            // lblBill
            // 
            lblBill.Anchor = AnchorStyles.None;
            lblBill.AutoSize = true;
            lblBill.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBill.Location = new Point(37, 200);
            lblBill.Name = "lblBill";
            lblBill.Size = new Size(247, 32);
            lblBill.TabIndex = 8;
            lblBill.Text = "Quản lý hóa đơn đặt";
            // 
            // lblImport
            // 
            lblImport.Anchor = AnchorStyles.None;
            lblImport.AutoSize = true;
            lblImport.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblImport.Location = new Point(91, 248);
            lblImport.Name = "lblImport";
            lblImport.Size = new Size(139, 32);
            lblImport.TabIndex = 9;
            lblImport.Text = "Nhập hàng";
            // 
            // lblProduct
            // 
            lblProduct.Anchor = AnchorStyles.None;
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProduct.Location = new Point(51, 296);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(219, 32);
            lblProduct.TabIndex = 10;
            lblProduct.Text = "Quản lý sản phẩm";
            // 
            // lblSupplier
            // 
            lblSupplier.Anchor = AnchorStyles.None;
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSupplier.Location = new Point(30, 344);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(262, 32);
            lblSupplier.TabIndex = 11;
            lblSupplier.Text = "Quản lý nhà cung cấp";
            // 
            // lblCustomer
            // 
            lblCustomer.Anchor = AnchorStyles.None;
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCustomer.Location = new Point(41, 392);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(239, 32);
            lblCustomer.TabIndex = 12;
            lblCustomer.Text = "Quản lý khách hàng";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(50, 440);
            label1.Name = "label1";
            label1.Size = new Size(221, 32);
            label1.TabIndex = 13;
            label1.Text = "Quản lý nhân viên";
            // 
            // lblAccount
            // 
            lblAccount.Anchor = AnchorStyles.None;
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAccount.Location = new Point(53, 488);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(215, 32);
            lblAccount.TabIndex = 14;
            lblAccount.Text = "Quản lý tài khoản";
            // 
            // lblPermission
            // 
            lblPermission.Anchor = AnchorStyles.None;
            lblPermission.AutoSize = true;
            lblPermission.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPermission.Location = new Point(39, 536);
            lblPermission.Name = "lblPermission";
            lblPermission.Size = new Size(244, 32);
            lblPermission.TabIndex = 15;
            lblPermission.Text = "Quản lý phân quyền";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(101, 588);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 16;
            label2.Text = "Thống kê";
            // 
            // chbViewBooking
            // 
            chbViewBooking.Anchor = AnchorStyles.None;
            chbViewBooking.Appearance = Appearance.Button;
            chbViewBooking.BackColor = SystemColors.ButtonHighlight;
            chbViewBooking.BackgroundImageLayout = ImageLayout.None;
            chbViewBooking.CheckAlign = ContentAlignment.MiddleCenter;
            chbViewBooking.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbViewBooking.Location = new Point(362, 52);
            chbViewBooking.Name = "chbViewBooking";
            chbViewBooking.Size = new Size(40, 40);
            chbViewBooking.TabIndex = 17;
            chbViewBooking.Tag = "ViewBooking";
            chbViewBooking.UseVisualStyleBackColor = false;
            // 
            // chbViewCourt
            // 
            chbViewCourt.Anchor = AnchorStyles.None;
            chbViewCourt.Appearance = Appearance.Button;
            chbViewCourt.BackColor = SystemColors.ButtonHighlight;
            chbViewCourt.BackgroundImageLayout = ImageLayout.None;
            chbViewCourt.CheckAlign = ContentAlignment.MiddleCenter;
            chbViewCourt.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbViewCourt.Location = new Point(362, 100);
            chbViewCourt.Name = "chbViewCourt";
            chbViewCourt.Size = new Size(40, 40);
            chbViewCourt.TabIndex = 19;
            chbViewCourt.Tag = "ViewCourt";
            chbViewCourt.UseVisualStyleBackColor = false;
            // 
            // txtPermissionName
            // 
            txtPermissionName.Font = new Font("Segoe UI", 12F);
            txtPermissionName.Location = new Point(607, 70);
            txtPermissionName.Name = "txtPermissionName";
            txtPermissionName.Size = new Size(241, 39);
            txtPermissionName.TabIndex = 4;
            // 
            // lblPermissionName
            // 
            lblPermissionName.AutoSize = true;
            lblPermissionName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPermissionName.Location = new Point(479, 73);
            lblPermissionName.Name = "lblPermissionName";
            lblPermissionName.Size = new Size(131, 32);
            lblPermissionName.TabIndex = 3;
            lblPermissionName.Text = "Tên quyền:";
            // 
            // txtPermissionId
            // 
            txtPermissionId.Font = new Font("Segoe UI", 12F);
            txtPermissionId.Location = new Point(170, 67);
            txtPermissionId.Name = "txtPermissionId";
            txtPermissionId.ReadOnly = true;
            txtPermissionId.Size = new Size(241, 39);
            txtPermissionId.TabIndex = 2;
            // 
            // lblPermissionId
            // 
            lblPermissionId.AutoSize = true;
            lblPermissionId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPermissionId.Location = new Point(42, 70);
            lblPermissionId.Name = "lblPermissionId";
            lblPermissionId.Size = new Size(127, 32);
            lblPermissionId.TabIndex = 1;
            lblPermissionId.Text = "Mã quyền:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(356, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(201, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thêm quyền";
            // 
            // InsertPermissionGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(draftPanel);
            Name = "InsertPermissionGUI";
            Size = new Size(900, 850);
            draftPanel.ResumeLayout(false);
            draftPanel.PerformLayout();
            tPermission.ResumeLayout(false);
            tPermission.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel draftPanel;
        private Label lblTitle;
        private TextBox txtPermissionName;
        private Label lblPermissionName;
        private TextBox txtPermissionId;
        private Label lblPermissionId;
        private TableLayoutPanel tPermission;
        private Label lblFuctionName;
        private Label lblInsert;
        private Label lblView;
        private Label lblBooking;
        private Label lblDelete;
        private Label lblUpdate;
        private Label lblCourt;
        private Label lblSell;
        private Label lblBill;
        private Label lblImport;
        private Label lblProduct;
        private Label lblSupplier;
        private Label lblCustomer;
        private Label label1;
        private Label lblAccount;
        private Label lblPermission;
        private Label label2;
        private CheckBox chbViewBooking;
        private CheckBox chbDeleteCourt;
        private CheckBox chbUpdateCourt;
        private CheckBox chbInsertCourt;
        private CheckBox cbInsertBooking;
        private CheckBox chbViewCourt;
        private CheckBox chbViewStatistic;
        private CheckBox chbDeletePermission;
        private CheckBox chbUpdatePermission;
        private CheckBox chbInsertPermission;
        private CheckBox chbViewPermission;
        private CheckBox chbDeleteAccount;
        private CheckBox chbUpdateAccount;
        private CheckBox chbInsertAccount;
        private CheckBox chbViewAccount;
        private CheckBox DeleteEmployee;
        private CheckBox chbUpdateEmployee;
        private CheckBox chbInsertEmployee;
        private CheckBox chbViewEmployee;
        private CheckBox checkBox26;
        private CheckBox chbUpdateCustomer;
        private CheckBox chbInsertCustomer;
        private CheckBox chbViewCustomer;
        private CheckBox chbDeleteSupplier;
        private CheckBox chbUpdateSupplier;
        private CheckBox chbInsertSupplier;
        private CheckBox chbViewSupplier;
        private CheckBox chbDeleteProduct;
        private CheckBox chbUpdateProduct;
        private CheckBox chbInsertProduct;
        private CheckBox chbViewProduct;
        private CheckBox chbInsertImport;
        private CheckBox chbViewImport;
        private CheckBox chbViewBill;
        private CheckBox chbInserSell;
        private CheckBox chbViewSell;
        private Label btnCancel;
        private Label btnConfirm;
    }
}
