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
            panel2 = new Panel();
            txtUsername = new TextBox();
            pIconUser = new PictureBox();
            bSignIn = new Button();
            lblTitle = new Label();
            pIconPassword = new PictureBox();
            lblWelcome = new Label();
            lblBrand = new Label();
            pLogo = new PictureBox();
            panel3 = new Panel();
            txtPassword = new TextBox();
            pSignIn.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pIconUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pIconPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pLogo).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pSignIn
            // 
            pSignIn.BackColor = Color.FromArgb(235, 235, 235);
            pSignIn.Controls.Add(panel2);
            pSignIn.Controls.Add(bSignIn);
            pSignIn.Controls.Add(lblTitle);
            pSignIn.Location = new Point(597, -2);
            pSignIn.Margin = new Padding(4, 5, 4, 5);
            pSignIn.Name = "pSignIn";
            pSignIn.Size = new Size(810, 1103);
            pSignIn.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(pIconUser);
            panel2.Location = new Point(0, 325);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(810, 85);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(96, 23);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(696, 38);
            txtUsername.TabIndex = 3;
            txtUsername.Tag = "";
            txtUsername.TextChanged += txtUsername_TextChanged;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // pIconUser
            // 
            pIconUser.BackColor = Color.White;
            pIconUser.Image = Properties.Resources.user_solid_full;
            pIconUser.Location = new Point(17, 10);
            pIconUser.Margin = new Padding(4, 5, 4, 5);
            pIconUser.Name = "pIconUser";
            pIconUser.Size = new Size(56, 70);
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
            bSignIn.Location = new Point(281, 692);
            bSignIn.Margin = new Padding(4, 5, 4, 5);
            bSignIn.Name = "bSignIn";
            bSignIn.Size = new Size(269, 92);
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
            lblTitle.Location = new Point(303, 195);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(228, 55);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Đăng nhập";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // pIconPassword
            // 
            pIconPassword.BackColor = Color.White;
            pIconPassword.Image = Properties.Resources.lock_solid_full;
            pIconPassword.Location = new Point(17, 5);
            pIconPassword.Margin = new Padding(4, 5, 4, 5);
            pIconPassword.Name = "pIconPassword";
            pIconPassword.Size = new Size(56, 70);
            pIconPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pIconPassword.TabIndex = 6;
            pIconPassword.TabStop = false;
            pIconPassword.Click += pIconPassword_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(100, 193);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(292, 55);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "WELCOME TO ";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(100, 255);
            lblBrand.Margin = new Padding(4, 0, 4, 0);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(122, 55);
            lblBrand.TabIndex = 2;
            lblBrand.Text = "SCLL ";
            lblBrand.Click += lblBrand_Click;
            // 
            // pLogo
            // 
            pLogo.Image = Properties.Resources.image_3;
            pLogo.Location = new Point(100, 443);
            pLogo.Margin = new Padding(4, 5, 4, 5);
            pLogo.Name = "pLogo";
            pLogo.Size = new Size(361, 440);
            pLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pLogo.TabIndex = 3;
            pLogo.TabStop = false;
            pLogo.Click += pLogo_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(pIconPassword);
            panel3.Location = new Point(597, 443);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(810, 85);
            panel3.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(96, 23);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(696, 38);
            txtPassword.TabIndex = 3;
            txtPassword.Tag = "";
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // LoginGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(125, 179, 125);
            ClientSize = new Size(1406, 1050);
            Controls.Add(panel3);
            Controls.Add(pLogo);
            Controls.Add(lblBrand);
            Controls.Add(lblWelcome);
            Controls.Add(pSignIn);
            Name = "LoginGUI";
            Text = "Đăng nhập";
            Load += LoginGUI_Load;
            pSignIn.ResumeLayout(false);
            pSignIn.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pIconUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pIconPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pLogo).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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