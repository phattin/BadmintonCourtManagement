namespace GUI
{
    partial class AccountAddGUI
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
            panelEmployeeName = new Panel();
            comboBoxEmployeeName = new ComboBox();
            labelEmployeeName = new Label();
            panelPassword = new Panel();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            panelUsername = new Panel();
            textBoxUsername = new TextBox();
            labelUsername = new Label();
            panelPermission = new Panel();
            comboBoxPermission = new ComboBox();
            labelPermission = new Label();
            panel2 = new Panel();
            errorProvider1 = new ErrorProvider(components);
            panelTitle.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelEmployeeName.SuspendLayout();
            panelPassword.SuspendLayout();
            panelUsername.SuspendLayout();
            panelPermission.SuspendLayout();
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
            panelTitle.Size = new Size(348, 56);
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
            labelTitle.Size = new Size(348, 56);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Thêm tài khoản mới";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 309);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 20, 0, 0);
            panel1.Size = new Size(348, 59);
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
            tableLayoutPanel2.Location = new Point(0, 20);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(348, 39);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonAccept
            // 
            buttonAccept.BackColor = Color.FromArgb(0, 120, 103);
            buttonAccept.Dock = DockStyle.Fill;
            buttonAccept.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAccept.ForeColor = Color.White;
            buttonAccept.Location = new Point(50, 0);
            buttonAccept.Margin = new Padding(50, 0, 10, 0);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(114, 39);
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
            buttonCancel.Location = new Point(184, 0);
            buttonCancel.Margin = new Padding(10, 0, 50, 0);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(114, 39);
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
            tableLayoutPanel1.Controls.Add(panelEmployeeName, 0, 3);
            tableLayoutPanel1.Controls.Add(panelPassword, 0, 1);
            tableLayoutPanel1.Controls.Add(panelUsername, 0, 0);
            tableLayoutPanel1.Controls.Add(panelPermission, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20, 0, 17, 0);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(348, 253);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panelEmployeeName
            // 
            panelEmployeeName.Controls.Add(comboBoxEmployeeName);
            panelEmployeeName.Controls.Add(labelEmployeeName);
            panelEmployeeName.Dock = DockStyle.Fill;
            panelEmployeeName.Location = new Point(20, 189);
            panelEmployeeName.Margin = new Padding(0);
            panelEmployeeName.Name = "panelEmployeeName";
            panelEmployeeName.Size = new Size(311, 64);
            panelEmployeeName.TabIndex = 5;
            // 
            // comboBoxEmployeeName
            // 
            comboBoxEmployeeName.Dock = DockStyle.Fill;
            comboBoxEmployeeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxEmployeeName.FormattingEnabled = true;
            comboBoxEmployeeName.Location = new Point(0, 28);
            comboBoxEmployeeName.Name = "comboBoxEmployeeName";
            comboBoxEmployeeName.Size = new Size(311, 36);
            comboBoxEmployeeName.TabIndex = 3;
            // 
            // labelEmployeeName
            // 
            labelEmployeeName.AutoSize = true;
            labelEmployeeName.BackColor = SystemColors.Control;
            labelEmployeeName.Dock = DockStyle.Top;
            labelEmployeeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmployeeName.Location = new Point(0, 0);
            labelEmployeeName.Margin = new Padding(0);
            labelEmployeeName.Name = "labelEmployeeName";
            labelEmployeeName.Size = new Size(151, 28);
            labelEmployeeName.TabIndex = 2;
            labelEmployeeName.Text = "Chọn nhân viên:";
            labelEmployeeName.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelPassword
            // 
            panelPassword.Controls.Add(textBoxPassword);
            panelPassword.Controls.Add(labelPassword);
            panelPassword.Dock = DockStyle.Fill;
            panelPassword.Location = new Point(20, 63);
            panelPassword.Margin = new Padding(0);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(311, 63);
            panelPassword.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Dock = DockStyle.Fill;
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(0, 28);
            textBoxPassword.MaxLength = 255;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(311, 34);
            textBoxPassword.TabIndex = 1;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = SystemColors.Control;
            labelPassword.Dock = DockStyle.Top;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(0, 0);
            labelPassword.Margin = new Padding(0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(98, 28);
            labelPassword.TabIndex = 0;
            labelPassword.Text = "Mật khẩu:";
            labelPassword.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelUsername
            // 
            panelUsername.Controls.Add(textBoxUsername);
            panelUsername.Controls.Add(labelUsername);
            panelUsername.Dock = DockStyle.Fill;
            panelUsername.Location = new Point(20, 0);
            panelUsername.Margin = new Padding(0);
            panelUsername.Name = "panelUsername";
            panelUsername.Size = new Size(311, 63);
            panelUsername.TabIndex = 0;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Dock = DockStyle.Fill;
            textBoxUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.Location = new Point(0, 28);
            textBoxUsername.MaxLength = 50;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(311, 34);
            textBoxUsername.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = SystemColors.Control;
            labelUsername.Dock = DockStyle.Top;
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(0, 0);
            labelUsername.Margin = new Padding(0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(98, 28);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Tài khoản:";
            labelUsername.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelPermission
            // 
            panelPermission.Controls.Add(comboBoxPermission);
            panelPermission.Controls.Add(labelPermission);
            panelPermission.Dock = DockStyle.Fill;
            panelPermission.Location = new Point(20, 126);
            panelPermission.Margin = new Padding(0);
            panelPermission.Name = "panelPermission";
            panelPermission.Size = new Size(311, 63);
            panelPermission.TabIndex = 4;
            // 
            // comboBoxPermission
            // 
            comboBoxPermission.Dock = DockStyle.Fill;
            comboBoxPermission.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPermission.FormattingEnabled = true;
            comboBoxPermission.Location = new Point(0, 28);
            comboBoxPermission.Name = "comboBoxPermission";
            comboBoxPermission.Size = new Size(311, 36);
            comboBoxPermission.TabIndex = 3;
            // 
            // labelPermission
            // 
            labelPermission.AutoSize = true;
            labelPermission.BackColor = SystemColors.Control;
            labelPermission.Dock = DockStyle.Top;
            labelPermission.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPermission.Location = new Point(0, 0);
            labelPermission.Margin = new Padding(0);
            labelPermission.Name = "labelPermission";
            labelPermission.Size = new Size(110, 28);
            labelPermission.TabIndex = 2;
            labelPermission.Text = "Quyền hạn:";
            labelPermission.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.Coral;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 56);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(348, 253);
            panel2.TabIndex = 3;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AccountAddGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(348, 368);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AccountAddGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm";
            panelTitle.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelEmployeeName.ResumeLayout(false);
            panelEmployeeName.PerformLayout();
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            panelUsername.ResumeLayout(false);
            panelUsername.PerformLayout();
            panelPermission.ResumeLayout(false);
            panelPermission.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitle;
        private Label labelTitle;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelUsername;
        private Label labelStartTime;
        private Panel panelStartDate;
        private Label labelStartDate;
        private Panel panelPassword;
        private Label labelUsername;
        private Label labelPassword;
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
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private DateTimePicker dateTimePickerStartTime;
        private DateTimePicker dateTimePickerEndTime;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePickerEndDate;
        private DateTimePicker dateTimePickerStartDate;
        private ComboBox comboBoxEndType;
        private Panel panelPermission;
        private ComboBox comboBoxPermission;
        private Label labelPermission;
        private Panel panelEmployeeName;
        private ComboBox comboBoxEmployeeName;
        private Label labelEmployeeName;
    }
}