namespace BadmintonCourtManagement.GUI
{
    partial class LoginGUI
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
            pSignIn = new Panel();
            panel3 = new Panel();
            txtPassword = new TextBox();
            txtPassword.Text = "admin123"; // Default password for testing
            pIconPassword = new PictureBox();
            panel2 = new Panel();
            txtUsername = new TextBox();
            txtUsername.Text = "admin"; // Default username for testing
            pIconUser = new PictureBox();
            bSignIn = new Button();
            lblTitle = new Label();
            lblWelcome = new Label();
            lblBrand = new Label();
            pLogo = new PictureBox();
            pSignIn.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pIconPassword).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pIconUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pLogo).BeginInit();
            SuspendLayout();
            // 
            // pSignIn
            // 
            pSignIn.BackColor = Color.FromArgb(235, 235, 235);
            pSignIn.Controls.Add(panel3);
            pSignIn.Controls.Add(panel2);
            pSignIn.Controls.Add(bSignIn);
            pSignIn.Controls.Add(lblTitle);
            pSignIn.Location = new Point(420, 1);
            pSignIn.Margin = new Padding(3, 4, 3, 4);
            pSignIn.Name = "pSignIn";
            pSignIn.Size = new Size(508, 644);
            pSignIn.TabIndex = 0;
            pSignIn.Paint += pSignIn_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(pIconPassword);
            panel3.Location = new Point(3, 243);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(502, 68);
            panel3.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(77, 18);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(411, 32);
            txtPassword.TabIndex = 3;
            txtPassword.Tag = "";
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // pIconPassword
            // 
            pIconPassword.BackColor = Color.White;
            pIconPassword.Image = Properties.Resources.lockIcon;
            pIconPassword.Location = new Point(14, 4);
            pIconPassword.Margin = new Padding(3, 4, 3, 4);
            pIconPassword.Name = "pIconPassword";
            pIconPassword.Size = new Size(45, 56);
            pIconPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pIconPassword.TabIndex = 6;
            pIconPassword.TabStop = false;
            pIconPassword.Click += pIconPassword_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(pIconUser);
            panel2.Location = new Point(0, 147);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(505, 68);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(77, 18);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(414, 32);
            txtUsername.TabIndex = 3;
            txtUsername.Tag = "";
            txtUsername.TextChanged += txtUsername_TextChanged;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // pIconUser
            // 
            pIconUser.BackColor = Color.White;
            pIconUser.Image = Properties.Resources.user;
            pIconUser.Location = new Point(14, 8);
            pIconUser.Margin = new Padding(3, 4, 3, 4);
            pIconUser.Name = "pIconUser";
            pIconUser.Size = new Size(45, 56);
            pIconUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pIconUser.TabIndex = 5;
            pIconUser.TabStop = false;
            // 
            // bSignIn
            // 
            bSignIn.BackColor = Color.FromArgb(125, 179, 125);
            bSignIn.BackgroundImageLayout = ImageLayout.None;
            bSignIn.Cursor = Cursors.AppStarting;
            bSignIn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bSignIn.ForeColor = Color.White;
            bSignIn.Location = new Point(154, 428);
            bSignIn.Margin = new Padding(3, 4, 3, 4);
            bSignIn.Name = "bSignIn";
            bSignIn.Size = new Size(215, 74);
            bSignIn.TabIndex = 7;
            bSignIn.Text = "Đăng nhập";
            bSignIn.TextImageRelation = TextImageRelation.TextAboveImage;
            bSignIn.UseVisualStyleBackColor = false;
            bSignIn.Click += bSignIn_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(125, 179, 125);
            lblTitle.Location = new Point(165, 64);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(189, 46);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Đăng nhập";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(56, 65);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(245, 46);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "WELCOME TO ";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(56, 111);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(103, 46);
            lblBrand.TabIndex = 2;
            lblBrand.Text = "SCLL ";
            lblBrand.Click += lblBrand_Click;
            // 
            // pLogo
            // 
            pLogo.Image = Properties.Resources.iconcl;
            pLogo.Location = new Point(56, 216);
            pLogo.Margin = new Padding(3, 4, 3, 4);
            pLogo.Name = "pLogo";
            pLogo.Size = new Size(289, 352);
            pLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pLogo.TabIndex = 3;
            pLogo.TabStop = false;
            pLogo.Click += pLogo_Click;
            // 
            // LoginGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(125, 179, 125);
            ClientSize = new Size(926, 644);
            Controls.Add(pLogo);
            Controls.Add(lblBrand);
            Controls.Add(lblWelcome);
            Controls.Add(pSignIn);
            Margin = new Padding(2);
            Name = "LoginGUI";
            Text = "Đăng nhập";
            Load += LoginGUI_Load;
            pSignIn.ResumeLayout(false);
            pSignIn.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pIconPassword).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pIconUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pSignIn;
        private Label lblWelcome;
        private Label lblBrand;
        private PictureBox pLogo;
        private Label lblTitle;
        private TextBox txtUsername;
        private PictureBox pIconUser;
        private PictureBox pIconPassword;
        private Button bSignIn;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtPassword;
    }
}