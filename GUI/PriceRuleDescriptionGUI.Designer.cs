
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
            panelTop.Size = new Size(586, 133);
            panelTop.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(586, 133);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Mô tả";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(labelDescription);
            panelBottom.Dock = DockStyle.Fill;
            panelBottom.Location = new Point(0, 133);
            panelBottom.Margin = new Padding(3, 4, 3, 4);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(586, 130);
            panelBottom.TabIndex = 1;
            // 
            // labelDescription
            // 
            labelDescription.Dock = DockStyle.Fill;
            labelDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescription.Location = new Point(0, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(586, 130);
            labelDescription.TabIndex = 0;
            labelDescription.Text = "Giá sân này chỉ dùng cho đấu giải";
            labelDescription.TextAlign = ContentAlignment.TopCenter;
            // 
            // PriceRuleDescriptionGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 263);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PriceRuleDescriptionGUI";
            StartPosition = FormStartPosition.CenterScreen;
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