namespace BadmintonCourtManagement.GUI
{
    partial class FormPermissionGUI
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
            lblStatictis = new Label();
            chbViewBooking = new CheckBox();
            chbViewCourt = new CheckBox();
            chbUpdateBill = new CheckBox();
            lblPriceRule = new Label();
            lblBrand = new Label();
            lblTypeProduct = new Label();
            chbViewPriceRule = new CheckBox();
            chbViewBrand = new CheckBox();
            chbViewTypeProduct = new CheckBox();
            chbInsertPriceRule = new CheckBox();
            chbInsertBrand = new CheckBox();
            InsertTypeProduct = new CheckBox();
            UpdatePriceRule = new CheckBox();
            UpdateBrand = new CheckBox();
            chbUpdateTypeProduct = new CheckBox();
            chbDeletePriceRule = new CheckBox();
            chbDeleteTypeProduct = new CheckBox();
            chbDeleteBrand = new CheckBox();
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
            draftPanel.Margin = new Padding(2);
            draftPanel.Name = "draftPanel";
            draftPanel.Size = new Size(720, 735);
            draftPanel.TabIndex = 0;
            draftPanel.Paint += draftPanel_Paint;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Red;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(385, 663);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(10, 11, 10, 13);
            btnCancel.Size = new Size(102, 46);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Hủy";
            btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirm.AutoSize = true;
            btnConfirm.BackColor = Color.FromArgb(0, 192, 0);
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(203, 662);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Padding = new Padding(10, 11, 10, 13);
            btnConfirm.Size = new Size(102, 47);
            btnConfirm.TabIndex = 8;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.TextAlign = ContentAlignment.MiddleCenter;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // tPermission
            // 
            tPermission.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            tPermission.Controls.Add(lblStatictis, 0, 12);
            tPermission.Controls.Add(chbViewBooking, 1, 1);
            tPermission.Controls.Add(chbViewCourt, 1, 2);
            tPermission.Controls.Add(chbUpdateBill, 3, 4);
            tPermission.Controls.Add(lblPriceRule, 0, 13);
            tPermission.Controls.Add(lblBrand, 0, 14);
            tPermission.Controls.Add(lblTypeProduct, 0, 15);
            tPermission.Controls.Add(chbViewPriceRule, 1, 13);
            tPermission.Controls.Add(chbViewBrand, 1, 14);
            tPermission.Controls.Add(chbViewTypeProduct, 1, 15);
            tPermission.Controls.Add(chbInsertPriceRule, 2, 13);
            tPermission.Controls.Add(chbInsertBrand, 2, 14);
            tPermission.Controls.Add(InsertTypeProduct, 2, 15);
            tPermission.Controls.Add(UpdatePriceRule, 3, 13);
            tPermission.Controls.Add(UpdateBrand, 3, 14);
            tPermission.Controls.Add(chbUpdateTypeProduct, 3, 15);
            tPermission.Controls.Add(chbDeletePriceRule, 4, 13);
            tPermission.Controls.Add(chbDeleteTypeProduct, 4, 15);
            tPermission.Controls.Add(chbDeleteBrand, 4, 14);
            tPermission.Location = new Point(34, 104);
            tPermission.Margin = new Padding(2);
            tPermission.Name = "tPermission";
            tPermission.RowCount = 16;
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 6.2497797F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 6.24978065F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 6.24978065F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 6.24978065F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 6.24978065F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 6.24978065F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 6.24978065F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 6.24978065F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 6.24978065F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 6.24978065F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 6.24978065F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 6.24978065F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 6.24978065F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25095272F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25095272F));
            tPermission.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25095272F));
            tPermission.Size = new Size(645, 531);
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
            chbViewStatistic.Location = new Point(290, 398);
            chbViewStatistic.Margin = new Padding(2);
            chbViewStatistic.Name = "chbViewStatistic";
            chbViewStatistic.Size = new Size(32, 29);
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
            chbDeletePermission.Location = new Point(579, 365);
            chbDeletePermission.Margin = new Padding(2);
            chbDeletePermission.Name = "chbDeletePermission";
            chbDeletePermission.Size = new Size(32, 29);
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
            chbUpdatePermission.Location = new Point(482, 365);
            chbUpdatePermission.Margin = new Padding(2);
            chbUpdatePermission.Name = "chbUpdatePermission";
            chbUpdatePermission.Size = new Size(32, 29);
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
            chbInsertPermission.Location = new Point(386, 365);
            chbInsertPermission.Margin = new Padding(2);
            chbInsertPermission.Name = "chbInsertPermission";
            chbInsertPermission.Size = new Size(32, 29);
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
            chbViewPermission.Location = new Point(290, 365);
            chbViewPermission.Margin = new Padding(2);
            chbViewPermission.Name = "chbViewPermission";
            chbViewPermission.Size = new Size(32, 29);
            chbViewPermission.TabIndex = 57;
            chbViewPermission.Tag = "ViewPermission";
            chbViewPermission.UseVisualStyleBackColor = false;
            chbViewPermission.CheckedChanged += chbViewPermission_CheckedChanged;
            // 
            // chbDeleteAccount
            // 
            chbDeleteAccount.Anchor = AnchorStyles.None;
            chbDeleteAccount.Appearance = Appearance.Button;
            chbDeleteAccount.BackColor = SystemColors.ButtonHighlight;
            chbDeleteAccount.BackgroundImageLayout = ImageLayout.None;
            chbDeleteAccount.CheckAlign = ContentAlignment.MiddleCenter;
            chbDeleteAccount.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbDeleteAccount.Location = new Point(579, 332);
            chbDeleteAccount.Margin = new Padding(2);
            chbDeleteAccount.Name = "chbDeleteAccount";
            chbDeleteAccount.Size = new Size(32, 29);
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
            chbUpdateAccount.Location = new Point(482, 332);
            chbUpdateAccount.Margin = new Padding(2);
            chbUpdateAccount.Name = "chbUpdateAccount";
            chbUpdateAccount.Size = new Size(32, 29);
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
            chbInsertAccount.Location = new Point(386, 332);
            chbInsertAccount.Margin = new Padding(2);
            chbInsertAccount.Name = "chbInsertAccount";
            chbInsertAccount.Size = new Size(32, 29);
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
            chbViewAccount.Location = new Point(290, 332);
            chbViewAccount.Margin = new Padding(2);
            chbViewAccount.Name = "chbViewAccount";
            chbViewAccount.Size = new Size(32, 29);
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
            DeleteEmployee.Location = new Point(579, 299);
            DeleteEmployee.Margin = new Padding(2);
            DeleteEmployee.Name = "DeleteEmployee";
            DeleteEmployee.Size = new Size(32, 29);
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
            chbUpdateEmployee.Location = new Point(482, 299);
            chbUpdateEmployee.Margin = new Padding(2);
            chbUpdateEmployee.Name = "chbUpdateEmployee";
            chbUpdateEmployee.Size = new Size(32, 29);
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
            chbInsertEmployee.Location = new Point(386, 299);
            chbInsertEmployee.Margin = new Padding(2);
            chbInsertEmployee.Name = "chbInsertEmployee";
            chbInsertEmployee.Size = new Size(32, 29);
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
            chbViewEmployee.Location = new Point(290, 299);
            chbViewEmployee.Margin = new Padding(2);
            chbViewEmployee.Name = "chbViewEmployee";
            chbViewEmployee.Size = new Size(32, 29);
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
            chbUpdateCustomer.Location = new Point(482, 266);
            chbUpdateCustomer.Margin = new Padding(2);
            chbUpdateCustomer.Name = "chbUpdateCustomer";
            chbUpdateCustomer.Size = new Size(32, 29);
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
            chbInsertCustomer.Location = new Point(386, 266);
            chbInsertCustomer.Margin = new Padding(2);
            chbInsertCustomer.Name = "chbInsertCustomer";
            chbInsertCustomer.Size = new Size(32, 29);
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
            chbViewCustomer.Location = new Point(290, 266);
            chbViewCustomer.Margin = new Padding(2);
            chbViewCustomer.Name = "chbViewCustomer";
            chbViewCustomer.Size = new Size(32, 29);
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
            chbDeleteSupplier.Location = new Point(579, 233);
            chbDeleteSupplier.Margin = new Padding(2);
            chbDeleteSupplier.Name = "chbDeleteSupplier";
            chbDeleteSupplier.Size = new Size(32, 29);
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
            chbUpdateSupplier.Location = new Point(482, 233);
            chbUpdateSupplier.Margin = new Padding(2);
            chbUpdateSupplier.Name = "chbUpdateSupplier";
            chbUpdateSupplier.Size = new Size(32, 29);
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
            chbInsertSupplier.Location = new Point(386, 233);
            chbInsertSupplier.Margin = new Padding(2);
            chbInsertSupplier.Name = "chbInsertSupplier";
            chbInsertSupplier.Size = new Size(32, 29);
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
            chbViewSupplier.Location = new Point(290, 233);
            chbViewSupplier.Margin = new Padding(2);
            chbViewSupplier.Name = "chbViewSupplier";
            chbViewSupplier.Size = new Size(32, 29);
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
            chbDeleteProduct.Location = new Point(579, 200);
            chbDeleteProduct.Margin = new Padding(2);
            chbDeleteProduct.Name = "chbDeleteProduct";
            chbDeleteProduct.Size = new Size(32, 29);
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
            chbUpdateProduct.Location = new Point(482, 200);
            chbUpdateProduct.Margin = new Padding(2);
            chbUpdateProduct.Name = "chbUpdateProduct";
            chbUpdateProduct.Size = new Size(32, 29);
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
            chbInsertProduct.Location = new Point(386, 200);
            chbInsertProduct.Margin = new Padding(2);
            chbInsertProduct.Name = "chbInsertProduct";
            chbInsertProduct.Size = new Size(32, 29);
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
            chbViewProduct.Location = new Point(290, 200);
            chbViewProduct.Margin = new Padding(2);
            chbViewProduct.Name = "chbViewProduct";
            chbViewProduct.Size = new Size(32, 29);
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
            chbInsertImport.Location = new Point(386, 167);
            chbInsertImport.Margin = new Padding(2);
            chbInsertImport.Name = "chbInsertImport";
            chbInsertImport.Size = new Size(32, 29);
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
            chbViewImport.Location = new Point(290, 167);
            chbViewImport.Margin = new Padding(2);
            chbViewImport.Name = "chbViewImport";
            chbViewImport.Size = new Size(32, 29);
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
            chbViewBill.Location = new Point(290, 134);
            chbViewBill.Margin = new Padding(2);
            chbViewBill.Name = "chbViewBill";
            chbViewBill.Size = new Size(32, 29);
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
            chbInserSell.Location = new Point(386, 101);
            chbInserSell.Margin = new Padding(2);
            chbInserSell.Name = "chbInserSell";
            chbInserSell.Size = new Size(32, 29);
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
            chbViewSell.Location = new Point(290, 101);
            chbViewSell.Margin = new Padding(2);
            chbViewSell.Name = "chbViewSell";
            chbViewSell.Size = new Size(32, 29);
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
            chbDeleteCourt.Location = new Point(579, 68);
            chbDeleteCourt.Margin = new Padding(2);
            chbDeleteCourt.Name = "chbDeleteCourt";
            chbDeleteCourt.Size = new Size(32, 29);
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
            chbUpdateCourt.Location = new Point(482, 68);
            chbUpdateCourt.Margin = new Padding(2);
            chbUpdateCourt.Name = "chbUpdateCourt";
            chbUpdateCourt.Size = new Size(32, 29);
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
            chbInsertCourt.Location = new Point(386, 68);
            chbInsertCourt.Margin = new Padding(2);
            chbInsertCourt.Name = "chbInsertCourt";
            chbInsertCourt.Size = new Size(32, 29);
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
            cbInsertBooking.Location = new Point(386, 35);
            cbInsertBooking.Margin = new Padding(2);
            cbInsertBooking.Name = "cbInsertBooking";
            cbInsertBooking.Size = new Size(32, 29);
            cbInsertBooking.TabIndex = 18;
            cbInsertBooking.Tag = "InsertBooking";
            cbInsertBooking.UseVisualStyleBackColor = false;
            // 
            // lblBooking
            // 
            lblBooking.Anchor = AnchorStyles.None;
            lblBooking.AutoSize = true;
            lblBooking.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBooking.Location = new Point(87, 35);
            lblBooking.Margin = new Padding(2, 0, 2, 0);
            lblBooking.Name = "lblBooking";
            lblBooking.Size = new Size(84, 28);
            lblBooking.TabIndex = 5;
            lblBooking.Text = "Đặt sân";
            // 
            // lblDelete
            // 
            lblDelete.Anchor = AnchorStyles.None;
            lblDelete.AutoSize = true;
            lblDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDelete.Location = new Point(571, 2);
            lblDelete.Margin = new Padding(2, 0, 2, 0);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new Size(48, 28);
            lblDelete.TabIndex = 4;
            lblDelete.Text = "Xóa";
            // 
            // lblUpdate
            // 
            lblUpdate.Anchor = AnchorStyles.None;
            lblUpdate.AutoSize = true;
            lblUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdate.Location = new Point(474, 2);
            lblUpdate.Margin = new Padding(2, 0, 2, 0);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(47, 28);
            lblUpdate.TabIndex = 3;
            lblUpdate.Text = "Sửa";
            // 
            // lblInsert
            // 
            lblInsert.Anchor = AnchorStyles.None;
            lblInsert.AutoSize = true;
            lblInsert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInsert.Location = new Point(369, 2);
            lblInsert.Margin = new Padding(2, 0, 2, 0);
            lblInsert.Name = "lblInsert";
            lblInsert.Size = new Size(65, 28);
            lblInsert.TabIndex = 2;
            lblInsert.Text = "Thêm";
            // 
            // lblView
            // 
            lblView.Anchor = AnchorStyles.None;
            lblView.AutoSize = true;
            lblView.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblView.Location = new Point(279, 2);
            lblView.Margin = new Padding(2, 0, 2, 0);
            lblView.Name = "lblView";
            lblView.Size = new Size(54, 28);
            lblView.TabIndex = 1;
            lblView.Text = "Xem";
            // 
            // lblFuctionName
            // 
            lblFuctionName.Anchor = AnchorStyles.None;
            lblFuctionName.AutoSize = true;
            lblFuctionName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFuctionName.Location = new Point(54, 2);
            lblFuctionName.Margin = new Padding(2, 0, 2, 0);
            lblFuctionName.Name = "lblFuctionName";
            lblFuctionName.Size = new Size(149, 28);
            lblFuctionName.TabIndex = 0;
            lblFuctionName.Text = "Tên chức năng";
            // 
            // lblCourt
            // 
            lblCourt.Anchor = AnchorStyles.None;
            lblCourt.AutoSize = true;
            lblCourt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCourt.Location = new Point(67, 68);
            lblCourt.Margin = new Padding(2, 0, 2, 0);
            lblCourt.Name = "lblCourt";
            lblCourt.Size = new Size(123, 28);
            lblCourt.TabIndex = 6;
            lblCourt.Text = "Quản lý sân";
            // 
            // lblSell
            // 
            lblSell.Anchor = AnchorStyles.None;
            lblSell.AutoSize = true;
            lblSell.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSell.Location = new Point(78, 101);
            lblSell.Margin = new Padding(2, 0, 2, 0);
            lblSell.Name = "lblSell";
            lblSell.Size = new Size(101, 28);
            lblSell.TabIndex = 7;
            lblSell.Text = "Bán hàng";
            // 
            // lblBill
            // 
            lblBill.Anchor = AnchorStyles.None;
            lblBill.AutoSize = true;
            lblBill.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBill.Location = new Point(44, 134);
            lblBill.Margin = new Padding(2, 0, 2, 0);
            lblBill.Name = "lblBill";
            lblBill.Size = new Size(170, 28);
            lblBill.TabIndex = 8;
            lblBill.Text = "Quản lý hóa đơn";
            // 
            // lblImport
            // 
            lblImport.Anchor = AnchorStyles.None;
            lblImport.AutoSize = true;
            lblImport.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblImport.Location = new Point(71, 167);
            lblImport.Margin = new Padding(2, 0, 2, 0);
            lblImport.Name = "lblImport";
            lblImport.Size = new Size(116, 28);
            lblImport.TabIndex = 9;
            lblImport.Text = "Nhập hàng";
            // 
            // lblProduct
            // 
            lblProduct.Anchor = AnchorStyles.None;
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProduct.Location = new Point(38, 200);
            lblProduct.Margin = new Padding(2, 0, 2, 0);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(182, 28);
            lblProduct.TabIndex = 10;
            lblProduct.Text = "Quản lý sản phẩm";
            // 
            // lblSupplier
            // 
            lblSupplier.Anchor = AnchorStyles.None;
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSupplier.Location = new Point(20, 233);
            lblSupplier.Margin = new Padding(2, 0, 2, 0);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(217, 28);
            lblSupplier.TabIndex = 11;
            lblSupplier.Text = "Quản lý nhà cung cấp";
            // 
            // lblCustomer
            // 
            lblCustomer.Anchor = AnchorStyles.None;
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCustomer.Location = new Point(29, 266);
            lblCustomer.Margin = new Padding(2, 0, 2, 0);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(200, 28);
            lblCustomer.TabIndex = 12;
            lblCustomer.Text = "Quản lý khách hàng";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(37, 299);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 28);
            label1.TabIndex = 13;
            label1.Text = "Quản lý nhân viên";
            // 
            // lblAccount
            // 
            lblAccount.Anchor = AnchorStyles.None;
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAccount.Location = new Point(39, 332);
            lblAccount.Margin = new Padding(2, 0, 2, 0);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(180, 28);
            lblAccount.TabIndex = 14;
            lblAccount.Text = "Quản lý tài khoản";
            // 
            // lblPermission
            // 
            lblPermission.Anchor = AnchorStyles.None;
            lblPermission.AutoSize = true;
            lblPermission.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPermission.Location = new Point(28, 365);
            lblPermission.Margin = new Padding(2, 0, 2, 0);
            lblPermission.Name = "lblPermission";
            lblPermission.Size = new Size(202, 28);
            lblPermission.TabIndex = 15;
            lblPermission.Text = "Quản lý phân quyền";
            // 
            // lblStatictis
            // 
            lblStatictis.Anchor = AnchorStyles.None;
            lblStatictis.AutoSize = true;
            lblStatictis.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStatictis.Location = new Point(79, 398);
            lblStatictis.Margin = new Padding(2, 0, 2, 0);
            lblStatictis.Name = "lblStatictis";
            lblStatictis.Size = new Size(100, 28);
            lblStatictis.TabIndex = 16;
            lblStatictis.Text = "Thống kê";
            // 
            // chbViewBooking
            // 
            chbViewBooking.Anchor = AnchorStyles.None;
            chbViewBooking.Appearance = Appearance.Button;
            chbViewBooking.BackColor = SystemColors.ButtonHighlight;
            chbViewBooking.BackgroundImageLayout = ImageLayout.None;
            chbViewBooking.CheckAlign = ContentAlignment.MiddleCenter;
            chbViewBooking.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbViewBooking.Location = new Point(290, 35);
            chbViewBooking.Margin = new Padding(2);
            chbViewBooking.Name = "chbViewBooking";
            chbViewBooking.Size = new Size(32, 29);
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
            chbViewCourt.Location = new Point(290, 68);
            chbViewCourt.Margin = new Padding(2);
            chbViewCourt.Name = "chbViewCourt";
            chbViewCourt.Size = new Size(32, 29);
            chbViewCourt.TabIndex = 19;
            chbViewCourt.Tag = "ViewCourt";
            chbViewCourt.UseVisualStyleBackColor = false;
            // 
            // chbUpdateBill
            // 
            chbUpdateBill.Anchor = AnchorStyles.None;
            chbUpdateBill.Appearance = Appearance.Button;
            chbUpdateBill.BackColor = SystemColors.ButtonHighlight;
            chbUpdateBill.BackgroundImageLayout = ImageLayout.None;
            chbUpdateBill.CheckAlign = ContentAlignment.MiddleCenter;
            chbUpdateBill.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbUpdateBill.Location = new Point(482, 134);
            chbUpdateBill.Margin = new Padding(2);
            chbUpdateBill.Name = "chbUpdateBill";
            chbUpdateBill.Size = new Size(32, 29);
            chbUpdateBill.TabIndex = 62;
            chbUpdateBill.Tag = "UpdateBill";
            chbUpdateBill.UseVisualStyleBackColor = false;
            // 
            // lblPriceRule
            // 
            lblPriceRule.Anchor = AnchorStyles.None;
            lblPriceRule.AutoSize = true;
            lblPriceRule.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPriceRule.Location = new Point(50, 431);
            lblPriceRule.Margin = new Padding(2, 0, 2, 0);
            lblPriceRule.Name = "lblPriceRule";
            lblPriceRule.Size = new Size(158, 28);
            lblPriceRule.TabIndex = 63;
            lblPriceRule.Text = "Quản lý giá sân";
            // 
            // lblBrand
            // 
            lblBrand.Anchor = AnchorStyles.None;
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBrand.Location = new Point(25, 464);
            lblBrand.Margin = new Padding(2, 0, 2, 0);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(208, 28);
            lblBrand.TabIndex = 64;
            lblBrand.Text = "Quản lý thương hiệu";
            // 
            // lblTypeProduct
            // 
            lblTypeProduct.Anchor = AnchorStyles.None;
            lblTypeProduct.AutoSize = true;
            lblTypeProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTypeProduct.Location = new Point(17, 499);
            lblTypeProduct.Margin = new Padding(2, 0, 2, 0);
            lblTypeProduct.Name = "lblTypeProduct";
            lblTypeProduct.Size = new Size(223, 28);
            lblTypeProduct.TabIndex = 65;
            lblTypeProduct.Text = "Quản lý loại sản phẩm";
            // 
            // chbViewPriceRule
            // 
            chbViewPriceRule.Anchor = AnchorStyles.None;
            chbViewPriceRule.Appearance = Appearance.Button;
            chbViewPriceRule.BackColor = SystemColors.ButtonHighlight;
            chbViewPriceRule.BackgroundImageLayout = ImageLayout.None;
            chbViewPriceRule.CheckAlign = ContentAlignment.MiddleCenter;
            chbViewPriceRule.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbViewPriceRule.Location = new Point(290, 431);
            chbViewPriceRule.Margin = new Padding(2);
            chbViewPriceRule.Name = "chbViewPriceRule";
            chbViewPriceRule.Size = new Size(32, 29);
            chbViewPriceRule.TabIndex = 66;
            chbViewPriceRule.Tag = "ViewPriceRule";
            chbViewPriceRule.UseVisualStyleBackColor = false;
            // 
            // chbViewBrand
            // 
            chbViewBrand.Anchor = AnchorStyles.None;
            chbViewBrand.Appearance = Appearance.Button;
            chbViewBrand.BackColor = SystemColors.ButtonHighlight;
            chbViewBrand.BackgroundImageLayout = ImageLayout.None;
            chbViewBrand.CheckAlign = ContentAlignment.MiddleCenter;
            chbViewBrand.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbViewBrand.Location = new Point(290, 464);
            chbViewBrand.Margin = new Padding(2);
            chbViewBrand.Name = "chbViewBrand";
            chbViewBrand.Size = new Size(32, 29);
            chbViewBrand.TabIndex = 67;
            chbViewBrand.Tag = "ViewBrand";
            chbViewBrand.UseVisualStyleBackColor = false;
            // 
            // chbViewTypeProduct
            // 
            chbViewTypeProduct.Anchor = AnchorStyles.None;
            chbViewTypeProduct.Appearance = Appearance.Button;
            chbViewTypeProduct.BackColor = SystemColors.ButtonHighlight;
            chbViewTypeProduct.BackgroundImageLayout = ImageLayout.None;
            chbViewTypeProduct.CheckAlign = ContentAlignment.MiddleCenter;
            chbViewTypeProduct.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbViewTypeProduct.Location = new Point(290, 498);
            chbViewTypeProduct.Margin = new Padding(2);
            chbViewTypeProduct.Name = "chbViewTypeProduct";
            chbViewTypeProduct.Size = new Size(32, 29);
            chbViewTypeProduct.TabIndex = 68;
            chbViewTypeProduct.Tag = "ViewTypeProduct";
            chbViewTypeProduct.UseVisualStyleBackColor = false;
            // 
            // chbInsertPriceRule
            // 
            chbInsertPriceRule.Anchor = AnchorStyles.None;
            chbInsertPriceRule.Appearance = Appearance.Button;
            chbInsertPriceRule.BackColor = SystemColors.ButtonHighlight;
            chbInsertPriceRule.BackgroundImageLayout = ImageLayout.None;
            chbInsertPriceRule.CheckAlign = ContentAlignment.MiddleCenter;
            chbInsertPriceRule.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbInsertPriceRule.Location = new Point(386, 431);
            chbInsertPriceRule.Margin = new Padding(2);
            chbInsertPriceRule.Name = "chbInsertPriceRule";
            chbInsertPriceRule.Size = new Size(32, 29);
            chbInsertPriceRule.TabIndex = 69;
            chbInsertPriceRule.Tag = "InsertPriceRule";
            chbInsertPriceRule.UseVisualStyleBackColor = false;
            // 
            // chbInsertBrand
            // 
            chbInsertBrand.Anchor = AnchorStyles.None;
            chbInsertBrand.Appearance = Appearance.Button;
            chbInsertBrand.BackColor = SystemColors.ButtonHighlight;
            chbInsertBrand.BackgroundImageLayout = ImageLayout.None;
            chbInsertBrand.CheckAlign = ContentAlignment.MiddleCenter;
            chbInsertBrand.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbInsertBrand.Location = new Point(386, 464);
            chbInsertBrand.Margin = new Padding(2);
            chbInsertBrand.Name = "chbInsertBrand";
            chbInsertBrand.Size = new Size(32, 29);
            chbInsertBrand.TabIndex = 70;
            chbInsertBrand.Tag = "InsertBrand";
            chbInsertBrand.UseVisualStyleBackColor = false;
            // 
            // InsertTypeProduct
            // 
            InsertTypeProduct.Anchor = AnchorStyles.None;
            InsertTypeProduct.Appearance = Appearance.Button;
            InsertTypeProduct.BackColor = SystemColors.ButtonHighlight;
            InsertTypeProduct.BackgroundImageLayout = ImageLayout.None;
            InsertTypeProduct.CheckAlign = ContentAlignment.MiddleCenter;
            InsertTypeProduct.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InsertTypeProduct.Location = new Point(386, 498);
            InsertTypeProduct.Margin = new Padding(2);
            InsertTypeProduct.Name = "InsertTypeProduct";
            InsertTypeProduct.Size = new Size(32, 29);
            InsertTypeProduct.TabIndex = 71;
            InsertTypeProduct.Tag = "InsertTypeProduct";
            InsertTypeProduct.UseVisualStyleBackColor = false;
            // 
            // UpdatePriceRule
            // 
            UpdatePriceRule.Anchor = AnchorStyles.None;
            UpdatePriceRule.Appearance = Appearance.Button;
            UpdatePriceRule.BackColor = SystemColors.ButtonHighlight;
            UpdatePriceRule.BackgroundImageLayout = ImageLayout.None;
            UpdatePriceRule.CheckAlign = ContentAlignment.MiddleCenter;
            UpdatePriceRule.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdatePriceRule.Location = new Point(482, 431);
            UpdatePriceRule.Margin = new Padding(2);
            UpdatePriceRule.Name = "UpdatePriceRule";
            UpdatePriceRule.Size = new Size(32, 29);
            UpdatePriceRule.TabIndex = 72;
            UpdatePriceRule.Tag = "UpdatePriceRule";
            UpdatePriceRule.UseVisualStyleBackColor = false;
            // 
            // UpdateBrand
            // 
            UpdateBrand.Anchor = AnchorStyles.None;
            UpdateBrand.Appearance = Appearance.Button;
            UpdateBrand.BackColor = SystemColors.ButtonHighlight;
            UpdateBrand.BackgroundImageLayout = ImageLayout.None;
            UpdateBrand.CheckAlign = ContentAlignment.MiddleCenter;
            UpdateBrand.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBrand.Location = new Point(482, 464);
            UpdateBrand.Margin = new Padding(2);
            UpdateBrand.Name = "UpdateBrand";
            UpdateBrand.Size = new Size(32, 29);
            UpdateBrand.TabIndex = 73;
            UpdateBrand.Tag = "UpdateBrand";
            UpdateBrand.UseVisualStyleBackColor = false;
            // 
            // chbUpdateTypeProduct
            // 
            chbUpdateTypeProduct.Anchor = AnchorStyles.None;
            chbUpdateTypeProduct.Appearance = Appearance.Button;
            chbUpdateTypeProduct.BackColor = SystemColors.ButtonHighlight;
            chbUpdateTypeProduct.BackgroundImageLayout = ImageLayout.None;
            chbUpdateTypeProduct.CheckAlign = ContentAlignment.MiddleCenter;
            chbUpdateTypeProduct.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbUpdateTypeProduct.Location = new Point(482, 498);
            chbUpdateTypeProduct.Margin = new Padding(2);
            chbUpdateTypeProduct.Name = "chbUpdateTypeProduct";
            chbUpdateTypeProduct.Size = new Size(32, 29);
            chbUpdateTypeProduct.TabIndex = 74;
            chbUpdateTypeProduct.Tag = "UpdateTypeProduct";
            chbUpdateTypeProduct.UseVisualStyleBackColor = false;
            // 
            // chbDeletePriceRule
            // 
            chbDeletePriceRule.Anchor = AnchorStyles.None;
            chbDeletePriceRule.Appearance = Appearance.Button;
            chbDeletePriceRule.BackColor = SystemColors.ButtonHighlight;
            chbDeletePriceRule.BackgroundImageLayout = ImageLayout.None;
            chbDeletePriceRule.CheckAlign = ContentAlignment.MiddleCenter;
            chbDeletePriceRule.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbDeletePriceRule.Location = new Point(579, 431);
            chbDeletePriceRule.Margin = new Padding(2);
            chbDeletePriceRule.Name = "chbDeletePriceRule";
            chbDeletePriceRule.Size = new Size(32, 29);
            chbDeletePriceRule.TabIndex = 75;
            chbDeletePriceRule.Tag = "DeletePriceRule";
            chbDeletePriceRule.UseVisualStyleBackColor = false;
            chbDeletePriceRule.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // chbDeleteTypeProduct
            // 
            chbDeleteTypeProduct.Anchor = AnchorStyles.None;
            chbDeleteTypeProduct.Appearance = Appearance.Button;
            chbDeleteTypeProduct.BackColor = SystemColors.ButtonHighlight;
            chbDeleteTypeProduct.BackgroundImageLayout = ImageLayout.None;
            chbDeleteTypeProduct.CheckAlign = ContentAlignment.MiddleCenter;
            chbDeleteTypeProduct.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbDeleteTypeProduct.Location = new Point(579, 498);
            chbDeleteTypeProduct.Margin = new Padding(2);
            chbDeleteTypeProduct.Name = "chbDeleteTypeProduct";
            chbDeleteTypeProduct.Size = new Size(32, 29);
            chbDeleteTypeProduct.TabIndex = 76;
            chbDeleteTypeProduct.Tag = "DeleteTypeProduct";
            chbDeleteTypeProduct.UseVisualStyleBackColor = false;
            // 
            // chbDeleteBrand
            // 
            chbDeleteBrand.Anchor = AnchorStyles.None;
            chbDeleteBrand.Appearance = Appearance.Button;
            chbDeleteBrand.BackColor = SystemColors.ButtonHighlight;
            chbDeleteBrand.BackgroundImageLayout = ImageLayout.None;
            chbDeleteBrand.CheckAlign = ContentAlignment.MiddleCenter;
            chbDeleteBrand.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbDeleteBrand.Location = new Point(579, 464);
            chbDeleteBrand.Margin = new Padding(2);
            chbDeleteBrand.Name = "chbDeleteBrand";
            chbDeleteBrand.Size = new Size(32, 29);
            chbDeleteBrand.TabIndex = 77;
            chbDeleteBrand.Tag = "DeleteBrand";
            chbDeleteBrand.UseVisualStyleBackColor = false;
            // 
            // txtPermissionName
            // 
            txtPermissionName.Font = new Font("Segoe UI", 12F);
            txtPermissionName.Location = new Point(486, 56);
            txtPermissionName.Margin = new Padding(2);
            txtPermissionName.Name = "txtPermissionName";
            txtPermissionName.Size = new Size(194, 34);
            txtPermissionName.TabIndex = 4;
            // 
            // lblPermissionName
            // 
            lblPermissionName.AutoSize = true;
            lblPermissionName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPermissionName.Location = new Point(383, 58);
            lblPermissionName.Margin = new Padding(2, 0, 2, 0);
            lblPermissionName.Name = "lblPermissionName";
            lblPermissionName.Size = new Size(104, 28);
            lblPermissionName.TabIndex = 3;
            lblPermissionName.Text = "Tên quyền:";
            // 
            // txtPermissionId
            // 
            txtPermissionId.Font = new Font("Segoe UI", 12F);
            txtPermissionId.Location = new Point(136, 54);
            txtPermissionId.Margin = new Padding(2);
            txtPermissionId.Name = "txtPermissionId";
            txtPermissionId.ReadOnly = true;
            txtPermissionId.Size = new Size(194, 34);
            txtPermissionId.TabIndex = 2;
            // 
            // lblPermissionId
            // 
            lblPermissionId.AutoSize = true;
            lblPermissionId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPermissionId.Location = new Point(34, 56);
            lblPermissionId.Margin = new Padding(2, 0, 2, 0);
            lblPermissionId.Name = "lblPermissionId";
            lblPermissionId.Size = new Size(103, 28);
            lblPermissionId.TabIndex = 1;
            lblPermissionId.Text = "Mã quyền:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(285, 5);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(169, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thêm quyền";
            // 
            // FormPermissionGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(draftPanel);
            Margin = new Padding(2);
            Name = "FormPermissionGUI";
            Size = new Size(720, 735);
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
        private Label lblStatictis;
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
        private CheckBox chbUpdateBill;
        private Label lblPriceRule;
        private Label lblBrand;
        private Label lblTypeProduct;
        private CheckBox chbViewPriceRule;
        private CheckBox chbViewBrand;
        private CheckBox chbViewTypeProduct;
        private CheckBox chbInsertPriceRule;
        private CheckBox chbInsertBrand;
        private CheckBox InsertTypeProduct;
        private CheckBox UpdatePriceRule;
        private CheckBox UpdateBrand;
        private CheckBox chbUpdateTypeProduct;
        private CheckBox chbDeletePriceRule;
        private CheckBox chbDeleteTypeProduct;
        private CheckBox chbDeleteBrand;
    }
}
