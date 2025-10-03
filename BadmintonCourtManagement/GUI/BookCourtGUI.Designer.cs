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
            draft_panel = new Panel();
            pFilter = new CustomPanel();
            customPanel4 = new CustomPanel();
            btnTimeFinish = new BadmintonCourtManagement.GUI.ComponentsGUI.TimePicker();
            lbltimeFinish = new Label();
            customPanel3 = new CustomPanel();
            btnTimeStart = new BadmintonCourtManagement.GUI.ComponentsGUI.TimePicker();
            lbltimeStart = new Label();
            customPanel2 = new CustomPanel();
            dateTimePicker1 = new DateTimePicker();
            lblDate = new Label();
            customPanel1 = new CustomPanel();
            btnDelete = new PictureBox();
            textBox1 = new TextBox();
            lblTitle = new Label();
            btnBooking = new Label();
            pCourtList = new FlowLayoutPanel();
            draft_panel.SuspendLayout();
            pFilter.SuspendLayout();
            customPanel4.SuspendLayout();
            customPanel3.SuspendLayout();
            customPanel2.SuspendLayout();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
            SuspendLayout();
            // 
            // draft_panel
            // 
            draft_panel.BackColor = Color.White;
            draft_panel.Controls.Add(pFilter);
            draft_panel.Controls.Add(lblTitle);
            draft_panel.Controls.Add(btnBooking);
            draft_panel.Controls.Add(pCourtList);
            draft_panel.Dock = DockStyle.Fill;
            draft_panel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            draft_panel.Location = new Point(0, 0);
            draft_panel.Margin = new Padding(4);
            draft_panel.Name = "draft_panel";
            draft_panel.Size = new Size(1126, 816);
            draft_panel.TabIndex = 0;
            draft_panel.Paint += draft_panel_Paint;
            // 
            // pFilter
            // 
            pFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pFilter.BackColor = Color.FromArgb(217, 217, 217);
            pFilter.BorderRadius = 10;
            pFilter.Controls.Add(customPanel4);
            pFilter.Controls.Add(customPanel3);
            pFilter.Controls.Add(customPanel2);
            pFilter.Controls.Add(customPanel1);
            pFilter.Location = new Point(72, 166);
            pFilter.Margin = new Padding(4);
            pFilter.Name = "pFilter";
            pFilter.Size = new Size(1000, 84);
            pFilter.TabIndex = 5;
            pFilter.Paint += pFilter_Paint;
            // 
            // customPanel4
            // 
            customPanel4.BackColor = Color.White;
            customPanel4.BorderRadius = 10;
            customPanel4.Controls.Add(btnTimeFinish);
            customPanel4.Controls.Add(lbltimeFinish);
            customPanel4.Location = new Point(824, 20);
            customPanel4.Margin = new Padding(4);
            customPanel4.Name = "customPanel4";
            customPanel4.Size = new Size(141, 48);
            customPanel4.TabIndex = 3;
            // 
            // btnTimeFinish
            // 
            btnTimeFinish.Location = new Point(110, 10);
            btnTimeFinish.Name = "btnTimeFinish";
            btnTimeFinish.SelectedTime = new DateTime(2025, 10, 3, 15, 20, 6, 16);
            btnTimeFinish.Size = new Size(25, 27);
            btnTimeFinish.TabIndex = 10;
            btnTimeFinish.ValueChanged += btnTimeFinish_ValueChanged;
            btnTimeFinish.Load += btnTimeFinish_Load;
            // 
            // lbltimeFinish
            // 
            lbltimeFinish.AutoSize = true;
            lbltimeFinish.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltimeFinish.Location = new Point(4, 12);
            lbltimeFinish.Margin = new Padding(4, 0, 4, 0);
            lbltimeFinish.Name = "lbltimeFinish";
            lbltimeFinish.Size = new Size(94, 21);
            lbltimeFinish.TabIndex = 2;
            lbltimeFinish.Text = "Giờ kết thúc";
            // 
            // customPanel3
            // 
            customPanel3.BackColor = Color.White;
            customPanel3.BorderRadius = 10;
            customPanel3.Controls.Add(btnTimeStart);
            customPanel3.Controls.Add(lbltimeStart);
            customPanel3.Location = new Point(654, 20);
            customPanel3.Margin = new Padding(4);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(141, 48);
            customPanel3.TabIndex = 2;
            // 
            // btnTimeStart
            // 
            btnTimeStart.Location = new Point(113, 10);
            btnTimeStart.Name = "btnTimeStart";
            btnTimeStart.SelectedTime = new DateTime(2025, 10, 3, 15, 20, 6, 16);
            btnTimeStart.Size = new Size(25, 27);
            btnTimeStart.TabIndex = 9;
            btnTimeStart.ValueChanged += btnTimeStart_ValueChanged;
            btnTimeStart.Load += btnTimeStart_Load;
            // 
            // lbltimeStart
            // 
            lbltimeStart.AutoSize = true;
            lbltimeStart.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltimeStart.Location = new Point(4, 12);
            lbltimeStart.Margin = new Padding(4, 0, 4, 0);
            lbltimeStart.Name = "lbltimeStart";
            lbltimeStart.Size = new Size(91, 21);
            lbltimeStart.TabIndex = 2;
            lbltimeStart.Text = "Giờ bắt đầu";
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 10;
            customPanel2.Controls.Add(dateTimePicker1);
            customPanel2.Controls.Add(lblDate);
            customPanel2.Location = new Point(491, 20);
            customPanel2.Margin = new Padding(4);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(141, 48);
            customPanel2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(110, 6);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(26, 31);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(4, 12);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(47, 21);
            lblDate.TabIndex = 2;
            lblDate.Text = "Ngày";
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(btnDelete);
            customPanel1.Controls.Add(textBox1);
            customPanel1.Location = new Point(32, 20);
            customPanel1.Margin = new Padding(4);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(309, 48);
            customPanel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.X;
            btnDelete.Location = new Point(274, 12);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(16, 18);
            btnDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            btnDelete.TabIndex = 1;
            btnDelete.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(15, 10);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Value";
            textBox1.Size = new Size(156, 30);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(50, 44);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(12, 14, 12, 14);
            lblTitle.Size = new Size(156, 73);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Đặt sân";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.UseWaitCursor = true;
            // 
            // btnBooking
            // 
            btnBooking.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBooking.AutoSize = true;
            btnBooking.BackColor = Color.FromArgb(64, 64, 64);
            btnBooking.Cursor = Cursors.Hand;
            btnBooking.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooking.ForeColor = Color.White;
            btnBooking.Location = new Point(919, 44);
            btnBooking.Margin = new Padding(4, 0, 4, 0);
            btnBooking.Name = "btnBooking";
            btnBooking.Padding = new Padding(12, 14, 12, 16);
            btnBooking.Size = new Size(147, 62);
            btnBooking.TabIndex = 3;
            btnBooking.Text = "Thêm sân";
            btnBooking.TextAlign = ContentAlignment.MiddleCenter;
            btnBooking.Click += btnBooking_Click;
            // 
            // pCourtList
            // 
            pCourtList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pCourtList.BackColor = Color.Gray;
            pCourtList.Location = new Point(70, 336);
            pCourtList.Name = "pCourtList";
            pCourtList.Size = new Size(1002, 453);
            pCourtList.TabIndex = 1;
            pCourtList.Paint += pCourtList_Paint;
            pCourtList.Resize += pCourtList_Resize;
            pCourtList.WrapContents = true;
            pCourtList.FlowDirection = FlowDirection.LeftToRight;
            pCourtList.AutoScroll = true;

            // 
            // BookCourtGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(draft_panel);
            Margin = new Padding(4);
            Name = "BookCourtGUI";
            Size = new Size(1126, 816);
            draft_panel.ResumeLayout(false);
            draft_panel.PerformLayout();
            pFilter.ResumeLayout(false);
            customPanel4.ResumeLayout(false);
            customPanel4.PerformLayout();
            customPanel3.ResumeLayout(false);
            customPanel3.PerformLayout();
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnDelete).EndInit();
            ResumeLayout(false);
        }
        #endregion


        private Panel draft_panel;
        private Label btnBooking;
        private CustomPanel pFilter;
        private Label lblTitle;
        private CustomPanel customPanel1;
        private TextBox textBox1;
        private PictureBox btnDelete;
        private DateTimePicker dateTimePicker1;
        private CustomPanel customPanel4;
        private Label lbltimeFinish;
        private CustomPanel customPanel3;
        private Label lbltimeStart;
        private CustomPanel customPanel2;
        private Label lblDate;
        private ComponentsGUI.TimePicker btnTimeStart;
        private ComponentsGUI.TimePicker btnTimeFinish;
        private FlowLayoutPanel pCourtList;
    }
}