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
            card = new Panel();
            cardBodyPanel = new Panel();
            cardBody = new Label();
            cardButtonPanel = new Panel();
            cardButton = new Button();
            cardTitlePanel = new Panel();
            cardTitle = new Label();
            toolBar = new TableLayoutPanel();
            endDate = new DateTimePicker();
            endText = new Label();
            searchBar = new TextBox();
            startDate = new DateTimePicker();
            startText = new Label();
            filterButton = new Button();
            titlePanel = new Panel();
            titleText = new Label();
            nhapHangPage = new TabPage();
            NhapHangPagePanel = new Panel();
            NhapHangExtraNext = new Button();
            NhapHangExtraPrevious = new Button();
            NhapHangNext = new Button();
            NhapHangPrevious = new Button();
            NhapHangCardList = new TableLayoutPanel();
            NhapHangCard = new Panel();
            NhapHangBodyCardPanel = new Panel();
            NhapHangBodyCard = new Label();
            NhapHangButtonCardPanel = new Panel();
            NhapHangButtonCard = new Button();
            NhapHangTitleCardPanel = new Panel();
            NhapHangTitleCard = new Label();
            NhapHangToolBar = new TableLayoutPanel();
            NhapHangEndDate = new DateTimePicker();
            NhapHangEnd = new Label();
            NhapHangSearchbar = new TextBox();
            NhapHangStartDate = new DateTimePicker();
            NhapHangStart = new Label();
            NhapHangFilterButton = new Button();
            NhapHangTitlePanel = new Panel();
            NhapHangTitle = new Label();
            tabPane.SuspendLayout();
            khoHangPage.SuspendLayout();
            pageButtonPanel.SuspendLayout();
            cardList.SuspendLayout();
            card.SuspendLayout();
            cardBodyPanel.SuspendLayout();
            cardButtonPanel.SuspendLayout();
            cardTitlePanel.SuspendLayout();
            toolBar.SuspendLayout();
            titlePanel.SuspendLayout();
            nhapHangPage.SuspendLayout();
            NhapHangPagePanel.SuspendLayout();
            NhapHangCardList.SuspendLayout();
            NhapHangCard.SuspendLayout();
            NhapHangBodyCardPanel.SuspendLayout();
            NhapHangButtonCardPanel.SuspendLayout();
            NhapHangTitleCardPanel.SuspendLayout();
            NhapHangToolBar.SuspendLayout();
            NhapHangTitlePanel.SuspendLayout();
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
            cardList.Size = new Size(1642, 1000);
            cardList.TabIndex = 2;
            // 
            // card
            // 
            card.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            card.AutoSize = true;
            card.BackColor = Color.FromArgb(200, 250, 214);
            card.Controls.Add(cardBodyPanel);
            card.Controls.Add(cardButtonPanel);
            card.Controls.Add(cardTitlePanel);
            card.Location = new Point(15, 21);
            card.Margin = new Padding(15);
            card.Name = "card";
            card.Size = new Size(380, 457);
            card.TabIndex = 0;
            // 
            // cardBodyPanel
            // 
            cardBodyPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cardBodyPanel.AutoSize = true;
            cardBodyPanel.Controls.Add(cardBody);
            cardBodyPanel.Location = new Point(3, 126);
            cardBodyPanel.Margin = new Padding(0);
            cardBodyPanel.Name = "cardBodyPanel";
            cardBodyPanel.Size = new Size(374, 230);
            cardBodyPanel.TabIndex = 2;
            // 
            // cardBody
            // 
            cardBody.Dock = DockStyle.Fill;
            cardBody.Font = new Font("Roboto SemiBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardBody.Location = new Point(0, 0);
            cardBody.Name = "cardBody";
            cardBody.Size = new Size(374, 230);
            cardBody.TabIndex = 0;
            cardBody.Text = "ID: 0001\r\nSL: 100\r\nGiá: 100.000đ";
            cardBody.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardButtonPanel
            // 
            cardButtonPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cardButtonPanel.AutoSize = true;
            cardButtonPanel.Controls.Add(cardButton);
            cardButtonPanel.Location = new Point(63, 387);
            cardButtonPanel.Margin = new Padding(20, 0, 0, 0);
            cardButtonPanel.Name = "cardButtonPanel";
            cardButtonPanel.Size = new Size(258, 70);
            cardButtonPanel.TabIndex = 1;
            // 
            // cardButton
            // 
            cardButton.BackColor = Color.Black;
            cardButton.Cursor = Cursors.Hand;
            cardButton.Dock = DockStyle.Fill;
            cardButton.Font = new Font("Roboto Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cardButton.ForeColor = Color.White;
            cardButton.Location = new Point(0, 0);
            cardButton.Margin = new Padding(0);
            cardButton.Name = "cardButton";
            cardButton.Size = new Size(258, 70);
            cardButton.TabIndex = 5;
            cardButton.Text = "Xem chi tiết";
            cardButton.UseVisualStyleBackColor = false;
            cardButton.Click += cardButton_Click;
            cardButton.MouseEnter += buttonEnter;
            cardButton.MouseLeave += buttonLeave;
            // 
            // cardTitlePanel
            // 
            cardTitlePanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cardTitlePanel.AutoSize = true;
            cardTitlePanel.Controls.Add(cardTitle);
            cardTitlePanel.Location = new Point(3, 1);
            cardTitlePanel.Margin = new Padding(0);
            cardTitlePanel.Name = "cardTitlePanel";
            cardTitlePanel.Size = new Size(374, 125);
            cardTitlePanel.TabIndex = 0;
            cardTitlePanel.Paint += cardTitlePanel_Paint;
            // 
            // cardTitle
            // 
            cardTitle.Dock = DockStyle.Fill;
            cardTitle.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardTitle.Location = new Point(0, 0);
            cardTitle.Margin = new Padding(0);
            cardTitle.Name = "cardTitle";
            cardTitle.Size = new Size(374, 125);
            cardTitle.TabIndex = 0;
            cardTitle.Text = "KH0001";
            cardTitle.TextAlign = ContentAlignment.MiddleCenter;
            cardTitle.Click += label4_Click_2;
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
            // endDate
            // 
            endDate.Anchor = AnchorStyles.None;
            endDate.Cursor = Cursors.Hand;
            endDate.DropDownAlign = LeftRightAlignment.Right;
            endDate.Font = new Font("Roboto Medium", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            endDate.Format = DateTimePickerFormat.Short;
            endDate.Location = new Point(1209, 43);
            endDate.Margin = new Padding(0, 0, 10, 0);
            endDate.Name = "endDate";
            endDate.ShowUpDown = true;
            endDate.Size = new Size(268, 56);
            endDate.TabIndex = 3;
            // 
            // endText
            // 
            endText.AutoSize = true;
            endText.Dock = DockStyle.Fill;
            endText.Font = new Font("Roboto Condensed", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            endText.ForeColor = Color.White;
            endText.Location = new Point(976, 10);
            endText.Margin = new Padding(10, 0, 0, 0);
            endText.Name = "endText";
            endText.Size = new Size(224, 123);
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
            searchBar.Location = new Point(24, 45);
            searchBar.Margin = new Padding(0, 0, 10, 0);
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = "value...";
            searchBar.Size = new Size(401, 52);
            searchBar.TabIndex = 1;
            searchBar.TextChanged += textBox1_TextChanged;
            // 
            // startDate
            // 
            startDate.Anchor = AnchorStyles.None;
            startDate.Cursor = Cursors.Hand;
            startDate.DropDownAlign = LeftRightAlignment.Right;
            startDate.Font = new Font("Roboto Medium", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startDate.Format = DateTimePickerFormat.Short;
            startDate.Location = new Point(687, 43);
            startDate.Margin = new Padding(0, 0, 10, 0);
            startDate.MaxDate = new DateTime(9998, 10, 1, 0, 0, 0, 0);
            startDate.Name = "startDate";
            startDate.ShowUpDown = true;
            startDate.Size = new Size(260, 56);
            startDate.TabIndex = 2;
            startDate.Value = new DateTime(2025, 10, 1, 0, 0, 0, 0);
            startDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // startText
            // 
            startText.Anchor = AnchorStyles.None;
            startText.AutoSize = true;
            startText.Font = new Font("Roboto", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startText.ForeColor = Color.White;
            startText.Location = new Point(449, 51);
            startText.Margin = new Padding(0);
            startText.Name = "startText";
            startText.Size = new Size(229, 41);
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
            filterButton.Image = Properties.Resources.Filter;
            filterButton.Location = new Point(1497, 10);
            filterButton.Margin = new Padding(0);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(135, 123);
            filterButton.TabIndex = 4;
            filterButton.UseVisualStyleBackColor = false;
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
            nhapHangPage.Controls.Add(NhapHangPagePanel);
            nhapHangPage.Controls.Add(NhapHangCardList);
            nhapHangPage.Controls.Add(NhapHangToolBar);
            nhapHangPage.Controls.Add(NhapHangTitlePanel);
            nhapHangPage.Location = new Point(4, 48);
            nhapHangPage.Margin = new Padding(0);
            nhapHangPage.Name = "nhapHangPage";
            nhapHangPage.Size = new Size(1645, 1348);
            nhapHangPage.TabIndex = 1;
            nhapHangPage.Text = "Nhập hàng";
            nhapHangPage.UseVisualStyleBackColor = true;
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
            NhapHangCard.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NhapHangCard.AutoSize = true;
            NhapHangCard.BackColor = Color.FromArgb(200, 250, 214);
            NhapHangCard.Controls.Add(NhapHangBodyCardPanel);
            NhapHangCard.Controls.Add(NhapHangButtonCardPanel);
            NhapHangCard.Controls.Add(NhapHangTitleCardPanel);
            NhapHangCard.Location = new Point(15, 22);
            NhapHangCard.Margin = new Padding(15);
            NhapHangCard.Name = "NhapHangCard";
            NhapHangCard.Size = new Size(381, 468);
            NhapHangCard.TabIndex = 0;
            // 
            // NhapHangBodyCardPanel
            // 
            NhapHangBodyCardPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NhapHangBodyCardPanel.AutoSize = true;
            NhapHangBodyCardPanel.Controls.Add(NhapHangBodyCard);
            NhapHangBodyCardPanel.Location = new Point(1, 108);
            NhapHangBodyCardPanel.Margin = new Padding(0);
            NhapHangBodyCardPanel.Name = "NhapHangBodyCardPanel";
            NhapHangBodyCardPanel.Size = new Size(373, 274);
            NhapHangBodyCardPanel.TabIndex = 2;
            // 
            // NhapHangBodyCard
            // 
            NhapHangBodyCard.Dock = DockStyle.Fill;
            NhapHangBodyCard.Font = new Font("Roboto SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NhapHangBodyCard.Location = new Point(0, 0);
            NhapHangBodyCard.Name = "NhapHangBodyCard";
            NhapHangBodyCard.Size = new Size(373, 274);
            NhapHangBodyCard.TabIndex = 0;
            NhapHangBodyCard.Text = "Nhân viên: 0001\r\nNhà cung cấp: 0001\r\nSố lượng: 100\r\nTổng tiền: 10.000.000đ";
            NhapHangBodyCard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NhapHangButtonCardPanel
            // 
            NhapHangButtonCardPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NhapHangButtonCardPanel.AutoSize = true;
            NhapHangButtonCardPanel.Controls.Add(NhapHangButtonCard);
            NhapHangButtonCardPanel.Location = new Point(67, 382);
            NhapHangButtonCardPanel.Margin = new Padding(20, 0, 0, 0);
            NhapHangButtonCardPanel.Name = "NhapHangButtonCardPanel";
            NhapHangButtonCardPanel.Size = new Size(252, 86);
            NhapHangButtonCardPanel.TabIndex = 1;
            // 
            // NhapHangButtonCard
            // 
            NhapHangButtonCard.BackColor = Color.Black;
            NhapHangButtonCard.Cursor = Cursors.Hand;
            NhapHangButtonCard.Dock = DockStyle.Fill;
            NhapHangButtonCard.Font = new Font("Roboto Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NhapHangButtonCard.ForeColor = Color.White;
            NhapHangButtonCard.Location = new Point(0, 0);
            NhapHangButtonCard.Margin = new Padding(0);
            NhapHangButtonCard.Name = "NhapHangButtonCard";
            NhapHangButtonCard.Size = new Size(252, 86);
            NhapHangButtonCard.TabIndex = 5;
            NhapHangButtonCard.Text = "Xem chi tiết";
            NhapHangButtonCard.UseVisualStyleBackColor = false;
            NhapHangButtonCard.Click += NhapHangButtonCard_Click;
            NhapHangButtonCard.MouseEnter += buttonEnter;
            NhapHangButtonCard.MouseLeave += buttonLeave;
            // 
            // NhapHangTitleCardPanel
            // 
            NhapHangTitleCardPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NhapHangTitleCardPanel.AutoSize = true;
            NhapHangTitleCardPanel.Controls.Add(NhapHangTitleCard);
            NhapHangTitleCardPanel.Location = new Point(1, 4);
            NhapHangTitleCardPanel.Margin = new Padding(0);
            NhapHangTitleCardPanel.Name = "NhapHangTitleCardPanel";
            NhapHangTitleCardPanel.Size = new Size(379, 104);
            NhapHangTitleCardPanel.TabIndex = 0;
            // 
            // NhapHangTitleCard
            // 
            NhapHangTitleCard.Dock = DockStyle.Fill;
            NhapHangTitleCard.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NhapHangTitleCard.Location = new Point(0, 0);
            NhapHangTitleCard.Margin = new Padding(0);
            NhapHangTitleCard.Name = "NhapHangTitleCard";
            NhapHangTitleCard.Size = new Size(379, 104);
            NhapHangTitleCard.TabIndex = 0;
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
            NhapHangFilterButton.Image = Properties.Resources.Filter;
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
            // NhapHangTitlePanel
            // 
            NhapHangTitlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NhapHangTitlePanel.AutoSize = true;
            NhapHangTitlePanel.Controls.Add(NhapHangTitle);
            NhapHangTitlePanel.Location = new Point(0, 0);
            NhapHangTitlePanel.Margin = new Padding(0);
            NhapHangTitlePanel.Name = "NhapHangTitlePanel";
            NhapHangTitlePanel.Size = new Size(1645, 100);
            NhapHangTitlePanel.TabIndex = 1;
            // 
            // NhapHangTitle
            // 
            NhapHangTitle.Dock = DockStyle.Fill;
            NhapHangTitle.Font = new Font("Roboto", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NhapHangTitle.Location = new Point(0, 0);
            NhapHangTitle.Margin = new Padding(0);
            NhapHangTitle.Name = "NhapHangTitle";
            NhapHangTitle.Size = new Size(1645, 100);
            NhapHangTitle.TabIndex = 2;
            NhapHangTitle.Text = "Nhập hàng";
            NhapHangTitle.TextAlign = ContentAlignment.MiddleLeft;
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
            cardList.ResumeLayout(false);
            cardList.PerformLayout();
            card.ResumeLayout(false);
            card.PerformLayout();
            cardBodyPanel.ResumeLayout(false);
            cardButtonPanel.ResumeLayout(false);
            cardTitlePanel.ResumeLayout(false);
            toolBar.ResumeLayout(false);
            toolBar.PerformLayout();
            titlePanel.ResumeLayout(false);
            nhapHangPage.ResumeLayout(false);
            nhapHangPage.PerformLayout();
            NhapHangPagePanel.ResumeLayout(false);
            NhapHangCardList.ResumeLayout(false);
            NhapHangCardList.PerformLayout();
            NhapHangCard.ResumeLayout(false);
            NhapHangCard.PerformLayout();
            NhapHangBodyCardPanel.ResumeLayout(false);
            NhapHangButtonCardPanel.ResumeLayout(false);
            NhapHangTitleCardPanel.ResumeLayout(false);
            NhapHangToolBar.ResumeLayout(false);
            NhapHangToolBar.PerformLayout();
            NhapHangTitlePanel.ResumeLayout(false);
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
        private Panel card;
        private Panel cardBodyPanel;
        private Label cardBody;
        private Panel cardButtonPanel;
        private Button cardButton;
        private Panel cardTitlePanel;
        private Label cardTitle;
        private Panel titlePanel;
        private Label titleText;
        private Panel pageButtonPanel;
        private Button previousButton;
        private Button nextButton;
        private Button extraNextButton;
        private Button extraPreviousButton;
        private Button filterButton;
        private Panel NhapHangTitlePanel;
        private Label NhapHangTitle;
        private TableLayoutPanel NhapHangToolBar;
        private DateTimePicker NhapHangEndDate;
        private Label NhapHangEnd;
        private TextBox NhapHangSearchbar;
        private DateTimePicker NhapHangStartDate;
        private Label NhapHangStart;
        private Button NhapHangFilterButton;
        private TableLayoutPanel NhapHangCardList;
        private Panel NhapHangCard;
        private Panel NhapHangBodyCardPanel;
        private Label NhapHangBodyCard;
        private Panel NhapHangButtonCardPanel;
        private Button NhapHangButtonCard;
        private Panel NhapHangTitleCardPanel;
        private Label NhapHangTitleCard;
        private Panel NhapHangPagePanel;
        private Button NhapHangExtraNext;
        private Button NhapHangExtraPrevious;
        private Button NhapHangNext;
        private Button NhapHangPrevious;
    }
}