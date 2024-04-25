using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyShopBanGiay.GUI.FormQuanLy
{

    public partial class frmLapHoaDon : Form
    {
        private DataTable tableSP;
        public frmLapHoaDon()
        {
            InitializeComponent();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
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

        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            HienThiSanPham();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
            dgvThongTinChiTieTHD.DataSource = tableSP;
        }
        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = false;
            txtTenKH.ReadOnly = false;
            mtxtSDT.ReadOnly = false;
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtMaHD.Text = "";
            txtMaNV.Text = "";
            txtTenKH.Text = "";
            txtThanhTien.Text = "";
            //txtTongGiaTri.Text = "";
            mtxtSDT.Text = "";
            nmudSoLuong.Value = 1;
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            int i;
            i = dgvThongTinChiTieTHD.CurrentRow.Index;
            int gia = int.Parse(dgvThongTinChiTieTHD.Rows[i].Cells[5].Value.ToString());
            var thanhtien = nmudSoLuong.Value * gia;
            txtThanhTien.Text = thanhtien.ToString();
            txtMaNV.ReadOnly = true;
            txtTenKH.ReadOnly = true;
            mtxtSDT.ReadOnly = true;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            SqlCommand query1 = conn.CreateCommand();
            SqlCommand query2 = conn.CreateCommand();
            query1.CommandText = "execute ThemKH  @sdt, @ten";

            query1.Parameters.Add("@sdt", SqlDbType.NChar, 10);
            query1.Parameters.Add("@ten", SqlDbType.NVarChar, 30);


            query1.Parameters["@sdt"].Value = mtxtSDT.Text;
            query1.Parameters["@ten"].Value = txtTenKH.Text;

            query2.CommandText = "execute ThemHD_X @MaNV,@TenKH,@SDT,@MaHang,@TenHang,@SoLuong,@ThanhTien,@NgayLap";

            query2.Parameters.Add("@MaNV", SqlDbType.NChar, 5);
            query2.Parameters.Add("@TenKH", SqlDbType.NVarChar, 30);
            query2.Parameters.Add("@SDT", SqlDbType.NChar, 10);
            query2.Parameters.Add("@MaHang", SqlDbType.NChar, 5);
            query2.Parameters.Add("@TenHang", SqlDbType.NVarChar, 30);
            query2.Parameters.Add("@SoLuong", SqlDbType.Int);
            query2.Parameters.Add("@ThanhTien", SqlDbType.NChar, 100);
            query2.Parameters.Add("@NgayLap", SqlDbType.DateTime);

            query2.Parameters["@MaNV"].Value = txtMaNV.Text;
            query2.Parameters["@TenKH"].Value = txtTenKH.Text;
            query2.Parameters["@SDT"].Value = mtxtSDT.Text;
            query2.Parameters["@MaHang"].Value = txtMaHang.Text;
            query2.Parameters["@TenHang"].Value = txtTenHang.Text;
            query2.Parameters["@SoLuong"].Value = nmudSoLuong.Value.ToString();
            query2.Parameters["@ThanhTien"].Value = txtThanhTien.Text;
            query2.Parameters["@NgayLap"].Value = DateTime.Now.ToString();

            conn.Open();
            query1.ExecuteScalar();
            int numRowAffected = query2.ExecuteNonQuery();
            if (numRowAffected > 0)
            {

                MessageBox.Show("Thêm hóa đơn thành công", "Message");
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

        private void dgvThongTinChiTieTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaHD.ReadOnly = true;
            int i;
            i = dgvThongTinChiTieTHD.CurrentRow.Index;
            txtMaHang.Text = dgvThongTinChiTieTHD.Rows[i].Cells[0].Value.ToString();
            txtTenHang.Text = dgvThongTinChiTieTHD.Rows[i].Cells[1].Value.ToString();
            int gia = int.Parse(dgvThongTinChiTieTHD.Rows[i].Cells[5].Value.ToString());
            var thanhtien = nmudSoLuong.Value * gia;
            txtThanhTien.Text = thanhtien.ToString();
        }
    }
}
