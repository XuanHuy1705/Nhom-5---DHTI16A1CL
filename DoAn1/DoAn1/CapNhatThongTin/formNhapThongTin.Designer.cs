namespace DoAn1
{
    partial class formNhapThongTin
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
            TenKhachHang = new TextBox();
            CMND = new TextBox();
            DiaChi = new TextBox();
            DienThoai = new TextBox();
            QuocTich = new TextBox();
            GioiTinh = new ComboBox();
            LuuThongTin = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            MaKhachHang = new TextBox();
            SuspendLayout();
            // 
            // TenKhachHang
            // 
            TenKhachHang.Location = new Point(175, 57);
            TenKhachHang.Name = "TenKhachHang";
            TenKhachHang.Size = new Size(287, 23);
            TenKhachHang.TabIndex = 0;
            // 
            // CMND
            // 
            CMND.Location = new Point(176, 108);
            CMND.Name = "CMND";
            CMND.Size = new Size(287, 23);
            CMND.TabIndex = 1;
            // 
            // DiaChi
            // 
            DiaChi.Location = new Point(176, 159);
            DiaChi.Name = "DiaChi";
            DiaChi.Size = new Size(287, 23);
            DiaChi.TabIndex = 2;
            // 
            // DienThoai
            // 
            DienThoai.Location = new Point(176, 209);
            DienThoai.Name = "DienThoai";
            DienThoai.Size = new Size(287, 23);
            DienThoai.TabIndex = 3;
            // 
            // QuocTich
            // 
            QuocTich.Location = new Point(176, 261);
            QuocTich.Name = "QuocTich";
            QuocTich.Size = new Size(287, 23);
            QuocTich.TabIndex = 4;
            // 
            // GioiTinh
            // 
            GioiTinh.FormattingEnabled = true;
            GioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            GioiTinh.Location = new Point(175, 313);
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Size = new Size(121, 23);
            GioiTinh.TabIndex = 5;
            GioiTinh.Text = "Chọn giới tính";
            // 
            // LuuThongTin
            // 
            LuuThongTin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LuuThongTin.Location = new Point(205, 378);
            LuuThongTin.Name = "LuuThongTin";
            LuuThongTin.Size = new Size(117, 39);
            LuuThongTin.TabIndex = 6;
            LuuThongTin.Text = "Lưu";
            LuuThongTin.UseVisualStyleBackColor = true;
            LuuThongTin.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 64);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 7;
            label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 116);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 8;
            label2.Text = "CCCD/CMND";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 167);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 9;
            label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 217);
            label4.Name = "label4";
            label4.Size = new Size(61, 13);
            label4.TabIndex = 10;
            label4.Text = "Điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 267);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 11;
            label5.Text = "Quốc tịch";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(45, 321);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 12;
            label6.Text = "Giới tính";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(45, 19);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 14;
            label7.Text = "Mã khách hàng";
            label7.Click += label7_Click;
            // 
            // MaKhachHang
            // 
            MaKhachHang.Location = new Point(175, 12);
            MaKhachHang.Name = "MaKhachHang";
            MaKhachHang.Size = new Size(287, 23);
            MaKhachHang.TabIndex = 13;
            // 
            // formNhapThongTin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 450);
            Controls.Add(label7);
            Controls.Add(MaKhachHang);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LuuThongTin);
            Controls.Add(GioiTinh);
            Controls.Add(QuocTich);
            Controls.Add(DienThoai);
            Controls.Add(DiaChi);
            Controls.Add(CMND);
            Controls.Add(TenKhachHang);
            Name = "formNhapThongTin";
            Text = "Nhập thông tin người dùng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TenKhachHang;
        private TextBox CMND;
        private TextBox DiaChi;
        private TextBox DienThoai;
        private TextBox QuocTich;
        private ComboBox GioiTinh;
        private Button LuuThongTin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox MaKhachHang;
    }
}