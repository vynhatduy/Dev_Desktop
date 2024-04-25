using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyShopBanGiay.GUI.FromKho
{
    public partial class frmNhapKho : Form
    {

        public frmNhapKho()
        {
            InitializeComponent();
        }

        private void frmNhapKho_Load(object sender, EventArgs e)
        {

        }


        private void btnXacNhanThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaHang.Text))
            {
                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                SqlCommand query1 = conn.CreateCommand();
                SqlCommand query2 = conn.CreateCommand();

                // Câu lệnh SQL sử dụng hàm SinhMaHD_N để sinh mã mới
                query1.CommandText = "INSERT INTO HangHoa VALUES ('" + txtMaHang.Text + "',N'" + txtTenHang.Text + "',N'" + cboMauSac.Text + "','" + nmudSize.Value.ToString() + "',N'" + cboThuongHieu.Text + "','" + txtGiaBan.Text + "','" + txtGiaVon.Text + "','" + nmudSoLuong.Value.ToString() + "'  )";
                query2.CommandText = "EXECUTE @MaHD = dbo.SinhMaHD_N"; // Thực thi hàm SinhMaHD_N và lấy giá trị trả về vào biến @MaHD

                query2.Parameters.Add("@MaHD", SqlDbType.NChar, 5).Direction = ParameterDirection.Output; // Khai báo tham số đầu ra để nhận giá trị mã mới

                try
                {
                    conn.Open();

                    query1.ExecuteNonQuery();
                    query2.ExecuteNonQuery();

                    string maHD = query2.Parameters["@MaHD"].Value.ToString(); // Lấy giá trị mã mới từ tham số đầu ra

                    MessageBox.Show("Thêm thành công Hàng hóa có mã : " + txtMaHang.Text + " và Mã hóa đơn mới: " + maHD, "Message");
                    ResetText();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Nhập thông tin và thử lại", "Warning");
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
