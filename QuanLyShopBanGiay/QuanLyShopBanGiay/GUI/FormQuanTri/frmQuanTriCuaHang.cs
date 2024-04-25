using System;
using System.Windows.Forms;

namespace QuanLyShopBanGiay.GUI.FormQuanTri
{
    public partial class frmQuanTriCuaHang : Form
    {
        public frmQuanTriCuaHang()
        {
            InitializeComponent();
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
            panel1.BringToFront();
            frmQuanLyNhanVien frm = new frmQuanLyNhanVien();
            foreach (Form frmItem in panel1.Controls)
            {
                if (frmItem is frmQuanLyNhanVien)
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

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
            panel1.BringToFront();
            frmThongKe frm = new frmThongKe();
            foreach (Form frmItem in panel1.Controls)
            {
                if (frmItem is frmThongKe)
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
