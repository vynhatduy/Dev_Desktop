using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyShopBanGiay.GUI.FormQuanLy
{
    public partial class frmDanhSachHoaDon : Form
    {
        private DataTable tableDSHD;
        public frmDanhSachHoaDon()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.ReadOnly = true;
            int i;
            i = dgvThongTin.CurrentRow.Index;
            txtMaHD.Text = dgvThongTin.Rows[i].Cells[0].Value.ToString();
            txtMaNV.Text = dgvThongTin.Rows[i].Cells[1].Value.ToString();
            txtTenKH.Text = dgvThongTin.Rows[i].Cells[2].Value.ToString();
            mtxtSDT.Text = dgvThongTin.Rows[i].Cells[3].Value.ToString();
            txtMaHang.Text = dgvThongTin.Rows[i].Cells[4].Value.ToString();
            txtTenHang.Text = dgvThongTin.Rows[i].Cells[5].Value.ToString();
            nmudSoLuong.Text = dgvThongTin.Rows[i].Cells[6].Value.ToString();
            txtDonGia.Text = dgvThongTin.Rows[i].Cells[7].Value.ToString();

        }

        private void frmDanhSachHoaDon_Load(object sender, EventArgs e)
        {
            HienThiDanhSachHD();
        }
        private void HienThiDanhSachHD()
        {
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

            string s = "select MaHD,MaNV,TenKH,SDT,MaHang,TenHang,SoLuong,ThanhTien from HoaDon ";
            tableDSHD = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(s, conn);
            conn.Open();
            adapter.Fill(tableDSHD);
            conn.Close();
            conn.Dispose();
            dgvThongTin.DataSource = tableDSHD;

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            
            if (txtTenKH.Text == null && txtMaNV.Text == null)
            {
                MessageBox.Show("Nhập mã nhân viên hoặc tên khách hàng rồi thử lại", "message");
            }
            if (txtTenKH.Text != null)
            {
                string filterEx = "TenKH like '%" + txtTenKH.Text + "%' ";
                string sortEx = "ThanhTien desc";
                DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;
                DataView tableDSHDview = new DataView(tableDSHD, filterEx, sortEx, rowStateFilter);
                dgvThongTin.DataSource = tableDSHDview;
            }
            else
            {
                string filterEx = "MaNV like '%" + txtMaNV.Text + "%' ";
                string sortEx = "ThanhTien desc";
                DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;
                DataView tableDSHDview = new DataView(tableDSHD, filterEx, sortEx, rowStateFilter);
                dgvThongTin.DataSource = tableDSHDview;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            SqlCommand query = conn.CreateCommand();
            query.CommandText = "delete from HoaDon where MaHD = '" + txtMaHD.Text + "'";
            conn.Open();
            int numRowAffected = query.ExecuteNonQuery();
            if (numRowAffected > 0)
            {

                MessageBox.Show("Xóa Hóa đơn thành công", "Message");
                this.ResetText();
            }
            else
            {
                MessageBox.Show("Lỗi thao tác!");
            }
            conn.Close();
            conn.Dispose();
            HienThiDanhSachHD();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            SqlCommand query = conn.CreateCommand();

            query.CommandText = "update HoaDon set MaNV='" + txtMaNV.Text + "',TenKH='" + txtTenKH.Text + "',SDT='" + mtxtSDT.Text + "',MaHang='" + txtMaHang.Text + "',TenHang='" + txtTenHang.Text + "',SoLuong=" + nmudSoLuong.Value.ToString() + ",ThanhTien='" + txtDonGia.Text + "'  ";
            conn.Open();
            int numRowAffected = query.ExecuteNonQuery();
            if (numRowAffected > 0)
            {

                MessageBox.Show("Sửa hóa đơn thành công", "Message");
                this.ResetText();
            }
            else
            {
                MessageBox.Show("Lỗi thao tác!");
            }
            conn.Close();
            conn.Dispose();
            HienThiDanhSachHD();
        }
    }
}
