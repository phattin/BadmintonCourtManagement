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
            pCourtList = new TableLayoutPanel();
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
            draft_panel.Controls.Add(pCourtList);
            draft_panel.Controls.Add(pFilter);
            draft_panel.Controls.Add(lblTitle);
            draft_panel.Dock = DockStyle.Fill;
            draft_panel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            draft_panel.Location = new Point(0, 0);
            draft_panel.Name = "draft_panel";
            draft_panel.Size = new Size(901, 653);
            draft_panel.TabIndex = 0;
            draft_panel.TabStop = true;
            draft_panel.Paint += draft_panel_Paint;
            // 
            // pCourtList
            // 
            pCourtList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pCourtList.ColumnCount = 4;
            pCourtList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCourtList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCourtList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCourtList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCourtList.Location = new Point(58, 255);
            pCourtList.Margin = new Padding(2, 2, 2, 2);
            pCourtList.Name = "pCourtList";
            pCourtList.RowCount = 2;
            pCourtList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pCourtList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pCourtList.Size = new Size(799, 360);
            pCourtList.TabIndex = 0;
            pCourtList.Paint += pCourtList_Paint;
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
            pFilter.Location = new Point(58, 133);
            pFilter.Name = "pFilter";
            pFilter.Size = new Size(800, 67);
            pFilter.TabIndex = 5;
            pFilter.Paint += pFilter_Paint;
            // 
            // customPanel4
            // 
            customPanel4.BackColor = Color.White;
            customPanel4.BorderRadius = 10;
            customPanel4.Controls.Add(btnTimeFinish);
            customPanel4.Controls.Add(lbltimeFinish);
            customPanel4.Location = new Point(659, 16);
            customPanel4.Name = "customPanel4";
            customPanel4.Size = new Size(113, 38);
            customPanel4.TabIndex = 3;
            // 
            // btnTimeFinish
            // 
            btnTimeFinish.Location = new Point(88, 8);
            btnTimeFinish.Margin = new Padding(2, 2, 2, 2);
            btnTimeFinish.Name = "btnTimeFinish";
            btnTimeFinish.SelectedTime = new DateTime(2025, 10, 3, 15, 16, 6, 16);
            btnTimeFinish.Size = new Size(25, 27);
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
            // 
            // customPanel3
            // 
            customPanel3.BackColor = Color.White;
            customPanel3.BorderRadius = 10;
            customPanel3.Controls.Add(btnTimeStart);
            customPanel3.Controls.Add(lbltimeStart);
            customPanel3.Location = new Point(523, 16);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(113, 38);
            customPanel3.TabIndex = 2;
            // 
            // btnTimeStart
            // 
            btnTimeStart.Location = new Point(90, 8);
            btnTimeStart.Margin = new Padding(2, 2, 2, 2);
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
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 10;
            customPanel2.Controls.Add(dateTimePicker1);
            customPanel2.Controls.Add(lblDate);
            customPanel2.Location = new Point(393, 16);
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
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(btnDelete);
            customPanel1.Controls.Add(textBox1);
            customPanel1.Location = new Point(26, 16);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(247, 38);
            customPanel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.X;
            btnDelete.Location = new Point(219, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(13, 14);
            btnDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            btnDelete.TabIndex = 1;
            btnDelete.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(12, 8);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Value";
            textBox1.Size = new Size(125, 24);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
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
            // BookCourtGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(draft_panel);
            Name = "BookCourtGUI";
            Size = new Size(901, 653);
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
        private TableLayoutPanel pCourtList;
    }
}