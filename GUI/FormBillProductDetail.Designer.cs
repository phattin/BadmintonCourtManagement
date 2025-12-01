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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            customPanelMain = new CustomPanel();
            print = new Label();
            btnClose = new Label();
            dgvDetails = new DataGridView();
            colSTT = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            panelHeader = new Panel();
            tlInfo = new TableLayoutPanel();
            lblBillId = new Label();
            lblEmployee = new Label();
            lblTotalPrice = new Label();
            lblDate = new Label();
            lblTitle = new Label();
            customPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).BeginInit();
            panelHeader.SuspendLayout();
            tlInfo.SuspendLayout();
            SuspendLayout();
            // 
            // customPanelMain
            // 
            customPanelMain.BackColor = Color.FromArgb(239, 248, 230);
            customPanelMain.BorderRadius = 20;
            customPanelMain.Controls.Add(print);
            customPanelMain.Controls.Add(btnClose);
            customPanelMain.Controls.Add(dgvDetails);
            customPanelMain.Controls.Add(panelHeader);
            customPanelMain.Controls.Add(lblTitle);
            customPanelMain.Dock = DockStyle.Fill;
            customPanelMain.Location = new Point(0, 0);
            customPanelMain.Name = "customPanelMain";
            customPanelMain.Size = new Size(928, 624);
            customPanelMain.TabIndex = 0;
            // 
            // print
            // 
            print.AutoSize = true;
            print.BackColor = Color.LimeGreen;
            print.Cursor = Cursors.Hand;
            print.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            print.ForeColor = Color.White;
            print.Location = new Point(12, 9);
            print.Name = "print";
            print.Padding = new Padding(30, 12, 30, 12);
            print.Size = new Size(130, 56);
            print.TabIndex = 4;
            print.Text = "Print";
            print.TextAlign = ContentAlignment.MiddleCenter;
            print.Click += print_Click;
            // 
            // btnClose
            // 
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
            // 
            // dgvDetails
            // 
            dgvDetails.AllowUserToAddRows = false;
            dgvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetails.BackgroundColor = Color.White;
            dgvDetails.BorderStyle = BorderStyle.None;
            dgvDetails.ColumnHeadersHeight = 50;
            dgvDetails.Columns.AddRange(new DataGridViewColumn[] { colSTT, colProductName, colQuantity, colPrice, colTotal });
            dgvDetails.Dock = DockStyle.Fill;
            dgvDetails.Location = new Point(0, 230);
            dgvDetails.Margin = new Padding(30, 20, 30, 100);
            dgvDetails.Name = "dgvDetails";
            dgvDetails.ReadOnly = true;
            dgvDetails.RowHeadersVisible = false;
            dgvDetails.RowHeadersWidth = 62;
            dgvDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetails.Size = new Size(928, 394);
            dgvDetails.TabIndex = 1;
            // 
            // colSTT
            // 
            colSTT.HeaderText = "STT";
            colSTT.MinimumWidth = 8;
            colSTT.Name = "colSTT";
            colSTT.ReadOnly = true;
            // 
            // colProductName
            // 
            colProductName.HeaderText = "Tên sản phẩm";
            colProductName.MinimumWidth = 8;
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "SL";
            colQuantity.MinimumWidth = 8;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // colPrice
            // 
            dataGridViewCellStyle3.Format = "N0";
            colPrice.DefaultCellStyle = dataGridViewCellStyle3;
            colPrice.HeaderText = "Đơn giá";
            colPrice.MinimumWidth = 8;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colTotal
            // 
            dataGridViewCellStyle4.Format = "N0";
            colTotal.DefaultCellStyle = dataGridViewCellStyle4;
            colTotal.HeaderText = "Thành tiền";
            colTotal.MinimumWidth = 8;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 120, 103);
            panelHeader.Controls.Add(tlInfo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 90);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(928, 140);
            panelHeader.TabIndex = 2;
            // 
            // tlInfo
            // 
            tlInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 187F));
            tlInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 184F));
            tlInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 187F));
            tlInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 183F));
            tlInfo.Controls.Add(lblBillId, 0, 0);
            tlInfo.Controls.Add(lblEmployee, 1, 0);
            tlInfo.Controls.Add(lblTotalPrice, 3, 0);
            tlInfo.Controls.Add(lblDate, 2, 0);
            tlInfo.Dock = DockStyle.Fill;
            tlInfo.Location = new Point(0, 0);
            tlInfo.Name = "tlInfo";
            tlInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlInfo.Size = new Size(928, 140);
            tlInfo.TabIndex = 0;
            // 
            // lblBillId
            // 
            lblBillId.Location = new Point(3, 0);
            lblBillId.Name = "lblBillId";
            lblBillId.Size = new Size(181, 140);
            lblBillId.TabIndex = 0;
            lblBillId.Text = "Mã hóa đơn:\n...";
            lblBillId.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblEmployee
            // 
            lblEmployee.Location = new Point(190, 0);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(178, 140);
            lblEmployee.TabIndex = 1;
            lblEmployee.Text = "Nhân viên:\n...";
            lblEmployee.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotalPrice.Location = new Point(561, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(364, 140);
            lblTotalPrice.TabIndex = 3;
            lblTotalPrice.Text = "TỔNG TIỀN:\n0 ₫";
            lblTotalPrice.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDate
            // 
            lblDate.Location = new Point(374, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(181, 140);
            lblDate.TabIndex = 2;
            lblDate.Text = "Ngày lập:\n...";
            lblDate.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 120, 103);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(0, 20, 0, 0);
            lblTitle.Size = new Size(928, 90);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "CHI TIẾT HÓA ĐƠN BÁN HÀNG";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormBillProductDetail
            // 
            BackColor = Color.White;
            ClientSize = new Size(928, 624);
            Controls.Add(customPanelMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBillProductDetail";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chi tiết hóa đơn bán hàng";
            Load += FormBillProductDetail_Load;
            customPanelMain.ResumeLayout(false);
            customPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).EndInit();
            panelHeader.ResumeLayout(false);
            tlInfo.ResumeLayout(false);
            ResumeLayout(false);
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
        private TableLayoutPanel tlInfo;
        private Label print;
    }
}