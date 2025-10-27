﻿namespace BadmintonCourtManagement.GUI
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
            sortFieldComboBox = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            customPanel2 = new CustomPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dateTimePicker1 = new DateTimePicker();
            btnGenerate = new Label();
            customPanel1 = new CustomPanel();
            dgTopProducts = new DataGridView();
            label1 = new Label();
            drPanelCourtMN = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            tabPage2 = new TabPage();
            customPanel4 = new CustomPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            textBox1 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            customPanel10 = new CustomPanel();
            dataGridView1 = new DataGridView();
            customPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgTopProducts).BeginInit();
            drPanelCourtMN.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            customPanel4.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            customPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // sortFieldComboBox
            // 
            sortFieldComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sortFieldComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sortFieldComboBox.FormattingEnabled = true;
            sortFieldComboBox.Items.AddRange(new object[] { "Số lượng sản phẩm giảm dần", "Số lượng sản phẩm tăng dần", "Doanh thu tăng dần", "Doanh thu giảm dần" });
            sortFieldComboBox.Location = new Point(859, 35);
            sortFieldComboBox.Margin = new Padding(130, 10, 0, 0);
            sortFieldComboBox.Name = "sortFieldComboBox";
            sortFieldComboBox.Size = new Size(273, 33);
            sortFieldComboBox.TabIndex = 3;
            sortFieldComboBox.SelectedIndexChanged += sortFieldComboBox_SelectedIndexChanged_1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(35, 35);
            dateTimePicker2.Margin = new Padding(35, 10, 30, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(320, 31);
            dateTimePicker2.TabIndex = 1;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.FromArgb(0, 120, 103);
            customPanel2.BorderRadius = 20;
            customPanel2.Controls.Add(flowLayoutPanel1);
            customPanel2.Dock = DockStyle.Top;
            customPanel2.Location = new Point(70, 84);
            customPanel2.Margin = new Padding(0);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(1364, 97);
            customPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(dateTimePicker2);
            flowLayoutPanel1.Controls.Add(dateTimePicker1);
            flowLayoutPanel1.Controls.Add(sortFieldComboBox);
            flowLayoutPanel1.Controls.Add(btnGenerate);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 25, 0, 0);
            flowLayoutPanel1.Size = new Size(1364, 97);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(395, 35);
            dateTimePicker1.Margin = new Padding(10, 10, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(334, 31);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(64, 64, 64);
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.WhiteSmoke;
            btnGenerate.Location = new Point(240, 66);
            btnGenerate.Margin = new Padding(240, 0, 10, 10);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Padding = new Padding(15, 0, 15, 0);
            btnGenerate.Size = new Size(153, 37);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Thống Kê";
            btnGenerate.TextAlign = ContentAlignment.MiddleCenter;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.FromArgb(239, 248, 230);
            customPanel1.BorderRadius = 20;
            customPanel1.Controls.Add(dgTopProducts);
            customPanel1.Dock = DockStyle.Fill;
            customPanel1.Location = new Point(70, 84);
            customPanel1.Margin = new Padding(20);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(37, 98, 37, 20);
            customPanel1.Size = new Size(1364, 619);
            customPanel1.TabIndex = 1;
            customPanel1.Paint += customPanel1_Paint;
            // 
            // dgTopProducts
            // 
            dgTopProducts.AllowUserToAddRows = false;
            dgTopProducts.BackgroundColor = Color.White;
            dgTopProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTopProducts.Dock = DockStyle.Fill;
            dgTopProducts.Location = new Point(37, 98);
            dgTopProducts.Name = "dgTopProducts";
            dgTopProducts.ReadOnly = true;
            dgTopProducts.RowHeadersVisible = false;
            dgTopProducts.RowHeadersWidth = 62;
            dgTopProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgTopProducts.Size = new Size(1290, 501);
            dgTopProducts.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(1364, 84);
            label1.TabIndex = 4;
            label1.Text = "Thống Kê";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // drPanelCourtMN
            // 
            drPanelCourtMN.BackColor = Color.White;
            drPanelCourtMN.Controls.Add(tabControl1);
            drPanelCourtMN.Dock = DockStyle.Fill;
            drPanelCourtMN.Location = new Point(0, 0);
            drPanelCourtMN.Name = "drPanelCourtMN";
            drPanelCourtMN.Size = new Size(1512, 741);
            drPanelCourtMN.TabIndex = 0;
            drPanelCourtMN.Paint += drPanelCourtMN_Paint;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1512, 741);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(customPanel2);
            tabPage1.Controls.Add(customPanel1);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(0);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(70, 0, 70, 0);
            tabPage1.Size = new Size(1504, 703);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sản Phẩm";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(70, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1364, 84);
            panel1.TabIndex = 5;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(customPanel4);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(customPanel10);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(70, 0, 70, 0);
            tabPage2.Size = new Size(1504, 703);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Sân";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // customPanel4
            // 
            customPanel4.BackColor = Color.FromArgb(0, 120, 103);
            customPanel4.BorderRadius = 20;
            customPanel4.Controls.Add(flowLayoutPanel2);
            customPanel4.Controls.Add(label2);
            customPanel4.Dock = DockStyle.Top;
            customPanel4.Location = new Point(70, 84);
            customPanel4.Margin = new Padding(4, 5, 4, 5);
            customPanel4.Name = "customPanel4";
            customPanel4.Size = new Size(1364, 98);
            customPanel4.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(dateTimePicker3);
            flowLayoutPanel2.Controls.Add(dateTimePicker4);
            flowLayoutPanel2.Controls.Add(textBox1);
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(0, 25, 0, 0);
            flowLayoutPanel2.Size = new Size(1364, 98);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(35, 35);
            dateTimePicker3.Margin = new Padding(35, 10, 30, 0);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(310, 31);
            dateTimePicker3.TabIndex = 1;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(385, 35);
            dateTimePicker4.Margin = new Padding(10, 10, 0, 0);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(310, 31);
            dateTimePicker4.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(825, 35);
            textBox1.Margin = new Padding(130, 10, 0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Value";
            textBox1.Size = new Size(265, 30);
            textBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(64, 64, 64);
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(240, 76);
            label4.Margin = new Padding(240, 10, 10, 10);
            label4.Name = "label4";
            label4.Padding = new Padding(15, 0, 15, 0);
            label4.Size = new Size(153, 32);
            label4.TabIndex = 6;
            label4.Text = "Thống Kê";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 64, 64);
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(2540, 19);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(15, 10, 15, 10);
            label2.Size = new Size(153, 52);
            label2.TabIndex = 4;
            label2.Text = "Thống Kê";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(70, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1364, 84);
            panel2.TabIndex = 6;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(0, 0);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(10);
            label5.Size = new Size(1364, 84);
            label5.TabIndex = 4;
            label5.Text = "Thống Kê";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // customPanel10
            // 
            customPanel10.BackColor = Color.FromArgb(239, 248, 230);
            customPanel10.BorderRadius = 20;
            customPanel10.Controls.Add(dataGridView1);
            customPanel10.Dock = DockStyle.Fill;
            customPanel10.Location = new Point(70, 0);
            customPanel10.Margin = new Padding(20);
            customPanel10.Name = "customPanel10";
            customPanel10.Padding = new Padding(37, 183, 37, 20);
            customPanel10.Size = new Size(1364, 703);
            customPanel10.TabIndex = 2;
            customPanel10.Paint += customPanel10_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(37, 183);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1290, 500);
            dataGridView1.TabIndex = 2;
            // 
            // StatisticGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(drPanelCourtMN);
            Margin = new Padding(4, 5, 4, 5);
            Name = "StatisticGUI";
            Size = new Size(1512, 741);
            Load += StatisticGUI_Load;
            customPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgTopProducts).EndInit();
            drPanelCourtMN.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            customPanel4.ResumeLayout(false);
            customPanel4.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            customPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label btnGenerate;
        private CustomPanel customPanel1;
        private DataGridView dgTopProducts;
        private CustomPanel customPanel2;
        private DateTimePicker dateTimePicker2;
        private Panel drPanelCourtMN;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox sortFieldComboBox;
        private Label label1;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private Label label4;
        private TextBox textBox1;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private FlowLayoutPanel flowLayoutPanel1;
        private CustomPanel customPanel10;
        private DataGridView dataGridView1;
        private CustomPanel customPanel4;
        private Label label2;
        private Panel panel2;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}