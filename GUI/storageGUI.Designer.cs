namespace BadmintonCourtManagement.GUI
{
    partial class storageGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(storageGUI));
            tabPane = new TabControl();
            khoHangPage = new TabPage();
            pageButtonPanel = new Panel();
            extraNextButton = new Button();
            extraPreviousButton = new Button();
            nextButton = new Button();
            previousButton = new Button();
            cardList = new TableLayoutPanel();
            toolBar = new TableLayoutPanel();
            Reset = new Button();
            endDate = new DateTimePicker();
            endText = new Label();
            searchBar = new TextBox();
            startDate = new DateTimePicker();
            startText = new Label();
            filterButton = new Button();
            titlePanel = new Panel();
            titleText = new Label();
            nhapHangPage = new TabPage();
            HeaderPanel = new TableLayoutPanel();
            Title = new Label();
            AddButton = new Button();
            NhapHangPagePanel = new Panel();
            NhapHangExtraNext = new Button();
            NhapHangExtraPrevious = new Button();
            NhapHangNext = new Button();
            NhapHangPrevious = new Button();
            NhapHangCardList = new TableLayoutPanel();
            NhapHangCard = new Panel();
            NhapHangButtonCard = new Button();
            NhapHangBodyCard = new Label();
            NhapHangTitleCard = new Label();
            NhapHangToolBar = new TableLayoutPanel();
            NhapHangEndDate = new DateTimePicker();
            NhapHangEnd = new Label();
            NhapHangSearchbar = new TextBox();
            NhapHangStartDate = new DateTimePicker();
            NhapHangStart = new Label();
            NhapHangFilterButton = new Button();
            tabPane.SuspendLayout();
            khoHangPage.SuspendLayout();
            pageButtonPanel.SuspendLayout();
            toolBar.SuspendLayout();
            titlePanel.SuspendLayout();
            nhapHangPage.SuspendLayout();
            HeaderPanel.SuspendLayout();
            NhapHangPagePanel.SuspendLayout();
            NhapHangCardList.SuspendLayout();
            NhapHangCard.SuspendLayout();
            NhapHangToolBar.SuspendLayout();
            SuspendLayout();
            // 
            // tabPane
            // 
            tabPane.Controls.Add(khoHangPage);
            tabPane.Controls.Add(nhapHangPage);
            tabPane.Dock = DockStyle.Fill;
            tabPane.Font = new Font("Roboto", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPane.Location = new Point(0, 0);
            tabPane.Margin = new Padding(0);
            tabPane.Name = "tabPane";
            tabPane.SelectedIndex = 0;
            tabPane.Size = new Size(1653, 1400);
            tabPane.TabIndex = 0;
            // 
            // khoHangPage
            // 
            khoHangPage.AutoScroll = true;
            khoHangPage.BackColor = Color.White;
            khoHangPage.Controls.Add(pageButtonPanel);
            khoHangPage.Controls.Add(cardList);
            khoHangPage.Controls.Add(toolBar);
            khoHangPage.Controls.Add(titlePanel);
            khoHangPage.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            khoHangPage.Location = new Point(4, 48);
            khoHangPage.Margin = new Padding(0);
            khoHangPage.Name = "khoHangPage";
            khoHangPage.Size = new Size(1645, 1348);
            khoHangPage.TabIndex = 0;
            khoHangPage.Text = "Kho hàng";
            khoHangPage.Click += tabPage1_Click;
            // 
            // pageButtonPanel
            // 
            pageButtonPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pageButtonPanel.AutoSize = true;
            pageButtonPanel.Controls.Add(extraNextButton);
            pageButtonPanel.Controls.Add(extraPreviousButton);
            pageButtonPanel.Controls.Add(nextButton);
            pageButtonPanel.Controls.Add(previousButton);
            pageButtonPanel.Location = new Point(0, 1246);
            pageButtonPanel.Margin = new Padding(0);
            pageButtonPanel.Name = "pageButtonPanel";
            pageButtonPanel.Size = new Size(1642, 102);
            pageButtonPanel.TabIndex = 3;
            // 
            // extraNextButton
            // 
            extraNextButton.Anchor = AnchorStyles.None;
            extraNextButton.BackColor = Color.Transparent;
            extraNextButton.Cursor = Cursors.Hand;
            extraNextButton.Image = (Image)resources.GetObject("extraNextButton.Image");
            extraNextButton.Location = new Point(948, 18);
            extraNextButton.Name = "extraNextButton";
            extraNextButton.Size = new Size(75, 69);
            extraNextButton.TabIndex = 16;
            extraNextButton.TextImageRelation = TextImageRelation.ImageAboveText;
            extraNextButton.UseVisualStyleBackColor = false;
            extraNextButton.Click += extraNextButton_Click;
            // 
            // extraPreviousButton
            // 
            extraPreviousButton.Anchor = AnchorStyles.None;
            extraPreviousButton.BackColor = Color.Transparent;
            extraPreviousButton.Cursor = Cursors.Hand;
            extraPreviousButton.ForeColor = Color.Transparent;
            extraPreviousButton.Image = (Image)resources.GetObject("extraPreviousButton.Image");
            extraPreviousButton.Location = new Point(618, 18);
            extraPreviousButton.Name = "extraPreviousButton";
            extraPreviousButton.Size = new Size(75, 69);
            extraPreviousButton.TabIndex = 13;
            extraPreviousButton.TextImageRelation = TextImageRelation.ImageAboveText;
            extraPreviousButton.UseVisualStyleBackColor = false;
            extraPreviousButton.Click += extraPreviousButton_Click;
            // 
            // nextButton
            // 
            nextButton.Anchor = AnchorStyles.None;
            nextButton.BackColor = Color.Transparent;
            nextButton.Cursor = Cursors.Hand;
            nextButton.Image = (Image)resources.GetObject("nextButton.Image");
            nextButton.Location = new Point(836, 18);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(75, 69);
            nextButton.TabIndex = 15;
            nextButton.TextImageRelation = TextImageRelation.ImageAboveText;
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // previousButton
            // 
            previousButton.Anchor = AnchorStyles.None;
            previousButton.BackColor = Color.Transparent;
            previousButton.Cursor = Cursors.Hand;
            previousButton.Image = (Image)resources.GetObject("previousButton.Image");
            previousButton.Location = new Point(731, 18);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(75, 69);
            previousButton.TabIndex = 14;
            previousButton.TextImageRelation = TextImageRelation.ImageAboveText;
            previousButton.UseVisualStyleBackColor = false;
            previousButton.Click += previousButton_Click;
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
            cardList.Location = new Point(0, 246);
            cardList.Margin = new Padding(0);
            cardList.Name = "cardList";
            cardList.RowCount = 2;
            cardList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            cardList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            cardList.Size = new Size(1642, 1000);
            cardList.TabIndex = 2;
            cardList.Paint += cardList_Paint;
            // 
            // toolBar
            // 
            toolBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            toolBar.BackColor = Color.FromArgb(0, 120, 103);
            toolBar.ColumnCount = 7;
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.6420288F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.8735247F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.1885948F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.159811F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.68776F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.569667F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.4463625F));
            toolBar.Controls.Add(Reset, 6, 0);
            toolBar.Controls.Add(endDate, 4, 0);
            toolBar.Controls.Add(endText, 3, 0);
            toolBar.Controls.Add(searchBar, 0, 0);
            toolBar.Controls.Add(startDate, 2, 0);
            toolBar.Controls.Add(startText, 1, 0);
            toolBar.Controls.Add(filterButton, 5, 0);
            toolBar.Location = new Point(0, 100);
            toolBar.Margin = new Padding(0);
            toolBar.Name = "toolBar";
            toolBar.Padding = new Padding(10);
            toolBar.RowCount = 1;
            toolBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            toolBar.Size = new Size(1642, 143);
            toolBar.TabIndex = 1;
            toolBar.Paint += tableLayoutPanel1_Paint;
            // 
            // Reset
            // 
            Reset.BackColor = Color.FromArgb(0, 120, 103);
            Reset.Cursor = Cursors.Hand;
            Reset.Dock = DockStyle.Fill;
            Reset.Image = Image.FromFile(Application.StartupPath + @"\Img\Icon\Reset.png");
            Reset.Location = new Point(1494, 10);
            Reset.Margin = new Padding(0);
            Reset.Name = "Reset";
            Reset.Size = new Size(138, 123);
            Reset.TabIndex = 5;
            Reset.UseVisualStyleBackColor = false;
            Reset.Click += Reset_Click;
            // 
            // endDate
            // 
            endDate.Anchor = AnchorStyles.None;
            endDate.Cursor = Cursors.Hand;
            endDate.DropDownAlign = LeftRightAlignment.Right;
            endDate.Font = new Font("Roboto Medium", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            endDate.Format = DateTimePickerFormat.Short;
            endDate.Location = new Point(1087, 43);
            endDate.Margin = new Padding(0, 0, 10, 0);
            endDate.Name = "endDate";
            endDate.ShowUpDown = true;
            endDate.Size = new Size(259, 56);
            endDate.TabIndex = 3;
            // 
            // endText
            // 
            endText.AutoSize = true;
            endText.Dock = DockStyle.Fill;
            endText.Font = new Font("Roboto Condensed", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            endText.ForeColor = Color.White;
            endText.Location = new Point(885, 10);
            endText.Margin = new Padding(10, 0, 0, 0);
            endText.Name = "endText";
            endText.Size = new Size(202, 123);
            endText.TabIndex = 3;
            endText.Text = "Ngày kết thúc:";
            endText.TextAlign = ContentAlignment.MiddleCenter;
            endText.Click += label3_Click;
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
            searchBar.Size = new Size(387, 52);
            searchBar.TabIndex = 1;
            searchBar.TextChanged += textBox1_TextChanged;
            searchBar.KeyDown += searchEnterEvent;
            // 
            // startDate
            // 
            startDate.Anchor = AnchorStyles.None;
            startDate.Cursor = Cursors.Hand;
            startDate.DropDownAlign = LeftRightAlignment.Right;
            startDate.Font = new Font("Roboto Medium", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startDate.Format = DateTimePickerFormat.Short;
            startDate.Location = new Point(614, 43);
            startDate.Margin = new Padding(0, 0, 10, 0);
            startDate.MaxDate = new DateTime(9998, 10, 1, 0, 0, 0, 0);
            startDate.Name = "startDate";
            startDate.ShowUpDown = true;
            startDate.Size = new Size(251, 56);
            startDate.TabIndex = 2;
            startDate.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            startDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // startText
            // 
            startText.Anchor = AnchorStyles.None;
            startText.AutoSize = true;
            startText.Font = new Font("Roboto", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startText.ForeColor = Color.White;
            startText.Location = new Point(434, 30);
            startText.Margin = new Padding(0);
            startText.Name = "startText";
            startText.Size = new Size(153, 82);
            startText.TabIndex = 2;
            startText.Text = "Ngày bắt đầu:";
            startText.TextAlign = ContentAlignment.MiddleCenter;
            startText.Click += label2_Click;
            // 
            // filterButton
            // 
            filterButton.BackColor = Color.FromArgb(0, 120, 103);
            filterButton.Cursor = Cursors.Hand;
            filterButton.Dock = DockStyle.Fill;
            filterButton.Image = Image.FromFile(Application.StartupPath + @"\Img\Icon\Filter.png");
            filterButton.Location = new Point(1356, 10);
            filterButton.Margin = new Padding(0);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(138, 123);
            filterButton.TabIndex = 4;
            filterButton.UseVisualStyleBackColor = false;
            filterButton.Click += filterButton_Click;
            filterButton.MouseEnter += filterButton_MouseEnter;
            filterButton.MouseLeave += filterButton_MouseLeave;
            // 
            // titlePanel
            // 
            titlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titlePanel.AutoSize = true;
            titlePanel.Controls.Add(titleText);
            titlePanel.Location = new Point(0, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(1642, 100);
            titlePanel.TabIndex = 0;
            titlePanel.Paint += panel1_Paint;
            // 
            // titleText
            // 
            titleText.Dock = DockStyle.Fill;
            titleText.Font = new Font("Roboto", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleText.Location = new Point(0, 0);
            titleText.Margin = new Padding(0);
            titleText.Name = "titleText";
            titleText.Size = new Size(1642, 100);
            titleText.TabIndex = 2;
            titleText.Text = "Kho hàng";
            titleText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nhapHangPage
            // 
            nhapHangPage.AutoScroll = true;
            nhapHangPage.Controls.Add(HeaderPanel);
            nhapHangPage.Controls.Add(NhapHangPagePanel);
            nhapHangPage.Controls.Add(NhapHangCardList);
            nhapHangPage.Controls.Add(NhapHangToolBar);
            nhapHangPage.Location = new Point(4, 48);
            nhapHangPage.Margin = new Padding(0);
            nhapHangPage.Name = "nhapHangPage";
            nhapHangPage.Size = new Size(1645, 1348);
            nhapHangPage.TabIndex = 1;
            nhapHangPage.Text = "Nhập hàng";
            nhapHangPage.UseVisualStyleBackColor = true;
            // 
            // HeaderPanel
            // 
            HeaderPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            HeaderPanel.AutoSize = true;
            HeaderPanel.ColumnCount = 2;
            HeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            HeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            HeaderPanel.Controls.Add(Title, 0, 0);
            HeaderPanel.Controls.Add(AddButton, 1, 0);
            HeaderPanel.Location = new Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.RowCount = 1;
            HeaderPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            HeaderPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            HeaderPanel.Size = new Size(1645, 97);
            HeaderPanel.TabIndex = 5;
            // 
            // Title
            // 
            Title.Dock = DockStyle.Fill;
            Title.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(3, 0);
            Title.Name = "Title";
            Title.Padding = new Padding(20, 0, 0, 0);
            Title.Size = new Size(816, 97);
            Title.TabIndex = 0;
            Title.Text = "Nhập hàng";
            Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.Black;
            AddButton.Cursor = Cursors.Hand;
            AddButton.Dock = DockStyle.Right;
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(1384, 0);
            AddButton.Margin = new Padding(0, 0, 40, 0);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(221, 97);
            AddButton.TabIndex = 1;
            AddButton.Text = "+ Thêm";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click_1;
            // 
            // NhapHangPagePanel
            // 
            NhapHangPagePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NhapHangPagePanel.AutoSize = true;
            NhapHangPagePanel.Controls.Add(NhapHangExtraNext);
            NhapHangPagePanel.Controls.Add(NhapHangExtraPrevious);
            NhapHangPagePanel.Controls.Add(NhapHangNext);
            NhapHangPagePanel.Controls.Add(NhapHangPrevious);
            NhapHangPagePanel.Location = new Point(0, 1246);
            NhapHangPagePanel.Margin = new Padding(0);
            NhapHangPagePanel.Name = "NhapHangPagePanel";
            NhapHangPagePanel.Size = new Size(1645, 102);
            NhapHangPagePanel.TabIndex = 4;
            // 
            // NhapHangExtraNext
            // 
            NhapHangExtraNext.Anchor = AnchorStyles.None;
            NhapHangExtraNext.BackColor = Color.Transparent;
            NhapHangExtraNext.Cursor = Cursors.Hand;
            NhapHangExtraNext.Image = (Image)resources.GetObject("NhapHangExtraNext.Image");
            NhapHangExtraNext.Location = new Point(932, 19);
            NhapHangExtraNext.Name = "NhapHangExtraNext";
            NhapHangExtraNext.Size = new Size(75, 69);
            NhapHangExtraNext.TabIndex = 16;
            NhapHangExtraNext.TextImageRelation = TextImageRelation.ImageAboveText;
            NhapHangExtraNext.UseVisualStyleBackColor = false;
            // 
            // NhapHangExtraPrevious
            // 
            NhapHangExtraPrevious.Anchor = AnchorStyles.None;
            NhapHangExtraPrevious.BackColor = Color.Transparent;
            NhapHangExtraPrevious.Cursor = Cursors.Hand;
            NhapHangExtraPrevious.ForeColor = Color.Transparent;
            NhapHangExtraPrevious.Image = (Image)resources.GetObject("NhapHangExtraPrevious.Image");
            NhapHangExtraPrevious.Location = new Point(605, 19);
            NhapHangExtraPrevious.Name = "NhapHangExtraPrevious";
            NhapHangExtraPrevious.Size = new Size(75, 69);
            NhapHangExtraPrevious.TabIndex = 13;
            NhapHangExtraPrevious.TextImageRelation = TextImageRelation.ImageAboveText;
            NhapHangExtraPrevious.UseVisualStyleBackColor = false;
            // 
            // NhapHangNext
            // 
            NhapHangNext.Anchor = AnchorStyles.None;
            NhapHangNext.BackColor = Color.Transparent;
            NhapHangNext.Cursor = Cursors.Hand;
            NhapHangNext.Image = (Image)resources.GetObject("NhapHangNext.Image");
            NhapHangNext.Location = new Point(823, 19);
            NhapHangNext.Name = "NhapHangNext";
            NhapHangNext.Size = new Size(75, 69);
            NhapHangNext.TabIndex = 15;
            NhapHangNext.TextImageRelation = TextImageRelation.ImageAboveText;
            NhapHangNext.UseVisualStyleBackColor = false;
            // 
            // NhapHangPrevious
            // 
            NhapHangPrevious.Anchor = AnchorStyles.None;
            NhapHangPrevious.BackColor = Color.Transparent;
            NhapHangPrevious.Cursor = Cursors.Hand;
            NhapHangPrevious.Image = (Image)resources.GetObject("NhapHangPrevious.Image");
            NhapHangPrevious.Location = new Point(714, 19);
            NhapHangPrevious.Name = "NhapHangPrevious";
            NhapHangPrevious.Size = new Size(75, 69);
            NhapHangPrevious.TabIndex = 14;
            NhapHangPrevious.TextImageRelation = TextImageRelation.ImageAboveText;
            NhapHangPrevious.UseVisualStyleBackColor = false;
            // 
            // NhapHangCardList
            // 
            NhapHangCardList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NhapHangCardList.AutoSize = true;
            NhapHangCardList.BackColor = Color.FromArgb(239, 248, 230);
            NhapHangCardList.ColumnCount = 4;
            NhapHangCardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            NhapHangCardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            NhapHangCardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            NhapHangCardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            NhapHangCardList.Controls.Add(NhapHangCard, 0, 0);
            NhapHangCardList.Location = new Point(0, 222);
            NhapHangCardList.Margin = new Padding(0);
            NhapHangCardList.Name = "NhapHangCardList";
            NhapHangCardList.RowCount = 2;
            NhapHangCardList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            NhapHangCardList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            NhapHangCardList.Size = new Size(1645, 1024);
            NhapHangCardList.TabIndex = 3;
            // 
            // NhapHangCard
            // 
            NhapHangCard.AutoSize = true;
            NhapHangCard.BackColor = Color.FromArgb(200, 250, 214);
            NhapHangCard.Controls.Add(NhapHangButtonCard);
            NhapHangCard.Controls.Add(NhapHangBodyCard);
            NhapHangCard.Controls.Add(NhapHangTitleCard);
            NhapHangCard.Dock = DockStyle.Fill;
            NhapHangCard.Location = new Point(15, 15);
            NhapHangCard.Margin = new Padding(15);
            NhapHangCard.Name = "NhapHangCard";
            NhapHangCard.Size = new Size(381, 482);
            NhapHangCard.TabIndex = 0;
            // 
            // NhapHangButtonCard
            // 
            NhapHangButtonCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NhapHangButtonCard.BackColor = Color.Black;
            NhapHangButtonCard.Cursor = Cursors.Hand;
            NhapHangButtonCard.Font = new Font("Roboto Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NhapHangButtonCard.ForeColor = Color.White;
            NhapHangButtonCard.Location = new Point(64, 373);
            NhapHangButtonCard.Margin = new Padding(0);
            NhapHangButtonCard.Name = "NhapHangButtonCard";
            NhapHangButtonCard.Size = new Size(252, 74);
            NhapHangButtonCard.TabIndex = 6;
            NhapHangButtonCard.Text = "Xem chi tiết";
            NhapHangButtonCard.UseVisualStyleBackColor = false;
            NhapHangButtonCard.Click += NhapHangButtonCard_Click_1;
            // 
            // NhapHangBodyCard
            // 
            NhapHangBodyCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NhapHangBodyCard.Font = new Font("Roboto SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NhapHangBodyCard.Location = new Point(0, 89);
            NhapHangBodyCard.Name = "NhapHangBodyCard";
            NhapHangBodyCard.Size = new Size(379, 284);
            NhapHangBodyCard.TabIndex = 2;
            NhapHangBodyCard.Text = "Nhân viên: 0001\r\nNhà cung cấp: 0001\r\nSố lượng: 100\r\nTổng tiền: 10.000.000đ";
            NhapHangBodyCard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NhapHangTitleCard
            // 
            NhapHangTitleCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NhapHangTitleCard.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NhapHangTitleCard.Location = new Point(0, 2);
            NhapHangTitleCard.Margin = new Padding(0);
            NhapHangTitleCard.Name = "NhapHangTitleCard";
            NhapHangTitleCard.Size = new Size(379, 87);
            NhapHangTitleCard.TabIndex = 1;
            NhapHangTitleCard.Text = "NH0001";
            NhapHangTitleCard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NhapHangToolBar
            // 
            NhapHangToolBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NhapHangToolBar.BackColor = Color.FromArgb(0, 120, 103);
            NhapHangToolBar.ColumnCount = 6;
            NhapHangToolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.0795383F));
            NhapHangToolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.1469336F));
            NhapHangToolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.78992F));
            NhapHangToolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.4615383F));
            NhapHangToolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.33846F));
            NhapHangToolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.075289F));
            NhapHangToolBar.Controls.Add(NhapHangEndDate, 4, 0);
            NhapHangToolBar.Controls.Add(NhapHangEnd, 3, 0);
            NhapHangToolBar.Controls.Add(NhapHangSearchbar, 0, 0);
            NhapHangToolBar.Controls.Add(NhapHangStartDate, 2, 0);
            NhapHangToolBar.Controls.Add(NhapHangStart, 1, 0);
            NhapHangToolBar.Controls.Add(NhapHangFilterButton, 5, 0);
            NhapHangToolBar.Location = new Point(0, 100);
            NhapHangToolBar.Margin = new Padding(0);
            NhapHangToolBar.Name = "NhapHangToolBar";
            NhapHangToolBar.Padding = new Padding(10);
            NhapHangToolBar.RowCount = 1;
            NhapHangToolBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            NhapHangToolBar.Size = new Size(1645, 122);
            NhapHangToolBar.TabIndex = 2;
            // 
            // NhapHangEndDate
            // 
            NhapHangEndDate.Anchor = AnchorStyles.None;
            NhapHangEndDate.Cursor = Cursors.Hand;
            NhapHangEndDate.DropDownAlign = LeftRightAlignment.Right;
            NhapHangEndDate.Font = new Font("Roboto Medium", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NhapHangEndDate.Format = DateTimePickerFormat.Short;
            NhapHangEndDate.Location = new Point(1214, 33);
            NhapHangEndDate.Margin = new Padding(0, 0, 10, 0);
            NhapHangEndDate.Name = "NhapHangEndDate";
            NhapHangEndDate.ShowUpDown = true;
            NhapHangEndDate.Size = new Size(268, 56);
            NhapHangEndDate.TabIndex = 3;
            // 
            // NhapHangEnd
            // 
            NhapHangEnd.AutoSize = true;
            NhapHangEnd.Dock = DockStyle.Fill;
            NhapHangEnd.Font = new Font("Roboto Condensed", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NhapHangEnd.ForeColor = Color.White;
            NhapHangEnd.Location = new Point(979, 10);
            NhapHangEnd.Margin = new Padding(10, 0, 0, 0);
            NhapHangEnd.Name = "NhapHangEnd";
            NhapHangEnd.Size = new Size(225, 102);
            NhapHangEnd.TabIndex = 3;
            NhapHangEnd.Text = "Ngày kết thúc:";
            NhapHangEnd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NhapHangSearchbar
            // 
            NhapHangSearchbar.Anchor = AnchorStyles.None;
            NhapHangSearchbar.Cursor = Cursors.IBeam;
            NhapHangSearchbar.Font = new Font("Roboto Medium", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NhapHangSearchbar.Location = new Point(24, 35);
            NhapHangSearchbar.Margin = new Padding(0, 0, 10, 0);
            NhapHangSearchbar.Name = "NhapHangSearchbar";
            NhapHangSearchbar.PlaceholderText = "value...";
            NhapHangSearchbar.Size = new Size(401, 52);
            NhapHangSearchbar.TabIndex = 1;
            // 
            // NhapHangStartDate
            // 
            NhapHangStartDate.Anchor = AnchorStyles.None;
            NhapHangStartDate.Cursor = Cursors.Hand;
            NhapHangStartDate.DropDownAlign = LeftRightAlignment.Right;
            NhapHangStartDate.Font = new Font("Roboto Medium", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NhapHangStartDate.Format = DateTimePickerFormat.Short;
            NhapHangStartDate.Location = new Point(689, 33);
            NhapHangStartDate.Margin = new Padding(0, 0, 10, 0);
            NhapHangStartDate.MaxDate = new DateTime(9998, 10, 1, 0, 0, 0, 0);
            NhapHangStartDate.Name = "NhapHangStartDate";
            NhapHangStartDate.ShowUpDown = true;
            NhapHangStartDate.Size = new Size(260, 56);
            NhapHangStartDate.TabIndex = 2;
            NhapHangStartDate.Value = new DateTime(2025, 10, 1, 0, 0, 0, 0);
            // 
            // NhapHangStart
            // 
            NhapHangStart.Anchor = AnchorStyles.None;
            NhapHangStart.AutoSize = true;
            NhapHangStart.Font = new Font("Roboto", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NhapHangStart.ForeColor = Color.White;
            NhapHangStart.Location = new Point(450, 40);
            NhapHangStart.Margin = new Padding(0);
            NhapHangStart.Name = "NhapHangStart";
            NhapHangStart.Size = new Size(229, 41);
            NhapHangStart.TabIndex = 2;
            NhapHangStart.Text = "Ngày bắt đầu:";
            NhapHangStart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NhapHangFilterButton
            // 
            NhapHangFilterButton.BackColor = Color.FromArgb(0, 120, 103);
            NhapHangFilterButton.Cursor = Cursors.Hand;
            NhapHangFilterButton.Dock = DockStyle.Fill;
            NhapHangFilterButton.Image = Image.FromFile(Application.StartupPath + @"\Img\Icon\Filter.png");
            NhapHangFilterButton.Location = new Point(1502, 10);
            NhapHangFilterButton.Margin = new Padding(0);
            NhapHangFilterButton.Name = "NhapHangFilterButton";
            NhapHangFilterButton.Size = new Size(133, 102);
            NhapHangFilterButton.TabIndex = 4;
            NhapHangFilterButton.UseVisualStyleBackColor = false;
            NhapHangFilterButton.Click += NhapHangFilterButton_Click;
            NhapHangFilterButton.MouseEnter += filterButton_MouseEnter;
            NhapHangFilterButton.MouseLeave += filterButton_MouseLeave;
            // 
            // storageGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(tabPane);
            Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(0);
            Name = "storageGUI";
            Size = new Size(1653, 1400);
            Load += storageGUI_Load;
            tabPane.ResumeLayout(false);
            khoHangPage.ResumeLayout(false);
            khoHangPage.PerformLayout();
            pageButtonPanel.ResumeLayout(false);
            toolBar.ResumeLayout(false);
            toolBar.PerformLayout();
            titlePanel.ResumeLayout(false);
            nhapHangPage.ResumeLayout(false);
            nhapHangPage.PerformLayout();
            HeaderPanel.ResumeLayout(false);
            NhapHangPagePanel.ResumeLayout(false);
            NhapHangCardList.ResumeLayout(false);
            NhapHangCardList.PerformLayout();
            NhapHangCard.ResumeLayout(false);
            NhapHangToolBar.ResumeLayout(false);
            NhapHangToolBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPane;
        private TabPage khoHangPage;
        private TabPage nhapHangPage;
        private TableLayoutPanel toolBar;
        private TextBox searchBar;
        private DateTimePicker startDate;
        private Label startText;
        private Label endText;
        private DateTimePicker endDate;
        private TableLayoutPanel cardList;
        private Panel titlePanel;
        private Label titleText;
        private Panel pageButtonPanel;
        private Button previousButton;
        private Button nextButton;
        private Button extraNextButton;
        private Button extraPreviousButton;
        private Button filterButton;
        private TableLayoutPanel NhapHangToolBar;
        private DateTimePicker NhapHangEndDate;
        private Label NhapHangEnd;
        private TextBox NhapHangSearchbar;
        private DateTimePicker NhapHangStartDate;
        private Label NhapHangStart;
        private Button NhapHangFilterButton;
        private TableLayoutPanel NhapHangCardList;
        private Panel NhapHangCard;
        private Panel NhapHangPagePanel;
        private Button NhapHangExtraNext;
        private Button NhapHangExtraPrevious;
        private Button NhapHangNext;
        private Button NhapHangPrevious;
        private Button NhapHangButtonCard;
        private Label NhapHangBodyCard;
        private Label NhapHangTitleCard;
        private TableLayoutPanel HeaderPanel;
        private Label Title;
        private Button AddButton;
        private Button Reset;
    }
}