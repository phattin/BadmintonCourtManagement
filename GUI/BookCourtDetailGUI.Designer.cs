using System.Drawing;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    partial class BookCourtDetailGUI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnBooking = new Label();
            customPanel1 = new CustomPanel();
            customPanel2 = new CustomPanel();
            btnBooking4 = new Label();
            customPanel8 = new CustomPanel();
            pictureBox5 = new PictureBox();
            txtTotalPrice = new TextBox();
            customPanel7 = new CustomPanel();
            txtEndTime = new TextBox();
            customPanel6 = new CustomPanel();
            txtStartTime = new TextBox();
            customPanel5 = new CustomPanel();
            txtDate = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            customPanel4 = new CustomPanel();
            pictureBox1 = new PictureBox();
            txtPhone = new TextBox();
            customPanel9 = new CustomPanel();
            pictureBox6 = new PictureBox();
            txtCourtID = new TextBox();
            lblCourtID = new Label();
            customPanel3 = new CustomPanel();
            btnDelete = new PictureBox();
            txtCustomerName = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();

            // BÊN TRÁI: lịch & giờ
            calBooking = new MonthCalendar();
            timeStartPicker = new DateTimePicker();
            timeEndPicker = new DateTimePicker();
            lblCalStart = new Label();
            lblCalEnd = new Label();

            customPanel2.SuspendLayout();
            customPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            customPanel7.SuspendLayout();
            customPanel6.SuspendLayout();
            customPanel5.SuspendLayout();
            customPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            customPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(50, 44);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(12, 14, 12, 14);
            lblTitle.Size = new Size(156, 73);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Đặt sân";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // btnBooking (Quay lại)
            btnBooking.AutoSize = true;
            btnBooking.BackColor = Color.FromArgb(64, 64, 64);
            btnBooking.Cursor = Cursors.Hand;
            btnBooking.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooking.ForeColor = Color.White;
            btnBooking.Location = new Point(919, 44);
            btnBooking.Name = "btnBooking";
            btnBooking.Padding = new Padding(12, 14, 12, 16);
            btnBooking.Size = new Size(131, 62);
            btnBooking.TabIndex = 6;
            btnBooking.Text = "Quay lại";
            btnBooking.TextAlign = ContentAlignment.MiddleCenter;
            btnBooking.Click += btnBooking_Click;

            // customPanel1 (bên trái)
            customPanel1.BackColor = Color.WhiteSmoke;
            customPanel1.BorderRadius = 20;
            customPanel1.Location = new Point(70, 139);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(490, 582);
            customPanel1.TabIndex = 7;

            // calBooking
            calBooking.Location = new Point(20, 20);
            calBooking.MaxSelectionCount = 1;
            calBooking.DateSelected += calBooking_DateSelected;

            // lblCalStart
            lblCalStart.Text = "Giờ bắt đầu";
            lblCalStart.Location = new Point(20, 250);
            lblCalStart.AutoSize = true;

            // timeStartPicker
            timeStartPicker.Format = DateTimePickerFormat.Time;
            timeStartPicker.ShowUpDown = true;
            timeStartPicker.Location = new Point(150, 245);
            timeStartPicker.Width = 120;
            timeStartPicker.ValueChanged += timeStartPicker_ValueChanged;

            // lblCalEnd
            lblCalEnd.Text = "Giờ kết thúc";
            lblCalEnd.Location = new Point(20, 300);
            lblCalEnd.AutoSize = true;

            // timeEndPicker
            timeEndPicker.Format = DateTimePickerFormat.Time;
            timeEndPicker.ShowUpDown = true;
            timeEndPicker.Location = new Point(150, 295);
            timeEndPicker.Width = 120;
            timeEndPicker.ValueChanged += timeEndPicker_ValueChanged;

            // add vào customPanel1
            customPanel1.Controls.Add(calBooking);
            customPanel1.Controls.Add(lblCalStart);
            customPanel1.Controls.Add(timeStartPicker);
            customPanel1.Controls.Add(lblCalEnd);
            customPanel1.Controls.Add(timeEndPicker);

            // customPanel2 (bên phải)
            customPanel2.BackColor = Color.WhiteSmoke;
            customPanel2.BorderRadius = 20;
            customPanel2.Controls.Add(btnBooking4);
            customPanel2.Controls.Add(customPanel8);
            customPanel2.Controls.Add(customPanel7);
            customPanel2.Controls.Add(customPanel6);
            customPanel2.Controls.Add(customPanel5);
            customPanel2.Controls.Add(label5);
            customPanel2.Controls.Add(label4);
            customPanel2.Controls.Add(label6);
            customPanel2.Controls.Add(customPanel4);
            customPanel2.Controls.Add(customPanel9);
            customPanel2.Controls.Add(lblCourtID);
            customPanel2.Controls.Add(customPanel3);
            customPanel2.Controls.Add(label1);
            customPanel2.Controls.Add(label3);
            customPanel2.Controls.Add(label2);
            customPanel2.Location = new Point(613, 139);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(444, 582);
            customPanel2.TabIndex = 8;
            customPanel2.Paint += customPanel2_Paint;

            // btnBooking4 (Đặt sân)
            btnBooking4.AutoSize = true;
            btnBooking4.BackColor = Color.FromArgb(64, 64, 64);
            btnBooking4.Cursor = Cursors.Hand;
            btnBooking4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooking4.ForeColor = Color.White;
            btnBooking4.Location = new Point(177, 508);
            btnBooking4.Name = "btnBooking4";
            btnBooking4.Padding = new Padding(18, 10, 16, 14);
            btnBooking4.Size = new Size(101, 45);
            btnBooking4.TabIndex = 11;
            btnBooking4.Text = "Đặt sân";
            btnBooking4.TextAlign = ContentAlignment.MiddleCenter;

            // customPanel8 (Tổng tiền)
            customPanel8.BackColor = SystemColors.Control;
            customPanel8.BorderRadius = 30;
            customPanel8.Controls.Add(pictureBox5);
            customPanel8.Controls.Add(txtTotalPrice);
            customPanel8.Location = new Point(177, 432);
            customPanel8.Name = "customPanel8";
            customPanel8.Size = new Size(246, 48);
            customPanel8.TabIndex = 10;

            pictureBox5.Image = Properties.Resources.X;
            pictureBox5.Location = new Point(211, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(16, 18);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabStop = false;

            txtTotalPrice.BorderStyle = BorderStyle.None;
            txtTotalPrice.Font = new Font("Segoe UI", 9F);
            txtTotalPrice.ForeColor = Color.Black;
            txtTotalPrice.Location = new Point(15, 10);
            txtTotalPrice.Multiline = true;
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.PlaceholderText = "Value";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(156, 30);
            txtTotalPrice.TabIndex = 0;

            // customPanel7 (Giờ kết thúc)
            customPanel7.BackColor = SystemColors.Control;
            customPanel7.BorderRadius = 30;
            customPanel7.Controls.Add(txtEndTime);
            customPanel7.Location = new Point(177, 366);
            customPanel7.Name = "customPanel7";
            customPanel7.Size = new Size(246, 48);
            customPanel7.TabIndex = 9;

            txtEndTime.BorderStyle = BorderStyle.None;
            txtEndTime.Font = new Font("Segoe UI", 9F);
            txtEndTime.ForeColor = Color.Black;
            txtEndTime.Location = new Point(15, 10);
            txtEndTime.Multiline = true;
            txtEndTime.Name = "txtEndTime";
            txtEndTime.PlaceholderText = "Value";
            txtEndTime.ReadOnly = true;
            txtEndTime.Size = new Size(156, 30);
            txtEndTime.TabIndex = 0;
            txtEndTime.TextChanged += txtEndTime_TextChanged;

            // customPanel6 (Giờ bắt đầu)
            customPanel6.BackColor = SystemColors.Control;
            customPanel6.BorderRadius = 30;
            customPanel6.Controls.Add(txtStartTime);
            customPanel6.Location = new Point(177, 296);
            customPanel6.Name = "customPanel6";
            customPanel6.Size = new Size(246, 48);
            customPanel6.TabIndex = 7;

            txtStartTime.BorderStyle = BorderStyle.None;
            txtStartTime.Font = new Font("Segoe UI", 9F);
            txtStartTime.ForeColor = Color.Black;
            txtStartTime.Location = new Point(15, 10);
            txtStartTime.Multiline = true;
            txtStartTime.Name = "txtStartTime";
            txtStartTime.PlaceholderText = "Value";
            txtStartTime.ReadOnly = true;
            txtStartTime.Size = new Size(156, 30);
            txtStartTime.TabIndex = 0;
            txtStartTime.TextChanged += txtStartTime_TextChanged;

            // customPanel5 (Ngày đánh)
            customPanel5.BackColor = SystemColors.Control;
            customPanel5.BorderRadius = 30;
            customPanel5.Controls.Add(txtDate);
            customPanel5.Location = new Point(177, 226);
            customPanel5.Name = "customPanel5";
            customPanel5.Size = new Size(246, 48);
            customPanel5.TabIndex = 8;

            txtDate.BorderStyle = BorderStyle.None;
            txtDate.Font = new Font("Segoe UI", 9F);
            txtDate.ForeColor = Color.Black;
            txtDate.Location = new Point(15, 10);
            txtDate.Multiline = true;
            txtDate.Name = "txtDate";
            txtDate.PlaceholderText = "Value";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(156, 30);
            txtDate.TabIndex = 0;

            // label5,4,6
            label5.AutoSize = true;
            label5.Location = new Point(25, 376);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.Text = "Giờ kết thúc";

            label4.AutoSize = true;
            label4.Location = new Point(25, 306);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.Text = "Giờ bắt đầu";

            label6.AutoSize = true;
            label6.Location = new Point(25, 442);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.Text = "Tổng tiền";

            // customPanel4 (Số ĐT)
            customPanel4.BackColor = Color.White;
            customPanel4.BorderRadius = 30;
            customPanel4.Controls.Add(pictureBox1);
            customPanel4.Controls.Add(txtPhone);
            customPanel4.Location = new Point(176, 158);
            customPanel4.Name = "customPanel4";
            customPanel4.Size = new Size(246, 48);
            customPanel4.TabIndex = 7;

            pictureBox1.Image = Properties.Resources.X;
            pictureBox1.Location = new Point(211, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(16, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabStop = false;

            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("Segoe UI", 9F);
            txtPhone.ForeColor = Color.Black;
            txtPhone.Location = new Point(15, 10);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Value";
            txtPhone.Size = new Size(156, 30);
            txtPhone.TabIndex = 0;

            // customPanel9 (Mã sân)
            customPanel9.BackColor = SystemColors.Control;
            customPanel9.BorderRadius = 30;
            customPanel9.Controls.Add(pictureBox6);
            customPanel9.Controls.Add(txtCourtID);
            customPanel9.Location = new Point(176, 23);
            customPanel9.Name = "customPanel9";
            customPanel9.Size = new Size(246, 48);
            customPanel9.TabIndex = 6;
            customPanel9.Paint += customPanel3_Paint;

            pictureBox6.Image = Properties.Resources.X;
            pictureBox6.Location = new Point(211, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(16, 18);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabStop = false;

            txtCourtID.BorderStyle = BorderStyle.None;
            txtCourtID.Font = new Font("Segoe UI", 9F);
            txtCourtID.ForeColor = Color.Black;
            txtCourtID.Location = new Point(15, 10);
            txtCourtID.Multiline = true;
            txtCourtID.Name = "txtCourtID";
            txtCourtID.PlaceholderText = "Value";
            txtCourtID.ReadOnly = true;
            txtCourtID.Size = new Size(156, 30);
            txtCourtID.TabIndex = 0;

            lblCourtID.AutoSize = true;
            lblCourtID.Location = new Point(25, 33);
            lblCourtID.Name = "lblCourtID";
            lblCourtID.Size = new Size(71, 25);
            lblCourtID.Text = "Mã Sân";

            // customPanel3 (Tên KH)
            customPanel3.BackColor = SystemColors.Control;
            customPanel3.BorderRadius = 30;
            customPanel3.Controls.Add(btnDelete);
            customPanel3.Controls.Add(txtCustomerName);
            customPanel3.Location = new Point(176, 89);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(246, 48);
            customPanel3.TabIndex = 6;
            customPanel3.Paint += customPanel3_Paint;

            btnDelete.Image = Properties.Resources.X;
            btnDelete.Location = new Point(211, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(16, 18);
            btnDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            btnDelete.TabStop = false;

            txtCustomerName.BorderStyle = BorderStyle.None;
            txtCustomerName.Font = new Font("Segoe UI", 9F);
            txtCustomerName.ForeColor = Color.Black;
            txtCustomerName.Location = new Point(15, 10);
            txtCustomerName.Multiline = true;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Value";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(156, 30);
            txtCustomerName.TabIndex = 0;

            label1.AutoSize = true;
            label1.Location = new Point(25, 99);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.Text = "Tên KH";

            label3.AutoSize = true;
            label3.Location = new Point(25, 236);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.Text = "Ngày đánh";

            label2.AutoSize = true;
            label2.Location = new Point(25, 168);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.Text = "Số điện thoại KH";

            // BookCourtDetailGUI (UserControl)
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(customPanel2);
            Controls.Add(customPanel1);
            Controls.Add(btnBooking);
            Controls.Add(lblTitle);
            Name = "BookCourtDetailGUI";
            Size = new Size(1126, 816);
            Load += BookCourtDetail_Load;

            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            customPanel8.ResumeLayout(false);
            customPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            customPanel7.ResumeLayout(false);
            customPanel7.PerformLayout();
            customPanel6.ResumeLayout(false);
            customPanel6.PerformLayout();
            customPanel5.ResumeLayout(false);
            customPanel5.PerformLayout();
            customPanel4.ResumeLayout(false);
            customPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            customPanel9.ResumeLayout(false);
            customPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            customPanel3.ResumeLayout(false);
            customPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnDelete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label btnBooking;
        private CustomPanel customPanel1;
        private CustomPanel customPanel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CustomPanel customPanel3;
        private PictureBox btnDelete;
        private TextBox txtCustomerName;
        private CustomPanel customPanel8;
        private PictureBox pictureBox5;
        private TextBox txtTotalPrice;
        private CustomPanel customPanel7;
        private TextBox txtEndTime;
        private CustomPanel customPanel6;
        private TextBox txtStartTime;
        private CustomPanel customPanel5;
        private TextBox txtDate;
        private CustomPanel customPanel4;
        private PictureBox pictureBox1;
        private TextBox txtPhone;
        private Label btnBooking4;
        private CustomPanel customPanel9;
        private PictureBox pictureBox6;
        private TextBox txtCourtID;
        private Label lblCourtID;

        // Khu chọn lịch & giờ bên trái
        private MonthCalendar calBooking;
        private DateTimePicker timeStartPicker;
        private DateTimePicker timeEndPicker;
        private Label lblCalStart;
        private Label lblCalEnd;
    }
}
