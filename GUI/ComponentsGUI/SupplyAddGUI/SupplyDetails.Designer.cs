using GUI.ComponentsGUI;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI.ComponentsGUI.SupplyAddGUI
{
    partial class SupplyDetails
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
            Body = new Panel();
            MainPanel = new Panel();
            CardListPanel = new RoundedTableLayoutPanel();
            cardPanel = new RoundedTableLayoutPanel();
            picture = new PictureBox();
            infoPanel = new TableLayoutPanel();
            productID = new Label();
            totalPrice = new Label();
            price = new Label();
            quantity = new Label();
            importDetailID = new Label();
            delete = new RoundedButton();
            toolBar = new RoundedTableLayoutPanel();
            searchBar = new TextBox();
            filterButton = new Button();
            SupplyActivePanel = new Panel();
            SupplyActive = new Label();
            TitlePanel = new Panel();
            Title = new Label();
            Body.SuspendLayout();
            MainPanel.SuspendLayout();
            CardListPanel.SuspendLayout();
            cardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            infoPanel.SuspendLayout();
            toolBar.SuspendLayout();
            SupplyActivePanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // Body
            // 
            Body.Controls.Add(MainPanel);
            Body.Dock = DockStyle.Fill;
            Body.Location = new Point(0, 0);
            Body.Margin = new Padding(1);
            Body.Name = "Body";
            Body.Size = new Size(1196, 766);
            Body.TabIndex = 1;
            // 
            // MainPanel
            // 
            MainPanel.AutoScroll = true;
            MainPanel.BackColor = Color.FromArgb(239, 248, 230);
            MainPanel.Controls.Add(CardListPanel);
            MainPanel.Controls.Add(toolBar);
            MainPanel.Controls.Add(SupplyActivePanel);
            MainPanel.Controls.Add(TitlePanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Margin = new Padding(0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1196, 766);
            MainPanel.TabIndex = 1;
            // 
            // CardListPanel
            // 
            CardListPanel.AutoSize = true;
            CardListPanel.BackColor = Color.FromArgb(239, 248, 230);
            CardListPanel.BorderRadius = 20;
            CardListPanel.ColumnCount = 1;
            CardListPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            // CardListPanel.Controls.Add(cardPanel, 0, 0);
            CardListPanel.Dock = DockStyle.Top;
            CardListPanel.Location = new Point(0, 166);
            CardListPanel.Margin = new Padding(0);
            CardListPanel.Name = "CardListPanel";
            // CardListPanel.RowCount = 6;
            // CardListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            // CardListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            // CardListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            // CardListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            // CardListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            // CardListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            // CardListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            // CardListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            // CardListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CardListPanel.Size = new Size(1175, 1554);
            CardListPanel.TabIndex = 4;
            // 
            // cardPanel
            // 
            cardPanel.BackColor = Color.FromArgb(200, 250, 214);
            cardPanel.BorderRadius = 20;
            cardPanel.ColumnCount = 3;
            cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.0044861F));
            cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.9641266F));
            cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.9417038F));
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
            cardPanel.Size = new Size(1135, 219);
            cardPanel.TabIndex = 0;
            // 
            // picture
            // 
            picture.Dock = DockStyle.Fill;
            picture.Image = Properties.Resources.Picture;
            picture.Location = new Point(10, 10);
            picture.Margin = new Padding(0, 0, 40, 0);
            picture.Name = "picture";
            picture.Size = new Size(328, 199);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.TabIndex = 0;
            picture.TabStop = false;
            // 
            // infoPanel
            // 
            infoPanel.ColumnCount = 1;
            infoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            infoPanel.Controls.Add(productID, 0, 1);
            infoPanel.Controls.Add(totalPrice, 0, 4);
            infoPanel.Controls.Add(price, 0, 3);
            infoPanel.Controls.Add(quantity, 0, 2);
            infoPanel.Controls.Add(importDetailID, 0, 0);
            infoPanel.Dock = DockStyle.Fill;
            infoPanel.Location = new Point(378, 10);
            infoPanel.Margin = new Padding(0);
            infoPanel.Name = "infoPanel";
            infoPanel.RowCount = 5;
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            infoPanel.Size = new Size(624, 199);
            infoPanel.TabIndex = 1;
            // 
            // productID
            // 
            productID.Dock = DockStyle.Fill;
            productID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            productID.Location = new Point(0, 39);
            productID.Margin = new Padding(0);
            productID.Name = "productID";
            productID.Size = new Size(624, 39);
            productID.TabIndex = 5;
            productID.Text = "Mã sản phẩm:";
            productID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // totalPrice
            // 
            totalPrice.Dock = DockStyle.Fill;
            totalPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            totalPrice.Location = new Point(0, 156);
            totalPrice.Margin = new Padding(0);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(624, 43);
            totalPrice.TabIndex = 4;
            totalPrice.Text = "Tổng tiền:";
            totalPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // price
            // 
            price.Dock = DockStyle.Fill;
            price.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            price.Location = new Point(0, 117);
            price.Margin = new Padding(0);
            price.Name = "price";
            price.Size = new Size(624, 39);
            price.TabIndex = 3;
            price.Text = "Giá:";
            price.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // quantity
            // 
            quantity.Dock = DockStyle.Fill;
            quantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            quantity.Location = new Point(0, 78);
            quantity.Margin = new Padding(0);
            quantity.Name = "quantity";
            quantity.Size = new Size(624, 39);
            quantity.TabIndex = 2;
            quantity.Text = "Số lượng:";
            quantity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // importDetailID
            // 
            importDetailID.Dock = DockStyle.Fill;
            importDetailID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            importDetailID.Location = new Point(0, 0);
            importDetailID.Margin = new Padding(0);
            importDetailID.Name = "importDetailID";
            importDetailID.Size = new Size(624, 39);
            importDetailID.TabIndex = 0;
            importDetailID.Text = "Mã CT đơn nhập:";
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
            delete.Location = new Point(1012, 70);
            delete.Margin = new Padding(10, 60, 10, 60);
            delete.Name = "delete";
            delete.Size = new Size(103, 79);
            delete.TabIndex = 2;
            delete.Text = "Xóa";
            delete.TextColor = Color.White;
            delete.UseVisualStyleBackColor = false;
            delete.MouseEnter += buttonEnter;
            delete.MouseLeave += buttonLeave;
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
            toolBar.Controls.Add(filterButton, 1, 0);
            toolBar.Dock = DockStyle.Top;
            toolBar.Location = new Point(0, 80);
            toolBar.Margin = new Padding(0);
            toolBar.Name = "toolBar";
            toolBar.Padding = new Padding(12, 13, 12, 13);
            toolBar.RowCount = 1;
            toolBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            toolBar.Size = new Size(1175, 86);
            toolBar.TabIndex = 3;
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
            searchBar.Size = new Size(1016, 34);
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
            filterButton.Location = new Point(1028, 13);
            filterButton.Margin = new Padding(0);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(135, 60);
            filterButton.TabIndex = 4;
            filterButton.UseVisualStyleBackColor = false;
            filterButton.MouseEnter += FilterButton_MouseEnter;
            filterButton.MouseLeave += FilterButton_MouseLeave;
            // 
            // SupplyActivePanel
            // 
            SupplyActivePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SupplyActivePanel.AutoSize = true;
            SupplyActivePanel.Controls.Add(SupplyActive);
            SupplyActivePanel.Location = new Point(753, 127);
            SupplyActivePanel.Margin = new Padding(0);
            SupplyActivePanel.Name = "SupplyActivePanel";
            SupplyActivePanel.Size = new Size(1317, 98);
            SupplyActivePanel.TabIndex = 2;
            // 
            // SupplyActive
            // 
            SupplyActive.Dock = DockStyle.Fill;
            SupplyActive.Font = new Font("Roboto Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SupplyActive.ImageAlign = ContentAlignment.MiddleLeft;
            SupplyActive.Location = new Point(0, 0);
            SupplyActive.Margin = new Padding(4, 0, 4, 0);
            SupplyActive.Name = "SupplyActive";
            SupplyActive.Size = new Size(1317, 98);
            SupplyActive.TabIndex = 0;
            SupplyActive.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TitlePanel
            // 
            TitlePanel.Controls.Add(Title);
            TitlePanel.Dock = DockStyle.Top;
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Margin = new Padding(0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(1175, 80);
            TitlePanel.TabIndex = 0;
            // 
            // Title
            // 
            Title.Dock = DockStyle.Fill;
            Title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Title.Location = new Point(0, 0);
            Title.Margin = new Padding(4, 0, 4, 0);
            Title.Name = "Title";
            Title.Size = new Size(1175, 80);
            Title.TabIndex = 0;
            Title.Text = "Chi tiết đơn hàng nhập: ";
            Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SupplyDetails
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(Body);
            Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            Margin = new Padding(0);
            Name = "SupplyDetails";
            Size = new Size(1196, 766);
            Body.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            CardListPanel.ResumeLayout(false);
            cardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            infoPanel.ResumeLayout(false);
            toolBar.ResumeLayout(false);
            toolBar.PerformLayout();
            SupplyActivePanel.ResumeLayout(false);
            TitlePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel Body;
        private Panel MainPanel;
        private RoundedTableLayoutPanel CardListPanel;
        private RoundedTableLayoutPanel cardPanel;
        private PictureBox picture;
        private TableLayoutPanel infoPanel;
        private Label productID;
        private Label totalPrice;
        private Label price;
        private Label quantity;
        private Label importDetailID;
        private RoundedTableLayoutPanel toolBar;
        private TextBox searchBar;
        private Button filterButton;
        private Panel SupplyActivePanel;
        private Label SupplyActive;
        private Panel TitlePanel;
        private Label Title;
        private RoundedButton delete;
    }
}
