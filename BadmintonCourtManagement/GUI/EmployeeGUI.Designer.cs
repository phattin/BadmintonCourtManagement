namespace BadmintonCourtManagement.GUI
{
    partial class EmployeeGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeGUI));
            tabPane = new TabControl();
            khoHangPage = new TabPage();
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
            toolBar = new TableLayoutPanel();
            endDate = new DateTimePicker();
            endText = new Label();
            searchBar = new TextBox();
            startDate = new DateTimePicker();
            startText = new Label();
            filterButton = new Button();
            titlePanel = new Panel();
            titleText = new Label();
            tabPane.SuspendLayout();
            khoHangPage.SuspendLayout();
            pageButtonPanel.SuspendLayout();
            cardList.SuspendLayout();
            card.SuspendLayout();
            toolBar.SuspendLayout();
            titlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // tabPane
            // 
            tabPane.Controls.Add(khoHangPage);
            tabPane.Dock = DockStyle.Fill;
            tabPane.Font = new Font("Roboto", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPane.Location = new Point(0, 0);
            tabPane.Margin = new Padding(0);
            tabPane.Name = "tabPane";
            tabPane.SelectedIndex = 0;
            tabPane.Size = new Size(1800, 1400);
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
            khoHangPage.Size = new Size(1792, 1348);
            khoHangPage.TabIndex = 0;
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
            pageButtonPanel.Size = new Size(1789, 102);
            pageButtonPanel.TabIndex = 3;
            // 
            // extraNextButton
            // 
            extraNextButton.Anchor = AnchorStyles.None;
            extraNextButton.BackColor = Color.Transparent;
            extraNextButton.Cursor = Cursors.Hand;
            extraNextButton.Image = (Image)resources.GetObject("extraNextButton.Image");
            extraNextButton.Location = new Point(1021, 18);
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
            extraPreviousButton.Location = new Point(691, 18);
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
            nextButton.Location = new Point(909, 18);
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
            previousButton.Location = new Point(804, 18);
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
            cardButton.Click += cardButton_Click_1;
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
            cardTitle.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            toolBar.Size = new Size(1789, 143);
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
            endDate.Location = new Point(1333, 43);
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
            endText.Location = new Point(1064, 10);
            endText.Margin = new Padding(10, 0, 0, 0);
            endText.Name = "endText";
            endText.Size = new Size(246, 123);
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
            searchBar.Location = new Point(44, 45);
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
            startDate.Location = new Point(761, 43);
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
            startText.Location = new Point(499, 51);
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
            filterButton.Location = new Point(1634, 10);
            filterButton.Margin = new Padding(0);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(145, 123);
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
            titlePanel.Size = new Size(1789, 100);
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
            titleText.Size = new Size(1789, 100);
            titleText.TabIndex = 2;
            titleText.Text = "Nhân viên";
            titleText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EmployeeGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(tabPane);
            Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(0);
            Name = "EmployeeGUI";
            Size = new Size(1800, 1400);
            Load += storageGUI_Load;
            tabPane.ResumeLayout(false);
            khoHangPage.ResumeLayout(false);
            khoHangPage.PerformLayout();
            pageButtonPanel.ResumeLayout(false);
            cardList.ResumeLayout(false);
            cardList.PerformLayout();
            card.ResumeLayout(false);
            toolBar.ResumeLayout(false);
            toolBar.PerformLayout();
            titlePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPane;
        private TabPage khoHangPage;
        private TableLayoutPanel toolBar;
        private TextBox searchBar;
        private DateTimePicker startDate;
        private Label startText;
        private Label endText;
        private DateTimePicker endDate;
        private TableLayoutPanel cardList;
        private Panel card;
        private Panel titlePanel;
        private Label titleText;
        private Panel pageButtonPanel;
        private Button previousButton;
        private Button nextButton;
        private Button extraNextButton;
        private Button extraPreviousButton;
        private Button filterButton;
        private Label cardTitle;
        private Button cardButton;
        private Label cardBody;
    }
}