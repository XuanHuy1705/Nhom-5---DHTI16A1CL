namespace DoAn1
{
    partial class formDatPhong
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            BangKhachHang = new DataGridView();
            MaPhong = new DataGridViewTextBoxColumn();
            MaLoaiPhong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            TinhTrangPhong = new DataGridViewTextBoxColumn();
            DatPhongMoi = new Button();
            label1 = new Label();
            SuaThongTinDatPhong = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)BangKhachHang).BeginInit();
            SuspendLayout();
            // 
            // BangKhachHang
            // 
            BangKhachHang.AllowUserToAddRows = false;
            BangKhachHang.AllowUserToDeleteRows = false;
            BangKhachHang.AllowUserToResizeColumns = false;
            BangKhachHang.AllowUserToResizeRows = false;
            BangKhachHang.BackgroundColor = SystemColors.ButtonHighlight;
            BangKhachHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            BangKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            BangKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BangKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaPhong, MaLoaiPhong, DonGia, TinhTrangPhong });
            BangKhachHang.Dock = DockStyle.Bottom;
            BangKhachHang.EnableHeadersVisualStyles = false;
            BangKhachHang.Location = new Point(0, 365);
            BangKhachHang.Name = "BangKhachHang";
            BangKhachHang.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            BangKhachHang.RowHeadersVisible = false;
            BangKhachHang.Size = new Size(800, 254);
            BangKhachHang.TabIndex = 0;
            BangKhachHang.CellContentClick += BangKhachHang_CellContentClick;
            // 
            // MaPhong
            // 
            MaPhong.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MaPhong.HeaderText = "Mã Phòng";
            MaPhong.Name = "MaPhong";
            MaPhong.Width = 279;
            // 
            // MaLoaiPhong
            // 
            MaLoaiPhong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaLoaiPhong.HeaderText = "Mã Loại Phòng";
            MaLoaiPhong.Name = "MaLoaiPhong";
            // 
            // DonGia
            // 
            DonGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DonGia.HeaderText = "Đơn Giá";
            DonGia.Name = "DonGia";
            // 
            // TinhTrangPhong
            // 
            TinhTrangPhong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TinhTrangPhong.HeaderText = "Tình Trạng Phòng";
            TinhTrangPhong.Name = "TinhTrangPhong";
            // 
            // DatPhongMoi
            // 
            DatPhongMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DatPhongMoi.Location = new Point(175, 85);
            DatPhongMoi.Name = "DatPhongMoi";
            DatPhongMoi.Size = new Size(201, 96);
            DatPhongMoi.TabIndex = 1;
            DatPhongMoi.Text = "Đặt phòng mới";
            DatPhongMoi.UseVisualStyleBackColor = true;
            DatPhongMoi.Click += DatPhongMoi_Click;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(267, 265);
            label1.Name = "label1";
            label1.Size = new Size(250, 32);
            label1.TabIndex = 2;
            label1.Text = "DANH SÁCH PHÒNG";
            label1.Click += label1_Click;
            // 
            // SuaThongTinDatPhong
            // 
            SuaThongTinDatPhong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SuaThongTinDatPhong.Location = new Point(490, 85);
            SuaThongTinDatPhong.Name = "SuaThongTinDatPhong";
            SuaThongTinDatPhong.Size = new Size(201, 96);
            SuaThongTinDatPhong.TabIndex = 3;
            SuaThongTinDatPhong.Text = "Sửa thông tin phòng";
            SuaThongTinDatPhong.UseVisualStyleBackColor = true;
            SuaThongTinDatPhong.Click += SuaThongTinDatPhong_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(576, 259);
            button1.Name = "button1";
            button1.Size = new Size(143, 38);
            button1.TabIndex = 4;
            button1.Text = "Làm mới dữ liệu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // formDatPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 619);
            Controls.Add(button1);
            Controls.Add(SuaThongTinDatPhong);
            Controls.Add(label1);
            Controls.Add(DatPhongMoi);
            Controls.Add(BangKhachHang);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formDatPhong";
            Text = "formDatPhong";
            Load += formDatPhong_Load;
            ((System.ComponentModel.ISupportInitialize)BangKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView BangKhachHang;
        private Button DatPhongMoi;
        private Label label1;
        private Button SuaThongTinDatPhong;
        private Button button1;
        private DataGridViewTextBoxColumn MaPhong;
        private DataGridViewTextBoxColumn MaLoaiPhong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn TinhTrangPhong;
    }
}