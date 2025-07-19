using DoAn1.ThanhToan;
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
    public partial class formThanhToan : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";
        private void LoadHoaDon(string maPhongFilter = "")
        {
            dataGridViewHoaDon.Rows.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT MaHoaDon, MaPhong, MaKhach, NgayNhan, NgayTra, TongTienDichVu, TongTien, NgayLapHoaDon FROM HOA_DON";
                if (!string.IsNullOrEmpty(maPhongFilter))
                {
                    query += " WHERE MaPhong LIKE @MaPhong";
                }
                SqlCommand cmd = new SqlCommand(query, con);
                if (!string.IsNullOrEmpty(maPhongFilter))
                {
                    cmd.Parameters.AddWithValue("@MaPhong", "%" + maPhongFilter + "%");
                }
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    dataGridViewHoaDon.Rows.Add(
                        row["MaHoaDon"],
                        row["MaPhong"],
                        row["MaKhach"],
                        Convert.ToDateTime(row["NgayNhan"]).ToString("dd/MM/yyyy"),
                        Convert.ToDateTime(row["NgayTra"]).ToString("dd/MM/yyyy"),
                        row["TongTienDichVu"],
                        row["TongTien"],
                        Convert.ToDateTime(row["NgayLapHoaDon"]).ToString("dd/MM/yyyy")
                    );
                }
            }
        }
        public formThanhToan()
        {
            InitializeComponent();
        }

        private void formThanhToan_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void TimKiem_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text.Trim();
            LoadHoaDon(maPhong);
        }

        private void ThanhToan_Click(object sender, EventArgs e)
        {
            var frm = new formChonThanhToan();
            frm.ShowDialog();
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formLichSuHoaDonThanhToan lichSuHoaDon = new formLichSuHoaDonThanhToan();
            lichSuHoaDon.ShowDialog();
        }
    }
}
