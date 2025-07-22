using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ClosedXML.Excel;

namespace DoAn1.OrderPhong.DatPhong
{
    public partial class formDanhSachPhongDangThue : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";

        public formDanhSachPhongDangThue()
        {
            InitializeComponent();
        }

        private void formDanhSachPhongDangThue_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhongDaChoThue();
        }

        private void LoadDanhSachPhongDaChoThue()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Set up columns (order and names as in your table)
            dataGridView1.Columns.Add("MaPhong", "Mã Phòng");
            dataGridView1.Columns.Add("MaLoaiPhong", "Mã Loại Phòng");
            dataGridView1.Columns.Add("MaKhachHang", "Mã Khách Hàng");
            dataGridView1.Columns.Add("NgayNhan", "Ngày Nhận");
            dataGridView1.Columns.Add("NgayDuKienTra", "Ngày Dự Kiến Trả");
            dataGridView1.Columns.Add("GhiChu", "Ghi Chú");

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT MaPhong, MaLoaiPhong, MaKhachHang, NgayNhan, NgayDuKienTra, GhiChu FROM DANH_SACH_PHONG_DA_CHO_THUE";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["MaPhong"].ToString(),
                        reader["MaLoaiPhong"].ToString(),
                        reader["MaKhachHang"].ToString(),
                        Convert.ToDateTime(reader["NgayNhan"]).ToString("dd/MM/yyyy"),
                        Convert.ToDateTime(reader["NgayDuKienTra"]).ToString("dd/MM/yyyy"),
                        reader["GhiChu"].ToString()
                    );
                }
            }
        }

        private void XuatDuLieu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Workbook|*.xlsx";
                sfd.Title = "Chọn vị trí lưu file Excel";
                sfd.FileName = "Danh Sách Phòng Đang Cho Thuê.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Danh sách phòng đang thuê");

                        // Export column headers
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                        }

                        // Export rows
                        for (int r = 0; r < dataGridView1.Rows.Count; r++)
                        {
                            for (int c = 0; c < dataGridView1.Columns.Count; c++)
                            {
                                worksheet.Cell(r + 2, c + 1).Value = dataGridView1.Rows[r].Cells[c].Value?.ToString();
                            }
                        }

                        worksheet.Columns().AdjustToContents();
                        workbook.SaveAs(sfd.FileName);
                    }

                    MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ThemDuLieu_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel Files|*.xlsx;*.xls";
                ofd.Title = "Chọn file Excel dữ liệu phòng đang thuê";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var phongDaChoThue = new List<(string value, int row)>();
                    var invalidMaPhong = new List<(string value, int row)>();
                    var invalidMaKhachHang = new List<(string value, int row)>();
                    var invalidMaLoaiPhong = new List<(string value, int row)>();
                    int validCount = 0;

                    using (var workbook = new XLWorkbook(ofd.FileName))
                    {
                        var ws = workbook.Worksheets.First();
                        int lastRow = ws.LastRowUsed().RowNumber();

                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                            for (int r = 2; r <= lastRow; r++) // Assuming row 1 is header
                            {
                                var row = ws.Row(r);
                                string maPhong = row.Cell(1).GetString().Trim();
                                string maLoaiPhong = row.Cell(2).GetString().Trim();
                                string maKhachHang = row.Cell(3).GetString().Trim();
                                string ngayNhanStr = row.Cell(4).GetString().Trim();
                                string ngayDuKienTraStr = row.Cell(5).GetString().Trim();
                                string ghiChu = row.Cell(6).GetString().Trim();

                                // Check MaPhong exists in DANH_SACH_PHONG_THUE
                                var cmdPhong = new SqlCommand("SELECT COUNT(*) FROM DANH_SACH_PHONG_THUE WHERE MaPhong = @MaPhong", con);
                                cmdPhong.Parameters.AddWithValue("@MaPhong", maPhong);
                                int phongExists = (int)cmdPhong.ExecuteScalar();
                                if (phongExists == 0)
                                {
                                    invalidMaPhong.Add((maPhong, r));
                                    continue;
                                }

                                // Check MaLoaiPhong
                                var cmdLoaiPhong = new SqlCommand("SELECT COUNT(*) FROM LOAI_PHONG WHERE MaLoaiPhong = @MaLoaiPhong", con);
                                cmdLoaiPhong.Parameters.AddWithValue("@MaLoaiPhong", maLoaiPhong);
                                int loaiPhongExists = (int)cmdLoaiPhong.ExecuteScalar();
                                if (loaiPhongExists == 0)
                                {
                                    invalidMaLoaiPhong.Add((maLoaiPhong, r));
                                    continue;
                                }

                                // Check MaKhachHang
                                var cmdKhachHang = new SqlCommand("SELECT COUNT(*) FROM KHACH_HANG WHERE MaKhachHang = @MaKhachHang", con);
                                cmdKhachHang.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                                int khachHangExists = (int)cmdKhachHang.ExecuteScalar();
                                if (khachHangExists == 0)
                                {
                                    invalidMaKhachHang.Add((maKhachHang, r));
                                    continue;
                                }

                                // Check if MaPhong already rented in DANH_SACH_PHONG_DA_CHO_THUE
                                var cmdPhongDaChoThue = new SqlCommand("SELECT COUNT(*) FROM DANH_SACH_PHONG_DA_CHO_THUE WHERE MaPhong = @MaPhong", con);
                                cmdPhongDaChoThue.Parameters.AddWithValue("@MaPhong", maPhong);
                                int phongDaChoThueExists = (int)cmdPhongDaChoThue.ExecuteScalar();
                                if (phongDaChoThueExists > 0)
                                {
                                    phongDaChoThue.Add((maPhong, r));
                                    continue;
                                }

                                // Parse dates
                                DateTime ngayNhan, ngayDuKienTra;
                                if (!DateTime.TryParse(ngayNhanStr, out ngayNhan) || !DateTime.TryParse(ngayDuKienTraStr, out ngayDuKienTra))
                                {
                                    // Optionally handle invalid date format here
                                    continue;
                                }

                                // Insert valid row
                                var insertCmd = new SqlCommand(
                                    @"INSERT INTO DANH_SACH_PHONG_DA_CHO_THUE 
                            (MaPhong, MaLoaiPhong, MaKhachHang, NgayNhan, NgayDuKienTra, GhiChu)
                            VALUES (@MaPhong, @MaLoaiPhong, @MaKhachHang, @NgayNhan, @NgayDuKienTra, @GhiChu)", con);
                                insertCmd.Parameters.AddWithValue("@MaPhong", maPhong);
                                insertCmd.Parameters.AddWithValue("@MaLoaiPhong", maLoaiPhong);
                                insertCmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                                insertCmd.Parameters.AddWithValue("@NgayNhan", ngayNhan);
                                insertCmd.Parameters.AddWithValue("@NgayDuKienTra", ngayDuKienTra);
                                insertCmd.Parameters.AddWithValue("@GhiChu", ghiChu);
                                insertCmd.ExecuteNonQuery();

                                // Update TinhTrangPhong in DANH_SACH_PHONG_THUE
                                var updateCmd = new SqlCommand(
                                    "UPDATE DANH_SACH_PHONG_THUE SET TinhTrangPhong = 1 WHERE MaPhong = @MaPhong", con);
                                updateCmd.Parameters.AddWithValue("@MaPhong", maPhong);
                                updateCmd.ExecuteNonQuery();

                                validCount++;
                            }
                        }
                    }

                    // Build error message
                    StringBuilder sb = new StringBuilder();
                    if (phongDaChoThue.Count > 0)
                    {
                        sb.AppendLine($"Các phòng đã cho thuê từ trước ({phongDaChoThue.Count} dòng):");
                        foreach (var item in phongDaChoThue)
                            sb.AppendLine($"- {item.value} (dòng {item.row})");
                        sb.AppendLine();
                    }
                    if (invalidMaPhong.Count > 0)
                    {
                        sb.AppendLine($"Các Mã Phòng không tồn tại ({invalidMaPhong.Count} dòng):");
                        foreach (var item in invalidMaPhong)
                            sb.AppendLine($"- {item.value} (dòng {item.row})");
                    }
                    if (invalidMaLoaiPhong.Count > 0)
                    {
                        sb.AppendLine($"Các Mã Loại Phòng không tồn tại ({invalidMaLoaiPhong.Count} dòng):");
                        foreach (var item in invalidMaLoaiPhong)
                            sb.AppendLine($"- {item.value} (dòng {item.row})");
                    }
                    if (invalidMaKhachHang.Count > 0)
                    {
                        sb.AppendLine($"Các Mã Khách Hàng không tồn tại ({invalidMaKhachHang.Count} dòng):");
                        foreach (var item in invalidMaKhachHang)
                            sb.AppendLine($"- {item.value} (dòng {item.row})");
                    }
                    sb.AppendLine($"Số dòng hợp lệ đã nhập: {validCount}");

                    LoadDanhSachPhongDaChoThue();
                    MessageBox.Show(sb.ToString(), "Kết quả nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
