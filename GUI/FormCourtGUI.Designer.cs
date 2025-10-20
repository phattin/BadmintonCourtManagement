namespace BadmintonCourtManagement.GUI
{
    partial class FormCourtGUI
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
            Title = new Label();
            lblCourtName = new Label();
            lblCourtSTT = new Label();
            txtCourtName = new TextBox();
            Status = new ComboBox();
            btnAccept = new Button();
            btnCancel = new Button();
            lblCourtID = new Label();
            CourtID = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(128, 22);
            Title.Name = "Title";
            Title.Size = new Size(98, 38);
            Title.TabIndex = 0;
            Title.Text = "Sửa sân";
            Title.UseCompatibleTextRendering = true;
            // 
            // lblCourtName
            // 
            lblCourtName.AutoSize = true;
            lblCourtName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourtName.Location = new Point(28, 138);
            lblCourtName.Name = "lblCourtName";
            lblCourtName.Size = new Size(73, 30);
            lblCourtName.TabIndex = 1;
            lblCourtName.Text = "Tên sân";
            lblCourtName.UseCompatibleTextRendering = true;
            // 
            // lblCourtSTT
            // 
            lblCourtSTT.AutoSize = true;
            lblCourtSTT.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourtSTT.Location = new Point(28, 190);
            lblCourtSTT.Name = "lblCourtSTT";
            lblCourtSTT.Size = new Size(94, 30);
            lblCourtSTT.TabIndex = 2;
            lblCourtSTT.Text = "Trạng thái";
            lblCourtSTT.UseCompatibleTextRendering = true;
            // 
            // txtCourtName
            // 
            txtCourtName.Location = new Point(165, 138);
            txtCourtName.Margin = new Padding(3, 2, 3, 2);
            txtCourtName.Multiline = true;
            txtCourtName.Name = "txtCourtName";
            txtCourtName.Size = new Size(183, 22);
            txtCourtName.TabIndex = 3;
            // 
            // Status
            // 
            Status.FormattingEnabled = true;
            Status.Location = new Point(165, 190);
            Status.Margin = new Padding(3, 2, 3, 2);
            Status.Name = "Status";
            Status.Size = new Size(183, 23);
            Status.TabIndex = 4;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.IndianRed;
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(81, 262);
            btnAccept.Margin = new Padding(3, 2, 3, 2);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(93, 30);
            btnAccept.TabIndex = 5;
            btnAccept.Text = "Xác nhận";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DimGray;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(203, 262);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 30);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblCourtID
            // 
            lblCourtID.AutoSize = true;
            lblCourtID.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourtID.Location = new Point(28, 78);
            lblCourtID.Name = "lblCourtID";
            lblCourtID.Size = new Size(68, 30);
            lblCourtID.TabIndex = 7;
            lblCourtID.Text = "Mã sân";
            lblCourtID.UseCompatibleTextRendering = true;
            // 
            // CourtID
            // 
            CourtID.AutoSize = true;
            CourtID.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourtID.Location = new Point(165, 78);
            CourtID.Name = "CourtID";
            CourtID.Size = new Size(68, 30);
            CourtID.TabIndex = 8;
            CourtID.Text = "C00001";
            CourtID.UseCompatibleTextRendering = true;
            // 
            // FormCourtGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CourtID);
            Controls.Add(lblCourtID);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(Status);
            Controls.Add(txtCourtName);
            Controls.Add(lblCourtSTT);
            Controls.Add(lblCourtName);
            Controls.Add(Title);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCourtGUI";
            Size = new Size(367, 383);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label lblCourtName;
        private Label lblCourtSTT;
        private TextBox txtCourtName;
        private ComboBox Status;
        private Button btnAccept;
        private Button btnCancel;
        private Label lblCourtID;
        private Label CourtID;
    }
}
