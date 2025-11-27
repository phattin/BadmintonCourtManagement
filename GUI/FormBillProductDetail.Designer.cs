namespace BadmintonCourtManagement.GUI
{
    partial class FormBillProductDetail
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.customPanelMain = new CustomPanel();
            this.lblTitle = new Label();
            this.panelHeader = new Panel();
            this.lblBillId = new Label();
            this.lblEmployee = new Label();
            this.lblDate = new Label();
            this.lblTotalPrice = new Label();
            this.dgvDetails = new DataGridView();
            this.colSTT = new DataGridViewTextBoxColumn();
            this.colProductName = new DataGridViewTextBoxColumn();
            this.colQuantity = new DataGridViewTextBoxColumn();
            this.colPrice = new DataGridViewTextBoxColumn();
            this.colTotal = new DataGridViewTextBoxColumn();
            this.btnClose = new Label();

            this.customPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();

            // Form
            this.Text = "Chi tiết hóa đơn bán hàng";
            this.Size = new Size(950, 680);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.White;
            this.Load += FormBillProductDetail_Load;

            // customPanelMain
            this.customPanelMain.Dock = DockStyle.Fill;
            this.customPanelMain.BackColor = Color.FromArgb(239, 248, 230);
            this.customPanelMain.BorderRadius = 20;
            this.customPanelMain.Controls.Add(this.btnClose);
            this.customPanelMain.Controls.Add(this.dgvDetails);
            this.customPanelMain.Controls.Add(this.panelHeader);
            this.customPanelMain.Controls.Add(this.lblTitle);
            this.Controls.Add(this.customPanelMain);

            // Tiêu đề
            this.lblTitle.Text = "CHI TIẾT HÓA ĐƠN BÁN HÀNG";
            this.lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(0, 120, 103);
            this.lblTitle.Dock = DockStyle.Top;
            this.lblTitle.Height = 90;
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitle.Padding = new Padding(0, 20, 0, 0);

            // Header hóa đơn
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 140;
            this.panelHeader.BackColor = Color.FromArgb(0, 120, 103);
            this.panelHeader.Paint += (s, e) =>
            {
                var g = e.Graphics;
                string text = "HÓA ĐƠN BÁN HÀNG";
                var font = new Font("Segoe UI", 24F, FontStyle.Bold);
                var size = g.MeasureString(text, font);
                g.DrawString(text, font, Brushes.White, 
                    new PointF((panelHeader.Width - size.Width) / 2, 20));
            };

            var tlInfo = new TableLayoutPanel
            {
                Dock = DockStyle.Bottom,
                Height = 80,
                ColumnCount = 4,
                Padding = new Padding(30, 10, 30, 10)
            };
            for (int i = 0; i < 4; i++) tlInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

            lblBillId.Text = "Mã hóa đơn:\n...";
            lblEmployee.Text = "Nhân viên:\n...";
            lblDate.Text = "Ngày lập:\n...";
            lblTotalPrice.Text = "TỔNG TIỀN:\n0 ₫";
            lblTotalPrice.Font = new Font("Segoe UI", 16F, FontStyle.Bold);

            tlInfo.Controls.Add(lblBillId, 0, 0);
            tlInfo.Controls.Add(lblEmployee, 1, 0);
            tlInfo.Controls.Add(lblDate, 2, 0);
            tlInfo.Controls.Add(lblTotalPrice, 3, 0);
            panelHeader.Controls.Add(tlInfo);

            // DataGridView
            this.dgvDetails.Dock = DockStyle.Fill;
            this.dgvDetails.BackgroundColor = Color.White;
            this.dgvDetails.BorderStyle = BorderStyle.None;
            this.dgvDetails.RowHeadersVisible = false;
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.ColumnHeadersHeight = 50;
            this.dgvDetails.Margin = new Padding(30, 20, 30, 100);

            this.dgvDetails.Columns.AddRange(new DataGridViewColumn[] {
                colSTT, colProductName, colQuantity, colPrice, colTotal
            });

            colSTT.HeaderText = "STT"; colSTT.Width = 60;
            colProductName.HeaderText = "Tên sản phẩm";
            colQuantity.HeaderText = "SL"; colQuantity.Width = 80;
            colPrice.HeaderText = "Đơn giá"; colPrice.DefaultCellStyle.Format = "N0";
            colTotal.HeaderText = "Thành tiền"; colTotal.DefaultCellStyle.Format = "N0";

            // Nút Đóng (đỏ nổi bật)
            btnClose.Text = "Đóng";
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.BackColor = Color.FromArgb(180, 60, 60);
            btnClose.TextAlign = ContentAlignment.MiddleCenter;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Padding = new Padding(30, 12, 30, 12);
            btnClose.AutoSize = true;
            btnClose.MouseClick += (s, e) => btnClose_Click(s, EventArgs.Empty);

            // Tự động căn góc dưới bên phải
            this.Resize += (s, e) =>
            {
                btnClose.Location = new Point(this.ClientSize.Width - btnClose.Width - 40, this.ClientSize.Height - 90);
            };
            btnClose.Location = new Point(this.ClientSize.Width - btnClose.Width - 40, this.ClientSize.Height - 90);

            this.customPanelMain.ResumeLayout(false);
            this.customPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
        }

        private CustomPanel customPanelMain;
        private Label lblTitle;
        private Panel panelHeader;
        private Label lblBillId;
        private Label lblEmployee;
        private Label lblDate;
        private Label lblTotalPrice;
        private DataGridView dgvDetails;
        private DataGridViewTextBoxColumn colSTT;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colTotal;
        private Label btnClose;
    }
}