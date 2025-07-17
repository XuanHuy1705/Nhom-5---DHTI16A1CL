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
    public partial class formXoaThongTin : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";

        public formXoaThongTin()
        {
            InitializeComponent();
        }

        private void XoaThongTin_Click(object sender, EventArgs e)
        {
            string column = LoaiDuLieu.SelectedItem?.ToString();
            string value = TextField.Text.Trim();

            if (string.IsNullOrEmpty(column) || string.IsNullOrEmpty(value))
            {
                MessageBox.Show("Vui lòng chọn loại dữ liệu và nhập giá trị cần xóa.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = $"DELETE FROM KHACH_HANG WHERE [{column}] = @value";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@value", value);
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("Xóa khách hàng thành công!");
                    else
                        MessageBox.Show("Không tìm thấy dữ liệu phù hợp để xóa.");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message);
                }
            }
        }
    }
}
