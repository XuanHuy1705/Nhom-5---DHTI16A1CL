namespace DoAn1
{
    partial class formThanhToan
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
            dataGridViewHoaDon = new DataGridView();
            MaHoaDon = new DataGridViewTextBoxColumn();
            MaPhong = new DataGridViewTextBoxColumn();
            MaKhach = new DataGridViewTextBoxColumn();
            NgayNhan = new DataGridViewTextBoxColumn();
            NgayTra = new DataGridViewTextBoxColumn();
            TongTienDichVu = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            NgayLapHoaDon = new DataGridViewTextBoxColumn();
            ThanhToan = new Button();
            TimKiem = new Button();
            txtMaPhong = new TextBox();
            label1 = new Label();
            label2 = new Label();
            LoadData = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHoaDon).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHoaDon
            // 
            dataGridViewHoaDon.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHoaDon.Columns.AddRange(new DataGridViewColumn[] { MaHoaDon, MaPhong, MaKhach, NgayNhan, NgayTra, TongTienDichVu, TongTien, NgayLapHoaDon });
            dataGridViewHoaDon.Dock = DockStyle.Bottom;
            dataGridViewHoaDon.Location = new Point(0, 398);
            dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            dataGridViewHoaDon.RowHeadersVisible = false;
            dataGridViewHoaDon.Size = new Size(800, 213);
            dataGridViewHoaDon.TabIndex = 0;
            // 
            // MaHoaDon
            // 
            MaHoaDon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaHoaDon.HeaderText = "Mã Hóa Đơn";
            MaHoaDon.Name = "MaHoaDon";
            // 
            // MaPhong
            // 
            MaPhong.HeaderText = "Mã Phòng";
            MaPhong.Name = "MaPhong";
            // 
            // MaKhach
            // 
            MaKhach.HeaderText = "Mã Khách Hàng";
            MaKhach.Name = "MaKhach";
            // 
            // NgayNhan
            // 
            NgayNhan.HeaderText = "Ngày Nhận";
            NgayNhan.Name = "NgayNhan";
            // 
            // NgayTra
            // 
            NgayTra.HeaderText = "Ngày Trả";
            NgayTra.Name = "NgayTra";
            // 
            // TongTienDichVu
            // 
            TongTienDichVu.HeaderText = "Tổng Tiền Dịch Vụ";
            TongTienDichVu.Name = "TongTienDichVu";
            // 
            // TongTien
            // 
            TongTien.HeaderText = "Tổng Tiền";
            TongTien.Name = "TongTien";
            // 
            // NgayLapHoaDon
            // 
            NgayLapHoaDon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgayLapHoaDon.HeaderText = "Ngày Lập Hóa Đơn";
            NgayLapHoaDon.Name = "NgayLapHoaDon";
            // 
            // ThanhToan
            // 
            ThanhToan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThanhToan.Location = new Point(132, 62);
            ThanhToan.Name = "ThanhToan";
            ThanhToan.Size = new Size(186, 94);
            ThanhToan.TabIndex = 1;
            ThanhToan.Text = "Thanh Toán";
            ThanhToan.UseVisualStyleBackColor = true;
            ThanhToan.Click += ThanhToan_Click;
            // 
            // TimKiem
            // 
            TimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TimKiem.Location = new Point(322, 305);
            TimKiem.Name = "TimKiem";
            TimKiem.Size = new Size(97, 39);
            TimKiem.TabIndex = 2;
            TimKiem.Text = "Tìm Kiếm";
            TimKiem.UseVisualStyleBackColor = true;
            TimKiem.Click += TimKiem_Click;
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(121, 314);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(181, 23);
            txtMaPhong.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 322);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 4;
            label1.Text = "Mã Phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(257, 242);
            label2.Name = "label2";
            label2.Size = new Size(334, 40);
            label2.TabIndex = 5;
            label2.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // LoadData
            // 
            LoadData.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadData.Location = new Point(444, 305);
            LoadData.Name = "LoadData";
            LoadData.Size = new Size(104, 39);
            LoadData.TabIndex = 6;
            LoadData.Text = "Làm Mới";
            LoadData.UseVisualStyleBackColor = true;
            LoadData.Click += LoadData_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(502, 62);
            button1.Name = "button1";
            button1.Size = new Size(170, 95);
            button1.TabIndex = 7;
            button1.Text = "Lịch Sử Thanh Toán";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // formThanhToan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 611);
            Controls.Add(button1);
            Controls.Add(LoadData);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMaPhong);
            Controls.Add(TimKiem);
            Controls.Add(ThanhToan);
            Controls.Add(dataGridViewHoaDon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formThanhToan";
            Text = "Thanh Toán";
            Load += formThanhToan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewHoaDon;
        private Button ThanhToan;
        private Button TimKiem;
        private TextBox txtMaPhong;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn MaHoaDon;
        private DataGridViewTextBoxColumn MaPhong;
        private DataGridViewTextBoxColumn MaKhach;
        private DataGridViewTextBoxColumn NgayNhan;
        private DataGridViewTextBoxColumn NgayTra;
        private DataGridViewTextBoxColumn TongTienDichVu;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn NgayLapHoaDon;
        private Button LoadData;
        private Button button1;
    }
}