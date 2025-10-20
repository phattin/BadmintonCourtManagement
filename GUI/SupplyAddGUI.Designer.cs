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
            Part_2 = new Panel();
            supplyDetails1 = new BadmintonCourtManagement.GUI.ComponentsGUI.SupplyAddGUI.SupplyDetails();
            Part_1 = new TableLayoutPanel();
            supplyProductList1 = new BadmintonCourtManagement.GUI.ComponentsGUI.SupplyAddGUI.SupplyProductList();
            supplyProductInfo1 = new BadmintonCourtManagement.GUI.ComponentsGUI.SupplyAddGUI.SupplyProductInfo();
            MainPanel.SuspendLayout();
            Part_2.SuspendLayout();
            Part_1.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.AutoScroll = true;
            MainPanel.Controls.Add(Part_2);
            MainPanel.Controls.Add(Part_1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Margin = new Padding(0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1902, 1055);
            MainPanel.TabIndex = 0;
            // 
            // Part_2
            // 
            Part_2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Part_2.AutoSize = true;
            Part_2.Controls.Add(supplyDetails1);
            Part_2.Location = new Point(0, 1027);
            Part_2.Margin = new Padding(0);
            Part_2.Name = "Part_2";
            Part_2.Padding = new Padding(80, 0, 80, 80);
            Part_2.Size = new Size(1881, 1280);
            Part_2.TabIndex = 1;
            // 
            // supplyDetails1
            // 
            supplyDetails1.AutoSize = true;
            supplyDetails1.Dock = DockStyle.Fill;
            supplyDetails1.Font = new Font("Roboto Medium", 34.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supplyDetails1.Location = new Point(80, 0);
            supplyDetails1.Margin = new Padding(0);
            supplyDetails1.Name = "supplyDetails1";
            supplyDetails1.Size = new Size(1721, 1200);
            supplyDetails1.TabIndex = 0;
            // 
            // Part_1
            // 
            Part_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Part_1.AutoSize = true;
            Part_1.ColumnCount = 2;
            Part_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Part_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Part_1.Controls.Add(supplyProductList1, 0, 0);
            Part_1.Controls.Add(supplyProductInfo1, 1, 0);
            Part_1.Location = new Point(0, 0);
            Part_1.Margin = new Padding(0);
            Part_1.Name = "Part_1";
            Part_1.Padding = new Padding(80, 0, 80, 0);
            Part_1.RowCount = 1;
            Part_1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Part_1.Size = new Size(1881, 1027);
            Part_1.TabIndex = 0;
            // 
            // supplyProductList1
            // 
            supplyProductList1.Dock = DockStyle.Fill;
            supplyProductList1.Font = new Font("Roboto Medium", 34.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supplyProductList1.Location = new Point(80, 0);
            supplyProductList1.Margin = new Padding(0, 0, 80, 0);
            supplyProductList1.Name = "supplyProductList1";
            supplyProductList1.Size = new Size(780, 1027);
            supplyProductList1.TabIndex = 0;
            // 
            // supplyProductInfo1
            // 
            supplyProductInfo1.Dock = DockStyle.Fill;
            supplyProductInfo1.Font = new Font("Roboto Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supplyProductInfo1.Location = new Point(1020, 0);
            supplyProductInfo1.Margin = new Padding(80, 0, 0, 0);
            supplyProductInfo1.Name = "supplyProductInfo1";
            supplyProductInfo1.Size = new Size(781, 1027);
            supplyProductInfo1.TabIndex = 1;
            // 
            // SupplyAddGUI
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1902, 1055);
            Controls.Add(MainPanel);
            Font = new Font("Roboto Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "SupplyAddGUI";
            Text = "SupplyAddGUI";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            Part_2.ResumeLayout(false);
            Part_2.PerformLayout();
            Part_1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Panel Part_2;
        private ComponentsGUI.SupplyAddGUI.SupplyDetails supplyDetails1;
        private TableLayoutPanel Part_1;
        private ComponentsGUI.SupplyAddGUI.SupplyProductList supplyProductList1;
        private ComponentsGUI.SupplyAddGUI.SupplyProductInfo supplyProductInfo1;
    }
}