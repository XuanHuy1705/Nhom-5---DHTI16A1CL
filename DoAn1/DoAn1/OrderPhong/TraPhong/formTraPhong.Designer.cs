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
            dataGridView1 = new DataGridView();
            MaPhong = new DataGridViewTextBoxColumn();
            MaLoaiPhong = new DataGridViewTextBoxColumn();
            MaKhachHang = new DataGridViewTextBoxColumn();
            NgayNhan = new DataGridViewTextBoxColumn();
            NgayDuKienTra = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            TimKiemMaPhong = new Button();
            label2 = new Label();
            TimKiem = new TextBox();
            TraPhong = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(473, 163);
            button1.Name = "button1";
            button1.Size = new Size(126, 32);
            button1.TabIndex = 7;
            button1.Text = "Làm mới dữ liệu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 83);
            label1.Name = "label1";
            label1.Size = new Size(509, 40);
            label1.TabIndex = 6;
            label1.Text = "DANH SÁCH PHÒNG ĐÃ ĐƯỢC ĐẶT";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaPhong, MaLoaiPhong, MaKhachHang, NgayNhan, NgayDuKienTra, GhiChu });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 311);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.Size = new Size(800, 302);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += BangKhachHang_CellContentClick;
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
            // TimKiemMaPhong
            // 
            TimKiemMaPhong.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TimKiemMaPhong.Location = new Point(345, 161);
            TimKiemMaPhong.Name = "TimKiemMaPhong";
            TimKiemMaPhong.Size = new Size(91, 32);
            TimKiemMaPhong.TabIndex = 8;
            TimKiemMaPhong.Text = "Tìm Kiếm";
            TimKiemMaPhong.UseVisualStyleBackColor = true;
            TimKiemMaPhong.Click += TimKiemMaPhong_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 169);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 9;
            label2.Text = "Mã phòng";
            // 
            // TimKiem
            // 
            TimKiem.Location = new Point(147, 163);
            TimKiem.Name = "TimKiem";
            TimKiem.Size = new Size(170, 23);
            TimKiem.TabIndex = 10;
            // 
            // TraPhong
            // 
            TraPhong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TraPhong.Location = new Point(356, 213);
            TraPhong.Name = "TraPhong";
            TraPhong.Size = new Size(155, 44);
            TraPhong.TabIndex = 11;
            TraPhong.Text = "Trả Phòng";
            TraPhong.UseVisualStyleBackColor = true;
            TraPhong.Click += TraPhong_Click;
            // 
            // formTraPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 613);
            Controls.Add(TraPhong);
            Controls.Add(TimKiem);
            Controls.Add(label2);
            Controls.Add(TimKiemMaPhong);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formTraPhong";
            Text = "formTraPhong";
            Load += formTraPhong_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaPhong;
        private DataGridViewTextBoxColumn MaLoaiPhong;
        private DataGridViewTextBoxColumn MaKhachHang;
        private DataGridViewTextBoxColumn NgayNhan;
        private DataGridViewTextBoxColumn NgayDuKienTra;
        private DataGridViewTextBoxColumn GhiChu;
        private Button TimKiemMaPhong;
        private Label label2;
        private TextBox TimKiem;
        private Button TraPhong;
    }
}