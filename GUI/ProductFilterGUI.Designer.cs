/*
using System.Drawing;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    partial class ProductFilterGUI
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel tableLayout;
        private Label lblBrands;
        private CheckedListBox clbBrands;
        private Label lblTypes;
        private CheckedListBox clbTypes;
        private CheckBox chkInStock;
        private FlowLayoutPanel actionsPanel;
        private Button btnApply;
        private Button btnClear;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            tableLayout = new TableLayoutPanel();
            lblBrands = new Label();
            clbBrands = new CheckedListBox();
            lblTypes = new Label();
            clbTypes = new CheckedListBox();
            chkInStock = new CheckBox();
            actionsPanel = new FlowLayoutPanel();
            btnApply = new Button();
            btnClear = new Button();

            SuspendLayout();

            // tableLayout
            tableLayout.ColumnCount = 2;
            tableLayout.RowCount = 4;
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.Padding = new Padding(8);
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50)); // Brands
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50)); // Types
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));   // In stock
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));   // Actions

            // lblBrands
            lblBrands.Text = "Brand:";
            lblBrands.AutoSize = true;
            lblBrands.Dock = DockStyle.Fill;

            // clbBrands
            clbBrands.CheckOnClick = true;
            clbBrands.IntegralHeight = false;
            clbBrands.Dock = DockStyle.Fill;

            // lblTypes
            lblTypes.Text = "Type:";
            lblTypes.AutoSize = true;
            lblTypes.Dock = DockStyle.Fill;

            // clbTypes
            clbTypes.CheckOnClick = true;
            clbTypes.IntegralHeight = false;
            clbTypes.Dock = DockStyle.Fill;

            // chkInStock
            chkInStock.Text = "In stock only";
            chkInStock.AutoSize = true;
            chkInStock.Dock = DockStyle.Left;

            // actionsPanel
            actionsPanel.FlowDirection = FlowDirection.LeftToRight;
            actionsPanel.Dock = DockStyle.Fill;

            // btnApply
            btnApply.Text = "Apply";
            btnApply.AutoSize = true;
            btnApply.Click += (s, e) => RaiseApply();

            // btnClear
            btnClear.Text = "Clear";
            btnClear.AutoSize = true;
            btnClear.Click += (s, e) => ClearAndApply();

            actionsPanel.Controls.Add(btnApply);
            actionsPanel.Controls.Add(btnClear);

            // add to table
            tableLayout.Controls.Add(lblBrands, 0, 0);
            tableLayout.Controls.Add(clbBrands, 1, 0);
            tableLayout.Controls.Add(lblTypes, 0, 1);
            tableLayout.Controls.Add(clbTypes, 1, 1);
            tableLayout.Controls.Add(chkInStock, 1, 2);
            tableLayout.Controls.Add(actionsPanel, 1, 3);

            // ProductFilterGUI
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayout);
            Name = "ProductFilterGUI";
            Size = new Size(280, 400);

            ResumeLayout(false);
        }
    }
}
*/

