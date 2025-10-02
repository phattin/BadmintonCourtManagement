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
            dataFrameCustomer.ColumnHeadersHeight = 29;
            dataFrameCustomer.Location = new Point(72, 253);
            dataFrameCustomer.Name = "dataFrameCustomer";
            dataFrameCustomer.RowHeadersWidth = 51;
            dataFrameCustomer.Size = new Size(1600, 817);
            dataFrameCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataFrameCustomer.ReadOnly = true;
            dataFrameCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataFrameCustomer.MultiSelect = false;
            dataFrameCustomer.AllowUserToAddRows = false;

            // 
            // btn_add_customer
            // 
            btn_add_customer.BackColor = Color.Black;
            btn_add_customer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_customer.ForeColor = SystemColors.ButtonHighlight;
            btn_add_customer.Location = new Point(1521, 41);
            btn_add_customer.Name = "btn_add_customer";
            btn_add_customer.Size = new Size(151, 50);
            btn_add_customer.TabIndex = 1;
            btn_add_customer.Text = "+ Thêm";
            btn_add_customer.UseVisualStyleBackColor = false;
            // 
            // lbl_title_customer
            // 
            lbl_title_customer.AutoSize = true;
            lbl_title_customer.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title_customer.Location = new Point(72, 42);
            lbl_title_customer.Name = "lbl_title_customer";
            lbl_title_customer.Size = new Size(285, 62);
            lbl_title_customer.TabIndex = 0;
            lbl_title_customer.Text = "Khách hàng";
            // 
            // CustomerGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}
