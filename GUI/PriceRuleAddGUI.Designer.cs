namespace GUI
{
    partial class PriceRuleAddGUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTitle = new Panel();
            labelTitle = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelStartTime = new Panel();
            labelStartTime = new Label();
            textBoxStartTime = new TextBox();
            panelEndTime = new Panel();
            textBox1 = new TextBox();
            labelEndTime = new Label();
            panelStartDate = new Panel();
            textBox2 = new TextBox();
            labelStartDate = new Label();
            panelEndDate = new Panel();
            textBox3 = new TextBox();
            labelEndDate = new Label();
            panelPrice = new Panel();
            textBox4 = new TextBox();
            labelPrice = new Label();
            panelDescription = new Panel();
            textBox5 = new TextBox();
            labelDescription = new Label();
            panelTitle.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelStartTime.SuspendLayout();
            panelEndTime.SuspendLayout();
            panelStartDate.SuspendLayout();
            panelEndDate.SuspendLayout();
            panelPrice.SuspendLayout();
            panelDescription.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(labelTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Margin = new Padding(0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(800, 42);
            panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.FromArgb(224, 224, 224);
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Margin = new Padding(0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(800, 42);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Thêm giá sân mới";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 350);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panelDescription, 1, 2);
            tableLayoutPanel1.Controls.Add(panelPrice, 0, 2);
            tableLayoutPanel1.Controls.Add(panelEndDate, 1, 1);
            tableLayoutPanel1.Controls.Add(panelStartDate, 0, 1);
            tableLayoutPanel1.Controls.Add(panelEndTime, 1, 0);
            tableLayoutPanel1.Controls.Add(panelStartTime, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 42);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(15, 0, 15, 0);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(800, 308);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panelStartTime
            // 
            panelStartTime.Controls.Add(textBoxStartTime);
            panelStartTime.Controls.Add(labelStartTime);
            panelStartTime.Dock = DockStyle.Fill;
            panelStartTime.Location = new Point(15, 0);
            panelStartTime.Margin = new Padding(0, 0, 10, 0);
            panelStartTime.Name = "panelStartTime";
            panelStartTime.Size = new Size(375, 102);
            panelStartTime.TabIndex = 0;
            // 
            // labelStartTime
            // 
            labelStartTime.BackColor = Color.FromArgb(224, 224, 224);
            labelStartTime.Dock = DockStyle.Top;
            labelStartTime.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStartTime.Location = new Point(0, 0);
            labelStartTime.Margin = new Padding(0);
            labelStartTime.Name = "labelStartTime";
            labelStartTime.Size = new Size(375, 30);
            labelStartTime.TabIndex = 0;
            labelStartTime.Text = "StartTime";
            // 
            // textBoxStartTime
            // 
            textBoxStartTime.BackColor = SystemColors.HotTrack;
            textBoxStartTime.BorderStyle = BorderStyle.None;
            textBoxStartTime.Dock = DockStyle.Fill;
            textBoxStartTime.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxStartTime.Location = new Point(0, 30);
            textBoxStartTime.Margin = new Padding(0);
            textBoxStartTime.Name = "textBoxStartTime";
            textBoxStartTime.Size = new Size(375, 28);
            textBoxStartTime.TabIndex = 1;
            // 
            // panelEndTime
            // 
            panelEndTime.Controls.Add(textBox1);
            panelEndTime.Controls.Add(labelEndTime);
            panelEndTime.Location = new Point(410, 0);
            panelEndTime.Margin = new Padding(10, 0, 0, 0);
            panelEndTime.Name = "panelEndTime";
            panelEndTime.Size = new Size(375, 102);
            panelEndTime.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HotTrack;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(0, 30);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(375, 28);
            textBox1.TabIndex = 1;
            // 
            // labelEndTime
            // 
            labelEndTime.BackColor = Color.FromArgb(224, 224, 224);
            labelEndTime.Dock = DockStyle.Top;
            labelEndTime.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEndTime.Location = new Point(0, 0);
            labelEndTime.Margin = new Padding(0);
            labelEndTime.Name = "labelEndTime";
            labelEndTime.Size = new Size(375, 30);
            labelEndTime.TabIndex = 0;
            labelEndTime.Text = "EndTime";
            // 
            // panelStartDate
            // 
            panelStartDate.Controls.Add(textBox2);
            panelStartDate.Controls.Add(labelStartDate);
            panelStartDate.Dock = DockStyle.Fill;
            panelStartDate.Location = new Point(15, 102);
            panelStartDate.Margin = new Padding(0, 0, 10, 0);
            panelStartDate.Name = "panelStartDate";
            panelStartDate.Size = new Size(375, 102);
            panelStartDate.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.HotTrack;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(0, 30);
            textBox2.Margin = new Padding(0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(375, 28);
            textBox2.TabIndex = 1;
            // 
            // labelStartDate
            // 
            labelStartDate.BackColor = Color.FromArgb(224, 224, 224);
            labelStartDate.Dock = DockStyle.Top;
            labelStartDate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStartDate.Location = new Point(0, 0);
            labelStartDate.Margin = new Padding(0);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(375, 30);
            labelStartDate.TabIndex = 0;
            labelStartDate.Text = "StartDate";
            // 
            // panelEndDate
            // 
            panelEndDate.Controls.Add(textBox3);
            panelEndDate.Controls.Add(labelEndDate);
            panelEndDate.Location = new Point(410, 102);
            panelEndDate.Margin = new Padding(10, 0, 0, 0);
            panelEndDate.Name = "panelEndDate";
            panelEndDate.Size = new Size(375, 102);
            panelEndDate.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.HotTrack;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Dock = DockStyle.Fill;
            textBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(0, 30);
            textBox3.Margin = new Padding(0);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(375, 28);
            textBox3.TabIndex = 1;
            // 
            // labelEndDate
            // 
            labelEndDate.BackColor = Color.FromArgb(224, 224, 224);
            labelEndDate.Dock = DockStyle.Top;
            labelEndDate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEndDate.Location = new Point(0, 0);
            labelEndDate.Margin = new Padding(0);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(375, 30);
            labelEndDate.TabIndex = 0;
            labelEndDate.Text = "EndDate";
            // 
            // panelPrice
            // 
            panelPrice.Controls.Add(textBox4);
            panelPrice.Controls.Add(labelPrice);
            panelPrice.Dock = DockStyle.Fill;
            panelPrice.Location = new Point(15, 204);
            panelPrice.Margin = new Padding(0, 0, 10, 0);
            panelPrice.Name = "panelPrice";
            panelPrice.Size = new Size(375, 104);
            panelPrice.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.HotTrack;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Dock = DockStyle.Fill;
            textBox4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(0, 30);
            textBox4.Margin = new Padding(0);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(375, 28);
            textBox4.TabIndex = 1;
            // 
            // labelPrice
            // 
            labelPrice.BackColor = Color.FromArgb(224, 224, 224);
            labelPrice.Dock = DockStyle.Top;
            labelPrice.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrice.Location = new Point(0, 0);
            labelPrice.Margin = new Padding(0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(375, 30);
            labelPrice.TabIndex = 0;
            labelPrice.Text = "Price";
            // 
            // panelDescription
            // 
            panelDescription.Controls.Add(textBox5);
            panelDescription.Controls.Add(labelDescription);
            panelDescription.Dock = DockStyle.Fill;
            panelDescription.Location = new Point(410, 204);
            panelDescription.Margin = new Padding(10, 0, 0, 0);
            panelDescription.Name = "panelDescription";
            panelDescription.Size = new Size(375, 104);
            panelDescription.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.HotTrack;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Dock = DockStyle.Fill;
            textBox5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(0, 30);
            textBox5.Margin = new Padding(0);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(375, 28);
            textBox5.TabIndex = 1;
            // 
            // labelDescription
            // 
            labelDescription.BackColor = Color.FromArgb(224, 224, 224);
            labelDescription.Dock = DockStyle.Top;
            labelDescription.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescription.Location = new Point(0, 0);
            labelDescription.Margin = new Padding(0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(375, 30);
            labelDescription.TabIndex = 0;
            labelDescription.Text = "Description";
            // 
            // PriceRuleAddGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(panelTitle);
            Name = "PriceRuleAddGUI";
            Text = "PriceRuleAddGUI";
            panelTitle.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelStartTime.ResumeLayout(false);
            panelStartTime.PerformLayout();
            panelEndTime.ResumeLayout(false);
            panelEndTime.PerformLayout();
            panelStartDate.ResumeLayout(false);
            panelStartDate.PerformLayout();
            panelEndDate.ResumeLayout(false);
            panelEndDate.PerformLayout();
            panelPrice.ResumeLayout(false);
            panelPrice.PerformLayout();
            panelDescription.ResumeLayout(false);
            panelDescription.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitle;
        private Label labelTitle;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelStartTime;
        private Label labelStartTime;
        private TextBox textBoxStartTime;
        private Panel panelDescription;
        private TextBox textBox5;
        private Label labelDescription;
        private Panel panelPrice;
        private TextBox textBox4;
        private Label labelPrice;
        private Panel panelEndDate;
        private TextBox textBox3;
        private Label labelEndDate;
        private Panel panelStartDate;
        private TextBox textBox2;
        private Label labelStartDate;
        private Panel panelEndTime;
        private TextBox textBox1;
        private Label labelEndTime;
    }
}