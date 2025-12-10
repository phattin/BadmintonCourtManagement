namespace GUI
{
    partial class ProductUpdateGUI
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
            categoryComboBox = new ComboBox();
            brandComboBox = new ComboBox();
            tableLayoutBackground = new TableLayoutPanel();
            title_productUpdate = new Label();
            tableLayout_storeItem = new TableLayoutPanel();
            label2 = new Label();
            lbl_category = new Label();
            lbl_brand = new Label();
            lblProductName = new Label();
            txt_productName = new TextBox();
            saveBtn = new Label();
            resetBtn = new Label();
            lbl_image = new Label();
            chooseImgBtn = new Label();
            label1 = new Label();
            supplierComboBox = new ComboBox();
            lbl_status = new Label();
            statusComboBox = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            tableLayoutBackground.SuspendLayout();
            tableLayout_storeItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(291, 138);
            categoryComboBox.Margin = new Padding(4);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(264, 33);
            categoryComboBox.TabIndex = 13;
            // 
            // brandComboBox
            // 
            brandComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            brandComboBox.FormattingEnabled = true;
            brandComboBox.Location = new Point(291, 71);
            brandComboBox.Margin = new Padding(4);
            brandComboBox.Name = "brandComboBox";
            brandComboBox.Size = new Size(264, 33);
            brandComboBox.TabIndex = 12;
            // 
            // tableLayoutBackground
            // 
            tableLayoutBackground.AutoScroll = true;
            tableLayoutBackground.BackColor = Color.White;
            tableLayoutBackground.ColumnCount = 1;
            tableLayoutBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutBackground.Controls.Add(title_productUpdate, 0, 0);
            tableLayoutBackground.Controls.Add(tableLayout_storeItem, 0, 1);
            tableLayoutBackground.Dock = DockStyle.Fill;
            tableLayoutBackground.ForeColor = Color.Black;
            tableLayoutBackground.Location = new Point(0, 0);
            tableLayoutBackground.Margin = new Padding(4);
            tableLayoutBackground.Name = "tableLayoutBackground";
            tableLayoutBackground.RowCount = 2;
            tableLayoutBackground.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutBackground.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutBackground.Size = new Size(604, 800);
            tableLayoutBackground.TabIndex = 0;
            // 
            // title_productUpdate
            // 
            title_productUpdate.BackColor = Color.White;
            title_productUpdate.Dock = DockStyle.Fill;
            title_productUpdate.FlatStyle = FlatStyle.Flat;
            title_productUpdate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_productUpdate.Location = new Point(4, 0);
            title_productUpdate.Margin = new Padding(4, 0, 4, 0);
            title_productUpdate.Name = "title_productUpdate";
            title_productUpdate.Size = new Size(596, 80);
            title_productUpdate.TabIndex = 0;
            title_productUpdate.Text = "Sửa sản phẩm";
            title_productUpdate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayout_storeItem
            // 
            tableLayout_storeItem.Anchor = AnchorStyles.None;
            tableLayout_storeItem.AutoScroll = true;
            tableLayout_storeItem.ColumnCount = 2;
            tableLayout_storeItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayout_storeItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayout_storeItem.Controls.Add(label2, 0, 3);
            tableLayout_storeItem.Controls.Add(lbl_category, 0, 2);
            tableLayout_storeItem.Controls.Add(lbl_brand, 0, 1);
            tableLayout_storeItem.Controls.Add(lblProductName, 0, 0);
            tableLayout_storeItem.Controls.Add(txt_productName, 1, 0);
            tableLayout_storeItem.Controls.Add(brandComboBox, 1, 1);
            tableLayout_storeItem.Controls.Add(categoryComboBox, 1, 2);
            tableLayout_storeItem.Controls.Add(saveBtn, 0, 7);
            tableLayout_storeItem.Controls.Add(resetBtn, 1, 7);
            tableLayout_storeItem.Controls.Add(lbl_image, 1, 6);
            tableLayout_storeItem.Controls.Add(chooseImgBtn, 1, 5);
            tableLayout_storeItem.Controls.Add(label1, 0, 5);
            tableLayout_storeItem.Controls.Add(supplierComboBox, 1, 3);
            tableLayout_storeItem.Controls.Add(lbl_status, 0, 4);
            tableLayout_storeItem.Controls.Add(statusComboBox, 1, 4);
            tableLayout_storeItem.ForeColor = Color.Black;
            tableLayout_storeItem.Location = new Point(15, 148);
            tableLayout_storeItem.Margin = new Padding(4, 0, 4, 0);
            tableLayout_storeItem.Name = "tableLayout_storeItem";
            tableLayout_storeItem.RowCount = 8;
            tableLayout_storeItem.RowStyles.Add(new RowStyle(SizeType.Percent, 11.504425F));
            tableLayout_storeItem.RowStyles.Add(new RowStyle(SizeType.Percent, 11.504425F));
            tableLayout_storeItem.RowStyles.Add(new RowStyle(SizeType.Percent, 11.504425F));
            tableLayout_storeItem.RowStyles.Add(new RowStyle(SizeType.Percent, 11.504425F));
            tableLayout_storeItem.RowStyles.Add(new RowStyle(SizeType.Percent, 11.504425F));
            tableLayout_storeItem.RowStyles.Add(new RowStyle(SizeType.Percent, 17.6991158F));
            tableLayout_storeItem.RowStyles.Add(new RowStyle(SizeType.Percent, 8.849558F));
            tableLayout_storeItem.RowStyles.Add(new RowStyle(SizeType.Percent, 15.929204F));
            tableLayout_storeItem.Size = new Size(574, 583);
            tableLayout_storeItem.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 201);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(279, 38);
            label2.TabIndex = 15;
            label2.Text = "Nhà cung cấp:";
            // 
            // lbl_category
            // 
            lbl_category.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_category.AutoSize = true;
            lbl_category.FlatStyle = FlatStyle.Flat;
            lbl_category.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_category.Location = new Point(4, 134);
            lbl_category.Margin = new Padding(4, 0, 4, 0);
            lbl_category.Name = "lbl_category";
            lbl_category.Size = new Size(279, 38);
            lbl_category.TabIndex = 8;
            lbl_category.Text = "Thể loại: ";
            // 
            // lbl_brand
            // 
            lbl_brand.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_brand.AutoSize = true;
            lbl_brand.FlatStyle = FlatStyle.Flat;
            lbl_brand.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_brand.Location = new Point(4, 67);
            lbl_brand.Margin = new Padding(4, 0, 4, 0);
            lbl_brand.Name = "lbl_brand";
            lbl_brand.Padding = new Padding(0, 0, 0, 12);
            lbl_brand.Size = new Size(279, 50);
            lbl_brand.TabIndex = 9;
            lbl_brand.Text = "Thương hiệu: ";
            // 
            // lblProductName
            // 
            lblProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.White;
            lblProductName.Font = new Font("Segoe UI", 13.8F);
            lblProductName.Location = new Point(4, 0);
            lblProductName.Margin = new Padding(4, 0, 4, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Padding = new Padding(0, 0, 0, 12);
            lblProductName.Size = new Size(279, 50);
            lblProductName.TabIndex = 10;
            lblProductName.Text = "Tên sản phẩm:";
            // 
            // txt_productName
            // 
            txt_productName.BackColor = Color.White;
            txt_productName.BorderStyle = BorderStyle.FixedSingle;
            txt_productName.Location = new Point(291, 4);
            txt_productName.Margin = new Padding(4);
            txt_productName.Name = "txt_productName";
            txt_productName.Size = new Size(264, 31);
            txt_productName.TabIndex = 1;
            // 
            // saveBtn
            // 
            saveBtn.Anchor = AnchorStyles.None;
            saveBtn.AutoSize = true;
            saveBtn.BackColor = Color.FromArgb(64, 64, 64);
            saveBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(95, 509);
            saveBtn.Margin = new Padding(4, 0, 4, 0);
            saveBtn.Name = "saveBtn";
            saveBtn.Padding = new Padding(25, 12, 25, 12);
            saveBtn.Size = new Size(97, 54);
            saveBtn.TabIndex = 5;
            saveBtn.Text = "Lưu";
            saveBtn.TextAlign = ContentAlignment.MiddleCenter;
            saveBtn.Click += saveBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Anchor = AnchorStyles.None;
            resetBtn.AutoSize = true;
            resetBtn.BackColor = Color.FromArgb(64, 64, 64);
            resetBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetBtn.ForeColor = Color.White;
            resetBtn.Location = new Point(374, 509);
            resetBtn.Margin = new Padding(4, 0, 4, 0);
            resetBtn.Name = "resetBtn";
            resetBtn.Padding = new Padding(25, 12, 25, 12);
            resetBtn.Size = new Size(113, 54);
            resetBtn.TabIndex = 6;
            resetBtn.Text = "Reset";
            resetBtn.TextAlign = ContentAlignment.MiddleCenter;
            resetBtn.Click += resetBtn_Click;
            // 
            // lbl_image
            // 
            lbl_image.Anchor = AnchorStyles.Top;
            lbl_image.FlatStyle = FlatStyle.Flat;
            lbl_image.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_image.Location = new Point(314, 438);
            lbl_image.Margin = new Padding(0, 0, 0, 12);
            lbl_image.Name = "lbl_image";
            lbl_image.Size = new Size(232, 28);
            lbl_image.TabIndex = 7;
            // 
            // chooseImgBtn
            // 
            chooseImgBtn.Anchor = AnchorStyles.Top;
            chooseImgBtn.AutoSize = true;
            chooseImgBtn.BackColor = Color.FromArgb(64, 64, 64);
            chooseImgBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chooseImgBtn.ForeColor = Color.White;
            chooseImgBtn.Location = new Point(354, 335);
            chooseImgBtn.Margin = new Padding(4, 0, 4, 0);
            chooseImgBtn.Name = "chooseImgBtn";
            chooseImgBtn.Padding = new Padding(25, 12, 25, 12);
            chooseImgBtn.Size = new Size(153, 54);
            chooseImgBtn.TabIndex = 4;
            chooseImgBtn.Text = "Chọn ảnh";
            chooseImgBtn.TextAlign = ContentAlignment.MiddleCenter;
            chooseImgBtn.Click += chooseImgBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 335);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 12);
            label1.Size = new Size(279, 50);
            label1.TabIndex = 11;
            label1.Text = "Chọn ảnh: ";
            // 
            // supplierComboBox
            // 
            supplierComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            supplierComboBox.FormattingEnabled = true;
            supplierComboBox.Location = new Point(291, 205);
            supplierComboBox.Margin = new Padding(4);
            supplierComboBox.Name = "supplierComboBox";
            supplierComboBox.Size = new Size(264, 33);
            supplierComboBox.TabIndex = 14;
            // 
            // lbl_status
            // 
            lbl_status.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_status.AutoSize = true;
            lbl_status.FlatStyle = FlatStyle.Flat;
            lbl_status.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_status.Location = new Point(4, 268);
            lbl_status.Margin = new Padding(4, 0, 4, 0);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(279, 38);
            lbl_status.TabIndex = 16;
            lbl_status.Text = "Trạng thái:";
            // 
            // statusComboBox
            // 
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(291, 272);
            statusComboBox.Margin = new Padding(4);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(264, 33);
            statusComboBox.TabIndex = 17;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ProductUpdateGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutBackground);
            Margin = new Padding(4);
            Name = "ProductUpdateGUI";
            Size = new Size(604, 800);
            tableLayoutBackground.ResumeLayout(false);
            tableLayout_storeItem.ResumeLayout(false);
            tableLayout_storeItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutBackground;
        private TableLayoutPanel tableLayout_storeItem;
        private Label title_productUpdate;
        private Label lblProductName;
        private TextBox txt_productName;
        private Label lbl_brand;
        private Label lbl_image;
        private Label lbl_category;
        private ComboBox brandComboBox;
        private ComboBox categoryComboBox;
        private Label label1;
        private Label chooseImgBtn;
        private Label saveBtn;
        private Label resetBtn;
        private ErrorProvider errorProvider1;
        private Label label2;
        private ComboBox supplierComboBox;
        private Label lbl_status;
        private ComboBox statusComboBox;
    }
}