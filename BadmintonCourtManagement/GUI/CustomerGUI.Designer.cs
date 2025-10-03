namespace BadmintonCourtManagement.GUI
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
            customerPanel = new Panel();
            dataFrameCustomer = new DataGridView();
            btn_add_customer = new Button();
            lbl_title_customer = new Label();
            customerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataFrameCustomer).BeginInit();
            SuspendLayout();
            // 
            // customerPanel
            // 
            customerPanel.BackColor = Color.White;
            customerPanel.Controls.Add(dataFrameCustomer);
            customerPanel.Controls.Add(btn_add_customer);
            customerPanel.Controls.Add(lbl_title_customer);
            customerPanel.Dock = DockStyle.Fill;
            customerPanel.Location = new Point(0, 0);
            customerPanel.MaximumSize = new Size(1752, 1171);
            customerPanel.MinimumSize = new Size(634, 450);
            customerPanel.Name = "customerPanel";
            customerPanel.Size = new Size(1752, 1171);
            customerPanel.TabIndex = 0;
            // 
            // dataFrameCustomer
            // 
            dataFrameCustomer.AllowUserToAddRows = false;
            dataFrameCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataFrameCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataFrameCustomer.BackgroundColor = Color.White;
            dataFrameCustomer.ColumnHeadersHeight = 29;
            dataFrameCustomer.Location = new Point(72, 253);
            dataFrameCustomer.MultiSelect = false;
            dataFrameCustomer.Name = "dataFrameCustomer";
            dataFrameCustomer.ReadOnly = true;
            dataFrameCustomer.RowHeadersWidth = 51;
            dataFrameCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataFrameCustomer.Size = new Size(1600, 817);
            dataFrameCustomer.TabIndex = 0;
            // 
            // btn_add_customer
            // 
            btn_add_customer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_add_customer.BackColor = Color.FromArgb(64, 64, 64);
            btn_add_customer.FlatStyle = FlatStyle.Flat;
            btn_add_customer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_customer.ForeColor = SystemColors.ButtonHighlight;
            btn_add_customer.Location = new Point(1521, 45);
            btn_add_customer.Name = "btn_add_customer";
            btn_add_customer.Size = new Size(151, 50);
            btn_add_customer.TabIndex = 1;
            btn_add_customer.Text = "+ Thêm";
            btn_add_customer.UseVisualStyleBackColor = false;
            // 
            // lbl_title_customer
            // 
            lbl_title_customer.AutoSize = true;
            lbl_title_customer.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title_customer.Location = new Point(44, 45);
            lbl_title_customer.Name = "lbl_title_customer";
            lbl_title_customer.Size = new Size(277, 62);
            lbl_title_customer.TabIndex = 0;
            lbl_title_customer.Text = "Khách hàng";
            // 
            // CustomerGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(customerPanel);
            MaximumSize = new Size(1752, 1171);
            MinimumSize = new Size(634, 450);
            Name = "CustomerGUI";
            Size = new Size(1752, 1171);
            customerPanel.ResumeLayout(false);
            customerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataFrameCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
    }
}
