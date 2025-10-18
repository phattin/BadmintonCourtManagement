namespace BadmintonCourtManagement.GUI
{
    partial class PermissionGUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermissionGUI));
            draftPanel = new Panel();
            extraNextButton = new Button();
            nextButton = new Button();
            extraPreviousButton = new Button();
            previousButton = new Button();
            btnInsert = new Label();
            pListBG = new CustomPanel();
            pList = new TableLayoutPanel();
            pFilter = new CustomPanel();
            btnReset = new PictureBox();
            pSearch = new CustomPanel();
            txtSearch = new TextBox();
            lblTitle = new Label();
            draftPanel.SuspendLayout();
            pListBG.SuspendLayout();
            pFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnReset).BeginInit();
            pSearch.SuspendLayout();
            SuspendLayout();
            // 
            // draftPanel
            // 
            draftPanel.Controls.Add(extraNextButton);
            draftPanel.Controls.Add(nextButton);
            draftPanel.Controls.Add(extraPreviousButton);
            draftPanel.Controls.Add(previousButton);
            draftPanel.Controls.Add(btnInsert);
            draftPanel.Controls.Add(pListBG);
            draftPanel.Controls.Add(lblTitle);
            draftPanel.Dock = DockStyle.Fill;
            draftPanel.Location = new Point(0, 0);
            draftPanel.Name = "draftPanel";
            draftPanel.Size = new Size(915, 545);
            draftPanel.TabIndex = 0;
            // 
            // extraNextButton
            // 
            extraNextButton.Anchor = AnchorStyles.Bottom;
            extraNextButton.BackColor = Color.Transparent;
            extraNextButton.Cursor = Cursors.Hand;
            extraNextButton.Image = (Image)resources.GetObject("extraNextButton.Image");
            extraNextButton.Location = new Point(549, 489);
            extraNextButton.Name = "extraNextButton";
            extraNextButton.Size = new Size(53, 53);
            extraNextButton.TabIndex = 18;
            extraNextButton.TextImageRelation = TextImageRelation.TextAboveImage;
            extraNextButton.UseVisualStyleBackColor = false;
            extraNextButton.Click += extraNextButton_Click;
            // 
            // nextButton
            // 
            nextButton.Anchor = AnchorStyles.Bottom;
            nextButton.BackColor = Color.Transparent;
            nextButton.Cursor = Cursors.Hand;
            nextButton.Image = (Image)resources.GetObject("nextButton.Image");
            nextButton.Location = new Point(474, 489);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(53, 53);
            nextButton.TabIndex = 17;
            nextButton.TextImageRelation = TextImageRelation.TextAboveImage;
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // extraPreviousButton
            // 
            extraPreviousButton.Anchor = AnchorStyles.Bottom;
            extraPreviousButton.BackColor = Color.Transparent;
            extraPreviousButton.Cursor = Cursors.Hand;
            extraPreviousButton.ForeColor = Color.Transparent;
            extraPreviousButton.Image = (Image)resources.GetObject("extraPreviousButton.Image");
            extraPreviousButton.Location = new Point(295, 489);
            extraPreviousButton.Name = "extraPreviousButton";
            extraPreviousButton.Size = new Size(53, 53);
            extraPreviousButton.TabIndex = 16;
            extraPreviousButton.TextImageRelation = TextImageRelation.TextAboveImage;
            extraPreviousButton.UseVisualStyleBackColor = false;
            extraPreviousButton.Click += extraPreviousButton_Click;
            // 
            // previousButton
            // 
            previousButton.Anchor = AnchorStyles.Bottom;
            previousButton.BackColor = Color.Transparent;
            previousButton.BackgroundImageLayout = ImageLayout.Stretch;
            previousButton.Cursor = Cursors.Hand;
            previousButton.Image = (Image)resources.GetObject("previousButton.Image");
            previousButton.Location = new Point(369, 489);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(53, 53);
            previousButton.TabIndex = 15;
            previousButton.TextImageRelation = TextImageRelation.TextAboveImage;
            previousButton.UseVisualStyleBackColor = false;
            previousButton.Click += previousButton_Click;
            // 
            // btnInsert
            // 
            btnInsert.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnInsert.AutoSize = true;
            btnInsert.BackColor = Color.FromArgb(64, 64, 64);
            btnInsert.Cursor = Cursors.Hand;
            btnInsert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(633, 24);
            btnInsert.Margin = new Padding(4, 0, 4, 0);
            btnInsert.Name = "btnInsert";
            btnInsert.Padding = new Padding(12, 14, 12, 16);
            btnInsert.Size = new Size(243, 62);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Thêm phân quyền";
            btnInsert.TextAlign = ContentAlignment.MiddleCenter;
            btnInsert.Click += btnInsert_Click;
            // 
            // pListBG
            // 
            pListBG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pListBG.BackColor = Color.FromArgb(239, 248, 230);
            pListBG.BorderRadius = 20;
            pListBG.Controls.Add(pList);
            pListBG.Controls.Add(pFilter);
            pListBG.Location = new Point(31, 113);
            pListBG.Name = "pListBG";
            pListBG.Size = new Size(848, 373);
            pListBG.TabIndex = 6;
            // 
            // pList
            // 
            pList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pList.ColumnCount = 4;
            pList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pList.Location = new Point(17, 103);
            pList.Name = "pList";
            pList.RowCount = 2;
            pList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pList.Size = new Size(804, 250);
            pList.TabIndex = 5;
            pList.Paint += pList_Paint_1;
            // 
            // pFilter
            // 
            pFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pFilter.BackColor = Color.FromArgb(0, 120, 103);
            pFilter.BorderRadius = 20;
            pFilter.Controls.Add(btnReset);
            pFilter.Controls.Add(pSearch);
            pFilter.Location = new Point(0, 0);
            pFilter.Name = "pFilter";
            pFilter.Size = new Size(845, 82);
            pFilter.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.Location = new Point(775, 13);
            btnReset.Margin = new Padding(4, 5, 4, 5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(46, 54);
            btnReset.SizeMode = PictureBoxSizeMode.StretchImage;
            btnReset.TabIndex = 4;
            btnReset.TabStop = false;
            btnReset.Click += btnReset_Click;
            // 
            // pSearch
            // 
            pSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pSearch.BackColor = Color.White;
            pSearch.BorderRadius = 40;
            pSearch.Controls.Add(txtSearch);
            pSearch.Location = new Point(35, 13);
            pSearch.Name = "pSearch";
            pSearch.Size = new Size(388, 54);
            pSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(17, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm";
            txtSearch.Size = new Size(349, 30);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(31, 24);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(12, 14, 12, 14);
            lblTitle.Size = new Size(220, 73);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Phân quyền";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.UseWaitCursor = true;
            // 
            // PermissionGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(draftPanel);
            Name = "PermissionGUI";
            Size = new Size(915, 545);
            draftPanel.ResumeLayout(false);
            draftPanel.PerformLayout();
            pListBG.ResumeLayout(false);
            pFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnReset).EndInit();
            pSearch.ResumeLayout(false);
            pSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel draftPanel;
        private CustomPanel pListBG;
        private CustomPanel pFilter;
        private Label lblTitle;
        private CustomPanel pSearch;
        private TextBox txtSearch;
        private PictureBox btnReset;
        private TableLayoutPanel pList;
        private Label btnInsert;
        private Button previousButton;
        private Button extraPreviousButton;
        private Button nextButton;
        private Button extraNextButton;
    }
}
