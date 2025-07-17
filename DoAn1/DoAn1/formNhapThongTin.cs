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
    public partial class formNhapThongTin : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";
        public formNhapThongTin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Giả sử các control: MaKhachHang, TenKhachHang, CMND, cbGioiTinh, DiaChi, DienThoai, QuocTich
            if (string.IsNullOrWhiteSpace(MaKhachHang.Text) ||
                string.IsNullOrWhiteSpace(TenKhachHang.Text) ||
                string.IsNullOrWhiteSpace(CMND.Text) ||
                GioiTinh.SelectedItem == null ||
                string.IsNullOrWhiteSpace(DiaChi.Text) ||
                string.IsNullOrWhiteSpace(DienThoai.Text) ||
                string.IsNullOrWhiteSpace(QuocTich.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO KHACH_HANG (MaKhachHang, TenKhachHang, CMND, GioiTinh, DiaChi, DienThoai, QuocTich) " +
                                   "VALUES (@Ma, @Ten, @CMND, @GioiTinh, @DiaChi, @DienThoai, @QuocTich)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Ma", MaKhachHang.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ten", TenKhachHang.Text.Trim());
                    cmd.Parameters.AddWithValue("@CMND", CMND.Text.Trim());
                    cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DiaChi", DiaChi.Text.Trim());
                    cmd.Parameters.AddWithValue("@DienThoai", DienThoai.Text.Trim());
                    cmd.Parameters.AddWithValue("@QuocTich", QuocTich.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm khách hàng thành công!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm khách hàng: " + ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
