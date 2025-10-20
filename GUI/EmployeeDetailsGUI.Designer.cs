namespace BadmintonCourtManagement.GUI
{
    partial class EmployeeDetailsGUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainPanel = new Panel();
            PicturePanel = new Panel();
            Picture = new Label();
            ActiveIconPanel = new Panel();
            ActiveIcon = new Label();
            ProductStatusPanel = new Panel();
            EmployeeStatus = new Label();
            ProductTotalPanel = new Panel();
            EmployeeAccount = new Label();
            ProductPricePanel = new Panel();
            EmployeeAddress = new Label();
            ProductQuantityPanel = new Panel();
            EmployeeID = new Label();
            ProductBrandPanel = new Panel();
            EmployeePhone = new Label();
            ProductNamePanel = new Panel();
            EmployeeRole = new Label();
            ProductIDPanel = new Panel();
            EmployeeName = new Label();
            TitlePanel = new Panel();
            TitleText = new Label();
            MainPanel.SuspendLayout();
            PicturePanel.SuspendLayout();
            ActiveIconPanel.SuspendLayout();
            ProductStatusPanel.SuspendLayout();
            ProductTotalPanel.SuspendLayout();
            ProductPricePanel.SuspendLayout();
            ProductQuantityPanel.SuspendLayout();
            ProductBrandPanel.SuspendLayout();
            ProductNamePanel.SuspendLayout();
            ProductIDPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainPanel.AutoScroll = true;
            MainPanel.BackColor = Color.FromArgb(200, 250, 214);
            MainPanel.Controls.Add(PicturePanel);
            MainPanel.Controls.Add(ActiveIconPanel);
            MainPanel.Controls.Add(ProductStatusPanel);
            MainPanel.Controls.Add(ProductTotalPanel);
            MainPanel.Controls.Add(ProductPricePanel);
            MainPanel.Controls.Add(ProductQuantityPanel);
            MainPanel.Controls.Add(ProductBrandPanel);
            MainPanel.Controls.Add(ProductNamePanel);
            MainPanel.Controls.Add(ProductIDPanel);
            MainPanel.Controls.Add(TitlePanel);
            MainPanel.Location = new Point(61, 59);
            MainPanel.Margin = new Padding(0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1488, 937);
            MainPanel.TabIndex = 0;
            // 
            // PicturePanel
            // 
            PicturePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PicturePanel.AutoSize = true;
            PicturePanel.Controls.Add(Picture);
            PicturePanel.Location = new Point(843, 171);
            PicturePanel.Name = "PicturePanel";
            PicturePanel.Size = new Size(592, 735);
            PicturePanel.TabIndex = 10;
            // 
            // Picture
            // 
            Picture.Dock = DockStyle.Fill;
            Picture.Image = Image.FromFile(Application.StartupPath + @"\Img\Employee.png");
            Picture.Location = new Point(0, 0);
            Picture.Margin = new Padding(0);
            Picture.Name = "Picture";
            Picture.Size = new Size(592, 735);
            Picture.TabIndex = 0;
            // 
            // ActiveIconPanel
            // 
            ActiveIconPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ActiveIconPanel.AutoSize = true;
            ActiveIconPanel.Controls.Add(ActiveIcon);
            ActiveIconPanel.Location = new Point(723, 849);
            ActiveIconPanel.Margin = new Padding(0);
            ActiveIconPanel.Name = "ActiveIconPanel";
            ActiveIconPanel.Size = new Size(765, 57);
            ActiveIconPanel.TabIndex = 9;
            // 
            // ActiveIcon
            // 
            ActiveIcon.Dock = DockStyle.Left;
            ActiveIcon.Font = new Font("Roboto Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ActiveIcon.Image = Image.FromFile(Application.StartupPath + @"\Img\Icon\Picture.png");
            ActiveIcon.ImageAlign = ContentAlignment.MiddleLeft;
            ActiveIcon.Location = new Point(0, 0);
            ActiveIcon.Margin = new Padding(0);
            ActiveIcon.Name = "ActiveIcon";
            ActiveIcon.Size = new Size(765, 57);
            ActiveIcon.TabIndex = 0;
            ActiveIcon.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductStatusPanel
            // 
            ProductStatusPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductStatusPanel.AutoSize = true;
            ProductStatusPanel.Controls.Add(EmployeeStatus);
            ProductStatusPanel.Location = new Point(125, 849);
            ProductStatusPanel.Margin = new Padding(0);
            ProductStatusPanel.Name = "ProductStatusPanel";
            ProductStatusPanel.Size = new Size(1363, 57);
            ProductStatusPanel.TabIndex = 8;
            // 
            // EmployeeStatus
            // 
            EmployeeStatus.Dock = DockStyle.Fill;
            EmployeeStatus.Font = new Font("Roboto Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeeStatus.Location = new Point(0, 0);
            EmployeeStatus.Margin = new Padding(0);
            EmployeeStatus.Name = "EmployeeStatus";
            EmployeeStatus.Size = new Size(1363, 57);
            EmployeeStatus.TabIndex = 0;
            EmployeeStatus.Text = "Tình trạng: đang hoạt động";
            EmployeeStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductTotalPanel
            // 
            ProductTotalPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductTotalPanel.AutoSize = true;
            ProductTotalPanel.Controls.Add(EmployeeAccount);
            ProductTotalPanel.Location = new Point(125, 691);
            ProductTotalPanel.Margin = new Padding(0);
            ProductTotalPanel.Name = "ProductTotalPanel";
            ProductTotalPanel.Size = new Size(715, 149);
            ProductTotalPanel.TabIndex = 7;
            // 
            // EmployeeAccount
            // 
            EmployeeAccount.Dock = DockStyle.Fill;
            EmployeeAccount.Font = new Font("Roboto Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeeAccount.Location = new Point(0, 0);
            EmployeeAccount.Margin = new Padding(0);
            EmployeeAccount.Name = "EmployeeAccount";
            EmployeeAccount.Size = new Size(715, 149);
            EmployeeAccount.TabIndex = 0;
            EmployeeAccount.Text = "Tên tài khoản: ltttrang@gmail.com";
            EmployeeAccount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductPricePanel
            // 
            ProductPricePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductPricePanel.AutoSize = true;
            ProductPricePanel.Controls.Add(EmployeeAddress);
            ProductPricePanel.Location = new Point(125, 540);
            ProductPricePanel.Margin = new Padding(0);
            ProductPricePanel.Name = "ProductPricePanel";
            ProductPricePanel.Size = new Size(715, 131);
            ProductPricePanel.TabIndex = 6;
            // 
            // EmployeeAddress
            // 
            EmployeeAddress.Dock = DockStyle.Fill;
            EmployeeAddress.Font = new Font("Roboto Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeeAddress.Location = new Point(0, 0);
            EmployeeAddress.Margin = new Padding(0);
            EmployeeAddress.Name = "EmployeeAddress";
            EmployeeAddress.Size = new Size(715, 131);
            EmployeeAddress.TabIndex = 0;
            EmployeeAddress.Text = "Địa chỉ: 276 Lò Cao, phường Tân Phú, TPHCM";
            EmployeeAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductQuantityPanel
            // 
            ProductQuantityPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductQuantityPanel.AutoSize = true;
            ProductQuantityPanel.Controls.Add(EmployeeID);
            ProductQuantityPanel.Location = new Point(125, 444);
            ProductQuantityPanel.Margin = new Padding(0);
            ProductQuantityPanel.Name = "ProductQuantityPanel";
            ProductQuantityPanel.Size = new Size(1363, 57);
            ProductQuantityPanel.TabIndex = 5;
            // 
            // EmployeeID
            // 
            EmployeeID.Dock = DockStyle.Fill;
            EmployeeID.Font = new Font("Roboto Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeeID.Location = new Point(0, 0);
            EmployeeID.Margin = new Padding(0);
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Size = new Size(1363, 57);
            EmployeeID.TabIndex = 0;
            EmployeeID.Text = "CCCD: 123456789";
            EmployeeID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductBrandPanel
            // 
            ProductBrandPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductBrandPanel.AutoSize = true;
            ProductBrandPanel.Controls.Add(EmployeePhone);
            ProductBrandPanel.Location = new Point(125, 355);
            ProductBrandPanel.Margin = new Padding(0);
            ProductBrandPanel.Name = "ProductBrandPanel";
            ProductBrandPanel.Size = new Size(1363, 57);
            ProductBrandPanel.TabIndex = 4;
            // 
            // EmployeePhone
            // 
            EmployeePhone.Dock = DockStyle.Fill;
            EmployeePhone.Font = new Font("Roboto Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeePhone.Location = new Point(0, 0);
            EmployeePhone.Margin = new Padding(0);
            EmployeePhone.Name = "EmployeePhone";
            EmployeePhone.Size = new Size(1363, 57);
            EmployeePhone.TabIndex = 0;
            EmployeePhone.Text = "Số điện thoại: 0123456789";
            EmployeePhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductNamePanel
            // 
            ProductNamePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductNamePanel.AutoSize = true;
            ProductNamePanel.Controls.Add(EmployeeRole);
            ProductNamePanel.Location = new Point(125, 266);
            ProductNamePanel.Margin = new Padding(0);
            ProductNamePanel.Name = "ProductNamePanel";
            ProductNamePanel.Size = new Size(1363, 57);
            ProductNamePanel.TabIndex = 3;
            // 
            // EmployeeRole
            // 
            EmployeeRole.Dock = DockStyle.Fill;
            EmployeeRole.Font = new Font("Roboto Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeeRole.Location = new Point(0, 0);
            EmployeeRole.Margin = new Padding(0);
            EmployeeRole.Name = "EmployeeRole";
            EmployeeRole.Size = new Size(1363, 57);
            EmployeeRole.TabIndex = 0;
            EmployeeRole.Text = "Công việc: thu ngân";
            EmployeeRole.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductIDPanel
            // 
            ProductIDPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductIDPanel.AutoSize = true;
            ProductIDPanel.Controls.Add(EmployeeName);
            ProductIDPanel.Location = new Point(125, 171);
            ProductIDPanel.Margin = new Padding(0);
            ProductIDPanel.Name = "ProductIDPanel";
            ProductIDPanel.Size = new Size(1363, 57);
            ProductIDPanel.TabIndex = 1;
            // 
            // EmployeeName
            // 
            EmployeeName.Dock = DockStyle.Fill;
            EmployeeName.Font = new Font("Roboto Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeeName.Location = new Point(0, 0);
            EmployeeName.Margin = new Padding(0);
            EmployeeName.Name = "EmployeeName";
            EmployeeName.Size = new Size(1363, 57);
            EmployeeName.TabIndex = 0;
            EmployeeName.Text = "Tên nhân viên: Lê Thị Thu Trang";
            EmployeeName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TitlePanel
            // 
            TitlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitlePanel.AutoSize = true;
            TitlePanel.Controls.Add(TitleText);
            TitlePanel.Location = new Point(125, 0);
            TitlePanel.Margin = new Padding(0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(1363, 94);
            TitlePanel.TabIndex = 0;
            // 
            // TitleText
            // 
            TitleText.Dock = DockStyle.Fill;
            TitleText.Font = new Font("Roboto", 42F, FontStyle.Bold);
            TitleText.Location = new Point(0, 0);
            TitleText.Margin = new Padding(0);
            TitleText.Name = "TitleText";
            TitleText.Size = new Size(1363, 94);
            TitleText.TabIndex = 0;
            TitleText.Text = "Chi tiết: NV0001";
            TitleText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EmployeeDetailsGUI
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 120, 103);
            ClientSize = new Size(1613, 1055);
            Controls.Add(MainPanel);
            Font = new Font("Roboto", 12F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "EmployeeDetailsGUI";
            Text = "Chi tiết kho hàng";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            PicturePanel.ResumeLayout(false);
            ActiveIconPanel.ResumeLayout(false);
            ProductStatusPanel.ResumeLayout(false);
            ProductTotalPanel.ResumeLayout(false);
            ProductPricePanel.ResumeLayout(false);
            ProductQuantityPanel.ResumeLayout(false);
            ProductBrandPanel.ResumeLayout(false);
            ProductNamePanel.ResumeLayout(false);
            ProductIDPanel.ResumeLayout(false);
            TitlePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Panel TitlePanel;
        private Label TitleText;
        private Panel ProductIDPanel;
        private Label EmployeeName;
        private Panel ProductTotalPanel;
        private Label EmployeeAccount;
        private Panel ProductPricePanel;
        private Label EmployeeAddress;
        private Panel ProductQuantityPanel;
        private Label EmployeeID;
        private Panel ProductBrandPanel;
        private Label EmployeePhone;
        private Panel ProductNamePanel;
        private Label EmployeeRole;
        private Panel ProductStatusPanel;
        private Label EmployeeStatus;
        private Panel ActiveIconPanel;
        private Label ActiveIcon;
        private Panel PicturePanel;
        private Label Picture;
    }
}