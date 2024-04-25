namespace QuanLyShopBanGiay.GUI.FromKho
{
    partial class frmDanhSachSanPham
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.cboThuongHieu = new System.Windows.Forms.ComboBox();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblMauSac = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.lblThuongHieu = new System.Windows.Forms.Label();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nmudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.nmudSize = new System.Windows.Forms.NumericUpDown();
            this.cboMauSac = new System.Windows.Forms.ComboBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblGiaGoc = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaGoc = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDanhSachTonKho = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudSize)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(529, 332);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(129, 38);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(333, 332);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(129, 38);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.DarkBlue;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(729, 332);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(129, 38);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cboThuongHieu
            // 
            this.cboThuongHieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThuongHieu.FormattingEnabled = true;
            this.cboThuongHieu.Items.AddRange(new object[] {
            "Supreme",
            "ADIDAS",
            "Balance",
            "Converse",
            "Vans",
            "Valentino",
            "Charles & Keith",
            "Jimmy Choo",
            "Balenciaga",
            "Nike"});
            this.cboThuongHieu.Location = new System.Drawing.Point(153, 127);
            this.cboThuongHieu.Margin = new System.Windows.Forms.Padding(4);
            this.cboThuongHieu.Name = "cboThuongHieu";
            this.cboThuongHieu.Size = new System.Drawing.Size(205, 24);
            this.cboThuongHieu.TabIndex = 3;
            // 
            // lblTenHang
            // 
            this.lblTenHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHang.Location = new System.Drawing.Point(14, 79);
            this.lblTenHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(82, 20);
            this.lblTenHang.TabIndex = 0;
            this.lblTenHang.Text = "Tên Hàng";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(442, 122);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(80, 20);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // lblMauSac
            // 
            this.lblMauSac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMauSac.AutoSize = true;
            this.lblMauSac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMauSac.Location = new System.Drawing.Point(442, 24);
            this.lblMauSac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMauSac.Name = "lblMauSac";
            this.lblMauSac.Size = new System.Drawing.Size(75, 20);
            this.lblMauSac.TabIndex = 0;
            this.lblMauSac.Text = "Màu Sắc";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHang.Location = new System.Drawing.Point(153, 24);
            this.txtMaHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(205, 26);
            this.txtMaHang.TabIndex = 1;
            // 
            // lblThuongHieu
            // 
            this.lblThuongHieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblThuongHieu.AutoSize = true;
            this.lblThuongHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuongHieu.Location = new System.Drawing.Point(14, 127);
            this.lblThuongHieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThuongHieu.Name = "lblThuongHieu";
            this.lblThuongHieu.Size = new System.Drawing.Size(100, 20);
            this.lblThuongHieu.TabIndex = 0;
            this.lblThuongHieu.Text = "Thương hiệu";
            // 
            // lblMaHang
            // 
            this.lblMaHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHang.Location = new System.Drawing.Point(14, 27);
            this.lblMaHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(77, 20);
            this.lblMaHang.TabIndex = 0;
            this.lblMaHang.Text = "Mã Hàng";
            // 
            // txtTen
            // 
            this.txtTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(153, 74);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(205, 26);
            this.txtTen.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.nmudSoLuong);
            this.panel1.Controls.Add(this.nmudSize);
            this.panel1.Controls.Add(this.cboMauSac);
            this.panel1.Controls.Add(this.cboThuongHieu);
            this.panel1.Controls.Add(this.lblTenHang);
            this.panel1.Controls.Add(this.lblSoLuong);
            this.panel1.Controls.Add(this.lblMauSac);
            this.panel1.Controls.Add(this.txtMaHang);
            this.panel1.Controls.Add(this.lblGiaBan);
            this.panel1.Controls.Add(this.lblGiaGoc);
            this.panel1.Controls.Add(this.lblThuongHieu);
            this.panel1.Controls.Add(this.lblMaHang);
            this.panel1.Controls.Add(this.lblSize);
            this.panel1.Controls.Add(this.txtGiaBan);
            this.panel1.Controls.Add(this.txtGiaGoc);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Location = new System.Drawing.Point(39, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 208);
            this.panel1.TabIndex = 1;
            // 
            // nmudSoLuong
            // 
            this.nmudSoLuong.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nmudSoLuong.Location = new System.Drawing.Point(557, 120);
            this.nmudSoLuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmudSoLuong.Name = "nmudSoLuong";
            this.nmudSoLuong.Size = new System.Drawing.Size(105, 22);
            this.nmudSoLuong.TabIndex = 7;
            this.nmudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmudSize
            // 
            this.nmudSize.Location = new System.Drawing.Point(557, 70);
            this.nmudSize.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nmudSize.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nmudSize.Name = "nmudSize";
            this.nmudSize.Size = new System.Drawing.Size(105, 22);
            this.nmudSize.TabIndex = 6;
            this.nmudSize.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // cboMauSac
            // 
            this.cboMauSac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMauSac.FormattingEnabled = true;
            this.cboMauSac.Items.AddRange(new object[] {
            "Trắng",
            "Đen",
            "Xanh dương",
            "Đỏ",
            "Xám",
            "Cam",
            "Tím",
            "Hồng",
            "Lam",
            "Nâu sẫm",
            "Nâu"});
            this.cboMauSac.Location = new System.Drawing.Point(557, 20);
            this.cboMauSac.Margin = new System.Windows.Forms.Padding(4);
            this.cboMauSac.Name = "cboMauSac";
            this.cboMauSac.Size = new System.Drawing.Size(205, 24);
            this.cboMauSac.TabIndex = 5;
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaBan.Location = new System.Drawing.Point(442, 161);
            this.lblGiaBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(70, 20);
            this.lblGiaBan.TabIndex = 0;
            this.lblGiaBan.Text = "Giá Bán";
            // 
            // lblGiaGoc
            // 
            this.lblGiaGoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGiaGoc.AutoSize = true;
            this.lblGiaGoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaGoc.Location = new System.Drawing.Point(14, 161);
            this.lblGiaGoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiaGoc.Name = "lblGiaGoc";
            this.lblGiaGoc.Size = new System.Drawing.Size(71, 20);
            this.lblGiaGoc.TabIndex = 0;
            this.lblGiaGoc.Text = "Giá Gốc";
            // 
            // lblSize
            // 
            this.lblSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(442, 74);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(42, 20);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(557, 158);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(205, 26);
            this.txtGiaBan.TabIndex = 8;
            // 
            // txtGiaGoc
            // 
            this.txtGiaGoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGiaGoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaGoc.Location = new System.Drawing.Point(153, 161);
            this.txtGiaGoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaGoc.Name = "txtGiaGoc";
            this.txtGiaGoc.Size = new System.Drawing.Size(205, 26);
            this.txtGiaGoc.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SpringGreen;
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(806, 0);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 48);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 734);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 48);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 782);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(911, 48);
            this.panel3.TabIndex = 7;
            // 
            // lblDanhSachTonKho
            // 
            this.lblDanhSachTonKho.AutoSize = true;
            this.lblDanhSachTonKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachTonKho.ForeColor = System.Drawing.Color.White;
            this.lblDanhSachTonKho.Location = new System.Drawing.Point(16, 11);
            this.lblDanhSachTonKho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanhSachTonKho.Name = "lblDanhSachTonKho";
            this.lblDanhSachTonKho.Size = new System.Drawing.Size(478, 42);
            this.lblDanhSachTonKho.TabIndex = 0;
            this.lblDanhSachTonKho.Text = "Danh Sách Hàng Tồn Kho";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.pnlTitle.Controls.Add(this.lblDanhSachTonKho);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(911, 62);
            this.pnlTitle.TabIndex = 0;
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column2,
            this.Column8,
            this.Column7});
            this.dgvThongTin.Location = new System.Drawing.Point(39, 396);
            this.dgvThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.ReadOnly = true;
            this.dgvThongTin.RowHeadersWidth = 51;
            this.dgvThongTin.Size = new System.Drawing.Size(819, 338);
            this.dgvThongTin.TabIndex = 5;
            this.dgvThongTin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTin_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHang";
            this.Column1.HeaderText = "Mã Hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 96;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenHang";
            this.Column3.HeaderText = "Tên Hàng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 96;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MauSac";
            this.Column4.HeaderText = "Màu Sắc";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 96;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Size";
            this.Column5.HeaderText = "Size";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 96;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ThuongHieu";
            this.Column6.HeaderText = "Thương Hiệu";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 96;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GiaBan";
            this.Column2.HeaderText = "Gía Bán";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 96;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "GiaGoc";
            this.Column8.HeaderText = "Giá Gốc";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 96;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SoLuong";
            this.Column7.HeaderText = "Số Lượng";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 96;
            // 
            // frmDanhSachSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(932, 629);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.dgvThongTin);
            this.Name = "frmDanhSachSanPham";
            this.Text = "frmDanhSachSanPham";
            this.Load += new System.EventHandler(this.frmDanhSachSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudSize)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cboThuongHieu;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblMauSac;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label lblThuongHieu;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDanhSachTonKho;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.DataGridView dgvThongTin;
        private System.Windows.Forms.NumericUpDown nmudSize;
        private System.Windows.Forms.ComboBox cboMauSac;
        private System.Windows.Forms.NumericUpDown nmudSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblGiaGoc;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaGoc;
    }
}