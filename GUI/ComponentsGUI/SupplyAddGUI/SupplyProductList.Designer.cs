using GUI.ComponentsGUI;

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
            toolBar = new RoundedTableLayoutPanel();
            searchBar = new TextBox();
            filterButton = new Button();
            CardListPanel = new RoundedTableLayoutPanel();
            cardPanel = new RoundedTableLayoutPanel();
            picture = new PictureBox();
            infoPanel = new TableLayoutPanel();
            productID = new Label();
            importDetailID = new Label();
            delete = new RoundedButton();
            TitlePanel.SuspendLayout();
            toolBar.SuspendLayout();
            CardListPanel.SuspendLayout();
            cardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            infoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TitlePanel
            // 
            TitlePanel.Controls.Add(Title);
            TitlePanel.Dock = DockStyle.Top;
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Margin = new Padding(0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(597, 80);
            TitlePanel.TabIndex = 1;
            // 
            // Title
            // 
            Title.Dock = DockStyle.Fill;
            Title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Title.Location = new Point(0, 0);
            Title.Margin = new Padding(4, 0, 4, 0);
            Title.Name = "Title";
            Title.Size = new Size(597, 80);
            Title.TabIndex = 0;
            Title.Text = "Danh sách sản phẩm";
            Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolBar
            // 
            toolBar.BackColor = Color.FromArgb(0, 120, 103);
            toolBar.BorderRadius = 20;
            toolBar.ColumnCount = 2;
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.27107F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.7289314F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            toolBar.Controls.Add(searchBar, 0, 0);
            // Hide filter button from toolbar for this component
            // toolBar.Controls.Add(filterButton, 1, 0);
            toolBar.Dock = DockStyle.Top;
            toolBar.Location = new Point(0, 80);
            toolBar.Margin = new Padding(0);
            toolBar.Name = "toolBar";
            toolBar.Padding = new Padding(12, 13, 12, 13);
            toolBar.RowCount = 1;
            toolBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            toolBar.Size = new Size(597, 86);
            toolBar.TabIndex = 4;
            // 
            // searchBar
            // 
            searchBar.Cursor = Cursors.IBeam;
            searchBar.Dock = DockStyle.Fill;
            searchBar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            searchBar.Location = new Point(12, 28);
            searchBar.Margin = new Padding(0, 15, 0, 0);
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = "Tìm kiếm...";
            searchBar.Size = new Size(505, 34);
            searchBar.TabIndex = 1;
            // 
            // filterButton
            // 
            filterButton.BackColor = Color.FromArgb(0, 120, 103);
            filterButton.Cursor = Cursors.Hand;
            filterButton.Dock = DockStyle.Fill;
            filterButton.FlatAppearance.BorderSize = 0;
            filterButton.FlatStyle = FlatStyle.Flat;
            filterButton.Image = Properties.Resources.Filter;
            filterButton.Location = new Point(517, 13);
            filterButton.Margin = new Padding(0);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(68, 60);
            filterButton.TabIndex = 4;
            filterButton.UseVisualStyleBackColor = false;
            // Hide filter button entirely
            filterButton.Visible = false;
            // Wire Enter key to trigger search
            searchBar.KeyDown += searchBar_KeyDown;
            // 
            // CardListPanel (panel to store product cards)
            // 
            CardListPanel.AutoSize = true;
            CardListPanel.BackColor = Color.FromArgb(239, 248, 230);
            CardListPanel.BorderRadius = 20;
            CardListPanel.ColumnCount = 1;
            CardListPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            CardListPanel.Controls.Add(cardPanel, 0, 0);
            CardListPanel.Dock = DockStyle.Top;
            CardListPanel.Location = new Point(0, 166);
            CardListPanel.Margin = new Padding(0);
            CardListPanel.Name = "CardListPanel";
            CardListPanel.RowCount = 6;
            CardListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            CardListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            CardListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            CardListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            CardListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            CardListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            CardListPanel.Size = new Size(597, 1554);
            CardListPanel.TabIndex = 5;
            // 
            // cardPanel (product card)
            // 
            cardPanel.BackColor = Color.FromArgb(200, 250, 214);
            cardPanel.BorderRadius = 20;
            cardPanel.ColumnCount = 3;
            cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.0044861F));
            cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.5035477F));
            cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5886517F));
            cardPanel.Controls.Add(picture, 0, 0);
            cardPanel.Controls.Add(infoPanel, 1, 0);
            cardPanel.Controls.Add(delete, 2, 0);
            cardPanel.Dock = DockStyle.Fill;
            cardPanel.Location = new Point(20, 20);
            cardPanel.Margin = new Padding(20);
            cardPanel.Name = "cardPanel";
            cardPanel.Padding = new Padding(10);
            cardPanel.RowCount = 1;
            cardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            cardPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            cardPanel.Size = new Size(557, 219);
            cardPanel.TabIndex = 0;
            // 
            // picture
            // 
            picture.Dock = DockStyle.Fill;
            picture.Image = Properties.Resources.Picture;
            picture.Location = new Point(10, 10);
            picture.Margin = new Padding(0, 0, 40, 0);
            picture.Name = "picture";
            picture.Size = new Size(137, 199);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.TabIndex = 0;
            picture.TabStop = false;
            // 
            // infoPanel
            // 
            infoPanel.ColumnCount = 1;
            infoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            infoPanel.Controls.Add(productID, 0, 1);
            infoPanel.Controls.Add(importDetailID, 0, 0);
            infoPanel.Dock = DockStyle.Fill;
            infoPanel.Location = new Point(187, 10);
            infoPanel.Margin = new Padding(0);
            infoPanel.Name = "infoPanel";
            infoPanel.RowCount = 2;
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            infoPanel.Size = new Size(265, 199);
            infoPanel.TabIndex = 1;
            // 
            // productID
            // 
            productID.Dock = DockStyle.Fill;
            productID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            productID.Location = new Point(0, 99);
            productID.Margin = new Padding(0);
            productID.Name = "productID";
            productID.Size = new Size(265, 100);
            productID.TabIndex = 5;
            productID.Text = "Tên sản phẩm:";
            productID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // importDetailID
            // 
            importDetailID.Dock = DockStyle.Fill;
            importDetailID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            importDetailID.Location = new Point(0, 0);
            importDetailID.Margin = new Padding(0);
            importDetailID.Name = "importDetailID";
            importDetailID.Size = new Size(265, 99);
            importDetailID.TabIndex = 0;
            importDetailID.Text = "Mã sản phẩm:";
            importDetailID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // delete
            // 
            delete.BackColor = Color.Black;
            delete.BackgroundColor = Color.Black;
            delete.BorderColor = Color.PaleVioletRed;
            delete.BorderRadius = 20;
            delete.BorderSize = 0;
            delete.Cursor = Cursors.Hand;
            delete.Dock = DockStyle.Fill;
            delete.FlatAppearance.BorderSize = 0;
            delete.FlatStyle = FlatStyle.Flat;
            delete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            delete.ForeColor = Color.White;
            delete.Location = new Point(462, 70);
            delete.Margin = new Padding(10, 60, 10, 60);
            delete.Name = "delete";
            delete.Size = new Size(75, 79);
            delete.TabIndex = 2;
            delete.Text = "Thêm";
            delete.TextColor = Color.White;
            delete.UseVisualStyleBackColor = false;
            delete.MouseEnter += buttonEnter;
            delete.MouseLeave += buttonLeave;
            // 
            // SupplyProductList
            // 
            AutoScaleDimensions = new SizeF(33F, 68F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(CardListPanel);
            Controls.Add(toolBar);
            Controls.Add(TitlePanel);
            Font = new Font("Roboto Medium", 34.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(0);
            Name = "SupplyProductList";
            Size = new Size(597, 1021);
            TitlePanel.ResumeLayout(false);
            toolBar.ResumeLayout(false);
            toolBar.PerformLayout();
            CardListPanel.ResumeLayout(false);
            cardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            infoPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TitlePanel;
        private Label Title;
        private RoundedTableLayoutPanel toolBar;
        private TextBox searchBar;
        private Button filterButton;
        private RoundedTableLayoutPanel CardListPanel;
        private RoundedTableLayoutPanel cardPanel;
        private PictureBox picture;
        private TableLayoutPanel infoPanel;
        private Label productID;
        private Label importDetailID;
        private RoundedButton delete;
    }
}
