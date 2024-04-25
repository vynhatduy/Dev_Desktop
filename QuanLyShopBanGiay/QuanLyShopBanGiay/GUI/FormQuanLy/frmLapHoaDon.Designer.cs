namespace QuanLyShopBanGiay.GUI.FormQuanLy
{
    partial class frmLapHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblLapHD = new System.Windows.Forms.Label();
            this.pnlMatHang = new System.Windows.Forms.Panel();
            this.nmudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.pnlKhachHang = new System.Windows.Forms.Panel();
            this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKH = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.dgvThongTinChiTieTHD = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.pnlMatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudSoLuong)).BeginInit();
            this.pnlKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChiTieTHD)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(32)))));
            this.pnlTitle.Controls.Add(this.lblLapHD);
            this.pnlTitle.Location = new System.Drawing.Point(-1, 2);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(896, 62);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblLapHD
            // 
            this.lblLapHD.AutoSize = true;
            this.lblLapHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLapHD.ForeColor = System.Drawing.Color.White;
            this.lblLapHD.Location = new System.Drawing.Point(16, 11);
            this.lblLapHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLapHD.Name = "lblLapHD";
            this.lblLapHD.Size = new System.Drawing.Size(250, 42);
            this.lblLapHD.TabIndex = 0;
            this.lblLapHD.Text = "Lập Hóa Đơn";
            // 
            // pnlMatHang
            // 
            this.pnlMatHang.BackColor = System.Drawing.Color.White;
            this.pnlMatHang.Controls.Add(this.nmudSoLuong);
            this.pnlMatHang.Controls.Add(this.lblThanhTien);
            this.pnlMatHang.Controls.Add(this.txtThanhTien);
            this.pnlMatHang.Controls.Add(this.lblSoLuong);
            this.pnlMatHang.Controls.Add(this.label3);
            this.pnlMatHang.Controls.Add(this.lblMaHang);
            this.pnlMatHang.Controls.Add(this.txtTenHang);
            this.pnlMatHang.Controls.Add(this.txtMaHang);
            this.pnlMatHang.Location = new System.Drawing.Point(62, 324);
            this.pnlMatHang.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMatHang.Name = "pnlMatHang";
            this.pnlMatHang.Size = new System.Drawing.Size(572, 213);
            this.pnlMatHang.TabIndex = 2;
            // 
            // nmudSoLuong
            // 
            this.nmudSoLuong.Location = new System.Drawing.Point(193, 109);
            this.nmudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmudSoLuong.Name = "nmudSoLuong";
            this.nmudSoLuong.Size = new System.Drawing.Size(120, 22);
            this.nmudSoLuong.TabIndex = 5;
            this.nmudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(36, 160);
            this.lblThanhTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(92, 20);
            this.lblThanhTien.TabIndex = 0;
            this.lblThanhTien.Text = "Thành Tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(193, 156);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(270, 26);
            this.txtThanhTien.TabIndex = 6;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(36, 108);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(125, 20);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "Số Lượng Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Hàng";
            // 
            // lblMaHang
            // 
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHang.Location = new System.Drawing.Point(36, 22);
            this.lblMaHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(77, 20);
            this.lblMaHang.TabIndex = 0;
            this.lblMaHang.Text = "Mã Hàng";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHang.Location = new System.Drawing.Point(193, 61);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(270, 26);
            this.txtTenHang.TabIndex = 4;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHang.Location = new System.Drawing.Point(193, 18);
            this.txtMaHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(270, 26);
            this.txtMaHang.TabIndex = 4;
            // 
            // pnlKhachHang
            // 
            this.pnlKhachHang.BackColor = System.Drawing.Color.White;
            this.pnlKhachHang.Controls.Add(this.mtxtSDT);
            this.pnlKhachHang.Controls.Add(this.label1);
            this.pnlKhachHang.Controls.Add(this.lblKH);
            this.pnlKhachHang.Controls.Add(this.MaNV);
            this.pnlKhachHang.Controls.Add(this.txtTenKH);
            this.pnlKhachHang.Controls.Add(this.txtMaNV);
            this.pnlKhachHang.Controls.Add(this.lblMaHD);
            this.pnlKhachHang.Controls.Add(this.txtMaHD);
            this.pnlKhachHang.Location = new System.Drawing.Point(62, 96);
            this.pnlKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.pnlKhachHang.Name = "pnlKhachHang";
            this.pnlKhachHang.Size = new System.Drawing.Size(572, 220);
            this.pnlKhachHang.TabIndex = 1;
            // 
            // mtxtSDT
            // 
            this.mtxtSDT.Location = new System.Drawing.Point(161, 173);
            this.mtxtSDT.Mask = "##########";
            this.mtxtSDT.Name = "mtxtSDT";
            this.mtxtSDT.Size = new System.Drawing.Size(364, 22);
            this.mtxtSDT.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SDT";
            // 
            // lblKH
            // 
            this.lblKH.AutoSize = true;
            this.lblKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKH.Location = new System.Drawing.Point(21, 132);
            this.lblKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKH.Name = "lblKH";
            this.lblKH.Size = new System.Drawing.Size(101, 20);
            this.lblKH.TabIndex = 0;
            this.lblKH.Text = "Khách Hàng";
            // 
            // MaNV
            // 
            this.MaNV.AutoSize = true;
            this.MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNV.Location = new System.Drawing.Point(19, 82);
            this.MaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(114, 20);
            this.MaNV.TabIndex = 0;
            this.MaNV.Text = "Mã Nhân Viên";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(161, 129);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(364, 26);
            this.txtTenKH.TabIndex = 2;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(161, 77);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(364, 26);
            this.txtMaNV.TabIndex = 2;
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.Location = new System.Drawing.Point(19, 31);
            this.lblMaHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(103, 20);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "Mã Hóa Đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(161, 28);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(364, 26);
            this.txtMaHD.TabIndex = 1;
            // 
            // dgvThongTinChiTieTHD
            // 
            this.dgvThongTinChiTieTHD.AllowUserToAddRows = false;
            this.dgvThongTinChiTieTHD.AllowUserToDeleteRows = false;
            this.dgvThongTinChiTieTHD.AllowUserToResizeColumns = false;
            this.dgvThongTinChiTieTHD.AllowUserToResizeRows = false;
            this.dgvThongTinChiTieTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinChiTieTHD.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongTinChiTieTHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongTinChiTieTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinChiTieTHD.Location = new System.Drawing.Point(62, 581);
            this.dgvThongTinChiTieTHD.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThongTinChiTieTHD.Name = "dgvThongTinChiTieTHD";
            this.dgvThongTinChiTieTHD.ReadOnly = true;
            this.dgvThongTinChiTieTHD.RowHeadersWidth = 51;
            this.dgvThongTinChiTieTHD.Size = new System.Drawing.Size(771, 249);
            this.dgvThongTinChiTieTHD.TabIndex = 6;
            this.dgvThongTinChiTieTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinChiTieTHD_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnMacDinh);
            this.panel1.Controls.Add(this.btnThemHD);
            this.panel1.Controls.Add(this.pnlTitle);
            this.panel1.Controls.Add(this.dgvThongTinChiTieTHD);
            this.panel1.Controls.Add(this.pnlMatHang);
            this.panel1.Controls.Add(this.pnlKhachHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 922);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 1001);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng Giá Trị";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1021);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 48);
            this.panel2.TabIndex = 8;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(790, 0);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 48);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.BackColor = System.Drawing.Color.DarkBlue;
            this.btnMacDinh.FlatAppearance.BorderSize = 0;
            this.btnMacDinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMacDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMacDinh.ForeColor = System.Drawing.Color.White;
            this.btnMacDinh.Location = new System.Drawing.Point(672, 407);
            this.btnMacDinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(160, 42);
            this.btnMacDinh.TabIndex = 3;
            this.btnMacDinh.Text = "Mặc Định";
            this.btnMacDinh.UseVisualStyleBackColor = false;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // btnThemHD
            // 
            this.btnThemHD.BackColor = System.Drawing.Color.DarkBlue;
            this.btnThemHD.FlatAppearance.BorderSize = 0;
            this.btnThemHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHD.ForeColor = System.Drawing.Color.White;
            this.btnThemHD.Location = new System.Drawing.Point(672, 249);
            this.btnThemHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(160, 42);
            this.btnThemHD.TabIndex = 3;
            this.btnThemHD.Text = "Thêm Hóa Đơn";
            this.btnThemHD.UseVisualStyleBackColor = false;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // frmLapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(896, 922);
            this.Controls.Add(this.panel1);
            this.Name = "frmLapHoaDon";
            this.Text = "frmLapHoaDon";
            this.Load += new System.EventHandler(this.frmLapHoaDon_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlMatHang.ResumeLayout(false);
            this.pnlMatHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudSoLuong)).EndInit();
            this.pnlKhachHang.ResumeLayout(false);
            this.pnlKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChiTieTHD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblLapHD;
        private System.Windows.Forms.Panel pnlMatHang;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Panel pnlKhachHang;
        private System.Windows.Forms.Label lblKH;
        private System.Windows.Forms.Label MaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.DataGridView dgvThongTinChiTieTHD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.NumericUpDown nmudSoLuong;
        private System.Windows.Forms.MaskedTextBox mtxtSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenHang;
    }
}