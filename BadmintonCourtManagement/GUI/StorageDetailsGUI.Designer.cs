namespace BadmintonCourtManagement.GUI
{
    partial class StorageDetailsGUI
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
            MainPanel = new Panel();
            PicturePanel = new Panel();
            Picture = new Label();
            ActiveIconPanel = new Panel();
            ActiveIcon = new Label();
            ProductStatusPanel = new Panel();
            ProductStatus = new Label();
            ProductTotalPanel = new Panel();
            ProductTotal = new Label();
            ProductPricePanel = new Panel();
            ProductPrice = new Label();
            ProductQuantityPanel = new Panel();
            ProductQuantity = new Label();
            ProductBrandPanel = new Panel();
            ProductBrand = new Label();
            ProductNamePanel = new Panel();
            ProductName = new Label();
            ProductIDPanel = new Panel();
            ProductID = new Label();
            TitlePanel = new Panel();
            TitleText = new Label();
            MainPanel.SuspendLayout();
            PicturePanel.SuspendLayout();
            ActiveIconPanel.SuspendLayout();
            ProductStatusPanel.SuspendLayout();
            ProductTotalPanel.SuspendLayout();
            ProductPricePanel.SuspendLayout();
            ProductQuantityPanel.SuspendLayout();
            ProductBrandPanel.SuspendLayout();
            ProductNamePanel.SuspendLayout();
            ProductIDPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainPanel.AutoScroll = true;
            MainPanel.BackColor = Color.FromArgb(200, 250, 214);
            MainPanel.Controls.Add(PicturePanel);
            MainPanel.Controls.Add(ActiveIconPanel);
            MainPanel.Controls.Add(ProductStatusPanel);
            MainPanel.Controls.Add(ProductTotalPanel);
            MainPanel.Controls.Add(ProductPricePanel);
            MainPanel.Controls.Add(ProductQuantityPanel);
            MainPanel.Controls.Add(ProductBrandPanel);
            MainPanel.Controls.Add(ProductNamePanel);
            MainPanel.Controls.Add(ProductIDPanel);
            MainPanel.Controls.Add(TitlePanel);
            MainPanel.Location = new Point(61, 59);
            MainPanel.Margin = new Padding(0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1488, 837);
            MainPanel.TabIndex = 0;
            // 
            // PicturePanel
            // 
            PicturePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PicturePanel.AutoSize = true;
            PicturePanel.Controls.Add(Picture);
            PicturePanel.Location = new Point(843, 171);
            PicturePanel.Name = "PicturePanel";
            PicturePanel.Size = new Size(592, 604);
            PicturePanel.TabIndex = 10;
            // 
            // Picture
            // 
            Picture.Dock = DockStyle.Fill;
            Picture.Image = Properties.Resources.Picture;
            Picture.Location = new Point(0, 0);
            Picture.Margin = new Padding(0);
            Picture.Name = "Picture";
            Picture.Size = new Size(592, 604);
            Picture.TabIndex = 0;
            // 
            // ActiveIconPanel
            // 
            ActiveIconPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ActiveIconPanel.AutoSize = true;
            ActiveIconPanel.Controls.Add(ActiveIcon);
            ActiveIconPanel.Location = new Point(723, 718);
            ActiveIconPanel.Margin = new Padding(0);
            ActiveIconPanel.Name = "ActiveIconPanel";
            ActiveIconPanel.Size = new Size(765, 57);
            ActiveIconPanel.TabIndex = 9;
            // 
            // ActiveIcon
            // 
            ActiveIcon.Dock = DockStyle.Left;
            ActiveIcon.Font = new Font("Roboto Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ActiveIcon.Image = Properties.Resources.Active;
            ActiveIcon.ImageAlign = ContentAlignment.MiddleLeft;
            ActiveIcon.Location = new Point(0, 0);
            ActiveIcon.Margin = new Padding(0);
            ActiveIcon.Name = "ActiveIcon";
            ActiveIcon.Size = new Size(765, 57);
            ActiveIcon.TabIndex = 0;
            ActiveIcon.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductStatusPanel
            // 
            ProductStatusPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductStatusPanel.AutoSize = true;
            ProductStatusPanel.Controls.Add(ProductStatus);
            ProductStatusPanel.Location = new Point(125, 718);
            ProductStatusPanel.Margin = new Padding(0);
            ProductStatusPanel.Name = "ProductStatusPanel";
            ProductStatusPanel.Size = new Size(1363, 57);
            ProductStatusPanel.TabIndex = 8;
            // 
            // ProductStatus
            // 
            ProductStatus.Dock = DockStyle.Fill;
            ProductStatus.Font = new Font("Roboto Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductStatus.Location = new Point(0, 0);
            ProductStatus.Margin = new Padding(0);
            ProductStatus.Name = "ProductStatus";
            ProductStatus.Size = new Size(1363, 57);
            ProductStatus.TabIndex = 0;
            ProductStatus.Text = "Tình trạng: đang hoạt động";
            ProductStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductTotalPanel
            // 
            ProductTotalPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductTotalPanel.AutoSize = true;
            ProductTotalPanel.Controls.Add(ProductTotal);
            ProductTotalPanel.Location = new Point(125, 626);
            ProductTotalPanel.Margin = new Padding(0);
            ProductTotalPanel.Name = "ProductTotalPanel";
            ProductTotalPanel.Size = new Size(1363, 57);
            ProductTotalPanel.TabIndex = 7;
            // 
            // ProductTotal
            // 
            ProductTotal.Dock = DockStyle.Fill;
            ProductTotal.Font = new Font("Roboto Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductTotal.Location = new Point(0, 0);
            ProductTotal.Margin = new Padding(0);
            ProductTotal.Name = "ProductTotal";
            ProductTotal.Size = new Size(1363, 57);
            ProductTotal.TabIndex = 0;
            ProductTotal.Text = "Thành tiền: 10.000.000đ";
            ProductTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductPricePanel
            // 
            ProductPricePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductPricePanel.AutoSize = true;
            ProductPricePanel.Controls.Add(ProductPrice);
            ProductPricePanel.Location = new Point(125, 540);
            ProductPricePanel.Margin = new Padding(0);
            ProductPricePanel.Name = "ProductPricePanel";
            ProductPricePanel.Size = new Size(1363, 57);
            ProductPricePanel.TabIndex = 6;
            // 
            // ProductPrice
            // 
            ProductPrice.Dock = DockStyle.Fill;
            ProductPrice.Font = new Font("Roboto Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductPrice.Location = new Point(0, 0);
            ProductPrice.Margin = new Padding(0);
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Size = new Size(1363, 57);
            ProductPrice.TabIndex = 0;
            ProductPrice.Text = "Đơn giá: 100.000đ";
            ProductPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductQuantityPanel
            // 
            ProductQuantityPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductQuantityPanel.AutoSize = true;
            ProductQuantityPanel.Controls.Add(ProductQuantity);
            ProductQuantityPanel.Location = new Point(125, 444);
            ProductQuantityPanel.Margin = new Padding(0);
            ProductQuantityPanel.Name = "ProductQuantityPanel";
            ProductQuantityPanel.Size = new Size(1363, 57);
            ProductQuantityPanel.TabIndex = 5;
            // 
            // ProductQuantity
            // 
            ProductQuantity.Dock = DockStyle.Fill;
            ProductQuantity.Font = new Font("Roboto Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductQuantity.Location = new Point(0, 0);
            ProductQuantity.Margin = new Padding(0);
            ProductQuantity.Name = "ProductQuantity";
            ProductQuantity.Size = new Size(1363, 57);
            ProductQuantity.TabIndex = 0;
            ProductQuantity.Text = "Số lượng: 100";
            ProductQuantity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductBrandPanel
            // 
            ProductBrandPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductBrandPanel.AutoSize = true;
            ProductBrandPanel.Controls.Add(ProductBrand);
            ProductBrandPanel.Location = new Point(125, 355);
            ProductBrandPanel.Margin = new Padding(0);
            ProductBrandPanel.Name = "ProductBrandPanel";
            ProductBrandPanel.Size = new Size(1363, 57);
            ProductBrandPanel.TabIndex = 4;
            // 
            // ProductBrand
            // 
            ProductBrand.Dock = DockStyle.Fill;
            ProductBrand.Font = new Font("Roboto Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductBrand.Location = new Point(0, 0);
            ProductBrand.Margin = new Padding(0);
            ProductBrand.Name = "ProductBrand";
            ProductBrand.Size = new Size(1363, 57);
            ProductBrand.TabIndex = 0;
            ProductBrand.Text = "Hãng sản xuất: Nike";
            ProductBrand.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductNamePanel
            // 
            ProductNamePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductNamePanel.AutoSize = true;
            ProductNamePanel.Controls.Add(ProductName);
            ProductNamePanel.Location = new Point(125, 266);
            ProductNamePanel.Margin = new Padding(0);
            ProductNamePanel.Name = "ProductNamePanel";
            ProductNamePanel.Size = new Size(1363, 57);
            ProductNamePanel.TabIndex = 3;
            // 
            // ProductName
            // 
            ProductName.Dock = DockStyle.Fill;
            ProductName.Font = new Font("Roboto Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductName.Location = new Point(0, 0);
            ProductName.Margin = new Padding(0);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(1363, 57);
            ProductName.TabIndex = 0;
            ProductName.Text = "Tên sản phẩm: Giày thể thao";
            ProductName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductIDPanel
            // 
            ProductIDPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductIDPanel.AutoSize = true;
            ProductIDPanel.Controls.Add(ProductID);
            ProductIDPanel.Location = new Point(125, 171);
            ProductIDPanel.Margin = new Padding(0);
            ProductIDPanel.Name = "ProductIDPanel";
            ProductIDPanel.Size = new Size(1363, 57);
            ProductIDPanel.TabIndex = 1;
            // 
            // ProductID
            // 
            ProductID.Dock = DockStyle.Fill;
            ProductID.Font = new Font("Roboto Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductID.Location = new Point(0, 0);
            ProductID.Margin = new Padding(0);
            ProductID.Name = "ProductID";
            ProductID.Size = new Size(1363, 57);
            ProductID.TabIndex = 0;
            ProductID.Text = "Mã sản phẩm: SP0001";
            ProductID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TitlePanel
            // 
            TitlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitlePanel.AutoSize = true;
            TitlePanel.Controls.Add(TitleText);
            TitlePanel.Location = new Point(125, 0);
            TitlePanel.Margin = new Padding(0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(1363, 94);
            TitlePanel.TabIndex = 0;
            // 
            // TitleText
            // 
            TitleText.Dock = DockStyle.Fill;
            TitleText.Font = new Font("Roboto", 42F, FontStyle.Bold);
            TitleText.Location = new Point(0, 0);
            TitleText.Margin = new Padding(0);
            TitleText.Name = "TitleText";
            TitleText.Size = new Size(1363, 94);
            TitleText.TabIndex = 0;
            TitleText.Text = "Chi tiết: KH0001";
            TitleText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StorageDetailsGUI
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 120, 103);
            ClientSize = new Size(1613, 955);
            Controls.Add(MainPanel);
            Font = new Font("Roboto", 12F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "StorageDetailsGUI";
            Text = "Chi tiết kho hàng";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            PicturePanel.ResumeLayout(false);
            ActiveIconPanel.ResumeLayout(false);
            ProductStatusPanel.ResumeLayout(false);
            ProductTotalPanel.ResumeLayout(false);
            ProductPricePanel.ResumeLayout(false);
            ProductQuantityPanel.ResumeLayout(false);
            ProductBrandPanel.ResumeLayout(false);
            ProductNamePanel.ResumeLayout(false);
            ProductIDPanel.ResumeLayout(false);
            TitlePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Panel TitlePanel;
        private Label TitleText;
        private Panel ProductIDPanel;
        private Label ProductID;
        private Panel ProductTotalPanel;
        private Label ProductTotal;
        private Panel ProductPricePanel;
        private Label ProductPrice;
        private Panel ProductQuantityPanel;
        private Label ProductQuantity;
        private Panel ProductBrandPanel;
        private Label ProductBrand;
        private Panel ProductNamePanel;
        private Label ProductName;
        private Panel ProductStatusPanel;
        private Label ProductStatus;
        private Panel ActiveIconPanel;
        private Label ActiveIcon;
        private Panel PicturePanel;
        private Label Picture;
    }
}