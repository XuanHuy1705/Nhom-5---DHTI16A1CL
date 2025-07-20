namespace DoAn1
{
    partial class formThongTinCanSua
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
            XacNhan = new Button();
            label2 = new Label();
            TextField = new TextBox();
            label1 = new Label();
            LoaiDuLieu = new ComboBox();
            SuspendLayout();
            // 
            // XacNhan
            // 
            XacNhan.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            XacNhan.Location = new Point(204, 152);
            XacNhan.Name = "XacNhan";
            XacNhan.Size = new Size(116, 40);
            XacNhan.TabIndex = 9;
            XacNhan.Text = "Xác nhận";
            XacNhan.UseVisualStyleBackColor = true;
            XacNhan.Click += XacNhan_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(65, 85);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 8;
            label2.Text = "Dữ liệu";
            // 
            // TextField
            // 
            TextField.Location = new Point(186, 83);
            TextField.Name = "TextField";
            TextField.Size = new Size(199, 23);
            TextField.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 23);
            label1.Name = "label1";
            label1.Size = new Size(119, 17);
            label1.TabIndex = 6;
            label1.Text = "Thông tin cần tìm";
            // 
            // LoaiDuLieu
            // 
            LoaiDuLieu.FormattingEnabled = true;
            LoaiDuLieu.Items.AddRange(new object[] { "MaKhachHang", "TenKhachHang", "DienThoai", "QuocTich", "GioiTinh", "DienThoai", "CMND" });
            LoaiDuLieu.Location = new Point(185, 20);
            LoaiDuLieu.Name = "LoaiDuLieu";
            LoaiDuLieu.Size = new Size(144, 23);
            LoaiDuLieu.TabIndex = 5;
            // 
            // formThongTinCanSua
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 213);
            Controls.Add(XacNhan);
            Controls.Add(label2);
            Controls.Add(TextField);
            Controls.Add(label1);
            Controls.Add(LoaiDuLieu);
            Name = "formThongTinCanSua";
            Text = "Tìm Thông Tin Cần Sửa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button XacNhan;
        private Label label2;
        private TextBox TextField;
        private Label label1;
        private ComboBox LoaiDuLieu;
    }
}