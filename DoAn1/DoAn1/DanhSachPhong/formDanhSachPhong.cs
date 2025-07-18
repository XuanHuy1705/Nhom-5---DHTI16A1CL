using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAn1
{
    public partial class formDanhSachPhong : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;

        private void ExportDataToGrid(string filter = "")
        {
            BangDanhSachPhong.Rows.Clear();

            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                string query = "SELECT MaPhong, MaLoaiPhong, DonGia, TinhTrangPhong FROM DANH_SACH_PHONG_THUE";
                if (!string.IsNullOrEmpty(filter))
                {
                    query += " WHERE " + filter;
                }
                cmd = new SqlCommand(query, con);
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string tinhTrang = (row["TinhTrangPhong"] != DBNull.Value && (bool)row["TinhTrangPhong"])
                        ? "Đã Đặt"
                        : "Trống";

                    BangDanhSachPhong.Rows.Add(
                        row["MaPhong"],
                        row["MaLoaiPhong"],
                        row["DonGia"],
                        tinhTrang
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public formDanhSachPhong()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formDanhSachPhong_Load(object sender, EventArgs e)
        {
            ExportDataToGrid();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BangDanhSachPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NutDanhSach_Click(object sender, EventArgs e)
        {
            var frm = new DoAn1.DanhSachPhong.formDanhSachLoaiPhong();
            frm.ShowDialog(); // hoặc frm.Show()
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportDataToGrid("TinhTrangPhong = 1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportDataToGrid("TinhTrangPhong = 0");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExportDataToGrid();
        }
    }
}
