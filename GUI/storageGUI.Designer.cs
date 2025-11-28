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
            tabPane.Size = new Size(1199, 803);
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
            khoHangPage.Location = new Point(4, 40);
            khoHangPage.Margin = new Padding(0);
            khoHangPage.Name = "khoHangPage";
            khoHangPage.Padding = new Padding(30, 0, 30, 0);
            khoHangPage.Size = new Size(1191, 759);
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
            pageButtonPanel.Location = new Point(30, 678);
            pageButtonPanel.Margin = new Padding(0);
            pageButtonPanel.Name = "pageButtonPanel";
            pageButtonPanel.Size = new Size(1131, 81);
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
            extraNextButton.Location = new Point(667, 13);
            extraNextButton.Margin = new Padding(2);
            extraNextButton.Name = "extraNextButton";
            extraNextButton.Size = new Size(60, 58);
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
            extraPreviousButton.Location = new Point(403, 13);
            extraPreviousButton.Margin = new Padding(0);
            extraPreviousButton.Name = "extraPreviousButton";
            extraPreviousButton.Size = new Size(60, 58);
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
            nextButton.Location = new Point(577, 13);
            nextButton.Margin = new Padding(2);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(60, 58);
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
            previousButton.Location = new Point(493, 13);
            previousButton.Margin = new Padding(2);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(60, 58);
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
            cardList.Location = new Point(30, 142);
            cardList.Margin = new Padding(0);
            cardList.Name = "cardList";
            cardList.RowCount = 2;
            cardList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            cardList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            cardList.Size = new Size(1131, 536);
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
            toolBar.Location = new Point(30, 57);
            toolBar.Margin = new Padding(0);
            toolBar.Name = "toolBar";
            toolBar.Padding = new Padding(8);
            toolBar.RowCount = 1;
            toolBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            toolBar.Size = new Size(1131, 85);
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
            Reset.Location = new Point(1027, 8);
            Reset.Margin = new Padding(0);
            Reset.Name = "Reset";
            Reset.Size = new Size(96, 69);
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
            endDate.Location = new Point(747, 23);
            endDate.Margin = new Padding(0, 15, 8, 0);
            endDate.Name = "endDate";
            endDate.ShowUpDown = true;
            endDate.Size = new Size(177, 39);
            endDate.TabIndex = 3;
            // 
            // endText
            // 
            endText.AutoSize = true;
            endText.Dock = DockStyle.Fill;
            endText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            endText.ForeColor = Color.White;
            endText.Location = new Point(610, 8);
            endText.Margin = new Padding(8, 0, 0, 0);
            endText.Name = "endText";
            endText.Size = new Size(137, 69);
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
            searchBar.Location = new Point(8, 23);
            searchBar.Margin = new Padding(0, 15, 8, 0);
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = "Tìm kiếm...";
            searchBar.Size = new Size(265, 39);
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
            startDate.Location = new Point(423, 23);
            startDate.Margin = new Padding(0, 15, 8, 0);
            startDate.MaxDate = new DateTime(9998, 10, 1, 0, 0, 0, 0);
            startDate.Name = "startDate";
            startDate.ShowUpDown = true;
            startDate.Size = new Size(171, 39);
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
            startText.Location = new Point(281, 8);
            startText.Margin = new Padding(0);
            startText.Name = "startText";
            startText.Size = new Size(142, 69);
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
            filterButton.Location = new Point(932, 8);
            filterButton.Margin = new Padding(0);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(95, 69);
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
            titlePanel.Location = new Point(30, 0);
            titlePanel.Margin = new Padding(0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(1131, 57);
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
            titleText.Size = new Size(1131, 57);
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
            nhapHangPage.Location = new Point(4, 40);
            nhapHangPage.Margin = new Padding(0);
            nhapHangPage.Name = "nhapHangPage";
            nhapHangPage.Padding = new Padding(30, 0, 30, 0);
            nhapHangPage.Size = new Size(1191, 759);
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
            supplyPagination.Location = new Point(30, 678);
            supplyPagination.Margin = new Padding(0);
            supplyPagination.Name = "supplyPagination";
            supplyPagination.Size = new Size(1131, 81);
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
            supplyExtraNext.Location = new Point(663, 12);
            supplyExtraNext.Margin = new Padding(2);
            supplyExtraNext.Name = "supplyExtraNext";
            supplyExtraNext.Size = new Size(60, 58);
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
            supplyExtraPrevious.Location = new Point(405, 12);
            supplyExtraPrevious.Margin = new Padding(0);
            supplyExtraPrevious.Name = "supplyExtraPrevious";
            supplyExtraPrevious.Size = new Size(60, 58);
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
            supplyNext.Location = new Point(577, 12);
            supplyNext.Margin = new Padding(2);
            supplyNext.Name = "supplyNext";
            supplyNext.Size = new Size(60, 58);
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
            supplyPrevious.Location = new Point(491, 12);
            supplyPrevious.Margin = new Padding(2);
            supplyPrevious.Name = "supplyPrevious";
            supplyPrevious.Size = new Size(60, 58);
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
            supplyCardList.Location = new Point(30, 142);
            supplyCardList.Margin = new Padding(0);
            supplyCardList.Name = "supplyCardList";
            supplyCardList.RowCount = 2;
            supplyCardList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            supplyCardList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            supplyCardList.Size = new Size(1131, 536);
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
            supplyToolBar.Location = new Point(30, 54);
            supplyToolBar.Margin = new Padding(0);
            supplyToolBar.Name = "supplyToolBar";
            supplyToolBar.Padding = new Padding(8);
            supplyToolBar.RowCount = 1;
            supplyToolBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            supplyToolBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            supplyToolBar.Size = new Size(1131, 88);
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
            supplyReset.Location = new Point(1027, 8);
            supplyReset.Margin = new Padding(0);
            supplyReset.Name = "supplyReset";
            supplyReset.Size = new Size(96, 72);
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
            supplyEndDate.Location = new Point(747, 23);
            supplyEndDate.Margin = new Padding(0, 15, 8, 0);
            supplyEndDate.Name = "supplyEndDate";
            supplyEndDate.ShowUpDown = true;
            supplyEndDate.Size = new Size(177, 39);
            supplyEndDate.TabIndex = 3;
            // 
            // supplyEndLabel
            // 
            supplyEndLabel.AutoSize = true;
            supplyEndLabel.Dock = DockStyle.Fill;
            supplyEndLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            supplyEndLabel.ForeColor = Color.White;
            supplyEndLabel.Location = new Point(610, 8);
            supplyEndLabel.Margin = new Padding(8, 0, 0, 0);
            supplyEndLabel.Name = "supplyEndLabel";
            supplyEndLabel.Size = new Size(137, 72);
            supplyEndLabel.TabIndex = 3;
            supplyEndLabel.Text = "Ngày kết thúc:";
            supplyEndLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // supplySearchBar
            // 
            supplySearchBar.Cursor = Cursors.IBeam;
            supplySearchBar.Dock = DockStyle.Fill;
            supplySearchBar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            supplySearchBar.Location = new Point(8, 23);
            supplySearchBar.Margin = new Padding(0, 15, 8, 0);
            supplySearchBar.Name = "supplySearchBar";
            supplySearchBar.PlaceholderText = "Tìm kiếm...";
            supplySearchBar.Size = new Size(265, 39);
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
            supplyStartDate.Location = new Point(423, 23);
            supplyStartDate.Margin = new Padding(0, 15, 8, 0);
            supplyStartDate.MaxDate = new DateTime(9998, 10, 1, 0, 0, 0, 0);
            supplyStartDate.Name = "supplyStartDate";
            supplyStartDate.ShowUpDown = true;
            supplyStartDate.Size = new Size(171, 39);
            supplyStartDate.TabIndex = 2;
            supplyStartDate.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // supplyStartLabel
            // 
            supplyStartLabel.AutoSize = true;
            supplyStartLabel.Dock = DockStyle.Fill;
            supplyStartLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            supplyStartLabel.ForeColor = Color.White;
            supplyStartLabel.Location = new Point(281, 8);
            supplyStartLabel.Margin = new Padding(0);
            supplyStartLabel.Name = "supplyStartLabel";
            supplyStartLabel.Size = new Size(142, 72);
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
            supplyFilter.Location = new Point(932, 8);
            supplyFilter.Margin = new Padding(0);
            supplyFilter.Name = "supplyFilter";
            supplyFilter.Size = new Size(95, 72);
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
            supplyTitlePanel.Controls.Add(supplyTitle, 0, 0);
            supplyTitlePanel.Controls.Add(supplyAdd, 1, 0);
            supplyTitlePanel.Dock = DockStyle.Top;
            supplyTitlePanel.Location = new Point(30, 0);
            supplyTitlePanel.Margin = new Padding(0);
            supplyTitlePanel.Name = "supplyTitlePanel";
            supplyTitlePanel.Padding = new Padding(0, 4, 0, 4);
            supplyTitlePanel.RowCount = 1;
            supplyTitlePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            supplyTitlePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            supplyTitlePanel.Size = new Size(1131, 54);
            supplyTitlePanel.TabIndex = 5;
            // 
            // supplyTitle
            // 
            supplyTitle.Dock = DockStyle.Fill;
            supplyTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            supplyTitle.Location = new Point(0, 4);
            supplyTitle.Margin = new Padding(0);
            supplyTitle.Name = "supplyTitle";
            supplyTitle.Size = new Size(565, 46);
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
            supplyAdd.Location = new Point(999, 4);
            supplyAdd.Margin = new Padding(0, 0, 10, 0);
            supplyAdd.Name = "supplyAdd";
            supplyAdd.Size = new Size(122, 46);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(tabPane);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(0);
            Name = "storageGUI";
            Size = new Size(1199, 803);
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