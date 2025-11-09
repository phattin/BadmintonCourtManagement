namespace GUI
{
    partial class EmployeeAddGUI
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
            mainPanel = new Panel();
            bodyPanel = new TableLayoutPanel();
            infoPanel = new TableLayoutPanel();
            usernameInput = new TextBox();
            addressInput = new TextBox();
            cccdInput = new TextBox();
            phoneInput = new TextBox();
            username = new Label();
            address = new Label();
            cccd = new Label();
            phone = new Label();
            role = new Label();
            name = new Label();
            nameInput = new TextBox();
            roleCombo = new ComboBox();
            picturePanel = new TableLayoutPanel();
            pictureSetting = new TableLayoutPanel();
            browse = new Button();
            picture = new PictureBox();
            TitlePanel = new Panel();
            TitleText = new Label();
            mainPanel.SuspendLayout();
            bodyPanel.SuspendLayout();
            infoPanel.SuspendLayout();
            picturePanel.SuspendLayout();
            pictureSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            TitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(239, 248, 230);
            mainPanel.Controls.Add(bodyPanel);
            mainPanel.Controls.Add(TitlePanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(35, 39);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(20);
            mainPanel.Size = new Size(976, 493);
            mainPanel.TabIndex = 1;
            // 
            // bodyPanel
            // 
            bodyPanel.AutoScroll = true;
            bodyPanel.BackColor = Color.FromArgb(200, 250, 214);
            bodyPanel.ColumnCount = 2;
            bodyPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.23899F));
            bodyPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.7610054F));
            bodyPanel.Controls.Add(infoPanel, 0, 0);
            bodyPanel.Controls.Add(picturePanel, 1, 0);
            bodyPanel.Dock = DockStyle.Fill;
            bodyPanel.Location = new Point(20, 103);
            bodyPanel.Margin = new Padding(0);
            bodyPanel.Name = "bodyPanel";
            bodyPanel.Padding = new Padding(20);
            bodyPanel.RowCount = 1;
            bodyPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            bodyPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            bodyPanel.Size = new Size(936, 370);
            bodyPanel.TabIndex = 2;
            // 
            // infoPanel
            // 
            infoPanel.ColumnCount = 2;
            infoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.695652F));
            infoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.30435F));
            infoPanel.Controls.Add(usernameInput, 1, 5);
            infoPanel.Controls.Add(addressInput, 1, 4);
            infoPanel.Controls.Add(cccdInput, 1, 3);
            infoPanel.Controls.Add(phoneInput, 1, 2);
            infoPanel.Controls.Add(username, 0, 5);
            infoPanel.Controls.Add(address, 0, 4);
            infoPanel.Controls.Add(cccd, 0, 3);
            infoPanel.Controls.Add(phone, 0, 2);
            infoPanel.Controls.Add(role, 0, 1);
            infoPanel.Controls.Add(name, 0, 0);
            infoPanel.Controls.Add(nameInput, 1, 0);
            infoPanel.Controls.Add(roleCombo, 1, 1);
            infoPanel.Dock = DockStyle.Fill;
            infoPanel.Location = new Point(23, 23);
            infoPanel.Name = "infoPanel";
            infoPanel.RowCount = 6;
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            infoPanel.Size = new Size(605, 324);
            infoPanel.TabIndex = 0;
            // 
            // usernameInput
            // 
            usernameInput.Dock = DockStyle.Fill;
            usernameInput.Location = new Point(203, 280);
            usernameInput.Margin = new Padding(0, 10, 10, 0);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(392, 39);
            usernameInput.TabIndex = 12;
            // 
            // addressInput
            // 
            addressInput.Dock = DockStyle.Fill;
            addressInput.Location = new Point(203, 226);
            addressInput.Margin = new Padding(0, 10, 10, 0);
            addressInput.Name = "addressInput";
            addressInput.Size = new Size(392, 39);
            addressInput.TabIndex = 11;
            // 
            // cccdInput
            // 
            cccdInput.Dock = DockStyle.Fill;
            cccdInput.Location = new Point(203, 172);
            cccdInput.Margin = new Padding(0, 10, 10, 0);
            cccdInput.Name = "cccdInput";
            cccdInput.Size = new Size(392, 39);
            cccdInput.TabIndex = 10;
            // 
            // phoneInput
            // 
            phoneInput.Dock = DockStyle.Fill;
            phoneInput.Location = new Point(203, 118);
            phoneInput.Margin = new Padding(0, 10, 10, 0);
            phoneInput.Name = "phoneInput";
            phoneInput.Size = new Size(392, 39);
            phoneInput.TabIndex = 9;
            // 
            // username
            // 
            username.Dock = DockStyle.Fill;
            username.Font = new Font("Segoe UI", 14F);
            username.Location = new Point(0, 270);
            username.Margin = new Padding(0);
            username.Name = "username";
            username.Size = new Size(203, 54);
            username.TabIndex = 5;
            username.Text = "Tên tài khoản:";
            username.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // address
            // 
            address.Dock = DockStyle.Fill;
            address.Font = new Font("Segoe UI", 14F);
            address.Location = new Point(0, 216);
            address.Margin = new Padding(0);
            address.Name = "address";
            address.Size = new Size(203, 54);
            address.TabIndex = 4;
            address.Text = "Địa chỉ:";
            address.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cccd
            // 
            cccd.Dock = DockStyle.Fill;
            cccd.Font = new Font("Segoe UI", 14F);
            cccd.Location = new Point(0, 162);
            cccd.Margin = new Padding(0);
            cccd.Name = "cccd";
            cccd.Size = new Size(203, 54);
            cccd.TabIndex = 3;
            cccd.Text = "CCCD:";
            cccd.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // phone
            // 
            phone.Dock = DockStyle.Fill;
            phone.Font = new Font("Segoe UI", 14F);
            phone.Location = new Point(0, 108);
            phone.Margin = new Padding(0);
            phone.Name = "phone";
            phone.Size = new Size(203, 54);
            phone.TabIndex = 2;
            phone.Text = "Số điện thoại:";
            phone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // role
            // 
            role.Dock = DockStyle.Fill;
            role.Font = new Font("Segoe UI", 14F);
            role.Location = new Point(0, 54);
            role.Margin = new Padding(0);
            role.Name = "role";
            role.Size = new Size(203, 54);
            role.TabIndex = 1;
            role.Text = "Công việc:";
            role.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // name
            // 
            name.Dock = DockStyle.Fill;
            name.Font = new Font("Segoe UI", 14F);
            name.Location = new Point(0, 0);
            name.Margin = new Padding(0);
            name.Name = "name";
            name.Size = new Size(203, 54);
            name.TabIndex = 0;
            name.Text = "Tên nhân viên:";
            name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nameInput
            // 
            nameInput.Dock = DockStyle.Fill;
            nameInput.Location = new Point(203, 10);
            nameInput.Margin = new Padding(0, 10, 10, 0);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(392, 39);
            nameInput.TabIndex = 7;
            // 
            // roleCombo
            // 
            roleCombo.Dock = DockStyle.Fill;
            roleCombo.FormattingEnabled = true;
            roleCombo.Location = new Point(203, 64);
            roleCombo.Margin = new Padding(0, 10, 10, 0);
            roleCombo.Name = "roleCombo";
            roleCombo.Size = new Size(392, 39);
            roleCombo.TabIndex = 13;
            // 
            // picturePanel
            // 
            picturePanel.ColumnCount = 1;
            picturePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            picturePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            picturePanel.Controls.Add(pictureSetting, 0, 1);
            picturePanel.Controls.Add(picture, 0, 0);
            picturePanel.Dock = DockStyle.Fill;
            picturePanel.Location = new Point(631, 20);
            picturePanel.Margin = new Padding(0);
            picturePanel.Name = "picturePanel";
            picturePanel.RowCount = 2;
            picturePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 84.8717957F));
            picturePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.1282053F));
            picturePanel.Size = new Size(285, 330);
            picturePanel.TabIndex = 1;
            // 
            // pictureSetting
            // 
            pictureSetting.ColumnCount = 1;
            pictureSetting.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pictureSetting.Controls.Add(browse, 0, 0);
            pictureSetting.Dock = DockStyle.Fill;
            pictureSetting.Location = new Point(0, 280);
            pictureSetting.Margin = new Padding(0);
            pictureSetting.Name = "pictureSetting";
            pictureSetting.RowCount = 1;
            pictureSetting.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pictureSetting.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pictureSetting.Size = new Size(285, 50);
            pictureSetting.TabIndex = 0;
            // 
            // browse
            // 
            browse.BackColor = Color.Black;
            browse.Cursor = Cursors.Hand;
            browse.Dock = DockStyle.Fill;
            browse.ForeColor = Color.White;
            browse.Location = new Point(40, 0);
            browse.Margin = new Padding(40, 0, 40, 0);
            browse.Name = "browse";
            browse.Size = new Size(205, 50);
            browse.TabIndex = 0;
            browse.Text = "Chọn ảnh";
            browse.UseVisualStyleBackColor = false;
            browse.MouseEnter += buttonEnter;
            browse.MouseLeave += buttonLeave;
            // 
            // picture
            // 
            picture.BackColor = Color.White;
            picture.Dock = DockStyle.Fill;
            picture.Image = BadmintonCourtManagement.GUI.Properties.Resources.user;
            picture.Location = new Point(0, 0);
            picture.Margin = new Padding(0);
            picture.Name = "picture";
            picture.Size = new Size(285, 280);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.TabIndex = 1;
            picture.TabStop = false;
            // 
            // TitlePanel
            // 
            TitlePanel.Controls.Add(TitleText);
            TitlePanel.Dock = DockStyle.Top;
            TitlePanel.Location = new Point(20, 20);
            TitlePanel.Margin = new Padding(0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(936, 83);
            TitlePanel.TabIndex = 1;
            // 
            // TitleText
            // 
            TitleText.Dock = DockStyle.Fill;
            TitleText.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            TitleText.Location = new Point(0, 0);
            TitleText.Margin = new Padding(0);
            TitleText.Name = "TitleText";
            TitleText.Size = new Size(936, 83);
            TitleText.TabIndex = 0;
            TitleText.Text = "Thêm nhân viên:";
            TitleText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EmployeeAddGUI
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 120, 103);
            ClientSize = new Size(1046, 571);
            Controls.Add(mainPanel);
            Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "EmployeeAddGUI";
            Padding = new Padding(35, 39, 35, 39);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeAddGUI";
            mainPanel.ResumeLayout(false);
            bodyPanel.ResumeLayout(false);
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            picturePanel.ResumeLayout(false);
            pictureSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            TitlePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private TableLayoutPanel bodyPanel;
        private TableLayoutPanel infoPanel;
        private Label status;
        private Label username;
        private Label address;
        private Label cccd;
        private Label phone;
        private Label role;
        private Label name;
        private Label productID;
        private Label importBillID;
        private Panel TitlePanel;
        private Label TitleText;
        private TableLayoutPanel picturePanel;
        private TextBox nameInput;
        private TableLayoutPanel pictureSetting;
        private PictureBox picture;
        private TextBox usernameInput;
        private TextBox addressInput;
        private TextBox cccdInput;
        private TextBox phoneInput;
        private ComboBox roleCombo;
        private Button browse;
    }
}