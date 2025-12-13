namespace BadmintonCourtManagement.GUI
{
    partial class FormhoadonDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.customPanelMain = new CustomPanel();
            this.btnClose = new Label();
            this.panelHeader = new Panel();
            this.tlInfo = new TableLayoutPanel();
            this.lblBillId = new Label();
            this.lblEmployee = new Label();
            this.lblCustomer = new Label();
            this.lblCourt = new Label();
            this.lblTime = new Label();
            this.lblStatus = new Label();
            this.lblTotalPrice = new Label();
            this.lblPrePaid = new Label();
            this.lblRemaining = new Label();
            this.lblTitle = new Label();

            this.customPanelMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.tlInfo.SuspendLayout();
            this.SuspendLayout();

            // customPanelMain
            this.customPanelMain.BackColor = Color.FromArgb(239, 248, 230);
            this.customPanelMain.BorderRadius = 20;
            this.customPanelMain.Controls.Add(this.btnClose);
            this.customPanelMain.Controls.Add(this.panelHeader);
            this.customPanelMain.Controls.Add(this.lblTitle);
            this.customPanelMain.Dock = DockStyle.Fill;
            this.customPanelMain.Location = new Point(0, 0);
            this.customPanelMain.Name = "customPanelMain";
            this.customPanelMain.Size = new Size(960, 660);
            this.customPanelMain.TabIndex = 0;

            // btnClose
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = Color.FromArgb(180, 60, 60);
            this.btnClose.Cursor = Cursors.Hand;
            this.btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnClose.ForeColor = Color.White;
            this.btnClose.Location = new Point(800, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new Padding(30, 12, 30, 12);
            this.btnClose.Size = new Size(137, 56);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Đóng";
            this.btnClose.TextAlign = ContentAlignment.MiddleCenter;
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            // lblTitle
            this.lblTitle.Dock = DockStyle.Top;
            this.lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(0, 120, 103);
            this.lblTitle.Padding = new Padding(0, 25, 0, 10);
            this.lblTitle.Size = new Size(960, 100);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "CHI TIẾT HÓA ĐƠN ĐẶT SÂN";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // panelHeader (nền xanh đậm)
            this.panelHeader.BackColor = Color.FromArgb(0, 120, 103);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Controls.Add(this.tlInfo);
            this.panelHeader.Location = new Point(0, 100);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new Size(960, 480);
            this.panelHeader.TabIndex = 2;

            // tlInfo – Bố cục 3 cột × 3 dòng
            this.tlInfo.ColumnCount = 3;
            this.tlInfo.RowCount = 3;
            this.tlInfo.Dock = DockStyle.Fill;
            this.tlInfo.Padding = new Padding(40, 30, 40, 30);
            this.tlInfo.BackColor = Color.Transparent;

            // Cấu hình cột & dòng đều nhau
            for (int i = 0; i < 3; i++)
            {
                this.tlInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
                this.tlInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            }

            // Hàm setup chung cho các label thông tin
            Action<Label> SetupInfoLabel = lbl =>
            {
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.ForeColor = Color.White;
                lbl.Font = new Font("Segoe UI", 13F);
                lbl.Padding = new Padding(15, 10, 10, 10);
            };

            // Khởi tạo từng label
            this.lblBillId = new Label();     SetupInfoLabel(this.lblBillId);
            this.lblEmployee = new Label();   SetupInfoLabel(this.lblEmployee);
            this.lblCustomer = new Label();   SetupInfoLabel(this.lblCustomer);
            this.lblCourt = new Label();      SetupInfoLabel(this.lblCourt);
            this.lblTime = new Label();       SetupInfoLabel(this.lblTime);
            this.lblStatus = new Label();     SetupInfoLabel(this.lblStatus);

            // 3 label tiền – font to hơn + bold
            this.lblTotalPrice = new Label(); SetupInfoLabel(this.lblTotalPrice);
            this.lblTotalPrice.Font = new Font("Segoe UI", 18F, FontStyle.Bold);

            this.lblPrePaid = new Label();    SetupInfoLabel(this.lblPrePaid);
            this.lblPrePaid.Font = new Font("Segoe UI", 15F, FontStyle.Bold);

            this.lblRemaining = new Label();  SetupInfoLabel(this.lblRemaining);
            this.lblRemaining.Font = new Font("Segoe UI", 20F, FontStyle.Bold);

            // Đưa vào TableLayoutPanel
            this.tlInfo.Controls.Add(this.lblBillId,     0, 0);
            this.tlInfo.Controls.Add(this.lblEmployee,   1, 0);
            this.tlInfo.Controls.Add(this.lblCustomer,   2, 0);
            this.tlInfo.Controls.Add(this.lblCourt,      0, 1);
            this.tlInfo.Controls.Add(this.lblTime,       1, 1);
            this.tlInfo.Controls.Add(this.lblStatus,     2, 1);
            this.tlInfo.Controls.Add(this.lblTotalPrice, 0, 2);
            this.tlInfo.Controls.Add(this.lblPrePaid,    1, 2);
            this.tlInfo.Controls.Add(this.lblRemaining,  2, 2);

            // Form chính
            this.AutoScaleDimensions = new SizeF(9F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(960, 660);
            this.Controls.Add(this.customPanelMain);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "FormBillBookingDetail";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Chi tiết hóa đơn đặt sân";
            this.Load += new EventHandler(this.FormBillBookingDetail_Load);

            this.customPanelMain.ResumeLayout(false);
            this.customPanelMain.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.tlInfo.ResumeLayout(false);
            this.tlInfo.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private CustomPanel customPanelMain;
        private Label lblTitle;
        private Panel panelHeader;
        private TableLayoutPanel tlInfo;

        private Label lblBillId;
        private Label lblEmployee;
        private Label lblCustomer;
        private Label lblCourt;
        private Label lblTime;
        private Label lblStatus;
        private Label lblTotalPrice;
        private Label lblPrePaid;
        private Label lblRemaining;

        private Label btnClose;
    }
}