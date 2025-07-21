namespace DoAn1.ThanhToan
{
    partial class formTienThanhToan
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
            TongTien = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxPhuongThucThanhToan = new ComboBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            txtGhiChu = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TongTien
            // 
            TongTien.Location = new Point(204, 89);
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            TongTien.Size = new Size(150, 23);
            TongTien.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 90);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 1;
            label1.Text = "Tổng Tiền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(103, 142);
            label2.Name = "label2";
            label2.Size = new Size(93, 17);
            label2.TabIndex = 2;
            label2.Text = "Phương thức ";
            // 
            // comboBoxPhuongThucThanhToan
            // 
            comboBoxPhuongThucThanhToan.BackColor = SystemColors.HighlightText;
            comboBoxPhuongThucThanhToan.FormattingEnabled = true;
            comboBoxPhuongThucThanhToan.Items.AddRange(new object[] { "Tiền Mặt", "Chuyển Khoản", "Thẻ Ngân Hàng" });
            comboBoxPhuongThucThanhToan.Location = new Point(204, 136);
            comboBoxPhuongThucThanhToan.Name = "comboBoxPhuongThucThanhToan";
            comboBoxPhuongThucThanhToan.Size = new Size(150, 23);
            comboBoxPhuongThucThanhToan.TabIndex = 3;
            comboBoxPhuongThucThanhToan.SelectedIndexChanged += comboBoxPhuongThucThanhToan_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.qr;
            pictureBox1.Location = new Point(388, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(426, 31);
            label3.Name = "label3";
            label3.Size = new Size(126, 17);
            label3.TabIndex = 5;
            label3.Text = "Mã QR Thanh Toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(407, 237);
            label4.Name = "label4";
            label4.Size = new Size(150, 15);
            label4.TabIndex = 6;
            label4.Text = "Số tài khoản: 012345678910";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 258);
            label5.Name = "label5";
            label5.Size = new Size(149, 15);
            label5.TabIndex = 7;
            label5.Text = "Tên tài khoản: Khách Sạn A";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(249, 272);
            button1.Name = "button1";
            button1.Size = new Size(105, 36);
            button1.TabIndex = 8;
            button1.Text = "Xác Nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(104, 187);
            label6.Name = "label6";
            label6.Size = new Size(57, 17);
            label6.TabIndex = 10;
            label6.Text = "Ghi Chú";
            // 
            // txtGhiChu
            // 
            txtGhiChu.BackColor = SystemColors.ButtonHighlight;
            txtGhiChu.Location = new Point(204, 186);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(150, 66);
            txtGhiChu.TabIndex = 9;
            // 
            // formTienThanhToan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 320);
            Controls.Add(label6);
            Controls.Add(txtGhiChu);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(comboBoxPhuongThucThanhToan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TongTien);
            Name = "formTienThanhToan";
            Text = "Thanh Toán";
            Load += formTienThanhToan_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TongTien;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxPhuongThucThanhToan;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label label6;
        private TextBox txtGhiChu;
    }
}