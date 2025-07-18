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
    public partial class formChonPhongSuaThongTin : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";
        public string SelectedMaPhong { get; private set; }

        public formChonPhongSuaThongTin()
        {
            InitializeComponent();
            this.Load += formChonPhongSuaThongTin_Load;
        }

        private void formChonPhongSuaThongTin_Load(object sender, EventArgs e)
        {
            LoadPhong();
        }

        private void LoadPhong()
        {
            MaPhong.Items.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT MaPhong FROM DANH_SACH_PHONG_THUE WHERE TinhTrangPhong = 'True'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MaPhong.Items.Add(reader["MaPhong"].ToString());
                }
            }
        }

        private void XacNhan_Click(object sender, EventArgs e)
        {
            if (MaPhong.SelectedItem != null)
            {
                SelectedMaPhong = MaPhong.SelectedItem.ToString();
                var suaThongTinForm = new formSuaThongTinDatPhong(SelectedMaPhong);
                suaThongTinForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã phòng.");
            }
        }
    }
}
