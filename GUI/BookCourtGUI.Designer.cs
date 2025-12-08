namespace BadmintonCourtManagement.GUI
{
    partial class BookCourtGUI
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

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookCourtGUI));
            draft_panel = new Panel();
            extraNextButton = new Button();
            nextButton = new Button();
            extraPreviousButton = new Button();
            previousButton = new Button();
            lblTitle = new Label();
            customPanel5 = new CustomPanel();
            customPanel4 = new CustomPanel();
            btnTimeFinish = new BadmintonCourtManagement.GUI.ComponentsGUI.TimePicker();
            lbltimeFinish = new Label();
            customPanel1 = new CustomPanel();
            txtSearch = new TextBox();
            customPanel3 = new CustomPanel();
            btnTimeStart = new BadmintonCourtManagement.GUI.ComponentsGUI.TimePicker();
            lbltimeStart = new Label();
            customPanel2 = new CustomPanel();
            dateTimePicker1 = new DateTimePicker();
            lblDate = new Label();
            customPanel7 = new CustomPanel();
            pCourtList = new TableLayoutPanel();
            draft_panel.SuspendLayout();
            customPanel5.SuspendLayout();
            customPanel4.SuspendLayout();
            customPanel1.SuspendLayout();
            customPanel3.SuspendLayout();
            customPanel2.SuspendLayout();
            customPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // draft_panel
            // 
            draft_panel.BackColor = Color.White;
            draft_panel.Controls.Add(extraNextButton);
            draft_panel.Controls.Add(nextButton);
            draft_panel.Controls.Add(extraPreviousButton);
            draft_panel.Controls.Add(previousButton);
            draft_panel.Controls.Add(lblTitle);
            draft_panel.Controls.Add(customPanel5);
            draft_panel.Controls.Add(customPanel7);
            draft_panel.Dock = DockStyle.Fill;
            draft_panel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            draft_panel.Location = new Point(0, 0);
            draft_panel.Name = "draft_panel";
            draft_panel.Size = new Size(901, 653);
            draft_panel.TabIndex = 0;
            draft_panel.TabStop = true;
            draft_panel.Paint += draft_panel_Paint;
            // 
            // extraNextButton
            // 
            extraNextButton.Anchor = AnchorStyles.Bottom;
            extraNextButton.BackColor = Color.Transparent;
            extraNextButton.Cursor = Cursors.Hand;
            extraNextButton.Image = (Image)resources.GetObject("extraNextButton.Image");
            extraNextButton.Location = new Point(534, 589);
            extraNextButton.Margin = new Padding(2);
            extraNextButton.Name = "extraNextButton";
            extraNextButton.Size = new Size(42, 42);
            extraNextButton.TabIndex = 26;
            extraNextButton.TextImageRelation = TextImageRelation.TextAboveImage;
            extraNextButton.UseVisualStyleBackColor = false;
            extraNextButton.Click += extraNextButton_Click;
            // 
            // nextButton
            // 
            nextButton.Anchor = AnchorStyles.Bottom;
            nextButton.BackColor = Color.Transparent;
            nextButton.Cursor = Cursors.Hand;
            nextButton.Image = (Image)resources.GetObject("nextButton.Image");
            nextButton.Location = new Point(474, 589);
            nextButton.Margin = new Padding(2);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(42, 42);
            nextButton.TabIndex = 25;
            nextButton.TextImageRelation = TextImageRelation.TextAboveImage;
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // extraPreviousButton
            // 
            extraPreviousButton.Anchor = AnchorStyles.Bottom;
            extraPreviousButton.BackColor = Color.Transparent;
            extraPreviousButton.Cursor = Cursors.Hand;
            extraPreviousButton.ForeColor = Color.Transparent;
            extraPreviousButton.Image = (Image)resources.GetObject("extraPreviousButton.Image");
            extraPreviousButton.Location = new Point(331, 589);
            extraPreviousButton.Margin = new Padding(2);
            extraPreviousButton.Name = "extraPreviousButton";
            extraPreviousButton.Size = new Size(42, 42);
            extraPreviousButton.TabIndex = 24;
            extraPreviousButton.TextImageRelation = TextImageRelation.TextAboveImage;
            extraPreviousButton.UseVisualStyleBackColor = false;
            extraPreviousButton.Click += extraPreviousButton_Click;
            // 
            // previousButton
            // 
            previousButton.Anchor = AnchorStyles.Bottom;
            previousButton.BackColor = Color.Transparent;
            previousButton.BackgroundImageLayout = ImageLayout.Stretch;
            previousButton.Cursor = Cursors.Hand;
            previousButton.Image = (Image)resources.GetObject("previousButton.Image");
            previousButton.Location = new Point(390, 589);
            previousButton.Margin = new Padding(2);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(42, 42);
            previousButton.TabIndex = 23;
            previousButton.TextImageRelation = TextImageRelation.TextAboveImage;
            previousButton.UseVisualStyleBackColor = false;
            previousButton.Click += previousButton_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(40, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(10, 11, 10, 11);
            lblTitle.Size = new Size(133, 60);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Đặt sân";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.UseWaitCursor = true;
            // 
            // customPanel5
            // 
            customPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel5.BackColor = Color.FromArgb(0, 120, 103);
            customPanel5.BorderRadius = 20;
            customPanel5.Controls.Add(customPanel4);
            customPanel5.Controls.Add(customPanel1);
            customPanel5.Controls.Add(customPanel3);
            customPanel5.Controls.Add(customPanel2);
            customPanel5.Location = new Point(58, 115);
            customPanel5.Margin = new Padding(3, 4, 3, 4);
            customPanel5.Name = "customPanel5";
            customPanel5.Size = new Size(799, 81);
            customPanel5.TabIndex = 11;
            // 
            // customPanel4
            // 
            customPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customPanel4.BackColor = Color.White;
            customPanel4.BorderRadius = 10;
            customPanel4.Controls.Add(btnTimeFinish);
            customPanel4.Controls.Add(lbltimeFinish);
            customPanel4.Location = new Point(654, 21);
            customPanel4.Name = "customPanel4";
            customPanel4.Size = new Size(113, 38);
            customPanel4.TabIndex = 3;
            // 
            // btnTimeFinish
            // 
            btnTimeFinish.Location = new Point(85, 5);
            btnTimeFinish.Margin = new Padding(2);
            btnTimeFinish.Name = "btnTimeFinish";
            btnTimeFinish.SelectedTime = new DateTime(2025, 10, 3, 15, 16, 6, 16);
            btnTimeFinish.Size = new Size(26, 27);
            btnTimeFinish.TabIndex = 10;
            btnTimeFinish.ValueChanged += btnTimeFinish_ValueChanged;
            btnTimeFinish.Load += btnTimeFinish_Load;
            // 
            // lbltimeFinish
            // 
            lbltimeFinish.AutoSize = true;
            lbltimeFinish.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltimeFinish.Location = new Point(3, 10);
            lbltimeFinish.Name = "lbltimeFinish";
            lbltimeFinish.Size = new Size(77, 17);
            lbltimeFinish.TabIndex = 2;
            lbltimeFinish.Text = "Giờ kết thúc";
            lbltimeFinish.Click += lbltimeFinish_Click;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(txtSearch);
            customPanel1.Location = new Point(21, 21);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(247, 38);
            customPanel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(12, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Value";
            txtSearch.Size = new Size(125, 20);
            txtSearch.TabIndex = 0;
            txtSearch.KeyDown += TxtSearch_KeyDown;
            // 
            // customPanel3
            // 
            customPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customPanel3.BackColor = Color.White;
            customPanel3.BorderRadius = 10;
            customPanel3.Controls.Add(btnTimeStart);
            customPanel3.Controls.Add(lbltimeStart);
            customPanel3.Location = new Point(518, 21);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(113, 38);
            customPanel3.TabIndex = 2;
            // 
            // btnTimeStart
            // 
            btnTimeStart.Location = new Point(81, 8);
            btnTimeStart.Margin = new Padding(2);
            btnTimeStart.Name = "btnTimeStart";
            btnTimeStart.SelectedTime = new DateTime(2025, 10, 3, 15, 16, 6, 16);
            btnTimeStart.Size = new Size(25, 27);
            btnTimeStart.TabIndex = 9;
            btnTimeStart.ValueChanged += btnTimeStart_ValueChanged;
            btnTimeStart.Load += btnTimeStart_Load;
            // 
            // lbltimeStart
            // 
            lbltimeStart.AutoSize = true;
            lbltimeStart.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltimeStart.Location = new Point(3, 10);
            lbltimeStart.Name = "lbltimeStart";
            lbltimeStart.Size = new Size(77, 17);
            lbltimeStart.TabIndex = 2;
            lbltimeStart.Text = "Giờ bắt đầu";
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 10;
            customPanel2.Controls.Add(dateTimePicker1);
            customPanel2.Controls.Add(lblDate);
            customPanel2.Location = new Point(388, 21);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(113, 38);
            customPanel2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(88, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(22, 27);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(3, 10);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(39, 17);
            lblDate.TabIndex = 2;
            lblDate.Text = "Ngày";
            // 
            // customPanel7
            // 
            customPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customPanel7.BackColor = Color.FromArgb(239, 248, 230);
            customPanel7.BorderRadius = 20;
            customPanel7.Controls.Add(pCourtList);
            customPanel7.Location = new Point(58, 115);
            customPanel7.Margin = new Padding(3, 4, 3, 4);
            customPanel7.Name = "customPanel7";
            customPanel7.Size = new Size(799, 455);
            customPanel7.TabIndex = 12;
            // 
            // pCourtList
            // 
            pCourtList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pCourtList.ColumnCount = 4;
            pCourtList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCourtList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCourtList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCourtList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCourtList.Location = new Point(21, 103);
            pCourtList.Margin = new Padding(2);
            pCourtList.Name = "pCourtList";
            pCourtList.RowCount = 2;
            pCourtList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pCourtList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pCourtList.Size = new Size(752, 328);
            pCourtList.TabIndex = 0;
            pCourtList.Paint += pCourtList_Paint;
            // 
            // BookCourtGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(draft_panel);
            Name = "BookCourtGUI";
            Size = new Size(901, 653);
            draft_panel.ResumeLayout(false);
            draft_panel.PerformLayout();
            customPanel5.ResumeLayout(false);
            customPanel4.ResumeLayout(false);
            customPanel4.PerformLayout();
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            customPanel3.ResumeLayout(false);
            customPanel3.PerformLayout();
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            customPanel7.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion


        private Panel draft_panel;
        private Label lblTitle;
        private TableLayoutPanel pCourtList;
        private CustomPanel customPanel5;
        private CustomPanel customPanel4;
        private ComponentsGUI.TimePicker btnTimeFinish;
        private Label lbltimeFinish;
        private CustomPanel customPanel1;
        private TextBox txtSearch;
        private CustomPanel customPanel3;
        private ComponentsGUI.TimePicker btnTimeStart;
        private Label lbltimeStart;
        private CustomPanel customPanel2;
        private DateTimePicker dateTimePicker1;
        private Label lblDate;
        private CustomPanel customPanel7;
        private Button extraNextButton;
        private Button nextButton;
        private Button extraPreviousButton;
        private Button previousButton;
    }
}