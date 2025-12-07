
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
            components = new System.ComponentModel.Container();
            panelTitle = new Panel();
            labelTitle = new Label();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonAccept = new Button();
            buttonCancel = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelDes = new Panel();
            textBoxDes = new TextBox();
            labelDes = new Label();
            panelPrice = new Panel();
            numericUpDown1 = new NumericUpDown();
            labelPrice = new Label();
            panelEndType = new Panel();
            comboBoxEndType = new ComboBox();
            labelEndType = new Label();
            panelEndDate = new Panel();
            dateTimePickerEndDate = new DateTimePicker();
            labelEndDate = new Label();
            panelStartDate = new Panel();
            dateTimePickerStartDate = new DateTimePicker();
            labelStartDate = new Label();
            panelEndTime = new Panel();
            dateTimePickerEndTime = new DateTimePicker();
            labelEndTime = new Label();
            panelStartTime = new Panel();
            dateTimePickerStartTime = new DateTimePicker();
            labelStartTime = new Label();
            panel2 = new Panel();
            errorProvider1 = new ErrorProvider(components);
            panelTitle.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelDes.SuspendLayout();
            panelPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panelEndType.SuspendLayout();
            panelEndDate.SuspendLayout();
            panelStartDate.SuspendLayout();
            panelEndTime.SuspendLayout();
            panelStartTime.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(labelTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Margin = new Padding(0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(432, 56);
            panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = SystemColors.Control;
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Margin = new Padding(0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(432, 56);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Thêm giá sân mới";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 635);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 68);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.Control;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonAccept, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonCancel, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(432, 68);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonAccept
            // 
            buttonAccept.BackColor = Color.FromArgb(0, 120, 103);
            buttonAccept.Dock = DockStyle.Fill;
            buttonAccept.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAccept.ForeColor = Color.White;
            buttonAccept.Location = new Point(50, 0);
            buttonAccept.Margin = new Padding(50, 0, 50, 0);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(116, 68);
            buttonAccept.TabIndex = 1;
            buttonAccept.Text = "Xác nhận";
            buttonAccept.UseVisualStyleBackColor = false;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.IndianRed;
            buttonCancel.Dock = DockStyle.Fill;
            buttonCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(266, 0);
            buttonCancel.Margin = new Padding(50, 0, 50, 0);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(116, 68);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Hủy";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panelDes, 0, 6);
            tableLayoutPanel1.Controls.Add(panelPrice, 0, 5);
            tableLayoutPanel1.Controls.Add(panelEndType, 0, 4);
            tableLayoutPanel1.Controls.Add(panelEndDate, 0, 3);
            tableLayoutPanel1.Controls.Add(panelStartDate, 0, 2);
            tableLayoutPanel1.Controls.Add(panelEndTime, 0, 1);
            tableLayoutPanel1.Controls.Add(panelStartTime, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20, 0, 20, 20);
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857113F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.Size = new Size(432, 579);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panelDes
            // 
            panelDes.Controls.Add(textBoxDes);
            panelDes.Controls.Add(labelDes);
            panelDes.Dock = DockStyle.Fill;
            panelDes.Location = new Point(20, 474);
            panelDes.Margin = new Padding(0);
            panelDes.Name = "panelDes";
            panelDes.Size = new Size(392, 85);
            panelDes.TabIndex = 8;
            // 
            // textBoxDes
            // 
            textBoxDes.BackColor = Color.White;
            textBoxDes.BorderStyle = BorderStyle.None;
            textBoxDes.Dock = DockStyle.Fill;
            textBoxDes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDes.Location = new Point(0, 53);
            textBoxDes.Name = "textBoxDes";
            textBoxDes.Size = new Size(392, 27);
            textBoxDes.TabIndex = 1;
            // 
            // labelDes
            // 
            labelDes.BackColor = SystemColors.Control;
            labelDes.Dock = DockStyle.Top;
            labelDes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDes.Location = new Point(0, 0);
            labelDes.Margin = new Padding(0);
            labelDes.Name = "labelDes";
            labelDes.Size = new Size(392, 53);
            labelDes.TabIndex = 0;
            labelDes.Text = "Mô tả:";
            labelDes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelPrice
            // 
            panelPrice.Controls.Add(numericUpDown1);
            panelPrice.Controls.Add(labelPrice);
            panelPrice.Dock = DockStyle.Fill;
            panelPrice.Location = new Point(20, 395);
            panelPrice.Margin = new Padding(0);
            panelPrice.Name = "panelPrice";
            panelPrice.Size = new Size(392, 79);
            panelPrice.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Dock = DockStyle.Fill;
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(0, 48);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(392, 34);
            numericUpDown1.TabIndex = 1;
            // 
            // labelPrice
            // 
            labelPrice.BackColor = SystemColors.Control;
            labelPrice.Dock = DockStyle.Top;
            labelPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrice.Location = new Point(0, 0);
            labelPrice.Margin = new Padding(0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(392, 48);
            labelPrice.TabIndex = 0;
            labelPrice.Text = "Giá:";
            labelPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelEndType
            // 
            panelEndType.Controls.Add(comboBoxEndType);
            panelEndType.Controls.Add(labelEndType);
            panelEndType.Dock = DockStyle.Fill;
            panelEndType.Location = new Point(20, 316);
            panelEndType.Margin = new Padding(0);
            panelEndType.Name = "panelEndType";
            panelEndType.Size = new Size(392, 79);
            panelEndType.TabIndex = 6;
            // 
            // comboBoxEndType
            // 
            comboBoxEndType.Dock = DockStyle.Fill;
            comboBoxEndType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxEndType.FormattingEnabled = true;
            comboBoxEndType.Items.AddRange(new object[] { "Holiday", "Weekday", "Weekend" });
            comboBoxEndType.Location = new Point(0, 50);
            comboBoxEndType.Name = "comboBoxEndType";
            comboBoxEndType.Size = new Size(392, 36);
            comboBoxEndType.TabIndex = 1;
            // 
            // labelEndType
            // 
            labelEndType.BackColor = SystemColors.Control;
            labelEndType.Dock = DockStyle.Top;
            labelEndType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEndType.Location = new Point(0, 0);
            labelEndType.Margin = new Padding(0);
            labelEndType.Name = "labelEndType";
            labelEndType.Size = new Size(392, 50);
            labelEndType.TabIndex = 0;
            labelEndType.Text = "Thể loại:";
            labelEndType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelEndDate
            // 
            panelEndDate.Controls.Add(dateTimePickerEndDate);
            panelEndDate.Controls.Add(labelEndDate);
            panelEndDate.Dock = DockStyle.Fill;
            panelEndDate.Location = new Point(20, 237);
            panelEndDate.Margin = new Padding(0);
            panelEndDate.Name = "panelEndDate";
            panelEndDate.Size = new Size(392, 79);
            panelEndDate.TabIndex = 5;
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.CustomFormat = "dd/MM/yyyy";
            dateTimePickerEndDate.Dock = DockStyle.Fill;
            dateTimePickerEndDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerEndDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerEndDate.Location = new Point(0, 49);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.ShowCheckBox = true;
            dateTimePickerEndDate.Size = new Size(392, 34);
            dateTimePickerEndDate.TabIndex = 2;
            // 
            // labelEndDate
            // 
            labelEndDate.BackColor = SystemColors.Control;
            labelEndDate.Dock = DockStyle.Top;
            labelEndDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEndDate.Location = new Point(0, 0);
            labelEndDate.Margin = new Padding(0);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(392, 49);
            labelEndDate.TabIndex = 0;
            labelEndDate.Text = "Ngày kết thúc:";
            labelEndDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelStartDate
            // 
            panelStartDate.Controls.Add(dateTimePickerStartDate);
            panelStartDate.Controls.Add(labelStartDate);
            panelStartDate.Dock = DockStyle.Fill;
            panelStartDate.Location = new Point(20, 158);
            panelStartDate.Margin = new Padding(0);
            panelStartDate.Name = "panelStartDate";
            panelStartDate.Size = new Size(392, 79);
            panelStartDate.TabIndex = 4;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.CustomFormat = "dd/MM/yyyy";
            dateTimePickerStartDate.Dock = DockStyle.Fill;
            dateTimePickerStartDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerStartDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartDate.Location = new Point(0, 47);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.ShowCheckBox = true;
            dateTimePickerStartDate.Size = new Size(392, 34);
            dateTimePickerStartDate.TabIndex = 1;
            // 
            // labelStartDate
            // 
            labelStartDate.BackColor = SystemColors.Control;
            labelStartDate.Dock = DockStyle.Top;
            labelStartDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStartDate.Location = new Point(0, 0);
            labelStartDate.Margin = new Padding(0);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(392, 47);
            labelStartDate.TabIndex = 0;
            labelStartDate.Text = "Ngày bắt đầu:";
            labelStartDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelEndTime
            // 
            panelEndTime.Controls.Add(dateTimePickerEndTime);
            panelEndTime.Controls.Add(labelEndTime);
            panelEndTime.Dock = DockStyle.Fill;
            panelEndTime.Location = new Point(20, 79);
            panelEndTime.Margin = new Padding(0);
            panelEndTime.Name = "panelEndTime";
            panelEndTime.Size = new Size(392, 79);
            panelEndTime.TabIndex = 3;
            // 
            // dateTimePickerEndTime
            // 
            dateTimePickerEndTime.CustomFormat = "HH:mm:ss";
            dateTimePickerEndTime.Dock = DockStyle.Fill;
            dateTimePickerEndTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerEndTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerEndTime.Location = new Point(0, 46);
            dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            dateTimePickerEndTime.ShowUpDown = true;
            dateTimePickerEndTime.Size = new Size(392, 34);
            dateTimePickerEndTime.TabIndex = 1;
            // 
            // labelEndTime
            // 
            labelEndTime.BackColor = SystemColors.Control;
            labelEndTime.Dock = DockStyle.Top;
            labelEndTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEndTime.Location = new Point(0, 0);
            labelEndTime.Margin = new Padding(0);
            labelEndTime.Name = "labelEndTime";
            labelEndTime.Size = new Size(392, 46);
            labelEndTime.TabIndex = 0;
            labelEndTime.Text = "Giờ kết thúc:";
            labelEndTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelStartTime
            // 
            panelStartTime.Controls.Add(dateTimePickerStartTime);
            panelStartTime.Controls.Add(labelStartTime);
            panelStartTime.Dock = DockStyle.Fill;
            panelStartTime.Location = new Point(20, 0);
            panelStartTime.Margin = new Padding(0);
            panelStartTime.Name = "panelStartTime";
            panelStartTime.Size = new Size(392, 79);
            panelStartTime.TabIndex = 0;
            // 
            // dateTimePickerStartTime
            // 
            dateTimePickerStartTime.CustomFormat = "HH:mm:ss";
            dateTimePickerStartTime.Dock = DockStyle.Fill;
            dateTimePickerStartTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerStartTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartTime.Location = new Point(0, 46);
            dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            dateTimePickerStartTime.ShowUpDown = true;
            dateTimePickerStartTime.Size = new Size(392, 34);
            dateTimePickerStartTime.TabIndex = 1;
            // 
            // labelStartTime
            // 
            labelStartTime.BackColor = SystemColors.Control;
            labelStartTime.Dock = DockStyle.Top;
            labelStartTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStartTime.Location = new Point(0, 0);
            labelStartTime.Margin = new Padding(0);
            labelStartTime.Name = "labelStartTime";
            labelStartTime.Size = new Size(392, 46);
            labelStartTime.TabIndex = 0;
            labelStartTime.Text = "Giờ bắt đầu:";
            labelStartTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.Coral;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 579);
            panel2.TabIndex = 3;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // PriceRuleAddGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(432, 703);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PriceRuleAddGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm";
            panelTitle.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelDes.ResumeLayout(false);
            panelDes.PerformLayout();
            panelPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panelEndType.ResumeLayout(false);
            panelEndDate.ResumeLayout(false);
            panelStartDate.ResumeLayout(false);
            panelEndTime.ResumeLayout(false);
            panelStartTime.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitle;
        private Label labelTitle;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelStartTime;
        private Label labelStartTime;
        private Panel panelStartDate;
        private Label labelStartDate;
        private Panel panelEndTime;
        private Label labelEndTime;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonCancel;
        private Button buttonAccept;
        private Panel panelPrice;
        private Label labelPrice;
        private Panel panelEndType;
        private Label labelEndType;
        private Panel panelEndDate;
        private Label labelEndDate;
        private Panel panelDes;
        private TextBox textBoxDes;
        private Label labelDes;
        private ErrorProvider errorProvider1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePickerStartTime;
        private DateTimePicker dateTimePickerEndTime;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePickerEndDate;
        private DateTimePicker dateTimePickerStartDate;
        private ComboBox comboBoxEndType;
    }
}