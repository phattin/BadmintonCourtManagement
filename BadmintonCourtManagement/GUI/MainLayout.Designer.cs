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
            ModuleToggle = new Panel();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.FromArgb(239, 248, 230);
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Margin = new Padding(3, 2, 3, 2);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(180, 490);
            menuPanel.TabIndex = 0;
            // 
            // ModuleToggle
            // 
            ModuleToggle.BackColor = SystemColors.ActiveCaption;
            ModuleToggle.Location = new Point(177, 0);
            ModuleToggle.Name = "ModuleToggle";
            ModuleToggle.Size = new Size(788, 490);
            ModuleToggle.TabIndex = 1;
            // 
            // MainLayout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 490);
            Controls.Add(ModuleToggle);
            Controls.Add(menuPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainLayout";
            Text = "MainLayout";
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel ModuleToggle;
    }
}