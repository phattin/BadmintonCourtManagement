namespace GUI
{
    partial class PriceRuleDescriptionGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            labelTitle = new Label();
            panelBottom = new Panel();
            labelDescription = new Label();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(513, 100);
            panelTop.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(513, 100);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Description";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(labelDescription);
            panelBottom.Dock = DockStyle.Fill;
            panelBottom.Location = new Point(0, 100);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(513, 97);
            panelBottom.TabIndex = 1;
            // 
            // labelDescription
            // 
            labelDescription.Dock = DockStyle.Fill;
            labelDescription.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescription.Location = new Point(0, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(513, 97);
            labelDescription.TabIndex = 0;
            labelDescription.Text = "Giá sân này chỉ dùng cho đấu giải";
            labelDescription.TextAlign = ContentAlignment.TopCenter;
            // 
            // PriceRuleDescriptionGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 197);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Name = "PriceRuleDescriptionGUI";
            Text = "PriceRuleDescriptionGUI";
            panelTop.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelTitle;
        private Panel panelBottom;
        private Label labelDescription;
    }
}