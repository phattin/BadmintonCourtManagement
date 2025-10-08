namespace BadmintonCourtManagement.GUI.ComponentsGUI.SupplyAddGUI
{
    partial class SupplyProductInfo
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
            SubBody = new Panel();
            ButtonPanel = new Panel();
            AddButton = new Button();
            InputPanel = new TableLayoutPanel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            ProductTotal = new Label();
            ProductPriceOut = new Label();
            ProductPriceIn = new Label();
            ProductQuantity = new Label();
            QuantityBox = new TextBox();
            InfoPanel = new TableLayoutPanel();
            ProductBrand = new Label();
            ProductType = new Label();
            ProductName = new Label();
            ProductID = new Label();
            TitlePanel.SuspendLayout();
            Body.SuspendLayout();
            SubBody.SuspendLayout();
            ButtonPanel.SuspendLayout();
            InputPanel.SuspendLayout();
            InfoPanel.SuspendLayout();
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
            TitlePanel.TabIndex = 1;
            // 
            // Title
            // 
            Title.Dock = DockStyle.Fill;
            Title.Font = new Font("Roboto", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(0, 0);
            Title.Name = "Title";
            Title.Size = new Size(786, 95);
            Title.TabIndex = 0;
            Title.Text = "Thông tin sản phẩm";
            Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Body
            // 
            Body.BackColor = Color.FromArgb(0, 120, 103);
            Body.Controls.Add(SubBody);
            Body.Dock = DockStyle.Fill;
            Body.Location = new Point(0, 95);
            Body.Margin = new Padding(0);
            Body.Name = "Body";
            Body.Padding = new Padding(20, 40, 20, 40);
            Body.Size = new Size(786, 926);
            Body.TabIndex = 2;
            // 
            // SubBody
            // 
            SubBody.BackColor = Color.FromArgb(200, 250, 214);
            SubBody.Controls.Add(ButtonPanel);
            SubBody.Controls.Add(InputPanel);
            SubBody.Controls.Add(InfoPanel);
            SubBody.Dock = DockStyle.Fill;
            SubBody.Location = new Point(20, 40);
            SubBody.Margin = new Padding(0);
            SubBody.Name = "SubBody";
            SubBody.Padding = new Padding(40);
            SubBody.Size = new Size(746, 846);
            SubBody.TabIndex = 0;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(AddButton);
            ButtonPanel.Dock = DockStyle.Fill;
            ButtonPanel.Location = new Point(40, 692);
            ButtonPanel.Margin = new Padding(0);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Padding = new Padding(240, 20, 240, 20);
            ButtonPanel.Size = new Size(666, 114);
            ButtonPanel.TabIndex = 2;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.Black;
            AddButton.Cursor = Cursors.Hand;
            AddButton.Dock = DockStyle.Fill;
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(240, 20);
            AddButton.Margin = new Padding(0);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(186, 74);
            AddButton.TabIndex = 0;
            AddButton.Text = "+ Thêm";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.MouseEnter += buttonEnter;
            AddButton.MouseLeave += buttonLeave;
            // 
            // InputPanel
            // 
            InputPanel.BackColor = Color.FromArgb(0, 120, 103);
            InputPanel.ColumnCount = 2;
            InputPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.03303F));
            InputPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.9669647F));
            InputPanel.Controls.Add(textBox3, 1, 3);
            InputPanel.Controls.Add(textBox2, 1, 2);
            InputPanel.Controls.Add(textBox1, 1, 1);
            InputPanel.Controls.Add(ProductTotal, 0, 3);
            InputPanel.Controls.Add(ProductPriceOut, 0, 2);
            InputPanel.Controls.Add(ProductPriceIn, 0, 1);
            InputPanel.Controls.Add(ProductQuantity, 0, 0);
            InputPanel.Controls.Add(QuantityBox, 1, 0);
            InputPanel.Dock = DockStyle.Top;
            InputPanel.Location = new Point(40, 341);
            InputPanel.Margin = new Padding(0);
            InputPanel.Name = "InputPanel";
            InputPanel.RowCount = 4;
            InputPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0712242F));
            InputPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25.9259262F));
            InputPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 24.7863255F));
            InputPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 24.2165241F));
            InputPanel.Size = new Size(666, 351);
            InputPanel.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(219, 281);
            textBox3.Margin = new Padding(0, 15, 20, 0);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(427, 48);
            textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(219, 194);
            textBox2.Margin = new Padding(0, 15, 20, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(427, 48);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(219, 103);
            textBox1.Margin = new Padding(0, 15, 20, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(427, 48);
            textBox1.TabIndex = 8;
            // 
            // ProductTotal
            // 
            ProductTotal.Dock = DockStyle.Fill;
            ProductTotal.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductTotal.ForeColor = Color.White;
            ProductTotal.Location = new Point(20, 266);
            ProductTotal.Margin = new Padding(20, 0, 0, 0);
            ProductTotal.Name = "ProductTotal";
            ProductTotal.Size = new Size(199, 85);
            ProductTotal.TabIndex = 6;
            ProductTotal.Text = "Thành tiền:";
            ProductTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductPriceOut
            // 
            ProductPriceOut.Dock = DockStyle.Fill;
            ProductPriceOut.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductPriceOut.ForeColor = Color.White;
            ProductPriceOut.Location = new Point(20, 179);
            ProductPriceOut.Margin = new Padding(20, 0, 0, 0);
            ProductPriceOut.Name = "ProductPriceOut";
            ProductPriceOut.Size = new Size(199, 87);
            ProductPriceOut.TabIndex = 4;
            ProductPriceOut.Text = "Giá bán:";
            ProductPriceOut.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductPriceIn
            // 
            ProductPriceIn.Dock = DockStyle.Fill;
            ProductPriceIn.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductPriceIn.ForeColor = Color.White;
            ProductPriceIn.Location = new Point(20, 88);
            ProductPriceIn.Margin = new Padding(20, 0, 0, 0);
            ProductPriceIn.Name = "ProductPriceIn";
            ProductPriceIn.Size = new Size(199, 91);
            ProductPriceIn.TabIndex = 2;
            ProductPriceIn.Text = "Giá nhập:";
            ProductPriceIn.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductQuantity
            // 
            ProductQuantity.Dock = DockStyle.Fill;
            ProductQuantity.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductQuantity.ForeColor = Color.White;
            ProductQuantity.Location = new Point(20, 0);
            ProductQuantity.Margin = new Padding(20, 0, 0, 0);
            ProductQuantity.Name = "ProductQuantity";
            ProductQuantity.Size = new Size(199, 88);
            ProductQuantity.TabIndex = 0;
            ProductQuantity.Text = "Số lượng:";
            ProductQuantity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // QuantityBox
            // 
            QuantityBox.Dock = DockStyle.Fill;
            QuantityBox.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuantityBox.Location = new Point(219, 15);
            QuantityBox.Margin = new Padding(0, 15, 20, 0);
            QuantityBox.Name = "QuantityBox";
            QuantityBox.Size = new Size(427, 48);
            QuantityBox.TabIndex = 7;
            // 
            // InfoPanel
            // 
            InfoPanel.ColumnCount = 1;
            InfoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            InfoPanel.Controls.Add(ProductBrand, 0, 3);
            InfoPanel.Controls.Add(ProductType, 0, 2);
            InfoPanel.Controls.Add(ProductName, 0, 1);
            InfoPanel.Controls.Add(ProductID, 0, 0);
            InfoPanel.Dock = DockStyle.Top;
            InfoPanel.Location = new Point(40, 40);
            InfoPanel.Margin = new Padding(0);
            InfoPanel.Name = "InfoPanel";
            InfoPanel.Padding = new Padding(0, 0, 0, 20);
            InfoPanel.RowCount = 4;
            InfoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            InfoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            InfoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            InfoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            InfoPanel.Size = new Size(666, 301);
            InfoPanel.TabIndex = 0;
            // 
            // ProductBrand
            // 
            ProductBrand.Dock = DockStyle.Fill;
            ProductBrand.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductBrand.Location = new Point(0, 210);
            ProductBrand.Margin = new Padding(0);
            ProductBrand.Name = "ProductBrand";
            ProductBrand.Size = new Size(666, 71);
            ProductBrand.TabIndex = 3;
            ProductBrand.Text = "Nhãn hàng: Nike";
            ProductBrand.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductType
            // 
            ProductType.Dock = DockStyle.Fill;
            ProductType.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductType.Location = new Point(0, 140);
            ProductType.Margin = new Padding(0);
            ProductType.Name = "ProductType";
            ProductType.Size = new Size(666, 70);
            ProductType.TabIndex = 2;
            ProductType.Text = "Loại sản phẩm: Giày dép";
            ProductType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductName
            // 
            ProductName.Dock = DockStyle.Fill;
            ProductName.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductName.Location = new Point(0, 70);
            ProductName.Margin = new Padding(0);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(666, 70);
            ProductName.TabIndex = 1;
            ProductName.Text = "Tên sản phẩm: Giày thể thao";
            ProductName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductID
            // 
            ProductID.Dock = DockStyle.Fill;
            ProductID.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductID.Location = new Point(0, 0);
            ProductID.Margin = new Padding(0);
            ProductID.Name = "ProductID";
            ProductID.Size = new Size(666, 70);
            ProductID.TabIndex = 0;
            ProductID.Text = "Mã sản phẩm: SP0001";
            ProductID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SupplyProductInfo
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Body);
            Controls.Add(TitlePanel);
            Font = new Font("Roboto Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "SupplyProductInfo";
            Size = new Size(786, 1021);
            TitlePanel.ResumeLayout(false);
            Body.ResumeLayout(false);
            SubBody.ResumeLayout(false);
            ButtonPanel.ResumeLayout(false);
            InputPanel.ResumeLayout(false);
            InputPanel.PerformLayout();
            InfoPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TitlePanel;
        private Label Title;
        private Panel Body;
        private Panel SubBody;
        private TableLayoutPanel InfoPanel;
        private Label ProductID;
        private TableLayoutPanel InputPanel;
        private Label ProductBrand;
        private Label ProductType;
        private Label ProductName;
        private Label ProductTotal;
        private Label ProductPriceOut;
        private Label ProductPriceIn;
        private Label ProductQuantity;
        private TextBox QuantityBox;
        private Panel ButtonPanel;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button AddButton;
    }
}
