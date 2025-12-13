namespace GUI
{
    partial class StatisticMainGUI
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            statisticBookinggui1 = new StatisticBookingGUI(listBooking, listBillBookings,listCourts);
            tabPage2 = new TabPage();
            statisticImportProductgui1 = new StatisticImportProductGUI(listImportBill, listImportDetails, listProducts);
            tabPage3 = new TabPage();
            statisticProductgui1 = new StatisticProductGUI(listBillProduct, listBillDetails, listProducts);
            tabPage4 = new TabPage();
            statisticTotalgui1 = new StatisticTotalGUI(listBillBookings,listBillProduct, listImportBill);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1189, 705);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(statisticBookinggui1);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1181, 664);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Đặt sân";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // statisticBookinggui1
            // 
            statisticBookinggui1.Dock = DockStyle.Fill;
            statisticBookinggui1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statisticBookinggui1.Location = new Point(3, 3);
            statisticBookinggui1.Margin = new Padding(4, 2, 4, 2);
            statisticBookinggui1.Name = "statisticBookinggui1";
            statisticBookinggui1.Size = new Size(1175, 658);
            statisticBookinggui1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(statisticImportProductgui1);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1181, 664);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Nhập sản phẩm";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // statisticImportProductgui1
            // 
            statisticImportProductgui1.Dock = DockStyle.Fill;
            statisticImportProductgui1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statisticImportProductgui1.Location = new Point(3, 3);
            statisticImportProductgui1.Name = "statisticImportProductgui1";
            statisticImportProductgui1.Size = new Size(1175, 658);
            statisticImportProductgui1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(statisticProductgui1);
            tabPage3.Location = new Point(4, 37);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1181, 664);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Bán sản phẩm";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // statisticProductgui1
            // 
            statisticProductgui1.Dock = DockStyle.Fill;
            statisticProductgui1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statisticProductgui1.Location = new Point(3, 3);
            statisticProductgui1.Name = "statisticProductgui1";
            statisticProductgui1.Size = new Size(1175, 658);
            statisticProductgui1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(statisticTotalgui1);
            tabPage4.Location = new Point(4, 37);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1181, 664);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Tổng quan";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // statisticTotalgui1
            // 
            statisticTotalgui1.Dock = DockStyle.Fill;
            statisticTotalgui1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statisticTotalgui1.Location = new Point(3, 3);
            statisticTotalgui1.Name = "statisticTotalgui1";
            statisticTotalgui1.Size = new Size(1175, 658);
            statisticTotalgui1.TabIndex = 0;
            // 
            // StatisticMainGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "StatisticMainGUI";
            Size = new Size(1189, 705);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private StatisticBookingGUI statisticBookinggui1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private StatisticImportProductGUI statisticImportProductgui1;
        private StatisticProductGUI statisticProductgui1;
        private TabPage tabPage4;
        private StatisticTotalGUI statisticTotalgui1;
    }
}
