namespace GUI
{
    partial class PriceRuleGUI
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelTop = new Panel();
            panelTopRight = new Panel();
            buttonAdd = new Button();
            labelTitle = new Label();
            panelBottom = new Panel();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            StartTime = new DataGridViewTextBoxColumn();
            EndTime = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Function = new DataGridViewButtonColumn();
            panelTop.SuspendLayout();
            panelTopRight.SuspendLayout();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(panelTopRight);
            panelTop.Controls.Add(labelTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(30, 0, 30, 0);
            panelTop.Size = new Size(1050, 100);
            panelTop.TabIndex = 0;
            // 
            // panelTopRight
            // 
            panelTopRight.Controls.Add(buttonAdd);
            panelTopRight.Dock = DockStyle.Fill;
            panelTopRight.Location = new Point(886, 0);
            panelTopRight.Margin = new Padding(0);
            panelTopRight.Name = "panelTopRight";
            panelTopRight.Padding = new Padding(0, 25, 0, 25);
            panelTopRight.Size = new Size(134, 100);
            panelTopRight.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(0, 25);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(134, 50);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Thêm";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Left;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(30, 0);
            labelTitle.Margin = new Padding(0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(856, 100);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Giá Sân";
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(dataGridView1);
            panelBottom.Dock = DockStyle.Fill;
            panelBottom.Location = new Point(0, 100);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1050, 506);
            panelBottom.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, StartTime, EndTime, StartDate, EndDate, Price, Status, Function });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1050, 506);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // StartTime
            // 
            StartTime.HeaderText = "StartTime";
            StartTime.Name = "StartTime";
            // 
            // EndTime
            // 
            EndTime.HeaderText = "EndTime";
            EndTime.Name = "EndTime";
            // 
            // StartDate
            // 
            StartDate.HeaderText = "StartDate";
            StartDate.Name = "StartDate";
            // 
            // EndDate
            // 
            EndDate.HeaderText = "EndDate";
            EndDate.Name = "EndDate";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // Function
            // 
            Function.HeaderText = "Function";
            Function.Name = "Function";
            // 
            // PriceRuleGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Name = "PriceRuleGUI";
            Size = new Size(1050, 606);
            panelTop.ResumeLayout(false);
            panelTopRight.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelTitle;
        private Panel panelTopRight;
        private Button buttonAdd;
        private Panel panelBottom;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn StartTime;
        private DataGridViewTextBoxColumn EndTime;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn Function;
    }
}
