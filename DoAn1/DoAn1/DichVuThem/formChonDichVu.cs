using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.DichVuThem
{
    public partial class formChonDichVu : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";
        private string maPhong;
        public formChonDichVu(string maPhong)
        {
            InitializeComponent();
            this.maPhong = maPhong;
        }

        private void formChonDichVu_Load(object sender, EventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (DichVuDaChon.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dịch vụ.");
                return;
            }

            decimal tongTien = 0;
            // Gom nhóm dịch vụ: MaDichVu -> tổng số lượng
            Dictionary<string, int> maDichVuSoLuong = new Dictionary<string, int>();

            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                foreach (DataGridViewRow row in DichVuDaChon.Rows)
                {
                    if (row.IsNewRow) continue;
                    string tenDichVu = row.Cells[0]?.Value?.ToString() ?? "";
                    int soLuong = 0;
                    int.TryParse(row.Cells[1]?.Value?.ToString(), out soLuong);

                    // Lấy MaDichVu và DonGia
                    string query = "SELECT MaDichVu, DonGia FROM DICH_VU WHERE TenDichVu = @TenDichVu";
                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@TenDichVu", tenDichVu);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string maDichVu = reader["MaDichVu"]?.ToString() ?? "";
                                decimal donGia = reader["DonGia"] != DBNull.Value ? Convert.ToDecimal(reader["DonGia"]) : 0;
                                tongTien += donGia * soLuong;

                                if (maDichVuSoLuong.ContainsKey(maDichVu))
                                    maDichVuSoLuong[maDichVu] += soLuong;
                                else
                                    maDichVuSoLuong[maDichVu] = soLuong;
                            }
                        }
                    }
                }

                // Tạo chuỗi dịch vụ đã dùng dạng: "DV01(x2),DV02(x1),DV03(x5)"
                string dichVuDaDung = string.Join(",", maDichVuSoLuong.Select(x => $"{x.Key}(x{x.Value})"));

                // Nếu đã có MaPhong thì cộng thêm vào danh sách và tổng tiền
                string checkQuery = "SELECT DichVuDaDung, TongTienDichVu FROM DANH_SACH_DICH_VU_DUNG WHERE MaPhong = @MaPhong";
                using (var checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    using (var reader = checkCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string oldDichVu = reader["DichVuDaDung"]?.ToString() ?? "";
                            decimal oldTongTien = reader["TongTienDichVu"] != DBNull.Value ? Convert.ToDecimal(reader["TongTienDichVu"]) : 0;
                            if (!string.IsNullOrEmpty(oldDichVu))
                                dichVuDaDung = oldDichVu + "," + dichVuDaDung;
                            tongTien += oldTongTien;

                            reader.Close();
                            // Update lại
                            string update = "UPDATE DANH_SACH_DICH_VU_DUNG SET DichVuDaDung = @DichVuDaDung, TongTienDichVu = @TongTienDichVu WHERE MaPhong = @MaPhong";
                            using (var updateCmd = new SqlCommand(update, con))
                            {
                                updateCmd.Parameters.AddWithValue("@DichVuDaDung", dichVuDaDung);
                                updateCmd.Parameters.AddWithValue("@TongTienDichVu", tongTien);
                                updateCmd.Parameters.AddWithValue("@MaPhong", maPhong);
                                updateCmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Lưu dịch vụ thành công!");
                            this.Close();
                            return;
                        }
                    }
                }

                // Insert mới nếu chưa có
                string insert = "INSERT INTO DANH_SACH_DICH_VU_DUNG (MaPhong, DichVuDaDung, TongTienDichVu) VALUES (@MaPhong, @DichVuDaDung, @TongTienDichVu)";
                using (var insertCmd = new SqlCommand(insert, con))
                {
                    insertCmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    insertCmd.Parameters.AddWithValue("@DichVuDaDung", dichVuDaDung);
                    insertCmd.Parameters.AddWithValue("@TongTienDichVu", tongTien);
                    insertCmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Lưu dịch vụ thành công!");
            this.Close();
        }

        private void formChonDichVu_Load_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT TenDichVu FROM DICH_VU";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                DanhSachDichVu.Items.Clear();
                while (reader.Read())
                {
                    DanhSachDichVu.Items.Add(reader["TenDichVu"].ToString());
                }
            }
        }

        private void ThemDichVu_Click(object sender, EventArgs e)
        {
            if (DanhSachDichVu.SelectedItem == null || string.IsNullOrWhiteSpace(SoLuongChon.Text))
            {
                MessageBox.Show("Vui lòng chọn dịch vụ và nhập số lượng.");
                return;
            }
            string tenDichVu = DanhSachDichVu.SelectedItem.ToString();
            int soLuong = int.Parse(SoLuongChon.Text);
            DichVuDaChon.Rows.Add(tenDichVu, soLuong);
        }
    }
}
