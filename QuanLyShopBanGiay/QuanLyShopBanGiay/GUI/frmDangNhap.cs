using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyShopBanGiay.GUI
{
    public partial class frmDangNhap : Form
    {
        public delegate void Send(int dangnhap);
        public Send Sender;
        public object kq;
        public frmDangNhap()
        {
            InitializeComponent();
            Sender = new Send(TruyenThamSoDangNhap);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            SqlCommand query = conn.CreateCommand();
            query.CommandType = CommandType.StoredProcedure;
            query.CommandText = "KiemTraTKMK";
            query.Parameters.AddWithValue("@UserName", txtTK.Text);
            query.Parameters.AddWithValue("@Password", txtMK.Text);
            conn.Open();
            kq = query.ExecuteScalar();
            int code = Convert.ToInt32(kq);
            string quyen = PhanQuyen(txtTK.Text);
            if (code == 0)
            {
                MessageBox.Show("Tài khoản mật khẩu không đúng hoặc không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTK.Text = "";
                txtMK.Text = "";
            }
            else if (code == 1)
            {
                MessageBox.Show("Chào mừng Admin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmQuanLy frm = new frmQuanLy(quyen);
                frm.ShowDialog();
            }
            else if (code == 2)
            {
                MessageBox.Show("Chào mừng quản lý đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmQuanLy frm = new frmQuanLy(quyen);
                frm.ShowDialog();
            }
            else if (code == 3)
            {
                MessageBox.Show("Chào mừng user đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmQuanLy frm = new frmQuanLy(quyen);
                frm.ShowDialog();
            }
            conn.Close();
            conn.Dispose();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            string t = "Bạn có muốn thoát chương trình ?";
            DialogResult dialogResult = MessageBox.Show(t, "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked)
            {
                txtMK.PasswordChar = (char)0;
            }
            else
            {
                txtMK.PasswordChar = '*';
            }
        }
        private void TruyenThamSoDangNhap(int dn)
        {
            dn = (int)kq;
        }

        private string PhanQuyen(string username)
        {
            string kq = null; // Khởi tạo kết quả là null để tránh lỗi truy cập null khi có ngoại lệ
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            SqlCommand query = conn.CreateCommand();
            query.CommandType = CommandType.StoredProcedure;
            query.CommandText = "LayQuyenTheoTK";

            query.Parameters.AddWithValue("@UserName", username);
            conn.Open();

            try
            {
                // Thực thi câu truy vấn và gán kết quả cho biến kq
                object result = query.ExecuteScalar();
                if (result != null)
                {
                    kq = result.ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Đã xảy ra lỗi khi lấy quyền người dùng. Chi tiết: " + e.Message);

            }
            finally
            {
                // Đảm bảo rằng kết nối được đóng sau khi sử dụng
                conn.Close();
            }

            return kq;
        }

    }
}
