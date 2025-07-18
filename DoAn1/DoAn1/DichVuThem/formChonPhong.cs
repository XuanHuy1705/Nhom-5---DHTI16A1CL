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
    public partial class formChonPhong : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";
        public formChonPhong()
        {
            InitializeComponent();
        }

        private void formChonPhong_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT MaPhong FROM DANH_SACH_PHONG_CHO_THUE WHERE TinhTrangPhong = 'True'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                ChonMaPhong.Items.Clear();
                while (reader.Read())
                {
                    ChonMaPhong.Items.Add(reader["MaPhong"].ToString());
                }
            }
        }

        private void XacNhan_Click(object sender, EventArgs e)
        {
            if (ChonMaPhong.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn mã phòng.");
                return;
            }
            string maPhong = ChonMaPhong.SelectedItem.ToString();
            var chonDichVuForm = new formChonDichVu(maPhong);
            chonDichVuForm.ShowDialog();
            this.Close();
        }

        private void formChonPhong_Load_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT MaPhong FROM DANH_SACH_PHONG_CHO_THUE WHERE TinhTrangPhong = 'True'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                ChonMaPhong.Items.Clear();
                while (reader.Read())
                {
                    ChonMaPhong.Items.Add(reader["MaPhong"].ToString());
                }
            }
        }
    }
}
