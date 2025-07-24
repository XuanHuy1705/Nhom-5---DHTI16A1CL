namespace DoAn1.OrderPhong
{
    partial class formChonPhongSuaThongTin
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
            label2 = new Label();
            MaPhong = new ComboBox();
            XacNhan = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 37);
            label1.Name = "label1";
            label1.Size = new Size(298, 25);
            label1.TabIndex = 0;
            label1.Text = "CHỌN PHÒNG SỬA THÔNG TIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(99, 104);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã phòng";
            // 
            // MaPhong
            // 
            MaPhong.FormattingEnabled = true;
            MaPhong.Location = new Point(196, 97);
            MaPhong.Name = "MaPhong";
            MaPhong.Size = new Size(159, 23);
            MaPhong.TabIndex = 2;
            // 
            // XacNhan
            // 
            XacNhan.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            XacNhan.Location = new Point(210, 163);
            XacNhan.Name = "XacNhan";
            XacNhan.Size = new Size(94, 32);
            XacNhan.TabIndex = 3;
            XacNhan.Text = "Xác nhận";
            XacNhan.UseVisualStyleBackColor = true;
            XacNhan.Click += XacNhan_Click;
            // 
            // formChonPhongSuaThongTin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 241);
            Controls.Add(XacNhan);
            Controls.Add(MaPhong);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formChonPhongSuaThongTin";
            Text = "Chọn Phòng Sửa Thông Tin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox MaPhong;
        private Button XacNhan;
    }
}