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
            TitlePanel = new Panel();
            TitleText = new Label();
            bodyPanel = new TableLayoutPanel();
            infoPanel = new TableLayoutPanel();
            EmployeeName = new Label();
            EmployeeRole = new Label();
            EmployeePhone = new Label();
            EmployeeID = new Label();
            EmployeeAddress = new Label();
            EmployeeAccount = new Label();
            picture = new PictureBox();
            EmployeeStatus = new Label();
            MainPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            bodyPanel.SuspendLayout();
            infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.AutoScroll = true;
            MainPanel.BackColor = Color.FromArgb(239, 248, 230);
            MainPanel.Controls.Add(bodyPanel);
            MainPanel.Controls.Add(TitlePanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(35, 39);
            MainPanel.Margin = new Padding(0);
            MainPanel.Name = "MainPanel";
            MainPanel.Padding = new Padding(20);
            MainPanel.Size = new Size(940, 525);
            MainPanel.TabIndex = 0;
            // 
            // TitlePanel
            // 
            TitlePanel.Controls.Add(TitleText);
            TitlePanel.Dock = DockStyle.Top;
            TitlePanel.Location = new Point(20, 20);
            TitlePanel.Margin = new Padding(0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(900, 72);
            TitlePanel.TabIndex = 0;
            // 
            // TitleText
            // 
            TitleText.Dock = DockStyle.Fill;
            TitleText.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            TitleText.Location = new Point(0, 0);
            TitleText.Margin = new Padding(0);
            TitleText.Name = "TitleText";
            TitleText.Size = new Size(900, 72);
            TitleText.TabIndex = 0;
            TitleText.Text = "Chi tiết: NV0001";
            TitleText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bodyPanel
            // 
            bodyPanel.BackColor = Color.FromArgb(200, 250, 214);
            bodyPanel.ColumnCount = 2;
            bodyPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            bodyPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            bodyPanel.Controls.Add(infoPanel, 0, 0);
            bodyPanel.Controls.Add(picture, 1, 0);
            bodyPanel.Dock = DockStyle.Fill;
            bodyPanel.Location = new Point(20, 92);
            bodyPanel.Margin = new Padding(0);
            bodyPanel.Name = "bodyPanel";
            bodyPanel.Padding = new Padding(10);
            bodyPanel.RowCount = 1;
            bodyPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            bodyPanel.Size = new Size(900, 413);
            bodyPanel.TabIndex = 11;
            // 
            // infoPanel
            // 
            infoPanel.ColumnCount = 1;
            infoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            infoPanel.Controls.Add(EmployeeStatus, 0, 6);
            infoPanel.Controls.Add(EmployeeAccount, 0, 5);
            infoPanel.Controls.Add(EmployeeAddress, 0, 4);
            infoPanel.Controls.Add(EmployeeID, 0, 3);
            infoPanel.Controls.Add(EmployeePhone, 0, 2);
            infoPanel.Controls.Add(EmployeeRole, 0, 1);
            infoPanel.Controls.Add(EmployeeName, 0, 0);
            infoPanel.Dock = DockStyle.Fill;
            infoPanel.Location = new Point(13, 13);
            infoPanel.Name = "infoPanel";
            infoPanel.RowCount = 7;
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            infoPanel.Size = new Size(434, 387);
            infoPanel.TabIndex = 0;
            // 
            // EmployeeName
            // 
            EmployeeName.Dock = DockStyle.Fill;
            EmployeeName.Font = new Font("Segoe UI", 12F);
            EmployeeName.Location = new Point(0, 0);
            EmployeeName.Margin = new Padding(0);
            EmployeeName.Name = "EmployeeName";
            EmployeeName.Size = new Size(434, 55);
            EmployeeName.TabIndex = 1;
            EmployeeName.Text = "Tên nhân viên: Lê Thị Thu Trang";
            EmployeeName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EmployeeRole
            // 
            EmployeeRole.Dock = DockStyle.Fill;
            EmployeeRole.Font = new Font("Segoe UI", 12F);
            EmployeeRole.Location = new Point(0, 55);
            EmployeeRole.Margin = new Padding(0);
            EmployeeRole.Name = "EmployeeRole";
            EmployeeRole.Size = new Size(434, 55);
            EmployeeRole.TabIndex = 2;
            EmployeeRole.Text = "Công việc: Thu ngân";
            EmployeeRole.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EmployeePhone
            // 
            EmployeePhone.Dock = DockStyle.Fill;
            EmployeePhone.Font = new Font("Segoe UI", 12F);
            EmployeePhone.Location = new Point(0, 110);
            EmployeePhone.Margin = new Padding(0);
            EmployeePhone.Name = "EmployeePhone";
            EmployeePhone.Size = new Size(434, 55);
            EmployeePhone.TabIndex = 3;
            EmployeePhone.Text = "Số điện thoại: 0123456789";
            EmployeePhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EmployeeID
            // 
            EmployeeID.Dock = DockStyle.Fill;
            EmployeeID.Font = new Font("Segoe UI", 12F);
            EmployeeID.Location = new Point(0, 165);
            EmployeeID.Margin = new Padding(0);
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Size = new Size(434, 55);
            EmployeeID.TabIndex = 4;
            EmployeeID.Text = "CCCD: 123456789";
            EmployeeID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EmployeeAddress
            // 
            EmployeeAddress.Dock = DockStyle.Fill;
            EmployeeAddress.Font = new Font("Segoe UI", 12F);
            EmployeeAddress.Location = new Point(0, 220);
            EmployeeAddress.Margin = new Padding(0);
            EmployeeAddress.Name = "EmployeeAddress";
            EmployeeAddress.Size = new Size(434, 55);
            EmployeeAddress.TabIndex = 5;
            EmployeeAddress.Text = "Địa chỉ: 27 Mã Lò, Bình Trị, TPHCM";
            EmployeeAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EmployeeAccount
            // 
            EmployeeAccount.Dock = DockStyle.Fill;
            EmployeeAccount.Font = new Font("Segoe UI", 12F);
            EmployeeAccount.Location = new Point(0, 275);
            EmployeeAccount.Margin = new Padding(0);
            EmployeeAccount.Name = "EmployeeAccount";
            EmployeeAccount.Size = new Size(434, 55);
            EmployeeAccount.TabIndex = 6;
            EmployeeAccount.Text = "Tên tài khoản: ltttrang@gmail.com";
            EmployeeAccount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picture
            // 
            picture.Dock = DockStyle.Fill;
            picture.Image = Properties.Resources.Employee;
            picture.Location = new Point(490, 10);
            picture.Margin = new Padding(40, 0, 40, 0);
            picture.Name = "picture";
            picture.Size = new Size(360, 393);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.TabIndex = 1;
            picture.TabStop = false;
            // 
            // EmployeeStatus
            // 
            EmployeeStatus.Dock = DockStyle.Fill;
            EmployeeStatus.Font = new Font("Segoe UI", 12F);
            EmployeeStatus.Image = Properties.Resources.Active;
            EmployeeStatus.ImageAlign = ContentAlignment.MiddleRight;
            EmployeeStatus.Location = new Point(0, 330);
            EmployeeStatus.Margin = new Padding(0);
            EmployeeStatus.Name = "EmployeeStatus";
            EmployeeStatus.Size = new Size(434, 57);
            EmployeeStatus.TabIndex = 7;
            EmployeeStatus.Text = "Tình trạng: đang hoạt động";
            EmployeeStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EmployeeDetailsGUI
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 120, 103);
            ClientSize = new Size(1010, 603);
            Controls.Add(MainPanel);
            Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 5, 5, 5);
            MaximizeBox = false;
            Name = "EmployeeDetailsGUI";
            Padding = new Padding(35, 39, 35, 39);
            Text = "Chi tiết nhân viên";
            MainPanel.ResumeLayout(false);
            TitlePanel.ResumeLayout(false);
            bodyPanel.ResumeLayout(false);
            infoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Panel TitlePanel;
        private Label TitleText;
        private TableLayoutPanel bodyPanel;
        private TableLayoutPanel infoPanel;
        private Label EmployeeAddress;
        private Label EmployeeID;
        private Label EmployeePhone;
        private Label EmployeeRole;
        private Label EmployeeName;
        private Label EmployeeAccount;
        private PictureBox picture;
        private Label EmployeeStatus;
    }
}