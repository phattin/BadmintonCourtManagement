namespace GUI
{
    partial class AccountModifyGUI
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
            panelTitle.Size = new Size(493, 56);
            panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.FromArgb(224, 224, 224);
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Margin = new Padding(0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(493, 56);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Sửa tài khoản";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 302);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 10, 0, 0);
            panel1.Size = new Size(493, 59);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonAccept, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonCancel, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 10);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(493, 49);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonAccept
            // 
            buttonAccept.Dock = DockStyle.Fill;
            buttonAccept.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAccept.Location = new Point(50, 0);
            buttonAccept.Margin = new Padding(50, 0, 10, 0);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(186, 49);
            buttonAccept.TabIndex = 1;
            buttonAccept.Text = "Xác nhận";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Dock = DockStyle.Fill;
            buttonCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCancel.Location = new Point(256, 0);
            buttonCancel.Margin = new Padding(10, 0, 50, 0);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(187, 49);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Hủy";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panelPassword, 0, 1);
            tableLayoutPanel1.Controls.Add(panelUsername, 0, 0);
            tableLayoutPanel1.Controls.Add(panelPermission, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20, 0, 17, 0);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(493, 246);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panelPassword
            // 
            panelPassword.Controls.Add(textBoxPassword);
            panelPassword.Controls.Add(labelPassword);
            panelPassword.Dock = DockStyle.Fill;
            panelPassword.Location = new Point(20, 82);
            panelPassword.Margin = new Padding(0);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(456, 82);
            panelPassword.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Dock = DockStyle.Fill;
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(0, 28);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(456, 34);
            textBoxPassword.TabIndex = 1;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.FromArgb(224, 224, 224);
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
            panelUsername.Size = new Size(456, 82);
            panelUsername.TabIndex = 0;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Dock = DockStyle.Fill;
            textBoxUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.Location = new Point(0, 28);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(456, 34);
            textBoxUsername.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.FromArgb(224, 224, 224);
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
            panelPermission.Location = new Point(20, 164);
            panelPermission.Margin = new Padding(0);
            panelPermission.Name = "panelPermission";
            panelPermission.Size = new Size(456, 82);
            panelPermission.TabIndex = 4;
            // 
            // comboBoxPermission
            // 
            comboBoxPermission.Dock = DockStyle.Fill;
            comboBoxPermission.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPermission.FormattingEnabled = true;
            comboBoxPermission.Location = new Point(0, 28);
            comboBoxPermission.Name = "comboBoxPermission";
            comboBoxPermission.Size = new Size(456, 36);
            comboBoxPermission.TabIndex = 3;
            // 
            // labelPermission
            // 
            labelPermission.AutoSize = true;
            labelPermission.BackColor = Color.FromArgb(224, 224, 224);
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
            panel2.Size = new Size(493, 246);
            panel2.TabIndex = 3;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AccountModifyGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(493, 361);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AccountModifyGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa";
            panelTitle.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
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
    }
}