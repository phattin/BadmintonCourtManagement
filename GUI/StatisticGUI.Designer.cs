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
            customPanel5 = new CustomPanel();
            dateTimePicker1 = new DateTimePicker();
            customPanel9 = new CustomPanel();
            sortFieldComboBox = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            customPanel2 = new CustomPanel();
            customPanel3 = new CustomPanel();
            btnGenerate = new Label();
            customPanel1 = new CustomPanel();
            dgTopProducts = new DataGridView();
            label1 = new Label();
            drPanelCourtMN = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label3 = new Label();
            customPanel10 = new CustomPanel();
            dataGridView1 = new DataGridView();
            customPanel4 = new CustomPanel();
            label4 = new Label();
            customPanel6 = new CustomPanel();
            dateTimePicker3 = new DateTimePicker();
            customPanel7 = new CustomPanel();
            label2 = new Label();
            customPanel8 = new CustomPanel();
            dateTimePicker4 = new DateTimePicker();
            textBox1 = new TextBox();
            customPanel5.SuspendLayout();
            customPanel9.SuspendLayout();
            customPanel2.SuspendLayout();
            customPanel3.SuspendLayout();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgTopProducts).BeginInit();
            drPanelCourtMN.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            customPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            customPanel4.SuspendLayout();
            customPanel6.SuspendLayout();
            customPanel7.SuspendLayout();
            customPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel5
            // 
            customPanel5.BackColor = Color.White;
            customPanel5.BorderRadius = 10;
            customPanel5.Controls.Add(dateTimePicker1);
            customPanel5.Location = new Point(465, 31);
            customPanel5.Margin = new Padding(4, 3, 4, 3);
            customPanel5.Name = "customPanel5";
            customPanel5.Size = new Size(320, 40);
            customPanel5.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(4, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(310, 31);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // customPanel9
            // 
            customPanel9.BackColor = Color.White;
            customPanel9.BorderRadius = 10;
            customPanel9.Controls.Add(sortFieldComboBox);
            customPanel9.Location = new Point(876, 29);
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
            sortFieldComboBox.Location = new Point(2, 4);
            sortFieldComboBox.Name = "sortFieldComboBox";
            sortFieldComboBox.Size = new Size(268, 33);
            sortFieldComboBox.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(5, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(310, 31);
            dateTimePicker2.TabIndex = 1;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel2.BackColor = Color.FromArgb(0, 120, 103);
            customPanel2.BorderRadius = 20;
            customPanel2.Controls.Add(customPanel3);
            customPanel2.Controls.Add(customPanel9);
            customPanel2.Controls.Add(btnGenerate);
            customPanel2.Controls.Add(customPanel5);
            customPanel2.Location = new Point(74, 84);
            customPanel2.Margin = new Padding(4, 5, 4, 5);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(1572, 98);
            customPanel2.TabIndex = 0;
            // 
            // customPanel3
            // 
            customPanel3.BackColor = Color.White;
            customPanel3.BorderRadius = 10;
            customPanel3.Controls.Add(dateTimePicker2);
            customPanel3.Location = new Point(90, 31);
            customPanel3.Margin = new Padding(4, 3, 4, 3);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(320, 40);
            customPanel3.TabIndex = 2;
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerate.AutoSize = true;
            btnGenerate.BackColor = Color.FromArgb(64, 64, 64);
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.WhiteSmoke;
            btnGenerate.Location = new Point(1376, 19);
            btnGenerate.Margin = new Padding(4, 0, 4, 0);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Padding = new Padding(15, 10, 15, 10);
            btnGenerate.Size = new Size(153, 52);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Thống Kê";
            btnGenerate.TextAlign = ContentAlignment.MiddleCenter;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // customPanel1
            // 
            customPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customPanel1.BackColor = Color.FromArgb(239, 248, 230);
            customPanel1.BorderRadius = 20;
            customPanel1.Controls.Add(dgTopProducts);
            customPanel1.Location = new Point(74, 182);
            customPanel1.Margin = new Padding(4, 5, 4, 5);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(1572, 900);
            customPanel1.TabIndex = 1;
            // 
            // dgTopProducts
            // 
            dgTopProducts.AllowUserToAddRows = false;
            dgTopProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgTopProducts.BackgroundColor = Color.White;
            dgTopProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTopProducts.Location = new Point(35, 35);
            dgTopProducts.Name = "dgTopProducts";
            dgTopProducts.ReadOnly = true;
            dgTopProducts.RowHeadersVisible = false;
            dgTopProducts.RowHeadersWidth = 62;
            dgTopProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgTopProducts.Size = new Size(1490, 830);
            dgTopProducts.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(63, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(197, 68);
            label1.TabIndex = 4;
            label1.Text = "Thống Kê";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // drPanelCourtMN
            // 
            drPanelCourtMN.BackColor = Color.White;
            drPanelCourtMN.Controls.Add(tabControl1);
            drPanelCourtMN.Dock = DockStyle.Fill;
            drPanelCourtMN.Location = new Point(0, 0);
            drPanelCourtMN.Name = "drPanelCourtMN";
            drPanelCourtMN.Size = new Size(1554, 957);
            drPanelCourtMN.TabIndex = 0;
            drPanelCourtMN.Paint += drPanelCourtMN_Paint;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1750, 1200);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(customPanel1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(customPanel2);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1742, 1162);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sản Phẩm";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(customPanel10);
            tabPage2.Controls.Add(customPanel4);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1742, 1162);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Sân";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(63, 11);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(10);
            label3.Size = new Size(197, 68);
            label3.TabIndex = 5;
            label3.Text = "Thống Kê";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customPanel10
            // 
            customPanel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customPanel10.BackColor = Color.FromArgb(239, 248, 230);
            customPanel10.BorderRadius = 20;
            customPanel10.Controls.Add(dataGridView1);
            customPanel10.Location = new Point(74, 182);
            customPanel10.Margin = new Padding(4, 5, 4, 5);
            customPanel10.Name = "customPanel10";
            customPanel10.Size = new Size(1572, 900);
            customPanel10.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1490, 830);
            dataGridView1.TabIndex = 2;
            // 
            // customPanel4
            // 
            customPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel4.BackColor = Color.FromArgb(0, 120, 103);
            customPanel4.BorderRadius = 20;
            customPanel4.Controls.Add(label4);
            customPanel4.Controls.Add(customPanel6);
            customPanel4.Controls.Add(customPanel7);
            customPanel4.Controls.Add(label2);
            customPanel4.Controls.Add(customPanel8);
            customPanel4.Location = new Point(74, 84);
            customPanel4.Margin = new Padding(4, 5, 4, 5);
            customPanel4.Name = "customPanel4";
            customPanel4.Size = new Size(1572, 98);
            customPanel4.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(64, 64, 64);
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(1376, 19);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(15, 10, 15, 10);
            label4.Size = new Size(153, 52);
            label4.TabIndex = 6;
            label4.Text = "Thống Kê";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customPanel6
            // 
            customPanel6.BackColor = Color.White;
            customPanel6.BorderRadius = 10;
            customPanel6.Controls.Add(dateTimePicker3);
            customPanel6.Location = new Point(90, 31);
            customPanel6.Margin = new Padding(4, 3, 4, 3);
            customPanel6.Name = "customPanel6";
            customPanel6.Size = new Size(320, 40);
            customPanel6.TabIndex = 2;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(5, 4);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(310, 31);
            dateTimePicker3.TabIndex = 1;
            // 
            // customPanel7
            // 
            customPanel7.BackColor = Color.White;
            customPanel7.BorderRadius = 10;
            customPanel7.Controls.Add(textBox1);
            customPanel7.Location = new Point(876, 29);
            customPanel7.Margin = new Padding(4, 3, 4, 3);
            customPanel7.Name = "customPanel7";
            customPanel7.Size = new Size(273, 40);
            customPanel7.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 64, 64);
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(2748, 19);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(15, 10, 15, 10);
            label2.Size = new Size(153, 52);
            label2.TabIndex = 4;
            label2.Text = "Thống Kê";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customPanel8
            // 
            customPanel8.BackColor = Color.White;
            customPanel8.BorderRadius = 10;
            customPanel8.Controls.Add(dateTimePicker4);
            customPanel8.Location = new Point(465, 31);
            customPanel8.Margin = new Padding(4, 3, 4, 3);
            customPanel8.Name = "customPanel8";
            customPanel8.Size = new Size(320, 40);
            customPanel8.TabIndex = 1;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(4, 4);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(310, 31);
            dateTimePicker4.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(4, 6);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Value";
            textBox1.Size = new Size(265, 30);
            textBox1.TabIndex = 6;
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
            customPanel5.ResumeLayout(false);
            customPanel9.ResumeLayout(false);
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            customPanel3.ResumeLayout(false);
            customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgTopProducts).EndInit();
            drPanelCourtMN.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            customPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            customPanel4.ResumeLayout(false);
            customPanel4.PerformLayout();
            customPanel6.ResumeLayout(false);
            customPanel7.ResumeLayout(false);
            customPanel7.PerformLayout();
            customPanel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label btnGenerate;
        private CustomPanel customPanel1;
        private DataGridView dgTopProducts;
        private CustomPanel customPanel2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private CustomPanel customPanel9;
        private CustomPanel customPanel5;
        private Panel drPanelCourtMN;
        private CustomPanel customPanel3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox sortFieldComboBox;
        private Label label1;
        private Label label3;
        private CustomPanel customPanel10;
        private DataGridView dataGridView1;
        private CustomPanel customPanel4;
        private CustomPanel customPanel6;
        private DateTimePicker dateTimePicker3;
        private CustomPanel customPanel7;
        private Label label2;
        private CustomPanel customPanel8;
        private DateTimePicker dateTimePicker4;
        private Label label4;
        private TextBox textBox1;
    }
}