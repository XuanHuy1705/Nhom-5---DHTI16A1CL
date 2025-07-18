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
    public partial class formSuaThongTinDatPhong : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";
        private string maPhong;

        public formSuaThongTinDatPhong(string maPhong)
        {
            InitializeComponent();
            this.maPhong = maPhong;
            LoadMaLoaiPhong();
        }
        private void LoadMaLoaiPhong()
        {
            MaLoaiPhong.Items.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
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
            MaLoaiPhong.SelectedIndexChanged += MaLoaiPhong_SelectedIndexChanged;
            LoadPhongData(); // Load data after MaLoaiPhong is filled
        }

        private void LoadPhongData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM DANH_SACH_PHONG_DA_CHO_THUE WHERE MaPhong = @MaPhong";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MaPhong.Text = reader["MaPhong"].ToString();
                    MaLoaiPhong.Text = reader["MaLoaiPhong"].ToString();
                    MaKhachHang.Text = reader["MaKhachHang"].ToString();
                    NgayNhan.Value = reader["NgayNhan"] != DBNull.Value ? Convert.ToDateTime(reader["NgayNhan"]) : DateTime.Now;
                    NgayDuKienTra.Value = reader["NgayDuKienTra"] != DBNull.Value ? Convert.ToDateTime(reader["NgayDuKienTra"]) : DateTime.Now;
                    GhiChu.Text = reader["GhiChu"].ToString();
                    // Set selected items for ComboBoxes
                    MaLoaiPhong.SelectedItem = reader["MaLoaiPhong"].ToString();
                    LoadMaPhong(reader["MaLoaiPhong"].ToString());
                    MaPhong.SelectedItem = reader["MaPhong"].ToString();
                }
            }
        }
        private void LoadMaPhong(string maLoaiPhong)
        {
            MaPhong.Items.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
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
        }

        private void Check_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"UPDATE DANH_SACH_PHONG_DA_CHO_THUE SET 
                            MaLoaiPhong = @MaLoaiPhong,
                            MaKhachHang = @MaKhachHang,
                            NgayNhan = @NgayNhan,
                            NgayDuKienTra = @NgayDuKienTra,
                            GhiChu = @GhiChu
                         WHERE MaPhong = @MaPhong";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                cmd.Parameters.AddWithValue("@MaLoaiPhong", MaLoaiPhong.Text.Trim());
                cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang.Text.Trim());
                cmd.Parameters.AddWithValue("@NgayNhan", NgayNhan.Value.Date);
                cmd.Parameters.AddWithValue("@NgayDuKienTra", NgayDuKienTra.Value.Date);
                cmd.Parameters.AddWithValue("@GhiChu", GhiChu.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thông tin thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void MaLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MaLoaiPhong.SelectedItem != null)
            {
                string selectedMaLoaiPhong = MaLoaiPhong.SelectedItem.ToString();
                LoadMaPhong(selectedMaLoaiPhong);
            }
        }
    }
}