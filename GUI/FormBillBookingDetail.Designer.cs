namespace BadmintonCourtManagement.GUI
{
    partial class FormBillBookingDetail
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            customPanelMain = new CustomPanel();
            btnClose = new Label();
            panelHeader = new Panel();
            tlInfo = new TableLayoutPanel();
            lblBillId = new Label();
            lblEmployee = new Label();
            lblCustomer = new Label();
            lblCourt = new Label();
            lblTime = new Label();
            lblStatus = new Label();
            lblTotalPrice = new Label();
            lblPrePaid = new Label();
            lblRemaining = new Label();
            lblTitle = new Label();

            customPanelMain.SuspendLayout();
            panelHeader.SuspendLayout();
            tlInfo.SuspendLayout();
            SuspendLayout();

            // customPanelMain
            customPanelMain.BackColor = Color.FromArgb(239, 248, 230);
            customPanelMain.BorderRadius = 20;
            customPanelMain.Controls.Add(btnClose);
            customPanelMain.Controls.Add(panelHeader);
            customPanelMain.Controls.Add(lblTitle);
            customPanelMain.Dock = DockStyle.Fill;
            customPanelMain.Location = new Point(0, 0);
            customPanelMain.Name = "customPanelMain";
            customPanelMain.Size = new Size(928, 624);
            customPanelMain.TabIndex = 0;

            // btnClose
            btnClose.AutoSize = true;
            btnClose.BackColor = Color.FromArgb(180, 60, 60);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(779, 9);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(30, 12, 30, 12);
            btnClose.Size = new Size(137, 56);
            btnClose.TabIndex = 0;
            btnClose.Text = "Đóng";
            btnClose.TextAlign = ContentAlignment.MiddleCenter;
            btnClose.Click += btnClose_Click;

            // panelHeader
            panelHeader.BackColor = Color.FromArgb(0, 120, 103);
            panelHeader.Controls.Add(tlInfo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 90);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(928, 480);
            panelHeader.TabIndex = 2;

            // tlInfo - Bố cục 3 cột x 3 dòng
            tlInfo.ColumnCount = 3;
            tlInfo.RowCount = 3;
            tlInfo.Dock = DockStyle.Fill;
            tlInfo.Padding = new Padding(20);
            tlInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            for (int i = 0; i < 3; i++) tlInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));

            // Các label thông tin
            Label[] labels = { lblBillId, lblEmployee, lblCustomer, lblCourt, lblTime, lblStatus, lblTotalPrice, lblPrePaid, lblRemaining };
            string[] texts = {
                "Mã hóa đơn:\n...", "Nhân viên:\n...", "Khách hàng:\n...\nSĐT: ...",
                "Sân:\n...", "Thời gian chơi:\n... → ...", "Trạng thái:\n...",
                "TỔNG TIỀN:\n0 ₫", "Đã cọc:\n0 ₫", "Còn lại:\n0 ₫"
            };

            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label
                {
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", i >= 6 ? 16F : 12F, i >= 6 ? FontStyle.Bold : FontStyle.Regular),
                    Text = texts[i]
                };
                int row = i / 3;
                int col = i % 3;
                tlInfo.Controls.Add(labels[i], col, row);
            }

            // lblTitle
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 120, 103);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(0, 20, 0, 0);
            lblTitle.Size = new Size(928, 90);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "CHI TIẾT HÓA ĐƠN ĐẶT SÂN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Form
            this.BackColor = Color.White;
            this.ClientSize = new Size(928, 624);
            this.Controls.Add(customPanelMain);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "FormBillBookingDetail";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Chi tiết hóa đơn đặt sân";
            this.Load += FormBillBookingDetail_Load;

            customPanelMain.ResumeLayout(false);
            customPanelMain.PerformLayout();
            panelHeader.ResumeLayout(false);
            tlInfo.ResumeLayout(false);
            this.ResumeLayout(false);
        }

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