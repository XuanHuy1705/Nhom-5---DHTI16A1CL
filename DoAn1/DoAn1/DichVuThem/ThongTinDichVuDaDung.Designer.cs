namespace DoAn1.DichVuThem
{
    partial class ThongTinDichVuDaDung
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
            DichVuDaDat = new DataGridView();
            label1 = new Label();
            MaPhong = new DataGridViewTextBoxColumn();
            DichVuDaDung = new DataGridViewTextBoxColumn();
            TongTienDichVu = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DichVuDaDat).BeginInit();
            SuspendLayout();
            // 
            // DichVuDaDat
            // 
            DichVuDaDat.AllowUserToAddRows = false;
            DichVuDaDat.AllowUserToDeleteRows = false;
            DichVuDaDat.AllowUserToResizeColumns = false;
            DichVuDaDat.AllowUserToResizeRows = false;
            DichVuDaDat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DichVuDaDat.Columns.AddRange(new DataGridViewColumn[] { MaPhong, DichVuDaDung, TongTienDichVu });
            DichVuDaDat.Dock = DockStyle.Bottom;
            DichVuDaDat.Location = new Point(0, 111);
            DichVuDaDat.Name = "DichVuDaDat";
            DichVuDaDat.RowHeadersVisible = false;
            DichVuDaDat.Size = new Size(459, 179);
            DichVuDaDat.TabIndex = 0;
            DichVuDaDat.CellContentClick += DichVuDaDat_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 40);
            label1.Name = "label1";
            label1.Size = new Size(293, 28);
            label1.TabIndex = 1;
            label1.Text = "THÔNG TIN DỊCH VỤ ĐÃ ĐẶT";
            // 
            // MaPhong
            // 
            MaPhong.HeaderText = "Mã Phòng";
            MaPhong.Name = "MaPhong";
            // 
            // DichVuDaDung
            // 
            DichVuDaDung.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DichVuDaDung.HeaderText = "Dịch Vụ Đã Dùng";
            DichVuDaDung.Name = "DichVuDaDung";
            // 
            // TongTienDichVu
            // 
            TongTienDichVu.HeaderText = "Tổng Tiền";
            TongTienDichVu.Name = "TongTienDichVu";
            // 
            // ThongTinDichVuDaDung
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 290);
            Controls.Add(label1);
            Controls.Add(DichVuDaDat);
            Name = "ThongTinDichVuDaDung";
            Text = "Thông Tin Dịch Vụ";
            Load += ThongTinDichVuDaDung_Load;
            ((System.ComponentModel.ISupportInitialize)DichVuDaDat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DichVuDaDat;
        private Label label1;
        private DataGridViewTextBoxColumn MaPhong;
        private DataGridViewTextBoxColumn DichVuDaDung;
        private DataGridViewTextBoxColumn TongTienDichVu;
    }
}