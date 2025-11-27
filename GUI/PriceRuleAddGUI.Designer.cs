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
            buttonCancel = new Button();
            buttonAccept = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelDes = new Panel();
            textBoxDes = new TextBox();
            labelDes = new Label();
            panelPrice = new Panel();
            textBoxPrice = new TextBox();
            labelPrice = new Label();
            panelEndType = new Panel();
            textBoxEndType = new TextBox();
            labelEndType = new Label();
            panelEndDate = new Panel();
            textBoxEndDate = new TextBox();
            labelEndDate = new Label();
            panelStartDate = new Panel();
            textBoxStartDate = new TextBox();
            labelStartDate = new Label();
            panelEndTime = new Panel();
            textBoxEndTime = new TextBox();
            labelEndTime = new Label();
            panelStartTime = new Panel();
            textBoxStartTime = new TextBox();
            labelStartTime = new Label();
            panel2 = new Panel();
            errorProvider1 = new ErrorProvider(components);
            panelTitle.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelDes.SuspendLayout();
            panelPrice.SuspendLayout();
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
            panelTitle.Size = new Size(980, 56);
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
            labelTitle.Size = new Size(980, 56);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Thêm giá sân mới";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 634);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 68);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonCancel, 1, 0);
            tableLayoutPanel2.Controls.Add(buttonAccept, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(980, 68);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.Dock = DockStyle.Fill;
            buttonCancel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCancel.Location = new Point(540, 0);
            buttonCancel.Margin = new Padding(50, 0, 250, 0);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(190, 68);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Hủy";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAccept
            // 
            buttonAccept.Dock = DockStyle.Fill;
            buttonAccept.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAccept.Location = new Point(250, 0);
            buttonAccept.Margin = new Padding(250, 0, 50, 0);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(190, 68);
            buttonAccept.TabIndex = 1;
            buttonAccept.Text = "Xác nhận";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.BackColor = Color.FromArgb(224, 224, 224);
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
            tableLayoutPanel1.Padding = new Padding(17, 0, 17, 0);
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857113F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.Size = new Size(980, 578);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panelDes
            // 
            panelDes.Controls.Add(textBoxDes);
            panelDes.Controls.Add(labelDes);
            panelDes.Dock = DockStyle.Fill;
            panelDes.Location = new Point(17, 492);
            panelDes.Margin = new Padding(0, 0, 11, 0);
            panelDes.Name = "panelDes";
            panelDes.Size = new Size(935, 86);
            panelDes.TabIndex = 8;
            // 
            // textBoxDes
            // 
            textBoxDes.BackColor = SystemColors.HotTrack;
            textBoxDes.BorderStyle = BorderStyle.None;
            textBoxDes.Dock = DockStyle.Fill;
            textBoxDes.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDes.Location = new Point(0, 53);
            textBoxDes.Margin = new Padding(0);
            textBoxDes.Name = "textBoxDes";
            textBoxDes.Size = new Size(935, 35);
            textBoxDes.TabIndex = 1;
            // 
            // labelDes
            // 
            labelDes.BackColor = Color.FromArgb(224, 224, 224);
            labelDes.Dock = DockStyle.Top;
            labelDes.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDes.Location = new Point(0, 0);
            labelDes.Margin = new Padding(0);
            labelDes.Name = "labelDes";
            labelDes.Size = new Size(935, 53);
            labelDes.TabIndex = 0;
            labelDes.Text = "Description";
            // 
            // panelPrice
            // 
            panelPrice.Controls.Add(textBoxPrice);
            panelPrice.Controls.Add(labelPrice);
            panelPrice.Dock = DockStyle.Fill;
            panelPrice.Location = new Point(17, 410);
            panelPrice.Margin = new Padding(0, 0, 11, 0);
            panelPrice.Name = "panelPrice";
            panelPrice.Size = new Size(935, 82);
            panelPrice.TabIndex = 7;
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = SystemColors.HotTrack;
            textBoxPrice.BorderStyle = BorderStyle.None;
            textBoxPrice.Dock = DockStyle.Fill;
            textBoxPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPrice.Location = new Point(0, 48);
            textBoxPrice.Margin = new Padding(0);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(935, 35);
            textBoxPrice.TabIndex = 1;
            // 
            // labelPrice
            // 
            labelPrice.BackColor = Color.FromArgb(224, 224, 224);
            labelPrice.Dock = DockStyle.Top;
            labelPrice.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrice.Location = new Point(0, 0);
            labelPrice.Margin = new Padding(0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(935, 48);
            labelPrice.TabIndex = 0;
            labelPrice.Text = "Price";
            // 
            // panelEndType
            // 
            panelEndType.Controls.Add(textBoxEndType);
            panelEndType.Controls.Add(labelEndType);
            panelEndType.Dock = DockStyle.Fill;
            panelEndType.Location = new Point(17, 328);
            panelEndType.Margin = new Padding(0, 0, 11, 0);
            panelEndType.Name = "panelEndType";
            panelEndType.Size = new Size(935, 82);
            panelEndType.TabIndex = 6;
            // 
            // textBoxEndType
            // 
            textBoxEndType.BackColor = SystemColors.HotTrack;
            textBoxEndType.BorderStyle = BorderStyle.None;
            textBoxEndType.Dock = DockStyle.Fill;
            textBoxEndType.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEndType.Location = new Point(0, 50);
            textBoxEndType.Margin = new Padding(0);
            textBoxEndType.Name = "textBoxEndType";
            textBoxEndType.Size = new Size(935, 35);
            textBoxEndType.TabIndex = 1;
            // 
            // labelEndType
            // 
            labelEndType.BackColor = Color.FromArgb(224, 224, 224);
            labelEndType.Dock = DockStyle.Top;
            labelEndType.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEndType.Location = new Point(0, 0);
            labelEndType.Margin = new Padding(0);
            labelEndType.Name = "labelEndType";
            labelEndType.Size = new Size(935, 50);
            labelEndType.TabIndex = 0;
            labelEndType.Text = "EndType";
            // 
            // panelEndDate
            // 
            panelEndDate.Controls.Add(textBoxEndDate);
            panelEndDate.Controls.Add(labelEndDate);
            panelEndDate.Dock = DockStyle.Fill;
            panelEndDate.Location = new Point(17, 246);
            panelEndDate.Margin = new Padding(0, 0, 11, 0);
            panelEndDate.Name = "panelEndDate";
            panelEndDate.Size = new Size(935, 82);
            panelEndDate.TabIndex = 5;
            // 
            // textBoxEndDate
            // 
            textBoxEndDate.BackColor = SystemColors.HotTrack;
            textBoxEndDate.BorderStyle = BorderStyle.None;
            textBoxEndDate.Dock = DockStyle.Fill;
            textBoxEndDate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEndDate.Location = new Point(0, 49);
            textBoxEndDate.Margin = new Padding(0);
            textBoxEndDate.Name = "textBoxEndDate";
            textBoxEndDate.Size = new Size(935, 35);
            textBoxEndDate.TabIndex = 1;
            // 
            // labelEndDate
            // 
            labelEndDate.BackColor = Color.FromArgb(224, 224, 224);
            labelEndDate.Dock = DockStyle.Top;
            labelEndDate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEndDate.Location = new Point(0, 0);
            labelEndDate.Margin = new Padding(0);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(935, 49);
            labelEndDate.TabIndex = 0;
            labelEndDate.Text = "EndDate";
            // 
            // panelStartDate
            // 
            panelStartDate.Controls.Add(textBoxStartDate);
            panelStartDate.Controls.Add(labelStartDate);
            panelStartDate.Dock = DockStyle.Fill;
            panelStartDate.Location = new Point(17, 164);
            panelStartDate.Margin = new Padding(0, 0, 11, 0);
            panelStartDate.Name = "panelStartDate";
            panelStartDate.Size = new Size(935, 82);
            panelStartDate.TabIndex = 4;
            // 
            // textBoxStartDate
            // 
            textBoxStartDate.BackColor = SystemColors.HotTrack;
            textBoxStartDate.BorderStyle = BorderStyle.None;
            textBoxStartDate.Dock = DockStyle.Fill;
            textBoxStartDate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxStartDate.Location = new Point(0, 47);
            textBoxStartDate.Margin = new Padding(0);
            textBoxStartDate.Name = "textBoxStartDate";
            textBoxStartDate.Size = new Size(935, 35);
            textBoxStartDate.TabIndex = 1;
            // 
            // labelStartDate
            // 
            labelStartDate.BackColor = Color.FromArgb(224, 224, 224);
            labelStartDate.Dock = DockStyle.Top;
            labelStartDate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStartDate.Location = new Point(0, 0);
            labelStartDate.Margin = new Padding(0);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(935, 47);
            labelStartDate.TabIndex = 0;
            labelStartDate.Text = "StartDate";
            // 
            // panelEndTime
            // 
            panelEndTime.Controls.Add(textBoxEndTime);
            panelEndTime.Controls.Add(labelEndTime);
            panelEndTime.Dock = DockStyle.Fill;
            panelEndTime.Location = new Point(17, 82);
            panelEndTime.Margin = new Padding(0, 0, 11, 0);
            panelEndTime.Name = "panelEndTime";
            panelEndTime.Size = new Size(935, 82);
            panelEndTime.TabIndex = 3;
            // 
            // textBoxEndTime
            // 
            textBoxEndTime.BackColor = SystemColors.HotTrack;
            textBoxEndTime.BorderStyle = BorderStyle.None;
            textBoxEndTime.Dock = DockStyle.Fill;
            textBoxEndTime.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEndTime.Location = new Point(0, 46);
            textBoxEndTime.Margin = new Padding(0);
            textBoxEndTime.Name = "textBoxEndTime";
            textBoxEndTime.Size = new Size(935, 35);
            textBoxEndTime.TabIndex = 1;
            // 
            // labelEndTime
            // 
            labelEndTime.BackColor = Color.FromArgb(224, 224, 224);
            labelEndTime.Dock = DockStyle.Top;
            labelEndTime.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEndTime.Location = new Point(0, 0);
            labelEndTime.Margin = new Padding(0);
            labelEndTime.Name = "labelEndTime";
            labelEndTime.Size = new Size(935, 46);
            labelEndTime.TabIndex = 0;
            labelEndTime.Text = "EndTime";
            // 
            // panelStartTime
            // 
            panelStartTime.Controls.Add(textBoxStartTime);
            panelStartTime.Controls.Add(labelStartTime);
            panelStartTime.Dock = DockStyle.Fill;
            panelStartTime.Location = new Point(17, 0);
            panelStartTime.Margin = new Padding(0, 0, 11, 0);
            panelStartTime.Name = "panelStartTime";
            panelStartTime.Size = new Size(935, 82);
            panelStartTime.TabIndex = 0;
            // 
            // textBoxStartTime
            // 
            textBoxStartTime.BackColor = SystemColors.HotTrack;
            textBoxStartTime.BorderStyle = BorderStyle.None;
            textBoxStartTime.Dock = DockStyle.Fill;
            textBoxStartTime.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxStartTime.Location = new Point(0, 46);
            textBoxStartTime.Margin = new Padding(0);
            textBoxStartTime.Name = "textBoxStartTime";
            textBoxStartTime.Size = new Size(935, 35);
            textBoxStartTime.TabIndex = 2;
            // 
            // labelStartTime
            // 
            labelStartTime.BackColor = Color.FromArgb(224, 224, 224);
            labelStartTime.Dock = DockStyle.Top;
            labelStartTime.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStartTime.Location = new Point(0, 0);
            labelStartTime.Margin = new Padding(0);
            labelStartTime.Name = "labelStartTime";
            labelStartTime.Size = new Size(935, 46);
            labelStartTime.TabIndex = 0;
            labelStartTime.Text = "StartTime";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.Coral;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 578);
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
            ClientSize = new Size(980, 702);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PriceRuleAddGUI";
            Text = "PriceRuleAddGUI";
            panelTitle.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelDes.ResumeLayout(false);
            panelDes.PerformLayout();
            panelPrice.ResumeLayout(false);
            panelPrice.PerformLayout();
            panelEndType.ResumeLayout(false);
            panelEndType.PerformLayout();
            panelEndDate.ResumeLayout(false);
            panelEndDate.PerformLayout();
            panelStartDate.ResumeLayout(false);
            panelStartDate.PerformLayout();
            panelEndTime.ResumeLayout(false);
            panelEndTime.PerformLayout();
            panelStartTime.ResumeLayout(false);
            panelStartTime.PerformLayout();
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
        private TextBox textBoxStartDate;
        private Label labelStartDate;
        private Panel panelEndTime;
        private Label labelEndTime;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonCancel;
        private Button buttonAccept;
        private Panel panelPrice;
        private TextBox textBoxPrice;
        private Label labelPrice;
        private Panel panelEndType;
        private TextBox textBoxEndType;
        private Label labelEndType;
        private Panel panelEndDate;
        private TextBox textBoxEndDate;
        private Label labelEndDate;
        private Panel panelDes;
        private TextBox textBoxDes;
        private Label labelDes;
        private TextBox textBoxEndTime;
        private TextBox textBoxStartTime;
        private ErrorProvider errorProvider1;
    }
}