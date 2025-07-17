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
            LoadMaDatPhong();
            NgayNhan.Format = DateTimePickerFormat.Custom;
            NgayNhan.CustomFormat = "dd/MM/yyyy";
            NgayDuKienTra.Format = DateTimePickerFormat.Custom;
            NgayDuKienTra.CustomFormat = "dd/MM/yyyy";
        }
        private void LoadMaDatPhong()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT MaLoaiPhong FROM LOAI_PHONG WHERE TinhTrangPhong IS NULL OR TinhTrangPhong = ''";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        MaLoaiPhong.Items.Add(reader["MaLoaiPhong"].ToString());
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
            
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (MaLoaiPhong.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn mã phòng.");
                return;
            }

            string maPhong = MaLoaiPhong.SelectedItem.ToString();
            string maLoaiPhong = MaPhong.Text.Trim();
            string maKhachHang = ""; // Lấy từ textbox hoặc logic khác nếu có
            string ghiChu = GhiChu.Text.Trim();
            DateTime ngayNhan = NgayNhan.Value.Date;
            DateTime ngayDuKienTra = NgayDuKienTra.Value.Date;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string insertQuery = "INSERT INTO DANH_SACH_PHONG_CHO_THUE (MaPhong, MaLoaiPhong, MaKhachHang, NgayNhan, NgayDuKienTra, GhiChu) VALUES (@MaPhong, @MaLoaiPhong, @MaKhachHang, @NgayNhan, @NgayDuKienTra, @GhiChu)";
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmd.Parameters.AddWithValue("@MaLoaiPhong", maLoaiPhong);
                    cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                    cmd.Parameters.AddWithValue("@NgayNhan", ngayNhan);
                    cmd.Parameters.AddWithValue("@NgayDuKienTra", ngayDuKienTra);
                    cmd.Parameters.AddWithValue("@GhiChu", ghiChu);
                    cmd.ExecuteNonQuery();
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
    }
}
