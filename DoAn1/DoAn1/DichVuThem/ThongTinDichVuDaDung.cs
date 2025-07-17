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

namespace DoAn1.DichVuThem
{
    public partial class ThongTinDichVuDaDung : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhachSan;Integrated Security=True";
        public ThongTinDichVuDaDung()
        {
            InitializeComponent();
        }
        public ThongTinDichVuDaDung(DataTable data)
        {
            InitializeComponent();
            LoadData(data);
        }
        private void LoadData(DataTable data)
        {
            foreach (DataRow row in data.Rows)
            {
                DichVuDaDat.Rows.Add(
                    row["MaDichVu"],
                    row["MaPhong"],
                    row["SoLuong"]
                );
            }
        }

        private void DichVuDaDat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
