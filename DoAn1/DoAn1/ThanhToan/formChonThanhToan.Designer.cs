namespace DoAn1
{
    partial class formChonThanhToan
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
            label1 = new Label();
            ChonMaPhong = new ComboBox();
            ThanhToan = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 112);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Phòng";
            // 
            // ChonMaPhong
            // 
            ChonMaPhong.FormattingEnabled = true;
            ChonMaPhong.Location = new Point(188, 111);
            ChonMaPhong.Name = "ChonMaPhong";
            ChonMaPhong.Size = new Size(174, 23);
            ChonMaPhong.TabIndex = 1;
            // 
            // ThanhToan
            // 
            ThanhToan.Location = new Point(216, 164);
            ThanhToan.Name = "ThanhToan";
            ThanhToan.Size = new Size(104, 35);
            ThanhToan.TabIndex = 2;
            ThanhToan.Text = "Thanh Toán";
            ThanhToan.UseVisualStyleBackColor = true;
            ThanhToan.Click += ThanhToan_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(123, 30);
            label2.Name = "label2";
            label2.Size = new Size(273, 30);
            label2.TabIndex = 3;
            label2.Text = "XÁC NHẬN THANH TOÁN";
            // 
            // formChonThanhToan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 237);
            Controls.Add(label2);
            Controls.Add(ThanhToan);
            Controls.Add(ChonMaPhong);
            Controls.Add(label1);
            Name = "formChonThanhToan";
            Text = "Chọn Phòng Thanh Toán";
            Load += formChonThanhToan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox ChonMaPhong;
        private Button ThanhToan;
        private Label label2;
    }
}