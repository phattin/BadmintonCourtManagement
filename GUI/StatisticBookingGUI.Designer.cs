namespace GUI
{
    partial class StatisticBookingGUI
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTop = new Panel();
            labelTitle = new Label();
            buttonTK = new Button();
            panelBottom = new Panel();
            customPanel1 = new BadmintonCourtManagement.GUI.CustomPanel();
            panelDataGridView = new Panel();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            CourtId = new DataGridViewTextBoxColumn();
            CourtName = new DataGridViewTextBoxColumn();
            TotalBook = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            chartStatistic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            customPanel2 = new BadmintonCourtManagement.GUI.CustomPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            customPanel3 = new BadmintonCourtManagement.GUI.CustomPanel();
            textBox1 = new TextBox();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            customPanel1.SuspendLayout();
            panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartStatistic).BeginInit();
            customPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            customPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1221, 72);
            panelTop.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(1221, 72);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Thống kê đặt sân";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonTK
            // 
            buttonTK.BackColor = Color.FromArgb(64, 64, 64);
            buttonTK.Dock = DockStyle.Right;
            buttonTK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTK.ForeColor = Color.White;
            buttonTK.Location = new Point(913, 25);
            buttonTK.Name = "buttonTK";
            buttonTK.Size = new Size(177, 38);
            buttonTK.TabIndex = 1;
            buttonTK.Text = "Thống kê";
            buttonTK.UseVisualStyleBackColor = false;
            buttonTK.Click += buttonTK_Click;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(customPanel1);
            panelBottom.Dock = DockStyle.Fill;
            panelBottom.Location = new Point(0, 72);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(53, 0, 53, 40);
            panelBottom.Size = new Size(1221, 614);
            panelBottom.TabIndex = 1;
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
            customPanel1.Size = new Size(1115, 574);
            customPanel1.TabIndex = 2;
            // 
            // panelDataGridView
            // 
            panelDataGridView.Controls.Add(splitContainer1);
            panelDataGridView.Dock = DockStyle.Fill;
            panelDataGridView.Location = new Point(0, 88);
            panelDataGridView.Name = "panelDataGridView";
            panelDataGridView.Padding = new Padding(20);
            panelDataGridView.Size = new Size(1115, 486);
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
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(chartStatistic);
            splitContainer1.Size = new Size(1075, 446);
            splitContainer1.SplitterDistance = 500;
            splitContainer1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 120, 103);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CourtId, CourtName, TotalBook, TotalPrice });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(500, 446);
            dataGridView1.TabIndex = 0;
            // 
            // CourtId
            // 
            CourtId.DataPropertyName = "MaSan";
            CourtId.HeaderText = "Mã sân";
            CourtId.MinimumWidth = 6;
            CourtId.Name = "CourtId";
            CourtId.Width = 125;
            // 
            // CourtName
            // 
            CourtName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CourtName.DataPropertyName = "TenSan";
            CourtName.HeaderText = "Tên sân";
            CourtName.MinimumWidth = 6;
            CourtName.Name = "CourtName";
            // 
            // TotalBook
            // 
            TotalBook.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalBook.DataPropertyName = "TongSoLanDat";
            TotalBook.HeaderText = "Tổng số lần đặt";
            TotalBook.MinimumWidth = 6;
            TotalBook.Name = "TotalBook";
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalPrice.DataPropertyName = "TongTien";
            dataGridViewCellStyle2.Format = "#,##0 \"VND\"";
            TotalPrice.DefaultCellStyle = dataGridViewCellStyle2;
            TotalPrice.HeaderText = "Tổng tiền";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            // 
            // chartStatistic
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.Title = "Danh sách sân";
            chartArea1.AxisX.TitleFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chartArea1.AxisY.LabelStyle.Format = "#,##0";
            chartArea1.AxisY.Title = "Doanh thu (VND)";
            chartArea1.AxisY.TitleFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.Title = "Số lượt đặt (Lần)";
            chartArea1.AxisY2.TitleFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            chartStatistic.ChartAreas.Add(chartArea1);
            chartStatistic.Dock = DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chartStatistic.Legends.Add(legend1);
            chartStatistic.Location = new Point(0, 0);
            chartStatistic.Name = "chartStatistic";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackSecondaryColor = Color.White;
            series1.BorderColor = Color.FromArgb(0, 120, 103);
            series1.ChartArea = "ChartArea1";
            series1.Color = Color.FromArgb(0, 120, 103);
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "#,##0";
            series1.Legend = "Legend1";
            series1.LegendText = "Doanh thu";
            series1.Name = "SeriesDoanhThu";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = Color.FromArgb(255, 193, 7);
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.LegendText = "Số lượt đặt";
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "SeriesSoLuong";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            chartStatistic.Series.Add(series1);
            chartStatistic.Series.Add(series2);
            chartStatistic.Size = new Size(571, 446);
            chartStatistic.TabIndex = 0;
            chartStatistic.Text = "chart1";
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.FromArgb(0, 120, 103);
            customPanel2.BorderRadius = 20;
            customPanel2.Controls.Add(tableLayoutPanel1);
            customPanel2.Controls.Add(buttonTK);
            customPanel2.Controls.Add(customPanel3);
            customPanel2.Dock = DockStyle.Top;
            customPanel2.Location = new Point(0, 0);
            customPanel2.Name = "customPanel2";
            customPanel2.Padding = new Padding(25);
            customPanel2.Size = new Size(1115, 88);
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
            tableLayoutPanel1.Location = new Point(555, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(358, 38);
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
            dateTimePicker1.Size = new Size(173, 34);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Dock = DockStyle.Fill;
            dateTimePicker2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(182, 3);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(173, 34);
            dateTimePicker2.TabIndex = 1;
            // 
            // customPanel3
            // 
            customPanel3.BackColor = Color.White;
            customPanel3.BorderRadius = 30;
            customPanel3.Controls.Add(textBox1);
            customPanel3.Dock = DockStyle.Left;
            customPanel3.Location = new Point(25, 25);
            customPanel3.Margin = new Padding(3, 2, 3, 2);
            customPanel3.Name = "customPanel3";
            customPanel3.Padding = new Padding(10, 3, 0, 0);
            customPanel3.Size = new Size(530, 38);
            customPanel3.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(10, 3);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tìm kiếm";
            textBox1.Size = new Size(520, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // StatisticBookingGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Name = "StatisticBookingGUI";
            Size = new Size(1221, 686);
            panelTop.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            customPanel1.ResumeLayout(false);
            panelDataGridView.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartStatistic).EndInit();
            customPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            customPanel3.ResumeLayout(false);
            customPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelTitle;
        private Panel panelBottom;
        private DataGridView dataGridView1;
        private Button buttonTK;
        private BadmintonCourtManagement.GUI.CustomPanel customPanel1;
        private BadmintonCourtManagement.GUI.CustomPanel customPanel2;
        private BadmintonCourtManagement.GUI.CustomPanel customPanel3;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Panel panelDataGridView;
        private SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistic;
        private DataGridViewTextBoxColumn CourtId;
        private DataGridViewTextBoxColumn CourtName;
        private DataGridViewTextBoxColumn TotalBook;
        private DataGridViewTextBoxColumn TotalPrice;
    }
}
