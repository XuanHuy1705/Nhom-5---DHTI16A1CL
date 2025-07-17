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
            MaKhachHang = new DataGridViewTextBoxColumn();
            NgayNhan = new DataGridViewTextBoxColumn();
            NgayDuKienTra = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
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
            BangKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaPhong, MaLoaiPhong, MaKhachHang, NgayNhan, NgayDuKienTra, GhiChu });
            BangKhachHang.Dock = DockStyle.Bottom;
            BangKhachHang.EnableHeadersVisualStyles = false;
            BangKhachHang.Location = new Point(0, 177);
            BangKhachHang.Name = "BangKhachHang";
            BangKhachHang.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            BangKhachHang.Size = new Size(800, 273);
            BangKhachHang.TabIndex = 0;
            BangKhachHang.CellContentClick += BangKhachHang_CellContentClick;
            // 
            // MaPhong
            // 
            MaPhong.HeaderText = "Mã Phòng";
            MaPhong.Name = "MaPhong";
            // 
            // MaLoaiPhong
            // 
            MaLoaiPhong.HeaderText = "Mã Loại Phòng";
            MaLoaiPhong.Name = "MaLoaiPhong";
            // 
            // MaKhachHang
            // 
            MaKhachHang.HeaderText = "Mã Khách Hàng";
            MaKhachHang.Name = "MaKhachHang";
            // 
            // NgayNhan
            // 
            NgayNhan.HeaderText = "Ngày Nhận";
            NgayNhan.Name = "NgayNhan";
            // 
            // NgayDuKienTra
            // 
            NgayDuKienTra.HeaderText = "Ngày Dự Kiến Trả";
            NgayDuKienTra.Name = "NgayDuKienTra";
            // 
            // GhiChu
            // 
            GhiChu.HeaderText = "Ghi Chú";
            GhiChu.Name = "GhiChu";
            // 
            // formDatPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BangKhachHang);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formDatPhong";
            Text = "formDatPhong";
            Load += formDatPhong_Load;
            ((System.ComponentModel.ISupportInitialize)BangKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView BangKhachHang;
        private DataGridViewTextBoxColumn MaPhong;
        private DataGridViewTextBoxColumn MaLoaiPhong;
        private DataGridViewTextBoxColumn MaKhachHang;
        private DataGridViewTextBoxColumn NgayNhan;
        private DataGridViewTextBoxColumn NgayDuKienTra;
        private DataGridViewTextBoxColumn GhiChu;
    }
}