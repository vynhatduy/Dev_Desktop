namespace QuanLyShopBanGiay
{
    partial class frmQuanLy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnQuanLyTaiKhoan = new System.Windows.Forms.Button();
            this.btnQuanTriCuaHang = new System.Windows.Forms.Button();
            this.btnQuanLyKho = new System.Windows.Forms.Button();
            this.btnQuanLyBanHang = new System.Windows.Forms.Button();
            this.pnlNoiDung = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnQuanLyTaiKhoan);
            this.panel1.Controls.Add(this.btnQuanTriCuaHang);
            this.panel1.Controls.Add(this.btnQuanLyKho);
            this.panel1.Controls.Add(this.btnQuanLyBanHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 690);
            this.panel1.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDangXuat.Location = new System.Drawing.Point(8, 620);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(204, 50);
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnUser
            // 
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUser.Location = new System.Drawing.Point(8, 557);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(204, 50);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "Xin Chào";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyTaiKhoan.ForeColor = System.Drawing.SystemColors.Window;
            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(7, 350);
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(204, 50);
            this.btnQuanLyTaiKhoan.TabIndex = 4;
            this.btnQuanLyTaiKhoan.Text = "Quản Lý Tài Khoản";
            this.btnQuanLyTaiKhoan.UseVisualStyleBackColor = true;
            this.btnQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanTriHeThong_Click);
            // 
            // btnQuanTriCuaHang
            // 
            this.btnQuanTriCuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanTriCuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanTriCuaHang.ForeColor = System.Drawing.SystemColors.Window;
            this.btnQuanTriCuaHang.Location = new System.Drawing.Point(7, 250);
            this.btnQuanTriCuaHang.Name = "btnQuanTriCuaHang";
            this.btnQuanTriCuaHang.Size = new System.Drawing.Size(204, 50);
            this.btnQuanTriCuaHang.TabIndex = 3;
            this.btnQuanTriCuaHang.Text = "Quản Trị Của Hàng";
            this.btnQuanTriCuaHang.UseVisualStyleBackColor = true;
            this.btnQuanTriCuaHang.Click += new System.EventHandler(this.btnQuanTriCuaHang_Click);
            // 
            // btnQuanLyKho
            // 
            this.btnQuanLyKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyKho.ForeColor = System.Drawing.SystemColors.Window;
            this.btnQuanLyKho.Location = new System.Drawing.Point(7, 150);
            this.btnQuanLyKho.Name = "btnQuanLyKho";
            this.btnQuanLyKho.Size = new System.Drawing.Size(204, 50);
            this.btnQuanLyKho.TabIndex = 2;
            this.btnQuanLyKho.Text = "Quản Lý Kho";
            this.btnQuanLyKho.UseVisualStyleBackColor = true;
            this.btnQuanLyKho.Click += new System.EventHandler(this.btnQuanLyKho_Click);
            // 
            // btnQuanLyBanHang
            // 
            this.btnQuanLyBanHang.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnQuanLyBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyBanHang.ForeColor = System.Drawing.SystemColors.Window;
            this.btnQuanLyBanHang.Location = new System.Drawing.Point(7, 50);
            this.btnQuanLyBanHang.Name = "btnQuanLyBanHang";
            this.btnQuanLyBanHang.Size = new System.Drawing.Size(204, 50);
            this.btnQuanLyBanHang.TabIndex = 1;
            this.btnQuanLyBanHang.Text = "Quản Lý Bán Hàng";
            this.btnQuanLyBanHang.UseVisualStyleBackColor = false;
            this.btnQuanLyBanHang.Click += new System.EventHandler(this.btnQuanLyBanHang_Click);
            // 
            // pnlNoiDung
            // 
            this.pnlNoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.pnlNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNoiDung.Location = new System.Drawing.Point(218, 0);
            this.pnlNoiDung.Name = "pnlNoiDung";
            this.pnlNoiDung.Size = new System.Drawing.Size(961, 690);
            this.pnlNoiDung.TabIndex = 1;
            this.pnlNoiDung.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNoiDung_Paint);
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.pnlNoiDung);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuanLy";
            this.Text = "Quản Lý";
            this.Load += new System.EventHandler(this.frmQuanLy_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnQuanLyTaiKhoan;
        private System.Windows.Forms.Button btnQuanTriCuaHang;
        private System.Windows.Forms.Button btnQuanLyKho;
        private System.Windows.Forms.Button btnQuanLyBanHang;
        private System.Windows.Forms.Panel pnlNoiDung;
    }
}

