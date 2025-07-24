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
using ClosedXML.Excel;

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
            if(BangKhachHang.SelectedRows.Count == 0)
    {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa.");
                return;
            }

            var selectedRow = BangKhachHang.SelectedRows[0];
            var maKhachHang = selectedRow.Cells[0].Value?.ToString();

            if (string.IsNullOrEmpty(maKhachHang))
            {
                MessageBox.Show("Không thể xác định khách hàng cần xóa.");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var cmd = new SqlCommand("DELETE FROM KHACH_HANG WHERE MaKhachHang = @MaKhachHang", con);
                    cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa khách hàng thành công!");
                        LoadAllData();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng để xóa.");
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("REFERENCE constraint") && ex.Message.Contains("conflicted"))
                    {
                        MessageBox.Show("Không thể xóa khách hàng này vì đang có dữ liệu liên quan (ví dụ: khách hàng đã thuê phòng). Vui lòng kiểm tra lại!");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message);
                    }
                }
            }
        }

        private void SuaKhachHang_Click(object sender, EventArgs e)
        {
            formThongTinCanSua thongTinForm = new formThongTinCanSua();
            thongTinForm.FormClosed += (s, args) => { LoadAllData(); };
            thongTinForm.ShowDialog();
        }

        private void ThemFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel Files|*.xlsx;*.xls|CSV Files|*.csv";
                ofd.Title = "Chọn file dữ liệu khách hàng";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var filePath = ofd.FileName;
                    var ext = System.IO.Path.GetExtension(filePath).ToLower();
                    var customers = new List<(string, string, string, string, string, string, string)>();

                    if (ext == ".xlsx" || ext == ".xls")
                    {
                        using (var workbook = new XLWorkbook(filePath))
                        {
                            var ws = workbook.Worksheets.First();
                            // Assuming first row is header, data starts from row 2
                            for (int r = 2; r <= ws.LastRowUsed().RowNumber(); r++)
                            {
                                var row = ws.Row(r);
                                customers.Add((
                                    row.Cell(1).GetString(), // MaKhachHang
                                    row.Cell(2).GetString(), // TenKhachHang
                                    row.Cell(3).GetString(), // CMND
                                    row.Cell(4).GetString(), // GioiTinh
                                    row.Cell(5).GetString(), // DiaChi
                                    row.Cell(6).GetString(), // DienThoai
                                    row.Cell(7).GetString()  // QuocTich
                                ));
                            }
                        }
                    }
                    else if (ext == ".csv")
                    {
                        var lines = File.ReadAllLines(filePath);
                        for (int i = 1; i < lines.Length; i++) // skip header
                        {
                            var cols = lines[i].Split(',');
                            if (cols.Length >= 7)
                            {
                                customers.Add((
                                    cols[0], cols[1], cols[2], cols[3], cols[4], cols[5], cols[6]
                                ));
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Định dạng file không hỗ trợ.");
                        return;
                    }

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        foreach (var c in customers)
                        {
                            var cmd = new SqlCommand(
                                "INSERT INTO KHACH_HANG (MaKhachHang, TenKhachHang, CMND, GioiTinh, DiaChi, DienThoai, QuocTich) " +
                                "VALUES (@MaKhachHang, @TenKhachHang, @CMND, @GioiTinh, @DiaChi, @DienThoai, @QuocTich)", con);
                            cmd.Parameters.AddWithValue("@MaKhachHang", c.Item1);
                            cmd.Parameters.AddWithValue("@TenKhachHang", c.Item2);
                            cmd.Parameters.AddWithValue("@CMND", c.Item3);
                            cmd.Parameters.AddWithValue("@GioiTinh", c.Item4);
                            cmd.Parameters.AddWithValue("@DiaChi", c.Item5);
                            cmd.Parameters.AddWithValue("@DienThoai", c.Item6);
                            cmd.Parameters.AddWithValue("@QuocTich", c.Item7);
                            try { cmd.ExecuteNonQuery(); } catch { /* handle duplicates or errors if needed */ }
                        }
                    }

                    LoadAllData();
                    MessageBox.Show("Thêm dữ liệu từ file thành công!");
                }
            }
        }
    }
}
