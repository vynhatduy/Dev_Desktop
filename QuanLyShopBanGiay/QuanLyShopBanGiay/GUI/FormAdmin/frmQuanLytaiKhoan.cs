using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyShopBanGiay.GUI.FormAdmin
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        private DataTable tableQLTK;
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            HienThiThongTaiKhoan();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HienThiThongTaiKhoan()
        {
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            var query = "select *from QL_TaiKhoan";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            tableQLTK = new DataTable();
            conn.Open();
            adapter.Fill(tableQLTK);
            conn.Close();
            conn.Dispose();
            dgvThongTin.DataSource = tableQLTK;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string s2;
            if (cboChucVu.Text.CompareTo("Quản trị") == 0)
                s2 = "Q1";
            else if (cboChucVu.Text.CompareTo("Quản lý") == 0)
                s2 = "Q2";
            else
                s2 = "Q3";
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            SqlCommand query = conn.CreateCommand();
            query.CommandText = "update QL_TaiKhoan  set TaiKhoan = N'" + txtTenTK.Text + "',MatKhau = N'" + txtMK.Text + "',MaNV= N'" + txtMaNV.Text + "',MaQuyen = '" + s2 + "',TrangThai = N'" + cboTrangThai.Text + "' where TaiKhoan = '" + txtTenTK.Text + "'";
            conn.Open();
            int numRowAffected = query.ExecuteNonQuery();
            if (numRowAffected > 0)
            {

                MessageBox.Show("Sửa thông tin thành công", "Message");
                this.ResetText();
            }
            else
            {
                MessageBox.Show("Lỗi thao tác!");
            }
            conn.Close();
            conn.Dispose();
            HienThiThongTaiKhoan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            SqlCommand query = conn.CreateCommand();
            query.CommandText = "delete from QL_TaiKhoan where TaiKhoan = N'" + txtTenTK.Text + "'";
            conn.Open();
            int numRowAffected = query.ExecuteNonQuery();
            if (numRowAffected > 0)
            {

                MessageBox.Show("Sửa thông tin thành công", "Message");
                this.ResetText();
            }
            else
            {
                MessageBox.Show("Lỗi thao tác!");
            }
            conn.Close();
            conn.Dispose();
            HienThiThongTaiKhoan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string s1 = "Q3";
            if (cboChucVu.Text.CompareTo("Quản trị") == 0)
                s1 = "Q1";
            else
                s1 = "Q2";

            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            SqlCommand query = conn.CreateCommand();
            query.CommandText = "insert into QL_TaiKhoan values ('" + txtTenTK.Text + "','" + txtMK.Text + "','" + txtMaNV.Text + "','" + s1 + "',N'" + cboTrangThai.Text + "')";
            conn.Open();
            int numRowAffected = query.ExecuteNonQuery();
            if (numRowAffected > 0)
            {

                MessageBox.Show("Thêm tài khoản thành công", "Message");
                this.ResetText();
            }
            else
            {
                MessageBox.Show("Lỗi thao tác!");
            }
            conn.Close();
            conn.Dispose();
            HienThiThongTaiKhoan();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            HienThiThongTaiKhoan();
            if (txtTenTK.Text == null && txtMaNV == null)
            {
                MessageBox.Show("Nhập thông tin mã nhân viên hoặc tài khoản và thử lại", "Warning");
            }
            else if (txtTenTK.Text != null)
            {
                string filterEx = "TaiKhoan like '%" + txtTenTK.Text + "%' ";
                string sortEx = "MaQuyen desc";
                DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;
                DataView tableQLTKview = new DataView(tableQLTK, filterEx, sortEx, rowStateFilter);
                dgvThongTin.DataSource = tableQLTKview;
            }
            if (txtMaNV.Text != null)
            {
                string filterEx = "MaNV = '" + txtMaNV.Text + "' ";
                string sortEx = "MaQuyen desc";
                DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;
                DataView tableQLTKview = new DataView(tableQLTK, filterEx, sortEx, rowStateFilter);
                dgvThongTin.DataSource = tableQLTKview;
            }
        }

        private void dgvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenTK.ReadOnly = true;
            int i;
            i = dgvThongTin.CurrentRow.Index;
            txtTenTK.Text = dgvThongTin.Rows[i].Cells[0].Value.ToString();
            txtMK.Text = dgvThongTin.Rows[i].Cells[1].Value.ToString();
            txtMaNV.Text = dgvThongTin.Rows[i].Cells[2].Value.ToString();
            cboChucVu.Text = dgvThongTin.Rows[i].Cells[3].Value.ToString();
        }
    }
}
