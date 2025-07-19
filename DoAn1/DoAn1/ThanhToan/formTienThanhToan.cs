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

namespace DoAn1.ThanhToan
{
    public partial class formTienThanhToan : Form
    {
        public string MaPhongDuocChon { get; set; }
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";

        public formTienThanhToan()
        {
            InitializeComponent();
        }

        private void formTienThanhToan_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            pictureBox1.Visible = false;

            // Hiển thị TongTien từ HOA_DON theo MaPhongDuocChon
            if (!string.IsNullOrEmpty(MaPhongDuocChon))
            {
                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 TongTien FROM HOA_DON WHERE MaPhong = @MaPhong", con);
                    cmd.Parameters.AddWithValue("@MaPhong", MaPhongDuocChon);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        TongTien.Text = result.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn cho phòng này!");
                        this.Close();
                    }
                }
            }
        }

        private void comboBoxPhuongThucThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isChuyenKhoan = comboBoxPhuongThucThanhToan.SelectedItem?.ToString() == "Chuyển Khoản";
            label3.Visible = isChuyenKhoan;
            label4.Visible = isChuyenKhoan;
            label5.Visible = isChuyenKhoan;
            pictureBox1.Visible = isChuyenKhoan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal tongTien = decimal.Parse(TongTien.Text);
            string phuongThuc = comboBoxPhuongThucThanhToan.SelectedItem?.ToString() ?? "";
            string ghiChu = txtGhiChu.Text.Trim();
            string maHoaDon = "";
            string maPhong = MaPhongDuocChon;

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Lấy MaHoaDon từ HOA_DON theo MaPhong
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 MaHoaDon FROM HOA_DON WHERE MaPhong = @MaPhong", con);
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    maHoaDon = result.ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn!");
                    return;
                }

                // Thêm vào HOA_DON_THANH_TOAN
                cmd = new SqlCommand(@"INSERT INTO HOA_DON_THANH_TOAN 
            (MaHoaDon, MaPhong, TongTien, NgayThanhToan, PhuongThucThanhToan, GhiChu)
            VALUES (@MaHoaDon, @MaPhong, @TongTien, @NgayThanhToan, @PhuongThuc, @GhiChu)", con);
                cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                cmd.Parameters.AddWithValue("@TongTien", tongTien);
                cmd.Parameters.AddWithValue("@NgayThanhToan", DateTime.Now);
                cmd.Parameters.AddWithValue("@PhuongThuc", phuongThuc);
                cmd.Parameters.AddWithValue("@GhiChu", ghiChu);
                cmd.ExecuteNonQuery();

                // Xóa hóa đơn khỏi HOA_DON
                cmd = new SqlCommand("DELETE FROM HOA_DON WHERE MaHoaDon = @MaHoaDon", con);
                cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Xác nhận thanh toán thành công!");
            this.Close();
        }
    }
}
