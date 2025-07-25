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

namespace DoAn1.OrderPhong.SuaPhong
{
    public partial class formXacNhanTraPhong : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";
        public formXacNhanTraPhong()
        {
            InitializeComponent();
        }

        private void XacNhan_Click(object sender, EventArgs e)
        {
            if (comboBoxDanhSachPhongCanThanhToan.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phòng cần thanh toán!");
                return;
            }

            string maPhong = comboBoxDanhSachPhongCanThanhToan.SelectedItem.ToString();

            if (MessageBox.Show("Xác nhận trả phòng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // 1. Lấy thông tin từ DANH_SACH_PHONG_DA_CHO_THUE
                    SqlCommand cmd = new SqlCommand(
                        "SELECT MaKhachHang, NgayNhan FROM DANH_SACH_PHONG_DA_CHO_THUE WHERE MaPhong = @MaPhong", con);
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (!reader.Read())
                    {
                        MessageBox.Show("Không tìm thấy thông tin phòng!");
                        return;
                    }
                    string maKhach = reader["MaKhachHang"].ToString();
                    DateTime ngayNhan = Convert.ToDateTime(reader["NgayNhan"]);
                    reader.Close();

                    // Kiểm tra chưa đến ngày nhận phòng
                    if (DateTime.Now.Date < ngayNhan.Date)
                    {
                        MessageBox.Show("Chưa đến ngày nhận phòng, không thể trả phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 2. Lấy DonGia từ DANH_SACH_PHONG_THUE
                    cmd = new SqlCommand(
                        "SELECT DonGia FROM DANH_SACH_PHONG_THUE WHERE MaPhong = @MaPhong", con);
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    object donGiaObj = cmd.ExecuteScalar();
                    decimal donGia = donGiaObj != null ? Convert.ToDecimal(donGiaObj) : 0;

                    // 3. Lấy tổng tiền dịch vụ từ DANH_SACH_SU_DUNG_DICH_VU
                    cmd = new SqlCommand(
                        "SELECT TongTienDichVu FROM DANH_SACH_DICH_VU_DUNG WHERE MaPhong = @MaPhong", con);
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    object result = cmd.ExecuteScalar();
                    decimal tongTienDichVu = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                    // 4. Tính toán ngày trả, ngày lập hóa đơn, tổng tiền
                    DateTime ngayTra = DateTime.Now;
                    DateTime ngayLapHoaDon = DateTime.Now;
                    int soNgay = (ngayTra.Date - ngayNhan.Date).Days;
                    if (soNgay == 0) soNgay = 1; // Nếu trả trong ngày thì tính 1 ngày
                    decimal tongTien = donGia * soNgay + tongTienDichVu;

                    // 5. Tạo mã hóa đơn ngẫu nhiên 5 số
                    Random rnd = new Random();
                    string maHoaDon = rnd.Next(10000, 99999).ToString();

                    // 6. Đặt lại TinhTrangPhong
                    cmd = new SqlCommand(
                        "UPDATE DANH_SACH_PHONG_THUE SET TinhTrangPhong = 0 WHERE MaPhong = @MaPhong", con);
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmd.ExecuteNonQuery();

                    // 7. Thêm hóa đơn vào bảng HOA_DON
                    cmd = new SqlCommand(
                        @"INSERT INTO HOA_DON (MaHoaDon, MaPhong, MaKhach, NgayNhan, NgayTra, TongTienDichVu, TongTien, NgayLapHoaDon)
                  VALUES (@MaHoaDon, @MaPhong, @MaKhach, @NgayNhan, @NgayTra, @TongTienDichVu, @TongTien, @NgayLapHoaDon)", con);
                    cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmd.Parameters.AddWithValue("@MaKhach", maKhach);
                    cmd.Parameters.AddWithValue("@NgayNhan", ngayNhan);
                    cmd.Parameters.AddWithValue("@NgayTra", ngayTra);
                    cmd.Parameters.AddWithValue("@TongTienDichVu", tongTienDichVu);
                    cmd.Parameters.AddWithValue("@TongTien", tongTien);
                    cmd.Parameters.AddWithValue("@NgayLapHoaDon", ngayLapHoaDon);
                    cmd.ExecuteNonQuery();

                    // 8. Xóa MaPhong khỏi DANH_SACH_PHONG_DA_CHO_THUE
                    cmd = new SqlCommand(
                        "DELETE FROM DANH_SACH_PHONG_DA_CHO_THUE WHERE MaPhong = @MaPhong", con);
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Trả phòng và tạo hóa đơn thành công!");
                }
            }
        }

        private void formXacNhanTraPhong_Load(object sender, EventArgs e)
        {
            comboBoxDanhSachPhongCanThanhToan.Items.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MaPhong FROM DANH_SACH_PHONG_DA_CHO_THUE", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxDanhSachPhongCanThanhToan.Items.Add(reader["MaPhong"].ToString());
                }
            }
        }
    }
}