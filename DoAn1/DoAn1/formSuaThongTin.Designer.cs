namespace DoAn1
{
    partial class formSuaThongTin
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
            label7 = new Label();
            MaKhachHang = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            GioiTinh = new ComboBox();
            QuocTich = new TextBox();
            DienThoai = new TextBox();
            DiaChi = new TextBox();
            CMND = new TextBox();
            TenKhachHang = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(86, 58);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 28;
            label7.Text = "Mã khách hàng";
            // 
            // MaKhachHang
            // 
            MaKhachHang.Location = new Point(216, 51);
            MaKhachHang.Name = "MaKhachHang";
            MaKhachHang.Size = new Size(287, 23);
            MaKhachHang.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(86, 360);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 26;
            label6.Text = "Giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(86, 306);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 25;
            label5.Text = "Quốc tịch";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(86, 256);
            label4.Name = "label4";
            label4.Size = new Size(61, 13);
            label4.TabIndex = 24;
            label4.Text = "Điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(86, 206);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 23;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 155);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 22;
            label2.Text = "CCCD/CMND";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 103);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 21;
            label1.Text = "Tên khách hàng";
            // 
            // GioiTinh
            // 
            GioiTinh.FormattingEnabled = true;
            GioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            GioiTinh.Location = new Point(216, 352);
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Size = new Size(121, 23);
            GioiTinh.TabIndex = 20;
            GioiTinh.Text = "Chọn giới tính";
            // 
            // QuocTich
            // 
            QuocTich.Location = new Point(217, 300);
            QuocTich.Name = "QuocTich";
            QuocTich.Size = new Size(287, 23);
            QuocTich.TabIndex = 19;
            // 
            // DienThoai
            // 
            DienThoai.Location = new Point(217, 248);
            DienThoai.Name = "DienThoai";
            DienThoai.Size = new Size(287, 23);
            DienThoai.TabIndex = 18;
            // 
            // DiaChi
            // 
            DiaChi.Location = new Point(217, 198);
            DiaChi.Name = "DiaChi";
            DiaChi.Size = new Size(287, 23);
            DiaChi.TabIndex = 17;
            // 
            // CMND
            // 
            CMND.Location = new Point(217, 147);
            CMND.Name = "CMND";
            CMND.Size = new Size(287, 23);
            CMND.TabIndex = 16;
            // 
            // TenKhachHang
            // 
            TenKhachHang.Location = new Point(216, 96);
            TenKhachHang.Name = "TenKhachHang";
            TenKhachHang.Size = new Size(287, 23);
            TenKhachHang.TabIndex = 15;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(262, 397);
            button1.Name = "button1";
            button1.Size = new Size(148, 41);
            button1.TabIndex = 29;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // formSuaThongTin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 450);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(MaKhachHang);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GioiTinh);
            Controls.Add(QuocTich);
            Controls.Add(DienThoai);
            Controls.Add(DiaChi);
            Controls.Add(CMND);
            Controls.Add(TenKhachHang);
            Name = "formSuaThongTin";
            Text = "Sửa thông tin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        public TextBox MaKhachHang;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public ComboBox GioiTinh;
        public TextBox QuocTich;
        public TextBox DienThoai;
        public TextBox DiaChi;
        public TextBox CMND;
        public TextBox TenKhachHang;
        private Button button1;
    }
}