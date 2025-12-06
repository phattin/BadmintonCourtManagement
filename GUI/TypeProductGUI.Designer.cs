namespace BadmintonCourtManagement.GUI
{
    partial class TypeProductGUI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(storageGUI));
            lblTitle = new Label();
            customPanel1 = new CustomPanel();
            customPanel2 = new CustomPanel();
            customPanel3 = new CustomPanel();
            btnClearSearch = new PictureBox();
            txtSearch = new TextBox();
            paginationPanel = new Panel();
            btnExtraPrevious = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            btnExtraNext = new Button();
            drPanel = new Panel();
            lblAddTypeProduct = new Label();
            pTypeProductList = new TableLayoutPanel();
            customPanel1.SuspendLayout();
            customPanel2.SuspendLayout();
            customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClearSearch).BeginInit();
            paginationPanel.SuspendLayout();
            drPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblTitle.Location = new Point(66, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(12, 14, 12, 14);
            lblTitle.Size = new Size(376, 73);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Quản lý loại sản phẩm";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customPanel1
            // 
            customPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customPanel1.BackColor = Color.FromArgb(239, 248, 230);
            customPanel1.BorderRadius = 20;
            customPanel1.Controls.Add(pTypeProductList);
            customPanel1.Controls.Add(customPanel2);
            customPanel1.Controls.Add(paginationPanel);
            customPanel1.Location = new Point(70, 99);
            customPanel1.Margin = new Padding(4, 5, 4, 5);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(1432, 799);
            customPanel1.TabIndex = 6;
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel2.BackColor = Color.FromArgb(0, 120, 103);
            customPanel2.BorderRadius = 20;
            customPanel2.Controls.Add(customPanel3);
            customPanel2.Location = new Point(0, 0);
            customPanel2.Margin = new Padding(4, 5, 4, 5);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(1432, 91);
            customPanel2.TabIndex = 1;
            // 
            // customPanel3
            // 
            customPanel3.BackColor = Color.White;
            customPanel3.BorderRadius = 30;
            customPanel3.Controls.Add(btnClearSearch);
            customPanel3.Controls.Add(txtSearch);
            customPanel3.Location = new Point(19, 15);
            customPanel3.Margin = new Padding(4, 4, 4, 4);
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
            btnClearSearch.Margin = new Padding(4, 4, 4, 4);
            btnClearSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClearSearch.TabIndex = 0;
            btnClearSearch.TabStop = false;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.Location = new Point(18, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Margin = new Padding(4, 4, 4, 4);
            txtSearch.Multiline = true;
            txtSearch.PlaceholderText = "Tìm kiếm loại sản phẩm";
            txtSearch.Size = new Size(588, 30);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
           // 
            // paginationPanel
            // 
            this.paginationPanel = new Panel();
            this.btnExtraPrevious = new Button();
            this.btnPrevious = new Button();
            this.btnNext = new Button();
            this.btnExtraNext = new Button();
            // this.lblPageInfo = new Label();

            this.paginationPanel.Dock = DockStyle.Bottom;
            this.paginationPanel.Height = 81;
            this.paginationPanel.BackColor = Color.FromArgb(239, 248, 230);
            this.paginationPanel.Controls.Add(this.btnExtraPrevious);
            this.paginationPanel.Controls.Add(this.btnPrevious);
            // this.paginationPanel.Controls.Add(this.lblPageInfo);
            this.paginationPanel.Controls.Add(this.btnNext);
            this.paginationPanel.Controls.Add(this.btnExtraNext);

            // Nút << (Trang đầu)
            this.btnExtraPrevious.Anchor = AnchorStyles.None;
            this.btnExtraPrevious.BackColor = Color.Transparent;
            this.btnExtraPrevious.Cursor = Cursors.Hand;
            this.btnExtraPrevious.FlatAppearance.BorderSize = 0;
            this.btnExtraPrevious.FlatStyle = FlatStyle.Flat;
            this.btnExtraPrevious.Image = (Image)resources.GetObject("extraPreviousButton.Image");
            this.btnExtraPrevious.Location = new Point(433, 13);
            this.btnExtraPrevious.Size = new Size(60, 58);
            this.btnExtraPrevious.TabIndex = 13;
            this.btnExtraPrevious.UseVisualStyleBackColor = false;
            this.btnExtraPrevious.Click += btnExtraPrevious_Click;

            // Nút < (Trang trước)
            this.btnPrevious.Anchor = AnchorStyles.None;
            this.btnPrevious.BackColor = Color.Transparent;
            this.btnPrevious.Cursor = Cursors.Hand;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = FlatStyle.Flat;
            this.btnPrevious.Image = (Image)resources.GetObject("previousButton.Image");
            this.btnPrevious.Location = new Point(523, 13);
            this.btnPrevious.Size = new Size(60, 58);
            this.btnPrevious.TabIndex = 14;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += btnPrevious_Click;
            
            // Nút > (Trang sau)
            this.btnNext.Anchor = AnchorStyles.None;
            this.btnNext.BackColor = Color.Transparent;
            this.btnNext.Cursor = Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = FlatStyle.Flat;
            this.btnNext.Image = (Image)resources.GetObject("nextButton.Image");
            this.btnNext.Location = new Point(607, 13);
            this.btnNext.Size = new Size(60, 58);
            this.btnNext.TabIndex = 15;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += btnNext_Click;

            // Nút >> (Trang cuối)
            this.btnExtraNext.Anchor = AnchorStyles.None;
            this.btnExtraNext.BackColor = Color.Transparent;
            this.btnExtraNext.Cursor = Cursors.Hand;
            this.btnExtraNext.FlatAppearance.BorderSize = 0;
            this.btnExtraNext.FlatStyle = FlatStyle.Flat;
            this.btnExtraNext.Image = (Image)resources.GetObject("extraNextButton.Image");
            this.btnExtraNext.Location = new Point(697, 13);
            this.btnExtraNext.Size = new Size(60, 58);
            this.btnExtraNext.TabIndex = 16;
            this.btnExtraNext.UseVisualStyleBackColor = false;
            this.btnExtraNext.Click += btnExtraNext_Click;
            // 
            // drPanel
            // 
            drPanel.BackColor = Color.White;
            drPanel.Controls.Add(lblAddTypeProduct);
            drPanel.Controls.Add(customPanel1);
            drPanel.Controls.Add(lblTitle);
            drPanel.Dock = DockStyle.Fill;
            drPanel.Location = new Point(0, 0);
            drPanel.Name = "drPanel";
            drPanel.Size = new Size(1554, 958);
            drPanel.TabIndex = 0;
            // 
            // lblAddTypeProduct
            // 
            lblAddTypeProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAddTypeProduct.BackColor = Color.FromArgb(64, 64, 64);
            lblAddTypeProduct.Cursor = Cursors.Hand;
            lblAddTypeProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAddTypeProduct.ForeColor = Color.White;
            lblAddTypeProduct.Location = new Point(1264, 19);
            lblAddTypeProduct.Name = "lblAddTypeProduct";
            lblAddTypeProduct.Padding = new Padding(12, 14, 12, 16);
            lblAddTypeProduct.Size = new Size(238, 62);
            lblAddTypeProduct.TabIndex = 0;
            lblAddTypeProduct.Text = "Thêm loại sản phẩm";
            lblAddTypeProduct.TextAlign = ContentAlignment.MiddleCenter;
            lblAddTypeProduct.Click += lblAddTypeProduct_Click;
            // 
            // pTypeProductList
            // 
            pTypeProductList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pTypeProductList.ColumnCount = 4;
            pTypeProductList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pTypeProductList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pTypeProductList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pTypeProductList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pTypeProductList.Location = new Point(54, 124);
            pTypeProductList.Name = "pTypeProductList";
            pTypeProductList.RowCount = 2;
            pTypeProductList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pTypeProductList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pTypeProductList.Size = new Size(1324, 600);
            pTypeProductList.TabIndex = 0;
            // 
            // TypeProductGUI
            // 
            BackColor = Color.White;
            Controls.Add(drPanel);
            Name = "TypeProductGUI";
            Size = new Size(1554, 958);
            this.customPanel1.Controls.Add(this.paginationPanel);
            customPanel1.ResumeLayout(false);
            customPanel2.ResumeLayout(false);
            customPanel3.ResumeLayout(false);
            customPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClearSearch).EndInit();
            paginationPanel.ResumeLayout(false);
            drPanel.ResumeLayout(false);
            drPanel.PerformLayout();
            ResumeLayout(false);
        }

        private Label lblTitle;
        private CustomPanel customPanel1;
        private CustomPanel customPanel2;
        private CustomPanel customPanel3;
        private TextBox txtSearch;
        private PictureBox btnClearSearch;
        private Panel drPanel;
        private Label lblAddTypeProduct;

        private Panel paginationPanel;
        private Button btnExtraPrevious;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnExtraNext;
        private TableLayoutPanel pTypeProductList;
    }
}