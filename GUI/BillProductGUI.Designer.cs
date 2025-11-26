namespace BadmintonCourtManagement.GUI
{
    partial class BillProductGUI
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

    // === CÁC CONTROL CHÍNH ===
    lblTitle = new Label();
    customPanelHeader = new CustomPanel();
    flowLayoutSearch = new FlowLayoutPanel();
    dtpFrom = new DateTimePicker();
    dtpTo = new DateTimePicker();
    txtSearch = new TextBox();
    cmbSort = new ComboBox();
    btnSearch = new Label(); // Dùng Label làm nút đẹp

    customPanelMain = new CustomPanel();
    dgvBills = new DataGridView();

    drPanelMain = new Panel();

    customPanelHeader.SuspendLayout();
    flowLayoutSearch.SuspendLayout();
    customPanelMain.SuspendLayout();
    ((System.ComponentModel.ISupportInitialize)dgvBills).BeginInit();
    drPanelMain.SuspendLayout();
    SuspendLayout();

    // ==============================================================
    // HEADER TIÊU ĐỀ
    // ==============================================================
    lblTitle.Text = "Quản Lý Hóa Đơn Bán Hàng";
    lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
    lblTitle.ForeColor = Color.Black;
    lblTitle.Dock = DockStyle.Top;
    lblTitle.Padding = new Padding(10);
    lblTitle.Height = 84;
    lblTitle.TextAlign = ContentAlignment.MiddleLeft;

    // ==============================================================
    // PANEL TÌM KIẾM & LỌC (xanh lá)
    // ==============================================================
    customPanelHeader.BackColor = Color.FromArgb(0, 120, 103);
    customPanelHeader.BorderRadius = 20;
    customPanelHeader.Dock = DockStyle.Top;
    customPanelHeader.Height = 98;
    customPanelHeader.Controls.Add(flowLayoutSearch);

    flowLayoutSearch.Dock = DockStyle.Fill;
    flowLayoutSearch.Padding = new Padding(0, 25, 0, 0);
    flowLayoutSearch.FlowDirection = FlowDirection.LeftToRight;

    // Từ ngày
    dtpFrom.Format = DateTimePickerFormat.Short;
    dtpFrom.Size = new Size(310, 31);
    dtpFrom.Margin = new Padding(35, 10, 30, 0);
    flowLayoutSearch.Controls.Add(dtpFrom);

    // Đến ngày
    dtpTo.Format = DateTimePickerFormat.Short;
    dtpTo.Size = new Size(310, 31);
    dtpTo.Margin = new Padding(10, 10, 0, 0);
    flowLayoutSearch.Controls.Add(dtpTo);

    // Ô tìm kiếm
    txtSearch.BorderStyle = BorderStyle.None;
    txtSearch.Font = new Font("Segoe UI", 10F);
    txtSearch.ForeColor = Color.Black;
    txtSearch.Size = new Size(265, 30);
    txtSearch.Margin = new Padding(130, 10, 0, 0);
    txtSearch.PlaceholderText = "Tìm mã hóa đơn, nhân viên...";
    txtSearch.TextChanged += txtSearch_TextChanged;
    flowLayoutSearch.Controls.Add(txtSearch);

    // ComboBox sắp xếp
    cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
    cmbSort.FormattingEnabled = true;
    cmbSort.Items.AddRange(new object[] {
        "Mới nhất trước",
        "Cũ nhất trước",
        "Tổng tiền giảm dần",
        "Tổng tiền tăng dần"
    });
    cmbSort.SelectedIndex = 0;
    cmbSort.Size = new Size(265, 33);
    cmbSort.Margin = new Padding(30, 10, 0, 0);
    flowLayoutSearch.Controls.Add(cmbSort);

    // Nút "Tìm Kiếm"
    btnSearch.Text = "Tìm Kiếm";
    btnSearch.BackColor = Color.FromArgb(64, 64, 64);
    btnSearch.ForeColor = Color.WhiteSmoke;
    btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
    btnSearch.Cursor = Cursors.Hand;
    btnSearch.TextAlign = ContentAlignment.MiddleCenter;
    btnSearch.Padding = new Padding(20, 8, 20, 8);
    btnSearch.Margin = new Padding(30, 10, 35, 10);
    btnSearch.AutoSize = true;
    btnSearch.Click += btnSearch_Click;
    flowLayoutSearch.Controls.Add(btnSearch);

    // ==============================================================
    // PANEL CHỨA DATAGRIDVIEW
    // ==============================================================
    customPanelMain.BackColor = Color.FromArgb(239, 248, 230);
    customPanelMain.BorderRadius = 20;
    customPanelMain.Dock = DockStyle.Fill;
    customPanelMain.Padding = new Padding(37, 20, 37, 37);
    customPanelMain.Controls.Add(dgvBills);

    // ==== Pagination placeholder panel and buttons (basic setup) ====
    paginationPanel = new Panel();
    paginationPanel.Height = 60;
    paginationPanel.Dock = DockStyle.Bottom;
    paginationPanel.Padding = new Padding(0, 10, 0, 10);
    paginationPanel.BackColor = Color.Transparent;

    btnExtraPrevious = new Button();
    btnPrevious = new Button();
    btnNext = new Button();
    btnExtraNext = new Button();
    lblPageInfo = new Label();

    btnExtraPrevious.Size = new Size(50, 30);
    btnPrevious.Size = new Size(50, 30);
    btnNext.Size = new Size(50, 30);
    btnExtraNext.Size = new Size(50, 30);

    btnExtraPrevious.Text = "«";
    btnPrevious.Text = "‹";
    btnNext.Text = "›";
    btnExtraNext.Text = "»";

    btnExtraPrevious.FlatStyle = FlatStyle.Flat;
    btnPrevious.FlatStyle = FlatStyle.Flat;
    btnNext.FlatStyle = FlatStyle.Flat;
    btnExtraNext.FlatStyle = FlatStyle.Flat;

    btnExtraPrevious.Click += btnExtraPrevious_Click;
    btnPrevious.Click += btnPrevious_Click;
    btnNext.Click += btnNext_Click;
    btnExtraNext.Click += btnExtraNext_Click;

    lblPageInfo.AutoSize = true;
    lblPageInfo.Text = "";

    // Add buttons to pagination panel (positions handled at runtime)
    paginationPanel.Controls.Add(btnExtraPrevious);
    paginationPanel.Controls.Add(btnPrevious);
    paginationPanel.Controls.Add(lblPageInfo);
    paginationPanel.Controls.Add(btnNext);
    paginationPanel.Controls.Add(btnExtraNext);

    customPanelMain.Controls.Add(paginationPanel);

    dgvBills.Dock = DockStyle.Fill;
    dgvBills.BackgroundColor = Color.White;
    dgvBills.BorderStyle = BorderStyle.None;
    dgvBills.AllowUserToAddRows = false;
    dgvBills.ReadOnly = true;
    dgvBills.RowHeadersVisible = false;
    dgvBills.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    dgvBills.MultiSelect = false;
    dgvBills.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    dgvBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    dgvBills.EnableHeadersVisualStyles = false;
    dgvBills.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 103);
    dgvBills.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
    dgvBills.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

    // Cột mẫu (sẽ được tạo động trong code)
    dgvBills.Columns.Add("BillId", "Mã Hóa Đơn");
    dgvBills.Columns.Add("Date", "Ngày Tạo");
    dgvBills.Columns.Add("Staff", "Nhân Viên");
    dgvBills.Columns.Add("Total", "Tổng Tiền");
    dgvBills.Columns.Add("Action", "Hành Động");

    // ==============================================================
    // LAYOUT CHÍNH
    // ==============================================================
    drPanelMain.Dock = DockStyle.Fill;
    drPanelMain.BackColor = Color.White;
    drPanelMain.Controls.Add(customPanelMain);
    drPanelMain.Controls.Add(customPanelHeader);
    drPanelMain.Controls.Add(lblTitle);

    this.Controls.Add(drPanelMain);
    this.BackColor = Color.White;
    this.Size = new Size(1512, 900);

    customPanelHeader.ResumeLayout(false);
    flowLayoutSearch.ResumeLayout(false);
    flowLayoutSearch.PerformLayout();
    customPanelMain.ResumeLayout(false);
    ((System.ComponentModel.ISupportInitialize)dgvBills).EndInit();
    drPanelMain.ResumeLayout(false);
    ResumeLayout(false);
}

// === KHAI BÁO CÁC CONTROL ===
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
private Panel paginationPanel;
private Button btnExtraPrevious;
private Button btnPrevious;
private Button btnNext;
private Button btnExtraNext;
private Label lblPageInfo;
    }
}