namespace GUI
{
    partial class ProductInsertGUI
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
            components = new System.ComponentModel.Container();
            tableLayoutBackground = new TableLayoutPanel();
            title_productInsert = new Label();
            tableLayout_storeItem = new TableLayoutPanel();
            saveBtn = new Label();
            resetBtn = new Label();
            lbl_image = new Label();
            category_listBox = new CheckedListBox();
            lbl_category = new Label();
            brand_listBox = new CheckedListBox();
            lbl_brand = new Label();
            lblProductName = new Label();
            txt_productName = new TextBox();
            label1 = new Label();
            chooseImgBtn = new Label();
            errorProvider1 = new ErrorProvider(components);
            tableLayoutBackground.SuspendLayout();
            tableLayout_storeItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutBackground
            // 
            tableLayoutBackground.AutoScroll = true;
            tableLayoutBackground.BackColor = Color.White;
            tableLayoutBackground.ColumnCount = 1;
            tableLayoutBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutBackground.Controls.Add(title_productInsert, 0, 0);
            tableLayoutBackground.Controls.Add(tableLayout_storeItem, 0, 1);
            tableLayoutBackground.Dock = DockStyle.Fill;
            tableLayoutBackground.ForeColor = Color.Black;
            tableLayoutBackground.Location = new Point(0, 0);
            tableLayoutBackground.Name = "tableLayoutBackground";
            tableLayoutBackground.RowCount = 2;
            tableLayoutBackground.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutBackground.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutBackground.Size = new Size(483, 640);
            // 
            // title_productInsert
            // 
            title_productInsert.BackColor = Color.White;
            title_productInsert.Dock = DockStyle.Fill;
            title_productInsert.FlatStyle = FlatStyle.Flat;
            title_productInsert.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_productInsert.Location = new Point(3, 0);
            title_productInsert.Name = "title_productInsert";
            title_productInsert.Size = new Size(477, 64);
            title_productInsert.Text = "Thêm sản phẩm";
            title_productInsert.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayout_storeItem
            // 
            tableLayout_storeItem.Anchor = AnchorStyles.None;
            tableLayout_storeItem.AutoScroll = true;
            tableLayout_storeItem.ColumnCount = 2;
            tableLayout_storeItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayout_storeItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayout_storeItem.Controls.Add(saveBtn, 0, 5);
            tableLayout_storeItem.Controls.Add(resetBtn, 1, 5);
            tableLayout_storeItem.Controls.Add(lbl_image, 1, 4);
            tableLayout_storeItem.Controls.Add(category_listBox, 1, 2);
            tableLayout_storeItem.Controls.Add(lbl_category, 0, 2);
            tableLayout_storeItem.Controls.Add(brand_listBox, 1, 1);
            tableLayout_storeItem.Controls.Add(lbl_brand, 0, 1);
            tableLayout_storeItem.Controls.Add(lblProductName, 0, 0);
            tableLayout_storeItem.Controls.Add(txt_productName, 1, 0);
            tableLayout_storeItem.Controls.Add(label1, 0, 3);
            tableLayout_storeItem.Controls.Add(chooseImgBtn, 1, 3);
            tableLayout_storeItem.ForeColor = Color.Black;
            tableLayout_storeItem.Location = new Point(28, 114);
            tableLayout_storeItem.Margin = new Padding(3, 50, 3, 70);
            tableLayout_storeItem.Name = "tableLayout_storeItem";
            tableLayout_storeItem.RowCount = 6;
            tableLayout_storeItem.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayout_storeItem.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            tableLayout_storeItem.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayout_storeItem.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableLayout_storeItem.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayout_storeItem.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableLayout_storeItem.Size = new Size(427, 456);
            tableLayout_storeItem.Paint += tableLayout_storeItem_Paint;
            // 
            // saveBtn
            // 
            saveBtn.Anchor = AnchorStyles.None;
            saveBtn.AutoSize = true;
            saveBtn.BackColor = Color.FromArgb(64, 64, 64);
            saveBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(57, 403);
            saveBtn.Name = "saveBtn";
            saveBtn.Padding = new Padding(20, 10, 20, 10);
            saveBtn.Size = new Size(78, 43);
            saveBtn.TabIndex = 5;
            saveBtn.Text = "Lưu";
            saveBtn.TextAlign = ContentAlignment.MiddleCenter;
            saveBtn.Click += saveBtn_Click;
            saveBtn.MouseEnter += buttonEnter;
            saveBtn.MouseLeave += buttonLeave;
            // 
            // resetBtn
            // 
            resetBtn.Anchor = AnchorStyles.None;
            resetBtn.AutoSize = true;
            resetBtn.BackColor = Color.FromArgb(64, 64, 64);
            resetBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetBtn.ForeColor = Color.White;
            resetBtn.Location = new Point(264, 403);
            resetBtn.Name = "resetBtn";
            resetBtn.Padding = new Padding(20, 10, 20, 10);
            resetBtn.Size = new Size(91, 43);
            resetBtn.TabIndex = 6;
            resetBtn.Text = "Reset";
            resetBtn.TextAlign = ContentAlignment.MiddleCenter;
            resetBtn.MouseEnter += buttonEnter;
            resetBtn.MouseLeave += buttonLeave;
            // 
            // lbl_image
            // 
            lbl_image.Anchor = AnchorStyles.Top;
            lbl_image.FlatStyle = FlatStyle.Flat;
            lbl_image.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_image.Location = new Point(216, 340);
            lbl_image.Margin = new Padding(0, 0, 0, 10);
            lbl_image.Name = "lbl_image";
            lbl_image.Size = new Size(186, 41);
            // 
            // category_listBox
            // 
            category_listBox.BackColor = Color.White;
            category_listBox.BorderStyle = BorderStyle.None;
            category_listBox.Dock = DockStyle.Fill;
            category_listBox.FormattingEnabled = true;
            category_listBox.IntegralHeight = false;
            category_listBox.Location = new Point(195, 193);
            category_listBox.Name = "category_listBox";
            category_listBox.Size = new Size(229, 85);
            category_listBox.TabIndex = 3;
            // 
            // lbl_category
            // 
            lbl_category.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_category.AutoSize = true;
            lbl_category.FlatStyle = FlatStyle.Flat;
            lbl_category.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_category.Location = new Point(3, 190);
            lbl_category.Name = "lbl_category";
            lbl_category.Size = new Size(186, 31);
            lbl_category.Text = "Thể loại: ";
            // 
            // brand_listBox
            // 
            brand_listBox.BackColor = Color.White;
            brand_listBox.BorderStyle = BorderStyle.None;
            brand_listBox.Dock = DockStyle.Fill;
            brand_listBox.FormattingEnabled = true;
            brand_listBox.IntegralHeight = false;
            brand_listBox.Location = new Point(195, 48);
            brand_listBox.Name = "brand_listBox";
            brand_listBox.Size = new Size(229, 139);
            brand_listBox.TabIndex = 2;
            brand_listBox.SelectedIndexChanged += brand_listBox_SelectedIndexChanged;
            // 
            // lbl_brand
            // 
            lbl_brand.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_brand.AutoSize = true;
            lbl_brand.FlatStyle = FlatStyle.Flat;
            lbl_brand.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_brand.Location = new Point(3, 45);
            lbl_brand.Name = "lbl_brand";
            lbl_brand.Padding = new Padding(0, 0, 0, 10);
            lbl_brand.Size = new Size(186, 41);
            lbl_brand.Text = "Thương hiệu: ";
            // 
            // lblProductName
            // 
            lblProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.White;
            lblProductName.Font = new Font("Segoe UI", 13.8F);
            lblProductName.Location = new Point(3, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Padding = new Padding(0, 0, 0, 10);
            lblProductName.Size = new Size(186, 41);
            lblProductName.Text = "Tên sản phẩm:";
            lblProductName.Click += label1_Click;
            // 
            // txt_productName
            // 
            txt_productName.BackColor = Color.White;
            txt_productName.BorderStyle = BorderStyle.FixedSingle;
            txt_productName.Location = new Point(195, 3);
            txt_productName.Name = "txt_productName";
            txt_productName.Size = new Size(212, 27);
            txt_productName.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 281);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 10);
            label1.Size = new Size(186, 41);
            label1.Text = "Chọn ảnh: ";
            label1.Click += label1_Click_1;
            // 
            // chooseImgBtn
            // 
            chooseImgBtn.Anchor = AnchorStyles.Top;
            chooseImgBtn.AutoSize = true;
            chooseImgBtn.BackColor = Color.FromArgb(64, 64, 64);
            chooseImgBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chooseImgBtn.ForeColor = Color.White;
            chooseImgBtn.Location = new Point(247, 281);
            chooseImgBtn.Name = "chooseImgBtn";
            chooseImgBtn.Padding = new Padding(20, 10, 20, 10);
            chooseImgBtn.Size = new Size(125, 43);
            chooseImgBtn.TabIndex = 4;
            chooseImgBtn.Text = "Chọn ảnh";
            chooseImgBtn.TextAlign = ContentAlignment.MiddleCenter;
            chooseImgBtn.Click += chooseImgBtn_Click;
            chooseImgBtn.MouseEnter += buttonEnter;
            chooseImgBtn.MouseLeave += buttonLeave;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ProductInsertGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutBackground);
            Name = "ProductInsertGUI";
            Size = new Size(483, 640);
            tableLayoutBackground.ResumeLayout(false);
            tableLayout_storeItem.ResumeLayout(false);
            tableLayout_storeItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutBackground;
        private TableLayoutPanel tableLayout_storeItem;
        private Label title_productInsert;
        private Label lblProductName;
        private TextBox txt_productName;
        private Label lbl_brand;
        private Label lbl_image;
        private CheckedListBox brand_listBox;
        private Label lbl_category;
        private CheckedListBox category_listBox;
        private Label label1;
        private Label chooseImgBtn;
        private Label saveBtn;
        private Label resetBtn;
        private ErrorProvider errorProvider1;
    }
}
