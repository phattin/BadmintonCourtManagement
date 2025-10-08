namespace BadmintonCourtManagement.GUI.ComponentsGUI.SupplyAddGUI
{
    partial class SupplyProductList
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
            TitlePanel = new Panel();
            Title = new Label();
            Body = new Panel();
            ListPanel = new TableLayoutPanel();
            AddPanel = new Panel();
            AddButton = new Button();
            PicturePanel = new Panel();
            Picture = new PictureBox();
            BodyPanel = new TableLayoutPanel();
            ProductName = new Label();
            ProductID = new Label();
            SearchPanel = new TableLayoutPanel();
            SearchBar = new TextBox();
            FilterButton = new Button();
            TitlePanel.SuspendLayout();
            Body.SuspendLayout();
            ListPanel.SuspendLayout();
            AddPanel.SuspendLayout();
            PicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Picture).BeginInit();
            BodyPanel.SuspendLayout();
            SearchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TitlePanel
            // 
            TitlePanel.Controls.Add(Title);
            TitlePanel.Dock = DockStyle.Top;
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Margin = new Padding(0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(786, 95);
            TitlePanel.TabIndex = 0;
            // 
            // Title
            // 
            Title.Dock = DockStyle.Fill;
            Title.Font = new Font("Roboto", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(0, 0);
            Title.Name = "Title";
            Title.Size = new Size(786, 95);
            Title.TabIndex = 0;
            Title.Text = "Danh sách sản phẩm";
            Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Body
            // 
            Body.Controls.Add(ListPanel);
            Body.Controls.Add(SearchPanel);
            Body.Dock = DockStyle.Fill;
            Body.Location = new Point(0, 95);
            Body.Name = "Body";
            Body.Size = new Size(786, 926);
            Body.TabIndex = 1;
            // 
            // ListPanel
            // 
            ListPanel.AutoScroll = true;
            ListPanel.BackColor = Color.FromArgb(239, 248, 230);
            ListPanel.ColumnCount = 3;
            ListPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.8804073F));
            ListPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.0890579F));
            ListPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.0305347F));
            ListPanel.Controls.Add(AddPanel, 2, 0);
            ListPanel.Controls.Add(PicturePanel, 0, 0);
            ListPanel.Controls.Add(BodyPanel, 1, 0);
            ListPanel.Dock = DockStyle.Fill;
            ListPanel.Location = new Point(0, 86);
            ListPanel.Margin = new Padding(0);
            ListPanel.Name = "ListPanel";
            ListPanel.RowCount = 2;
            ListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 164F));
            ListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ListPanel.Size = new Size(786, 840);
            ListPanel.TabIndex = 1;
            // 
            // AddPanel
            // 
            AddPanel.BackColor = Color.FromArgb(200, 250, 214);
            AddPanel.Controls.Add(AddButton);
            AddPanel.Dock = DockStyle.Fill;
            AddPanel.Location = new Point(660, 20);
            AddPanel.Margin = new Padding(0, 20, 0, 20);
            AddPanel.Name = "AddPanel";
            AddPanel.Size = new Size(126, 124);
            AddPanel.TabIndex = 2;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(200, 250, 214);
            AddButton.Cursor = Cursors.Hand;
            AddButton.Dock = DockStyle.Fill;
            AddButton.Image = Properties.Resources.Button;
            AddButton.Location = new Point(0, 0);
            AddButton.Margin = new Padding(0);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(126, 124);
            AddButton.TabIndex = 0;
            AddButton.UseVisualStyleBackColor = false;
            // 
            // PicturePanel
            // 
            PicturePanel.BackColor = Color.FromArgb(200, 250, 214);
            PicturePanel.Controls.Add(Picture);
            PicturePanel.Dock = DockStyle.Fill;
            PicturePanel.Location = new Point(0, 20);
            PicturePanel.Margin = new Padding(0, 20, 0, 20);
            PicturePanel.Name = "PicturePanel";
            PicturePanel.Padding = new Padding(30, 10, 30, 10);
            PicturePanel.Size = new Size(227, 124);
            PicturePanel.TabIndex = 0;
            // 
            // Picture
            // 
            Picture.Dock = DockStyle.Fill;
            Picture.Image = Properties.Resources.Picture;
            Picture.Location = new Point(30, 10);
            Picture.Name = "Picture";
            Picture.Size = new Size(167, 104);
            Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture.TabIndex = 0;
            Picture.TabStop = false;
            // 
            // BodyPanel
            // 
            BodyPanel.BackColor = Color.FromArgb(200, 250, 214);
            BodyPanel.ColumnCount = 1;
            BodyPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            BodyPanel.Controls.Add(ProductName, 0, 1);
            BodyPanel.Controls.Add(ProductID, 0, 0);
            BodyPanel.Dock = DockStyle.Fill;
            BodyPanel.Location = new Point(227, 20);
            BodyPanel.Margin = new Padding(0, 20, 0, 20);
            BodyPanel.Name = "BodyPanel";
            BodyPanel.RowCount = 2;
            BodyPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BodyPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BodyPanel.Size = new Size(433, 124);
            BodyPanel.TabIndex = 3;
            // 
            // ProductName
            // 
            ProductName.Dock = DockStyle.Fill;
            ProductName.Font = new Font("Roboto Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductName.Location = new Point(3, 62);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(427, 62);
            ProductName.TabIndex = 1;
            ProductName.Text = "Tên sản phẩm: Giày thể thao";
            ProductName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductID
            // 
            ProductID.Dock = DockStyle.Fill;
            ProductID.Font = new Font("Roboto Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductID.Location = new Point(3, 0);
            ProductID.Name = "ProductID";
            ProductID.Size = new Size(427, 62);
            ProductID.TabIndex = 0;
            ProductID.Text = "Mã sản phẩm: SP0001";
            ProductID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SearchPanel
            // 
            SearchPanel.AutoSize = true;
            SearchPanel.BackColor = Color.FromArgb(0, 120, 103);
            SearchPanel.ColumnCount = 2;
            SearchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.04326F));
            SearchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.9567432F));
            SearchPanel.Controls.Add(SearchBar, 0, 0);
            SearchPanel.Controls.Add(FilterButton, 1, 0);
            SearchPanel.Dock = DockStyle.Top;
            SearchPanel.Location = new Point(0, 0);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.RowCount = 1;
            SearchPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            SearchPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            SearchPanel.Size = new Size(786, 86);
            SearchPanel.TabIndex = 0;
            // 
            // SearchBar
            // 
            SearchBar.Dock = DockStyle.Fill;
            SearchBar.Font = new Font("Roboto Medium", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBar.Location = new Point(15, 15);
            SearchBar.Margin = new Padding(15);
            SearchBar.Name = "SearchBar";
            SearchBar.PlaceholderText = "value...";
            SearchBar.Size = new Size(607, 56);
            SearchBar.TabIndex = 0;
            // 
            // FilterButton
            // 
            FilterButton.BackColor = Color.FromArgb(0, 120, 103);
            FilterButton.Cursor = Cursors.Hand;
            FilterButton.Dock = DockStyle.Fill;
            FilterButton.ForeColor = Color.FromArgb(0, 120, 103);
            FilterButton.Image = Properties.Resources.Filter;
            FilterButton.Location = new Point(667, 0);
            FilterButton.Margin = new Padding(30, 0, 30, 0);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(89, 86);
            FilterButton.TabIndex = 1;
            FilterButton.UseVisualStyleBackColor = false;
            FilterButton.Click += FilterButton_Click;
            FilterButton.MouseEnter += FilterButton_MouseEnter;
            FilterButton.MouseLeave += FilterButton_MouseLeave;
            // 
            // SupplyProductList
            // 
            AutoScaleDimensions = new SizeF(33F, 68F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Body);
            Controls.Add(TitlePanel);
            Font = new Font("Roboto Medium", 34.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(0);
            Name = "SupplyProductList";
            Size = new Size(786, 1021);
            TitlePanel.ResumeLayout(false);
            Body.ResumeLayout(false);
            Body.PerformLayout();
            ListPanel.ResumeLayout(false);
            AddPanel.ResumeLayout(false);
            PicturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Picture).EndInit();
            BodyPanel.ResumeLayout(false);
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TitlePanel;
        private Label Title;
        private Panel Body;
        private TableLayoutPanel SearchPanel;
        private TextBox SearchBar;
        private Button FilterButton;
        private TableLayoutPanel ListPanel;
        private Panel PicturePanel;
        private Panel AddPanel;
        private PictureBox Picture;
        private Button AddButton;
        private TableLayoutPanel BodyPanel;
        private Label ProductName;
        private Label ProductID;
    }
}
