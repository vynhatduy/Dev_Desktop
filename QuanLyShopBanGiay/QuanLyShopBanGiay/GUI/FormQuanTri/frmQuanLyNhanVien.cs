
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyShopBanGiay.GUI.FormQuanTri
{
    public partial class frmQuanLyNhanVien : Form
    {
        private DataTable tableNV;
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            dgvThongTin.AutoGenerateColumns = false; // tự động thêm cột mới
        }


        private void HienThiNhanVien()
        {
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

            var query = "select a.MaNV,a.HoTen,a.GioiTinh,a.DiaChi,a.NgaySinh,a.SDT,b.TenQuyen from NhanVien a, PhanQuyen b where a.MaQuyen=b.MaQuyen";
            tableNV = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

            conn.Open();
            adapter.Fill(tableNV);
            conn.Close();
            conn.Dispose();
            dgvThongTin.DataSource = tableNV;
        }

        private void frmQuanLyNhanVien_Load(object sender, System.EventArgs e)
        {

            HienThiNhanVien();
        }

        private void dgvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.ReadOnly = true;
            int i;
            i = dgvThongTin.CurrentRow.Index;
            txtMaNV.Text = dgvThongTin.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = dgvThongTin.Rows[i].Cells[1].Value.ToString();
            rdNu.Checked = true;
            string gt = dgvThongTin.Rows[i].Cells[2].Value.ToString();
            if (gt == "Nam")
                rdNam.Checked = true;
            txtDiaChi.Text = dgvThongTin.Rows[i].Cells[3].Value.ToString();
            dtpNgaySinh.Text = dgvThongTin.Rows[i].Cells[4].Value.ToString();
            mtxtSDT.Text = dgvThongTin.Rows[i].Cells[5].Value.ToString();
            cboChucVu.Text = dgvThongTin.Rows[i].Cells[6].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string s1 = "Nữ";
            if (rdNam.Checked)
                s1 = "Nam";
            string s2 = "";
            if (cboChucVu.Text.CompareTo("Quản trị") == 0)
                s2 = "Q1";
            else if (cboChucVu.Text.CompareTo("Quản lý") == 0)
                s2 = "Q2";
            else
                s2 = "Q3";
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            SqlCommand query = conn.CreateCommand();
            query.CommandText = "insert into NhanVien values ('" + txtMaNV.Text + "',N'" + txtTen.Text + "',N'" + s1 + "',N'" + txtDiaChi.Text + "','" + dtpNgaySinh.Text + "','" + mtxtSDT.Text + "','" + s2 + "' )";
            conn.Open();
            int numRowAffected = query.ExecuteNonQuery();
            if (numRowAffected > 0)
            {

                MessageBox.Show("Thêm thành công nhân viên có mã : " + txtMaNV.Text, "Message");
                this.ResetText();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!");
            }
            conn.Close();
            conn.Dispose();
            ResetText();
            HienThiNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            SqlCommand query = conn.CreateCommand();
            query.CommandText = "delete from NhanVien where MaNV = '" + txtMaNV.Text + "'";
            conn.Open();
            int numRowAffected = query.ExecuteNonQuery();
            if (numRowAffected > 0)
            {

                MessageBox.Show("Xóa nhân viên thành công", "Message");
                this.ResetText();
            }
            else
            {
                MessageBox.Show("Lỗi thao tác!");
            }
            conn.Close();
            conn.Dispose();
            ResetText();
            HienThiNhanVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string gioiTinh = rdNam.Checked ? "Nam" : "Nữ";

            string maQuyen;
            if (cboChucVu.Text == "Quản trị")
                maQuyen = "Q1";
            else if (cboChucVu.Text == "Quản lý")
                maQuyen = "Q2";
            else
                maQuyen = "Q3";

            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand query = conn.CreateCommand();
                    query.CommandText = "UPDATE NhanVien SET HoTen = @HoTen, GioiTinh = @GioiTinh, DiaChi = @DiaChi, NgaySinh = @NgaySinh, SDT = @SDT, MaQuyen = @MaQuyen WHERE MaNV = @MaNV";

                    query.Parameters.AddWithValue("@HoTen", txtTen.Text);
                    query.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    query.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    query.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                    query.Parameters.AddWithValue("@SDT", mtxtSDT.Text);
                    query.Parameters.AddWithValue("@MaQuyen", maQuyen);
                    query.Parameters.AddWithValue("@MaNV", txtMaNV.Text);

                    int numRowAffected = query.ExecuteNonQuery();
                    if (numRowAffected > 0)
                    {
                        MessageBox.Show("Sửa thông tin nhân viên thành công", "Message");
                        ResetText();
                        HienThiNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Sửa nhân viên thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void ResetText()
        {
            txtMaNV.Text = "";
            txtTen.Text = "";
            mtxtSDT.Text = "";
            txtDiaChi.Text = "";
            rdNam.Checked = true;
            cboChucVu.Text = "Nhân viên";
            dtpNgaySinh.Value = DateTime.Parse("01/01/2000");
        }
        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.ResetText();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {


            HienThiNhanVien();

            if (txtTen.Text == null)
            {
                MessageBox.Show("Nhập thông tin họ tên rồi thử lại", "message");
            }
            else
            {
                string filterEx = "HoTen like '%" + txtTen.Text + "%' ";
                string sortEx = "SDT desc";
                DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;
                DataView tableNVView = new DataView(tableNV, filterEx, sortEx, rowStateFilter);
                dgvThongTin.DataSource = tableNVView;

            }
            ResetText();
        }
    }
}
