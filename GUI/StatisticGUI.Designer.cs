namespace BadmintonCourtManagement.GUI
{
    partial class StatisticGUI
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
            lblTitle = new Label();
            customPanel1 = new CustomPanel();
            dgTopProducts = new DataGridView();
            customPanel2 = new CustomPanel();
            customPanel9 = new CustomPanel();
            sortFieldComboBox = new ComboBox();
            customPanel7 = new CustomPanel();
            dateTimePicker2 = new DateTimePicker();
            customPanel5 = new CustomPanel();
            dateTimePicker1 = new DateTimePicker();
            btnGenerate = new Label();
            drPanelCourtMN = new Panel();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgTopProducts).BeginInit();
            customPanel2.SuspendLayout();
            customPanel9.SuspendLayout();
            customPanel7.SuspendLayout();
            customPanel5.SuspendLayout();
            drPanelCourtMN.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(50, 20);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(10);
            lblTitle.Size = new Size(197, 68);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thống Kê";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customPanel1
            // 
            customPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customPanel1.BackColor = Color.FromArgb(239, 248, 230);
            customPanel1.BorderRadius = 20;
            customPanel1.Controls.Add(dgTopProducts);
            customPanel1.Controls.Add(customPanel2);
            customPanel1.Location = new Point(50, 80);
            customPanel1.Margin = new Padding(4, 5, 4, 5);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(1450, 850);
            customPanel1.TabIndex = 1;
            // 
            // dgTopProducts
            // 
            dgTopProducts.AllowUserToAddRows = false;
            dgTopProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgTopProducts.BackgroundColor = Color.White;
            dgTopProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTopProducts.Location = new Point(20, 120);
            dgTopProducts.Name = "dgTopProducts";
            dgTopProducts.ReadOnly = true;
            dgTopProducts.RowHeadersVisible = false;
            dgTopProducts.RowHeadersWidth = 62;
            dgTopProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgTopProducts.Size = new Size(1410, 710);
            dgTopProducts.TabIndex = 2;
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel2.BackColor = Color.FromArgb(0, 120, 103);
            customPanel2.BorderRadius = 20;
            customPanel2.Controls.Add(customPanel9);
            customPanel2.Controls.Add(customPanel7);
            customPanel2.Controls.Add(customPanel5);
            customPanel2.Controls.Add(btnGenerate);
            customPanel2.Location = new Point(10, 10);
            customPanel2.Margin = new Padding(4, 5, 4, 5);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(1430, 100);
            customPanel2.TabIndex = 0;
            // 
            // customPanel9
            // 
            customPanel9.BackColor = Color.White;
            customPanel9.BorderRadius = 10;
            customPanel9.Controls.Add(sortFieldComboBox);
            customPanel9.Location = new Point(770, 30);
            customPanel9.Margin = new Padding(4, 3, 4, 3);
            customPanel9.Name = "customPanel9";
            customPanel9.Size = new Size(273, 40);
            customPanel9.TabIndex = 3;
            // 
            // sortFieldComboBox
            // 
            sortFieldComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sortFieldComboBox.FormattingEnabled = true;
            sortFieldComboBox.Items.AddRange(new object[] { "Số lượng sản phẩm giảm dần", "Số lượng sản phẩm tăng dần", "Doanh thu tăng dần", "Doanh thu giảm dần" });
            sortFieldComboBox.Location = new Point(2, 3);
            sortFieldComboBox.Name = "sortFieldComboBox";
            sortFieldComboBox.Size = new Size(268, 33);
            sortFieldComboBox.TabIndex = 0;
            sortFieldComboBox.SelectedIndexChanged += sortFieldComboBox_SelectedIndexChanged;
            // 
            // customPanel7
            // 
            customPanel7.BackColor = Color.White;
            customPanel7.BorderRadius = 10;
            customPanel7.Controls.Add(dateTimePicker2);
            customPanel7.Location = new Point(400, 30);
            customPanel7.Margin = new Padding(4, 3, 4, 3);
            customPanel7.Name = "customPanel7";
            customPanel7.Size = new Size(320, 40);
            customPanel7.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(5, 5);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(310, 31);
            dateTimePicker2.TabIndex = 1;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // customPanel5
            // 
            customPanel5.BackColor = Color.White;
            customPanel5.BorderRadius = 10;
            customPanel5.Controls.Add(dateTimePicker1);
            customPanel5.Location = new Point(50, 30);
            customPanel5.Margin = new Padding(4, 3, 4, 3);
            customPanel5.Name = "customPanel5";
            customPanel5.Size = new Size(320, 40);
            customPanel5.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(5, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(310, 31);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerate.AutoSize = true;
            btnGenerate.BackColor = Color.FromArgb(64, 64, 64);
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.WhiteSmoke;
            btnGenerate.Location = new Point(1250, 20);
            btnGenerate.Margin = new Padding(4, 0, 4, 0);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Padding = new Padding(15, 10, 15, 10);
            btnGenerate.Size = new Size(153, 52);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Thống Kê";
            btnGenerate.TextAlign = ContentAlignment.MiddleCenter;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // drPanelCourtMN
            // 
            drPanelCourtMN.BackColor = Color.White;
            drPanelCourtMN.Controls.Add(customPanel1);
            drPanelCourtMN.Controls.Add(lblTitle);
            drPanelCourtMN.Dock = DockStyle.Fill;
            drPanelCourtMN.Location = new Point(0, 0);
            drPanelCourtMN.Name = "drPanelCourtMN";
            drPanelCourtMN.Size = new Size(1554, 957);
            drPanelCourtMN.TabIndex = 0;
            // 
            // StatisticGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(drPanelCourtMN);
            Margin = new Padding(4, 5, 4, 5);
            Name = "StatisticGUI";
            Size = new Size(1554, 957);
            Load += StatisticGUI_Load;
            customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgTopProducts).EndInit();
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            customPanel9.ResumeLayout(false);
            customPanel7.ResumeLayout(false);
            customPanel5.ResumeLayout(false);
            drPanelCourtMN.ResumeLayout(false);
            drPanelCourtMN.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private CustomPanel customPanel1;
        private CustomPanel customPanel2;
        private Label btnGenerate;
        private DataGridView dgTopProducts;
        private CustomPanel customPanel7;
        private DateTimePicker dateTimePicker2;
        private CustomPanel customPanel5;
        private DateTimePicker dateTimePicker1;
        private CustomPanel customPanel9;
        private ComboBox sortFieldComboBox;
        private Panel drPanelCourtMN;
    }
}