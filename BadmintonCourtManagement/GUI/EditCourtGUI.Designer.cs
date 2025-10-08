namespace BadmintonCourtManagement.GUI
{
    partial class EditCourtGUI
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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            btnAccept = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(146, 29);
            Title.Name = "Title";
            Title.Size = new Size(123, 47);
            Title.TabIndex = 0;
            Title.Text = "Sửa sân";
            Title.UseCompatibleTextRendering = true;
            // 
            // lblCourtName
            // 
            lblCourtName.AutoSize = true;
            lblCourtName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourtName.Location = new Point(42, 100);
            lblCourtName.Name = "lblCourtName";
            lblCourtName.Size = new Size(91, 37);
            lblCourtName.TabIndex = 1;
            lblCourtName.Text = "Tên sân";
            lblCourtName.UseCompatibleTextRendering = true;
            // 
            // lblCourtSTT
            // 
            lblCourtSTT.AutoSize = true;
            lblCourtSTT.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourtSTT.Location = new Point(42, 177);
            lblCourtSTT.Name = "lblCourtSTT";
            lblCourtSTT.Size = new Size(118, 37);
            lblCourtSTT.TabIndex = 2;
            lblCourtSTT.Text = "Trạng thái";
            lblCourtSTT.UseCompatibleTextRendering = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 100);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 28);
            textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(172, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(209, 28);
            comboBox1.TabIndex = 4;
            //comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.IndianRed;
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(103, 270);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(106, 40);
            btnAccept.TabIndex = 5;
            btnAccept.Text = "Xác nhận";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DimGray;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(231, 270);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 40);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditCourtGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(lblCourtSTT);
            Controls.Add(lblCourtName);
            Controls.Add(Title);
            Name = "EditCourtGUI";
            Size = new Size(419, 417);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label lblCourtName;
        private Label lblCourtSTT;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button btnAccept;
        private Button btnCancel;
    }
}
