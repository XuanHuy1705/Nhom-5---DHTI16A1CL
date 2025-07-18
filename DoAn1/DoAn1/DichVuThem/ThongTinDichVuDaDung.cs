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
    public partial class ThongTinDichVuDaDung : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";

        public ThongTinDichVuDaDung()
        {
            InitializeComponent();
        }

        // Constructor nhận MaPhong, tự truy vấn và hiển thị dữ liệu
        public ThongTinDichVuDaDung(string maPhong)
        {
            InitializeComponent();
            LoadData(maPhong);
        }

        private void LoadData(string maPhong)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT MaPhong, DichVuDaDung, TongTienDichVu FROM DANH_SACH_DICH_VU_DUNG WHERE MaPhong = @MaPhong";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Hiển thị lên DataGridView
                        DichVuDaDat.Rows.Add(
                            reader["MaPhong"].ToString(),
                            reader["DichVuDaDung"].ToString(),
                            reader["TongTienDichVu"].ToString()
                        );
                    }
                }
            }
        }

        private void ThongTinDichVuDaDung_Load(object sender, EventArgs e)
        {

        }

        private void DichVuDaDat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
