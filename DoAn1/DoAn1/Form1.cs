namespace DoAn1
{
    public partial class Form1 : Form
    {
        formDatPhong DatPhong;
        formTraPhong TraPhong;
        formDanhSachPhong DanhSachPhong;
        formDichVuThem DichVuThem;
        formThanhToan ThanhToan;
        formCapNhatThongTin CapNhatThongTin;
        Form1 form;

        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            mdiProp();
        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (DatPhong == null)
            {
                DatPhong = new formDatPhong();
                DatPhong.FormClosed += DatPhong_FormClosed;
                DatPhong.MdiParent = this;
                DatPhong.Dock = DockStyle.Fill;
                DatPhong.Show();
            }
            else
            {
                DatPhong.Activate();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (CapNhatThongTin == null)
            {
                CapNhatThongTin = new formCapNhatThongTin();
                CapNhatThongTin.FormClosed += CapNhatThongTin_FormClosed;
                CapNhatThongTin.MdiParent = this;
                CapNhatThongTin.Dock = DockStyle.Fill;
                CapNhatThongTin.Show();
            }
            else
            {
                CapNhatThongTin.Activate();
            }
        }

        private void CapNhatThongTin_FormClosed(object? sender, FormClosedEventArgs e)
        {
            CapNhatThongTin = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ThanhToan == null)
            {
                ThanhToan = new formThanhToan();
                ThanhToan.FormClosed += ThanhToan_FormClosed;
                ThanhToan.MdiParent = this;
                ThanhToan.Dock = DockStyle.Fill;
                ThanhToan.Show();
            }
            else
            {
                ThanhToan.Activate();
            }
        }

        private void ThanhToan_FormClosed(object? sender, FormClosedEventArgs e)
        {
            ThanhToan = null;
        }

        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 158)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 53)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void OrderPhong_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 40)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 186)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DatPhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatPhong = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (TraPhong == null)
            {
                TraPhong = new formTraPhong();
                TraPhong.FormClosed += TraPhong_FormClosed;
                TraPhong.MdiParent = this;
                TraPhong.Dock = DockStyle.Fill;
                TraPhong.Show();
            }
            else
            {
                TraPhong.Activate();
            }
        }

        private void TraPhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            TraPhong = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (DichVuThem == null)
            {
                DichVuThem = new formDichVuThem();
                DichVuThem.FormClosed += DichVuThem_FormClosed;
                DichVuThem.MdiParent = this;
                DichVuThem.Dock = DockStyle.Fill;
                DichVuThem.Show();
            }
            else
            {
                DichVuThem.Activate();
            }
        }

        private void DichVuThem_FormClosed(object? sender, FormClosedEventArgs e)
        {

            DichVuThem = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DanhSachPhong == null)
            {
                DanhSachPhong = new formDanhSachPhong();
                DanhSachPhong.FormClosed += DanhSachPhong_FormClosed;
                DanhSachPhong.MdiParent = this;
                DanhSachPhong.Dock = DockStyle.Fill;
                DanhSachPhong.Show();
            }
            else
            {
                DanhSachPhong.Activate();
            }
        }

        private void DanhSachPhong_FormClosed(object? sender, FormClosedEventArgs e)
        {
            DanhSachPhong = null;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
