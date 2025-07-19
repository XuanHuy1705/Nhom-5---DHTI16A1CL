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

namespace DoAn1.GiaoDienChinh
{
    public partial class formDangKy : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";

        public formDangKy()
        {
            InitializeComponent();
        }

        private void DangKy_Click(object sender, EventArgs e)
        {
            string tenDangNhap = TenDangNhap.Text.Trim();
            string matKhau = MatKhau.Text.Trim();
            string nguoiDung = NguoiDung.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(nguoiDung))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO NGUOI_DUNG (TenDangNhap, MatKhau, LoaiNguoiDung) VALUES (@TenDangNhap, @MatKhau, @NguoiDung)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                cmd.Parameters.AddWithValue("@NguoiDung", nguoiDung);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Đăng ký thành công!");
            this.Close();
        }
    }
}
