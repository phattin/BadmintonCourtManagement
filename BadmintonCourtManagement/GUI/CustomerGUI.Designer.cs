﻿namespace BadmintonCourtManagement.GUI
{
    partial class CustomerGUI
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
            lblTitle = new Label();
            customPanel1 = new CustomPanel();
            pCustomerList = new TableLayoutPanel();
            customPanel2 = new CustomPanel();
            pictureBox1 = new PictureBox();
            customPanel3 = new CustomPanel();
            btnClearSearch = new PictureBox();
            txtSearch = new TextBox();
            drPanelCustomer = new Panel();
            lblAddCustomer = new Label();
            customPanel1.SuspendLayout();
            customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClearSearch).BeginInit();
            drPanelCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(66, 19);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(12, 14, 12, 14);
            lblTitle.Size = new Size(340, 73);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Quản lý khách hàng";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.UseWaitCursor = true;
            // 
            // customPanel1
            // 
            customPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customPanel1.BackColor = Color.FromArgb(239, 248, 230);
            customPanel1.BorderRadius = 20;
            customPanel1.Controls.Add(pCustomerList);
            customPanel1.Controls.Add(customPanel2);
            customPanel1.Location = new Point(70, 99);
            customPanel1.Margin = new Padding(4, 5, 4, 5);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(1432, 799);
            customPanel1.TabIndex = 6;
            // 
            // pCustomerList
            // 
            pCustomerList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pCustomerList.ColumnCount = 4;
            pCustomerList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCustomerList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCustomerList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCustomerList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pCustomerList.Location = new Point(54, 126);
            pCustomerList.Margin = new Padding(2);
            pCustomerList.Name = "pCustomerList";
            pCustomerList.RowCount = 2;
            pCustomerList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pCustomerList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pCustomerList.Size = new Size(1324, 618);
            pCustomerList.TabIndex = 1;
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel2.BackColor = Color.FromArgb(0, 120, 103);
            customPanel2.BorderRadius = 20;
            customPanel2.Controls.Add(pictureBox1);
            customPanel2.Controls.Add(customPanel3);
            customPanel2.Location = new Point(0, 0);
            customPanel2.Margin = new Padding(4, 5, 4, 5);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(1432, 91);
            customPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Location = new Point(1355, 15);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // customPanel3
            // 
            customPanel3.BackColor = Color.White;
            customPanel3.BorderRadius = 30;
            customPanel3.Controls.Add(btnClearSearch);
            customPanel3.Controls.Add(txtSearch);
            customPanel3.Location = new Point(19, 15);
            customPanel3.Margin = new Padding(4, 4, 4, 4);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(650, 64);
            customPanel3.TabIndex = 1;
            // 
            // btnClearSearch
            // 
            btnClearSearch.Image = Properties.Resources.X;
            btnClearSearch.Location = new Point(612, 24);
            btnClearSearch.Margin = new Padding(4, 4, 4, 4);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(16, 16);
            btnClearSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClearSearch.TabIndex = 1;
            btnClearSearch.TabStop = false;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(18, 16);
            txtSearch.Margin = new Padding(4, 4, 4, 4);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm khách hàng";
            txtSearch.Size = new Size(588, 30);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // drPanelCustomer
            // 
            drPanelCustomer.BackColor = Color.White;
            drPanelCustomer.Controls.Add(lblAddCustomer);
            drPanelCustomer.Controls.Add(customPanel1);
            drPanelCustomer.Controls.Add(lblTitle);
            drPanelCustomer.Dock = DockStyle.Fill;
            drPanelCustomer.Location = new Point(0, 0);
            drPanelCustomer.Margin = new Padding(4, 4, 4, 4);
            drPanelCustomer.Name = "drPanelCustomer";
            drPanelCustomer.Size = new Size(1554, 958);
            drPanelCustomer.TabIndex = 0;
            // 
            // lblAddCustomer
            // 
            lblAddCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAddCustomer.AutoSize = true;
            lblAddCustomer.BackColor = Color.FromArgb(64, 64, 64);
            lblAddCustomer.Cursor = Cursors.Hand;
            lblAddCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddCustomer.ForeColor = Color.White;
            lblAddCustomer.Location = new Point(1264, 19);
            lblAddCustomer.Margin = new Padding(4, 0, 4, 0);
            lblAddCustomer.Name = "lblAddCustomer";
            lblAddCustomer.Padding = new Padding(12, 14, 12, 16);
            lblAddCustomer.Size = new Size(238, 62);
            lblAddCustomer.TabIndex = 7;
            lblAddCustomer.Text = "Thêm khách hàng";
            lblAddCustomer.TextAlign = ContentAlignment.MiddleCenter;
            lblAddCustomer.Click += lblAddCustomer_Click;
            // 
            // CustomerGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(drPanelCustomer);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CustomerGUI";
            Size = new Size(1554, 958);
            Load += CustomerGUI_Load;
            customPanel1.ResumeLayout(false);
            customPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            customPanel3.ResumeLayout(false);
            customPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClearSearch).EndInit();
            drPanelCustomer.ResumeLayout(false);
            drPanelCustomer.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Label lblTitle;
        private CustomPanel customPanel1;
        private TableLayoutPanel pCustomerList;
        private CustomPanel customPanel2;
        private CustomPanel customPanel3;
        private TextBox txtSearch;
        private PictureBox btnClearSearch;
        private PictureBox pictureBox1;
        private Panel drPanelCustomer;
        private Label lblAddCustomer;
    }
}