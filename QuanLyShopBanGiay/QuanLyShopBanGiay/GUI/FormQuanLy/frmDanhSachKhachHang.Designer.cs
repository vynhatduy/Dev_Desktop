namespace QuanLyShopBanGiay.GUI.FormQuanLy
{
    partial class frmDanhSachKhachHang
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblDanhSachKH = new System.Windows.Forms.Label();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdSDT = new System.Windows.Forms.RadioButton();
            this.rdTen = new System.Windows.Forms.RadioButton();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel4.Controls.Add(this.button3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 816);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(896, 58);
            this.panel4.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(777, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 58);
            this.button3.TabIndex = 0;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlTitle.Controls.Add(this.lblDanhSachKH);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(896, 62);
            this.pnlTitle.TabIndex = 1;
  
            // 
            // lblDanhSachKH
            // 
            this.lblDanhSachKH.AutoSize = true;
            this.lblDanhSachKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachKH.ForeColor = System.Drawing.Color.White;
            this.lblDanhSachKH.Location = new System.Drawing.Point(16, 11);
            this.lblDanhSachKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanhSachKH.Name = "lblDanhSachKH";
            this.lblDanhSachKH.Size = new System.Drawing.Size(441, 42);
            this.lblDanhSachKH.TabIndex = 0;
            this.lblDanhSachKH.Text = "Danh Sách Khách Hàng";
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.BackColor = System.Drawing.Color.Navy;
            this.btnSuaKH.FlatAppearance.BorderSize = 0;
            this.btnSuaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKH.ForeColor = System.Drawing.Color.White;
            this.btnSuaKH.Location = new System.Drawing.Point(510, 87);
            this.btnSuaKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(160, 42);
            this.btnSuaKH.TabIndex = 5;
            this.btnSuaKH.Text = "Sửa Khách Hàng";
            this.btnSuaKH.UseVisualStyleBackColor = false;
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.mtxtSDT);
            this.panel1.Controls.Add(this.lblSDT);
            this.panel1.Controls.Add(this.btnSuaKH);
            this.panel1.Controls.Add(this.btnXoaKH);
            this.panel1.Controls.Add(this.lblTenKH);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.lblMaKH);
            this.panel1.Controls.Add(this.txtMaHang);
            this.panel1.Location = new System.Drawing.Point(52, 113);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 219);
            this.panel1.TabIndex = 2;
            // 
            // mtxtSDT
            // 
            this.mtxtSDT.Location = new System.Drawing.Point(168, 157);
            this.mtxtSDT.Mask = "##########";
            this.mtxtSDT.Name = "mtxtSDT";
            this.mtxtSDT.Size = new System.Drawing.Size(207, 22);
            this.mtxtSDT.TabIndex = 3;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(23, 159);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(42, 20);
            this.lblSDT.TabIndex = 0;
            this.lblSDT.Text = "SĐT";
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.BackColor = System.Drawing.Color.Navy;
            this.btnXoaKH.FlatAppearance.BorderSize = 0;
            this.btnXoaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKH.ForeColor = System.Drawing.Color.White;
            this.btnXoaKH.Location = new System.Drawing.Point(510, 148);
            this.btnXoaKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(160, 42);
            this.btnXoaKH.TabIndex = 6;
            this.btnXoaKH.Text = "Xóa Khách Hàng";
            this.btnXoaKH.UseVisualStyleBackColor = false;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.Location = new System.Drawing.Point(23, 95);
            this.lblTenKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(134, 20);
            this.lblTenKH.TabIndex = 0;
            this.lblTenKH.Text = "Tên Khách Hàng";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(168, 95);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(207, 26);
            this.txtTen.TabIndex = 2;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.Location = new System.Drawing.Point(23, 30);
            this.lblMaKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(129, 20);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã Khách Hàng";
    
            // txtMaHang
            // 
            this.txtMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHang.Location = new System.Drawing.Point(168, 27);
            this.txtMaHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.ReadOnly = true;
            this.txtMaHang.Size = new System.Drawing.Size(207, 26);
            this.txtMaHang.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 874);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(896, 48);
            this.panel3.TabIndex = 0;
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.AllowUserToAddRows = false;
            this.dgvThongTin.AllowUserToDeleteRows = false;
            this.dgvThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTin.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongTin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Location = new System.Drawing.Point(52, 486);
            this.dgvThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.ReadOnly = true;
            this.dgvThongTin.RowHeadersWidth = 51;
            this.dgvThongTin.Size = new System.Drawing.Size(800, 322);
            this.dgvThongTin.TabIndex = 4;
            this.dgvThongTin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTin_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdSDT);
            this.panel2.Controls.Add(this.rdTen);
            this.panel2.Controls.Add(this.txtTim);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Location = new System.Drawing.Point(52, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 3;
            // 
            // rdSDT
            // 
            this.rdSDT.AutoSize = true;
            this.rdSDT.Location = new System.Drawing.Point(377, 66);
            this.rdSDT.Name = "rdSDT";
            this.rdSDT.Size = new System.Drawing.Size(56, 20);
            this.rdSDT.TabIndex = 3;
            this.rdSDT.Text = "SDT";
            this.rdSDT.UseVisualStyleBackColor = true;
            // 
            // rdTen
            // 
            this.rdTen.AutoSize = true;
            this.rdTen.Checked = true;
            this.rdTen.Location = new System.Drawing.Point(252, 66);
            this.rdTen.Name = "rdTen";
            this.rdTen.Size = new System.Drawing.Size(52, 20);
            this.rdTen.TabIndex = 2;
            this.rdTen.TabStop = true;
            this.rdTen.Text = "Tên";
            this.rdTen.UseVisualStyleBackColor = true;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(239, 23);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(214, 22);
            this.txtTim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin tìm kiếm";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Navy;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(566, 23);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(160, 42);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // frmDanhSachKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(896, 922);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvThongTin);
            this.Name = "frmDanhSachKhachHang";
            this.Text = "frmDanhSachKhachHang";
            this.Load += new System.EventHandler(this.frmDanhSachKhachHang_Load);
            this.panel4.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblDanhSachKH;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.DataGridView dgvThongTin;
        private System.Windows.Forms.MaskedTextBox mtxtSDT;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdSDT;
        private System.Windows.Forms.RadioButton rdTen;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTim;
    }
}