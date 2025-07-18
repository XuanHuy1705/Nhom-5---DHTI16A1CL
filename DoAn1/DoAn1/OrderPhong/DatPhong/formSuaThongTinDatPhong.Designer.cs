namespace DoAn1.OrderPhong
{
    partial class formSuaThongTinDatPhong
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
            MaPhong = new ComboBox();
            Check = new Button();
            label6 = new Label();
            GhiChu = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            NgayDuKienTra = new DateTimePicker();
            NgayNhan = new DateTimePicker();
            label2 = new Label();
            MaLoaiPhong = new ComboBox();
            label1 = new Label();
            MaKhachHang = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // MaPhong
            // 
            MaPhong.FormattingEnabled = true;
            MaPhong.Location = new Point(166, 151);
            MaPhong.Margin = new Padding(4, 3, 4, 3);
            MaPhong.Name = "MaPhong";
            MaPhong.Size = new Size(247, 23);
            MaPhong.TabIndex = 24;
            // 
            // Check
            // 
            Check.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Check.Location = new Point(204, 400);
            Check.Name = "Check";
            Check.Size = new Size(105, 37);
            Check.TabIndex = 23;
            Check.Text = "Xác nhận";
            Check.UseVisualStyleBackColor = true;
            Check.Click += Check_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(155, 37);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(180, 30);
            label6.TabIndex = 22;
            label6.Text = "SỬA THÔNG TIN";
            // 
            // GhiChu
            // 
            GhiChu.Location = new Point(165, 311);
            GhiChu.Margin = new Padding(4, 3, 4, 3);
            GhiChu.Multiline = true;
            GhiChu.Name = "GhiChu";
            GhiChu.Size = new Size(247, 50);
            GhiChu.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 323);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 17);
            label5.TabIndex = 20;
            label5.Text = "Ghi chú";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 270);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 17);
            label4.TabIndex = 19;
            label4.Text = "Ngày Dự Kiến Trả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 225);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 18;
            label3.Text = "Ngày Nhận";
            // 
            // NgayDuKienTra
            // 
            NgayDuKienTra.Location = new Point(165, 270);
            NgayDuKienTra.Margin = new Padding(4, 3, 4, 3);
            NgayDuKienTra.Name = "NgayDuKienTra";
            NgayDuKienTra.Size = new Size(247, 23);
            NgayDuKienTra.TabIndex = 17;
            // 
            // NgayNhan
            // 
            NgayNhan.Location = new Point(165, 222);
            NgayNhan.Margin = new Padding(4, 3, 4, 3);
            NgayNhan.Name = "NgayNhan";
            NgayNhan.Size = new Size(247, 23);
            NgayNhan.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 115);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 17);
            label2.TabIndex = 15;
            label2.Text = "Mã Loại Phòng";
            // 
            // MaLoaiPhong
            // 
            MaLoaiPhong.FormattingEnabled = true;
            MaLoaiPhong.Location = new Point(166, 110);
            MaLoaiPhong.Margin = new Padding(4, 3, 4, 3);
            MaLoaiPhong.Name = "MaLoaiPhong";
            MaLoaiPhong.Size = new Size(247, 23);
            MaLoaiPhong.TabIndex = 14;
            MaLoaiPhong.SelectedIndexChanged += MaLoaiPhong_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 157);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 13;
            label1.Text = "Mã Phòng";
            // 
            // MaKhachHang
            // 
            MaKhachHang.Location = new Point(165, 187);
            MaKhachHang.Name = "MaKhachHang";
            MaKhachHang.Size = new Size(245, 23);
            MaKhachHang.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 189);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(102, 17);
            label7.TabIndex = 25;
            label7.Text = "Mã khách hàng";
            // 
            // formSuaThongTinDatPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 450);
            Controls.Add(MaKhachHang);
            Controls.Add(label7);
            Controls.Add(MaPhong);
            Controls.Add(Check);
            Controls.Add(label6);
            Controls.Add(GhiChu);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(NgayDuKienTra);
            Controls.Add(NgayNhan);
            Controls.Add(label2);
            Controls.Add(MaLoaiPhong);
            Controls.Add(label1);
            Name = "formSuaThongTinDatPhong";
            Text = "formSuaThongTinDatPhong";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox MaPhong;
        private Button Check;
        private Label label6;
        private TextBox GhiChu;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker NgayDuKienTra;
        private DateTimePicker NgayNhan;
        private Label label2;
        private ComboBox MaLoaiPhong;
        private Label label1;
        private TextBox MaKhachHang;
        private Label label7;
    }
}