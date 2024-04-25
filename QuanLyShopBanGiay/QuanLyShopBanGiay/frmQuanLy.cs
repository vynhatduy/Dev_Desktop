using QuanLyShopBanGiay.GUI;
using QuanLyShopBanGiay.GUI.FormAdmin;
using QuanLyShopBanGiay.GUI.FormQuanLy;
using QuanLyShopBanGiay.GUI.FormQuanTri;
using QuanLyShopBanGiay.GUI.FromKho;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyShopBanGiay
{


    public partial class frmQuanLy : Form
    {
        //#region phương thức bổ trợ
        //private void resetColor(Button btn)
        //{


        //    foreach (Button item in btn.Controls)
        //    {
        //        item.BackColor = Color.DodgerBlue;
        //        item.ForeColor = Color.White;
        //    }
        //}
        //private void setClickEventButton(Button btn)
        //{
        //    foreach (object item in panel1.Controls)
        //    {
        //        if (item is Button)
        //        {
        //            resetColor((Button)item);
        //        }
        //    }

        //    btn.ForeColor = Color.LightSkyBlue;
        //    btn.BackColor = Color.FromArgb(239, 239, 239);
        //}
        //#endregion
        public int dn;
        public string quyen;
        public frmQuanLy(string quyen)
        {
            InitializeComponent();
            this.quyen = quyen;
        }

        private void btnQuanTriHeThong_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();
            // setClickEventButton(btnQuanTriHeThong);
            frmQuanLyTaiKhoan frm = new frmQuanLyTaiKhoan();
            pnlNoiDung.Height = frm.Height;
            pnlNoiDung.AutoScroll = true;
            foreach (Form frmItem in pnlNoiDung.Controls)
            {
                if (frmItem is frmQuanLyTaiKhoan)
                {
                    frmItem.BringToFront();
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = 0;
            pnlNoiDung.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void btnQuanLyBanHang_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();
            // setClickEventButton(btnQuanLyBanHang);
            frmQuanLyShop frm = new frmQuanLyShop();
            pnlNoiDung.Height = frm.Height;
            pnlNoiDung.AutoScroll = true;
            foreach (Form frmItem in pnlNoiDung.Controls)
            {
                if (frmItem is frmQuanLyShop)
                {
                    frmItem.BringToFront();
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = 0;
            pnlNoiDung.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void btnQuanLyKho_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();
            // setClickEventButton(btnQuanLyKho);
            frmQuanLyKho frm = new frmQuanLyKho();
            pnlNoiDung.Height = frm.Height;
            pnlNoiDung.AutoScroll = true;
            foreach (Form frmItem in pnlNoiDung.Controls)
            {
                if (frmItem is frmQuanLyKho)
                {
                    frmItem.BringToFront();
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = 0;
            pnlNoiDung.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void btnQuanTriCuaHang_Click(object sender, EventArgs e)
        {

            pnlNoiDung.Controls.Clear();
            //setClickEventButton(btnQuanTriCuaHang);
            frmQuanTriCuaHang frm = new frmQuanTriCuaHang();
            pnlNoiDung.Height = frm.Height;
            pnlNoiDung.AutoScroll = true;
            foreach (Form frmItem in pnlNoiDung.Controls)
            {
                if (frmItem is frmQuanTriCuaHang)
                {
                    frmItem.BringToFront();
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = 0;
            pnlNoiDung.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }


        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
        }

        private void pnlNoiDung_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            if(quyen.CompareTo("Q3")==0)
            {
                btnQuanLyTaiKhoan.Hide();
                btnQuanTriCuaHang.Hide();
            }
        }
        private void querySend_Click(object sender, EventArgs e)
        {
            //frmDangNhap frm = new frmDangNhap();
            //frm.Sender(dn);
        }



    }
}
