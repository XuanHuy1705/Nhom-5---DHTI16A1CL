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
                cmd = new SqlCommand("SELECT * FROM DANH_SACH_PHONG_CHO_THUE", con);
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string ngayNhan = "";
                    string ngayDuKienTra = "";
                    if (row["NgayNhan"] != DBNull.Value)
                        ngayNhan = Convert.ToDateTime(row["NgayNhan"]).ToString("dd/MM/yyyy");
                    if (row["NgayDuKienTra"] != DBNull.Value)
                        ngayDuKienTra = Convert.ToDateTime(row["NgayDuKienTra"]).ToString("dd/MM/yyyy");

                    BangKhachHang.Rows.Add(
                        row["MaPhong"],
                        row["MaLoaiPhong"],
                        row["MaKhachHang"],
                        ngayNhan,
                        ngayDuKienTra,
                        row["GhiChu"]
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
    }
}
