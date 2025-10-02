namespace BadmintonCourtManagement.GUI
{
    partial class MainLayout
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
            menuPanel = new Panel();
            contentPanel = new Panel();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.FromArgb(239, 248, 230);
            menuPanel.Width = 166;
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Name = "menuPanel";
            //
            // contentPanel
            //
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Name = "contentPanel";
            this.Controls.Add(contentPanel);
            this.Controls.Add(menuPanel);
            // 
            // MainLayout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 657);
            Name = "MainLayout";
            Text = "MainLayout";
            WindowState = FormWindowState.Maximized;
            Load += MainLayout_Load;
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel ModuleToggle;
    }
}