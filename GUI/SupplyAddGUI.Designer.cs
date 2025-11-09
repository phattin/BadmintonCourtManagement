using BadmintonCourtManagement.GUI.ComponentsGUI.SupplyAddGUI;

namespace BadmintonCourtManagement.GUI
{
    partial class SupplyAddGUI
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
            MainPanel = new Panel();
            donePanel = new Panel();
            done = new Button();
            listDetailPanel = new SupplyDetails();
            productPanel = new TableLayoutPanel();
            listProductPanel = new SupplyProductList();
            infoProductPanel = new SupplyProductInfo();
            MainPanel.SuspendLayout();
            donePanel.SuspendLayout();
            productPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.AutoScroll = true;
            MainPanel.Controls.Add(donePanel);
            MainPanel.Controls.Add(listDetailPanel);
            MainPanel.Controls.Add(productPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Margin = new Padding(0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1274, 793);
            MainPanel.TabIndex = 0;
            // 
            // donePanel
            // 
            donePanel.Controls.Add(done);
            donePanel.Dock = DockStyle.Top;
            donePanel.Location = new Point(0, 1182);
            donePanel.Margin = new Padding(0);
            donePanel.Name = "donePanel";
            donePanel.Padding = new Padding(500, 0, 500, 0);
            donePanel.Size = new Size(1253, 78);
            donePanel.TabIndex = 2;
            donePanel.MouseEnter += buttonEnter;
            donePanel.MouseLeave += buttonLeave;
            // 
            // done
            // 
            done.BackColor = Color.Black;
            done.Cursor = Cursors.Hand;
            done.Dock = DockStyle.Fill;
            done.ForeColor = Color.White;
            done.Location = new Point(500, 0);
            done.Margin = new Padding(0);
            done.Name = "done";
            done.Size = new Size(253, 78);
            done.TabIndex = 0;
            done.Text = "Hoàn thành";
            done.UseVisualStyleBackColor = false;
            done.MouseEnter += buttonEnter;
            done.MouseLeave += buttonLeave;
            // 
            // listDetailPanel
            // 
            listDetailPanel.AutoScroll = true;
            listDetailPanel.Dock = DockStyle.Top;
            listDetailPanel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            listDetailPanel.Location = new Point(0, 720);
            listDetailPanel.Margin = new Padding(0);
            listDetailPanel.Name = "listDetailPanel";
            listDetailPanel.Size = new Size(1253, 462);
            listDetailPanel.TabIndex = 1;
            // 
            // productPanel
            // 
            productPanel.ColumnCount = 2;
            productPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            productPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            productPanel.Controls.Add(listProductPanel, 0, 0);
            productPanel.Controls.Add(infoProductPanel, 1, 0);
            productPanel.Dock = DockStyle.Top;
            productPanel.Location = new Point(0, 0);
            productPanel.Margin = new Padding(0);
            productPanel.Name = "productPanel";
            productPanel.RowCount = 1;
            productPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            productPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            productPanel.Size = new Size(1253, 720);
            productPanel.TabIndex = 0;
            // 
            // listProductPanel
            // 
            listProductPanel.AutoScroll = true;
            listProductPanel.Dock = DockStyle.Fill;
            listProductPanel.Font = new Font("Roboto Medium", 34.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listProductPanel.Location = new Point(0, 0);
            listProductPanel.Margin = new Padding(0);
            listProductPanel.Name = "listProductPanel";
            listProductPanel.Size = new Size(626, 720);
            listProductPanel.TabIndex = 0;
            // 
            // infoProductPanel
            // 
            infoProductPanel.AutoScroll = true;
            infoProductPanel.Dock = DockStyle.Fill;
            infoProductPanel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            infoProductPanel.Location = new Point(626, 0);
            infoProductPanel.Margin = new Padding(0);
            infoProductPanel.Name = "infoProductPanel";
            infoProductPanel.Size = new Size(627, 720);
            infoProductPanel.TabIndex = 1;
            // 
            // SupplyAddGUI
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1274, 793);
            Controls.Add(MainPanel);
            Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "SupplyAddGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm đơn hàng nhập";
            Load += SupplyAddGUI_Load;
            MainPanel.ResumeLayout(false);
            donePanel.ResumeLayout(false);
            productPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private TableLayoutPanel productPanel;
        private SupplyProductList listProductPanel;
        private SupplyProductInfo infoProductPanel;
        private ComponentsGUI.SupplyAddGUI.SupplyProductList supplyProductList1;
        private ComponentsGUI.SupplyAddGUI.SupplyProductInfo supplyProductInfo1;
        private Panel panel1;
        private ComponentsGUI.SupplyAddGUI.SupplyDetails listDetailPanel;
        private Panel donePanel;
        private Button done;
    }
}