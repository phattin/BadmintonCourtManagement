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
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.FromArgb(239, 248, 230);
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(206, 653);
            menuPanel.TabIndex = 0;
            // 
            // MainLayout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 653);
            Controls.Add(menuPanel);
            Name = "MainLayout";
            Text = "MainLayout";
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
    }
}