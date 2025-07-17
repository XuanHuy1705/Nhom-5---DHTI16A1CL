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
    public partial class formDichVuThem : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";
        public formDichVuThem()
        {
            InitializeComponent();
        }
        private void LoadDichVuData()
        {
            bangDichVu.Rows.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT MaDichVu, TenDichVu, DonVi, DonGia FROM DICH_VU";
                    SqlDataAdapter adt = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adt.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        bangDichVu.Rows.Add(
                            row["MaDichVu"],
                            row["TenDichVu"],
                            row["DonVi"],
                            row["DonGia"]
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu dịch vụ: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bangDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formDichVuThem_Load(object sender, EventArgs e)
        {
            LoadDichVuData();
        }

        private void TimKiemDichVu_Click(object sender, EventArgs e)
        {
            string tenDichVu = TimKiem.Text.Trim();
            bangDichVu.Rows.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT MaDichVu, TenDichVu, DonVi, DonGia FROM DICH_VU WHERE TenDichVu LIKE @TenDichVu";
                    SqlDataAdapter adt = new SqlDataAdapter(query, con);
                    adt.SelectCommand.Parameters.AddWithValue("@TenDichVu", "%" + tenDichVu + "%");
                    DataTable dt = new DataTable();
                    adt.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        bangDichVu.Rows.Add(
                            row["MaDichVu"],
                            row["TenDichVu"],
                            row["DonVi"],
                            row["DonGia"]
                        );
                    }

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy dịch vụ phù hợp.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm dịch vụ: " + ex.Message);
                }
            }
        }

        private void ShowaAll_Click(object sender, EventArgs e)
        {
                        LoadDichVuData();
        }
        private void TraCuu_Click(object sender, EventArgs e)
        {
            string maPhong = TraCuuThongTin.Text.Trim();
            if (string.IsNullOrEmpty(maPhong))
            {
                MessageBox.Show("Vui lòng nhập mã phòng cần tra cứu.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM DANH_SACH_SU_DUNG_DICH_VU WHERE MaPhong = @MaPhong";
                    SqlDataAdapter adt = new SqlDataAdapter(query, con);
                    adt.SelectCommand.Parameters.AddWithValue("@MaPhong", maPhong);
                    DataTable dt = new DataTable();
                    adt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        // Truyền DataTable sang form ThongTinDichVuDaDung để hiển thị
                        var thongTinForm = new DoAn1.DichVuThem.ThongTinDichVuDaDung(dt);
                        thongTinForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin dịch vụ cho mã phòng này.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tra cứu: " + ex.Message);
                }
            }
        }
    }
}
