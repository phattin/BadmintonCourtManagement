namespace BadmintonCourtManagement.GUI
{
    partial class EmployeeGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeGUI));
            titlePanel = new TableLayoutPanel();
            title = new Label();
            add = new Button();
            toolBar = new TableLayoutPanel();
            reset = new Button();
            endDate = new DateTimePicker();
            endLabel = new Label();
            searchBar = new TextBox();
            startDate = new DateTimePicker();
            startLabel = new Label();
            filter = new Button();
            cardList = new TableLayoutPanel();
            pagination = new Panel();
            extraNext = new Button();
            extraPrevious = new Button();
            next = new Button();
            previous = new Button();
            titlePanel.SuspendLayout();
            toolBar.SuspendLayout();
            pagination.SuspendLayout();
            SuspendLayout();
            // 
            // titlePanel
            // 
            titlePanel.ColumnCount = 2;
            titlePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            titlePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            titlePanel.Controls.Add(title, 0, 0);
            titlePanel.Controls.Add(add, 1, 0);
            titlePanel.Dock = DockStyle.Top;
            titlePanel.Location = new Point(0, 0);
            titlePanel.Margin = new Padding(0);
            titlePanel.Name = "titlePanel";
            titlePanel.RowCount = 1;
            titlePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            titlePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            titlePanel.Size = new Size(1199, 54);
            titlePanel.TabIndex = 6;
            // 
            // title
            // 
            title.Dock = DockStyle.Fill;
            title.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            title.Location = new Point(0, 0);
            title.Margin = new Padding(0);
            title.Name = "title";
            title.Size = new Size(599, 54);
            title.TabIndex = 3;
            title.Text = "Nhân viên";
            title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // add
            // 
            add.AutoSize = true;
            add.BackColor = Color.Black;
            add.Cursor = Cursors.Hand;
            add.Dock = DockStyle.Right;
            add.ForeColor = Color.White;
            add.Location = new Point(1099, 0);
            add.Margin = new Padding(0, 0, 10, 0);
            add.Name = "add";
            add.Size = new Size(90, 54);
            add.TabIndex = 4;
            add.Text = "+ Thêm";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            add.MouseEnter += buttonEnter;
            add.MouseLeave += buttonLeave;
            // 
            // toolBar
            // 
            toolBar.BackColor = Color.FromArgb(0, 120, 103);
            toolBar.ColumnCount = 7;
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.5029163F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.8008471F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.0972042F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.0855179F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.59355F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.521287F));
            toolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.398679F));
            toolBar.Controls.Add(reset, 6, 0);
            toolBar.Controls.Add(endDate, 4, 0);
            toolBar.Controls.Add(endLabel, 3, 0);
            toolBar.Controls.Add(searchBar, 0, 0);
            toolBar.Controls.Add(startDate, 2, 0);
            toolBar.Controls.Add(startLabel, 1, 0);
            toolBar.Controls.Add(filter, 5, 0);
            toolBar.Dock = DockStyle.Top;
            toolBar.Font = new Font("Segoe UI", 9F);
            toolBar.Location = new Point(0, 54);
            toolBar.Margin = new Padding(0);
            toolBar.Name = "toolBar";
            toolBar.Padding = new Padding(8);
            toolBar.RowCount = 1;
            toolBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            toolBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            toolBar.Size = new Size(1199, 88);
            toolBar.TabIndex = 7;
            // 
            // reset
            // 
            reset.BackColor = Color.FromArgb(0, 120, 103);
            reset.Cursor = Cursors.Hand;
            reset.Dock = DockStyle.Fill;
            reset.FlatAppearance.BorderSize = 0;
            reset.FlatStyle = FlatStyle.Flat;
            reset.Image = Properties.Resources.Reset;
            reset.Location = new Point(1088, 8);
            reset.Margin = new Padding(0);
            reset.Name = "reset";
            reset.Size = new Size(103, 72);
            reset.TabIndex = 5;
            reset.UseVisualStyleBackColor = false;
            reset.MouseEnter += filterButton_MouseEnter;
            reset.MouseLeave += filterButton_MouseLeave;
            // 
            // endDate
            // 
            endDate.Cursor = Cursors.Hand;
            endDate.CustomFormat = "dd/MM/yyyy";
            endDate.Dock = DockStyle.Fill;
            endDate.DropDownAlign = LeftRightAlignment.Right;
            endDate.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            endDate.Format = DateTimePickerFormat.Custom;
            endDate.Location = new Point(792, 23);
            endDate.Margin = new Padding(0, 15, 8, 0);
            endDate.Name = "endDate";
            endDate.ShowUpDown = true;
            endDate.Size = new Size(188, 39);
            endDate.TabIndex = 3;
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.Dock = DockStyle.Fill;
            endLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            endLabel.ForeColor = Color.White;
            endLabel.Location = new Point(646, 8);
            endLabel.Margin = new Padding(8, 0, 0, 0);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(146, 72);
            endLabel.TabIndex = 3;
            endLabel.Text = "Ngày kết thúc:";
            endLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // searchBar
            // 
            searchBar.Cursor = Cursors.IBeam;
            searchBar.Dock = DockStyle.Fill;
            searchBar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            searchBar.Location = new Point(8, 23);
            searchBar.Margin = new Padding(0, 15, 8, 0);
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = "Tìm kiếm...";
            searchBar.Size = new Size(281, 39);
            searchBar.TabIndex = 1;
            // 
            // startDate
            // 
            startDate.Cursor = Cursors.Hand;
            startDate.CustomFormat = "dd/MM/yyyy";
            startDate.Dock = DockStyle.Fill;
            startDate.DropDownAlign = LeftRightAlignment.Right;
            startDate.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            startDate.Format = DateTimePickerFormat.Custom;
            startDate.Location = new Point(448, 23);
            startDate.Margin = new Padding(0, 15, 8, 0);
            startDate.MaxDate = new DateTime(9998, 10, 1, 0, 0, 0, 0);
            startDate.Name = "startDate";
            startDate.ShowUpDown = true;
            startDate.Size = new Size(182, 39);
            startDate.TabIndex = 2;
            startDate.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Dock = DockStyle.Fill;
            startLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            startLabel.ForeColor = Color.White;
            startLabel.Location = new Point(297, 8);
            startLabel.Margin = new Padding(0);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(151, 72);
            startLabel.TabIndex = 2;
            startLabel.Text = "Ngày bắt đầu:";
            startLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // filter
            // 
            filter.BackColor = Color.FromArgb(0, 120, 103);
            filter.Cursor = Cursors.Hand;
            filter.Dock = DockStyle.Fill;
            filter.FlatAppearance.BorderSize = 0;
            filter.FlatStyle = FlatStyle.Flat;
            filter.Image = Properties.Resources.Filter;
            filter.Location = new Point(988, 8);
            filter.Margin = new Padding(0);
            filter.Name = "filter";
            filter.Size = new Size(100, 72);
            filter.TabIndex = 4;
            filter.UseVisualStyleBackColor = false;
            filter.MouseEnter += filterButton_MouseEnter;
            filter.MouseLeave += filterButton_MouseLeave;
            // 
            // cardList
            // 
            cardList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cardList.AutoScroll = true;
            cardList.BackColor = Color.FromArgb(239, 248, 230);
            cardList.ColumnCount = 4;
            cardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            cardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            cardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            cardList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            cardList.Font = new Font("Segoe UI", 11F);
            cardList.Location = new Point(4, 142);
            cardList.Margin = new Padding(0);
            cardList.Name = "cardList";
            cardList.RowCount = 2;
            cardList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            cardList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            cardList.Size = new Size(1195, 580);
            cardList.TabIndex = 8;
            // 
            // pagination
            // 
            pagination.Controls.Add(extraNext);
            pagination.Controls.Add(extraPrevious);
            pagination.Controls.Add(next);
            pagination.Controls.Add(previous);
            pagination.Dock = DockStyle.Bottom;
            pagination.Location = new Point(0, 722);
            pagination.Margin = new Padding(0);
            pagination.Name = "pagination";
            pagination.Size = new Size(1199, 81);
            pagination.TabIndex = 9;
            // 
            // extraNext
            // 
            extraNext.Anchor = AnchorStyles.None;
            extraNext.BackColor = Color.Transparent;
            extraNext.Cursor = Cursors.Hand;
            extraNext.FlatAppearance.BorderSize = 0;
            extraNext.FlatStyle = FlatStyle.Flat;
            extraNext.Image = (Image)resources.GetObject("extraNext.Image");
            extraNext.Location = new Point(696, 12);
            extraNext.Margin = new Padding(2);
            extraNext.Name = "extraNext";
            extraNext.Size = new Size(60, 58);
            extraNext.TabIndex = 16;
            extraNext.TextImageRelation = TextImageRelation.ImageAboveText;
            extraNext.UseVisualStyleBackColor = false;
            // 
            // extraPrevious
            // 
            extraPrevious.Anchor = AnchorStyles.None;
            extraPrevious.BackColor = Color.Transparent;
            extraPrevious.Cursor = Cursors.Hand;
            extraPrevious.FlatAppearance.BorderSize = 0;
            extraPrevious.FlatStyle = FlatStyle.Flat;
            extraPrevious.ForeColor = Color.Transparent;
            extraPrevious.Image = (Image)resources.GetObject("extraPrevious.Image");
            extraPrevious.Location = new Point(441, 12);
            extraPrevious.Margin = new Padding(0);
            extraPrevious.Name = "extraPrevious";
            extraPrevious.Size = new Size(60, 58);
            extraPrevious.TabIndex = 13;
            extraPrevious.TextImageRelation = TextImageRelation.ImageAboveText;
            extraPrevious.UseVisualStyleBackColor = false;
            // 
            // next
            // 
            next.Anchor = AnchorStyles.None;
            next.BackColor = Color.Transparent;
            next.Cursor = Cursors.Hand;
            next.FlatAppearance.BorderSize = 0;
            next.FlatStyle = FlatStyle.Flat;
            next.Image = (Image)resources.GetObject("next.Image");
            next.Location = new Point(611, 12);
            next.Margin = new Padding(2);
            next.Name = "next";
            next.Size = new Size(60, 58);
            next.TabIndex = 15;
            next.TextImageRelation = TextImageRelation.ImageAboveText;
            next.UseVisualStyleBackColor = false;
            // 
            // previous
            // 
            previous.Anchor = AnchorStyles.None;
            previous.BackColor = Color.Transparent;
            previous.Cursor = Cursors.Hand;
            previous.FlatAppearance.BorderSize = 0;
            previous.FlatStyle = FlatStyle.Flat;
            previous.Image = (Image)resources.GetObject("previous.Image");
            previous.Location = new Point(526, 12);
            previous.Margin = new Padding(2);
            previous.Name = "previous";
            previous.Size = new Size(60, 58);
            previous.TabIndex = 14;
            previous.TextImageRelation = TextImageRelation.ImageAboveText;
            previous.UseVisualStyleBackColor = false;
            // 
            // EmployeeGUI
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(pagination);
            Controls.Add(cardList);
            Controls.Add(toolBar);
            Controls.Add(titlePanel);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(0);
            Name = "EmployeeGUI";
            Size = new Size(1199, 803);
            Load += storageGUI_Load;
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            toolBar.ResumeLayout(false);
            toolBar.PerformLayout();
            pagination.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel titlePanel;
        private Label title;
        private Button add;
        private TableLayoutPanel toolBar;
        private Button reset;
        private DateTimePicker endDate;
        private Label endLabel;
        private TextBox searchBar;
        private DateTimePicker startDate;
        private Label startLabel;
        private Button filter;
        private TableLayoutPanel cardList;
        private Panel pagination;
        private Button extraNext;
        private Button extraPrevious;
        private Button next;
        private Button previous;
    }
}