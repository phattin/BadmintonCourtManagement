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
            calBooking = new MonthCalendar();
            customPanel2 = new CustomPanel();
            customPanel10 = new CustomPanel();
            txtPrePayment = new TextBox();
            lblPrePayment = new Label();
            btnBooking4 = new Label();
            customPanel8 = new CustomPanel();
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
            txtPhone = new TextBox();
            customPanel9 = new CustomPanel();
            txtCourtID = new TextBox();
            lblCourtID = new Label();
            customPanel3 = new CustomPanel();
            txtCustomerName = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            customPanel1.SuspendLayout();
            customPanel2.SuspendLayout();
            customPanel10.SuspendLayout();
            customPanel8.SuspendLayout();
            customPanel7.SuspendLayout();
            customPanel6.SuspendLayout();
            customPanel5.SuspendLayout();
            customPanel4.SuspendLayout();
            customPanel9.SuspendLayout();
            customPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(40, 35);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(10, 11, 10, 11);
            lblTitle.Size = new Size(133, 60);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Đặt sân";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBooking
            // 
            btnBooking.AutoSize = true;
            btnBooking.BackColor = Color.FromArgb(64, 64, 64);
            btnBooking.Cursor = Cursors.Hand;
            btnBooking.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooking.ForeColor = Color.White;
            btnBooking.Location = new Point(735, 35);
            btnBooking.Margin = new Padding(2, 0, 2, 0);
            btnBooking.Name = "btnBooking";
            btnBooking.Padding = new Padding(10, 11, 10, 13);
            btnBooking.Size = new Size(110, 52);
            btnBooking.TabIndex = 6;
            btnBooking.Text = "Quay lại";
            btnBooking.TextAlign = ContentAlignment.MiddleCenter;
            btnBooking.Click += btnBooking_Click;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.WhiteSmoke;
            customPanel1.BorderRadius = 20;
            customPanel1.Controls.Add(calBooking);
            customPanel1.Controls.Add(label4);
            customPanel1.Controls.Add(label5);
            customPanel1.Controls.Add(customPanel6);
            customPanel1.Controls.Add(customPanel7);
            customPanel1.Location = new Point(56, 111);
            customPanel1.Margin = new Padding(2);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(396, 454);
            customPanel1.TabIndex = 7;
            // 
            // calBooking
            // 
            calBooking.Enabled = false;
            calBooking.Location = new Point(68, 48);
            calBooking.Margin = new Padding(7);
            calBooking.MaxSelectionCount = 1;
            calBooking.Name = "calBooking";
            calBooking.TabIndex = 0;
            calBooking.DateChanged += calBooking_DateChanged;
            calBooking.DateSelected += calBooking_DateSelected;
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.WhiteSmoke;
            customPanel2.BorderRadius = 20;
            customPanel2.Controls.Add(customPanel10);
            customPanel2.Controls.Add(lblPrePayment);
            customPanel2.Controls.Add(btnBooking4);
            customPanel2.Controls.Add(customPanel8);
            customPanel2.Controls.Add(customPanel5);
            customPanel2.Controls.Add(label6);
            customPanel2.Controls.Add(customPanel4);
            customPanel2.Controls.Add(customPanel9);
            customPanel2.Controls.Add(lblCourtID);
            customPanel2.Controls.Add(customPanel3);
            customPanel2.Controls.Add(label1);
            customPanel2.Controls.Add(label3);
            customPanel2.Controls.Add(label2);
            customPanel2.Location = new Point(490, 111);
            customPanel2.Margin = new Padding(2);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(355, 454);
            customPanel2.TabIndex = 8;
            customPanel2.Paint += customPanel2_Paint;
            // 
            // customPanel10
            // 
            customPanel10.BackColor = Color.White;
            customPanel10.BorderRadius = 30;
            customPanel10.Controls.Add(txtPrePayment);
            customPanel10.Location = new Point(142, 285);
            customPanel10.Margin = new Padding(2);
            customPanel10.Name = "customPanel10";
            customPanel10.Size = new Size(197, 38);
            customPanel10.TabIndex = 19;
            // 
            // txtPrePayment
            // 
            txtPrePayment.BorderStyle = BorderStyle.None;
            txtPrePayment.Font = new Font("Segoe UI", 9F);
            txtPrePayment.ForeColor = Color.Black;
            txtPrePayment.Location = new Point(12, 8);
            txtPrePayment.Margin = new Padding(2);
            txtPrePayment.Multiline = true;
            txtPrePayment.Name = "txtPrePayment";
            txtPrePayment.PlaceholderText = "Value";
            txtPrePayment.Size = new Size(146, 24);
            txtPrePayment.TabIndex = 0;
            txtPrePayment.Text = "0";
            // 
            // lblPrePayment
            // 
            lblPrePayment.AutoSize = true;
            lblPrePayment.Location = new Point(20, 293);
            lblPrePayment.Margin = new Padding(2, 0, 2, 0);
            lblPrePayment.Name = "lblPrePayment";
            lblPrePayment.Size = new Size(64, 20);
            lblPrePayment.TabIndex = 20;
            lblPrePayment.Text = "Tiền cọc";
            // 
            // btnBooking4
            // 
            btnBooking4.AutoSize = true;
            btnBooking4.BackColor = Color.FromArgb(64, 64, 64);
            btnBooking4.Cursor = Cursors.Hand;
            btnBooking4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooking4.ForeColor = Color.White;
            btnBooking4.Location = new Point(142, 368);
            btnBooking4.Margin = new Padding(2, 0, 2, 0);
            btnBooking4.Name = "btnBooking4";
            btnBooking4.Padding = new Padding(14, 8, 13, 11);
            btnBooking4.Size = new Size(82, 36);
            btnBooking4.TabIndex = 11;
            btnBooking4.Text = "Đặt sân";
            btnBooking4.TextAlign = ContentAlignment.MiddleCenter;
            btnBooking4.Click += btnBooking4_Click;
            // 
            // customPanel8
            // 
            customPanel8.BackColor = SystemColors.Control;
            customPanel8.BorderRadius = 30;
            customPanel8.Controls.Add(txtTotalPrice);
            customPanel8.Location = new Point(142, 237);
            customPanel8.Margin = new Padding(2);
            customPanel8.Name = "customPanel8";
            customPanel8.Size = new Size(197, 38);
            customPanel8.TabIndex = 10;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.BorderStyle = BorderStyle.None;
            txtTotalPrice.Font = new Font("Segoe UI", 9F);
            txtTotalPrice.ForeColor = Color.Black;
            txtTotalPrice.Location = new Point(12, 8);
            txtTotalPrice.Margin = new Padding(2);
            txtTotalPrice.Multiline = true;
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.PlaceholderText = "Value";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(125, 24);
            txtTotalPrice.TabIndex = 0;
            txtTotalPrice.TextChanged += txtTotalPrice_TextChanged;
            // 
            // customPanel7
            // 
            customPanel7.BackColor = SystemColors.Control;
            customPanel7.BorderRadius = 30;
            customPanel7.Controls.Add(txtEndTime);
            customPanel7.Location = new Point(152, 360);
            customPanel7.Margin = new Padding(2);
            customPanel7.Name = "customPanel7";
            customPanel7.Size = new Size(197, 38);
            customPanel7.TabIndex = 9;
            // 
            // txtEndTime
            // 
            txtEndTime.BorderStyle = BorderStyle.None;
            txtEndTime.Font = new Font("Segoe UI", 9F);
            txtEndTime.ForeColor = Color.Black;
            txtEndTime.Location = new Point(12, 8);
            txtEndTime.Margin = new Padding(2);
            txtEndTime.Multiline = true;
            txtEndTime.Name = "txtEndTime";
            txtEndTime.PlaceholderText = "Value";
            txtEndTime.ReadOnly = true;
            txtEndTime.Size = new Size(125, 24);
            txtEndTime.TabIndex = 0;
            txtEndTime.TextChanged += txtEndTime_TextChanged;
            // 
            // customPanel6
            // 
            customPanel6.BackColor = SystemColors.Control;
            customPanel6.BorderRadius = 30;
            customPanel6.Controls.Add(txtStartTime);
            customPanel6.Location = new Point(152, 304);
            customPanel6.Margin = new Padding(2);
            customPanel6.Name = "customPanel6";
            customPanel6.Size = new Size(197, 38);
            customPanel6.TabIndex = 7;
            // 
            // txtStartTime
            // 
            txtStartTime.BorderStyle = BorderStyle.None;
            txtStartTime.Font = new Font("Segoe UI", 9F);
            txtStartTime.ForeColor = Color.Black;
            txtStartTime.Location = new Point(12, 8);
            txtStartTime.Margin = new Padding(2);
            txtStartTime.Multiline = true;
            txtStartTime.Name = "txtStartTime";
            txtStartTime.PlaceholderText = "Value";
            txtStartTime.ReadOnly = true;
            txtStartTime.Size = new Size(125, 24);
            txtStartTime.TabIndex = 0;
            txtStartTime.TextChanged += txtStartTime_TextChanged;
            // 
            // customPanel5
            // 
            customPanel5.BackColor = SystemColors.Control;
            customPanel5.BorderRadius = 30;
            customPanel5.Controls.Add(txtDate);
            customPanel5.Location = new Point(142, 181);
            customPanel5.Margin = new Padding(2);
            customPanel5.Name = "customPanel5";
            customPanel5.Size = new Size(197, 38);
            customPanel5.TabIndex = 8;
            // 
            // txtDate
            // 
            txtDate.BorderStyle = BorderStyle.None;
            txtDate.Font = new Font("Segoe UI", 9F);
            txtDate.ForeColor = Color.Black;
            txtDate.Location = new Point(12, 8);
            txtDate.Margin = new Padding(2);
            txtDate.Multiline = true;
            txtDate.Name = "txtDate";
            txtDate.PlaceholderText = "Value";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(125, 24);
            txtDate.TabIndex = 0;
            txtDate.TextChanged += txtDate_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 368);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 12;
            label5.Text = "Giờ kết thúc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 312);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 13;
            label4.Text = "Giờ bắt đầu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 245);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 14;
            label6.Text = "Tổng tiền";
            // 
            // customPanel4
            // 
            customPanel4.BackColor = Color.White;
            customPanel4.BorderRadius = 30;
            customPanel4.Controls.Add(txtPhone);
            customPanel4.Location = new Point(141, 126);
            customPanel4.Margin = new Padding(2);
            customPanel4.Name = "customPanel4";
            customPanel4.Size = new Size(197, 38);
            customPanel4.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("Segoe UI", 9F);
            txtPhone.ForeColor = Color.Black;
            txtPhone.Location = new Point(12, 8);
            txtPhone.Margin = new Padding(2);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Value";
            txtPhone.Size = new Size(169, 24);
            txtPhone.TabIndex = 0;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // customPanel9
            // 
            customPanel9.BackColor = SystemColors.Control;
            customPanel9.BorderRadius = 30;
            customPanel9.Controls.Add(txtCourtID);
            customPanel9.Location = new Point(141, 18);
            customPanel9.Margin = new Padding(2);
            customPanel9.Name = "customPanel9";
            customPanel9.Size = new Size(197, 38);
            customPanel9.TabIndex = 6;
            customPanel9.Paint += customPanel3_Paint;
            // 
            // txtCourtID
            // 
            txtCourtID.BorderStyle = BorderStyle.None;
            txtCourtID.Font = new Font("Segoe UI", 9F);
            txtCourtID.ForeColor = Color.Black;
            txtCourtID.Location = new Point(12, 8);
            txtCourtID.Margin = new Padding(2);
            txtCourtID.Multiline = true;
            txtCourtID.Name = "txtCourtID";
            txtCourtID.PlaceholderText = "Value";
            txtCourtID.ReadOnly = true;
            txtCourtID.Size = new Size(125, 24);
            txtCourtID.TabIndex = 0;
            // 
            // lblCourtID
            // 
            lblCourtID.AutoSize = true;
            lblCourtID.Location = new Point(20, 26);
            lblCourtID.Margin = new Padding(2, 0, 2, 0);
            lblCourtID.Name = "lblCourtID";
            lblCourtID.Size = new Size(58, 20);
            lblCourtID.TabIndex = 15;
            lblCourtID.Text = "Mã Sân";
            // 
            // customPanel3
            // 
            customPanel3.BackColor = SystemColors.Control;
            customPanel3.BorderRadius = 30;
            customPanel3.Controls.Add(txtCustomerName);
            customPanel3.Location = new Point(141, 71);
            customPanel3.Margin = new Padding(2);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(197, 38);
            customPanel3.TabIndex = 6;
            customPanel3.Paint += customPanel3_Paint;
            // 
            // txtCustomerName
            // 
            txtCustomerName.BorderStyle = BorderStyle.None;
            txtCustomerName.Font = new Font("Segoe UI", 9F);
            txtCustomerName.ForeColor = Color.Black;
            txtCustomerName.Location = new Point(12, 8);
            txtCustomerName.Margin = new Padding(2);
            txtCustomerName.Multiline = true;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Value";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(169, 24);
            txtCustomerName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 79);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 16;
            label1.Text = "Tên KH";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 189);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 17;
            label3.Text = "Ngày đánh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 134);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 18;
            label2.Text = "Số điện thoại KH";
            // 
            // BookCourtDetailGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(customPanel2);
            Controls.Add(customPanel1);
            Controls.Add(btnBooking);
            Controls.Add(lblTitle);
            Margin = new Padding(2);
            Name = "BookCourtDetailGUI";
            Size = new Size(901, 653);
            Load += BookCourtDetail_Load;
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            customPanel10.ResumeLayout(false);
            customPanel10.PerformLayout();
            customPanel8.ResumeLayout(false);
            customPanel8.PerformLayout();
            customPanel7.ResumeLayout(false);
            customPanel7.PerformLayout();
            customPanel6.ResumeLayout(false);
            customPanel6.PerformLayout();
            customPanel5.ResumeLayout(false);
            customPanel5.PerformLayout();
            customPanel4.ResumeLayout(false);
            customPanel4.PerformLayout();
            customPanel9.ResumeLayout(false);
            customPanel9.PerformLayout();
            customPanel3.ResumeLayout(false);
            customPanel3.PerformLayout();
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
        private TextBox txtCustomerName;
        private CustomPanel customPanel8;
        private TextBox txtTotalPrice;
        private CustomPanel customPanel7;
        private TextBox txtEndTime;
        private CustomPanel customPanel6;
        private TextBox txtStartTime;
        private CustomPanel customPanel5;
        private TextBox txtDate;
        private CustomPanel customPanel4;
        private TextBox txtPhone;
        private Label btnBooking4;
        private CustomPanel customPanel9;
        private TextBox txtCourtID;
        private Label lblCourtID;

        // Khu chọn lịch & giờ bên trái
        private MonthCalendar calBooking;
        private CustomPanel customPanel10;
        private TextBox txtPrePayment;
        private Label lblPrePayment;
    }
}