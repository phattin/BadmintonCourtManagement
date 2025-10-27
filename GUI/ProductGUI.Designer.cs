namespace BadmintonCourtManagement.GUI
{
    partial class ProductGUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductGUI));
            pageButtonPanel = new Panel();
            extraNextButton = new Button();
            extraPreviousButton = new Button();
            nextButton = new Button();
            previousButton = new Button();
            cardList = new TableLayoutPanel();
            card = new Panel();
            cardButton = new Button();
            cardBody = new Label();
            cardTitle = new Label();
            toolBar = new CustomPanel();
            searchPanel = new CustomPanel();
            btnDelete = new PictureBox();
            searchBar = new TextBox();
            filterButton = new PictureBox();
            btnAddProduct = new Label();
            titlePanel = new Panel();
            titleText = new Label();
            bigPanel = new Panel();
            bodyPanel = new TableLayoutPanel();
            productListPanel = new Panel();
            pProductList = new TableLayoutPanel();
            pageButtonPanel.SuspendLayout();
            cardList.SuspendLayout();
            card.SuspendLayout();
            toolBar.SuspendLayout();
            searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filterButton).BeginInit();
            titlePanel.SuspendLayout();
            bigPanel.SuspendLayout();
            bodyPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pageButtonPanel
            // 
            pageButtonPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pageButtonPanel.AutoSize = true;
            pageButtonPanel.Controls.Add(extraNextButton);
            pageButtonPanel.Controls.Add(extraPreviousButton);
            pageButtonPanel.Controls.Add(nextButton);
            pageButtonPanel.Controls.Add(previousButton);
            pageButtonPanel.Location = new Point(0, 610);
            pageButtonPanel.Margin = new Padding(0);
            pageButtonPanel.Name = "pageButtonPanel";
            pageButtonPanel.Size = new Size(1243, 102);
            pageButtonPanel.TabIndex = 1;
            // 
            // extraNextButton
            // 
            extraNextButton.Anchor = AnchorStyles.None;
            extraNextButton.BackColor = Color.Transparent;
            extraNextButton.Cursor = Cursors.Hand;
            extraNextButton.Image = (Image)resources.GetObject("extraNextButton.Image");
            extraNextButton.Location = new Point(756, 17);
            extraNextButton.Name = "extraNextButton";
            extraNextButton.Size = new Size(75, 69);
            extraNextButton.TabIndex = 16;
            extraNextButton.TextImageRelation = TextImageRelation.ImageAboveText;
            extraNextButton.UseVisualStyleBackColor = false;
            // 
            // extraPreviousButton
            // 
            extraPreviousButton.Anchor = AnchorStyles.None;
            extraPreviousButton.BackColor = Color.Transparent;
            extraPreviousButton.Cursor = Cursors.Hand;
            extraPreviousButton.ForeColor = Color.Transparent;
            extraPreviousButton.Image = (Image)resources.GetObject("extraPreviousButton.Image");
            extraPreviousButton.Location = new Point(426, 17);
            extraPreviousButton.Name = "extraPreviousButton";
            extraPreviousButton.Size = new Size(75, 69);
            extraPreviousButton.TabIndex = 13;
            extraPreviousButton.TextImageRelation = TextImageRelation.ImageAboveText;
            extraPreviousButton.UseVisualStyleBackColor = false;
            // 
            // nextButton
            // 
            nextButton.Anchor = AnchorStyles.None;
            nextButton.BackColor = Color.Transparent;
            nextButton.Cursor = Cursors.Hand;
            nextButton.Image = (Image)resources.GetObject("nextButton.Image");
            nextButton.Location = new Point(644, 17);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(75, 69);
            nextButton.TabIndex = 15;
            nextButton.TextImageRelation = TextImageRelation.ImageAboveText;
            nextButton.UseVisualStyleBackColor = false;
            // 
            // previousButton
            // 
            previousButton.Anchor = AnchorStyles.None;
            previousButton.BackColor = Color.Transparent;
            previousButton.Cursor = Cursors.Hand;
            previousButton.Image = (Image)resources.GetObject("previousButton.Image");
            previousButton.Location = new Point(539, 17);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(75, 69);
            previousButton.TabIndex = 14;
            previousButton.TextImageRelation = TextImageRelation.ImageAboveText;
            previousButton.UseVisualStyleBackColor = false;
            // 
            // cardList
            // 
            cardList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cardList.AutoSize = true;
            cardList.BackColor = Color.FromArgb(239, 248, 230);
            cardList.ColumnCount = 4;
            cardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            cardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            cardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            cardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            cardList.Controls.Add(card, 0, 0);
            cardList.Location = new Point(0, 246);
            cardList.Margin = new Padding(0);
            cardList.Name = "cardList";
            cardList.RowCount = 2;
            cardList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            cardList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            cardList.Size = new Size(1789, 1000);
            cardList.TabIndex = 2;
            // 
            // card
            // 
            card.AutoSize = true;
            card.BackColor = Color.FromArgb(200, 250, 214);
            card.Controls.Add(cardButton);
            card.Controls.Add(cardBody);
            card.Controls.Add(cardTitle);
            card.Dock = DockStyle.Fill;
            card.Location = new Point(15, 15);
            card.Margin = new Padding(15);
            card.Name = "card";
            card.Size = new Size(417, 470);
            card.TabIndex = 0;
            // 
            // cardButton
            // 
            cardButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cardButton.BackColor = Color.Black;
            cardButton.Cursor = Cursors.Hand;
            cardButton.Font = new Font("Roboto Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cardButton.ForeColor = Color.White;
            cardButton.Location = new Point(56, 345);
            cardButton.Margin = new Padding(0);
            cardButton.Name = "cardButton";
            cardButton.Size = new Size(295, 70);
            cardButton.TabIndex = 6;
            cardButton.Text = "Xem chi tiết";
            cardButton.UseVisualStyleBackColor = false;
            // cardButton.Click += cardButton_Click_1;
            // 
            // cardBody
            // 
            cardBody.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cardBody.Font = new Font("Roboto Medium", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardBody.Location = new Point(3, 125);
            cardBody.Name = "cardBody";
            cardBody.Size = new Size(411, 220);
            cardBody.TabIndex = 4;
            cardBody.Text = "Tên nhân viên: Thu Trang\r\nCông việc: Thu ngân";
            cardBody.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardTitle
            // 
            cardTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cardTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardTitle.Location = new Point(3, 0);
            cardTitle.Margin = new Padding(0);
            cardTitle.Name = "cardTitle";
            cardTitle.Size = new Size(411, 111);
            cardTitle.TabIndex = 3;
            cardTitle.Text = "NV0001";
            cardTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolBar
            // 
            toolBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            toolBar.BackColor = Color.FromArgb(0, 120, 103);
            toolBar.BorderRadius = 20;
            toolBar.Controls.Add(searchPanel);
            toolBar.Controls.Add(filterButton);
            toolBar.Location = new Point(0, 0);
            toolBar.Margin = new Padding(3, 4, 3, 4);
            toolBar.Name = "toolBar";
            toolBar.Padding = new Padding(10);
            toolBar.Size = new Size(1146, 73);
            toolBar.TabIndex = 1;
            toolBar.Paint += tableLayoutPanel1_Paint;
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.White;
            searchPanel.BorderRadius = 30;
            searchPanel.Controls.Add(btnDelete);
            searchPanel.Controls.Add(searchBar);
            searchPanel.Location = new Point(15, 12);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(520, 51);
            searchPanel.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Image = Properties.Resources.X;
            btnDelete.Location = new Point(490, 19);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(13, 13);
            btnDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            btnDelete.TabIndex = 0;
            btnDelete.TabStop = false;
	        btnDelete.Click += new EventHandler(btnDelete_Click);
            // 
            // searchBar
            // 
            searchBar.Anchor = AnchorStyles.None;
            searchBar.BorderStyle = BorderStyle.None;
            searchBar.Cursor = Cursors.IBeam;
            searchBar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBar.ForeColor = Color.Black;
            searchBar.Location = new Point(14, 13);
            searchBar.Margin = new Padding(0, 0, 10, 0);
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = "value...";
            searchBar.Size = new Size(510, 20);
            searchBar.TabIndex = 1;
            // searchBar.TextChanged += searchEnterEvent;
            // 
            // filterButton
            // 
            filterButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filterButton.Cursor = Cursors.Hand;
            filterButton.Image = Properties.Resources.Filter;
            filterButton.Location = new Point(1084, 12);
            filterButton.Margin = new Padding(3, 4, 3, 4);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(48, 41);
            filterButton.SizeMode = PictureBoxSizeMode.StretchImage;
            filterButton.TabIndex = 1;
            filterButton.TabStop = false;
            filterButton.MouseEnter += filterButton_MouseEnter;
            filterButton.MouseLeave += filterButton_MouseLeave;
	    filterButton.Click += filterButton_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddProduct.AutoSize = true;
            btnAddProduct.BackColor = Color.FromArgb(64, 64, 64);
            btnAddProduct.Cursor = Cursors.Hand;
            btnAddProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(1079, 22);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Padding = new Padding(10, 11, 10, 13);
            btnAddProduct.Size = new Size(114, 52);
            btnAddProduct.TabIndex = 2;
            btnAddProduct.Text = "Thêm SP";
            btnAddProduct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // titlePanel
            // 
            titlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titlePanel.AutoSize = true;
            titlePanel.Controls.Add(titleText);
            titlePanel.Location = new Point(0, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(1789, 100);
            titlePanel.TabIndex = 0;
            titlePanel.Paint += panel1_Paint;
            // 
            // titleText
            // 
            titleText.AutoSize = true;
            titleText.BackColor = Color.Transparent;
            titleText.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleText.ForeColor = Color.Black;
            titleText.Location = new Point(53, 15);
            titleText.Name = "titleText";
            titleText.Padding = new Padding(10, 11, 10, 11);
            titleText.Size = new Size(164, 60);
            titleText.TabIndex = 0;
            titleText.Text = "Sản phẩm";
            titleText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bigPanel
            // 
            bigPanel.BackColor = Color.White;
            bigPanel.Controls.Add(bodyPanel);
            bigPanel.Controls.Add(pageButtonPanel);
            bigPanel.Controls.Add(btnAddProduct);
            bigPanel.Controls.Add(titlePanel);
            bigPanel.Dock = DockStyle.Fill;
            bigPanel.Location = new Point(0, 0);
            bigPanel.Name = "bigPanel";
            bigPanel.Size = new Size(1243, 719);
            bigPanel.TabIndex = 0;
            // 
            // bodyPanel
            // 
            bodyPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bodyPanel.BackColor = Color.FromArgb(239, 248, 230);
            bodyPanel.ColumnCount = 1;
            bodyPanel.RowCount = 2;
            bodyPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            bodyPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            bodyPanel.Controls.Add(toolBar);
            bodyPanel.Controls.Add(productListPanel);
            bodyPanel.Location = new Point(56, 79);
            bodyPanel.Margin = new Padding(3, 4, 3, 4);
            bodyPanel.Name = "bodyPanel";
            bodyPanel.Size = new Size(1146, 527);
            bodyPanel.TabIndex = 0;
            // 
            // productListPanel
            // 
            productListPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productListPanel.AutoScroll = true;
            productListPanel.Size = new Size(927, 370);
            // productListPanel.Location = new Point(43, 101);
            productListPanel.Location = new Point(38, 76);
            productListPanel.Margin = new Padding(2, 4, 2, 4);
            productListPanel.Controls.Add(pProductList);
            productListPanel.BackColor = Color.Transparent;
            //
            // pProductList
            //
            // pProductList.AutoScroll = true;
            pProductList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pProductList.ColumnCount = 4;
            pProductList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pProductList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pProductList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pProductList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pProductList.Margin = new Padding(2);
            pProductList.Name = "pProductList";
            pProductList.RowCount = 2;
            pProductList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pProductList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pProductList.Dock = DockStyle.Fill;
            // 
            // ProductGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(bigPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductGUI";
            Size = new Size(1243, 719);
            pageButtonPanel.ResumeLayout(false);
            cardList.ResumeLayout(false);
            cardList.PerformLayout();
            card.ResumeLayout(false);
            toolBar.ResumeLayout(false);
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)filterButton).EndInit();
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            bigPanel.ResumeLayout(false);
            bigPanel.PerformLayout();
            bodyPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // private DateTimePicker startDate;
        // private Label startText;
        // private Label endText;
        // private DateTimePicker endDate;
        private TableLayoutPanel cardList;
        private Panel card;
        private Panel titlePanel;
        private Label titleText;
        private Panel pageButtonPanel;
        private Button previousButton;
        private Button nextButton;
        private Button extraNextButton;
        private Button extraPreviousButton;
        private PictureBox filterButton;
        private Label cardTitle;
        private Button cardButton;
        private Label cardBody;

        // from court management GUI
        private Panel bigPanel;
        private TableLayoutPanel bodyPanel;
        private Panel productListPanel;
        private TableLayoutPanel pProductList;
        private CustomPanel toolBar;
        private CustomPanel searchPanel;
        private PictureBox btnDelete;
        private TextBox searchBar;
        private Label btnAddProduct;
    }
}
