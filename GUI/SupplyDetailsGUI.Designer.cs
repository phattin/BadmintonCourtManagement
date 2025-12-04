using GUI.ComponentsGUI;

namespace BadmintonCourtManagement.GUI
{
    partial class SupplyDetailsGUI
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
            CardListPanel = new TableLayoutPanel();
            cardPanel = new TableLayoutPanel();
            picture = new PictureBox();
            infoPanel = new TableLayoutPanel();
            productID = new Label();
            totalPrice = new Label();
            price = new Label();
            quantity = new Label();
            importDetailID = new Label();
            additionPanel = new TableLayoutPanel();
            status = new Label();
            createAt = new Label();
            toolBar = new TableLayoutPanel();
            endDate = new DateTimePicker();
            endText = new Label();
            searchBar = new TextBox();
            startDate = new DateTimePicker();
            startText = new Label();
            filterButton = new Button();
            SupplyActivePanel = new Panel();
            SupplyActive = new Label();
            SupplyStatusPanel = new Panel();
            SupplyStatus = new Label();
            headerPanel = new TableLayoutPanel();
            TitlePanel = new Panel();
            Title = new Label();
            exportButton = new RoundedButton();
            MainPanel.SuspendLayout();
            CardListPanel.SuspendLayout();
            cardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            infoPanel.SuspendLayout();
            additionPanel.SuspendLayout();
            toolBar.SuspendLayout();
            SupplyActivePanel.SuspendLayout();
            SupplyStatusPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.AutoScroll = true;
            MainPanel.BackColor = Color.FromArgb(239, 248, 230);
            MainPanel.Controls.Add(CardListPanel);
            MainPanel.Controls.Add(toolBar);
            MainPanel.Controls.Add(SupplyActivePanel);
            MainPanel.Controls.Add(SupplyStatusPanel);
            MainPanel.Controls.Add(headerPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(35, 39);
            MainPanel.Margin = new Padding(0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1102, 617);
            MainPanel.TabIndex = 0;
            // 
            // CardListPanel
            // 
            CardListPanel.AutoSize = true;
            CardListPanel.BackColor = Color.FromArgb(239, 248, 230);
            CardListPanel.ColumnCount = 1;
            CardListPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            CardListPanel.Controls.Add(cardPanel, 0, 0);
            CardListPanel.Dock = DockStyle.Top;
            CardListPanel.Location = new Point(0, 221);
            CardListPanel.Margin = new Padding(0);
            CardListPanel.Name = "CardListPanel";
            CardListPanel.RowCount = 6;
            CardListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            CardListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            CardListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            CardListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            CardListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            CardListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            CardListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CardListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CardListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CardListPanel.Size = new Size(1081, 1554);
            CardListPanel.TabIndex = 4;
            // 
            // cardPanel
            // 
            cardPanel.BackColor = Color.FromArgb(200, 250, 214);
            cardPanel.ColumnCount = 3;
            cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            cardPanel.Controls.Add(picture, 0, 0);
            cardPanel.Controls.Add(infoPanel, 1, 0);
            cardPanel.Controls.Add(additionPanel, 2, 0);
            cardPanel.Dock = DockStyle.Fill;
            cardPanel.Location = new Point(20, 20);
            cardPanel.Margin = new Padding(20);
            cardPanel.Name = "cardPanel";
            cardPanel.Padding = new Padding(10);
            cardPanel.RowCount = 1;
            cardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            cardPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            cardPanel.Size = new Size(1041, 219);
            cardPanel.TabIndex = 0;
            // 
            // picture
            // 
            picture.Dock = DockStyle.Fill;
            picture.Image = Properties.Resources.Picture;
            picture.Location = new Point(50, 10);
            picture.Margin = new Padding(40, 0, 40, 0);
            picture.Name = "picture";
            picture.Size = new Size(260, 199);
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
            infoPanel.Location = new Point(350, 10);
            infoPanel.Margin = new Padding(0);
            infoPanel.Name = "infoPanel";
            infoPanel.RowCount = 5;
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            infoPanel.Size = new Size(340, 199);
            infoPanel.TabIndex = 1;
            // 
            // productID
            // 
            productID.Dock = DockStyle.Fill;
            productID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            productID.Location = new Point(0, 39);
            productID.Margin = new Padding(0);
            productID.Name = "productID";
            productID.Size = new Size(340, 39);
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
            totalPrice.Size = new Size(340, 43);
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
            price.Size = new Size(340, 39);
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
            quantity.Size = new Size(340, 39);
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
            importDetailID.Size = new Size(340, 39);
            importDetailID.TabIndex = 0;
            importDetailID.Text = "Mã CT đơn nhập:";
            importDetailID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // additionPanel
            // 
            additionPanel.ColumnCount = 1;
            additionPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            additionPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            additionPanel.Controls.Add(status, 0, 1);
            additionPanel.Controls.Add(createAt, 0, 0);
            additionPanel.Dock = DockStyle.Fill;
            additionPanel.Location = new Point(690, 10);
            additionPanel.Margin = new Padding(0);
            additionPanel.Name = "additionPanel";
            additionPanel.RowCount = 2;
            additionPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            additionPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            additionPanel.Size = new Size(341, 199);
            additionPanel.TabIndex = 2;
            // 
            // status
            // 
            status.Dock = DockStyle.Fill;
            status.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            status.Location = new Point(10, 99);
            status.Margin = new Padding(10, 0, 0, 0);
            status.Name = "status";
            status.Size = new Size(331, 100);
            status.TabIndex = 2;
            status.Text = "Tình trạng:";
            status.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // createAt
            // 
            createAt.Dock = DockStyle.Fill;
            createAt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            createAt.Location = new Point(10, 0);
            createAt.Margin = new Padding(10, 0, 0, 0);
            createAt.Name = "createAt";
            createAt.Size = new Size(331, 99);
            createAt.TabIndex = 1;
            createAt.Text = "Ngày nhập:";
            createAt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolBar
            // 
            toolBar.BackColor = Color.FromArgb(0, 120, 103);
            toolBar.ColumnCount = 6;
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.0795383F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.0964994F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.7861881F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.4615383F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.33846F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.075289F));
            toolBar.Controls.Add(endDate, 4, 0);
            toolBar.Controls.Add(endText, 3, 0);
            toolBar.Controls.Add(searchBar, 0, 0);
            toolBar.Controls.Add(startDate, 2, 0);
            toolBar.Controls.Add(startText, 1, 0);
            toolBar.Controls.Add(filterButton, 5, 0);
            toolBar.Dock = DockStyle.Top;
            toolBar.Location = new Point(0, 135);
            toolBar.Margin = new Padding(0);
            toolBar.Name = "toolBar";
            toolBar.Padding = new Padding(12, 13, 12, 13);
            toolBar.RowCount = 1;
            toolBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            toolBar.Size = new Size(1081, 86);
            toolBar.TabIndex = 3;
            // 
            // endDate
            // 
            endDate.Cursor = Cursors.Hand;
            endDate.CustomFormat = "dd/MM/yyyy";
            endDate.Dock = DockStyle.Fill;
            endDate.DropDownAlign = LeftRightAlignment.Right;
            endDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            endDate.Format = DateTimePickerFormat.Custom;
            endDate.Location = new Point(788, 28);
            endDate.Margin = new Padding(0, 15, 12, 0);
            endDate.Name = "endDate";
            endDate.ShowUpDown = true;
            endDate.Size = new Size(182, 34);
            endDate.TabIndex = 3;
            // 
            // endText
            // 
            endText.AutoSize = true;
            endText.Dock = DockStyle.Fill;
            endText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            endText.ForeColor = Color.White;
            endText.Location = new Point(647, 13);
            endText.Margin = new Padding(12, 0, 0, 0);
            endText.Name = "endText";
            endText.Size = new Size(141, 60);
            endText.TabIndex = 3;
            endText.Text = "Ngày kết thúc:";
            endText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // searchBar
            // 
            searchBar.Cursor = Cursors.IBeam;
            searchBar.Dock = DockStyle.Fill;
            searchBar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            searchBar.Location = new Point(12, 28);
            searchBar.Margin = new Padding(0, 15, 15, 0);
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = "Tìm kiếm...";
            searchBar.Size = new Size(271, 34);
            searchBar.TabIndex = 1;
            // 
            // startDate
            // 
            startDate.Cursor = Cursors.Hand;
            startDate.CustomFormat = "dd/MM/yyyy";
            startDate.Dock = DockStyle.Top;
            startDate.DropDownAlign = LeftRightAlignment.Right;
            startDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            startDate.Format = DateTimePickerFormat.Custom;
            startDate.Location = new Point(447, 28);
            startDate.Margin = new Padding(0, 15, 12, 0);
            startDate.MaxDate = new DateTime(9998, 10, 1, 0, 0, 0, 0);
            startDate.Name = "startDate";
            startDate.ShowUpDown = true;
            startDate.Size = new Size(176, 34);
            startDate.TabIndex = 2;
            startDate.Value = new DateTime(2025, 10, 1, 0, 0, 0, 0);
            // 
            // startText
            // 
            startText.Anchor = AnchorStyles.None;
            startText.AutoSize = true;
            startText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            startText.ForeColor = Color.White;
            startText.Location = new Point(299, 29);
            startText.Margin = new Padding(0);
            startText.Name = "startText";
            startText.Size = new Size(146, 28);
            startText.TabIndex = 2;
            startText.Text = "Ngày bắt đầu:";
            startText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // filterButton
            // 
            filterButton.BackColor = Color.FromArgb(0, 120, 103);
            filterButton.Cursor = Cursors.Hand;
            filterButton.Dock = DockStyle.Fill;
            filterButton.FlatAppearance.BorderSize = 0;
            filterButton.FlatStyle = FlatStyle.Flat;
            filterButton.Image = Properties.Resources.Filter;
            filterButton.Location = new Point(982, 13);
            filterButton.Margin = new Padding(0);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(87, 60);
            filterButton.TabIndex = 4;
            filterButton.UseVisualStyleBackColor = false;
            filterButton.MouseEnter += filterButton_MouseEnter;
            filterButton.MouseLeave += filterButton_MouseLeave;
            // 
            // SupplyActivePanel
            // 
            SupplyActivePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SupplyActivePanel.AutoSize = true;
            SupplyActivePanel.Controls.Add(SupplyActive);
            SupplyActivePanel.Location = new Point(753, 127);
            SupplyActivePanel.Margin = new Padding(0);
            SupplyActivePanel.Name = "SupplyActivePanel";
            SupplyActivePanel.Size = new Size(321, 98);
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
            SupplyActive.Size = new Size(321, 98);
            SupplyActive.TabIndex = 0;
            SupplyActive.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SupplyStatusPanel
            // 
            SupplyStatusPanel.Controls.Add(SupplyStatus);
            SupplyStatusPanel.Dock = DockStyle.Top;
            SupplyStatusPanel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            SupplyStatusPanel.Location = new Point(0, 76);
            SupplyStatusPanel.Margin = new Padding(0);
            SupplyStatusPanel.Name = "SupplyStatusPanel";
            SupplyStatusPanel.Size = new Size(1081, 59);
            SupplyStatusPanel.TabIndex = 1;
            // 
            // SupplyStatus
            // 
            SupplyStatus.Dock = DockStyle.Fill;
            SupplyStatus.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            SupplyStatus.Location = new Point(0, 0);
            SupplyStatus.Margin = new Padding(4, 0, 4, 0);
            SupplyStatus.Name = "SupplyStatus";
            SupplyStatus.Size = new Size(1081, 59);
            SupplyStatus.TabIndex = 0;
            SupplyStatus.Text = "Tình trạng: đang hoạt động";
            SupplyStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // headerPanel
            // 
            headerPanel.ColumnCount = 2;
            headerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.38853F));
            headerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.6114712F));
            headerPanel.Controls.Add(TitlePanel, 0, 0);
            headerPanel.Controls.Add(exportButton, 1, 0);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(0);
            headerPanel.Name = "headerPanel";
            headerPanel.RowCount = 1;
            headerPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            headerPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            headerPanel.Size = new Size(1081, 76);
            headerPanel.TabIndex = 1;
            // 
            // TitlePanel
            // 
            TitlePanel.Controls.Add(Title);
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Margin = new Padding(0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(869, 76);
            TitlePanel.TabIndex = 0;
            // 
            // Title
            // 
            Title.Dock = DockStyle.Fill;
            Title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Title.Location = new Point(0, 0);
            Title.Margin = new Padding(4, 0, 4, 0);
            Title.Name = "Title";
            Title.Size = new Size(869, 76);
            Title.TabIndex = 0;
            Title.Text = "Chi tiết: NH0001";
            Title.TextAlign = ContentAlignment.MiddleLeft;
            Title.Click += Title_Click;
            // 
            // exportButton
            // 
            exportButton.BackColor = Color.Black;
            exportButton.BackgroundColor = Color.Black;
            exportButton.BorderColor = Color.PaleVioletRed;
            exportButton.BorderRadius = 20;
            exportButton.BorderSize = 0;
            exportButton.Cursor = Cursors.Hand;
            exportButton.Dock = DockStyle.Fill;
            exportButton.FlatAppearance.BorderSize = 0;
            exportButton.FlatStyle = FlatStyle.Flat;
            exportButton.ForeColor = Color.White;
            exportButton.Location = new Point(872, 3);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(206, 70);
            exportButton.TabIndex = 1;
            exportButton.Text = "Xuất Dữ Liệu";
            exportButton.TextColor = Color.White;
            exportButton.UseVisualStyleBackColor = false;
            exportButton.Click += exportButton_Click;
            exportButton.MouseEnter += buttonEnter;
            exportButton.MouseHover += buttonLeave;
            // 
            // SupplyDetailsGUI
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 120, 103);
            ClientSize = new Size(1172, 695);
            Controls.Add(MainPanel);
            Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "SupplyDetailsGUI";
            Padding = new Padding(35, 39, 35, 39);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết đơn hàng nhập";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            CardListPanel.ResumeLayout(false);
            cardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            infoPanel.ResumeLayout(false);
            additionPanel.ResumeLayout(false);
            toolBar.ResumeLayout(false);
            toolBar.PerformLayout();
            SupplyActivePanel.ResumeLayout(false);
            SupplyStatusPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            TitlePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Panel SupplyStatusPanel;
        private Label SupplyStatus;
        private Panel SupplyActivePanel;
        private Label SupplyActive;
        private TableLayoutPanel toolBar;
        private DateTimePicker endDate;
        private Label endText;
        private TextBox searchBar;
        private DateTimePicker startDate;
        private Label startText;
        private Button filterButton;
        private TableLayoutPanel CardListPanel;
        private TableLayoutPanel cardPanel;
        private PictureBox picture;
        private TableLayoutPanel infoPanel;
        private TableLayoutPanel additionPanel;
        private Label totalPrice;
        private Label price;
        private Label quantity;
        private Label importDetailID;
        private Label productID;
        private Label status;
        private Label createAt;
        private Panel TitlePanel;
        private Label Title;
        private TableLayoutPanel headerPanel;
        private RoundedButton exportButton;
    }
}