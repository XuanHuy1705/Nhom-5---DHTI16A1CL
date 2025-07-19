namespace DoAn1.GiaoDienChinh
{
    partial class formDangKy
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
            label3 = new Label();
            TenDangNhap = new TextBox();
            MatKhau = new TextBox();
            DangKy = new Button();
            label4 = new Label();
            NguoiDung = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 48);
            label1.Name = "label1";
            label1.Size = new Size(253, 30);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÝ NGƯỜI DÙNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 122);
            label2.Name = "label2";
            label2.Size = new Size(104, 17);
            label2.TabIndex = 1;
            label2.Text = "Tên Đăng Nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 174);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 2;
            label3.Text = "Mật Khẩu";
            // 
            // TenDangNhap
            // 
            TenDangNhap.Location = new Point(170, 116);
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.Size = new Size(201, 23);
            TenDangNhap.TabIndex = 3;
            // 
            // MatKhau
            // 
            MatKhau.Location = new Point(170, 168);
            MatKhau.Name = "MatKhau";
            MatKhau.Size = new Size(201, 23);
            MatKhau.TabIndex = 4;
            // 
            // DangKy
            // 
            DangKy.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DangKy.Location = new Point(221, 253);
            DangKy.Name = "DangKy";
            DangKy.Size = new Size(101, 33);
            DangKy.TabIndex = 5;
            DangKy.Text = "Đăng Ký";
            DangKy.UseVisualStyleBackColor = true;
            DangKy.Click += DangKy_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 218);
            label4.Name = "label4";
            label4.Size = new Size(85, 17);
            label4.TabIndex = 6;
            label4.Text = "Người Dùng";
            // 
            // NguoiDung
            // 
            NguoiDung.FormattingEnabled = true;
            NguoiDung.Items.AddRange(new object[] { "Nhân Viên Khách Sạn", "Quản Trị Hệ Thống", "Khách Hàng" });
            NguoiDung.Location = new Point(171, 211);
            NguoiDung.Name = "NguoiDung";
            NguoiDung.Size = new Size(200, 23);
            NguoiDung.TabIndex = 7;
            // 
            // formDangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 309);
            Controls.Add(NguoiDung);
            Controls.Add(label4);
            Controls.Add(DangKy);
            Controls.Add(MatKhau);
            Controls.Add(TenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formDangKy";
            Text = "Đăng ký người dùng mới";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TenDangNhap;
        private TextBox MatKhau;
        private Button DangKy;
        private Label label4;
        private ComboBox NguoiDung;
    }
}