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
            pCourt3 = new CustomPanel();
            label4 = new Label();
            label2 = new Label();
            btnBooking4 = new Label();
            pCourt2 = new CustomPanel();
            label3 = new Label();
            label1 = new Label();
            btnBooking3 = new Label();
            pCourt = new CustomPanel();
            lblCourtInfo = new Label();
            lblText = new Label();
            btnBooking2 = new Label();
            pFilter = new CustomPanel();
            customPanel4 = new CustomPanel();
            btnEndTime = new DateTimePicker();
            lbltimeFinish = new Label();
            customPanel3 = new CustomPanel();
            dateTimePicker2 = new DateTimePicker();
            lbltimeStart = new Label();
            customPanel2 = new CustomPanel();
            dateTimePicker1 = new DateTimePicker();
            lblDate = new Label();
            customPanel1 = new CustomPanel();
            btnDelete = new PictureBox();
            textBox1 = new TextBox();
            lblTitle = new Label();
            btnBooking = new Label();
            draft_panel.SuspendLayout();
            pCourt3.SuspendLayout();
            pCourt2.SuspendLayout();
            pCourt.SuspendLayout();
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
            draft_panel.Controls.Add(pCourt3);
            draft_panel.Controls.Add(pCourt2);
            draft_panel.Controls.Add(pCourt);
            draft_panel.Controls.Add(pFilter);
            draft_panel.Controls.Add(lblTitle);
            draft_panel.Controls.Add(btnBooking);
            draft_panel.Dock = DockStyle.Fill;
            draft_panel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            draft_panel.Location = new Point(0, 0);
            draft_panel.Margin = new Padding(4);
            draft_panel.Name = "draft_panel";
            draft_panel.Size = new Size(1126, 816);
            draft_panel.TabIndex = 0;
            // 
            // pCourt3
            // 
            pCourt3.BackColor = Color.FromArgb(255, 176, 163);
            pCourt3.BorderRadius = 10;
            pCourt3.Controls.Add(label4);
            pCourt3.Controls.Add(label2);
            pCourt3.Controls.Add(btnBooking4);
            pCourt3.Location = new Point(771, 336);
            pCourt3.Margin = new Padding(4);
            pCourt3.Name = "pCourt3";
            pCourt3.Size = new Size(301, 260);
            pCourt3.TabIndex = 8;
            pCourt3.Paint += pCourt3_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 95);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(220, 50);
            label4.TabIndex = 10;
            label4.Text = "Tình trạng sân: Trống\r\nBooking tiếp theo: 7h - 9h\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 176, 163);
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(86, 14);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(12, 14, 12, 14);
            label2.Size = new Size(117, 66);
            label2.TabIndex = 9;
            label2.Text = "Sân A";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseWaitCursor = true;
            // 
            // btnBooking4
            // 
            btnBooking4.AutoSize = true;
            btnBooking4.BackColor = Color.FromArgb(64, 64, 64);
            btnBooking4.Cursor = Cursors.Hand;
            btnBooking4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooking4.ForeColor = Color.White;
            btnBooking4.Location = new Point(105, 180);
            btnBooking4.Margin = new Padding(4, 0, 4, 0);
            btnBooking4.Name = "btnBooking4";
            btnBooking4.Padding = new Padding(10, 10, 10, 14);
            btnBooking4.Size = new Size(87, 45);
            btnBooking4.TabIndex = 7;
            btnBooking4.Text = "Đặt sân";
            btnBooking4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pCourt2
            // 
            pCourt2.BackColor = Color.FromArgb(200, 250, 214);
            pCourt2.BorderRadius = 10;
            pCourt2.Controls.Add(label3);
            pCourt2.Controls.Add(label1);
            pCourt2.Controls.Add(btnBooking3);
            pCourt2.Location = new Point(422, 336);
            pCourt2.Margin = new Padding(4);
            pCourt2.Name = "pCourt2";
            pCourt2.Size = new Size(301, 260);
            pCourt2.TabIndex = 7;
            pCourt2.Paint += pCourt2_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 95);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(220, 50);
            label3.TabIndex = 10;
            label3.Text = "Tình trạng sân: Trống\r\nBooking tiếp theo: 7h - 9h\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(200, 250, 214);
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(90, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(12, 14, 12, 14);
            label1.Size = new Size(117, 66);
            label1.TabIndex = 9;
            label1.Text = "Sân A";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseWaitCursor = true;
            // 
            // btnBooking3
            // 
            btnBooking3.AutoSize = true;
            btnBooking3.BackColor = Color.FromArgb(64, 64, 64);
            btnBooking3.Cursor = Cursors.Hand;
            btnBooking3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooking3.ForeColor = Color.White;
            btnBooking3.Location = new Point(102, 180);
            btnBooking3.Margin = new Padding(4, 0, 4, 0);
            btnBooking3.Name = "btnBooking3";
            btnBooking3.Padding = new Padding(10, 10, 10, 14);
            btnBooking3.Size = new Size(87, 45);
            btnBooking3.TabIndex = 7;
            btnBooking3.Text = "Đặt sân";
            btnBooking3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pCourt
            // 
            pCourt.BackColor = Color.FromArgb(200, 250, 214);
            pCourt.BorderRadius = 10;
            pCourt.Controls.Add(lblCourtInfo);
            pCourt.Controls.Add(lblText);
            pCourt.Controls.Add(btnBooking2);
            pCourt.Location = new Point(72, 336);
            pCourt.Margin = new Padding(4);
            pCourt.Name = "pCourt";
            pCourt.Size = new Size(301, 260);
            pCourt.TabIndex = 6;
            pCourt.Paint += pCourt_Paint;
            // 
            // lblCourtInfo
            // 
            lblCourtInfo.AutoSize = true;
            lblCourtInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCourtInfo.Location = new Point(32, 95);
            lblCourtInfo.Margin = new Padding(4, 0, 4, 0);
            lblCourtInfo.Name = "lblCourtInfo";
            lblCourtInfo.Size = new Size(220, 50);
            lblCourtInfo.TabIndex = 9;
            lblCourtInfo.Text = "Tình trạng sân: Trống\r\nBooking tiếp theo: 7h - 9h\r\n";
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.BackColor = Color.FromArgb(200, 250, 214);
            lblText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblText.ForeColor = Color.Black;
            lblText.Location = new Point(85, 14);
            lblText.Margin = new Padding(4, 0, 4, 0);
            lblText.Name = "lblText";
            lblText.Padding = new Padding(12, 14, 12, 14);
            lblText.Size = new Size(117, 66);
            lblText.TabIndex = 8;
            lblText.Text = "Sân A";
            lblText.TextAlign = ContentAlignment.MiddleCenter;
            lblText.UseWaitCursor = true;
            lblText.Click += label1_Click;
            // 
            // btnBooking2
            // 
            btnBooking2.AutoSize = true;
            btnBooking2.BackColor = Color.FromArgb(64, 64, 64);
            btnBooking2.Cursor = Cursors.Hand;
            btnBooking2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooking2.ForeColor = Color.White;
            btnBooking2.Location = new Point(102, 180);
            btnBooking2.Margin = new Padding(4, 0, 4, 0);
            btnBooking2.Name = "btnBooking2";
            btnBooking2.Padding = new Padding(10, 10, 10, 14);
            btnBooking2.Size = new Size(87, 45);
            btnBooking2.TabIndex = 7;
            btnBooking2.Text = "Đặt sân";
            btnBooking2.TextAlign = ContentAlignment.MiddleCenter;
            btnBooking2.Click += btnBooking2_Click;
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
            customPanel4.Controls.Add(btnEndTime);
            customPanel4.Controls.Add(lbltimeFinish);
            customPanel4.Location = new Point(824, 20);
            customPanel4.Margin = new Padding(4);
            customPanel4.Name = "customPanel4";
            customPanel4.Size = new Size(141, 48);
            customPanel4.TabIndex = 3;
            // 
            // btnEndTime
            // 
            btnEndTime.Location = new Point(110, 6);
            btnEndTime.Margin = new Padding(4);
            btnEndTime.Name = "btnEndTime";
            btnEndTime.Size = new Size(26, 31);
            btnEndTime.TabIndex = 9;
            btnEndTime.Format = DateTimePickerFormat.Time;
            btnEndTime.ShowUpDown = true;
            btnEndTime.ValueChanged += btnEndTime_ValueChanged;
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
            customPanel3.Controls.Add(dateTimePicker2);
            customPanel3.Controls.Add(lbltimeStart);
            customPanel3.Location = new Point(654, 20);
            customPanel3.Margin = new Padding(4);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(141, 48);
            customPanel3.TabIndex = 2;
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
            pCourt3.ResumeLayout(false);
            pCourt3.PerformLayout();
            pCourt2.ResumeLayout(false);
            pCourt2.PerformLayout();
            pCourt.ResumeLayout(false);
            pCourt.PerformLayout();
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
        private CustomPanel pCourt3;
        private Label btnBooking4;
        private CustomPanel pCourt2;
        private Label btnBooking3;
        private CustomPanel customPanel1;
        private TextBox textBox1;
        private PictureBox btnDelete;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private CustomPanel customPanel4;
        private Label lbltimeFinish;
        private CustomPanel customPanel3;
        private Label lbltimeStart;
        private CustomPanel customPanel2;
        private Label lblDate;
        private DateTimePicker btnEndTime;
        private DateTimePicker dateTimePicker2;
        private CustomPanel pCourt;
        private Label lblCourtInfo;
        private Label lblText;
        private Label btnBooking2;
    }
}