namespace DoAn1
{
    partial class formCapNhatThongTin
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            BangKhachHang = new DataGridView();
            MaKhachHang = new DataGridViewTextBoxColumn();
            TenKhachHang = new DataGridViewTextBoxColumn();
            CMND = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            QuocTich = new DataGridViewTextBoxColumn();
            TimKiem = new TextBox();
            label2 = new Label();
            Check = new Button();
            ViewAll = new Button();
            ThemKhachHang = new Button();
            SuaKhachHang = new Button();
            XoaKhachHang = new Button();
            ThemFile = new Button();
            ((System.ComponentModel.ISupportInitialize)BangKhachHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 43);
            label1.Name = "label1";
            label1.Size = new Size(357, 37);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // BangKhachHang
            // 
            BangKhachHang.AllowUserToAddRows = false;
            BangKhachHang.AllowUserToDeleteRows = false;
            BangKhachHang.AllowUserToResizeColumns = false;
            BangKhachHang.AllowUserToResizeRows = false;
            BangKhachHang.BackgroundColor = SystemColors.ButtonHighlight;
            BangKhachHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            BangKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            BangKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BangKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaKhachHang, TenKhachHang, CMND, GioiTinh, DiaChi, DienThoai, QuocTich });
            BangKhachHang.Dock = DockStyle.Bottom;
            BangKhachHang.EnableHeadersVisualStyles = false;
            BangKhachHang.Location = new Point(0, 379);
            BangKhachHang.Name = "BangKhachHang";
            BangKhachHang.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            BangKhachHang.Size = new Size(800, 230);
            BangKhachHang.TabIndex = 1;
            // 
            // MaKhachHang
            // 
            MaKhachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaKhachHang.HeaderText = "Mã Khách Hàng";
            MaKhachHang.Name = "MaKhachHang";
            // 
            // TenKhachHang
            // 
            TenKhachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenKhachHang.HeaderText = "Tên Khách Hàng";
            TenKhachHang.Name = "TenKhachHang";
            // 
            // CMND
            // 
            CMND.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CMND.HeaderText = "CMND";
            CMND.Name = "CMND";
            // 
            // GioiTinh
            // 
            GioiTinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GioiTinh.HeaderText = "Giới Tính";
            GioiTinh.Name = "GioiTinh";
            // 
            // DiaChi
            // 
            DiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.Name = "DiaChi";
            // 
            // DienThoai
            // 
            DienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DienThoai.HeaderText = "Điện Thoại";
            DienThoai.Name = "DienThoai";
            // 
            // QuocTich
            // 
            QuocTich.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            QuocTich.HeaderText = "Quốc Tịch";
            QuocTich.Name = "QuocTich";
            // 
            // TimKiem
            // 
            TimKiem.Location = new Point(367, 312);
            TimKiem.Name = "TimKiem";
            TimKiem.Size = new Size(242, 23);
            TimKiem.TabIndex = 3;
            TimKiem.TextChanged += TimKiem_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(282, 313);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 4;
            label2.Text = "Tìm kiếm";
            label2.Click += label2_Click;
            // 
            // Check
            // 
            Check.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Check.Location = new Point(638, 313);
            Check.Name = "Check";
            Check.Size = new Size(75, 23);
            Check.TabIndex = 5;
            Check.Text = "Kiểm tra";
            Check.UseVisualStyleBackColor = true;
            Check.Click += Check_Click;
            // 
            // ViewAll
            // 
            ViewAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewAll.Location = new Point(719, 313);
            ViewAll.Name = "ViewAll";
            ViewAll.Size = new Size(75, 23);
            ViewAll.TabIndex = 6;
            ViewAll.Text = "Làm mới";
            ViewAll.UseVisualStyleBackColor = true;
            ViewAll.Click += ViewAll_Click;
            // 
            // ThemKhachHang
            // 
            ThemKhachHang.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemKhachHang.Location = new Point(161, 124);
            ThemKhachHang.Name = "ThemKhachHang";
            ThemKhachHang.Size = new Size(150, 81);
            ThemKhachHang.TabIndex = 7;
            ThemKhachHang.Text = "Thêm khách hàng";
            ThemKhachHang.UseVisualStyleBackColor = true;
            ThemKhachHang.Click += ThemKhachHang_Click;
            // 
            // SuaKhachHang
            // 
            SuaKhachHang.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SuaKhachHang.Location = new Point(529, 124);
            SuaKhachHang.Name = "SuaKhachHang";
            SuaKhachHang.Size = new Size(143, 81);
            SuaKhachHang.TabIndex = 8;
            SuaKhachHang.Text = "Sửa thông tin khách hàng";
            SuaKhachHang.UseVisualStyleBackColor = true;
            SuaKhachHang.Click += SuaKhachHang_Click;
            // 
            // XoaKhachHang
            // 
            XoaKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            XoaKhachHang.Location = new Point(662, 284);
            XoaKhachHang.Name = "XoaKhachHang";
            XoaKhachHang.Size = new Size(117, 23);
            XoaKhachHang.TabIndex = 9;
            XoaKhachHang.Text = "Xóa khách hàng";
            XoaKhachHang.UseVisualStyleBackColor = true;
            XoaKhachHang.Click += XoaKhachHang_Click;
            // 
            // ThemFile
            // 
            ThemFile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemFile.Location = new Point(347, 124);
            ThemFile.Name = "ThemFile";
            ThemFile.Size = new Size(154, 81);
            ThemFile.TabIndex = 10;
            ThemFile.Text = "Thêm Thông Tin Từ Danh Sách Bên Ngoài";
            ThemFile.UseVisualStyleBackColor = true;
            ThemFile.Click += ThemFile_Click;
            // 
            // formCapNhatThongTin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 609);
            Controls.Add(ThemFile);
            Controls.Add(XoaKhachHang);
            Controls.Add(SuaKhachHang);
            Controls.Add(ThemKhachHang);
            Controls.Add(ViewAll);
            Controls.Add(Check);
            Controls.Add(label2);
            Controls.Add(TimKiem);
            Controls.Add(BangKhachHang);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formCapNhatThongTin";
            Text = "formCapNhatThongTin";
            Load += formCapNhatThongTin_Load;
            ((System.ComponentModel.ISupportInitialize)BangKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView BangKhachHang;
        private DataGridViewTextBoxColumn MaKhachHang;
        private DataGridViewTextBoxColumn TenKhachHang;
        private DataGridViewTextBoxColumn CMND;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn QuocTich;
        private TextBox TimKiem;
        private Label label2;
        private Button Check;
        private Button ViewAll;
        private Button ThemKhachHang;
        private Button SuaKhachHang;
        private Button XoaKhachHang;
        private Button ThemFile;
    }
}