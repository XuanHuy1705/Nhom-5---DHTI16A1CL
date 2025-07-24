namespace DoAn1
{
    partial class formDichVuThem
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
            bangDichVu = new DataGridView();
            MaDichVu = new DataGridViewTextBoxColumn();
            TenDichVu = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            TimKiemDichVu = new Button();
            label1 = new Label();
            TimKiem = new TextBox();
            TraCuuThongTin = new TextBox();
            label2 = new Label();
            TraCuu = new Button();
            label3 = new Label();
            button3 = new Button();
            ShowaAll = new Button();
            ((System.ComponentModel.ISupportInitialize)bangDichVu).BeginInit();
            SuspendLayout();
            // 
            // bangDichVu
            // 
            bangDichVu.AllowUserToAddRows = false;
            bangDichVu.AllowUserToDeleteRows = false;
            bangDichVu.AllowUserToResizeColumns = false;
            bangDichVu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            bangDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            bangDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bangDichVu.Columns.AddRange(new DataGridViewColumn[] { MaDichVu, TenDichVu, DonVi, DonGia });
            bangDichVu.Dock = DockStyle.Left;
            bangDichVu.Location = new Point(0, 0);
            bangDichVu.Name = "bangDichVu";
            bangDichVu.RowHeadersVisible = false;
            bangDichVu.Size = new Size(432, 389);
            bangDichVu.TabIndex = 0;
            bangDichVu.CellContentClick += bangDichVu_CellContentClick;
            // 
            // MaDichVu
            // 
            MaDichVu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaDichVu.HeaderText = "Mã Dịch Vụ";
            MaDichVu.Name = "MaDichVu";
            // 
            // TenDichVu
            // 
            TenDichVu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenDichVu.HeaderText = "Tên Dịch Vụ";
            TenDichVu.Name = "TenDichVu";
            // 
            // DonVi
            // 
            DonVi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DonVi.HeaderText = "Đơn Vị";
            DonVi.Name = "DonVi";
            // 
            // DonGia
            // 
            DonGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DonGia.HeaderText = "Đơn Giá";
            DonGia.Name = "DonGia";
            // 
            // TimKiemDichVu
            // 
            TimKiemDichVu.Location = new Point(529, 91);
            TimKiemDichVu.Name = "TimKiemDichVu";
            TimKiemDichVu.Size = new Size(75, 23);
            TimKiemDichVu.TabIndex = 1;
            TimKiemDichVu.Text = "Tìm kiếm";
            TimKiemDichVu.UseVisualStyleBackColor = true;
            TimKiemDichVu.Click += TimKiemDichVu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(457, 49);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 2;
            label1.Text = "Dịch vụ";
            // 
            // TimKiem
            // 
            TimKiem.Location = new Point(529, 41);
            TimKiem.Name = "TimKiem";
            TimKiem.Size = new Size(162, 23);
            TimKiem.TabIndex = 3;
            // 
            // TraCuuThongTin
            // 
            TraCuuThongTin.Location = new Point(529, 289);
            TraCuuThongTin.Name = "TraCuuThongTin";
            TraCuuThongTin.Size = new Size(162, 23);
            TraCuuThongTin.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(503, 246);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 5;
            label2.Text = "Tra cứu dịch vụ đã đặt";
            // 
            // TraCuu
            // 
            TraCuu.Location = new Point(573, 330);
            TraCuu.Name = "TraCuu";
            TraCuu.Size = new Size(75, 23);
            TraCuu.TabIndex = 4;
            TraCuu.Text = "Tra cứu";
            TraCuu.UseVisualStyleBackColor = true;
            TraCuu.Click += TraCuu_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(457, 297);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 7;
            label3.Text = "Mã phòng";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(501, 151);
            button3.Name = "button3";
            button3.Size = new Size(165, 56);
            button3.TabIndex = 8;
            button3.Text = "Đặt Dịch Vụ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ShowaAll
            // 
            ShowaAll.Location = new Point(616, 91);
            ShowaAll.Name = "ShowaAll";
            ShowaAll.Size = new Size(75, 23);
            ShowaAll.TabIndex = 9;
            ShowaAll.Text = "Đặt lại";
            ShowaAll.UseVisualStyleBackColor = true;
            ShowaAll.Click += ShowaAll_Click;
            // 
            // formDichVuThem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 389);
            Controls.Add(ShowaAll);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(TraCuuThongTin);
            Controls.Add(label2);
            Controls.Add(TraCuu);
            Controls.Add(TimKiem);
            Controls.Add(label1);
            Controls.Add(TimKiemDichVu);
            Controls.Add(bangDichVu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formDichVuThem";
            Text = "formDichVuThem";
            Load += formDichVuThem_Load;
            ((System.ComponentModel.ISupportInitialize)bangDichVu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView bangDichVu;
        private DataGridViewTextBoxColumn MaDichVu;
        private DataGridViewTextBoxColumn TenDichVu;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn DonGia;
        private Button TimKiemDichVu;
        private Label label1;
        private TextBox TimKiem;
        private TextBox TraCuuThongTin;
        private Label label2;
        private Button TraCuu;
        private Label label3;
        private Button button3;
        private Button ShowaAll;
    }
}