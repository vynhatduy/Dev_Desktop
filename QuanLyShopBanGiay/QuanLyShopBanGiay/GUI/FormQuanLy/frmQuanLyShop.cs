using System;
using System.Windows.Forms;

namespace QuanLyShopBanGiay.GUI.FormQuanLy
{
    public partial class frmQuanLyShop : Form
    {
        public frmQuanLyShop()
        {
            InitializeComponent();
        }

        private void btnnLapHoaDon_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
            panel1.BringToFront();
            frmLapHoaDon frm = new frmLapHoaDon();
            foreach (Form frmItem in panel1.Controls)
            {
                if (frmItem is frmLapHoaDon)
                {
                    panel1.BringToFront();
                    frmItem.BringToFront();
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = 0;
            panel1.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void btnDanhSachHoaDon_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
            panel1.BringToFront();
            frmDanhSachHoaDon frm = new frmDanhSachHoaDon();
            foreach (Form frmItem in panel1.Controls)
            {
                if (frmItem is frmDanhSachHoaDon)
                {
                    panel1.BringToFront();
                    frmItem.BringToFront();
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = 0;
            panel1.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void btnDanhSachKhachHang_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
            panel1.BringToFront();
            frmDanhSachKhachHang frm = new frmDanhSachKhachHang();
            foreach (Form frmItem in panel1.Controls)
            {
                if (frmItem is frmDanhSachKhachHang)
                {
                    panel1.BringToFront();
                    frmItem.BringToFront();
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = 0;
            panel1.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }
    }
}
