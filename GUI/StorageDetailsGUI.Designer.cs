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
            components = new System.ComponentModel.Container();
            mainPanel = new Panel();
            bodyPanel = new TableLayoutPanel();
            infoPanel = new TableLayoutPanel();
            status = new Label();
            date = new Label();
            totalPrice = new Label();
            price = new Label();
            quantity = new Label();
            productID = new Label();
            importBillID = new Label();
            productImage = new PictureBox();
            TitlePanel = new Panel();
            TitleText = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            mainPanel.SuspendLayout();
            bodyPanel.SuspendLayout();
            infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productImage).BeginInit();
            TitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(239, 248, 230);
            mainPanel.Controls.Add(bodyPanel);
            mainPanel.Controls.Add(TitlePanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(35, 39);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(976, 493);
            mainPanel.TabIndex = 0;
            // 
            // bodyPanel
            // 
            bodyPanel.AutoScroll = true;
            bodyPanel.ColumnCount = 2;
            bodyPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            bodyPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            bodyPanel.Controls.Add(infoPanel, 0, 0);
            bodyPanel.Controls.Add(productImage, 1, 0);
            bodyPanel.Dock = DockStyle.Fill;
            bodyPanel.Location = new Point(0, 83);
            bodyPanel.Margin = new Padding(0);
            bodyPanel.Name = "bodyPanel";
            bodyPanel.Padding = new Padding(20, 0, 2, 20);
            bodyPanel.RowCount = 1;
            bodyPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            bodyPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            bodyPanel.Size = new Size(976, 410);
            bodyPanel.TabIndex = 2;
            // 
            // infoPanel
            // 
            infoPanel.ColumnCount = 1;
            infoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            infoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            infoPanel.Controls.Add(status, 0, 6);
            infoPanel.Controls.Add(date, 0, 5);
            infoPanel.Controls.Add(totalPrice, 0, 4);
            infoPanel.Controls.Add(price, 0, 3);
            infoPanel.Controls.Add(quantity, 0, 2);
            infoPanel.Controls.Add(productID, 0, 1);
            infoPanel.Controls.Add(importBillID, 0, 0);
            infoPanel.Dock = DockStyle.Fill;
            infoPanel.Location = new Point(23, 3);
            infoPanel.Name = "infoPanel";
            infoPanel.RowCount = 7;
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            infoPanel.Size = new Size(471, 384);
            infoPanel.TabIndex = 0;
            // 
            // status
            // 
            status.Dock = DockStyle.Fill;
            status.Font = new Font("Segoe UI", 14F);
            status.Image = Properties.Resources.Active;
            status.ImageAlign = ContentAlignment.MiddleRight;
            status.Location = new Point(0, 324);
            status.Margin = new Padding(0);
            status.Name = "status";
            status.Size = new Size(471, 60);
            status.TabIndex = 6;
            status.Text = "Tình trạng:";
            status.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // date
            // 
            date.Dock = DockStyle.Fill;
            date.Font = new Font("Segoe UI", 14F);
            date.Location = new Point(0, 270);
            date.Margin = new Padding(0);
            date.Name = "date";
            date.Size = new Size(471, 54);
            date.TabIndex = 5;
            date.Text = "Ngày nhập:";
            date.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // totalPrice
            // 
            totalPrice.Dock = DockStyle.Fill;
            totalPrice.Font = new Font("Segoe UI", 14F);
            totalPrice.Location = new Point(0, 216);
            totalPrice.Margin = new Padding(0);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(471, 54);
            totalPrice.TabIndex = 4;
            totalPrice.Text = "Tổng tiền:";
            totalPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // price
            // 
            price.Dock = DockStyle.Fill;
            price.Font = new Font("Segoe UI", 14F);
            price.Location = new Point(0, 162);
            price.Margin = new Padding(0);
            price.Name = "price";
            price.Size = new Size(471, 54);
            price.TabIndex = 3;
            price.Text = "Giá:";
            price.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // quantity
            // 
            quantity.Dock = DockStyle.Fill;
            quantity.Font = new Font("Segoe UI", 14F);
            quantity.Location = new Point(0, 108);
            quantity.Margin = new Padding(0);
            quantity.Name = "quantity";
            quantity.Size = new Size(471, 54);
            quantity.TabIndex = 2;
            quantity.Text = "Số lượng:";
            quantity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // productID
            // 
            productID.Dock = DockStyle.Fill;
            productID.Font = new Font("Segoe UI", 14F);
            productID.Location = new Point(0, 54);
            productID.Margin = new Padding(0);
            productID.Name = "productID";
            productID.Size = new Size(471, 54);
            productID.TabIndex = 1;
            productID.Text = "Mã sản phẩm:";
            productID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // importBillID
            // 
            importBillID.Dock = DockStyle.Fill;
            importBillID.Font = new Font("Segoe UI", 14F);
            importBillID.Location = new Point(0, 0);
            importBillID.Margin = new Padding(0);
            importBillID.Name = "importBillID";
            importBillID.Size = new Size(471, 54);
            importBillID.TabIndex = 0;
            importBillID.Text = "Mã hóa đơn nhập:";
            importBillID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // productImage
            // 
            productImage.Dock = DockStyle.Fill;
            productImage.Image = Properties.Resources.Picture;
            productImage.Location = new Point(527, 30);
            productImage.Margin = new Padding(30);
            productImage.Name = "productImage";
            productImage.Size = new Size(417, 330);
            productImage.SizeMode = PictureBoxSizeMode.StretchImage;
            productImage.TabIndex = 1;
            productImage.TabStop = false;
            // 
            // TitlePanel
            // 
            TitlePanel.Controls.Add(TitleText);
            TitlePanel.Dock = DockStyle.Top;
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Margin = new Padding(0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(976, 83);
            TitlePanel.TabIndex = 1;
            // 
            // TitleText
            // 
            TitleText.Dock = DockStyle.Fill;
            TitleText.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            TitleText.Location = new Point(0, 0);
            TitleText.Margin = new Padding(0);
            TitleText.Name = "TitleText";
            TitleText.Size = new Size(976, 83);
            TitleText.TabIndex = 0;
            TitleText.Text = "Chi tiết:";
            TitleText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // StorageDetailsGUI
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 120, 103);
            ClientSize = new Size(1046, 571);
            Controls.Add(mainPanel);
            Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "StorageDetailsGUI";
            Padding = new Padding(35, 39, 35, 39);
            Text = "Chi tiết kho hàng";
            mainPanel.ResumeLayout(false);
            bodyPanel.ResumeLayout(false);
            infoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productImage).EndInit();
            TitlePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel TitlePanel;
        private Label TitleText;
        private TableLayoutPanel bodyPanel;
        private TableLayoutPanel infoPanel;
        private Label status;
        private Label date;
        private Label totalPrice;
        private Label price;
        private Label quantity;
        private Label productID;
        private Label importBillID;
        private PictureBox productImage;
        private ContextMenuStrip contextMenuStrip1;
    }
}