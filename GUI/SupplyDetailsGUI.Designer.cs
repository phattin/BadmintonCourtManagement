namespace BadmintonCourtManagement.GUI
{
    partial class SupplyDetailsGUI
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
            MainPanel = new Panel();
            CardListPanel = new TableLayoutPanel();
            Picture = new PictureBox();
            BodyCardPanel = new Panel();
            SupplyTotal = new Label();
            ProductPrice = new Label();
            ProductQuantity = new Label();
            ProductName = new Label();
            ProductID = new Label();
            SupplyDetailsID = new Label();
            StatusCardPanel = new Panel();
            SupplyDetailsStatus = new Label();
            StatusText = new Label();
            toolBar = new TableLayoutPanel();
            endDate = new DateTimePicker();
            endText = new Label();
            searchBar = new TextBox();
            startDate = new DateTimePicker();
            startText = new Label();
            filterButton = new Button();
            SupplyActivePanel = new Panel();
            SupplyActive = new Label();
            SupplyStatusPanel = new Panel();
            SupplyStatus = new Label();
            TitlePanel = new Panel();
            Title = new Label();
            MainPanel.SuspendLayout();
            CardListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Picture).BeginInit();
            BodyCardPanel.SuspendLayout();
            StatusCardPanel.SuspendLayout();
            toolBar.SuspendLayout();
            SupplyActivePanel.SuspendLayout();
            SupplyStatusPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainPanel.AutoScroll = true;
            MainPanel.BackColor = Color.FromArgb(239, 248, 230);
            MainPanel.Controls.Add(CardListPanel);
            MainPanel.Controls.Add(toolBar);
            MainPanel.Controls.Add(SupplyActivePanel);
            MainPanel.Controls.Add(SupplyStatusPanel);
            MainPanel.Controls.Add(TitlePanel);
            MainPanel.Location = new Point(54, 54);
            MainPanel.Margin = new Padding(0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1539, 950);
            MainPanel.TabIndex = 0;
            // 
            // CardListPanel
            // 
            CardListPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CardListPanel.AutoScroll = true;
            CardListPanel.AutoSize = true;
            CardListPanel.BackColor = Color.FromArgb(239, 248, 230);
            CardListPanel.ColumnCount = 3;
            CardListPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            CardListPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            CardListPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            CardListPanel.Controls.Add(Picture, 0, 0);
            CardListPanel.Controls.Add(BodyCardPanel, 1, 0);
            CardListPanel.Controls.Add(StatusCardPanel, 2, 0);
            CardListPanel.Location = new Point(0, 335);
            CardListPanel.Margin = new Padding(0);
            CardListPanel.Name = "CardListPanel";
            CardListPanel.RowCount = 2;
            CardListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            CardListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            CardListPanel.Size = new Size(1539, 768);
            CardListPanel.TabIndex = 4;
            // 
            // Picture
            // 
            Picture.BackColor = Color.FromArgb(200, 250, 214);
            Picture.Dock = DockStyle.Fill;
            Picture.Image = Image.FromFile(Application.StartupPath + @"\Img\Icon\Picture.png");
            Picture.Location = new Point(20, 20);
            Picture.Margin = new Padding(20, 20, 0, 20);
            Picture.Name = "Picture";
            Picture.Size = new Size(287, 344);
            Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture.TabIndex = 0;
            Picture.TabStop = false;
            // 
            // BodyCardPanel
            // 
            BodyCardPanel.AutoSize = true;
            BodyCardPanel.BackColor = Color.FromArgb(200, 250, 214);
            BodyCardPanel.Controls.Add(SupplyTotal);
            BodyCardPanel.Controls.Add(ProductPrice);
            BodyCardPanel.Controls.Add(ProductQuantity);
            BodyCardPanel.Controls.Add(ProductName);
            BodyCardPanel.Controls.Add(ProductID);
            BodyCardPanel.Controls.Add(SupplyDetailsID);
            BodyCardPanel.Dock = DockStyle.Fill;
            BodyCardPanel.Location = new Point(307, 20);
            BodyCardPanel.Margin = new Padding(0, 20, 0, 20);
            BodyCardPanel.Name = "BodyCardPanel";
            BodyCardPanel.Padding = new Padding(25, 10, 10, 10);
            BodyCardPanel.Size = new Size(615, 344);
            BodyCardPanel.TabIndex = 1;
            // 
            // SupplyTotal
            // 
            SupplyTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SupplyTotal.Font = new Font("Roboto Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SupplyTotal.Location = new Point(28, 280);
            SupplyTotal.Margin = new Padding(0);
            SupplyTotal.Name = "SupplyTotal";
            SupplyTotal.Size = new Size(565, 54);
            SupplyTotal.TabIndex = 5;
            SupplyTotal.Text = "Thành tiền: 10.000.000đ";
            SupplyTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductPrice
            // 
            ProductPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductPrice.Font = new Font("Roboto Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductPrice.Location = new Point(28, 226);
            ProductPrice.Margin = new Padding(0);
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Size = new Size(565, 54);
            ProductPrice.TabIndex = 4;
            ProductPrice.Text = "Đơn giá: 100.000đ";
            ProductPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductQuantity
            // 
            ProductQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductQuantity.Font = new Font("Roboto Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductQuantity.Location = new Point(28, 172);
            ProductQuantity.Margin = new Padding(0);
            ProductQuantity.Name = "ProductQuantity";
            ProductQuantity.Size = new Size(565, 54);
            ProductQuantity.TabIndex = 3;
            ProductQuantity.Text = "Số lượng: 100";
            ProductQuantity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductName
            // 
            ProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductName.Font = new Font("Roboto Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductName.Location = new Point(28, 118);
            ProductName.Margin = new Padding(0);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(565, 54);
            ProductName.TabIndex = 2;
            ProductName.Text = "Tên sản phẩm: Giày thể thao";
            ProductName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductID
            // 
            ProductID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductID.Font = new Font("Roboto Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductID.Location = new Point(28, 64);
            ProductID.Margin = new Padding(0);
            ProductID.Name = "ProductID";
            ProductID.Size = new Size(565, 54);
            ProductID.TabIndex = 1;
            ProductID.Text = "Mã sản phẩm: 0001";
            ProductID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SupplyDetailsID
            // 
            SupplyDetailsID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SupplyDetailsID.Font = new Font("Roboto Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SupplyDetailsID.Location = new Point(28, 10);
            SupplyDetailsID.Margin = new Padding(0);
            SupplyDetailsID.Name = "SupplyDetailsID";
            SupplyDetailsID.Size = new Size(565, 54);
            SupplyDetailsID.TabIndex = 0;
            SupplyDetailsID.Text = "Mã chi tiết nhập hàng: CTNH0001";
            SupplyDetailsID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StatusCardPanel
            // 
            StatusCardPanel.AutoSize = true;
            StatusCardPanel.BackColor = Color.FromArgb(200, 250, 214);
            StatusCardPanel.Controls.Add(SupplyDetailsStatus);
            StatusCardPanel.Controls.Add(StatusText);
            StatusCardPanel.Dock = DockStyle.Fill;
            StatusCardPanel.Location = new Point(922, 20);
            StatusCardPanel.Margin = new Padding(0, 20, 20, 20);
            StatusCardPanel.Name = "StatusCardPanel";
            StatusCardPanel.Padding = new Padding(10);
            StatusCardPanel.Size = new Size(597, 344);
            StatusCardPanel.TabIndex = 2;
            // 
            // SupplyDetailsStatus
            // 
            SupplyDetailsStatus.Font = new Font("Roboto Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SupplyDetailsStatus.Image = Image.FromFile(Application.StartupPath + @"\Img\Icon\Active.png");
            SupplyDetailsStatus.ImageAlign = ContentAlignment.MiddleLeft;
            SupplyDetailsStatus.Location = new Point(409, 10);
            SupplyDetailsStatus.Name = "SupplyDetailsStatus";
            SupplyDetailsStatus.Size = new Size(184, 54);
            SupplyDetailsStatus.TabIndex = 2;
            SupplyDetailsStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StatusText
            // 
            StatusText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StatusText.Font = new Font("Roboto Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StatusText.Location = new Point(23, 10);
            StatusText.Margin = new Padding(0);
            StatusText.Name = "StatusText";
            StatusText.Size = new Size(561, 54);
            StatusText.TabIndex = 1;
            StatusText.Text = "Tình trạng: Đang hoạt động";
            StatusText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolBar
            // 
            toolBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            toolBar.BackColor = Color.FromArgb(0, 120, 103);
            toolBar.ColumnCount = 6;
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.0795383F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.1469336F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.78992F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.4615383F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.33846F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.075289F));
            toolBar.Controls.Add(endDate, 4, 0);
            toolBar.Controls.Add(endText, 3, 0);
            toolBar.Controls.Add(searchBar, 0, 0);
            toolBar.Controls.Add(startDate, 2, 0);
            toolBar.Controls.Add(startText, 1, 0);
            toolBar.Controls.Add(filterButton, 5, 0);
            toolBar.Location = new Point(0, 192);
            toolBar.Margin = new Padding(0);
            toolBar.Name = "toolBar";
            toolBar.Padding = new Padding(10);
            toolBar.RowCount = 1;
            toolBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            toolBar.Size = new Size(1539, 143);
            toolBar.TabIndex = 3;
            // 
            // endDate
            // 
            endDate.Anchor = AnchorStyles.None;
            endDate.Cursor = Cursors.Hand;
            endDate.DropDownAlign = LeftRightAlignment.Right;
            endDate.Font = new Font("Roboto Medium", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            endDate.Format = DateTimePickerFormat.Short;
            endDate.Location = new Point(1125, 43);
            endDate.Margin = new Padding(0, 0, 10, 0);
            endDate.Name = "endDate";
            endDate.ShowUpDown = true;
            endDate.Size = new Size(267, 56);
            endDate.TabIndex = 3;
            // 
            // endText
            // 
            endText.AutoSize = true;
            endText.Dock = DockStyle.Fill;
            endText.Font = new Font("Roboto Condensed", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            endText.ForeColor = Color.White;
            endText.Location = new Point(916, 10);
            endText.Margin = new Padding(10, 0, 0, 0);
            endText.Name = "endText";
            endText.Size = new Size(209, 123);
            endText.TabIndex = 3;
            endText.Text = "Ngày kết thúc:";
            endText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // searchBar
            // 
            searchBar.Anchor = AnchorStyles.None;
            searchBar.Cursor = Cursors.IBeam;
            searchBar.Font = new Font("Roboto Medium", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBar.Location = new Point(10, 45);
            searchBar.Margin = new Padding(0, 0, 10, 0);
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = "value...";
            searchBar.Size = new Size(400, 52);
            searchBar.TabIndex = 1;
            // 
            // startDate
            // 
            startDate.Anchor = AnchorStyles.None;
            startDate.Cursor = Cursors.Hand;
            startDate.DropDownAlign = LeftRightAlignment.Right;
            startDate.Font = new Font("Roboto Medium", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startDate.Format = DateTimePickerFormat.Short;
            startDate.Location = new Point(636, 43);
            startDate.Margin = new Padding(0, 0, 10, 0);
            startDate.MaxDate = new DateTime(9998, 10, 1, 0, 0, 0, 0);
            startDate.Name = "startDate";
            startDate.ShowUpDown = true;
            startDate.Size = new Size(259, 56);
            startDate.TabIndex = 2;
            startDate.Value = new DateTime(2025, 10, 1, 0, 0, 0, 0);
            // 
            // startText
            // 
            startText.Anchor = AnchorStyles.None;
            startText.AutoSize = true;
            startText.Font = new Font("Roboto", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startText.ForeColor = Color.White;
            startText.Location = new Point(452, 30);
            startText.Margin = new Padding(0);
            startText.Name = "startText";
            startText.Size = new Size(153, 82);
            startText.TabIndex = 2;
            startText.Text = "Ngày bắt đầu:";
            startText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // filterButton
            // 
            filterButton.BackColor = Color.FromArgb(0, 120, 103);
            filterButton.Cursor = Cursors.Hand;
            filterButton.Dock = DockStyle.Fill;
            filterButton.Image = Image.FromFile(Application.StartupPath + @"\Img\Icon\Filter.png");
            filterButton.Location = new Point(1403, 10);
            filterButton.Margin = new Padding(0);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(126, 123);
            filterButton.TabIndex = 4;
            filterButton.UseVisualStyleBackColor = false;
            filterButton.MouseEnter += filterButton_MouseEnter;
            filterButton.MouseLeave += filterButton_MouseLeave;
            // 
            // SupplyActivePanel
            // 
            SupplyActivePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SupplyActivePanel.AutoSize = true;
            SupplyActivePanel.Controls.Add(SupplyActive);
            SupplyActivePanel.Location = new Point(637, 98);
            SupplyActivePanel.Margin = new Padding(0);
            SupplyActivePanel.Name = "SupplyActivePanel";
            SupplyActivePanel.Size = new Size(878, 76);
            SupplyActivePanel.TabIndex = 2;
            // 
            // SupplyActive
            // 
            SupplyActive.Dock = DockStyle.Fill;
            SupplyActive.Font = new Font("Roboto Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SupplyActive.Image = Image.FromFile(Application.StartupPath + @"\Img\Icon\Active.png");
            SupplyActive.ImageAlign = ContentAlignment.MiddleLeft;
            SupplyActive.Location = new Point(0, 0);
            SupplyActive.Name = "SupplyActive";
            SupplyActive.Size = new Size(878, 76);
            SupplyActive.TabIndex = 0;
            SupplyActive.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SupplyStatusPanel
            // 
            SupplyStatusPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SupplyStatusPanel.AutoSize = true;
            SupplyStatusPanel.Controls.Add(SupplyStatus);
            SupplyStatusPanel.Location = new Point(45, 98);
            SupplyStatusPanel.Margin = new Padding(0);
            SupplyStatusPanel.Name = "SupplyStatusPanel";
            SupplyStatusPanel.Size = new Size(1470, 76);
            SupplyStatusPanel.TabIndex = 1;
            // 
            // SupplyStatus
            // 
            SupplyStatus.Dock = DockStyle.Fill;
            SupplyStatus.Font = new Font("Roboto Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SupplyStatus.Location = new Point(0, 0);
            SupplyStatus.Name = "SupplyStatus";
            SupplyStatus.Size = new Size(1470, 76);
            SupplyStatus.TabIndex = 0;
            SupplyStatus.Text = "Tình trạng: đang hoạt động";
            SupplyStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TitlePanel
            // 
            TitlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitlePanel.AutoSize = true;
            TitlePanel.Controls.Add(Title);
            TitlePanel.Location = new Point(45, 0);
            TitlePanel.Margin = new Padding(0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(1470, 98);
            TitlePanel.TabIndex = 0;
            // 
            // Title
            // 
            Title.Dock = DockStyle.Fill;
            Title.Font = new Font("Roboto", 36F, FontStyle.Bold);
            Title.Location = new Point(0, 0);
            Title.Name = "Title";
            Title.Size = new Size(1470, 98);
            Title.TabIndex = 0;
            Title.Text = "Chi tiết: NH0001";
            Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SupplyDetailsGUI
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 120, 103);
            ClientSize = new Size(1649, 1055);
            Controls.Add(MainPanel);
            Font = new Font("Roboto", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SupplyDetailsGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết đơn hàng nhập";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            CardListPanel.ResumeLayout(false);
            CardListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Picture).EndInit();
            BodyCardPanel.ResumeLayout(false);
            StatusCardPanel.ResumeLayout(false);
            toolBar.ResumeLayout(false);
            toolBar.PerformLayout();
            SupplyActivePanel.ResumeLayout(false);
            SupplyStatusPanel.ResumeLayout(false);
            TitlePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Panel TitlePanel;
        private Label Title;
        private Panel SupplyStatusPanel;
        private Label SupplyStatus;
        private Panel SupplyActivePanel;
        private Label SupplyActive;
        private TableLayoutPanel toolBar;
        private DateTimePicker endDate;
        private Label endText;
        private TextBox searchBar;
        private DateTimePicker startDate;
        private Label startText;
        private Button filterButton;
        private TableLayoutPanel CardListPanel;
        private PictureBox Picture;
        private Panel BodyCardPanel;
        private Label SupplyDetailsID;
        private Label ProductID;
        private Label ProductName;
        private Label SupplyTotal;
        private Label ProductPrice;
        private Label ProductQuantity;
        private Panel StatusCardPanel;
        private Label SupplyDetailsStatus;
        private Label StatusText;
    }
}