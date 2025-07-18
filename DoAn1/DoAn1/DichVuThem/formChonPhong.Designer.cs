namespace DoAn1.DichVuThem
{
    partial class formChonPhong
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
            ChonMaPhong = new ComboBox();
            label1 = new Label();
            XacNhan = new Button();
            SuspendLayout();
            // 
            // ChonMaPhong
            // 
            ChonMaPhong.FormattingEnabled = true;
            ChonMaPhong.Location = new Point(156, 69);
            ChonMaPhong.Name = "ChonMaPhong";
            ChonMaPhong.Size = new Size(225, 23);
            ChonMaPhong.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 72);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã phòng";
            // 
            // XacNhan
            // 
            XacNhan.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            XacNhan.Location = new Point(203, 124);
            XacNhan.Name = "XacNhan";
            XacNhan.Size = new Size(123, 40);
            XacNhan.TabIndex = 2;
            XacNhan.Text = "Xác Nhận";
            XacNhan.UseVisualStyleBackColor = true;
            XacNhan.Click += XacNhan_Click;
            // 
            // formChonPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 227);
            Controls.Add(XacNhan);
            Controls.Add(label1);
            Controls.Add(ChonMaPhong);
            Name = "formChonPhong";
            Text = "formChonPhong";
            Load += formChonPhong_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ChonMaPhong;
        private Label label1;
        private Button XacNhan;
    }
}