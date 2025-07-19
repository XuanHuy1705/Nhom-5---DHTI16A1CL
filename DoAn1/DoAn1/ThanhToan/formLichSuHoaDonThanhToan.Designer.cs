namespace DoAn1.ThanhToan
{
    partial class formLichSuHoaDonThanhToan
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            MaHoaDon = new DataGridViewTextBoxColumn();
            MaPhong = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            NgayThanhToan = new DataGridViewTextBoxColumn();
            PhuongThucThanhToan = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            label2 = new Label();
            TimMaHoaDon = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 47);
            label1.Name = "label1";
            label1.Size = new Size(396, 32);
            label1.TabIndex = 0;
            label1.Text = "LỊCH SỬ HÓA ĐƠN THANH TOÁN";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaHoaDon, MaPhong, TongTien, NgayThanhToan, PhuongThucThanhToan, GhiChu });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 201);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(651, 257);
            dataGridView1.TabIndex = 1;
            // 
            // MaHoaDon
            // 
            MaHoaDon.HeaderText = "Mã Hóa Đơn";
            MaHoaDon.Name = "MaHoaDon";
            // 
            // MaPhong
            // 
            MaPhong.HeaderText = "Mã Phòng";
            MaPhong.Name = "MaPhong";
            // 
            // TongTien
            // 
            TongTien.HeaderText = "Tổng Tiền";
            TongTien.Name = "TongTien";
            // 
            // NgayThanhToan
            // 
            NgayThanhToan.HeaderText = "Ngày Thanh Toán";
            NgayThanhToan.Name = "NgayThanhToan";
            // 
            // PhuongThucThanhToan
            // 
            PhuongThucThanhToan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PhuongThucThanhToan.HeaderText = "Phương Thức Thanh Toán";
            PhuongThucThanhToan.Name = "PhuongThucThanhToan";
            // 
            // GhiChu
            // 
            GhiChu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GhiChu.HeaderText = "Ghi Chú";
            GhiChu.Name = "GhiChu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(122, 148);
            label2.Name = "label2";
            label2.Size = new Size(86, 17);
            label2.TabIndex = 2;
            label2.Text = "Mã Hóa Đơn";
            // 
            // TimMaHoaDon
            // 
            TimMaHoaDon.Location = new Point(211, 145);
            TimMaHoaDon.Name = "TimMaHoaDon";
            TimMaHoaDon.Size = new Size(140, 23);
            TimMaHoaDon.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(373, 145);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Tìm Kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(475, 145);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Tất Cả";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // formLichSuHoaDonThanhToan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 458);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TimMaHoaDon);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "formLichSuHoaDonThanhToan";
            Text = "formLichSuHoaDonThanhToan";
            Load += formLichSuHoaDonThanhToan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaHoaDon;
        private DataGridViewTextBoxColumn MaPhong;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn NgayThanhToan;
        private DataGridViewTextBoxColumn PhuongThucThanhToan;
        private DataGridViewTextBoxColumn GhiChu;
        private Label label2;
        private TextBox TimMaHoaDon;
        private Button button1;
        private Button button2;
    }
}