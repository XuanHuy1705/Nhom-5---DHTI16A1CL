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
    public partial class formCapNhatThongTin : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";

        private void LoadAllData()
        {
            BangKhachHang.Rows.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM KHACH_HANG";
                    SqlDataAdapter adt = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adt.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        BangKhachHang.Rows.Add(
                            row["MaKhachHang"],
                            row["TenKhachHang"],
                            row["CMND"],
                            row["GioiTinh"],
                            row["DiaChi"],
                            row["DienThoai"],
                            row["QuocTich"]
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
                }
            }
        }
        public formCapNhatThongTin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void formCapNhatThongTin_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            string column = LoaiTimKiem.SelectedItem?.ToString();
            string value = TimKiem.Text.Trim();

            if (string.IsNullOrEmpty(column) || string.IsNullOrEmpty(value))
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm và nhập dữ liệu.");
                return;
            }

            BangKhachHang.Rows.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = $"SELECT * FROM KHACH_HANG WHERE [{column}] LIKE @value";
                    SqlDataAdapter adt = new SqlDataAdapter(query, con);
                    adt.SelectCommand.Parameters.AddWithValue("@value", "%" + value + "%");
                    DataTable dt = new DataTable();
                    adt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            BangKhachHang.Rows.Add(
                                row["MaKhachHang"],
                                row["TenKhachHang"],
                                row["CMND"],
                                row["GioiTinh"],
                                row["DiaChi"],
                                row["DienThoai"],
                                row["QuocTich"]
                            );
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy giá trị phù hợp.");
                        LoadAllData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
                }
            }
        }

        private void ViewAll_Click(object sender, EventArgs e)
        {
            BangKhachHang.Rows.Clear();
            LoadAllData();
        }

        private void ThemKhachHang_Click(object sender, EventArgs e)
        {
            formNhapThongTin nhapForm = new formNhapThongTin();
            nhapForm.FormClosed += (s, args) => { LoadAllData(); };
            nhapForm.ShowDialog();
        }

        private void XoaKhachHang_Click(object sender, EventArgs e)
        {
            formXoaThongTin xoaForm = new formXoaThongTin();
            xoaForm.FormClosed += (s, args) => { LoadAllData(); };
            xoaForm.ShowDialog();
        }

        private void SuaKhachHang_Click(object sender, EventArgs e)
        {
            formThongTinCanSua thongTinForm = new formThongTinCanSua();
            thongTinForm.FormClosed += (s, args) => { LoadAllData(); };
            thongTinForm.ShowDialog();
        }
    }
}
