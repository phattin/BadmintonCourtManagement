
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using BadmintonCourtManagement.GUI; // namespace root

namespace BadmintonCourtManagement.GUI
{
    partial class ProductSaleGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            components = new Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            toolBar = new CustomPanel();
            searchPanel = new CustomPanel();
            btnDelete = new PictureBox();
            searchBar = new TextBox();
            filterButton = new PictureBox();
            btnAddInvoice = new Label();
            titlePanel = new Panel();
            titleText = new Label();
            bigPanel = new Panel();
            bodyPanel = new TableLayoutPanel();
            productListPanel = new Panel();
            pSaleProductList = new TableLayoutPanel();
            dtv = new DataGridView();
            propertyPanel = new Panel();
            tableLayoutPanel_property = new TableLayoutPanel();
            tableLayoutPanel_productQuantity = new TableLayoutPanel();
            lbl_productName = new Label();
            txt_productQuantity = new TextBox();
            txt_productName = new TextBox();
            lbl_productQuantity = new Label();
            tableLayoutPanel_price = new TableLayoutPanel();
            txt_priceExchange = new TextBox();
            txt_priceCustomerPay = new TextBox();
            lbl_totalPrice = new Label();
            lbl_priceCustomerPay = new Label();
            lbl_priceExchange = new Label();
            txt_totalPrice = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            toolBar.SuspendLayout();
            searchPanel.SuspendLayout();
            ((ISupportInitialize)btnDelete).BeginInit();
            ((ISupportInitialize)filterButton).BeginInit();
            titlePanel.SuspendLayout();
            bigPanel.SuspendLayout();
            bodyPanel.SuspendLayout();
            productListPanel.SuspendLayout();
            pSaleProductList.SuspendLayout();
            ((ISupportInitialize)dtv).BeginInit();
            propertyPanel.SuspendLayout();
            tableLayoutPanel_property.SuspendLayout();
            tableLayoutPanel_productQuantity.SuspendLayout();
            tableLayoutPanel_price.SuspendLayout();
            ((ISupportInitialize)errorProvider1).BeginInit();
            ((ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // toolBar
            // 
            toolBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            toolBar.BackColor = Color.FromArgb(0, 120, 103);
            toolBar.BorderRadius = 20;
            toolBar.Controls.Add(searchPanel);
            toolBar.Controls.Add(filterButton);
            toolBar.Location = new Point(3, 4);
            toolBar.Margin = new Padding(3, 4, 3, 4);
            toolBar.Name = "toolBar";
            toolBar.Size = new Size(1140, 71);
            toolBar.TabIndex = 0;
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.White;
            searchPanel.BorderRadius = 30;
            searchPanel.Controls.Add(btnDelete);
            searchPanel.Controls.Add(searchBar);
            searchPanel.Location = new Point(15, 12);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(520, 51);
            searchPanel.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Location = new Point(490, 19);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(13, 13);
            btnDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            btnDelete.TabIndex = 0;
            btnDelete.TabStop = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // searchBar
            // 
            searchBar.Anchor = AnchorStyles.None;
            searchBar.BorderStyle = BorderStyle.None;
            searchBar.Cursor = Cursors.IBeam;
            searchBar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBar.ForeColor = Color.Black;
            searchBar.Location = new Point(14, 13);
            searchBar.Margin = new Padding(0, 0, 10, 0);
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = "Tìm sản phẩm...";
            searchBar.Size = new Size(510, 20);
            searchBar.TabIndex = 1;
            searchBar.KeyDown += searchEnterEvent;
            // 
            // filterButton
            // 
            filterButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filterButton.Cursor = Cursors.Hand;
            filterButton.Location = new Point(1078, 12);
            filterButton.Margin = new Padding(3, 4, 3, 4);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(48, 41);
            filterButton.SizeMode = PictureBoxSizeMode.StretchImage;
            filterButton.TabIndex = 1;
            filterButton.TabStop = false;
            filterButton.MouseEnter += filterButton_MouseEnter;
            filterButton.MouseLeave += filterButton_MouseLeave;
            // 
            // btnAddInvoice
            // 
            btnAddInvoice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddInvoice.AutoSize = true;
            btnAddInvoice.BackColor = Color.FromArgb(64, 64, 64);
            btnAddInvoice.Cursor = Cursors.Hand;
            btnAddInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddInvoice.ForeColor = Color.White;
            btnAddInvoice.Location = new Point(1079, 22);
            btnAddInvoice.Name = "btnAddInvoice";
            btnAddInvoice.Padding = new Padding(10, 11, 10, 13);
            btnAddInvoice.Size = new Size(142, 52);
            btnAddInvoice.TabIndex = 2;
            btnAddInvoice.Text = "Thêm / Bán";
            btnAddInvoice.TextAlign = ContentAlignment.MiddleCenter;
            btnAddInvoice.Click += btnAddProduct_Click;
            // 
            // titlePanel
            // 
            titlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titlePanel.AutoSize = true;
            titlePanel.Controls.Add(titleText);
            titlePanel.Location = new Point(0, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(1243, 100);
            titlePanel.TabIndex = 0;
            // 
            // titleText
            // 
            titleText.AutoSize = true;
            titleText.BackColor = Color.White;
            titleText.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleText.ForeColor = Color.Black;
            titleText.Location = new Point(53, 15);
            titleText.Name = "titleText";
            titleText.Padding = new Padding(10, 11, 10, 11);
            titleText.Size = new Size(217, 60);
            titleText.TabIndex = 0;
            titleText.Text = "Bán sản phẩm";
            titleText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bigPanel
            // 
            bigPanel.BackColor = Color.White;
            bigPanel.Controls.Add(bodyPanel);
            bigPanel.Controls.Add(btnAddInvoice);
            bigPanel.Controls.Add(titlePanel);
            bigPanel.Dock = DockStyle.Fill;
            bigPanel.Location = new Point(0, 0);
            bigPanel.Name = "bigPanel";
            bigPanel.Size = new Size(1243, 719);
            bigPanel.TabIndex = 0;
            // 
            // bodyPanel
            // 
            bodyPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bodyPanel.BackColor = Color.FromArgb(239, 248, 230);
            bodyPanel.ColumnCount = 1;
            bodyPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            bodyPanel.Controls.Add(toolBar, 0, 0);
            bodyPanel.Controls.Add(productListPanel, 0, 1);
            bodyPanel.Location = new Point(56, 79);
            bodyPanel.Margin = new Padding(3, 4, 3, 4);
            bodyPanel.Name = "bodyPanel";
            bodyPanel.RowCount = 2;
            bodyPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            bodyPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            bodyPanel.Size = new Size(1146, 527);
            bodyPanel.TabIndex = 0;
            // 
            // productListPanel
            // 
            productListPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productListPanel.AutoScroll = true;
            productListPanel.BackColor = Color.FromArgb(239, 248, 230);
            productListPanel.Controls.Add(pSaleProductList);
            productListPanel.Location = new Point(3, 82);
            productListPanel.Name = "productListPanel";
            productListPanel.Size = new Size(1140, 442);
            productListPanel.TabIndex = 1;
            // 
            // pSaleProductList
            // 
            pSaleProductList.ColumnCount = 1;
            pSaleProductList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pSaleProductList.Controls.Add(dtv, 0, 0);
            pSaleProductList.Controls.Add(propertyPanel, 0, 1);
            pSaleProductList.Dock = DockStyle.Fill;
            pSaleProductList.Location = new Point(0, 0);
            pSaleProductList.Name = "pSaleProductList";
            pSaleProductList.Padding = new Padding(10);
            pSaleProductList.RowCount = 2;
            pSaleProductList.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            pSaleProductList.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            pSaleProductList.Size = new Size(1140, 442);
            pSaleProductList.TabIndex = 0;
            // 
            // dtv
            // 
            dtv.AllowUserToAddRows = false;
            dtv.AllowUserToDeleteRows = false;
            dtv.AllowUserToResizeColumns = false;
            dtv.AllowUserToResizeRows = false;
            dtv.BackgroundColor = Color.FromArgb(239, 248, 230);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(239, 248, 230);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(200, 255, 230);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtv.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(239, 248, 230);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(200, 255, 230);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtv.DefaultCellStyle = dataGridViewCellStyle2;
            dtv.Dock = DockStyle.Fill;
            dtv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtv.Location = new Point(13, 13);
            dtv.MultiSelect = false;
            dtv.Name = "dtv";
            dtv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(239, 248, 230);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(200, 255, 230);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtv.RowHeadersVisible = false;
            dtv.RowHeadersWidth = 51;
            dtv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtv.Size = new Size(1114, 289);
            dtv.TabIndex = 0;
            // 
            // propertyPanel
            // 
            propertyPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            propertyPanel.Controls.Add(tableLayoutPanel_property);
            propertyPanel.ForeColor = Color.Black;
            propertyPanel.Location = new Point(13, 308);
            propertyPanel.Name = "propertyPanel";
            propertyPanel.Size = new Size(1114, 121);
            propertyPanel.TabIndex = 1;
            // 
            // tableLayoutPanel_property
            // 
            tableLayoutPanel_property.ColumnCount = 2;
            tableLayoutPanel_property.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_property.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_property.Controls.Add(tableLayoutPanel_productQuantity, 0, 0);
            tableLayoutPanel_property.Controls.Add(tableLayoutPanel_price, 1, 0);
            tableLayoutPanel_property.Dock = DockStyle.Fill;
            tableLayoutPanel_property.Location = new Point(0, 0);
            tableLayoutPanel_property.Name = "tableLayoutPanel_property";
            tableLayoutPanel_property.Padding = new Padding(30, 0, 30, 0);
            tableLayoutPanel_property.RowCount = 1;
            tableLayoutPanel_property.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_property.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_property.Size = new Size(1114, 121);
            tableLayoutPanel_property.TabIndex = 0;
            // 
            // tableLayoutPanel_productQuantity
            // 
            tableLayoutPanel_productQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel_productQuantity.ColumnCount = 2;
            tableLayoutPanel_productQuantity.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel_productQuantity.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel_productQuantity.Controls.Add(lbl_productName, 0, 0);
            tableLayoutPanel_productQuantity.Controls.Add(txt_productQuantity, 1, 1);
            tableLayoutPanel_productQuantity.Controls.Add(txt_productName, 1, 0);
            tableLayoutPanel_productQuantity.Controls.Add(lbl_productQuantity, 0, 1);
            tableLayoutPanel_productQuantity.Location = new Point(33, 3);
            tableLayoutPanel_productQuantity.Name = "tableLayoutPanel_productQuantity";
            tableLayoutPanel_productQuantity.Padding = new Padding(20, 0, 0, 0);
            tableLayoutPanel_productQuantity.RowCount = 2;
            tableLayoutPanel_productQuantity.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_productQuantity.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_productQuantity.Size = new Size(521, 115);
            tableLayoutPanel_productQuantity.TabIndex = 0;
            // 
            // lbl_productName
            // 
            lbl_productName.Anchor = AnchorStyles.None;
            lbl_productName.AutoSize = true;
            lbl_productName.Font = new Font("Segoe UI", 10F);
            lbl_productName.Location = new Point(32, 17);
            lbl_productName.Name = "lbl_productName";
            lbl_productName.Size = new Size(125, 23);
            lbl_productName.TabIndex = 0;
            lbl_productName.Text = "Tên sản phẩm: ";
            // 
            // txt_productQuantity
            // 
            txt_productQuantity.Anchor = AnchorStyles.Left;
            txt_productQuantity.BackColor = Color.FromArgb(239, 248, 230);
            txt_productQuantity.BorderStyle = BorderStyle.FixedSingle;
            txt_productQuantity.Font = new Font("Segoe UI", 10F);
            txt_productQuantity.ForeColor = Color.Black;
            txt_productQuantity.Location = new Point(173, 71);
            txt_productQuantity.Name = "txt_productQuantity";
            txt_productQuantity.Size = new Size(125, 30);
            txt_productQuantity.TabIndex = 3;
            txt_productQuantity.TextChanged += txt_productQuantity_TextChanged;
            // 
            // txt_productName
            // 
            txt_productName.Anchor = AnchorStyles.Left;
            txt_productName.BackColor = Color.FromArgb(239, 248, 230);
            txt_productName.BorderStyle = BorderStyle.None;
            txt_productName.Font = new Font("Segoe UI", 10F);
            txt_productName.ForeColor = Color.Black;
            txt_productName.Location = new Point(173, 17);
            txt_productName.Name = "txt_productName";
            txt_productName.ReadOnly = true;
            txt_productName.Size = new Size(300, 23);
            txt_productName.TabIndex = 2;
            // 
            // lbl_productQuantity
            // 
            lbl_productQuantity.Anchor = AnchorStyles.None;
            lbl_productQuantity.AutoSize = true;
            lbl_productQuantity.Font = new Font("Segoe UI", 10F);
            lbl_productQuantity.Location = new Point(32, 74);
            lbl_productQuantity.Name = "lbl_productQuantity";
            lbl_productQuantity.Size = new Size(126, 23);
            lbl_productQuantity.TabIndex = 1;
            lbl_productQuantity.Text = "Số lượng mua: ";
            // 
            // tableLayoutPanel_price
            // 
            tableLayoutPanel_price.ColumnCount = 2;
            tableLayoutPanel_price.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel_price.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel_price.Controls.Add(txt_priceExchange, 1, 2);
            tableLayoutPanel_price.Controls.Add(txt_priceCustomerPay, 1, 1);
            tableLayoutPanel_price.Controls.Add(lbl_totalPrice, 0, 0);
            tableLayoutPanel_price.Controls.Add(lbl_priceCustomerPay, 0, 1);
            tableLayoutPanel_price.Controls.Add(lbl_priceExchange, 0, 2);
            tableLayoutPanel_price.Controls.Add(txt_totalPrice, 1, 0);
            tableLayoutPanel_price.Location = new Point(560, 3);
            tableLayoutPanel_price.Name = "tableLayoutPanel_price";
            tableLayoutPanel_price.Padding = new Padding(0, 0, 20, 0);
            tableLayoutPanel_price.RowCount = 3;
            tableLayoutPanel_price.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel_price.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel_price.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel_price.Size = new Size(480, 115);
            tableLayoutPanel_price.TabIndex = 1;
            // 
            // txt_priceExchange
            // 
            txt_priceExchange.Anchor = AnchorStyles.Left;
            txt_priceExchange.BackColor = Color.FromArgb(239, 248, 230);
            txt_priceExchange.BorderStyle = BorderStyle.None;
            txt_priceExchange.Location = new Point(187, 85);
            txt_priceExchange.Name = "txt_priceExchange";
            txt_priceExchange.ReadOnly = true;
            txt_priceExchange.Size = new Size(223, 20);
            txt_priceExchange.TabIndex = 6;
            // 
            // txt_priceCustomerPay
            // 
            txt_priceCustomerPay.Anchor = AnchorStyles.Left;
            txt_priceCustomerPay.BackColor = Color.FromArgb(239, 248, 230);
            txt_priceCustomerPay.BorderStyle = BorderStyle.FixedSingle;
            txt_priceCustomerPay.Location = new Point(187, 43);
            txt_priceCustomerPay.Name = "txt_priceCustomerPay";
            txt_priceCustomerPay.Size = new Size(223, 27);
            txt_priceCustomerPay.TabIndex = 7;
            txt_priceCustomerPay.TextChanged += updateExchangePrice;
            // 
            // lbl_totalPrice
            // 
            lbl_totalPrice.Anchor = AnchorStyles.None;
            lbl_totalPrice.AutoSize = true;
            lbl_totalPrice.Font = new Font("Segoe UI", 10F);
            lbl_totalPrice.Location = new Point(48, 7);
            lbl_totalPrice.Name = "lbl_totalPrice";
            lbl_totalPrice.Size = new Size(87, 23);
            lbl_totalPrice.TabIndex = 1;
            lbl_totalPrice.Text = "Tổng tiền:";
            // 
            // lbl_priceCustomerPay
            // 
            lbl_priceCustomerPay.Anchor = AnchorStyles.None;
            lbl_priceCustomerPay.AutoSize = true;
            lbl_priceCustomerPay.Font = new Font("Segoe UI", 10F);
            lbl_priceCustomerPay.Location = new Point(42, 45);
            lbl_priceCustomerPay.Name = "lbl_priceCustomerPay";
            lbl_priceCustomerPay.Size = new Size(99, 23);
            lbl_priceCustomerPay.TabIndex = 2;
            lbl_priceCustomerPay.Text = "Tiền KH trả:";
            // 
            // lbl_priceExchange
            // 
            lbl_priceExchange.Anchor = AnchorStyles.None;
            lbl_priceExchange.AutoSize = true;
            lbl_priceExchange.Font = new Font("Segoe UI", 10F);
            lbl_priceExchange.Location = new Point(51, 84);
            lbl_priceExchange.Name = "lbl_priceExchange";
            lbl_priceExchange.Size = new Size(81, 23);
            lbl_priceExchange.TabIndex = 3;
            lbl_priceExchange.Text = "Tiền thối:";
            // 
            // txt_totalPrice
            // 
            txt_totalPrice.Anchor = AnchorStyles.Left;
            txt_totalPrice.BackColor = Color.FromArgb(239, 248, 230);
            txt_totalPrice.BorderStyle = BorderStyle.None;
            txt_totalPrice.Location = new Point(187, 9);
            txt_totalPrice.Name = "txt_totalPrice";
            txt_totalPrice.ReadOnly = true;
            txt_totalPrice.Size = new Size(223, 20);
            txt_totalPrice.TabIndex = 8;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // ProductSaleGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(bigPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductSaleGUI";
            Size = new Size(1243, 719);
            toolBar.ResumeLayout(false);
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ((ISupportInitialize)btnDelete).EndInit();
            ((ISupportInitialize)filterButton).EndInit();
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            bigPanel.ResumeLayout(false);
            bigPanel.PerformLayout();
            bodyPanel.ResumeLayout(false);
            productListPanel.ResumeLayout(false);
            pSaleProductList.ResumeLayout(false);
            ((ISupportInitialize)dtv).EndInit();
            propertyPanel.ResumeLayout(false);
            tableLayoutPanel_property.ResumeLayout(false);
            tableLayoutPanel_productQuantity.ResumeLayout(false);
            tableLayoutPanel_productQuantity.PerformLayout();
            tableLayoutPanel_price.ResumeLayout(false);
            tableLayoutPanel_price.PerformLayout();
            ((ISupportInitialize)errorProvider1).EndInit();
            ((ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private CustomPanel toolBar;
        private CustomPanel searchPanel;
        private PictureBox btnDelete;
        private TextBox searchBar;
        private PictureBox filterButton;
        private Label btnAddInvoice;
        private Panel titlePanel;
        private Label titleText;
        private Panel bigPanel;
        private TableLayoutPanel bodyPanel;
        private Panel productListPanel;
        private TableLayoutPanel pSaleProductList;
        private DataGridView dtv;
        private Panel propertyPanel;
        private Label lbl_productQuantity;
        private Label lbl_productName;
        private TextBox txt_productQuantity;
        private TextBox txt_productName;
        private ErrorProvider errorProvider1;
        private TableLayoutPanel tableLayoutPanel_property;
        private TableLayoutPanel tableLayoutPanel_price;
        private TableLayoutPanel tableLayoutPanel_productQuantity;
        private Label lbl_totalPrice;
        private Label lbl_priceCustomerPay;
        private Label lbl_priceExchange;
        private TextBox txt_priceExchange;
        private TextBox txt_priceCustomerPay;
        private TextBox txt_totalPrice;
        private ErrorProvider errorProvider2;
    }
}