namespace BadmintonCourtManagement.GUI
{
    partial class ProductFilterGUI
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
            tableLayoutBackground = new TableLayoutPanel();
            title_productFilter = new Label();
            tableLayout_storeItem = new TableLayoutPanel();
            brand_listBox = new CheckedListBox();
            lbl_brand = new Label();
            lbl_category = new Label();
            lbl_onlyStock = new Label();
            category_listBox = new CheckedListBox();
            saveBtn = new Label();
            resetBtn = new Label();
            checkBox_onlyStock = new CheckBox();
            tableLayoutBackground.SuspendLayout();
            tableLayout_storeItem.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutBackground
            // 
            tableLayoutBackground.AutoSize = true;
            tableLayoutBackground.BackColor = Color.White;
            tableLayoutBackground.ColumnCount = 1;
            tableLayoutBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutBackground.Controls.Add(title_productFilter, 0, 0);
            tableLayoutBackground.Controls.Add(tableLayout_storeItem, 0, 1);
            tableLayoutBackground.Dock = DockStyle.Fill;
            tableLayoutBackground.Location = new Point(0, 0);
            tableLayoutBackground.Name = "tableLayoutBackground";
            tableLayoutBackground.Padding = new Padding(30, 10, 30, 10);
            tableLayoutBackground.RowCount = 2;
            tableLayoutBackground.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutBackground.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutBackground.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutBackground.Size = new Size(493, 521);
            tableLayoutBackground.TabIndex = 0;
            // 
            // title_productFilter
            // 
            title_productFilter.BackColor = Color.White;
            title_productFilter.Dock = DockStyle.Fill;
            title_productFilter.FlatStyle = FlatStyle.Flat;
            title_productFilter.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_productFilter.Location = new Point(33, 10);
            title_productFilter.Name = "title_productFilter";
            title_productFilter.Size = new Size(427, 75);
            title_productFilter.TabIndex = 1;
            title_productFilter.Text = "Lọc sản phẩm";
            title_productFilter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayout_storeItem
            // 
            tableLayout_storeItem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayout_storeItem.AutoScroll = true;
            tableLayout_storeItem.ColumnCount = 2;
            tableLayout_storeItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayout_storeItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayout_storeItem.Controls.Add(brand_listBox, 1, 0);
            tableLayout_storeItem.Controls.Add(lbl_brand, 0, 0);
            tableLayout_storeItem.Controls.Add(lbl_category, 0, 1);
            tableLayout_storeItem.Controls.Add(lbl_onlyStock, 0, 2);
            tableLayout_storeItem.Controls.Add(category_listBox, 1, 1);
            tableLayout_storeItem.Controls.Add(saveBtn, 0, 3);
            tableLayout_storeItem.Controls.Add(resetBtn, 1, 3);
            tableLayout_storeItem.Controls.Add(checkBox_onlyStock, 1, 2);
            tableLayout_storeItem.ForeColor = Color.Black;
            tableLayout_storeItem.Location = new Point(33, 135);
            tableLayout_storeItem.Margin = new Padding(3, 50, 3, 70);
            tableLayout_storeItem.Name = "tableLayout_storeItem";
            tableLayout_storeItem.RowCount = 4;
            tableLayout_storeItem.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayout_storeItem.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayout_storeItem.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayout_storeItem.RowStyles.Add(new RowStyle());
            tableLayout_storeItem.Size = new Size(427, 306);
            tableLayout_storeItem.TabIndex = 2;
            // 
            // brand_listBox
            // 
            brand_listBox.BackColor = Color.White;
            brand_listBox.BorderStyle = BorderStyle.None;
            brand_listBox.Dock = DockStyle.Fill;
            brand_listBox.FormattingEnabled = true;
            brand_listBox.IntegralHeight = false;
            brand_listBox.Location = new Point(216, 3);
            brand_listBox.Name = "brand_listBox";
            brand_listBox.Size = new Size(208, 81);
            brand_listBox.TabIndex = 1;
            // 
            // lbl_brand
            // 
            lbl_brand.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_brand.AutoSize = true;
            lbl_brand.FlatStyle = FlatStyle.Flat;
            lbl_brand.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_brand.Location = new Point(3, 0);
            lbl_brand.Name = "lbl_brand";
            lbl_brand.Size = new Size(207, 31);
            lbl_brand.TabIndex = 0;
            lbl_brand.Text = "Thương hiệu: ";
            // 
            // lbl_category
            // 
            lbl_category.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_category.AutoSize = true;
            lbl_category.FlatStyle = FlatStyle.Flat;
            lbl_category.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_category.Location = new Point(3, 87);
            lbl_category.Name = "lbl_category";
            lbl_category.Size = new Size(207, 31);
            lbl_category.TabIndex = 0;
            lbl_category.Text = "Thể loại: ";
            // 
            // lbl_onlyStock
            // 
            lbl_onlyStock.AutoSize = true;
            lbl_onlyStock.FlatStyle = FlatStyle.Flat;
            lbl_onlyStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_onlyStock.Location = new Point(3, 174);
            lbl_onlyStock.Name = "lbl_onlyStock";
            lbl_onlyStock.Size = new Size(207, 28);
            lbl_onlyStock.TabIndex = 0;
            lbl_onlyStock.Text = "Chỉ xem hàng tồn kho: ";
            // 
            // category_listBox
            // 
            category_listBox.BackColor = Color.White;
            category_listBox.BorderStyle = BorderStyle.None;
            category_listBox.Dock = DockStyle.Fill;
            category_listBox.FormattingEnabled = true;
            category_listBox.IntegralHeight = false;
            category_listBox.Location = new Point(216, 90);
            category_listBox.Name = "category_listBox";
            category_listBox.Size = new Size(208, 81);
            category_listBox.TabIndex = 2;
            // 
            // saveBtn
            // 
            saveBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            saveBtn.AutoSize = true;
            saveBtn.BackColor = Color.FromArgb(64, 64, 64);
            saveBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(67, 261);
            saveBtn.Name = "saveBtn";
            saveBtn.Padding = new Padding(20, 10, 20, 10);
            saveBtn.Size = new Size(78, 45);
            saveBtn.TabIndex = 3;
            saveBtn.Text = "Lưu";
            saveBtn.TextAlign = ContentAlignment.MiddleCenter;
            saveBtn.MouseEnter += buttonEnter;
            saveBtn.MouseLeave += buttonLeave;
            // 
            // resetBtn
            // 
            resetBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            resetBtn.AutoSize = true;
            resetBtn.BackColor = Color.FromArgb(64, 64, 64);
            resetBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetBtn.ForeColor = Color.White;
            resetBtn.Location = new Point(274, 261);
            resetBtn.Name = "resetBtn";
            resetBtn.Padding = new Padding(20, 10, 20, 10);
            resetBtn.Size = new Size(91, 45);
            resetBtn.TabIndex = 4;
            resetBtn.Text = "Reset";
            resetBtn.TextAlign = ContentAlignment.MiddleCenter;
            resetBtn.Click += resetBtn_Click;
            resetBtn.MouseEnter += buttonEnter;
            resetBtn.MouseLeave += buttonLeave;
            // 
            // checkBox_onlyStock
            // 
            checkBox_onlyStock.AutoSize = true;
            checkBox_onlyStock.ImageAlign = ContentAlignment.MiddleRight;
            checkBox_onlyStock.Location = new Point(216, 182);
            checkBox_onlyStock.Margin = new Padding(3, 8, 3, 3);
            checkBox_onlyStock.Name = "checkBox_onlyStock";
            checkBox_onlyStock.Size = new Size(18, 17);
            checkBox_onlyStock.TabIndex = 5;
            checkBox_onlyStock.UseVisualStyleBackColor = true;
            // 
            // ProductFilterGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutBackground);
            Name = "ProductFilterGUI";
            Size = new Size(493, 521);
            tableLayoutBackground.ResumeLayout(false);
            tableLayout_storeItem.ResumeLayout(false);
            tableLayout_storeItem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutBackground;
        private Label title_productFilter;
        private TableLayoutPanel tableLayout_storeItem;
        private Label lbl_brand;
        private Label lbl_category;
        private Label lbl_onlyStock;
        private CheckedListBox brand_listBox;
        private CheckedListBox category_listBox;
        private Label saveBtn;
        private Label resetBtn;
        private CheckBox checkBox_onlyStock;
    }
}