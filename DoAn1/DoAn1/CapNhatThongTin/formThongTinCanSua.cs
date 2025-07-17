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
    public partial class formThongTinCanSua : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";
        public formThongTinCanSua()
        {
            InitializeComponent();
        }

        private void XacNhan_Click(object sender, EventArgs e)
        {
            string? column = LoaiDuLieu.SelectedItem?.ToString();
            string value = TextField.Text.Trim();

            if (string.IsNullOrEmpty(column) || string.IsNullOrEmpty(value))
            {
                MessageBox.Show("Vui lòng chọn loại dữ liệu và nhập giá trị cần tìm.");
                return;
            }

            using (var con = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = $"SELECT TOP 1 * FROM KHACH_HANG WHERE [{column}] = @value";
                    var adt = new System.Data.SqlClient.SqlDataAdapter(query, con);
                    adt.SelectCommand.Parameters.AddWithValue("@value", value);
                    DataTable dt = new DataTable();
                    adt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        formSuaThongTin suaForm = new formSuaThongTin();
                        suaForm.MaKhachHang.Text = row["MaKhachHang"].ToString();
                        suaForm.TenKhachHang.Text = row["TenKhachHang"].ToString();
                        suaForm.CMND.Text = row["CMND"].ToString();
                        suaForm.DiaChi.Text = row["DiaChi"].ToString();
                        suaForm.DienThoai.Text = row["DienThoai"].ToString();
                        suaForm.QuocTich.Text = row["QuocTich"].ToString();
                        suaForm.GioiTinh.SelectedItem = row["GioiTinh"].ToString();
                        suaForm.OriginalMaKhachHang = row["MaKhachHang"]?.ToString() ?? "";

                        this.Hide();
                        suaForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin phù hợp.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
                }
            }
        }
    }
}
