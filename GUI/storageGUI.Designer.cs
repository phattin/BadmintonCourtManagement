using GUI.ComponentsGUI;

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
            cardList = new RoundedTableLayoutPanel();
            toolBar = new RoundedTableLayoutPanel();
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
            supplyPagination = new Panel();
            supplyExtraNext = new Button();
            supplyExtraPrevious = new Button();
            supplyNext = new Button();
            supplyPrevious = new Button();
            supplyCardList = new RoundedTableLayoutPanel();
            supplyToolBar = new RoundedTableLayoutPanel();
            supplyReset = new Button();
            supplyEndDate = new DateTimePicker();
            supplyEndLabel = new Label();
            supplySearchBar = new TextBox();
            supplyStartDate = new DateTimePicker();
            supplyStartLabel = new Label();
            supplyFilter = new Button();
            supplyTitlePanel = new TableLayoutPanel();
            supplyTitle = new Label();
            supplyAdd = new RoundedButton();
            tabPane.SuspendLayout();
            khoHangPage.SuspendLayout();
            pageButtonPanel.SuspendLayout();
            toolBar.SuspendLayout();
            titlePanel.SuspendLayout();
            nhapHangPage.SuspendLayout();
            supplyPagination.SuspendLayout();
            supplyToolBar.SuspendLayout();
            supplyTitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // tabPane
            // 
            tabPane.Controls.Add(khoHangPage);
            tabPane.Controls.Add(nhapHangPage);
            tabPane.Dock = DockStyle.Fill;
            tabPane.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            tabPane.Location = new Point(0, 0);
            tabPane.Margin = new Padding(0);
            tabPane.Name = "tabPane";
            tabPane.SelectedIndex = 0;
            tabPane.Size = new Size(1049, 602);
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
            khoHangPage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            khoHangPage.Location = new Point(4, 34);
            khoHangPage.Margin = new Padding(0);
            khoHangPage.Name = "khoHangPage";
            khoHangPage.Padding = new Padding(26, 0, 26, 0);
            khoHangPage.Size = new Size(1041, 564);
            khoHangPage.TabIndex = 0;
            khoHangPage.Text = "Kho hàng";
            khoHangPage.Click += tabPage1_Click;
            // 
            // pageButtonPanel
            // 
            pageButtonPanel.Controls.Add(extraNextButton);
            pageButtonPanel.Controls.Add(extraPreviousButton);
            pageButtonPanel.Controls.Add(nextButton);
            pageButtonPanel.Controls.Add(previousButton);
            pageButtonPanel.Dock = DockStyle.Bottom;
            pageButtonPanel.Location = new Point(26, 503);
            pageButtonPanel.Margin = new Padding(0);
            pageButtonPanel.Name = "pageButtonPanel";
            pageButtonPanel.Size = new Size(989, 61);
            pageButtonPanel.TabIndex = 3;
            // 
            // extraNextButton
            // 
            extraNextButton.Anchor = AnchorStyles.None;
            extraNextButton.BackColor = Color.Transparent;
            extraNextButton.Cursor = Cursors.Hand;
            extraNextButton.FlatAppearance.BorderSize = 0;
            extraNextButton.FlatStyle = FlatStyle.Flat;
            extraNextButton.Image = (Image)resources.GetObject("extraNextButton.Image");
            extraNextButton.Location = new Point(583, 10);
            extraNextButton.Margin = new Padding(2);
            extraNextButton.Name = "extraNextButton";
            extraNextButton.Size = new Size(52, 44);
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
            extraPreviousButton.FlatAppearance.BorderSize = 0;
            extraPreviousButton.FlatStyle = FlatStyle.Flat;
            extraPreviousButton.ForeColor = Color.Transparent;
            extraPreviousButton.Image = (Image)resources.GetObject("extraPreviousButton.Image");
            extraPreviousButton.Location = new Point(352, 10);
            extraPreviousButton.Margin = new Padding(0);
            extraPreviousButton.Name = "extraPreviousButton";
            extraPreviousButton.Size = new Size(52, 44);
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
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Image = (Image)resources.GetObject("nextButton.Image");
            nextButton.Location = new Point(504, 10);
            nextButton.Margin = new Padding(2);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(52, 44);
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
            previousButton.FlatAppearance.BorderSize = 0;
            previousButton.FlatStyle = FlatStyle.Flat;
            previousButton.Image = (Image)resources.GetObject("previousButton.Image");
            previousButton.Location = new Point(430, 10);
            previousButton.Margin = new Padding(2);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(52, 44);
            previousButton.TabIndex = 14;
            previousButton.TextImageRelation = TextImageRelation.ImageAboveText;
            previousButton.UseVisualStyleBackColor = false;
            previousButton.Click += previousButton_Click;
            // 
            // cardList
            // 
            cardList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cardList.BackColor = Color.FromArgb(239, 248, 230);
            cardList.BorderRadius = 20;
            cardList.ColumnCount = 4;
            cardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            cardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            cardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            cardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            cardList.Font = new Font("Segoe UI", 11F);
            cardList.Location = new Point(26, 106);
            cardList.Margin = new Padding(0);
            cardList.Name = "cardList";
            cardList.RowCount = 2;
            cardList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            cardList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            cardList.Size = new Size(990, 402);
            cardList.TabIndex = 2;
            // 
            // toolBar
            // 
            toolBar.BackColor = Color.FromArgb(0, 120, 103);
            toolBar.BorderRadius = 20;
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
            toolBar.Dock = DockStyle.Top;
            toolBar.Font = new Font("Segoe UI", 9F);
            toolBar.Location = new Point(26, 43);
            toolBar.Margin = new Padding(0);
            toolBar.Name = "toolBar";
            toolBar.Padding = new Padding(7, 6, 7, 6);
            toolBar.RowCount = 1;
            toolBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            toolBar.Size = new Size(989, 64);
            toolBar.TabIndex = 1;
            toolBar.Paint += tableLayoutPanel1_Paint;
            // 
            // Reset
            // 
            Reset.BackColor = Color.FromArgb(0, 120, 103);
            Reset.Cursor = Cursors.Hand;
            Reset.Dock = DockStyle.Fill;
            Reset.FlatAppearance.BorderSize = 0;
            Reset.FlatStyle = FlatStyle.Flat;
            Reset.Image = Properties.Resources.Reset;
            Reset.Location = new Point(896, 6);
            Reset.Margin = new Padding(0);
            Reset.Name = "Reset";
            Reset.Size = new Size(86, 52);
            Reset.TabIndex = 5;
            Reset.UseVisualStyleBackColor = false;
            Reset.Click += Reset_Click;
            // 
            // endDate
            // 
            endDate.Cursor = Cursors.Hand;
            endDate.CustomFormat = "dd/MM/yyyy";
            endDate.Dock = DockStyle.Fill;
            endDate.DropDownAlign = LeftRightAlignment.Right;
            endDate.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            endDate.Format = DateTimePickerFormat.Custom;
            endDate.Location = new Point(652, 17);
            endDate.Margin = new Padding(0, 11, 7, 0);
            endDate.Name = "endDate";
            endDate.ShowUpDown = true;
            endDate.Size = new Size(154, 32);
            endDate.TabIndex = 3;
            // 
            // endText
            // 
            endText.AutoSize = true;
            endText.Dock = DockStyle.Fill;
            endText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            endText.ForeColor = Color.White;
            endText.Location = new Point(532, 6);
            endText.Margin = new Padding(7, 0, 0, 0);
            endText.Name = "endText";
            endText.Size = new Size(120, 52);
            endText.TabIndex = 3;
            endText.Text = "Ngày kết thúc:";
            endText.TextAlign = ContentAlignment.MiddleCenter;
            endText.Click += label3_Click;
            // 
            // searchBar
            // 
            searchBar.Cursor = Cursors.IBeam;
            searchBar.Dock = DockStyle.Fill;
            searchBar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            searchBar.Location = new Point(7, 17);
            searchBar.Margin = new Padding(0, 11, 7, 0);
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = "Tìm kiếm...";
            searchBar.Size = new Size(231, 32);
            searchBar.TabIndex = 1;
            searchBar.TextChanged += textBox1_TextChanged;
            searchBar.KeyDown += searchEnterEvent;
            // 
            // startDate
            // 
            startDate.Cursor = Cursors.Hand;
            startDate.CustomFormat = "dd/MM/yyyy";
            startDate.Dock = DockStyle.Fill;
            startDate.DropDownAlign = LeftRightAlignment.Right;
            startDate.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            startDate.Format = DateTimePickerFormat.Custom;
            startDate.Location = new Point(369, 17);
            startDate.Margin = new Padding(0, 11, 7, 0);
            startDate.MaxDate = new DateTime(9998, 10, 1, 0, 0, 0, 0);
            startDate.Name = "startDate";
            startDate.ShowUpDown = true;
            startDate.Size = new Size(149, 32);
            startDate.TabIndex = 2;
            startDate.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            startDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // startText
            // 
            startText.AutoSize = true;
            startText.Dock = DockStyle.Fill;
            startText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            startText.ForeColor = Color.White;
            startText.Location = new Point(245, 6);
            startText.Margin = new Padding(0);
            startText.Name = "startText";
            startText.Size = new Size(124, 52);
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
            filterButton.FlatAppearance.BorderSize = 0;
            filterButton.FlatStyle = FlatStyle.Flat;
            filterButton.Image = Properties.Resources.Filter;
            filterButton.Location = new Point(813, 6);
            filterButton.Margin = new Padding(0);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(83, 52);
            filterButton.TabIndex = 4;
            filterButton.UseVisualStyleBackColor = false;
            filterButton.Click += filterButton_Click;
            filterButton.MouseEnter += filterButton_MouseEnter;
            filterButton.MouseLeave += filterButton_MouseLeave;
            // 
            // titlePanel
            // 
            titlePanel.Controls.Add(titleText);
            titlePanel.Dock = DockStyle.Top;
            titlePanel.Location = new Point(26, 0);
            titlePanel.Margin = new Padding(0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(989, 43);
            titlePanel.TabIndex = 0;
            titlePanel.Paint += panel1_Paint;
            // 
            // titleText
            // 
            titleText.Dock = DockStyle.Fill;
            titleText.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            titleText.Location = new Point(0, 0);
            titleText.Margin = new Padding(0);
            titleText.Name = "titleText";
            titleText.Size = new Size(989, 43);
            titleText.TabIndex = 2;
            titleText.Text = "Kho hàng";
            titleText.TextAlign = ContentAlignment.MiddleLeft;
            titleText.Click += titleText_Click;
            // 
            // nhapHangPage
            // 
            nhapHangPage.AutoScroll = true;
            nhapHangPage.Controls.Add(supplyPagination);
            nhapHangPage.Controls.Add(supplyCardList);
            nhapHangPage.Controls.Add(supplyToolBar);
            nhapHangPage.Controls.Add(supplyTitlePanel);
            nhapHangPage.Location = new Point(4, 34);
            nhapHangPage.Margin = new Padding(0);
            nhapHangPage.Name = "nhapHangPage";
            nhapHangPage.Padding = new Padding(26, 0, 26, 0);
            nhapHangPage.Size = new Size(1041, 564);
            nhapHangPage.TabIndex = 1;
            nhapHangPage.Text = "Nhập hàng";
            nhapHangPage.UseVisualStyleBackColor = true;
            // 
            // supplyPagination
            // 
            supplyPagination.Controls.Add(supplyExtraNext);
            supplyPagination.Controls.Add(supplyExtraPrevious);
            supplyPagination.Controls.Add(supplyNext);
            supplyPagination.Controls.Add(supplyPrevious);
            supplyPagination.Dock = DockStyle.Bottom;
            supplyPagination.Location = new Point(26, 503);
            supplyPagination.Margin = new Padding(0);
            supplyPagination.Name = "supplyPagination";
            supplyPagination.Size = new Size(989, 61);
            supplyPagination.TabIndex = 4;
            // 
            // supplyExtraNext
            // 
            supplyExtraNext.Anchor = AnchorStyles.None;
            supplyExtraNext.BackColor = Color.Transparent;
            supplyExtraNext.Cursor = Cursors.Hand;
            supplyExtraNext.FlatAppearance.BorderSize = 0;
            supplyExtraNext.FlatStyle = FlatStyle.Flat;
            supplyExtraNext.Image = (Image)resources.GetObject("supplyExtraNext.Image");
            supplyExtraNext.Location = new Point(579, 9);
            supplyExtraNext.Margin = new Padding(2);
            supplyExtraNext.Name = "supplyExtraNext";
            supplyExtraNext.Size = new Size(52, 44);
            supplyExtraNext.TabIndex = 16;
            supplyExtraNext.TextImageRelation = TextImageRelation.ImageAboveText;
            supplyExtraNext.UseVisualStyleBackColor = false;
            supplyExtraNext.Click += supplyExtraNext_Click;
            // 
            // supplyExtraPrevious
            // 
            supplyExtraPrevious.Anchor = AnchorStyles.None;
            supplyExtraPrevious.BackColor = Color.Transparent;
            supplyExtraPrevious.Cursor = Cursors.Hand;
            supplyExtraPrevious.FlatAppearance.BorderSize = 0;
            supplyExtraPrevious.FlatStyle = FlatStyle.Flat;
            supplyExtraPrevious.ForeColor = Color.Transparent;
            supplyExtraPrevious.Image = (Image)resources.GetObject("supplyExtraPrevious.Image");
            supplyExtraPrevious.Location = new Point(353, 9);
            supplyExtraPrevious.Margin = new Padding(0);
            supplyExtraPrevious.Name = "supplyExtraPrevious";
            supplyExtraPrevious.Size = new Size(52, 44);
            supplyExtraPrevious.TabIndex = 13;
            supplyExtraPrevious.TextImageRelation = TextImageRelation.ImageAboveText;
            supplyExtraPrevious.UseVisualStyleBackColor = false;
            supplyExtraPrevious.Click += supplyExtraPrevious_Click;
            // 
            // supplyNext
            // 
            supplyNext.Anchor = AnchorStyles.None;
            supplyNext.BackColor = Color.Transparent;
            supplyNext.Cursor = Cursors.Hand;
            supplyNext.FlatAppearance.BorderSize = 0;
            supplyNext.FlatStyle = FlatStyle.Flat;
            supplyNext.Image = (Image)resources.GetObject("supplyNext.Image");
            supplyNext.Location = new Point(504, 9);
            supplyNext.Margin = new Padding(2);
            supplyNext.Name = "supplyNext";
            supplyNext.Size = new Size(52, 44);
            supplyNext.TabIndex = 15;
            supplyNext.TextImageRelation = TextImageRelation.ImageAboveText;
            supplyNext.UseVisualStyleBackColor = false;
            supplyNext.Click += supplyNext_Click;
            // 
            // supplyPrevious
            // 
            supplyPrevious.Anchor = AnchorStyles.None;
            supplyPrevious.BackColor = Color.Transparent;
            supplyPrevious.Cursor = Cursors.Hand;
            supplyPrevious.FlatAppearance.BorderSize = 0;
            supplyPrevious.FlatStyle = FlatStyle.Flat;
            supplyPrevious.Image = (Image)resources.GetObject("supplyPrevious.Image");
            supplyPrevious.Location = new Point(429, 9);
            supplyPrevious.Margin = new Padding(2);
            supplyPrevious.Name = "supplyPrevious";
            supplyPrevious.Size = new Size(52, 44);
            supplyPrevious.TabIndex = 14;
            supplyPrevious.TextImageRelation = TextImageRelation.ImageAboveText;
            supplyPrevious.UseVisualStyleBackColor = false;
            supplyPrevious.Click += supplyPrevious_Click;
            // 
            // supplyCardList
            // 
            supplyCardList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            supplyCardList.AutoScroll = true;
            supplyCardList.BackColor = Color.FromArgb(239, 248, 230);
            supplyCardList.BorderRadius = 20;
            supplyCardList.ColumnCount = 4;
            supplyCardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            supplyCardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            supplyCardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            supplyCardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            supplyCardList.Font = new Font("Segoe UI", 11F);
            supplyCardList.Location = new Point(26, 106);
            supplyCardList.Margin = new Padding(0);
            supplyCardList.Name = "supplyCardList";
            supplyCardList.RowCount = 2;
            supplyCardList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            supplyCardList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            supplyCardList.Size = new Size(990, 402);
            supplyCardList.TabIndex = 3;
            // 
            // supplyToolBar
            // 
            supplyToolBar.BackColor = Color.FromArgb(0, 120, 103);
            supplyToolBar.BorderRadius = 20;
            supplyToolBar.ColumnCount = 7;
            supplyToolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.5029163F));
            supplyToolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.8008471F));
            supplyToolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.0972042F));
            supplyToolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.0855179F));
            supplyToolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.59355F));
            supplyToolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.521287F));
            supplyToolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.398679F));
            supplyToolBar.Controls.Add(supplyReset, 6, 0);
            supplyToolBar.Controls.Add(supplyEndDate, 4, 0);
            supplyToolBar.Controls.Add(supplyEndLabel, 3, 0);
            supplyToolBar.Controls.Add(supplySearchBar, 0, 0);
            supplyToolBar.Controls.Add(supplyStartDate, 2, 0);
            supplyToolBar.Controls.Add(supplyStartLabel, 1, 0);
            supplyToolBar.Controls.Add(supplyFilter, 5, 0);
            supplyToolBar.Dock = DockStyle.Top;
            supplyToolBar.Font = new Font("Segoe UI", 9F);
            supplyToolBar.Location = new Point(26, 40);
            supplyToolBar.Margin = new Padding(0);
            supplyToolBar.Name = "supplyToolBar";
            supplyToolBar.Padding = new Padding(7, 6, 7, 6);
            supplyToolBar.RowCount = 1;
            supplyToolBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            supplyToolBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            supplyToolBar.Size = new Size(989, 66);
            supplyToolBar.TabIndex = 2;
            // 
            // supplyReset
            // 
            supplyReset.BackColor = Color.FromArgb(0, 120, 103);
            supplyReset.Cursor = Cursors.Hand;
            supplyReset.Dock = DockStyle.Fill;
            supplyReset.FlatAppearance.BorderSize = 0;
            supplyReset.FlatStyle = FlatStyle.Flat;
            supplyReset.Image = Properties.Resources.Reset;
            supplyReset.Location = new Point(896, 6);
            supplyReset.Margin = new Padding(0);
            supplyReset.Name = "supplyReset";
            supplyReset.Size = new Size(86, 54);
            supplyReset.TabIndex = 5;
            supplyReset.UseVisualStyleBackColor = false;
            supplyReset.Click += supplyReset_Click;
            supplyReset.MouseEnter += filterButton_MouseEnter;
            supplyReset.MouseHover += filterButton_MouseLeave;
            // 
            // supplyEndDate
            // 
            supplyEndDate.Cursor = Cursors.Hand;
            supplyEndDate.CustomFormat = "dd/MM/yyyy";
            supplyEndDate.Dock = DockStyle.Fill;
            supplyEndDate.DropDownAlign = LeftRightAlignment.Right;
            supplyEndDate.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            supplyEndDate.Format = DateTimePickerFormat.Custom;
            supplyEndDate.Location = new Point(652, 17);
            supplyEndDate.Margin = new Padding(0, 11, 7, 0);
            supplyEndDate.Name = "supplyEndDate";
            supplyEndDate.ShowUpDown = true;
            supplyEndDate.Size = new Size(154, 32);
            supplyEndDate.TabIndex = 3;
            // 
            // supplyEndLabel
            // 
            supplyEndLabel.AutoSize = true;
            supplyEndLabel.Dock = DockStyle.Fill;
            supplyEndLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            supplyEndLabel.ForeColor = Color.White;
            supplyEndLabel.Location = new Point(532, 6);
            supplyEndLabel.Margin = new Padding(7, 0, 0, 0);
            supplyEndLabel.Name = "supplyEndLabel";
            supplyEndLabel.Size = new Size(120, 54);
            supplyEndLabel.TabIndex = 3;
            supplyEndLabel.Text = "Ngày kết thúc:";
            supplyEndLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // supplySearchBar
            // 
            supplySearchBar.Cursor = Cursors.IBeam;
            supplySearchBar.Dock = DockStyle.Fill;
            supplySearchBar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            supplySearchBar.Location = new Point(7, 17);
            supplySearchBar.Margin = new Padding(0, 11, 7, 0);
            supplySearchBar.Name = "supplySearchBar";
            supplySearchBar.PlaceholderText = "Tìm kiếm...";
            supplySearchBar.Size = new Size(231, 32);
            supplySearchBar.TabIndex = 1;
            supplySearchBar.KeyDown += supplySearchEnterEvent;
            // 
            // supplyStartDate
            // 
            supplyStartDate.Cursor = Cursors.Hand;
            supplyStartDate.CustomFormat = "dd/MM/yyyy";
            supplyStartDate.Dock = DockStyle.Fill;
            supplyStartDate.DropDownAlign = LeftRightAlignment.Right;
            supplyStartDate.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            supplyStartDate.Format = DateTimePickerFormat.Custom;
            supplyStartDate.Location = new Point(369, 17);
            supplyStartDate.Margin = new Padding(0, 11, 7, 0);
            supplyStartDate.MaxDate = new DateTime(9998, 10, 1, 0, 0, 0, 0);
            supplyStartDate.Name = "supplyStartDate";
            supplyStartDate.ShowUpDown = true;
            supplyStartDate.Size = new Size(149, 32);
            supplyStartDate.TabIndex = 2;
            supplyStartDate.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // supplyStartLabel
            // 
            supplyStartLabel.AutoSize = true;
            supplyStartLabel.Dock = DockStyle.Fill;
            supplyStartLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            supplyStartLabel.ForeColor = Color.White;
            supplyStartLabel.Location = new Point(245, 6);
            supplyStartLabel.Margin = new Padding(0);
            supplyStartLabel.Name = "supplyStartLabel";
            supplyStartLabel.Size = new Size(124, 54);
            supplyStartLabel.TabIndex = 2;
            supplyStartLabel.Text = "Ngày bắt đầu:";
            supplyStartLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // supplyFilter
            // 
            supplyFilter.BackColor = Color.FromArgb(0, 120, 103);
            supplyFilter.Cursor = Cursors.Hand;
            supplyFilter.Dock = DockStyle.Fill;
            supplyFilter.FlatAppearance.BorderSize = 0;
            supplyFilter.FlatStyle = FlatStyle.Flat;
            supplyFilter.Image = Properties.Resources.Filter;
            supplyFilter.Location = new Point(813, 6);
            supplyFilter.Margin = new Padding(0);
            supplyFilter.Name = "supplyFilter";
            supplyFilter.Size = new Size(83, 54);
            supplyFilter.TabIndex = 4;
            supplyFilter.UseVisualStyleBackColor = false;
            supplyFilter.Click += supplyFilter_Click;
            supplyFilter.MouseEnter += filterButton_MouseEnter;
            supplyFilter.MouseHover += filterButton_MouseLeave;
            // 
            // supplyTitlePanel
            // 
            supplyTitlePanel.ColumnCount = 2;
            supplyTitlePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            supplyTitlePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            supplyTitlePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            supplyTitlePanel.Controls.Add(supplyTitle, 0, 0);
            supplyTitlePanel.Controls.Add(supplyAdd, 1, 0);
            supplyTitlePanel.Dock = DockStyle.Top;
            supplyTitlePanel.Location = new Point(26, 0);
            supplyTitlePanel.Margin = new Padding(0);
            supplyTitlePanel.Name = "supplyTitlePanel";
            supplyTitlePanel.Padding = new Padding(0, 3, 0, 3);
            supplyTitlePanel.RowCount = 1;
            supplyTitlePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            supplyTitlePanel.Size = new Size(989, 40);
            supplyTitlePanel.TabIndex = 5;
            // 
            // supplyTitle
            // 
            supplyTitle.Dock = DockStyle.Fill;
            supplyTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            supplyTitle.Location = new Point(0, 3);
            supplyTitle.Margin = new Padding(0);
            supplyTitle.Name = "supplyTitle";
            supplyTitle.Size = new Size(494, 34);
            supplyTitle.TabIndex = 3;
            supplyTitle.Text = "Nhập hàng";
            supplyTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // supplyAdd
            // 
            supplyAdd.AutoSize = true;
            supplyAdd.BackColor = Color.Black;
            supplyAdd.BackgroundColor = Color.Black;
            supplyAdd.BorderColor = Color.PaleVioletRed;
            supplyAdd.BorderRadius = 20;
            supplyAdd.BorderSize = 0;
            supplyAdd.Cursor = Cursors.Hand;
            supplyAdd.Dock = DockStyle.Right;
            supplyAdd.FlatStyle = FlatStyle.Flat;
            supplyAdd.ForeColor = Color.White;
            supplyAdd.Location = new Point(873, 3);
            supplyAdd.Margin = new Padding(0, 0, 9, 0);
            supplyAdd.Name = "supplyAdd";
            supplyAdd.Size = new Size(107, 34);
            supplyAdd.TabIndex = 4;
            supplyAdd.Text = "+ Thêm";
            supplyAdd.TextColor = Color.White;
            supplyAdd.UseVisualStyleBackColor = false;
            supplyAdd.Click += supplyAdd_Click;
            supplyAdd.MouseEnter += buttonEnter;
            supplyAdd.MouseLeave += buttonLeave;
            // 
            // storageGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(tabPane);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(0);
            Name = "storageGUI";
            Size = new Size(1049, 602);
            Load += storageGUI_Load;
            tabPane.ResumeLayout(false);
            khoHangPage.ResumeLayout(false);
            pageButtonPanel.ResumeLayout(false);
            toolBar.ResumeLayout(false);
            toolBar.PerformLayout();
            titlePanel.ResumeLayout(false);
            nhapHangPage.ResumeLayout(false);
            supplyPagination.ResumeLayout(false);
            supplyToolBar.ResumeLayout(false);
            supplyToolBar.PerformLayout();
            supplyTitlePanel.ResumeLayout(false);
            supplyTitlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPane;
        private TabPage khoHangPage;
        private TabPage nhapHangPage;
        private RoundedTableLayoutPanel toolBar;
        private DateTimePicker startDate;
        private Label startText;
        private Label endText;
        private DateTimePicker endDate;
        private RoundedTableLayoutPanel cardList;
        private Panel titlePanel;
        private Label titleText;
        private Panel pageButtonPanel;
        private Button previousButton;
        private Button nextButton;
        private Button extraNextButton;
        private Button extraPreviousButton;
        private Button filterButton;
        private Button Reset;
        private TextBox searchBar;
        private RoundedTableLayoutPanel supplyCardList;
        private RoundedTableLayoutPanel supplyToolBar;
        private Button supplyReset;
        private DateTimePicker supplyEndDate;
        private Label supplyEndLabel;
        private TextBox supplySearchBar;
        private DateTimePicker supplyStartDate;
        private Label supplyStartLabel;
        private Button supplyFilter;
        private Panel supplyPagination;
        private Button supplyExtraNext;
        private Button supplyExtraPrevious;
        private Button supplyNext;
        private Button supplyPrevious;
        private TableLayoutPanel supplyTitlePanel;
        private Label supplyTitle;
        private RoundedButton supplyAdd;
    }
}