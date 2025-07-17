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

        private void ExportDataToGrid()
        {
            BangDanhSachPhong.Rows.Clear();

            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM LOAI_PHONG", con);
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    BangDanhSachPhong.Rows.Add(
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
    }
}
