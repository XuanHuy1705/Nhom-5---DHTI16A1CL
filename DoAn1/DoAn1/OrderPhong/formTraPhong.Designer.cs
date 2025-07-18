namespace DoAn1
{
    partial class formTraPhong
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
            button1 = new Button();
            label1 = new Label();
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
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(592, 135);
            button1.Name = "button1";
            button1.Size = new Size(138, 38);
            button1.TabIndex = 7;
            button1.Text = "Làm mới dữ liệu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(187, 140);
            label1.Name = "label1";
            label1.Size = new Size(336, 25);
            label1.TabIndex = 6;
            label1.Text = "DANH SÁCH PHÒNG ĐÃ ĐƯỢC ĐẶT";
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
            BangKhachHang.Location = new Point(0, 196);
            BangKhachHang.Name = "BangKhachHang";
            BangKhachHang.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            BangKhachHang.Size = new Size(800, 254);
            BangKhachHang.TabIndex = 5;
            BangKhachHang.CellContentClick += BangKhachHang_CellContentClick;
            // 
            // MaPhong
            // 
            MaPhong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaPhong.HeaderText = "Mã Phòng";
            MaPhong.Name = "MaPhong";
            // 
            // MaLoaiPhong
            // 
            MaLoaiPhong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaLoaiPhong.HeaderText = "Mã Loại Phòng";
            MaLoaiPhong.Name = "MaLoaiPhong";
            // 
            // MaKhachHang
            // 
            MaKhachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaKhachHang.HeaderText = "Mã Khách Hàng";
            MaKhachHang.Name = "MaKhachHang";
            // 
            // NgayNhan
            // 
            NgayNhan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgayNhan.HeaderText = "Ngày Nhận";
            NgayNhan.Name = "NgayNhan";
            // 
            // NgayDuKienTra
            // 
            NgayDuKienTra.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgayDuKienTra.HeaderText = "Ngày Dự Kiến Trả";
            NgayDuKienTra.Name = "NgayDuKienTra";
            // 
            // GhiChu
            // 
            GhiChu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GhiChu.HeaderText = "Ghi Chú";
            GhiChu.Name = "GhiChu";
            // 
            // formTraPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(BangKhachHang);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formTraPhong";
            Text = "formTraPhong";
            Load += formTraPhong_Load;
            ((System.ComponentModel.ISupportInitialize)BangKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private DataGridView BangKhachHang;
        private DataGridViewTextBoxColumn MaPhong;
        private DataGridViewTextBoxColumn MaLoaiPhong;
        private DataGridViewTextBoxColumn MaKhachHang;
        private DataGridViewTextBoxColumn NgayNhan;
        private DataGridViewTextBoxColumn NgayDuKienTra;
        private DataGridViewTextBoxColumn GhiChu;
    }
}