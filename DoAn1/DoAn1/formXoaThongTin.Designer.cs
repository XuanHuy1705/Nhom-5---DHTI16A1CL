namespace DoAn1
{
    partial class formXoaThongTin
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
            LoaiDuLieu = new ComboBox();
            label1 = new Label();
            TextField = new TextBox();
            label2 = new Label();
            XoaThongTin = new Button();
            SuspendLayout();
            // 
            // LoaiDuLieu
            // 
            LoaiDuLieu.FormattingEnabled = true;
            LoaiDuLieu.Items.AddRange(new object[] { "MaKhachHang", "TenKhachHang", "DienThoai", "QuocTich", "GioiTinh", "DienThoai", "CMND" });
            LoaiDuLieu.Location = new Point(152, 46);
            LoaiDuLieu.Name = "LoaiDuLieu";
            LoaiDuLieu.Size = new Size(144, 23);
            LoaiDuLieu.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 49);
            label1.Name = "label1";
            label1.Size = new Size(119, 17);
            label1.TabIndex = 1;
            label1.Text = "Thông tin cần tìm";
            // 
            // TextField
            // 
            TextField.Location = new Point(153, 109);
            TextField.Name = "TextField";
            TextField.Size = new Size(199, 23);
            TextField.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 111);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 3;
            label2.Text = "Dữ liệu";
            // 
            // XoaThongTin
            // 
            XoaThongTin.Location = new Point(171, 178);
            XoaThongTin.Name = "XoaThongTin";
            XoaThongTin.Size = new Size(116, 40);
            XoaThongTin.TabIndex = 4;
            XoaThongTin.Text = "Xóa khách hàng";
            XoaThongTin.UseVisualStyleBackColor = true;
            XoaThongTin.Click += XoaThongTin_Click;
            // 
            // formXoaThongTin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 230);
            Controls.Add(XoaThongTin);
            Controls.Add(label2);
            Controls.Add(TextField);
            Controls.Add(label1);
            Controls.Add(LoaiDuLieu);
            Name = "formXoaThongTin";
            Text = "Xóa thông tin khách hàng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox LoaiDuLieu;
        private Label label1;
        private TextBox TextField;
        private Label label2;
        private Button XoaThongTin;
    }
}