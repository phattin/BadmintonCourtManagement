namespace BadmintonCourtManagement.GUI
{
    partial class CustomerGUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerGUI));
            lblTitle = new Label();
            customPanel1 = new CustomPanel();
            pCustomerList = new TableLayoutPanel();
            customPanel2 = new CustomPanel();
            pictureBox1 = new PictureBox();
            customPanel3 = new CustomPanel();
            btnClearSearch = new PictureBox();
            txtSearch = new TextBox();
            drPanelCustomer = new Panel();
            lblAddCustomer = new Label();
            customPanel1.SuspendLayout();
            customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClearSearch).BeginInit();
            drPanelCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(53, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(10, 11, 10, 11);
            lblTitle.Size = new Size(200, 60);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Quản lý khách hàng";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.UseWaitCursor = true;
            // 
            // customPanel1
            // 
            customPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            customPanel1.BackColor = Color.FromArgb(239, 248, 230);
            customPanel1.BorderRadius = 20;
            customPanel1.Controls.Add(pCustomerList);
            customPanel1.Controls.Add(customPanel2);
            customPanel1.Location = new Point(56, 79);
            customPanel1.Margin = new Padding(3, 4, 3, 4);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(1146, 639);
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
            pCustomerList.Location = new Point(43, 101);
            pCustomerList.Margin = new Padding(2);
            pCustomerList.Name = "pCustomerList";
            pCustomerList.RowCount = 2;
            pCustomerList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pCustomerList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pCustomerList.Size = new Size(1059, 494);
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
            customPanel2.Margin = new Padding(3, 4, 3, 4);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(1146, 73);
            customPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1084, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // customPanel3
            // 
            customPanel3.BackColor = Color.White;
            customPanel3.BorderRadius = 30;
            customPanel3.Controls.Add(btnClearSearch);
            customPanel3.Controls.Add(txtSearch);
            customPanel3.Location = new Point(15, 12);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(520, 51);
            customPanel3.TabIndex = 1;
            // 
            // btnClearSearch
            // 
            btnClearSearch.Image = Image.FromFile(Application.StartupPath + @"\Img\Icon\X.png");
            btnClearSearch.Location = new Point(490, 19);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(13, 13);
            btnClearSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClearSearch.TabIndex = 1;
            btnClearSearch.TabStop = false;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(14, 13);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm khách hàng";
            txtSearch.Size = new Size(470, 24);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // drPanelCustomer
            // 
            drPanelCustomer.BackColor = Color.White;
            drPanelCustomer.Controls.Add(lblAddCustomer);
            drPanelCustomer.Controls.Add(customPanel1);
            drPanelCustomer.Controls.Add(lblTitle);
            drPanelCustomer.Dock = DockStyle.Fill;
            drPanelCustomer.Location = new Point(0, 0);
            drPanelCustomer.Name = "drPanelCustomer";
            drPanelCustomer.Size = new Size(1243, 766);
            drPanelCustomer.TabIndex = 0;
            // 
            // lblAddCustomer
            // 
            lblAddCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAddCustomer.AutoSize = true;
            lblAddCustomer.BackColor = Color.FromArgb(64, 64, 64);
            lblAddCustomer.Cursor = Cursors.Hand;
            lblAddCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddCustomer.ForeColor = Color.White;
            lblAddCustomer.Location = new Point(1079, 22);
            lblAddCustomer.Name = "lblAddCustomer";
            lblAddCustomer.Padding = new Padding(10, 11, 10, 13);
            lblAddCustomer.Size = new Size(150, 52);
            lblAddCustomer.TabIndex = 7;
            lblAddCustomer.Text = "Thêm khách hàng";
            lblAddCustomer.TextAlign = ContentAlignment.MiddleCenter;
            lblAddCustomer.Click += lblAddCustomer_Click;
            // 
            // CustomerGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(drPanelCustomer);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerGUI";
            Size = new Size(1243, 766);
            Load += CustomerGUI_Load;
            customPanel1.ResumeLayout(false);
            customPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            customPanel3.ResumeLayout(false);
            customPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClearSearch).EndInit();
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
        private Label lblAddCustomer;
    }
}