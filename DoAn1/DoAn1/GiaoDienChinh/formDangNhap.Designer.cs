namespace DoAn1
{
    partial class formDangNhap
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
            DangNhap = new Button();
            label1 = new Label();
            TaiKhoan = new TextBox();
            MatKhau = new TextBox();
            label2 = new Label();
            label3 = new Label();
            DangKy = new Button();
            SuspendLayout();
            // 
            // DangNhap
            // 
            DangNhap.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DangNhap.Location = new Point(140, 282);
            DangNhap.Name = "DangNhap";
            DangNhap.Size = new Size(99, 42);
            DangNhap.TabIndex = 0;
            DangNhap.Text = "Đăng nhập";
            DangNhap.UseVisualStyleBackColor = true;
            DangNhap.Click += DangNhap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 65);
            label1.Name = "label1";
            label1.Size = new Size(357, 30);
            label1.TabIndex = 1;
            label1.Text = "Quản lý cho thuê phòng khách sạn";
            // 
            // TaiKhoan
            // 
            TaiKhoan.Location = new Point(140, 149);
            TaiKhoan.Name = "TaiKhoan";
            TaiKhoan.Size = new Size(233, 23);
            TaiKhoan.TabIndex = 2;
            // 
            // MatKhau
            // 
            MatKhau.Location = new Point(140, 214);
            MatKhau.Name = "MatKhau";
            MatKhau.Size = new Size(233, 23);
            MatKhau.TabIndex = 3;
            MatKhau.UseSystemPasswordChar = true;
            MatKhau.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 150);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 4;
            label2.Text = "Tài khoản";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 223);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 5;
            label3.Text = "Mật khẩu";
            // 
            // DangKy
            // 
            DangKy.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DangKy.Location = new Point(274, 282);
            DangKy.Name = "DangKy";
            DangKy.Size = new Size(99, 42);
            DangKy.TabIndex = 6;
            DangKy.Text = "Đăng ký";
            DangKy.UseVisualStyleBackColor = true;
            DangKy.Click += DangKy_Click;
            // 
            // formDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 450);
            Controls.Add(DangKy);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(MatKhau);
            Controls.Add(TaiKhoan);
            Controls.Add(label1);
            Controls.Add(DangNhap);
            Name = "formDangNhap";
            Text = "formDangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DangNhap;
        private Label label1;
        private TextBox TaiKhoan;
        private TextBox MatKhau;
        private Label label2;
        private Label label3;
        private Button DangKy;
    }
}