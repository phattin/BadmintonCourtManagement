using System.Reflection;

namespace BadmintonCourtManagement.GUI
{
    partial class CourtManagementGUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourtManagementGUI));
            lblTitle = new Label();
            customPanel1 = new CustomPanel();
            pCourtList = new TableLayoutPanel();
            customPanel2 = new CustomPanel();
            pictureBox1 = new PictureBox();
            customPanel4 = new CustomPanel();
            dateTimePicker1 = new DateTimePicker();
            lblDate = new Label();
            customPanel3 = new CustomPanel();
            btnDelete = new PictureBox();
            textBox1 = new TextBox();
            btnBooking = new Label();
            drPanelCourtMN = new Panel();
            label30 = new Label();
            customPanel1.SuspendLayout();
            customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            customPanel4.SuspendLayout();
            customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
            drPanelCourtMN.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(53, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(10, 11, 10, 11);
            lblTitle.Size = new Size(135, 60);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Sân cầu";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.UseWaitCursor = true;
            // 
            // customPanel1
            // 
            customPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            customPanel1.BackColor = Color.FromArgb(239, 248, 230);
            customPanel1.BorderRadius = 20;
            customPanel1.Controls.Add(pCourtList);
            customPanel1.Controls.Add(customPanel2);
            customPanel1.Location = new Point(56, 79);
            customPanel1.Margin = new Padding(3, 4, 3, 4);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(1146, 639);
            customPanel1.TabIndex = 6;
            customPanel1.Paint += customPanel1_Paint;
            // 
            // pCourtList
            // 
            pCourtList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pCourtList.ColumnCount = 4;
            pCourtList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCourtList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCourtList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCourtList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCourtList.Location = new Point(43, 101);
            pCourtList.Margin = new Padding(2);
            pCourtList.Name = "pCourtList";
            pCourtList.RowCount = 2;
            pCourtList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pCourtList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pCourtList.Size = new Size(1059, 494);
            pCourtList.TabIndex = 1;
            pCourtList.Paint += pCourtList_Paint;
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel2.BackColor = Color.FromArgb(0, 120, 103);
            customPanel2.BorderRadius = 20;
            customPanel2.Controls.Add(pictureBox1);
            customPanel2.Controls.Add(customPanel4);
            customPanel2.Controls.Add(customPanel3);
            customPanel2.Location = new Point(0, 0);
            customPanel2.Margin = new Padding(3, 4, 3, 4);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(1146, 73);
            customPanel2.TabIndex = 0;
            // 
            // pictureBox1 (reload icon)
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1084, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // customPanel4 (date picker)
            // 
            customPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customPanel4.BackColor = Color.White;
            customPanel4.BorderRadius = 10;
            customPanel4.Controls.Add(dateTimePicker1);
            customPanel4.Controls.Add(lblDate);
            customPanel4.Location = new Point(877, 12);
            customPanel4.Name = "customPanel4";
            customPanel4.Size = new Size(177, 51);
            customPanel4.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(151, 11);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(22, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // lblDate (label for date picker)
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(3, 15);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(86, 17);
            lblDate.TabIndex = 2;
            lblDate.Text = "Ngày mở sân";
            // 
            // customPanel3 (search bar panel)
            // 
            customPanel3.BackColor = Color.White;
            customPanel3.BorderRadius = 30;
            customPanel3.Controls.Add(btnDelete);
            customPanel3.Controls.Add(textBox1);
            customPanel3.Location = new Point(15, 12);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(520, 51);
            customPanel3.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.X;
            btnDelete.Location = new Point(490, 19);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(13, 13);
            btnDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            btnDelete.TabIndex = 1;
            btnDelete.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(14, 13);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Value";
            textBox1.Size = new Size(125, 24);
            textBox1.TabIndex = 0;
            // 
            // btnBooking
            // 
            btnBooking.AutoSize = true;
            btnBooking.BackColor = Color.FromArgb(64, 64, 64);
            btnBooking.Cursor = Cursors.Hand;
            btnBooking.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooking.ForeColor = Color.White;
            btnBooking.Location = new Point(1676, 617);
            btnBooking.Name = "btnBooking";
            btnBooking.Padding = new Padding(10, 11, 10, 13);
            btnBooking.Size = new Size(123, 52);
            btnBooking.TabIndex = 7;
            btnBooking.Text = "Thêm sân";
            btnBooking.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // drPanelCourtMN
            // 
            drPanelCourtMN.BackColor = Color.White;
            drPanelCourtMN.Controls.Add(label30);
            drPanelCourtMN.Controls.Add(customPanel1);
            drPanelCourtMN.Controls.Add(lblTitle);
            drPanelCourtMN.Dock = DockStyle.Fill;
            drPanelCourtMN.Location = new Point(0, 0);
            drPanelCourtMN.Name = "drPanelCourtMN";
            drPanelCourtMN.Size = new Size(1243, 766);
            drPanelCourtMN.TabIndex = 0;
            drPanelCourtMN.Paint += drPanelCourtMN_Paint;
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label30.AutoSize = true;
            label30.BackColor = Color.FromArgb(64, 64, 64);
            label30.Cursor = Cursors.Hand;
            label30.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.ForeColor = Color.White;
            label30.Location = new Point(1079, 22);
            label30.Name = "label30";
            label30.Padding = new Padding(10, 11, 10, 13);
            label30.Size = new Size(123, 52);
            label30.TabIndex = 7;
            label30.Text = "Thêm sân";
            label30.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CourtManagementGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(drPanelCourtMN);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CourtManagementGUI";
            Size = new Size(1243, 766);
            Load += CourtManagementGUI_Load;
            customPanel1.ResumeLayout(false);
            customPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            customPanel4.ResumeLayout(false);
            customPanel4.PerformLayout();
            customPanel3.ResumeLayout(false);
            customPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnDelete).EndInit();
            drPanelCourtMN.ResumeLayout(false);
            drPanelCourtMN.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Label lblTitle;
        private CustomPanel customPanel1;
        private CustomPanel customPanel2;
        private Label btnBooking;
        private CustomPanel customPanel3;
        private PictureBox btnDelete;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private CustomPanel customPanel4;
        private DateTimePicker dateTimePicker1;
        private Label lblDate;
        private Panel drPanelCourtMN;
        private Label label30;
        private TableLayoutPanel pCourtList;
    }
}
