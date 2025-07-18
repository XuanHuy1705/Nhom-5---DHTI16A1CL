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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            NutDanhSach = new Button();
            label1 = new Label();
            BangDanhSachPhong = new DataGridView();
            MaPhong = new DataGridViewTextBoxColumn();
            Ma_loai_phong = new DataGridViewTextBoxColumn();
            Don_gia = new DataGridViewTextBoxColumn();
            TinhTrangPhong = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BangDanhSachPhong).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(NutDanhSach);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BangDanhSachPhong);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 439);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // NutDanhSach
            // 
            NutDanhSach.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NutDanhSach.Location = new Point(30, 106);
            NutDanhSach.Name = "NutDanhSach";
            NutDanhSach.Size = new Size(147, 63);
            NutDanhSach.TabIndex = 3;
            NutDanhSach.Text = "Danh sách loại phòng";
            NutDanhSach.UseVisualStyleBackColor = true;
            NutDanhSach.Click += NutDanhSach_Click;
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            BangDanhSachPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            BangDanhSachPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BangDanhSachPhong.Columns.AddRange(new DataGridViewColumn[] { MaPhong, Ma_loai_phong, Don_gia, TinhTrangPhong });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            BangDanhSachPhong.DefaultCellStyle = dataGridViewCellStyle6;
            BangDanhSachPhong.Dock = DockStyle.Bottom;
            BangDanhSachPhong.EnableHeadersVisualStyles = false;
            BangDanhSachPhong.Location = new Point(0, 201);
            BangDanhSachPhong.Name = "BangDanhSachPhong";
            BangDanhSachPhong.RowHeadersVisible = false;
            BangDanhSachPhong.Size = new Size(799, 238);
            BangDanhSachPhong.TabIndex = 0;
            BangDanhSachPhong.CellContentClick += BangDanhSachPhong_CellContentClick;
            // 
            // MaPhong
            // 
            MaPhong.HeaderText = "Mã Phòng";
            MaPhong.Name = "MaPhong";
            // 
            // Ma_loai_phong
            // 
            Ma_loai_phong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ma_loai_phong.HeaderText = "Mã loại phòng";
            Ma_loai_phong.Name = "Ma_loai_phong";
            // 
            // Don_gia
            // 
            Don_gia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Don_gia.HeaderText = "Đơn giá";
            Don_gia.Name = "Don_gia";
            // 
            // TinhTrangPhong
            // 
            TinhTrangPhong.HeaderText = "Tình Trạng Phòng";
            TinhTrangPhong.Name = "TinhTrangPhong";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(231, 107);
            button1.Name = "button1";
            button1.Size = new Size(147, 63);
            button1.TabIndex = 4;
            button1.Text = "Phòng còn trống";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(431, 107);
            button2.Name = "button2";
            button2.Size = new Size(147, 63);
            button2.TabIndex = 5;
            button2.Text = "Phòng đã đặt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(616, 108);
            button3.Name = "button3";
            button3.Size = new Size(147, 63);
            button3.TabIndex = 6;
            button3.Text = "Tất cả";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
        private DataGridViewTextBoxColumn MaPhong;
        private DataGridViewTextBoxColumn Ma_loai_phong;
        private DataGridViewTextBoxColumn Don_gia;
        private DataGridViewTextBoxColumn TinhTrangPhong;
        private Button NutDanhSach;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}