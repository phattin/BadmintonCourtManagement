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
            customPanel5 = new CustomPanel();
            pCourtList = new TableLayoutPanel();
            customPanel6 = new CustomPanel();
            customPanel1 = new CustomPanel();
            btnDelete = new PictureBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            customPanel4 = new CustomPanel();
            btnTimeFinish = new BadmintonCourtManagement.GUI.ComponentsGUI.TimePicker();
            lbltimeFinish = new Label();
            customPanel7 = new CustomPanel();
            statusFilter = new ComboBox();
            customPanel3 = new CustomPanel();
            btnTimeStart = new BadmintonCourtManagement.GUI.ComponentsGUI.TimePicker();
            lbltimeStart = new Label();
            customPanel2 = new CustomPanel();
            dateTimePicker1 = new DateTimePicker();
            lblDate = new Label();
            lblTitle = new Label();
            draft_panel.SuspendLayout();
            customPanel5.SuspendLayout();
            customPanel6.SuspendLayout();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            customPanel4.SuspendLayout();
            customPanel7.SuspendLayout();
            customPanel3.SuspendLayout();
            customPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // draft_panel
            // 
            draft_panel.BackColor = Color.White;
            draft_panel.Controls.Add(extraNextButton);
            draft_panel.Controls.Add(nextButton);
            draft_panel.Controls.Add(extraPreviousButton);
            draft_panel.Controls.Add(previousButton);
            draft_panel.Controls.Add(customPanel5);
            draft_panel.Controls.Add(lblTitle);
            draft_panel.Dock = DockStyle.Fill;
            draft_panel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            draft_panel.Location = new Point(0, 0);
            draft_panel.Margin = new Padding(3, 2, 3, 2);
            draft_panel.Name = "draft_panel";
            draft_panel.Size = new Size(1088, 574);
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
            extraNextButton.Location = new Point(616, 530);
            extraNextButton.Margin = new Padding(2);
            extraNextButton.Name = "extraNextButton";
            extraNextButton.Size = new Size(37, 32);
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
            nextButton.Location = new Point(563, 530);
            nextButton.Margin = new Padding(2);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(37, 32);
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
            extraPreviousButton.Location = new Point(438, 530);
            extraPreviousButton.Margin = new Padding(2);
            extraPreviousButton.Name = "extraPreviousButton";
            extraPreviousButton.Size = new Size(37, 32);
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
            previousButton.Location = new Point(490, 530);
            previousButton.Margin = new Padding(2);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(37, 32);
            previousButton.TabIndex = 23;
            previousButton.TextImageRelation = TextImageRelation.TextAboveImage;
            previousButton.UseVisualStyleBackColor = false;
            previousButton.Click += previousButton_Click;
            // 
            // customPanel5
            // 
            customPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customPanel5.BackColor = Color.FromArgb(239, 248, 230);
            customPanel5.BorderRadius = 20;
            customPanel5.Controls.Add(pCourtList);
            customPanel5.Controls.Add(customPanel6);
            customPanel5.Location = new Point(45, 77);
            customPanel5.Name = "customPanel5";
            customPanel5.Size = new Size(1003, 439);
            customPanel5.TabIndex = 7;
            // 
            // pCourtList
            // 
            pCourtList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pCourtList.ColumnCount = 4;
            pCourtList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCourtList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCourtList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCourtList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCourtList.Location = new Point(38, 76);
            pCourtList.Margin = new Padding(2);
            pCourtList.Name = "pCourtList";
            pCourtList.RowCount = 2;
            pCourtList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pCourtList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pCourtList.Size = new Size(927, 329);
            pCourtList.TabIndex = 1;
            // 
            // customPanel6
            // 
            customPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel6.BackColor = Color.FromArgb(0, 120, 103);
            customPanel6.BorderRadius = 20;
            customPanel6.Controls.Add(customPanel1);
            customPanel6.Controls.Add(pictureBox1);
            customPanel6.Controls.Add(customPanel4);
            customPanel6.Controls.Add(customPanel7);
            customPanel6.Controls.Add(customPanel3);
            customPanel6.Controls.Add(customPanel2);
            customPanel6.Location = new Point(0, 0);
            customPanel6.Name = "customPanel6";
            customPanel6.Size = new Size(1003, 55);
            customPanel6.TabIndex = 0;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(btnDelete);
            customPanel1.Controls.Add(textBox1);
            customPanel1.Location = new Point(13, 9);
            customPanel1.Margin = new Padding(3, 2, 3, 2);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(455, 38);
            customPanel1.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.X;
            btnDelete.Location = new Point(429, 14);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(11, 10);
            btnDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            btnDelete.TabIndex = 1;
            btnDelete.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(12, 10);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Value";
            textBox1.Size = new Size(397, 16);
            textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1751, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // customPanel4
            // 
            customPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customPanel4.BackColor = Color.White;
            customPanel4.BorderRadius = 10;
            customPanel4.Controls.Add(btnTimeFinish);
            customPanel4.Controls.Add(lbltimeFinish);
            customPanel4.Location = new Point(887, 15);
            customPanel4.Margin = new Padding(3, 2, 3, 2);
            customPanel4.Name = "customPanel4";
            customPanel4.Size = new Size(99, 28);
            customPanel4.TabIndex = 3;
            // 
            // btnTimeFinish
            // 
            btnTimeFinish.Location = new Point(31, 2);
            btnTimeFinish.Margin = new Padding(2);
            btnTimeFinish.Name = "btnTimeFinish";
            btnTimeFinish.SelectedTime = new DateTime(2025, 10, 3, 15, 16, 6, 16);
            btnTimeFinish.Size = new Size(9, 2);
            btnTimeFinish.TabIndex = 10;
            btnTimeFinish.ValueChanged += btnTimeFinish_ValueChanged;
            btnTimeFinish.Load += btnTimeFinish_Load;
            // 
            // lbltimeFinish
            // 
            lbltimeFinish.AutoSize = true;
            lbltimeFinish.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltimeFinish.Location = new Point(3, 8);
            lbltimeFinish.Name = "lbltimeFinish";
            lbltimeFinish.Size = new Size(70, 13);
            lbltimeFinish.TabIndex = 2;
            lbltimeFinish.Text = "Giờ kết thúc";
            // 
            // customPanel7
            // 
            customPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customPanel7.BackColor = Color.White;
            customPanel7.BorderRadius = 10;
            customPanel7.Controls.Add(statusFilter);
            customPanel7.Location = new Point(1573, 16);
            customPanel7.Margin = new Padding(3, 2, 3, 2);
            customPanel7.Name = "customPanel7";
            customPanel7.Size = new Size(149, 23);
            customPanel7.TabIndex = 2;
            // 
            // statusFilter
            // 
            statusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            statusFilter.FormattingEnabled = true;
            statusFilter.Items.AddRange(new object[] { "Hoạt động", "Bảo trì", "Tất cả" });
            statusFilter.Location = new Point(0, 0);
            statusFilter.Name = "statusFilter";
            statusFilter.Size = new Size(149, 23);
            statusFilter.TabIndex = 3;
            // 
            // customPanel3
            // 
            customPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customPanel3.BackColor = Color.White;
            customPanel3.BorderRadius = 10;
            customPanel3.Controls.Add(btnTimeStart);
            customPanel3.Controls.Add(lbltimeStart);
            customPanel3.Location = new Point(747, 15);
            customPanel3.Margin = new Padding(3, 2, 3, 2);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(99, 28);
            customPanel3.TabIndex = 2;
            // 
            // btnTimeStart
            // 
            btnTimeStart.Location = new Point(31, 2);
            btnTimeStart.Margin = new Padding(2);
            btnTimeStart.Name = "btnTimeStart";
            btnTimeStart.SelectedTime = new DateTime(2025, 10, 3, 15, 16, 6, 16);
            btnTimeStart.Size = new Size(9, 2);
            btnTimeStart.TabIndex = 9;
            btnTimeStart.ValueChanged += btnTimeStart_ValueChanged;
            btnTimeStart.Load += btnTimeStart_Load;
            // 
            // lbltimeStart
            // 
            lbltimeStart.AutoSize = true;
            lbltimeStart.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltimeStart.Location = new Point(3, 8);
            lbltimeStart.Name = "lbltimeStart";
            lbltimeStart.Size = new Size(68, 13);
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
            customPanel2.Location = new Point(605, 15);
            customPanel2.Margin = new Padding(3, 2, 3, 2);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(99, 28);
            customPanel2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(77, 4);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(20, 23);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(3, 8);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(33, 13);
            lblDate.TabIndex = 2;
            lblDate.Text = "Ngày";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(35, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(9, 8, 9, 8);
            lblTitle.Size = new Size(105, 46);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Đặt sân";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.UseWaitCursor = true;
            // 
            // BookCourtGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(draft_panel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BookCourtGUI";
            Size = new Size(1088, 574);
            draft_panel.ResumeLayout(false);
            draft_panel.PerformLayout();
            customPanel5.ResumeLayout(false);
            customPanel6.ResumeLayout(false);
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            customPanel4.ResumeLayout(false);
            customPanel4.PerformLayout();
            customPanel7.ResumeLayout(false);
            customPanel3.ResumeLayout(false);
            customPanel3.PerformLayout();
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            ResumeLayout(false);
        }
        #endregion


        private Panel draft_panel;
        private Label lblTitle;
        private DateTimePicker dateTimePicker1;
        private CustomPanel customPanel4;
        private Label lbltimeFinish;
        private CustomPanel customPanel3;
        private Label lbltimeStart;
        private CustomPanel customPanel2;
        private Label lblDate;
        private ComponentsGUI.TimePicker btnTimeStart;
        private ComponentsGUI.TimePicker btnTimeFinish;
        private CustomPanel customPanel5;
        private TableLayoutPanel pCourtList;
        private CustomPanel customPanel6;
        private PictureBox pictureBox1;
        private CustomPanel customPanel7;
        private ComboBox statusFilter;
        private Button extraNextButton;
        private Button nextButton;
        private Button extraPreviousButton;
        private Button previousButton;
        private CustomPanel customPanel1;
        private PictureBox btnDelete;
        private TextBox textBox1;
    }
}