using DoAn1.OrderPhong;
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
    public partial class formDatPhong : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;
        public formDatPhong()
        {
            InitializeComponent();
        }

        private void ExportDataToGrid()
        {
            BangKhachHang.Rows.Clear();

            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                // Chỉ lấy các phòng có TinhTrangPhong = 0 (False)
                cmd = new SqlCommand("SELECT * FROM DANH_SACH_PHONG_THUE WHERE TinhTrangPhong = 0", con);
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string tinhTrang = "Trống";
                    BangKhachHang.Rows.Add(
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
        }
        private void formDatPhong_Load(object sender, EventArgs e)
        {
            ExportDataToGrid();
        }

        private void BangKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DatPhongMoi_Click(object sender, EventArgs e)
        {
            var themPhongForm = new formThemThongTinDatPhong();
            if (themPhongForm.ShowDialog() == DialogResult.OK)
            {
                ExportDataToGrid();
            }
        }

        private void SuaThongTinDatPhong_Click(object sender, EventArgs e)
        {
            var chonPhongForm = new formChonPhongSuaThongTin();
            chonPhongForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportDataToGrid();
        }

        private void ThemDanhSach_Click(object sender, EventArgs e)
        {
            var danhSachForm = new DoAn1.OrderPhong.DatPhong.formDanhSachPhongDangThue();
            danhSachForm.ShowDialog();
        }
    }
}
