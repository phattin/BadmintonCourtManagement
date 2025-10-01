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
            pFilter = new Panel();
            lblTitle = new Label();
            btnBooking = new Label();
            pCourt = new Panel();
            btnBooking2 = new Label();
            pCourt2 = new Panel();
            btnBooking3 = new Label();
            pCourt3 = new Panel();
            btnBooking4 = new Label();
            draft_panel.SuspendLayout();
            pCourt.SuspendLayout();
            pCourt2.SuspendLayout();
            pCourt3.SuspendLayout();
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
            draft_panel.Name = "draft_panel";
            draft_panel.Size = new Size(915, 700);
            draft_panel.TabIndex = 0;
            // 
            // pFilter
            // 
            pFilter.BackColor = Color.FromArgb(217, 217, 217);
            pFilter.Location = new Point(58, 134);
            pFilter.Name = "pFilter";
            pFilter.Size = new Size(800, 66);
            pFilter.TabIndex = 5;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(40, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(10);
            lblTitle.Size = new Size(133, 58);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "??t sân";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.UseWaitCursor = true;
            // 
            // btnBooking
            // 
            btnBooking.AutoSize = true;
            btnBooking.BackColor = Color.FromArgb(64, 64, 64);
            btnBooking.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooking.ForeColor = Color.White;
            btnBooking.Location = new Point(754, 34);
            btnBooking.Name = "btnBooking";
            btnBooking.Padding = new Padding(10, 10, 10, 13);
            btnBooking.Size = new Size(104, 51);
            btnBooking.TabIndex = 3;
            btnBooking.Text = "??t sân";
            btnBooking.TextAlign = ContentAlignment.MiddleCenter;
            btnBooking.UseWaitCursor = true;
            btnBooking.Click += btnBooking_Click;
            // 
            // pCourt
            // 
            pCourt.BackColor = Color.FromArgb(200, 250, 214);
            pCourt.Controls.Add(btnBooking2);
            pCourt.Location = new Point(58, 270);
            pCourt.Name = "pCourt";
            pCourt.Size = new Size(241, 190);
            pCourt.TabIndex = 6;
            // 
            // btnBooking2
            // 
            btnBooking2.AutoSize = true;
            btnBooking2.BackColor = Color.FromArgb(64, 64, 64);
            btnBooking2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooking2.ForeColor = Color.White;
            btnBooking2.Location = new Point(82, 135);
            btnBooking2.Name = "btnBooking2";
            btnBooking2.Padding = new Padding(8, 8, 8, 10);
            btnBooking2.Size = new Size(71, 35);
            btnBooking2.TabIndex = 7;
            btnBooking2.Text = "??t sân";
            btnBooking2.TextAlign = ContentAlignment.MiddleCenter;
            btnBooking2.UseWaitCursor = true;
            // 
            // pCourt2
            // 
            pCourt2.BackColor = Color.FromArgb(200, 250, 214);
            pCourt2.Controls.Add(btnBooking3);
            pCourt2.Location = new Point(338, 270);
            pCourt2.Name = "pCourt2";
            pCourt2.Size = new Size(241, 190);
            pCourt2.TabIndex = 7;
            // 
            // btnBooking3
            // 
            btnBooking3.AutoSize = true;
            btnBooking3.BackColor = Color.FromArgb(64, 64, 64);
            btnBooking3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooking3.ForeColor = Color.White;
            btnBooking3.Location = new Point(82, 135);
            btnBooking3.Name = "btnBooking3";
            btnBooking3.Padding = new Padding(8, 8, 8, 10);
            btnBooking3.Size = new Size(71, 35);
            btnBooking3.TabIndex = 7;
            btnBooking3.Text = "??t sân";
            btnBooking3.TextAlign = ContentAlignment.MiddleCenter;
            btnBooking3.UseWaitCursor = true;
            // 
            // pCourt3
            // 
            pCourt3.BackColor = Color.FromArgb(200, 250, 214);
            pCourt3.Controls.Add(btnBooking4);
            pCourt3.Location = new Point(617, 270);
            pCourt3.Name = "pCourt3";
            pCourt3.Size = new Size(241, 190);
            pCourt3.TabIndex = 8;
            // 
            // btnBooking4
            // 
            btnBooking4.AutoSize = true;
            btnBooking4.BackColor = Color.FromArgb(64, 64, 64);
            btnBooking4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooking4.ForeColor = Color.White;
            btnBooking4.Location = new Point(82, 135);
            btnBooking4.Name = "btnBooking4";
            btnBooking4.Padding = new Padding(8, 8, 8, 10);
            btnBooking4.Size = new Size(71, 35);
            btnBooking4.TabIndex = 7;
            btnBooking4.Text = "??t sân";
            btnBooking4.TextAlign = ContentAlignment.MiddleCenter;
            btnBooking4.UseWaitCursor = true;
            // 
            // BookCourtGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(draft_panel);
            Name = "BookCourtGUI";
            Size = new Size(915, 700);
            draft_panel.ResumeLayout(false);
            draft_panel.PerformLayout();
            pCourt.ResumeLayout(false);
            pCourt.PerformLayout();
            pCourt2.ResumeLayout(false);
            pCourt2.PerformLayout();
            pCourt3.ResumeLayout(false);
            pCourt3.PerformLayout();
            ResumeLayout(false);
        }
        #endregion


        private Panel draft_panel;
        private Label btnBooking;
        private Panel pFilter;
        private Label lblTitle;
        private Panel pCourt;
        private Panel pCourt3;
        private Label btnBooking4;
        private Panel pCourt2;
        private Label btnBooking3;
        private Label btnBooking2;
    }
}