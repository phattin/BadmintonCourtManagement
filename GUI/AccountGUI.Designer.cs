namespace GUI
{
    partial class AccountGUI
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelTop = new Panel();
            panelTopRight = new Panel();
            flowLayoutPanel = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonModify = new Button();
            buttonDelete = new Button();
            labelTitle = new Label();
            panelBottom = new Panel();
            customPanel1 = new BadmintonCourtManagement.GUI.CustomPanel();
            panelDataGridView = new Panel();
            dataGridView1 = new DataGridView();
            PermissionId = new DataGridViewTextBoxColumn();
            EmployeeName = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            customPanel3 = new BadmintonCourtManagement.GUI.CustomPanel();
            textBox1 = new TextBox();
            customPanel2 = new BadmintonCourtManagement.GUI.CustomPanel();
            panelTop.SuspendLayout();
            panelTopRight.SuspendLayout();
            flowLayoutPanel.SuspendLayout();
            panelBottom.SuspendLayout();
            customPanel1.SuspendLayout();
            panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            customPanel3.SuspendLayout();
            customPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(panelTopRight);
            panelTop.Controls.Add(labelTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(53, 0, 53, 0);
            panelTop.Size = new Size(1209, 72);
            panelTop.TabIndex = 0;
            // 
            // panelTopRight
            // 
            panelTopRight.BackColor = Color.White;
            panelTopRight.Controls.Add(flowLayoutPanel);
            panelTopRight.Dock = DockStyle.Right;
            panelTopRight.Location = new Point(787, 0);
            panelTopRight.Margin = new Padding(0);
            panelTopRight.Name = "panelTopRight";
            panelTopRight.Padding = new Padding(0, 20, 0, 0);
            panelTopRight.Size = new Size(369, 72);
            panelTopRight.TabIndex = 1;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.BackColor = Color.White;
            flowLayoutPanel.Controls.Add(buttonAdd);
            flowLayoutPanel.Controls.Add(buttonModify);
            flowLayoutPanel.Controls.Add(buttonDelete);
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(0, 20);
            flowLayoutPanel.Margin = new Padding(0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(369, 52);
            flowLayoutPanel.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(64, 64, 64);
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(0, 0);
            buttonAdd.Margin = new Padding(0);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(123, 52);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Thêm";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonModify
            // 
            buttonModify.BackColor = Color.FromArgb(64, 64, 64);
            buttonModify.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonModify.ForeColor = Color.White;
            buttonModify.Location = new Point(123, 0);
            buttonModify.Margin = new Padding(0);
            buttonModify.Name = "buttonModify";
            buttonModify.Size = new Size(123, 52);
            buttonModify.TabIndex = 1;
            buttonModify.Text = "Sửa ";
            buttonModify.UseVisualStyleBackColor = false;
            buttonModify.Click += buttonModify_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(64, 64, 64);
            buttonDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(246, 0);
            buttonDelete.Margin = new Padding(0);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(123, 52);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Xóa";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.White;
            labelTitle.Dock = DockStyle.Left;
            labelTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Black;
            labelTitle.Location = new Point(53, 0);
            labelTitle.Margin = new Padding(0);
            labelTitle.Name = "labelTitle";
            labelTitle.Padding = new Padding(0, 20, 0, 0);
            labelTitle.Size = new Size(753, 72);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Quản lý tài khoản";
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.White;
            panelBottom.Controls.Add(customPanel1);
            panelBottom.Dock = DockStyle.Fill;
            panelBottom.Location = new Point(0, 72);
            panelBottom.Margin = new Padding(3, 4, 3, 4);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(53, 0, 53, 40);
            panelBottom.Size = new Size(1209, 736);
            panelBottom.TabIndex = 1;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.FromArgb(239, 248, 230);
            customPanel1.BorderRadius = 20;
            customPanel1.Controls.Add(panelDataGridView);
            customPanel1.Controls.Add(customPanel2);
            customPanel1.Dock = DockStyle.Fill;
            customPanel1.Location = new Point(53, 0);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(1103, 696);
            customPanel1.TabIndex = 25;
            // 
            // panelDataGridView
            // 
            panelDataGridView.Controls.Add(dataGridView1);
            panelDataGridView.Dock = DockStyle.Fill;
            panelDataGridView.Location = new Point(0, 88);
            panelDataGridView.Name = "panelDataGridView";
            panelDataGridView.Padding = new Padding(20);
            panelDataGridView.Size = new Size(1103, 608);
            panelDataGridView.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 120, 103);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PermissionId, EmployeeName, Username, Password, Status });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(20, 20);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1063, 568);
            dataGridView1.TabIndex = 0;
            // 
            // PermissionId
            // 
            PermissionId.HeaderText = "Quyền hạn";
            PermissionId.MinimumWidth = 6;
            PermissionId.Name = "PermissionId";
            // 
            // EmployeeName
            // 
            EmployeeName.HeaderText = "Tên nhân viên";
            EmployeeName.MinimumWidth = 6;
            EmployeeName.Name = "EmployeeName";
            // 
            // Username
            // 
            Username.HeaderText = "Tài khoản";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            // 
            // Password
            // 
            Password.HeaderText = "Mật khẩu";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            // 
            // Status
            // 
            Status.HeaderText = "Tình trạng";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // customPanel3
            // 
            customPanel3.BackColor = Color.White;
            customPanel3.BorderRadius = 30;
            customPanel3.Controls.Add(textBox1);
            customPanel3.Dock = DockStyle.Left;
            customPanel3.Location = new Point(25, 25);
            customPanel3.Margin = new Padding(3, 2, 3, 2);
            customPanel3.Name = "customPanel3";
            customPanel3.Padding = new Padding(10, 3, 0, 0);
            customPanel3.Size = new Size(455, 38);
            customPanel3.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(10, 3);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tìm kiếm";
            textBox1.Size = new Size(445, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.FromArgb(0, 120, 103);
            customPanel2.BorderRadius = 20;
            customPanel2.Controls.Add(customPanel3);
            customPanel2.Dock = DockStyle.Top;
            customPanel2.Location = new Point(0, 0);
            customPanel2.Name = "customPanel2";
            customPanel2.Padding = new Padding(25, 25, 0, 25);
            customPanel2.Size = new Size(1103, 88);
            customPanel2.TabIndex = 0;
            // 
            // AccountGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AccountGUI";
            Size = new Size(1209, 808);
            panelTop.ResumeLayout(false);
            panelTopRight.ResumeLayout(false);
            flowLayoutPanel.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            customPanel1.ResumeLayout(false);
            panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            customPanel3.ResumeLayout(false);
            customPanel3.PerformLayout();
            customPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelTitle;
        private Panel panelTopRight;
        private Button buttonAdd;
        private Panel panelBottom;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel;
        private Button buttonModify;
        private Button buttonDelete;
        private DataGridViewTextBoxColumn PermissionId;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Status;
        private BadmintonCourtManagement.GUI.CustomPanel customPanel1;
        private Panel panelDataGridView;
        private BadmintonCourtManagement.GUI.CustomPanel customPanel2;
        private BadmintonCourtManagement.GUI.CustomPanel customPanel3;
        private TextBox textBox1;
    }
}
