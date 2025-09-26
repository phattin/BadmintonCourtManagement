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
            SuspendLayout();

            draft_panel.BackColor = Color.Red;
            // draft_panel.Size = new Size(634, 450);
            // draft_panel.Location = new Point(0, 0);
            draft_panel.Dock = DockStyle.Fill;
            draft_panel.Name = "draftPanel";

            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(634, 450);
            this.Controls.Add(draft_panel);  // ADD THIS LINE
            this.Name = "BookCourtGUI";
            // this.Text = "Book Court";

            ResumeLayout(false);
        }
        #endregion


        private Panel draft_panel;
    }
}