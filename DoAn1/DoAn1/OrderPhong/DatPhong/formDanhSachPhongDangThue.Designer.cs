﻿namespace DoAn1.OrderPhong.DatPhong
{
    partial class formDanhSachPhongDangThue
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            MaPhong = new DataGridViewTextBoxColumn();
            MaLoaiPhong = new DataGridViewTextBoxColumn();
            MaKhachHang = new DataGridViewTextBoxColumn();
            NgayNhan = new DataGridViewTextBoxColumn();
            NgayDuKienTra = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            label1 = new Label();
            XuatDuLieu = new Button();
            ThemDuLieu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaPhong, MaLoaiPhong, MaKhachHang, NgayNhan, NgayDuKienTra, GhiChu });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(601, 284);
            dataGridView1.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 32);
            label1.Name = "label1";
            label1.Size = new Size(475, 32);
            label1.TabIndex = 1;
            label1.Text = "DANH SÁCH PHÒNG ĐANG ĐƯỢC THUÊ";
            // 
            // XuatDuLieu
            // 
            XuatDuLieu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            XuatDuLieu.Location = new Point(480, 83);
            XuatDuLieu.Name = "XuatDuLieu";
            XuatDuLieu.Size = new Size(109, 26);
            XuatDuLieu.TabIndex = 2;
            XuatDuLieu.Text = "Xuất Dữ Liệu";
            XuatDuLieu.UseVisualStyleBackColor = true;
            XuatDuLieu.Click += XuatDuLieu_Click;
            // 
            // ThemDuLieu
            // 
            ThemDuLieu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemDuLieu.Location = new Point(350, 83);
            ThemDuLieu.Name = "ThemDuLieu";
            ThemDuLieu.Size = new Size(109, 26);
            ThemDuLieu.TabIndex = 3;
            ThemDuLieu.Text = "Thêm Dữ Liệu";
            ThemDuLieu.UseVisualStyleBackColor = true;
            ThemDuLieu.Click += ThemDuLieu_Click;
            // 
            // formDanhSachPhongDangThue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 399);
            Controls.Add(ThemDuLieu);
            Controls.Add(XuatDuLieu);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "formDanhSachPhongDangThue";
            Text = "Danh Sách Phòng Đang Được Thuê";
            Load += formDanhSachPhongDangThue_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button XuatDuLieu;
        private Button ThemDuLieu;
        private DataGridViewTextBoxColumn MaPhong;
        private DataGridViewTextBoxColumn MaLoaiPhong;
        private DataGridViewTextBoxColumn MaKhachHang;
        private DataGridViewTextBoxColumn NgayNhan;
        private DataGridViewTextBoxColumn NgayDuKienTra;
        private DataGridViewTextBoxColumn GhiChu;
    }
}