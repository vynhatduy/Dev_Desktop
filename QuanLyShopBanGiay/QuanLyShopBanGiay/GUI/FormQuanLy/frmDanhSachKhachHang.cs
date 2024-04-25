
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyShopBanGiay.GUI.FormQuanLy
{
    public partial class frmDanhSachKhachHang : Form
    {
        private DataTable tableKH;
        public frmDanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhachHang();
        }
        private void HienThiDanhSachKhachHang()
        {
            var conn = new SqlConnection(ConnectionString.connectionString);
            var query = "select *from KhachHang";
            tableKH = new DataTable("KhachHang");
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            conn.Open();
            adapter.Fill(tableKH);
            conn.Close();
            conn.Dispose();
            dgvThongTin.DataSource = tableKH;
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            SqlCommand query = conn.CreateCommand();

            query.CommandText = "excute UpdateKH @id , @sdt, @ten";
            conn.Open();
            int numRowAffected = query.ExecuteNonQuery();
            if (numRowAffected > 0)
            {

                MessageBox.Show("Sửa thông tin khách hàng thành công", "Message");
                this.ResetText();
            }
            else
            {
                MessageBox.Show("Sửa khách hàng thất bại!");
            }
            conn.Close();
            conn.Dispose();
            HienThiDanhSachKhachHang();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            SqlCommand query = conn.CreateCommand();
            query.CommandText = "delete from KhachHang where ID = '" + txtMaHang.Text + "'";
            conn.Open();
            int numRowAffected = query.ExecuteNonQuery();
            if (numRowAffected > 0)
            {

                MessageBox.Show("Xóa khách hàng thành công", "Message");
                this.ResetText();
            }
            else
            {
                MessageBox.Show("Lỗi thao tác!");
            }
            conn.Close();
            conn.Dispose();
            HienThiDanhSachKhachHang();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (tableKH == null) return;
            if (txtTim.Text == null)
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Warnings");
            }
            if (rdTen.Checked)
            {
                string filterEx = "Ten like '%" + txtTim.Text + "%' ";
                string sortEx = "SDT desc";
                DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;
                DataView tableKHView = new DataView(tableKH, filterEx, sortEx, rowStateFilter);
                dgvThongTin.DataSource = tableKHView;
            }
            else
            {
                MessageBox.Show("Không có khách hàng có thông tin như đã nhập", "Warnings");
            }
            if (rdSDT.Checked)
            {
                string filterEx = "SDT like '%" + txtTim.Text + "%' ";
                string sortEx = "Ten desc";
                DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;
                DataView tableKHView = new DataView(tableKH, filterEx, sortEx, rowStateFilter);
                dgvThongTin.DataSource = tableKHView;
            }
            else
            {
                MessageBox.Show("Không có khách hàng có thông tin như đã nhập", "Warnings");
            }
        }

        private void dgvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHang.ReadOnly = true;
            int i;
            i = dgvThongTin.CurrentRow.Index;
            txtMaHang.Text = dgvThongTin.Rows[i].Cells[0].Value.ToString();
            mtxtSDT.Text = dgvThongTin.Rows[i].Cells[1].Value.ToString();
            txtTen.Text = dgvThongTin.Rows[i].Cells[2].Value.ToString();
        }
    }
}
