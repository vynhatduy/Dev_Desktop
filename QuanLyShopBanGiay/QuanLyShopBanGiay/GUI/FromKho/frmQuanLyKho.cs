using System;
using System.Windows.Forms;

namespace QuanLyShopBanGiay.GUI.FromKho
{
    public partial class frmQuanLyKho : Form
    {
        public frmQuanLyKho()
        {
            InitializeComponent();
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
            panel1.BringToFront();
            frmNhapKho frm = new frmNhapKho();
            foreach (Form frmItem in panel1.Controls)
            {
                if (frmItem is frmNhapKho)
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

        private void btnDanhSachHangTon_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
            panel1.BringToFront();
            frmDanhSachSanPham frm = new frmDanhSachSanPham();
            foreach (Form frmItem in panel1.Controls)
            {
                if (frmItem is frmDanhSachSanPham)
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
