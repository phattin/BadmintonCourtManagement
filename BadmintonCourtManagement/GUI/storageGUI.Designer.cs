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
            panel25 = new Panel();
            panel26 = new Panel();
            label13 = new Label();
            panel27 = new Panel();
            button7 = new Button();
            panel28 = new Panel();
            label14 = new Label();
            panel21 = new Panel();
            panel22 = new Panel();
            label11 = new Label();
            panel23 = new Panel();
            button6 = new Button();
            panel24 = new Panel();
            label12 = new Label();
            panel17 = new Panel();
            panel18 = new Panel();
            label9 = new Label();
            panel19 = new Panel();
            button5 = new Button();
            panel20 = new Panel();
            label10 = new Label();
            panel13 = new Panel();
            panel14 = new Panel();
            label7 = new Label();
            panel15 = new Panel();
            button4 = new Button();
            panel16 = new Panel();
            label8 = new Label();
            panel9 = new Panel();
            panel10 = new Panel();
            label5 = new Label();
            panel11 = new Panel();
            button3 = new Button();
            panel12 = new Panel();
            label6 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            label3 = new Label();
            panel7 = new Panel();
            button2 = new Button();
            panel8 = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            label2 = new Label();
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
            tabPane.SuspendLayout();
            khoHangPage.SuspendLayout();
            pageButtonPanel.SuspendLayout();
            cardList.SuspendLayout();
            panel25.SuspendLayout();
            panel26.SuspendLayout();
            panel27.SuspendLayout();
            panel28.SuspendLayout();
            panel21.SuspendLayout();
            panel22.SuspendLayout();
            panel23.SuspendLayout();
            panel24.SuspendLayout();
            panel17.SuspendLayout();
            panel18.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            card.SuspendLayout();
            cardBodyPanel.SuspendLayout();
            cardButtonPanel.SuspendLayout();
            cardTitlePanel.SuspendLayout();
            toolBar.SuspendLayout();
            titlePanel.SuspendLayout();
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
            tabPane.Size = new Size(1653, 1055);
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
            khoHangPage.Size = new Size(1645, 1003);
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
            pageButtonPanel.Location = new Point(0, 912);
            pageButtonPanel.Margin = new Padding(0);
            pageButtonPanel.Name = "pageButtonPanel";
            pageButtonPanel.Size = new Size(1642, 91);
            pageButtonPanel.TabIndex = 3;
            // 
            // extraNextButton
            // 
            extraNextButton.Anchor = AnchorStyles.None;
            extraNextButton.BackColor = Color.Transparent;
            extraNextButton.Cursor = Cursors.Hand;
            extraNextButton.Image = (Image)resources.GetObject("extraNextButton.Image");
            extraNextButton.Location = new Point(948, 12);
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
            extraPreviousButton.Location = new Point(618, 12);
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
            nextButton.Location = new Point(836, 12);
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
            previousButton.Location = new Point(731, 12);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(75, 69);
            previousButton.TabIndex = 14;
            previousButton.TextImageRelation = TextImageRelation.ImageAboveText;
            previousButton.UseVisualStyleBackColor = false;
            // 
            // cardList
            // 
            cardList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cardList.AutoScroll = true;
            cardList.BackColor = Color.FromArgb(239, 248, 230);
            cardList.ColumnCount = 4;
            cardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            cardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            cardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            cardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            cardList.Controls.Add(panel25, 3, 1);
            cardList.Controls.Add(panel21, 2, 1);
            cardList.Controls.Add(panel17, 1, 1);
            cardList.Controls.Add(panel13, 0, 1);
            cardList.Controls.Add(panel9, 3, 0);
            cardList.Controls.Add(panel5, 2, 0);
            cardList.Controls.Add(panel1, 1, 0);
            cardList.Controls.Add(card, 0, 0);
            cardList.Location = new Point(0, 246);
            cardList.Margin = new Padding(0);
            cardList.Name = "cardList";
            cardList.RowCount = 2;
            cardList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            cardList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            cardList.Size = new Size(1642, 663);
            cardList.TabIndex = 2;
            // 
            // panel25
            // 
            panel25.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel25.AutoSize = true;
            panel25.BackColor = Color.FromArgb(200, 250, 214);
            panel25.Controls.Add(panel26);
            panel25.Controls.Add(panel27);
            panel25.Controls.Add(panel28);
            panel25.Location = new Point(1245, 346);
            panel25.Margin = new Padding(15);
            panel25.Name = "panel25";
            panel25.Size = new Size(382, 302);
            panel25.TabIndex = 7;
            // 
            // panel26
            // 
            panel26.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel26.AutoSize = true;
            panel26.Controls.Add(label13);
            panel26.Location = new Point(4, 74);
            panel26.Margin = new Padding(0);
            panel26.Name = "panel26";
            panel26.Size = new Size(373, 169);
            panel26.TabIndex = 2;
            // 
            // label13
            // 
            label13.Dock = DockStyle.Fill;
            label13.Font = new Font("Roboto SemiBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(0, 0);
            label13.Name = "label13";
            label13.Size = new Size(373, 169);
            label13.TabIndex = 0;
            label13.Text = "ID: 0001\r\nSL: 100\r\nGiá: 100.000đ";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel27
            // 
            panel27.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel27.AutoSize = true;
            panel27.Controls.Add(button7);
            panel27.Location = new Point(62, 249);
            panel27.Margin = new Padding(20, 0, 0, 0);
            panel27.Name = "panel27";
            panel27.Size = new Size(253, 53);
            panel27.TabIndex = 1;
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.Cursor = Cursors.Hand;
            button7.Dock = DockStyle.Fill;
            button7.Font = new Font("Roboto Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(0, 0);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(253, 53);
            button7.TabIndex = 12;
            button7.Text = "Xem chi tiết";
            button7.UseVisualStyleBackColor = false;
            button7.MouseEnter += buttonEnter;
            button7.MouseLeave += buttonLeave;
            // 
            // panel28
            // 
            panel28.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel28.AutoSize = true;
            panel28.Controls.Add(label14);
            panel28.Location = new Point(4, 0);
            panel28.Margin = new Padding(0);
            panel28.Name = "panel28";
            panel28.Size = new Size(373, 74);
            panel28.TabIndex = 0;
            // 
            // label14
            // 
            label14.Dock = DockStyle.Fill;
            label14.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(0, 0);
            label14.Margin = new Padding(0);
            label14.Name = "label14";
            label14.Size = new Size(373, 74);
            label14.TabIndex = 0;
            label14.Text = "KH0001";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel21
            // 
            panel21.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel21.AutoSize = true;
            panel21.BackColor = Color.FromArgb(200, 250, 214);
            panel21.Controls.Add(panel22);
            panel21.Controls.Add(panel23);
            panel21.Controls.Add(panel24);
            panel21.Location = new Point(835, 346);
            panel21.Margin = new Padding(15);
            panel21.Name = "panel21";
            panel21.Size = new Size(380, 302);
            panel21.TabIndex = 6;
            // 
            // panel22
            // 
            panel22.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel22.AutoSize = true;
            panel22.Controls.Add(label11);
            panel22.Location = new Point(4, 74);
            panel22.Margin = new Padding(0);
            panel22.Name = "panel22";
            panel22.Size = new Size(372, 169);
            panel22.TabIndex = 2;
            // 
            // label11
            // 
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Roboto SemiBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(372, 169);
            label11.TabIndex = 0;
            label11.Text = "ID: 0001\r\nSL: 100\r\nGiá: 100.000đ";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel23
            // 
            panel23.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel23.AutoSize = true;
            panel23.Controls.Add(button6);
            panel23.Location = new Point(62, 249);
            panel23.Margin = new Padding(20, 0, 0, 0);
            panel23.Name = "panel23";
            panel23.Size = new Size(266, 53);
            panel23.TabIndex = 1;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.Cursor = Cursors.Hand;
            button6.Dock = DockStyle.Fill;
            button6.Font = new Font("Roboto Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(0, 0);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(266, 53);
            button6.TabIndex = 11;
            button6.Text = "Xem chi tiết";
            button6.UseVisualStyleBackColor = false;
            button6.MouseEnter += buttonEnter;
            button6.MouseLeave += buttonLeave;
            // 
            // panel24
            // 
            panel24.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel24.AutoSize = true;
            panel24.Controls.Add(label12);
            panel24.Location = new Point(4, 0);
            panel24.Margin = new Padding(0);
            panel24.Name = "panel24";
            panel24.Size = new Size(372, 74);
            panel24.TabIndex = 0;
            // 
            // label12
            // 
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(0, 0);
            label12.Margin = new Padding(0);
            label12.Name = "label12";
            label12.Size = new Size(372, 74);
            label12.TabIndex = 0;
            label12.Text = "KH0001";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel17
            // 
            panel17.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel17.AutoSize = true;
            panel17.BackColor = Color.FromArgb(200, 250, 214);
            panel17.Controls.Add(panel18);
            panel17.Controls.Add(panel19);
            panel17.Controls.Add(panel20);
            panel17.Location = new Point(425, 346);
            panel17.Margin = new Padding(15);
            panel17.Name = "panel17";
            panel17.Size = new Size(380, 302);
            panel17.TabIndex = 5;
            // 
            // panel18
            // 
            panel18.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel18.AutoSize = true;
            panel18.Controls.Add(label9);
            panel18.Location = new Point(4, 74);
            panel18.Margin = new Padding(0);
            panel18.Name = "panel18";
            panel18.Size = new Size(373, 169);
            panel18.TabIndex = 2;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Roboto SemiBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(373, 169);
            label9.TabIndex = 0;
            label9.Text = "ID: 0001\r\nSL: 100\r\nGiá: 100.000đ";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel19
            // 
            panel19.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel19.AutoSize = true;
            panel19.Controls.Add(button5);
            panel19.Location = new Point(61, 249);
            panel19.Margin = new Padding(20, 0, 0, 0);
            panel19.Name = "panel19";
            panel19.Size = new Size(257, 53);
            panel19.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.Cursor = Cursors.Hand;
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Roboto Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(0, 0);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(257, 53);
            button5.TabIndex = 10;
            button5.Text = "Xem chi tiết";
            button5.UseVisualStyleBackColor = false;
            button5.MouseEnter += buttonEnter;
            button5.MouseLeave += buttonLeave;
            // 
            // panel20
            // 
            panel20.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel20.AutoSize = true;
            panel20.Controls.Add(label10);
            panel20.Location = new Point(4, 0);
            panel20.Margin = new Padding(0);
            panel20.Name = "panel20";
            panel20.Size = new Size(373, 74);
            panel20.TabIndex = 0;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(0, 0);
            label10.Margin = new Padding(0);
            label10.Name = "label10";
            label10.Size = new Size(373, 74);
            label10.TabIndex = 0;
            label10.Text = "KH0001";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            panel13.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel13.AutoSize = true;
            panel13.BackColor = Color.FromArgb(200, 250, 214);
            panel13.Controls.Add(panel14);
            panel13.Controls.Add(panel15);
            panel13.Controls.Add(panel16);
            panel13.Location = new Point(15, 346);
            panel13.Margin = new Padding(15);
            panel13.Name = "panel13";
            panel13.Size = new Size(380, 302);
            panel13.TabIndex = 4;
            // 
            // panel14
            // 
            panel14.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel14.AutoSize = true;
            panel14.Controls.Add(label7);
            panel14.Location = new Point(1, 74);
            panel14.Margin = new Padding(0);
            panel14.Name = "panel14";
            panel14.Size = new Size(376, 169);
            panel14.TabIndex = 2;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Roboto SemiBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(376, 169);
            label7.TabIndex = 0;
            label7.Text = "ID: 0001\r\nSL: 100\r\nGiá: 100.000đ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel15
            // 
            panel15.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel15.AutoSize = true;
            panel15.Controls.Add(button4);
            panel15.Location = new Point(63, 249);
            panel15.Margin = new Padding(20, 0, 0, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(258, 53);
            panel15.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Cursor = Cursors.Hand;
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Roboto Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 0);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(258, 53);
            button4.TabIndex = 9;
            button4.Text = "Xem chi tiết";
            button4.UseVisualStyleBackColor = false;
            button4.MouseEnter += buttonEnter;
            button4.MouseLeave += buttonLeave;
            // 
            // panel16
            // 
            panel16.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel16.AutoSize = true;
            panel16.Controls.Add(label8);
            panel16.Location = new Point(3, 0);
            panel16.Margin = new Padding(0);
            panel16.Name = "panel16";
            panel16.Size = new Size(374, 74);
            panel16.TabIndex = 0;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(0, 0);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(374, 74);
            label8.TabIndex = 0;
            label8.Text = "KH0001";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel9.AutoSize = true;
            panel9.BackColor = Color.FromArgb(200, 250, 214);
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(panel11);
            panel9.Controls.Add(panel12);
            panel9.Location = new Point(1245, 15);
            panel9.Margin = new Padding(15);
            panel9.Name = "panel9";
            panel9.Size = new Size(382, 301);
            panel9.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel10.AutoSize = true;
            panel10.Controls.Add(label5);
            panel10.Location = new Point(4, 78);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(376, 169);
            panel10.TabIndex = 2;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Roboto SemiBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(376, 169);
            label5.TabIndex = 0;
            label5.Text = "ID: 0001\r\nSL: 100\r\nGiá: 100.000đ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel11.AutoSize = true;
            panel11.Controls.Add(button3);
            panel11.Location = new Point(62, 248);
            panel11.Margin = new Padding(20, 0, 0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(253, 53);
            panel11.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Roboto Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(253, 53);
            button3.TabIndex = 8;
            button3.Text = "Xem chi tiết";
            button3.UseVisualStyleBackColor = false;
            button3.MouseEnter += buttonEnter;
            button3.MouseLeave += buttonLeave;
            // 
            // panel12
            // 
            panel12.AutoSize = true;
            panel12.Controls.Add(label6);
            panel12.Location = new Point(4, 4);
            panel12.Margin = new Padding(0);
            panel12.Name = "panel12";
            panel12.Size = new Size(355, 74);
            panel12.TabIndex = 0;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 0);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(355, 74);
            label6.TabIndex = 0;
            label6.Text = "KH0001";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel5.AutoSize = true;
            panel5.BackColor = Color.FromArgb(200, 250, 214);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel8);
            panel5.Location = new Point(835, 15);
            panel5.Margin = new Padding(15);
            panel5.Name = "panel5";
            panel5.Size = new Size(380, 301);
            panel5.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel6.AutoSize = true;
            panel6.Controls.Add(label3);
            panel6.Location = new Point(4, 78);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(372, 169);
            panel6.TabIndex = 2;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Roboto SemiBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(372, 169);
            label3.TabIndex = 0;
            label3.Text = "ID: 0001\r\nSL: 100\r\nGiá: 100.000đ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel7.AutoSize = true;
            panel7.Controls.Add(button2);
            panel7.Location = new Point(62, 248);
            panel7.Margin = new Padding(20, 0, 0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(266, 53);
            panel7.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Roboto Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(266, 53);
            button2.TabIndex = 7;
            button2.Text = "Xem chi tiết";
            button2.UseVisualStyleBackColor = false;
            button2.MouseEnter += buttonEnter;
            button2.MouseLeave += buttonLeave;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel8.AutoSize = true;
            panel8.Controls.Add(label4);
            panel8.Location = new Point(0, 4);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(376, 74);
            panel8.TabIndex = 0;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(376, 74);
            label4.TabIndex = 0;
            label4.Text = "KH0001";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(255, 176, 163);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(425, 15);
            panel1.Margin = new Padding(15);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 300);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 78);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(377, 169);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Roboto SemiBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(377, 169);
            label1.TabIndex = 0;
            label1.Text = "ID: 0001\r\nSL: 0\r\nGiá: 100.000đ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.AutoSize = true;
            panel3.Controls.Add(button1);
            panel3.Location = new Point(61, 247);
            panel3.Margin = new Padding(20, 0, 0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 53);
            panel3.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Roboto Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(257, 53);
            button1.TabIndex = 6;
            button1.Text = "Xem chi tiết";
            button1.UseVisualStyleBackColor = false;
            button1.MouseEnter += buttonEnter;
            button1.MouseLeave += buttonLeave;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoSize = true;
            panel4.Controls.Add(label2);
            panel4.Location = new Point(4, 4);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(373, 74);
            panel4.TabIndex = 0;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(373, 74);
            label2.TabIndex = 0;
            label2.Text = "KH0001";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // card
            // 
            card.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            card.AutoSize = true;
            card.BackColor = Color.FromArgb(200, 250, 214);
            card.Controls.Add(cardBodyPanel);
            card.Controls.Add(cardButtonPanel);
            card.Controls.Add(cardTitlePanel);
            card.Location = new Point(15, 15);
            card.Margin = new Padding(15);
            card.Name = "card";
            card.Size = new Size(380, 300);
            card.TabIndex = 0;
            // 
            // cardBodyPanel
            // 
            cardBodyPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cardBodyPanel.AutoSize = true;
            cardBodyPanel.Controls.Add(cardBody);
            cardBodyPanel.Location = new Point(3, 78);
            cardBodyPanel.Margin = new Padding(0);
            cardBodyPanel.Name = "cardBodyPanel";
            cardBodyPanel.Size = new Size(374, 169);
            cardBodyPanel.TabIndex = 2;
            // 
            // cardBody
            // 
            cardBody.Dock = DockStyle.Fill;
            cardBody.Font = new Font("Roboto SemiBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardBody.Location = new Point(0, 0);
            cardBody.Name = "cardBody";
            cardBody.Size = new Size(374, 169);
            cardBody.TabIndex = 0;
            cardBody.Text = "ID: 0001\r\nSL: 100\r\nGiá: 100.000đ";
            cardBody.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardButtonPanel
            // 
            cardButtonPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cardButtonPanel.AutoSize = true;
            cardButtonPanel.Controls.Add(cardButton);
            cardButtonPanel.Location = new Point(63, 246);
            cardButtonPanel.Margin = new Padding(20, 0, 0, 0);
            cardButtonPanel.Name = "cardButtonPanel";
            cardButtonPanel.Size = new Size(258, 54);
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
            cardButton.Size = new Size(258, 54);
            cardButton.TabIndex = 5;
            cardButton.Text = "Xem chi tiết";
            cardButton.UseVisualStyleBackColor = false;
            cardButton.MouseEnter += buttonEnter;
            cardButton.MouseLeave += buttonLeave;
            // 
            // cardTitlePanel
            // 
            cardTitlePanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cardTitlePanel.AutoSize = true;
            cardTitlePanel.Controls.Add(cardTitle);
            cardTitlePanel.Location = new Point(3, 4);
            cardTitlePanel.Margin = new Padding(0);
            cardTitlePanel.Name = "cardTitlePanel";
            cardTitlePanel.Size = new Size(374, 74);
            cardTitlePanel.TabIndex = 0;
            // 
            // cardTitle
            // 
            cardTitle.Dock = DockStyle.Fill;
            cardTitle.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardTitle.Location = new Point(0, 0);
            cardTitle.Margin = new Padding(0);
            cardTitle.Name = "cardTitle";
            cardTitle.Size = new Size(374, 74);
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
            nhapHangPage.Location = new Point(4, 48);
            nhapHangPage.Margin = new Padding(0);
            nhapHangPage.Name = "nhapHangPage";
            nhapHangPage.Padding = new Padding(10);
            nhapHangPage.Size = new Size(1645, 1003);
            nhapHangPage.TabIndex = 1;
            nhapHangPage.Text = "Nhập hàng";
            nhapHangPage.UseVisualStyleBackColor = true;
            // 
            // storageGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(tabPane);
            Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "storageGUI";
            Size = new Size(1653, 1055);
            Load += storageGUI_Load;
            tabPane.ResumeLayout(false);
            khoHangPage.ResumeLayout(false);
            khoHangPage.PerformLayout();
            pageButtonPanel.ResumeLayout(false);
            cardList.ResumeLayout(false);
            cardList.PerformLayout();
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            panel26.ResumeLayout(false);
            panel27.ResumeLayout(false);
            panel28.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel22.ResumeLayout(false);
            panel23.ResumeLayout(false);
            panel24.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel18.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            card.ResumeLayout(false);
            card.PerformLayout();
            cardBodyPanel.ResumeLayout(false);
            cardButtonPanel.ResumeLayout(false);
            cardTitlePanel.ResumeLayout(false);
            toolBar.ResumeLayout(false);
            toolBar.PerformLayout();
            titlePanel.ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Button button1;
        private Panel panel4;
        private Label label2;
        private Panel panel5;
        private Panel panel6;
        private Label label3;
        private Panel panel7;
        private Button button2;
        private Panel panel8;
        private Label label4;
        private Panel panel9;
        private Panel panel10;
        private Label label5;
        private Panel panel11;
        private Button button3;
        private Panel panel12;
        private Label label6;
        private Panel panel25;
        private Panel panel26;
        private Label label13;
        private Panel panel27;
        private Button button7;
        private Panel panel28;
        private Label label14;
        private Panel panel21;
        private Panel panel22;
        private Label label11;
        private Panel panel23;
        private Button button6;
        private Panel panel24;
        private Label label12;
        private Panel panel17;
        private Panel panel18;
        private Label label9;
        private Panel panel19;
        private Button button5;
        private Panel panel20;
        private Label label10;
        private Panel panel13;
        private Panel panel14;
        private Label label7;
        private Panel panel15;
        private Button button4;
        private Panel panel16;
        private Label label8;
        private Panel pageButtonPanel;
        private Button previousButton;
        private Button nextButton;
        private Button extraNextButton;
        private Button extraPreviousButton;
        private Button filterButton;
    }
}