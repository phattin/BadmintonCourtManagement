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
            btnBooking4 = new Label();
            pCourt2 = new CustomPanel();
            btnBooking3 = new Label();
            pCourt = new CustomPanel();
            btnBooking2 = new Label();
            pFilter = new CustomPanel();
            lblTitle = new Label();
            btnBooking = new Label();
            draft_panel.SuspendLayout();
            pCourt3.SuspendLayout();
            pCourt2.SuspendLayout();
            pCourt.SuspendLayout();
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
            draft_panel.Margin = new Padding(3, 2, 3, 2);
            draft_panel.Name = "draft_panel";
            draft_panel.Size = new Size(788, 490);
            draft_panel.TabIndex = 0;
            // 
            // pCourt3
            // 
            pCourt3.BackColor = Color.FromArgb(200, 250, 214);
            pCourt3.BorderRadius = 20;
            pCourt3.Controls.Add(btnBooking4);
            pCourt3.Location = new Point(540, 202);
            pCourt3.Margin = new Padding(3, 2, 3, 2);
            pCourt3.Name = "pCourt3";
            pCourt3.Size = new Size(211, 142);
            pCourt3.TabIndex = 8;
            pCourt3.Paint += pCourt3_Paint;
            // 
            // btnBooking4
            // 
            btnBooking4.AutoSize = true;
            btnBooking4.BackColor = Color.FromArgb(64, 64, 64);
            btnBooking4.Cursor = Cursors.Hand;
            btnBooking4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooking4.ForeColor = Color.White;
            btnBooking4.Location = new Point(72, 101);
            btnBooking4.Name = "btnBooking4";
            btnBooking4.Padding = new Padding(7, 6, 7, 8);
            btnBooking4.Size = new Size(60, 27);
            btnBooking4.TabIndex = 7;
            btnBooking4.Text = "Đặt sân";
            btnBooking4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pCourt2
            // 
            pCourt2.BackColor = Color.FromArgb(200, 250, 214);
            pCourt2.BorderRadius = 20;
            pCourt2.Controls.Add(btnBooking3);
            pCourt2.Location = new Point(296, 202);
            pCourt2.Margin = new Padding(3, 2, 3, 2);
            pCourt2.Name = "pCourt2";
            pCourt2.Size = new Size(211, 142);
            pCourt2.TabIndex = 7;
            pCourt2.Paint += pCourt2_Paint;
            // 
            // btnBooking3
            // 
            btnBooking3.AutoSize = true;
            btnBooking3.BackColor = Color.FromArgb(64, 64, 64);
            btnBooking3.Cursor = Cursors.Hand;
            btnBooking3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooking3.ForeColor = Color.White;
            btnBooking3.Location = new Point(72, 101);
            btnBooking3.Name = "btnBooking3";
            btnBooking3.Padding = new Padding(7, 6, 7, 8);
            btnBooking3.Size = new Size(60, 27);
            btnBooking3.TabIndex = 7;
            btnBooking3.Text = "Đặt sân";
            btnBooking3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pCourt
            // 
            pCourt.BackColor = Color.FromArgb(200, 250, 214);
            pCourt.BorderRadius = 20;
            pCourt.Controls.Add(btnBooking2);
            pCourt.Location = new Point(51, 202);
            pCourt.Margin = new Padding(3, 2, 3, 2);
            pCourt.Name = "pCourt";
            pCourt.Size = new Size(211, 142);
            pCourt.TabIndex = 6;
            pCourt.Paint += pCourt_Paint;
            // 
            // btnBooking2
            // 
            btnBooking2.AutoSize = true;
            btnBooking2.BackColor = Color.FromArgb(64, 64, 64);
            btnBooking2.Cursor = Cursors.Hand;
            btnBooking2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooking2.ForeColor = Color.White;
            btnBooking2.Location = new Point(72, 101);
            btnBooking2.Name = "btnBooking2";
            btnBooking2.Padding = new Padding(7, 6, 7, 8);
            btnBooking2.Size = new Size(60, 27);
            btnBooking2.TabIndex = 7;
            btnBooking2.Text = "Đặt sân";
            btnBooking2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pFilter
            // 
            pFilter.BackColor = Color.FromArgb(217, 217, 217);
            pFilter.BorderRadius = 20;
            pFilter.Location = new Point(51, 100);
            pFilter.Margin = new Padding(3, 2, 3, 2);
            pFilter.Name = "pFilter";
            pFilter.Size = new Size(700, 50);
            pFilter.TabIndex = 5;
            pFilter.Paint += pFilter_Paint;
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
            // btnBooking
            // 
            btnBooking.AutoSize = true;
            btnBooking.BackColor = Color.FromArgb(64, 64, 64);
            btnBooking.Cursor = Cursors.Hand;
            btnBooking.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooking.ForeColor = Color.White;
            btnBooking.Location = new Point(660, 26);
            btnBooking.Name = "btnBooking";
            btnBooking.Padding = new Padding(9, 8, 9, 10);
            btnBooking.Size = new Size(85, 39);
            btnBooking.TabIndex = 3;
            btnBooking.Text = "Đặt sân";
            btnBooking.TextAlign = ContentAlignment.MiddleCenter;
            btnBooking.Click += btnBooking_Click;
            // 
            // BookCourtGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(draft_panel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BookCourtGUI";
            Size = new Size(788, 490);
            draft_panel.ResumeLayout(false);
            draft_panel.PerformLayout();
            pCourt3.ResumeLayout(false);
            pCourt3.PerformLayout();
            pCourt2.ResumeLayout(false);
            pCourt2.PerformLayout();
            pCourt.ResumeLayout(false);
            pCourt.PerformLayout();
            ResumeLayout(false);
        }
        #endregion


        private Panel draft_panel;
        private Label btnBooking;
        private CustomPanel pFilter;
        private Label lblTitle;
        private CustomPanel pCourt;
        private CustomPanel pCourt3;
        private Label btnBooking4;
        private CustomPanel pCourt2;
        private Label btnBooking3;
        private Label btnBooking2;
    }
}