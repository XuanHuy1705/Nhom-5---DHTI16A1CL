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

namespace DoAn1.OrderPhong
{
    public partial class formThemThongTinDatPhong : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";

        public formThemThongTinDatPhong()
        {
            InitializeComponent();
        }

        private void LoadMaLoaiPhong()
        {
            MaLoaiPhong.Items.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT MaLoaiPhong FROM LOAI_PHONG";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        MaLoaiPhong.Items.Add(reader["MaLoaiPhong"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải mã loại phòng: " + ex.Message);
                }
            }
        }

        private void LoadMaPhong(string maLoaiPhong)
        {
            MaPhong.Items.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // Lấy các phòng có MaLoaiPhong tương ứng và TinhTrangPhong = 0 (False)
                    string query = @"SELECT MaPhong FROM DANH_SACH_PHONG_THUE 
                             WHERE MaLoaiPhong = @MaLoaiPhong AND TinhTrangPhong = 0";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@MaLoaiPhong", maLoaiPhong);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        MaPhong.Items.Add(reader["MaPhong"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải mã phòng: " + ex.Message);
                }
            }
        }

        private void formThemThongTinDatPhong_Load(object sender, EventArgs e)
        {
            LoadMaLoaiPhong();
        }

        private void MaLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MaLoaiPhong.SelectedItem != null)
            {
                string selectedMaLoaiPhong = MaLoaiPhong.SelectedItem.ToString();
                LoadMaPhong(selectedMaLoaiPhong);
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (MaLoaiPhong.SelectedItem == null || MaPhong.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn mã loại phòng và mã phòng.");
                return;
            }

            string maLoaiPhong = MaLoaiPhong.SelectedItem.ToString();
            string maPhong = MaPhong.SelectedItem.ToString();
            string maKhachHang = MaKhachHang.Text.Trim();
            string ghiChu = GhiChu.Text.Trim();
            DateTime ngayNhan = NgayNhan.Value.Date;
            DateTime ngayDuKienTra = NgayDuKienTra.Value.Date;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Check if MaKhachHang exists
                    string checkQuery = "SELECT COUNT(*) FROM KHACH_HANG WHERE MaKhachHang = @MaKhachHang";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists == 0)
                    {
                        MessageBox.Show("Bạn cần thêm thông tin cho mã khách hàng để đặt phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string insertQuery = @"INSERT INTO DANH_SACH_PHONG_DA_CHO_THUE 
                (MaPhong, MaLoaiPhong, MaKhachHang, NgayNhan, NgayDuKienTra, GhiChu)
                VALUES (@MaPhong, @MaLoaiPhong, @MaKhachHang, @NgayNhan, @NgayDuKienTra, @GhiChu)";
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmd.Parameters.AddWithValue("@MaLoaiPhong", maLoaiPhong);
                    cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                    cmd.Parameters.AddWithValue("@NgayNhan", ngayNhan);
                    cmd.Parameters.AddWithValue("@NgayDuKienTra", ngayDuKienTra);
                    cmd.Parameters.AddWithValue("@GhiChu", ghiChu);
                    cmd.ExecuteNonQuery();

                    string updateQuery = @"UPDATE DANH_SACH_PHONG_THUE 
                                   SET TinhTrangPhong = 1 
                                   WHERE MaPhong = @MaPhong AND MaLoaiPhong = @MaLoaiPhong";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                    updateCmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    updateCmd.Parameters.AddWithValue("@MaLoaiPhong", maLoaiPhong);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Đặt phòng thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đặt phòng: " + ex.Message);
                }
            }
        }

        private void GhiChu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}