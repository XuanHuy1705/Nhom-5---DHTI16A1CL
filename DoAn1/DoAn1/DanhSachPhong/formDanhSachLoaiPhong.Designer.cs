namespace DoAn1.DanhSachPhong
{
    partial class formDanhSachLoaiPhong
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
            label1 = new Label();
            BangLoaiPhong = new DataGridView();
            MaLoaiPhong = new DataGridViewTextBoxColumn();
            TenLoaiPhong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            SoNguoiChuan = new DataGridViewTextBoxColumn();
            SoNguoiToiDa = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)BangLoaiPhong).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 19);
            label1.Name = "label1";
            label1.Size = new Size(275, 30);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH LOẠI PHÒNG";
            // 
            // BangLoaiPhong
            // 
            BangLoaiPhong.AllowUserToAddRows = false;
            BangLoaiPhong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            BangLoaiPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            BangLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            BangLoaiPhong.Columns.AddRange(new DataGridViewColumn[] { MaLoaiPhong, TenLoaiPhong, DonGia, SoNguoiChuan, SoNguoiToiDa });
            BangLoaiPhong.Dock = DockStyle.Bottom;
            BangLoaiPhong.Location = new Point(0, 78);
            BangLoaiPhong.Name = "BangLoaiPhong";
            BangLoaiPhong.RowHeadersVisible = false;
            BangLoaiPhong.Size = new Size(562, 351);
            BangLoaiPhong.TabIndex = 1;
            BangLoaiPhong.CellContentClick += BangLoaiPhong_CellContentClick;
            // 
            // MaLoaiPhong
            // 
            MaLoaiPhong.HeaderText = "Mã Loại Phòng";
            MaLoaiPhong.Name = "MaLoaiPhong";
            // 
            // TenLoaiPhong
            // 
            TenLoaiPhong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenLoaiPhong.HeaderText = "Tên Loại Phòng";
            TenLoaiPhong.Name = "TenLoaiPhong";
            // 
            // DonGia
            // 
            DonGia.HeaderText = "Đơn Giá";
            DonGia.Name = "DonGia";
            // 
            // SoNguoiChuan
            // 
            SoNguoiChuan.HeaderText = "Số Người Chuẩn";
            SoNguoiChuan.Name = "SoNguoiChuan";
            // 
            // SoNguoiToiDa
            // 
            SoNguoiToiDa.HeaderText = "Số Người Tối Đa";
            SoNguoiToiDa.Name = "SoNguoiToiDa";
            // 
            // formDanhSachLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 429);
            Controls.Add(BangLoaiPhong);
            Controls.Add(label1);
            Name = "formDanhSachLoaiPhong";
            Text = "Danh Sách Loại Phòng";
            Load += formDanhSachLoaiPhong_Load;
            ((System.ComponentModel.ISupportInitialize)BangLoaiPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView BangLoaiPhong;
        private DataGridViewTextBoxColumn MaLoaiPhong;
        private DataGridViewTextBoxColumn TenLoaiPhong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn SoNguoiChuan;
        private DataGridViewTextBoxColumn SoNguoiToiDa;
    }
}