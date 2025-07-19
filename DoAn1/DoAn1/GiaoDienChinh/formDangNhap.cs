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

namespace DoAn1
{
    public partial class formDangNhap : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;
        public formDangNhap()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DangNhap_Click(object sender, EventArgs e)
        {
            string username = TaiKhoan.Text;
            string password = MatKhau.Text;
            con = new SqlConnection(connectionString);
            try
            {
                String query = "SELECT * FROM NGUOI_DUNG WHERE TenDangNhap = @username AND MatKhau = @password";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt = new DataTable());

                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    Form1 mainForm = new Form1();
                    mainForm.Show();
                }
                else
                {
                    // Đăng nhập thất bại
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
                    TaiKhoan.Clear();
                    MatKhau.Clear();

                    TaiKhoan.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.");
                return;
            }
            finally
            {
                con.Close();
            }
        }

        private void DangKy_Click(object sender, EventArgs e)
        {
            var frm = new DoAn1.GiaoDienChinh.formDangKy();
            frm.ShowDialog();
        }
    }
}
