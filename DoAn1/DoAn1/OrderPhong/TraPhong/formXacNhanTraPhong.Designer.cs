namespace DoAn1.OrderPhong.SuaPhong
{
    partial class formXacNhanTraPhong
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
            comboBoxDanhSachPhongCanThanhToan = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            XacNhan = new Button();
            SuspendLayout();
            // 
            // comboBoxDanhSachPhongCanThanhToan
            // 
            comboBoxDanhSachPhongCanThanhToan.FormattingEnabled = true;
            comboBoxDanhSachPhongCanThanhToan.Location = new Point(181, 111);
            comboBoxDanhSachPhongCanThanhToan.Name = "comboBoxDanhSachPhongCanThanhToan";
            comboBoxDanhSachPhongCanThanhToan.Size = new Size(216, 23);
            comboBoxDanhSachPhongCanThanhToan.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 111);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 1;
            label1.Text = "Mã Phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(148, 40);
            label2.Name = "label2";
            label2.Size = new Size(273, 30);
            label2.TabIndex = 2;
            label2.Text = "XÁC NHẬN THANH TOÁN";
            // 
            // XacNhan
            // 
            XacNhan.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            XacNhan.Location = new Point(241, 191);
            XacNhan.Name = "XacNhan";
            XacNhan.Size = new Size(89, 39);
            XacNhan.TabIndex = 3;
            XacNhan.Text = "Xác Nhận";
            XacNhan.UseVisualStyleBackColor = true;
            XacNhan.Click += XacNhan_Click;
            // 
            // formXacNhanTraPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 273);
            Controls.Add(XacNhan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxDanhSachPhongCanThanhToan);
            Name = "formXacNhanTraPhong";
            Text = "Xác Nhận Thanh Toán";
            Load += formXacNhanTraPhong_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxDanhSachPhongCanThanhToan;
        private Label label1;
        private Label label2;
        private Button XacNhan;
    }
}