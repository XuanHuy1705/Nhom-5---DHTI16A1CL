namespace DoAn1.OrderPhong
{
    partial class formThemThongTinDatPhong
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
            MaLoaiPhong = new ComboBox();
            label2 = new Label();
            NgayNhan = new DateTimePicker();
            NgayDuKienTra = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            GhiChu = new TextBox();
            label6 = new Label();
            Check = new Button();
            MaPhong = new ComboBox();
            label7 = new Label();
            MaKhachHang = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 110);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 0;
            label1.Text = "Mã Phòng";
            // 
            // MaLoaiPhong
            // 
            MaLoaiPhong.FormattingEnabled = true;
            MaLoaiPhong.Location = new Point(181, 63);
            MaLoaiPhong.Margin = new Padding(4, 3, 4, 3);
            MaLoaiPhong.Name = "MaLoaiPhong";
            MaLoaiPhong.Size = new Size(246, 23);
            MaLoaiPhong.TabIndex = 2;
            MaLoaiPhong.SelectedIndexChanged += MaLoaiPhong_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 68);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 17);
            label2.TabIndex = 3;
            label2.Text = "Mã Loại Phòng";
            // 
            // NgayNhan
            // 
            NgayNhan.Location = new Point(180, 179);
            NgayNhan.Margin = new Padding(4, 3, 4, 3);
            NgayNhan.Name = "NgayNhan";
            NgayNhan.Size = new Size(247, 21);
            NgayNhan.TabIndex = 4;
            // 
            // NgayDuKienTra
            // 
            NgayDuKienTra.Location = new Point(180, 227);
            NgayDuKienTra.Margin = new Padding(4, 3, 4, 3);
            NgayDuKienTra.Name = "NgayDuKienTra";
            NgayDuKienTra.Size = new Size(247, 21);
            NgayDuKienTra.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 182);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 6;
            label3.Text = "Ngày Nhận";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 227);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 17);
            label4.TabIndex = 7;
            label4.Text = "Ngày Dự Kiến Trả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 280);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 17);
            label5.TabIndex = 8;
            label5.Text = "Ghi chú";
            // 
            // GhiChu
            // 
            GhiChu.Location = new Point(180, 268);
            GhiChu.Margin = new Padding(4, 3, 4, 3);
            GhiChu.Multiline = true;
            GhiChu.Name = "GhiChu";
            GhiChu.Size = new Size(247, 50);
            GhiChu.TabIndex = 9;
            GhiChu.TextChanged += GhiChu_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(196, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(138, 30);
            label6.TabIndex = 10;
            label6.Text = "ĐẶT PHÒNG";
            // 
            // Check
            // 
            Check.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Check.Location = new Point(219, 334);
            Check.Name = "Check";
            Check.Size = new Size(105, 37);
            Check.TabIndex = 11;
            Check.Text = "Xác nhận";
            Check.UseVisualStyleBackColor = true;
            Check.Click += Check_Click;
            // 
            // MaPhong
            // 
            MaPhong.FormattingEnabled = true;
            MaPhong.Location = new Point(181, 104);
            MaPhong.Margin = new Padding(4, 3, 4, 3);
            MaPhong.Name = "MaPhong";
            MaPhong.Size = new Size(246, 23);
            MaPhong.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(38, 146);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(102, 17);
            label7.TabIndex = 13;
            label7.Text = "Mã khách hàng";
            // 
            // MaKhachHang
            // 
            MaKhachHang.Location = new Point(182, 144);
            MaKhachHang.Name = "MaKhachHang";
            MaKhachHang.Size = new Size(245, 21);
            MaKhachHang.TabIndex = 14;
            // 
            // formThemThongTinDatPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 393);
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
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "formThemThongTinDatPhong";
            Text = "Đặt phòng";
            Load += formThemThongTinDatPhong_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox MaLoaiPhong;
        private Label label2;
        private DateTimePicker NgayNhan;
        private DateTimePicker NgayDuKienTra;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox GhiChu;
        private Label label6;
        private Button Check;
        private ComboBox MaPhong;
        private Label label7;
        private TextBox MaKhachHang;
    }
}