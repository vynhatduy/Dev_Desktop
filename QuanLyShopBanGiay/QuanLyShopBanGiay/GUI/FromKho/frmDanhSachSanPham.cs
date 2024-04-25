
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyShopBanGiay.GUI.FromKho
{
    public partial class frmDanhSachSanPham : Form
    {
        private DataTable tableSP;
        public frmDanhSachSanPham()
        {
            InitializeComponent();
            dgvThongTin.AutoGenerateColumns = false;
        }

        private void frmDanhSachSanPham_Load(object sender, EventArgs e)
        {
            HienThiSanPham();
        }
        private void HienThiSanPham()
        {
            var conn = new SqlConnection(ConnectionString.connectionString);

            var query = "select *from HangHoa";
            tableSP = new DataTable("HangHoa");
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            conn.Open();
            adapter.Fill(tableSP);
            conn.Close();
            dgvThongTin.DataSource = tableSP;
        }

        private void dgvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHang.ReadOnly = true;
            int i;
            i = dgvThongTin.CurrentRow.Index;
            txtMaHang.Text = dgvThongTin.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = dgvThongTin.Rows[i].Cells[1].Value.ToString();
            cboMauSac.Text = dgvThongTin.Rows[i].Cells[2].Value.ToString();
            nmudSize.Value = decimal.Parse(dgvThongTin.Rows[i].Cells[3].Value.ToString());//gán giá trị cho numericupdown
            cboThuongHieu.Text = dgvThongTin.Rows[i].Cells[4].Value.ToString();
            nmudSoLuong.Value = decimal.Parse(dgvThongTin.Rows[i].Cells[7].Value.ToString());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            SqlCommand query = conn.CreateCommand();
            query.CommandText = "update HangHoa set TenHang=N'" + txtTen.Text + "',MauSac=N'" + cboMauSac.Text + "',Size=" + nmudSize.Value.ToString() + ",ThuongHieu=N'" + cboThuongHieu.Text + "',GiaBan='" + txtGiaBan.Text + "',GiaGoc='" + txtGiaGoc.Text + "',SoLuong=" + nmudSoLuong.Value.ToString() + " where MaHang='" + txtMaHang.Text + "'     ";
            conn.Open();
            int numRowAffected = query.ExecuteNonQuery();
            if (numRowAffected > 0)
            {

                MessageBox.Show("Sửa thông tin sản phẩm thành công", "Message");
                this.ResetText();
            }
            else
            {
                MessageBox.Show("Lỗi thao tác!");
            }
            conn.Close();
            conn.Dispose();
            HienThiSanPham();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            SqlCommand query = conn.CreateCommand();
            SqlCommand query1 = conn.CreateCommand();

            query.CommandText = "delete from HangHoa where MaHang = '" + txtMaHang.Text + "'";
            query1.CommandText = "delete from HoaDon where MaHang = '" + txtMaHang.Text + "'";
            conn.Open();
            query1.ExecuteScalar();
            int numRowAffected = query.ExecuteNonQuery();
            if (numRowAffected > 0)
            {

                MessageBox.Show("Xóa sản phẩm thành công", "Message");
                this.ResetText();
            }
            else
            {
                MessageBox.Show("Lỗi thao tác!");
            }
            conn.Close();
            conn.Dispose();
            HienThiSanPham();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            HienThiSanPham();
            if (tableSP == null)
            {
                MessageBox.Show("Lỗi thao tác!", "Error");
            };
            if (txtTen.Text == null)
            {
                MessageBox.Show("Nhập thông tin tên hàng rồi thử lại", "message");
            }
            else
            {
                string filterEx = "TenHang like '%" + txtTen.Text + "%' ";
                string sortEx = "Size desc";
                DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;
                DataView tableNVView = new DataView(tableSP, filterEx, sortEx, rowStateFilter);
                dgvThongTin.DataSource = tableNVView;
            }
        }
    }
}
