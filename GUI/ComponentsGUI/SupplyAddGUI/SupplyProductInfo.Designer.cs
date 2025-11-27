using GUI.ComponentsGUI;

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
            components = new System.ComponentModel.Container();
            TitlePanel = new Panel();
            Title = new Label();
            Body = new CustomPanel();
            SubBody = new CustomPanel();
            ButtonPanel = new Panel();
            AddButton = new RoundedButton();
            InputPanel = new RoundedTableLayoutPanel();
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
            errorProvider1 = new ErrorProvider(components);
            TitlePanel.SuspendLayout();
            Body.SuspendLayout();
            SubBody.SuspendLayout();
            ButtonPanel.SuspendLayout();
            InputPanel.SuspendLayout();
            InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // TitlePanel
            // 
            TitlePanel.Controls.Add(Title);
            TitlePanel.Dock = DockStyle.Top;
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Margin = new Padding(0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(806, 76);
            TitlePanel.TabIndex = 1;
            // 
            // Title
            // 
            Title.Dock = DockStyle.Fill;
            Title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Title.Location = new Point(0, 0);
            Title.Margin = new Padding(4, 0, 4, 0);
            Title.Name = "Title";
            Title.Size = new Size(806, 76);
            Title.TabIndex = 0;
            Title.Text = "Thông tin sản phẩm";
            Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Body
            // 
            Body.BackColor = Color.FromArgb(0, 120, 103);
            Body.BorderRadius = 20;
            Body.Controls.Add(SubBody);
            Body.Dock = DockStyle.Top;
            Body.Location = new Point(0, 76);
            Body.Margin = new Padding(0);
            Body.Name = "Body";
            Body.Padding = new Padding(20);
            Body.Size = new Size(806, 631);
            Body.TabIndex = 2;
            // 
            // SubBody
            // 
            SubBody.BackColor = Color.FromArgb(200, 250, 214);
            SubBody.BorderRadius = 20;
            SubBody.Controls.Add(ButtonPanel);
            SubBody.Controls.Add(InputPanel);
            SubBody.Controls.Add(InfoPanel);
            SubBody.Dock = DockStyle.Fill;
            SubBody.Location = new Point(20, 20);
            SubBody.Margin = new Padding(0);
            SubBody.Name = "SubBody";
            SubBody.Padding = new Padding(20);
            SubBody.Size = new Size(766, 591);
            SubBody.TabIndex = 0;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(AddButton);
            ButtonPanel.Dock = DockStyle.Fill;
            ButtonPanel.Location = new Point(20, 481);
            ButtonPanel.Margin = new Padding(0);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Padding = new Padding(180, 4, 180, 4);
            ButtonPanel.Size = new Size(726, 90);
            ButtonPanel.TabIndex = 2;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.Black;
            AddButton.BackgroundColor = Color.Black;
            AddButton.BorderColor = Color.PaleVioletRed;
            AddButton.BorderRadius = 20;
            AddButton.BorderSize = 0;
            AddButton.Cursor = Cursors.Hand;
            AddButton.Dock = DockStyle.Fill;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(180, 4);
            AddButton.Margin = new Padding(0);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(366, 82);
            AddButton.TabIndex = 0;
            AddButton.Text = "+ Thêm";
            AddButton.TextColor = Color.White;
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            AddButton.MouseEnter += buttonEnter;
            AddButton.MouseLeave += buttonLeave;
            // 
            // InputPanel
            // 
            InputPanel.BackColor = Color.FromArgb(0, 120, 103);
            InputPanel.BorderRadius = 20;
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
            InputPanel.Location = new Point(20, 241);
            InputPanel.Margin = new Padding(0);
            InputPanel.Name = "InputPanel";
            InputPanel.RowCount = 4;
            InputPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0712242F));
            InputPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25.9259262F));
            InputPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 24.7863255F));
            InputPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 24.2165241F));
            InputPanel.Size = new Size(726, 240);
            InputPanel.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox3.Location = new Point(239, 201);
            textBox3.Margin = new Padding(0, 20, 25, 0);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(462, 34);
            textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox2.Location = new Point(239, 142);
            textBox2.Margin = new Padding(0, 20, 25, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(462, 34);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += price_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox1.Location = new Point(239, 80);
            textBox1.Margin = new Padding(0, 20, 25, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(462, 34);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += price_TextChanged;
            // 
            // ProductTotal
            // 
            ProductTotal.Dock = DockStyle.Fill;
            ProductTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ProductTotal.ForeColor = Color.White;
            ProductTotal.Location = new Point(25, 181);
            ProductTotal.Margin = new Padding(25, 0, 0, 0);
            ProductTotal.Name = "ProductTotal";
            ProductTotal.Size = new Size(214, 59);
            ProductTotal.TabIndex = 6;
            ProductTotal.Text = "Thành tiền:";
            ProductTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductPriceOut
            // 
            ProductPriceOut.Dock = DockStyle.Fill;
            ProductPriceOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ProductPriceOut.ForeColor = Color.White;
            ProductPriceOut.Location = new Point(25, 122);
            ProductPriceOut.Margin = new Padding(25, 0, 0, 0);
            ProductPriceOut.Name = "ProductPriceOut";
            ProductPriceOut.Size = new Size(214, 59);
            ProductPriceOut.TabIndex = 4;
            ProductPriceOut.Text = "Giá bán:";
            ProductPriceOut.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductPriceIn
            // 
            ProductPriceIn.Dock = DockStyle.Fill;
            ProductPriceIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ProductPriceIn.ForeColor = Color.White;
            ProductPriceIn.Location = new Point(25, 60);
            ProductPriceIn.Margin = new Padding(25, 0, 0, 0);
            ProductPriceIn.Name = "ProductPriceIn";
            ProductPriceIn.Size = new Size(214, 62);
            ProductPriceIn.TabIndex = 2;
            ProductPriceIn.Text = "Giá nhập:";
            ProductPriceIn.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductQuantity
            // 
            ProductQuantity.Dock = DockStyle.Fill;
            ProductQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ProductQuantity.ForeColor = Color.White;
            ProductQuantity.Location = new Point(25, 0);
            ProductQuantity.Margin = new Padding(25, 0, 0, 0);
            ProductQuantity.Name = "ProductQuantity";
            ProductQuantity.Size = new Size(214, 60);
            ProductQuantity.TabIndex = 0;
            ProductQuantity.Text = "Số lượng:";
            ProductQuantity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // QuantityBox
            // 
            QuantityBox.Dock = DockStyle.Fill;
            QuantityBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            QuantityBox.Location = new Point(239, 20);
            QuantityBox.Margin = new Padding(0, 20, 25, 0);
            QuantityBox.Name = "QuantityBox";
            QuantityBox.Size = new Size(462, 34);
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
            InfoPanel.Location = new Point(20, 20);
            InfoPanel.Margin = new Padding(0);
            InfoPanel.Name = "InfoPanel";
            InfoPanel.RowCount = 4;
            InfoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            InfoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            InfoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            InfoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            InfoPanel.Size = new Size(726, 221);
            InfoPanel.TabIndex = 0;
            // 
            // ProductBrand
            // 
            ProductBrand.Dock = DockStyle.Fill;
            ProductBrand.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ProductBrand.Location = new Point(0, 165);
            ProductBrand.Margin = new Padding(0);
            ProductBrand.Name = "ProductBrand";
            ProductBrand.Size = new Size(726, 56);
            ProductBrand.TabIndex = 3;
            ProductBrand.Text = "Nhãn hàng: ";
            ProductBrand.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductType
            // 
            ProductType.Dock = DockStyle.Fill;
            ProductType.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ProductType.Location = new Point(0, 110);
            ProductType.Margin = new Padding(0);
            ProductType.Name = "ProductType";
            ProductType.Size = new Size(726, 55);
            ProductType.TabIndex = 2;
            ProductType.Text = "Loại sản phẩm: ";
            ProductType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductName
            // 
            ProductName.Dock = DockStyle.Fill;
            ProductName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ProductName.Location = new Point(0, 55);
            ProductName.Margin = new Padding(0);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(726, 55);
            ProductName.TabIndex = 1;
            ProductName.Text = "Tên sản phẩm: ";
            ProductName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductID
            // 
            ProductID.Dock = DockStyle.Fill;
            ProductID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ProductID.Location = new Point(0, 0);
            ProductID.Margin = new Padding(0);
            ProductID.Name = "ProductID";
            ProductID.Size = new Size(726, 55);
            ProductID.TabIndex = 0;
            ProductID.Text = "Mã sản phẩm: ";
            ProductID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // SupplyProductInfo
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(Body);
            Controls.Add(TitlePanel);
            Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Margin = new Padding(6, 5, 6, 5);
            Name = "SupplyProductInfo";
            Size = new Size(806, 707);
            TitlePanel.ResumeLayout(false);
            Body.ResumeLayout(false);
            SubBody.ResumeLayout(false);
            ButtonPanel.ResumeLayout(false);
            InputPanel.ResumeLayout(false);
            InputPanel.PerformLayout();
            InfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel TitlePanel;
        private Label Title;
        private CustomPanel Body;
        private CustomPanel SubBody;
        private TableLayoutPanel InfoPanel;
        private Label ProductID;
        private RoundedTableLayoutPanel InputPanel;
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
        private RoundedButton AddButton;
        private ErrorProvider errorProvider1;
    }
}
