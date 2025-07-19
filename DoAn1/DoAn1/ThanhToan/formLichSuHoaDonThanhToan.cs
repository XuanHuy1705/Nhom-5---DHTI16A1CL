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
    public partial class formLichSuHoaDonThanhToan : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";

        public formLichSuHoaDonThanhToan()
        {
            InitializeComponent();
        }
        private void LoadData(string maHoaDon = "")
        {
            dataGridView1.Rows.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT MaHoaDon, MaPhong, TongTien, NgayThanhToan, PhuongThucThanhToan, GhiChu FROM HOA_DON_THANH_TOAN";
                if (!string.IsNullOrEmpty(maHoaDon))
                {
                    query += " WHERE MaHoaDon = @MaHoaDon";
                }
                SqlCommand cmd = new SqlCommand(query, con);
                if (!string.IsNullOrEmpty(maHoaDon))
                {
                    cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                }
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    dataGridView1.Rows.Add(
                        row["MaHoaDon"],
                        row["MaPhong"],
                        row["TongTien"],
                        Convert.ToDateTime(row["NgayThanhToan"]).ToString("dd/MM/yyyy"), // chỉ ngày/tháng/năm
                        row["PhuongThucThanhToan"],
                        row["GhiChu"]
                    );
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string maHoaDon = TimMaHoaDon.Text.Trim();
            LoadData(maHoaDon);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void formLichSuHoaDonThanhToan_Load(object sender, EventArgs e)
        {
                        LoadData();
        }
    }
}
