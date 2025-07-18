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

namespace DoAn1.DanhSachPhong
{
    public partial class formDanhSachLoaiPhong : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";
        public formDanhSachLoaiPhong()
        {
            InitializeComponent();
            label1.Dock = DockStyle.Top;
            label1.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void LoadLoaiPhongToGrid()
        {
            BangLoaiPhong.Rows.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT MaLoaiPhong, TenLoaiPhong, DonGia, SoNguoiChuan, SoNguoiToiDa FROM LOAI_PHONG";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adt.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        BangLoaiPhong.Rows.Add(
                            row["MaLoaiPhong"],
                            row["TenLoaiPhong"],
                            row["DonGia"],
                            row["SoNguoiChuan"],
                            row["SoNguoiToiDa"]
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
        }
        private void formDanhSachLoaiPhong_Load(object sender, EventArgs e)
        {
                        LoadLoaiPhongToGrid();
        }

        private void BangLoaiPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
