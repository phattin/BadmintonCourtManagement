namespace BadmintonCourtManagement.GUI
{
    partial class hoadonGUI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
        if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblTitle = new Label();
            customPanelHeader = new CustomPanel();
            flowLayoutSearch = new FlowLayoutPanel();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            txtSearch = new TextBox();
            cmbSort = new ComboBox();
            btnSearch = new Label();
            customPanelMain = new CustomPanel();
            dgvBills = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colCourt = new DataGridViewTextBoxColumn();
            colCustomer = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colPrePaid = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colAction = new DataGridViewTextBoxColumn();
            drPanelMain = new Panel();

            customPanelHeader.SuspendLayout();
            flowLayoutSearch.SuspendLayout();
            customPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBills).BeginInit();
            drPanelMain.SuspendLayout();
            SuspendLayout();

            // lblTitle
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(70, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(10);
            lblTitle.Size = new Size(1394, 81);
            lblTitle.Text = "Quản Lý Hóa Đơn Đặt Sân";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;

            // customPanelHeader
            customPanelHeader.BackColor = Color.FromArgb(0, 120, 103);
            customPanelHeader.BorderRadius = 20;
            customPanelHeader.Controls.Add(flowLayoutSearch);
            customPanelHeader.Dock = DockStyle.Top;
            customPanelHeader.Location = new Point(70, 81);
            customPanelHeader.Name = "customPanelHeader";
            customPanelHeader.Size = new Size(1394, 98);
            customPanelHeader.TabIndex = 1;

            // flowLayoutSearch
            flowLayoutSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutSearch.Controls.Add(dtpFrom);
            flowLayoutSearch.Controls.Add(dtpTo);
            flowLayoutSearch.Controls.Add(txtSearch);
            flowLayoutSearch.Controls.Add(cmbSort);
            flowLayoutSearch.Controls.Add(btnSearch);
            flowLayoutSearch.Location = new Point(0, 0);
            flowLayoutSearch.Padding = new Padding(0, 25, 0, 0);
            flowLayoutSearch.Size = new Size(1394, 98);

            // dtpFrom
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(20, 35);
            dtpFrom.Margin = new Padding(20, 10, 0, 0);
            dtpFrom.Size = new Size(310, 31);

            // dtpTo
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(340, 35);
            dtpTo.Margin = new Padding(10, 10, 0, 0);
            dtpTo.Size = new Size(310, 31);

            // txtSearch
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(700, 38);
            txtSearch.Margin = new Padding(50, 13, 0, 0);
            txtSearch.PlaceholderText = "Tìm mã hóa đơn, khách hàng, sân...";
            txtSearch.Size = new Size(265, 27);
            txtSearch.TextChanged += txtSearch_TextChanged;

            // cmbSort
            cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSort.Items.AddRange(new object[] { "Mới nhất trước", "Cũ nhất trước", "Tổng tiền giảm dần", "Tổng tiền tăng dần" });
            cmbSort.Location = new Point(975, 35);
            cmbSort.Margin = new Padding(10, 10, 0, 0);
            cmbSort.Size = new Size(265, 33);
            cmbSort.SelectedIndexChanged += cmbSort_SelectedIndexChanged;

            // btnSearch
            btnSearch.AutoSize = true;
            btnSearch.BackColor = Color.FromArgb(64, 64, 64);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSearch.ForeColor = Color.WhiteSmoke;
            btnSearch.Location = new Point(10, 68);
            btnSearch.Margin = new Padding(10, 0, 0, 0);
            btnSearch.Padding = new Padding(20, 8, 20, 8);
            btnSearch.Text = "Tìm Kiếm";
            btnSearch.Click += btnSearch_Click;

            // customPanelMain
            customPanelMain.BackColor = Color.FromArgb(239, 248, 230);
            customPanelMain.BorderRadius = 20;
            customPanelMain.Controls.Add(dgvBills);
            customPanelMain.Dock = DockStyle.Fill;
            customPanelMain.Location = new Point(70, 179);
            customPanelMain.Name = "customPanelMain";
            customPanelMain.Padding = new Padding(37, 20, 37, 37);
            customPanelMain.Size = new Size(1394, 720);
            customPanelMain.TabIndex = 0;

            // dgvBills
            dgvBills.AllowUserToAddRows = false;
            dgvBills.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBills.BackgroundColor = Color.White;
            dgvBills.BorderStyle = BorderStyle.None;
            dgvBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBills.Columns.AddRange(new DataGridViewColumn[] {
                colId, colDate, colCourt, colCustomer, colTotal, colPrePaid, colStatus, colAction
            });
            dgvBills.Dock = DockStyle.Fill;
            dgvBills.EnableHeadersVisualStyles = false;
            dgvBills.Location = new Point(37, 20);
            dgvBills.MultiSelect = false;
            dgvBills.Name = "dgvBills";
            dgvBills.ReadOnly = true;
            dgvBills.RowHeadersVisible = false;
            dgvBills.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBills.CellContentClick += dgvBills_CellContentClick;

            // Cột
            colId.HeaderText = "Mã Hóa Đơn"; colId.Name = "colId";
            colDate.HeaderText = "Ngày Đặt"; colDate.Name = "colDate";
            colCourt.HeaderText = "Sân"; colCourt.Name = "colCourt";
            colCustomer.HeaderText = "Khách Hàng"; colCustomer.Name = "colCustomer";
            colTotal.HeaderText = "Tổng Tiền"; colTotal.Name = "colTotal";
            colPrePaid.HeaderText = "Đã Cọc"; colPrePaid.Name = "colPrePaid";
            colStatus.HeaderText = "Trạng Thái"; colStatus.Name = "colStatus";
            colAction.HeaderText = "Hành Động"; colAction.Name = "colAction";

            // drPanelMain
            drPanelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            drPanelMain.BackColor = Color.White;
            drPanelMain.Controls.Add(customPanelMain);
            drPanelMain.Controls.Add(customPanelHeader);
            drPanelMain.Controls.Add(lblTitle);
            drPanelMain.Location = new Point(0, 0);
            drPanelMain.Name = "drPanelMain";
            drPanelMain.Padding = new Padding(70, 0, 90, 0);
            drPanelMain.Size = new Size(1554, 899);
            drPanelMain.TabIndex = 0;

            // BillBookingGUI
            this.BackColor = Color.White;
            this.Controls.Add(drPanelMain);
            this.Name = "BillBookingGUI";
            this.Size = new Size(1512, 900);

            customPanelHeader.ResumeLayout(false);
            flowLayoutSearch.ResumeLayout(false);
            flowLayoutSearch.PerformLayout();
            customPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBills).EndInit();
            drPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        // === KHAI BÁO CONTROL ===
        private Label lblTitle;
        private CustomPanel customPanelHeader;
        private FlowLayoutPanel flowLayoutSearch;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private TextBox txtSearch;
        private ComboBox cmbSort;
        private Label btnSearch;
        private CustomPanel customPanelMain;
        private DataGridView dgvBills;
        private Panel drPanelMain;

        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colCourt;
        private DataGridViewTextBoxColumn colCustomer;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colPrePaid;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colAction;
    }
}