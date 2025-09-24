namespace BadmintonCourtManagement.GUI
{
    partial class MainLayout
    {
        private System.ComponentModel.IContainer components = null;
        private Panel menuPanel;

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
            menuPanel = new Panel();
            menuPanel.SuspendLayout();
            SuspendLayout();
            
            // menuPanel 
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(166, 753);
            menuPanel.BackColor = Color.FromArgb(239, 248, 230);
            menuPanel.TabIndex = 0;

            // MainLayout
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "MainLayout";

            this.Controls.Add(menuPanel);
            menuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}