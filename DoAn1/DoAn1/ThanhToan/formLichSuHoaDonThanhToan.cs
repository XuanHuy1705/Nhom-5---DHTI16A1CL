using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace DoAn1.ThanhToan
{
    public partial class formLichSuHoaDonThanhToan : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";

        public formLichSuHoaDonThanhToan()
        {
            InitializeComponent();
        }

        private void LoadData(string maHoaDon = "")
        {
            dataGridView1.Rows.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT MaHoaDon, MaPhong, TongTien, NgayThanhToan, PhuongThucThanhToan, GhiChu FROM HOA_DON_THANH_TOAN";
                if (!string.IsNullOrEmpty(maHoaDon))
                {
                    query += " WHERE MaHoaDon = @MaHoaDon";
                }
                SqlCommand cmd = new SqlCommand(query, con);
                if (!string.IsNullOrEmpty(maHoaDon))
                {
                    cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                }
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    dataGridView1.Rows.Add(
                        row["MaHoaDon"],
                        row["MaPhong"],
                        row["TongTien"],
                        Convert.ToDateTime(row["NgayThanhToan"]).ToString("dd/MM/yyyy"),
                        row["PhuongThucThanhToan"],
                        row["GhiChu"]
                    );
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maHoaDon = TimMaHoaDon.Text.Trim();
            LoadData(maHoaDon);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void formLichSuHoaDonThanhToan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void XuatDuLieu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Workbook|*.xlsx";
                sfd.Title = "Chọn vị trí lưu file Excel";
                sfd.FileName = "Lịch Sử Hóa Đơn.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Lịch sử hóa đơn");

                        // Export column headers
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                        }

                        // Export rows
                        for (int r = 0; r < dataGridView1.Rows.Count; r++)
                        {
                            for (int c = 0; c < dataGridView1.Columns.Count; c++)
                            {
                                worksheet.Cell(r + 2, c + 1).Value = dataGridView1.Rows[r].Cells[c].Value?.ToString();
                            }
                        }

                        worksheet.Columns().AdjustToContents();
                        workbook.SaveAs(sfd.FileName);
                    }

                    MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}