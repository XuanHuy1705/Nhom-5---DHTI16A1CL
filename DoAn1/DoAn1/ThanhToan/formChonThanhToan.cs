using DoAn1.ThanhToan;
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
    public partial class formChonThanhToan : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";

        public formChonThanhToan()
        {
            InitializeComponent();
        }

        private void formChonThanhToan_Load(object sender, EventArgs e)
        {
            // Load danh sách mã phòng từ HOA_DON vào comboBox
            ChonMaPhong.Items.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT MaPhong FROM HOA_DON", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ChonMaPhong.Items.Add(reader["MaPhong"].ToString());
                }
            }
        }

        private void ThanhToan_Click(object sender, EventArgs e)
        {
        }

        private void ThanhToan_Click_1(object sender, EventArgs e)
        {
            if (ChonMaPhong.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn mã phòng!");
                return;
            }

            // Truyền MaPhong sang formTienThanhToan
            var formTien = new DoAn1.ThanhToan.formTienThanhToan();
            formTien.MaPhongDuocChon = ChonMaPhong.SelectedItem.ToString();
            formTien.ShowDialog();
        }
    }
}