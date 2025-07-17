namespace DoAn1
{
    partial class formDanhSachPhong
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
            panel1 = new Panel();
            label1 = new Label();
            BangDanhSachPhong = new DataGridView();
            Ma_loai_phong = new DataGridViewTextBoxColumn();
            Ten_loai_phong = new DataGridViewTextBoxColumn();
            Don_gia = new DataGridViewTextBoxColumn();
            So_nguoi_chuan = new DataGridViewTextBoxColumn();
            So_nguoi_toi_da = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BangDanhSachPhong).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BangDanhSachPhong);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 439);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 58);
            label1.Name = "label1";
            label1.Size = new Size(316, 25);
            label1.TabIndex = 1;
            label1.Text = "DANH SÁCH PHÒNG KHÁCH SẠN";
            // 
            // BangDanhSachPhong
            // 
            BangDanhSachPhong.AllowUserToAddRows = false;
            BangDanhSachPhong.BackgroundColor = SystemColors.ControlLightLight;
            BangDanhSachPhong.BorderStyle = BorderStyle.None;
            BangDanhSachPhong.CellBorderStyle = DataGridViewCellBorderStyle.None;
            BangDanhSachPhong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            BangDanhSachPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            BangDanhSachPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BangDanhSachPhong.Columns.AddRange(new DataGridViewColumn[] { Ma_loai_phong, Ten_loai_phong, Don_gia, So_nguoi_chuan, So_nguoi_toi_da });
            BangDanhSachPhong.EnableHeadersVisualStyles = false;
            BangDanhSachPhong.Location = new Point(0, 198);
            BangDanhSachPhong.Name = "BangDanhSachPhong";
            BangDanhSachPhong.RowHeadersVisible = false;
            BangDanhSachPhong.Size = new Size(799, 238);
            BangDanhSachPhong.TabIndex = 0;
            BangDanhSachPhong.CellContentClick += BangDanhSachPhong_CellContentClick;
            // 
            // Ma_loai_phong
            // 
            Ma_loai_phong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ma_loai_phong.HeaderText = "Mã loại phòng";
            Ma_loai_phong.Name = "Ma_loai_phong";
            // 
            // Ten_loai_phong
            // 
            Ten_loai_phong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ten_loai_phong.HeaderText = "Tên loại phòng";
            Ten_loai_phong.Name = "Ten_loai_phong";
            // 
            // Don_gia
            // 
            Don_gia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Don_gia.HeaderText = "Đơn giá";
            Don_gia.Name = "Don_gia";
            // 
            // So_nguoi_chuan
            // 
            So_nguoi_chuan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            So_nguoi_chuan.HeaderText = "Số người chuẩn";
            So_nguoi_chuan.Name = "So_nguoi_chuan";
            // 
            // So_nguoi_toi_da
            // 
            So_nguoi_toi_da.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            So_nguoi_toi_da.HeaderText = "Số người tối đa";
            So_nguoi_toi_da.Name = "So_nguoi_toi_da";
            // 
            // formDanhSachPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formDanhSachPhong";
            Text = "formDanhSachPhong";
            Load += formDanhSachPhong_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BangDanhSachPhong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView BangDanhSachPhong;
        private Label label1;
        private DataGridViewTextBoxColumn Ma_loai_phong;
        private DataGridViewTextBoxColumn Ten_loai_phong;
        private DataGridViewTextBoxColumn Don_gia;
        private DataGridViewTextBoxColumn So_nguoi_chuan;
        private DataGridViewTextBoxColumn So_nguoi_toi_da;
    }
}