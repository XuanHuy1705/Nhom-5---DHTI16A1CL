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
            MaDichVu = new DataGridViewTextBoxColumn();
            MaPhong = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
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
            DichVuDaDat.Columns.AddRange(new DataGridViewColumn[] { MaDichVu, MaPhong, SoLuong });
            DichVuDaDat.Dock = DockStyle.Bottom;
            DichVuDaDat.Location = new Point(0, 109);
            DichVuDaDat.Name = "DichVuDaDat";
            DichVuDaDat.RowHeadersVisible = false;
            DichVuDaDat.Size = new Size(477, 189);
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
            // MaDichVu
            // 
            MaDichVu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaDichVu.HeaderText = "Mã Dịch Vụ";
            MaDichVu.Name = "MaDichVu";
            // 
            // MaPhong
            // 
            MaPhong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaPhong.HeaderText = "Mã Phòng";
            MaPhong.Name = "MaPhong";
            // 
            // SoLuong
            // 
            SoLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.Name = "SoLuong";
            // 
            // ThongTinDichVuDaDung
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 298);
            Controls.Add(label1);
            Controls.Add(DichVuDaDat);
            Name = "ThongTinDichVuDaDung";
            Text = "Thông Tin Dịch Vụ";
            ((System.ComponentModel.ISupportInitialize)DichVuDaDat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DichVuDaDat;
        private DataGridViewTextBoxColumn MaDichVu;
        private DataGridViewTextBoxColumn MaPhong;
        private DataGridViewTextBoxColumn SoLuong;
        private Label label1;
    }
}