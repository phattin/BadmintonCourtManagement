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
            draftPanel.Margin = new Padding(2);
            draftPanel.Name = "draftPanel";
            draftPanel.Size = new Size(732, 436);
            draftPanel.TabIndex = 0;
            // 
            // extraNextButton
            // 
            extraNextButton.Anchor = AnchorStyles.Bottom;
            extraNextButton.BackColor = Color.Transparent;
            extraNextButton.Cursor = Cursors.Hand;
            extraNextButton.Image = (Image)resources.GetObject("extraNextButton.Image");
            extraNextButton.Location = new Point(439, 391);
            extraNextButton.Margin = new Padding(2);
            extraNextButton.Name = "extraNextButton";
            extraNextButton.Size = new Size(42, 42);
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
            nextButton.Location = new Point(379, 391);
            nextButton.Margin = new Padding(2);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(42, 42);
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
            extraPreviousButton.Location = new Point(236, 391);
            extraPreviousButton.Margin = new Padding(2);
            extraPreviousButton.Name = "extraPreviousButton";
            extraPreviousButton.Size = new Size(42, 42);
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
            previousButton.Location = new Point(295, 391);
            previousButton.Margin = new Padding(2);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(42, 42);
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
            btnInsert.Location = new Point(506, 19);
            btnInsert.Name = "btnInsert";
            btnInsert.Padding = new Padding(10, 11, 10, 13);
            btnInsert.Size = new Size(202, 52);
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
            pListBG.Location = new Point(25, 90);
            pListBG.Margin = new Padding(2);
            pListBG.Name = "pListBG";
            pListBG.Size = new Size(678, 298);
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
            pList.Location = new Point(14, 82);
            pList.Margin = new Padding(2);
            pList.Name = "pList";
            pList.RowCount = 2;
            pList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pList.Size = new Size(643, 200);
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
            pFilter.Margin = new Padding(2);
            pFilter.Name = "pFilter";
            pFilter.Size = new Size(676, 66);
            pFilter.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.Location = new Point(620, 10);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(37, 43);
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
            pSearch.Location = new Point(28, 10);
            pSearch.Margin = new Padding(2);
            pSearch.Name = "pSearch";
            pSearch.Size = new Size(310, 43);
            pSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(14, 10);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm";
            txtSearch.Size = new Size(279, 25);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(25, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(10, 11, 10, 11);
            lblTitle.Size = new Size(186, 60);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Phân quyền";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.UseWaitCursor = true;
            // 
            // PermissionGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(draftPanel);
            Margin = new Padding(2);
            Name = "PermissionGUI";
            Size = new Size(732, 436);
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
