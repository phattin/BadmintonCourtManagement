namespace BadmintonCourtManagement.GUI
{
    partial class BrandGUI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandGUI));
            lblTitle = new Label();
            customPanel1 = new CustomPanel();
            pBrandList = new TableLayoutPanel();
            customPanel2 = new CustomPanel();
            pictureBox1 = new PictureBox();
            customPanel3 = new CustomPanel();
            btnClearSearch = new PictureBox();
            txtSearch = new TextBox();
            paginationPanel = new Panel();
            btnExtraPrevious = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            btnExtraNext = new Button();
            lblAddBrand = new Label();
            lblPageInfo = new Label();
            customPanel1.SuspendLayout();
            customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClearSearch).BeginInit();
            paginationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(66, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(12, 14, 12, 14);
            lblTitle.Size = new Size(350, 73);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Quản lý thương hiệu";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customPanel1
            // 
            customPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customPanel1.BackColor = Color.FromArgb(239, 248, 230);
            customPanel1.BorderRadius = 20;
            customPanel1.Controls.Add(pBrandList);
            customPanel1.Controls.Add(customPanel2);
            customPanel1.Controls.Add(paginationPanel);
            customPanel1.Location = new Point(70, 99);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(1432, 799);
            customPanel1.TabIndex = 6;
            // 
            // pBrandList
            // 
            pBrandList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pBrandList.ColumnCount = 4;
            pBrandList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pBrandList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pBrandList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pBrandList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pBrandList.Location = new Point(54, 100);
            pBrandList.Name = "pBrandList";
            pBrandList.RowCount = 2;
            pBrandList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pBrandList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pBrandList.Size = new Size(1324, 618);
            pBrandList.TabIndex = 1;
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel2.BackColor = Color.FromArgb(0, 120, 103);
            customPanel2.BorderRadius = 20;
            // customPanel2.Controls.Add(pictureBox1);
            customPanel2.Controls.Add(customPanel3);
            customPanel2.Location = new Point(0, 0);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(1432, 91);
            customPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Location = new Point(1355, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // customPanel3
            // 
            customPanel3.BackColor = Color.White;
            customPanel3.BorderRadius = 30;
            customPanel3.Controls.Add(btnClearSearch);
            customPanel3.Controls.Add(txtSearch);
            customPanel3.Location = new Point(19, 15);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(650, 64);
            customPanel3.TabIndex = 1;
            // 
            // btnClearSearch
            // 
            btnClearSearch.Image = Properties.Resources.X;
            btnClearSearch.Location = new Point(612, 24);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(16, 16);
            btnClearSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClearSearch.TabIndex = 1;
            btnClearSearch.TabStop = false;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.None;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.Location = new Point(18, 16);
            // txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm thương hiệu";
            txtSearch.Size = new Size(588, 30);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblAddBrand
            // 
            lblAddBrand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAddBrand.AutoSize = true;
            lblAddBrand.BackColor = Color.FromArgb(64, 64, 64);
            lblAddBrand.Cursor = Cursors.Hand;
            lblAddBrand.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAddBrand.ForeColor = Color.White;
            lblAddBrand.Location = new Point(1264, 19); // TODO
            lblAddBrand.Name = "lblAddBrand";
            lblAddBrand.Padding = new Padding(12, 14, 12, 16);
            lblAddBrand.Size = new Size(261, 62);
            lblAddBrand.TabIndex = 7;
            lblAddBrand.Text = "Thêm thương hiệu";
            lblAddBrand.TextAlign = ContentAlignment.MiddleCenter;
            lblAddBrand.Click += lblAddBrand_Click;
            // 
            // paginationPanel
            // 
            paginationPanel.BackColor = Color.FromArgb(239, 248, 230);
            paginationPanel.Controls.Add(btnExtraPrevious);
            paginationPanel.Controls.Add(btnPrevious);
            paginationPanel.Controls.Add(lblPageInfo);
            paginationPanel.Controls.Add(btnNext);
            paginationPanel.Controls.Add(btnExtraNext);
            paginationPanel.Dock = DockStyle.Bottom;
            paginationPanel.Location = new Point(0, 718);
            paginationPanel.Name = "paginationPanel";
            paginationPanel.Size = new Size(1432, 81);
            paginationPanel.TabIndex = 2;
            
            // 
            // btnExtraPrevious
            // 
            btnExtraPrevious.Anchor = AnchorStyles.None;
            btnExtraPrevious.BackColor = Color.Transparent;
            btnExtraPrevious.Cursor = Cursors.Hand;
            btnExtraPrevious.FlatAppearance.BorderSize = 0;
            btnExtraPrevious.FlatStyle = FlatStyle.Flat;
            btnExtraPrevious.Location = new Point(433, 13);
            btnExtraPrevious.Size = new Size(60, 58);
            btnExtraPrevious.TabIndex = 13;
            btnExtraPrevious.UseVisualStyleBackColor = false;
            btnExtraPrevious.Click += btnExtraPrevious_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.None;
            btnPrevious.BackColor = Color.Transparent;
            btnPrevious.Cursor = Cursors.Hand;
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Location = new Point(523, 13);
            btnPrevious.Size = new Size(60, 58);
            btnPrevious.TabIndex = 14;
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.None;
            btnNext.BackColor = Color.Transparent;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Location = new Point(607, 13);
            btnNext.Size = new Size(60, 58);
            btnNext.TabIndex = 15;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnExtraNext
            // 
            btnExtraNext.Anchor = AnchorStyles.None;
            btnExtraNext.BackColor = Color.Transparent;
            btnExtraNext.Cursor = Cursors.Hand;
            btnExtraNext.FlatAppearance.BorderSize = 0;
            btnExtraNext.FlatStyle = FlatStyle.Flat;
            btnExtraNext.Location = new Point(697, 13);
            btnExtraNext.Size = new Size(60, 58);
            btnExtraNext.TabIndex = 16;
            btnExtraNext.UseVisualStyleBackColor = false;
            btnExtraNext.Click += btnExtraNext_Click;

            // 
            // lblPageInfo
            // 
            lblPageInfo.Anchor = AnchorStyles.None;
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Segoe UI", 11F);
            lblPageInfo.Location = new Point(650, 28);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(133, 25);
            lblPageInfo.TabIndex = 4;
            lblPageInfo.Text = "Trang 1/1 (0-0/0)";
            // 
            // BrandGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblTitle);
            Controls.Add(lblAddBrand);
            Controls.Add(customPanel1);
            Name = "BrandGUI";
            Size = new Size(1572, 920);
            Load += BrandGUI_Load;
            customPanel1.ResumeLayout(false);
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            customPanel3.ResumeLayout(false);
            customPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClearSearch).EndInit();
            paginationPanel.ResumeLayout(false);
            paginationPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private CustomPanel customPanel1;
        private TableLayoutPanel pBrandList;
        private CustomPanel customPanel2;
        private CustomPanel customPanel3;
        private TextBox txtSearch;
        private PictureBox btnClearSearch;
        private PictureBox pictureBox1;
        private Label lblAddBrand;
        private Panel paginationPanel;
        private Button btnExtraPrevious;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnExtraNext;
        private Label lblPageInfo;
    }
}
