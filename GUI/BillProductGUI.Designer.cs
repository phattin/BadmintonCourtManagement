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
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            drPanelMain = new Panel();
            customPanelHeader.SuspendLayout();
            flowLayoutSearch.SuspendLayout();
            customPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBills).BeginInit();
            drPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(70, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(10);
            lblTitle.Size = new Size(1394, 81);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Quản Lý Hóa Đơn Bán Hàng";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // customPanelHeader
            // 
            customPanelHeader.BackColor = Color.FromArgb(0, 120, 103);
            customPanelHeader.BorderRadius = 20;
            customPanelHeader.Controls.Add(flowLayoutSearch);
            customPanelHeader.Dock = DockStyle.Top;
            customPanelHeader.Location = new Point(70, 81);
            customPanelHeader.Name = "customPanelHeader";
            customPanelHeader.Size = new Size(1394, 98);
            customPanelHeader.TabIndex = 1;
            // 
            // flowLayoutSearch
            // 
            flowLayoutSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutSearch.Controls.Add(dtpFrom);
            flowLayoutSearch.Controls.Add(dtpTo);
            flowLayoutSearch.Controls.Add(txtSearch);
            flowLayoutSearch.Controls.Add(cmbSort);
            flowLayoutSearch.Controls.Add(btnSearch);
            flowLayoutSearch.Location = new Point(0, 0);
            flowLayoutSearch.Name = "flowLayoutSearch";
            flowLayoutSearch.Padding = new Padding(0, 25, 0, 0);
            flowLayoutSearch.Size = new Size(1394, 98);
            flowLayoutSearch.TabIndex = 0;
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(35, 35);
            dtpFrom.Margin = new Padding(35, 10, 30, 0);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(310, 31);
            dtpFrom.TabIndex = 0;
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(385, 35);
            dtpTo.Margin = new Padding(10, 10, 0, 0);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(310, 31);
            dtpTo.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(745, 35);
            txtSearch.Margin = new Padding(50, 10, 0, 0);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm mã hóa đơn, nhân viên...";
            txtSearch.Size = new Size(265, 27);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbSort
            // 
            cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSort.FormattingEnabled = true;
            cmbSort.Items.AddRange(new object[] { "Mới nhất trước", "Cũ nhất trước", "Tổng tiền giảm dần", "Tổng tiền tăng dần" });
            cmbSort.Location = new Point(1020, 35);
            cmbSort.Margin = new Padding(10, 10, 0, 0);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(265, 33);
            cmbSort.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.BackColor = Color.FromArgb(64, 64, 64);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSearch.ForeColor = Color.WhiteSmoke;
            btnSearch.Location = new Point(30, 68);
            btnSearch.Margin = new Padding(30, 0, 0, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new Padding(20, 8, 20, 8);
            btnSearch.Size = new Size(162, 48);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm Kiếm";
            btnSearch.TextAlign = ContentAlignment.MiddleCenter;
            btnSearch.Click += btnSearch_Click;
            // 
            // customPanelMain
            // 
            customPanelMain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanelMain.BackColor = Color.FromArgb(239, 248, 230);
            customPanelMain.BorderRadius = 20;
            customPanelMain.Controls.Add(dgvBills);
            customPanelMain.Location = new Point(70, 175);
            customPanelMain.Name = "customPanelMain";
            customPanelMain.Padding = new Padding(37, 20, 37, 37);
            customPanelMain.Size = new Size(1394, 706);
            customPanelMain.TabIndex = 0;
            // 
            // dgvBills
            // 
            dgvBills.AllowUserToAddRows = false;
            dgvBills.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvBills.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBills.BackgroundColor = Color.White;
            dgvBills.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 120, 103);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBills.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgvBills.EnableHeadersVisualStyles = false;
            dgvBills.Location = new Point(37, 20);
            dgvBills.MultiSelect = false;
            dgvBills.Name = "dgvBills";
            dgvBills.ReadOnly = true;
            dgvBills.RightToLeft = RightToLeft.No;
            dgvBills.RowHeadersVisible = false;
            dgvBills.RowHeadersWidth = 100;
            dgvBills.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBills.Size = new Size(1320, 661);
            dgvBills.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Mã Hóa Đơn";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Ngày Tạo";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Nhân Viên";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Tổng Tiền";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Hành Động";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // drPanelMain
            // 
            drPanelMain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            drPanelMain.BackColor = Color.White;
            drPanelMain.Controls.Add(customPanelMain);
            drPanelMain.Controls.Add(customPanelHeader);
            drPanelMain.Controls.Add(lblTitle);
            drPanelMain.Location = new Point(0, 0);
            drPanelMain.Name = "drPanelMain";
            drPanelMain.Padding = new Padding(70, 0, 90, 0);
            drPanelMain.Size = new Size(1554, 899);
            drPanelMain.TabIndex = 0;
            // 
            // BillProductGUI
            // 
            BackColor = Color.White;
            Controls.Add(drPanelMain);
            Name = "BillProductGUI";
            Size = new Size(1512, 900);
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}