namespace BadmintonCourtManagement.GUI
{
    partial class SupplierGUI
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierGUI));
            lblTitle = new Label();
            customPanel1 = new CustomPanel();
            pCustomerList = new TableLayoutPanel();
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
            drPanelCustomer = new Panel();
            lblAddSupplier = new Label();
            lblPageInfo = new Label();
            customPanel1.SuspendLayout();
            customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClearSearch).BeginInit();
            paginationPanel.SuspendLayout();
            drPanelCustomer.SuspendLayout();
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
            lblTitle.Size = new Size(368, 73);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Quản lý nhà cung cấp";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customPanel1
            // 
            customPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customPanel1.BackColor = Color.FromArgb(239, 248, 230);
            customPanel1.BorderRadius = 20;
            customPanel1.Controls.Add(pCustomerList);
            customPanel1.Controls.Add(customPanel2);
            customPanel1.Controls.Add(paginationPanel);
            customPanel1.Location = new Point(70, 99);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(1432, 799);
            customPanel1.TabIndex = 6;
            // 
            // pCustomerList
            // 
            pCustomerList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pCustomerList.ColumnCount = 4;
            pCustomerList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCustomerList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCustomerList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCustomerList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCustomerList.Location = new Point(54, 100);
            pCustomerList.Name = "pCustomerList";
            pCustomerList.RowCount = 2;
            pCustomerList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pCustomerList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pCustomerList.Size = new Size(1324, 618);
            pCustomerList.TabIndex = 1;
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel2.BackColor = Color.FromArgb(0, 120, 103);
            customPanel2.BorderRadius = 20;
            customPanel2.Controls.Add(pictureBox1);
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
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.Location = new Point(18, 16);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm nhà cung cấp";
            txtSearch.Size = new Size(588, 30);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // paginationPanel
            // 
            paginationPanel.BackColor = Color.FromArgb(239, 248, 230);
            paginationPanel.Controls.Add(btnExtraPrevious);
            paginationPanel.Controls.Add(btnPrevious);
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
            btnExtraPrevious.Image = (Image)resources.GetObject("extraPreviousButton.Image");
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
            btnPrevious.Image = (Image)resources.GetObject("previousButton.Image");
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
            btnNext.Image = (Image)resources.GetObject("nextButton.Image");
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
            btnExtraNext.Image = (Image)resources.GetObject("extraNextButton.Image");
            btnExtraNext.Location = new Point(697, 13);
            btnExtraNext.Size = new Size(60, 58);
            btnExtraNext.TabIndex = 16;
            btnExtraNext.UseVisualStyleBackColor = false;
            btnExtraNext.Click += btnExtraNext_Click;

            // Try to load pagination images from this form's resources; if missing, fall back to other forms that include them.
            System.Drawing.Image _img = null;
            try { _img = (System.Drawing.Image)resources.GetObject("extraPreviousButton.Image"); } catch { _img = null; }
            if (_img == null)
            {
                try { _img = (System.Drawing.Image)(new System.ComponentModel.ComponentResourceManager(typeof(ProductGUI)).GetObject("extraPreviousButton.Image")); } catch { _img = null; }
            }
            if (_img != null) btnExtraPrevious.Image = _img;

            try { _img = (System.Drawing.Image)resources.GetObject("previousButton.Image"); } catch { _img = null; }
            if (_img == null)
            {
                try { _img = (System.Drawing.Image)(new System.ComponentModel.ComponentResourceManager(typeof(ProductGUI)).GetObject("previousButton.Image")); } catch { _img = null; }
            }
            if (_img != null) btnPrevious.Image = _img;

            try { _img = (System.Drawing.Image)resources.GetObject("nextButton.Image"); } catch { _img = null; }
            if (_img == null)
            {
                try { _img = (System.Drawing.Image)(new System.ComponentModel.ComponentResourceManager(typeof(ProductGUI)).GetObject("nextButton.Image")); } catch { _img = null; }
            }
            if (_img != null) btnNext.Image = _img;

            try { _img = (System.Drawing.Image)resources.GetObject("extraNextButton.Image"); } catch { _img = null; }
            if (_img == null)
            {
                try { _img = (System.Drawing.Image)(new System.ComponentModel.ComponentResourceManager(typeof(ProductGUI)).GetObject("extraNextButton.Image")); } catch { _img = null; }
            }
            if (_img != null) btnExtraNext.Image = _img;
            // 
            // drPanelCustomer
            // 
            drPanelCustomer.BackColor = Color.White;
            drPanelCustomer.Controls.Add(lblAddSupplier);
            drPanelCustomer.Controls.Add(customPanel1);
            drPanelCustomer.Controls.Add(lblTitle);
            drPanelCustomer.Dock = DockStyle.Fill;
            drPanelCustomer.Location = new Point(0, 0);
            drPanelCustomer.Name = "drPanelCustomer";
            drPanelCustomer.Size = new Size(1554, 958);
            drPanelCustomer.TabIndex = 0;
            // 
            // lblAddSupplier
            // 
            lblAddSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAddSupplier.AutoSize = true;
            lblAddSupplier.BackColor = Color.FromArgb(64, 64, 64);
            lblAddSupplier.Cursor = Cursors.Hand;
            lblAddSupplier.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAddSupplier.ForeColor = Color.White;
            lblAddSupplier.Location = new Point(1264, 19);
            lblAddSupplier.Name = "lblAddSupplier";
            lblAddSupplier.Padding = new Padding(12, 14, 12, 16);
            lblAddSupplier.Size = new Size(261, 62);
            lblAddSupplier.TabIndex = 7;
            lblAddSupplier.Text = "Thêm nhà cung cấp";
            lblAddSupplier.TextAlign = ContentAlignment.MiddleCenter;
            lblAddSupplier.Click += lblAddSupplier_Click;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Location = new Point(0, 0);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(100, 23);
            lblPageInfo.TabIndex = 0;
            // 
            // SupplierGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(drPanelCustomer);
            Name = "SupplierGUI";
            Size = new Size(1554, 958);
            Load += SupplierGUI_Load;
            customPanel1.ResumeLayout(false);
            customPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            customPanel3.ResumeLayout(false);
            customPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClearSearch).EndInit();
            paginationPanel.ResumeLayout(false);
            drPanelCustomer.ResumeLayout(false);
            drPanelCustomer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private CustomPanel customPanel1;
        private TableLayoutPanel pCustomerList;
        private CustomPanel customPanel2;
        private CustomPanel customPanel3;
        private TextBox txtSearch;
        private PictureBox btnClearSearch;
        private PictureBox pictureBox1;
        private Panel drPanelCustomer;
        private Label lblAddSupplier;

        private Panel paginationPanel;
        private Button btnExtraPrevious;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnExtraNext;
        private Label lblPageInfo;
    }
}