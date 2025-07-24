namespace DoAn1.DichVuThem
{
    partial class formChonDichVu
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
            DanhSachDichVu = new ComboBox();
            SoLuongChon = new TextBox();
            DichVuDaChon = new DataGridView();
            DichVu = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            ThemDichVu = new Button();
            label1 = new Label();
            label2 = new Label();
            Check = new Button();
            ((System.ComponentModel.ISupportInitialize)DichVuDaChon).BeginInit();
            SuspendLayout();
            // 
            // DanhSachDichVu
            // 
            DanhSachDichVu.FormattingEnabled = true;
            DanhSachDichVu.Location = new Point(121, 60);
            DanhSachDichVu.Name = "DanhSachDichVu";
            DanhSachDichVu.Size = new Size(193, 23);
            DanhSachDichVu.TabIndex = 0;
            // 
            // SoLuongChon
            // 
            SoLuongChon.Location = new Point(121, 106);
            SoLuongChon.Name = "SoLuongChon";
            SoLuongChon.Size = new Size(80, 23);
            SoLuongChon.TabIndex = 1;
            // 
            // DichVuDaChon
            // 
            DichVuDaChon.AllowUserToAddRows = false;
            DichVuDaChon.AllowUserToDeleteRows = false;
            DichVuDaChon.AllowUserToResizeColumns = false;
            DichVuDaChon.AllowUserToResizeRows = false;
            DichVuDaChon.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DichVuDaChon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DichVuDaChon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DichVuDaChon.Columns.AddRange(new DataGridViewColumn[] { DichVu, SoLuong });
            DichVuDaChon.Dock = DockStyle.Right;
            DichVuDaChon.Location = new Point(388, 0);
            DichVuDaChon.Name = "DichVuDaChon";
            DichVuDaChon.RowHeadersVisible = false;
            DichVuDaChon.Size = new Size(230, 282);
            DichVuDaChon.TabIndex = 2;
            // 
            // DichVu
            // 
            DichVu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DichVu.HeaderText = "Dịch Vụ";
            DichVu.Name = "DichVu";
            // 
            // SoLuong
            // 
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.Name = "SoLuong";
            // 
            // ThemDichVu
            // 
            ThemDichVu.Location = new Point(177, 149);
            ThemDichVu.Name = "ThemDichVu";
            ThemDichVu.Size = new Size(75, 23);
            ThemDichVu.TabIndex = 3;
            ThemDichVu.Text = "Thêm";
            ThemDichVu.UseVisualStyleBackColor = true;
            ThemDichVu.Click += ThemDichVu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 63);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 4;
            label1.Text = "Dịch Vụ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 109);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 5;
            label2.Text = "Số lượng";
            // 
            // Check
            // 
            Check.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Check.Location = new Point(164, 213);
            Check.Name = "Check";
            Check.Size = new Size(121, 42);
            Check.TabIndex = 6;
            Check.Text = "Xác Nhận";
            Check.UseVisualStyleBackColor = true;
            Check.Click += Check_Click;
            // 
            // formChonDichVu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 282);
            Controls.Add(Check);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ThemDichVu);
            Controls.Add(DichVuDaChon);
            Controls.Add(SoLuongChon);
            Controls.Add(DanhSachDichVu);
            Name = "formChonDichVu";
            Text = "Đặt Dịch Vụ";
            Load += formChonDichVu_Load_1;
            ((System.ComponentModel.ISupportInitialize)DichVuDaChon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox DanhSachDichVu;
        private TextBox SoLuongChon;
        private DataGridView DichVuDaChon;
        private DataGridViewTextBoxColumn DichVu;
        private DataGridViewTextBoxColumn SoLuong;
        private Button ThemDichVu;
        private Label label1;
        private Label label2;
        private Button Check;
    }
}