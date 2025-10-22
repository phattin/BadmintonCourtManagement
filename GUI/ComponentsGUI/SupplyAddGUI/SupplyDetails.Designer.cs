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
            TitlePanel = new Panel();
            Title = new Label();
            Body = new Panel();
            DonePanel = new Panel();
            DoneButton = new Button();
            ListPanel = new TableLayoutPanel();
            AddPanel = new Panel();
            AddButton = new Button();
            PicturePanel = new Panel();
            Picture = new PictureBox();
            BodyPanel = new TableLayoutPanel();
            SupplyDetailTotal = new Label();
            ProductName = new Label();
            SupplyDetailIn = new Label();
            SupplyDetailQuantity = new Label();
            ProductID = new Label();
            SupplyDetailID = new Label();
            SearchPanel = new TableLayoutPanel();
            SearchBar = new TextBox();
            FilterButton = new Button();
            TitlePanel.SuspendLayout();
            Body.SuspendLayout();
            DonePanel.SuspendLayout();
            ListPanel.SuspendLayout();
            AddPanel.SuspendLayout();
            PicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Picture).BeginInit();
            BodyPanel.SuspendLayout();
            SearchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TitlePanel
            // 
            TitlePanel.Controls.Add(Title);
            TitlePanel.Dock = DockStyle.Top;
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Margin = new Padding(0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(1650, 95);
            TitlePanel.TabIndex = 0;
            // 
            // Title
            // 
            Title.Dock = DockStyle.Fill;
            Title.Font = new Font("Roboto", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(0, 0);
            Title.Name = "Title";
            Title.Size = new Size(1650, 95);
            Title.TabIndex = 0;
            Title.Text = "Chi tiết nhập hàng";
            Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Body
            // 
            Body.Controls.Add(DonePanel);
            Body.Controls.Add(ListPanel);
            Body.Controls.Add(SearchPanel);
            Body.Dock = DockStyle.Fill;
            Body.Location = new Point(0, 95);
            Body.Name = "Body";
            Body.Size = new Size(1650, 1126);
            Body.TabIndex = 1;
            // 
            // DonePanel
            // 
            DonePanel.Controls.Add(DoneButton);
            DonePanel.Dock = DockStyle.Fill;
            DonePanel.Font = new Font("Roboto Medium", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DonePanel.Location = new Point(0, 937);
            DonePanel.Margin = new Padding(0);
            DonePanel.Name = "DonePanel";
            DonePanel.Padding = new Padding(700, 40, 700, 40);
            DonePanel.Size = new Size(1650, 189);
            DonePanel.TabIndex = 2;
            // 
            // DoneButton
            // 
            DoneButton.BackColor = Color.Black;
            DoneButton.Cursor = Cursors.Hand;
            DoneButton.Dock = DockStyle.Fill;
            DoneButton.ForeColor = Color.White;
            DoneButton.Location = new Point(700, 40);
            DoneButton.Margin = new Padding(0);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(250, 109);
            DoneButton.TabIndex = 0;
            DoneButton.Text = "Hoàn tất";
            DoneButton.UseVisualStyleBackColor = false;
            DoneButton.MouseEnter += buttonEnter;
            DoneButton.MouseLeave += buttonLeave;
            // 
            // ListPanel
            // 
            ListPanel.AutoScroll = true;
            ListPanel.BackColor = Color.FromArgb(239, 248, 230);
            ListPanel.ColumnCount = 3;
            ListPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.8804073F));
            ListPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.0890579F));
            ListPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.0305347F));
            ListPanel.Controls.Add(AddPanel, 2, 0);
            ListPanel.Controls.Add(PicturePanel, 0, 0);
            ListPanel.Controls.Add(BodyPanel, 1, 0);
            ListPanel.Dock = DockStyle.Top;
            ListPanel.Location = new Point(0, 86);
            ListPanel.Margin = new Padding(0);
            ListPanel.Name = "ListPanel";
            ListPanel.RowCount = 2;
            ListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 317F));
            ListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ListPanel.Size = new Size(1650, 851);
            ListPanel.TabIndex = 1;
            // 
            // AddPanel
            // 
            AddPanel.BackColor = Color.FromArgb(200, 250, 214);
            AddPanel.Controls.Add(AddButton);
            AddPanel.Dock = DockStyle.Fill;
            AddPanel.Location = new Point(1384, 40);
            AddPanel.Margin = new Padding(0, 40, 40, 0);
            AddPanel.Name = "AddPanel";
            AddPanel.Size = new Size(226, 277);
            AddPanel.TabIndex = 2;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(200, 250, 214);
            AddButton.Cursor = Cursors.Hand;
            AddButton.Dock = DockStyle.Fill;
            AddButton.Image = Properties.Resources.Button;
            AddButton.Location = new Point(0, 0);
            AddButton.Margin = new Padding(0);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(226, 277);
            AddButton.TabIndex = 0;
            AddButton.UseVisualStyleBackColor = false;
            // 
            // PicturePanel
            // 
            PicturePanel.BackColor = Color.FromArgb(200, 250, 214);
            PicturePanel.Controls.Add(Picture);
            PicturePanel.Dock = DockStyle.Fill;
            PicturePanel.Location = new Point(40, 40);
            PicturePanel.Margin = new Padding(40, 40, 0, 0);
            PicturePanel.Name = "PicturePanel";
            PicturePanel.Padding = new Padding(30, 10, 30, 10);
            PicturePanel.Size = new Size(436, 277);
            PicturePanel.TabIndex = 0;
            // 
            // Picture
            // 
            Picture.Dock = DockStyle.Fill;
            Picture.Image = Properties.Resources.Picture;
            Picture.Location = new Point(30, 10);
            Picture.Name = "Picture";
            Picture.Size = new Size(376, 257);
            Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture.TabIndex = 0;
            Picture.TabStop = false;
            // 
            // BodyPanel
            // 
            BodyPanel.BackColor = Color.FromArgb(200, 250, 214);
            BodyPanel.ColumnCount = 2;
            BodyPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.5991173F));
            BodyPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.4008827F));
            BodyPanel.Controls.Add(SupplyDetailTotal, 1, 2);
            BodyPanel.Controls.Add(ProductName, 0, 2);
            BodyPanel.Controls.Add(SupplyDetailIn, 1, 1);
            BodyPanel.Controls.Add(SupplyDetailQuantity, 1, 0);
            BodyPanel.Controls.Add(ProductID, 0, 1);
            BodyPanel.Controls.Add(SupplyDetailID, 0, 0);
            BodyPanel.Dock = DockStyle.Fill;
            BodyPanel.Location = new Point(476, 40);
            BodyPanel.Margin = new Padding(0, 40, 0, 0);
            BodyPanel.Name = "BodyPanel";
            BodyPanel.RowCount = 3;
            BodyPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            BodyPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            BodyPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            BodyPanel.Size = new Size(908, 277);
            BodyPanel.TabIndex = 3;
            // 
            // SupplyDetailTotal
            // 
            SupplyDetailTotal.Dock = DockStyle.Fill;
            SupplyDetailTotal.Font = new Font("Roboto Medium", 18F, FontStyle.Bold);
            SupplyDetailTotal.Location = new Point(526, 184);
            SupplyDetailTotal.Name = "SupplyDetailTotal";
            SupplyDetailTotal.Size = new Size(379, 93);
            SupplyDetailTotal.TabIndex = 5;
            SupplyDetailTotal.Text = "Thành tiền: 10.000.000đ";
            SupplyDetailTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductName
            // 
            ProductName.Dock = DockStyle.Fill;
            ProductName.Font = new Font("Roboto Medium", 18F, FontStyle.Bold);
            ProductName.Location = new Point(3, 184);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(517, 93);
            ProductName.TabIndex = 4;
            ProductName.Text = "Tên sản phẩm: Giày thể thao";
            ProductName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SupplyDetailIn
            // 
            SupplyDetailIn.Dock = DockStyle.Fill;
            SupplyDetailIn.Font = new Font("Roboto Medium", 18F, FontStyle.Bold);
            SupplyDetailIn.Location = new Point(526, 92);
            SupplyDetailIn.Name = "SupplyDetailIn";
            SupplyDetailIn.Size = new Size(379, 92);
            SupplyDetailIn.TabIndex = 3;
            SupplyDetailIn.Text = "Đơn giá: 100.000đ";
            SupplyDetailIn.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SupplyDetailQuantity
            // 
            SupplyDetailQuantity.Dock = DockStyle.Fill;
            SupplyDetailQuantity.Font = new Font("Roboto Medium", 18F, FontStyle.Bold);
            SupplyDetailQuantity.Location = new Point(526, 0);
            SupplyDetailQuantity.Name = "SupplyDetailQuantity";
            SupplyDetailQuantity.Size = new Size(379, 92);
            SupplyDetailQuantity.TabIndex = 2;
            SupplyDetailQuantity.Text = "Số lượng: 100";
            SupplyDetailQuantity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductID
            // 
            ProductID.Dock = DockStyle.Fill;
            ProductID.Font = new Font("Roboto Medium", 18F, FontStyle.Bold);
            ProductID.Location = new Point(3, 92);
            ProductID.Name = "ProductID";
            ProductID.Size = new Size(517, 92);
            ProductID.TabIndex = 1;
            ProductID.Text = "Mã sản phẩm: SP0001";
            ProductID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SupplyDetailID
            // 
            SupplyDetailID.Dock = DockStyle.Fill;
            SupplyDetailID.Font = new Font("Roboto Medium", 18F, FontStyle.Bold);
            SupplyDetailID.Location = new Point(3, 0);
            SupplyDetailID.Name = "SupplyDetailID";
            SupplyDetailID.Size = new Size(517, 92);
            SupplyDetailID.TabIndex = 0;
            SupplyDetailID.Text = "Mã chi tiết nhập hàng: CTNH0001";
            SupplyDetailID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SearchPanel
            // 
            SearchPanel.AutoSize = true;
            SearchPanel.BackColor = Color.FromArgb(0, 120, 103);
            SearchPanel.ColumnCount = 2;
            SearchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.04326F));
            SearchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.9567432F));
            SearchPanel.Controls.Add(SearchBar, 0, 0);
            SearchPanel.Controls.Add(FilterButton, 1, 0);
            SearchPanel.Dock = DockStyle.Top;
            SearchPanel.Location = new Point(0, 0);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.RowCount = 1;
            SearchPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            SearchPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            SearchPanel.Size = new Size(1650, 86);
            SearchPanel.TabIndex = 0;
            // 
            // SearchBar
            // 
            SearchBar.Dock = DockStyle.Fill;
            SearchBar.Font = new Font("Roboto Medium", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBar.Location = new Point(15, 15);
            SearchBar.Margin = new Padding(15);
            SearchBar.Name = "SearchBar";
            SearchBar.PlaceholderText = "value...";
            SearchBar.Size = new Size(1307, 56);
            SearchBar.TabIndex = 0;
            // 
            // FilterButton
            // 
            FilterButton.BackColor = Color.FromArgb(0, 120, 103);
            FilterButton.Cursor = Cursors.Hand;
            FilterButton.Dock = DockStyle.Fill;
            FilterButton.ForeColor = Color.FromArgb(0, 120, 103);
            FilterButton.Image = Properties.Resources.Filter;
            FilterButton.Location = new Point(1437, 0);
            FilterButton.Margin = new Padding(100, 0, 100, 0);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(113, 86);
            FilterButton.TabIndex = 1;
            FilterButton.UseVisualStyleBackColor = false;
            FilterButton.Click += FilterButton_Click;
            FilterButton.MouseEnter += FilterButton_MouseEnter;
            FilterButton.MouseLeave += FilterButton_MouseLeave;
            // 
            // SupplyDetails
            // 
            AutoScaleDimensions = new SizeF(33F, 68F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Body);
            Controls.Add(TitlePanel);
            Font = new Font("Roboto Medium", 34.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(0);
            Name = "SupplyDetails";
            Size = new Size(1650, 1221);
            TitlePanel.ResumeLayout(false);
            Body.ResumeLayout(false);
            Body.PerformLayout();
            DonePanel.ResumeLayout(false);
            ListPanel.ResumeLayout(false);
            AddPanel.ResumeLayout(false);
            PicturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Picture).EndInit();
            BodyPanel.ResumeLayout(false);
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TitlePanel;
        private Label Title;
        private Panel Body;
        private TableLayoutPanel SearchPanel;
        private TextBox SearchBar;
        private Button FilterButton;
        private TableLayoutPanel ListPanel;
        private Panel PicturePanel;
        private Panel AddPanel;
        private PictureBox Picture;
        private Button AddButton;
        private TableLayoutPanel BodyPanel;
        private Label ProductID;
        private Label SupplyDetailID;
        private Label SupplyDetailTotal;
        private Label ProductName;
        private Label SupplyDetailIn;
        private Label SupplyDetailQuantity;
        private Panel DonePanel;
        private Button DoneButton;
    }
}
