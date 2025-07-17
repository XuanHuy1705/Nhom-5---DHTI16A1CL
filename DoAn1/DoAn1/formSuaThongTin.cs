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
    public partial class formSuaThongTin : Form
    {
        public string OriginalMaKhachHang { get; set; }
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";

        public formSuaThongTin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
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
                    string query = "UPDATE KHACH_HANG SET MaKhachHang=@Ma, TenKhachHang=@Ten, CMND=@CMND, GioiTinh=@GioiTinh, DiaChi=@DiaChi, DienThoai=@DienThoai, QuocTich=@QuocTich WHERE MaKhachHang=@OriginalMa";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Ma", MaKhachHang.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ten", TenKhachHang.Text.Trim());
                    cmd.Parameters.AddWithValue("@CMND", CMND.Text.Trim());
                    cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DiaChi", DiaChi.Text.Trim());
                    cmd.Parameters.AddWithValue("@DienThoai", DienThoai.Text.Trim());
                    cmd.Parameters.AddWithValue("@QuocTich", QuocTich.Text.Trim());
                    cmd.Parameters.AddWithValue("@OriginalMa", OriginalMaKhachHang);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sửa thông tin khách hàng thành công!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa thông tin: " + ex.Message);
                }
            }
        }
    }
}
