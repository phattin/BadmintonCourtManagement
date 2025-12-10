namespace GUI
{
    partial class StatisticTotalGUI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            labelTitle = new Label();
            panelBottom = new Panel();
            customPanel1 = new BadmintonCourtManagement.GUI.CustomPanel();
            panelDataGridView = new Panel();
            splitContainer1 = new SplitContainer();
            chartFinancial = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel6 = new Panel();
            label10 = new Label();
            label11 = new Label();
            panel5 = new Panel();
            label8 = new Label();
            label9 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel7 = new Panel();
            label1 = new Label();
            customPanel2 = new BadmintonCourtManagement.GUI.CustomPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            buttonTK = new Button();
            panelBottom.SuspendLayout();
            customPanel1.SuspendLayout();
            panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFinancial).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            customPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(1195, 72);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Tổng quan";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(customPanel1);
            panelBottom.Dock = DockStyle.Fill;
            panelBottom.Location = new Point(0, 72);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(53, 0, 53, 40);
            panelBottom.Size = new Size(1195, 650);
            panelBottom.TabIndex = 3;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.FromArgb(239, 248, 230);
            customPanel1.BorderRadius = 20;
            customPanel1.Controls.Add(panelDataGridView);
            customPanel1.Controls.Add(customPanel2);
            customPanel1.Dock = DockStyle.Fill;
            customPanel1.Location = new Point(53, 0);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(1089, 610);
            customPanel1.TabIndex = 2;
            // 
            // panelDataGridView
            // 
            panelDataGridView.Controls.Add(splitContainer1);
            panelDataGridView.Dock = DockStyle.Fill;
            panelDataGridView.Location = new Point(0, 88);
            panelDataGridView.Name = "panelDataGridView";
            panelDataGridView.Padding = new Padding(20);
            panelDataGridView.Size = new Size(1089, 522);
            panelDataGridView.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(20, 20);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(chartFinancial);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1049, 482);
            splitContainer1.SplitterDistance = 542;
            splitContainer1.TabIndex = 1;
            // 
            // chartFinancial
            // 
            chartArea1.Name = "ChartArea1";
            chartFinancial.ChartAreas.Add(chartArea1);
            chartFinancial.Dock = DockStyle.Fill;
            legend1.Alignment = StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            chartFinancial.Legends.Add(legend1);
            chartFinancial.Location = new Point(0, 0);
            chartFinancial.Name = "chartFinancial";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.CustomProperties = "PieLabelStyle=Outside";
            series1.Label = "#PERCENT";
            series1.Legend = "Legend1";
            series1.LegendText = "#VALX";
            series1.Name = "SeriesPhanTram";
            chartFinancial.Series.Add(series1);
            chartFinancial.Size = new Size(542, 482);
            chartFinancial.TabIndex = 0;
            chartFinancial.Text = "chart1";
            title1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title1.Name = "Tỷ trọng Doanh thu";
            chartFinancial.Titles.Add(title1);
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 482);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel6, 0, 4);
            tableLayoutPanel2.Controls.Add(panel5, 0, 3);
            tableLayoutPanel2.Controls.Add(panel4, 0, 2);
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 30);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(0, 10, 0, 0);
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel2.Size = new Size(503, 112);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.AutoSize = true;
            panel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel6.Controls.Add(label10);
            panel6.Controls.Add(label11);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 273);
            panel6.Name = "panel6";
            panel6.Size = new Size(497, 59);
            panel6.TabIndex = 4;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(0, 31);
            label10.Name = "label10";
            label10.Size = new Size(497, 28);
            label10.TabIndex = 1;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.Dock = DockStyle.Top;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(497, 31);
            label11.TabIndex = 0;
            label11.Text = "Tổng kết:";
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label9);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 208);
            panel5.Name = "panel5";
            panel5.Size = new Size(497, 59);
            panel5.TabIndex = 3;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(0, 31);
            label8.Name = "label8";
            label8.Size = new Size(497, 28);
            label8.TabIndex = 1;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.Dock = DockStyle.Top;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(497, 31);
            label9.TabIndex = 0;
            label9.Text = "Tổng tiền nhập hàng:";
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 143);
            panel4.Name = "panel4";
            panel4.Size = new Size(497, 59);
            panel4.TabIndex = 2;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 31);
            label6.Name = "label6";
            label6.Size = new Size(497, 28);
            label6.TabIndex = 1;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(497, 31);
            label7.TabIndex = 0;
            label7.Text = "Tổng doanh thu:";
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(497, 59);
            panel3.TabIndex = 1;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 31);
            label4.Name = "label4";
            label4.Size = new Size(497, 28);
            label4.TabIndex = 1;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(497, 31);
            label5.TabIndex = 0;
            label5.Text = "Doanh thu bán hàng:";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(497, 59);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 31);
            label3.Name = "label3";
            label3.Size = new Size(497, 28);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(497, 31);
            label2.TabIndex = 0;
            label2.Text = "Doanh thu đặt sân:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(239, 248, 230);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 142);
            panel7.Name = "panel7";
            panel7.Size = new Size(503, 340);
            panel7.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(503, 30);
            label1.TabIndex = 0;
            label1.Text = "Báo cáo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.FromArgb(0, 120, 103);
            customPanel2.BorderRadius = 20;
            customPanel2.Controls.Add(tableLayoutPanel1);
            customPanel2.Controls.Add(buttonTK);
            customPanel2.Dock = DockStyle.Top;
            customPanel2.Location = new Point(0, 0);
            customPanel2.Name = "customPanel2";
            customPanel2.Padding = new Padding(25);
            customPanel2.Size = new Size(1089, 88);
            customPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 0, 0);
            tableLayoutPanel1.Controls.Add(dateTimePicker2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(25, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(862, 38);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(3, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(425, 34);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Dock = DockStyle.Fill;
            dateTimePicker2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(434, 3);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(425, 34);
            dateTimePicker2.TabIndex = 1;
            // 
            // buttonTK
            // 
            buttonTK.BackColor = Color.FromArgb(64, 64, 64);
            buttonTK.Dock = DockStyle.Right;
            buttonTK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTK.ForeColor = Color.White;
            buttonTK.Location = new Point(887, 25);
            buttonTK.Name = "buttonTK";
            buttonTK.Size = new Size(177, 38);
            buttonTK.TabIndex = 1;
            buttonTK.Text = "Thống kê";
            buttonTK.UseVisualStyleBackColor = false;
            buttonTK.Click += buttonTK_Click;
            // 
            // StatisticTotalGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBottom);
            Controls.Add(labelTitle);
            Name = "StatisticTotalGUI";
            Size = new Size(1195, 722);
            panelBottom.ResumeLayout(false);
            customPanel1.ResumeLayout(false);
            panelDataGridView.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFinancial).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            customPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private Panel panelBottom;
        private BadmintonCourtManagement.GUI.CustomPanel customPanel1;
        private Panel panelDataGridView;
        private SplitContainer splitContainer1;
        private BadmintonCourtManagement.GUI.CustomPanel customPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button buttonTK;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFinancial;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel6;
        private Label label10;
        private Label label11;
        private Panel panel5;
        private Label label8;
        private Label label9;
        private Panel panel4;
        private Label label6;
        private Label label7;
        private Panel panel3;
        private Label label4;
        private Label label5;
        private Panel panel2;
        private Label label3;
        private Panel panel7;
    }
}
