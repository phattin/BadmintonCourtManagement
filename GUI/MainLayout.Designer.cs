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
            menuPanel.AutoScroll = true;
            menuPanel.BackColor = Color.FromArgb(239, 248, 230);
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(200, 719);
            menuPanel.TabIndex = 1;
            menuPanel.Paint += menuPanel_Paint;
            // 
            // contentPanel
            // 
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(166, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1243, 719);
            contentPanel.TabIndex = 0;
            contentPanel.Paint += contentPanel_Paint;
            // 
            // MainLayout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1409, 719);
            Controls.Add(contentPanel);
            Controls.Add(menuPanel);
            ImeMode = ImeMode.Katakana;
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
