namespace QuanLyShopBanGiay.GUI.FormQuanLy
{
    partial class frmQuanLyShop
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
            this.btnLapHoaDon = new System.Windows.Forms.Button();
            this.btnDanhSachHoaDon = new System.Windows.Forms.Button();
            this.btnDanhSachKhachHang = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(32)))));
            this.btnLapHoaDon.FlatAppearance.BorderSize = 0;
            this.btnLapHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapHoaDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLapHoaDon.Location = new System.Drawing.Point(74, 82);
            this.btnLapHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(755, 128);
            this.btnLapHoaDon.TabIndex = 1;
            this.btnLapHoaDon.Text = "Lập Hóa Đơn";
            this.btnLapHoaDon.UseVisualStyleBackColor = false;
            this.btnLapHoaDon.Click += new System.EventHandler(this.btnnLapHoaDon_Click);
            // 
            // btnDanhSachHoaDon
            // 
            this.btnDanhSachHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.btnDanhSachHoaDon.FlatAppearance.BorderSize = 0;
            this.btnDanhSachHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnDanhSachHoaDon.Location = new System.Drawing.Point(74, 246);
            this.btnDanhSachHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnDanhSachHoaDon.Name = "btnDanhSachHoaDon";
            this.btnDanhSachHoaDon.Size = new System.Drawing.Size(755, 128);
            this.btnDanhSachHoaDon.TabIndex = 2;
            this.btnDanhSachHoaDon.Text = "Danh Sách Hóa Đơn";
            this.btnDanhSachHoaDon.UseVisualStyleBackColor = false;
            this.btnDanhSachHoaDon.Click += new System.EventHandler(this.btnDanhSachHoaDon_Click);
            // 
            // btnDanhSachKhachHang
            // 
            this.btnDanhSachKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDanhSachKhachHang.FlatAppearance.BorderSize = 0;
            this.btnDanhSachKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnDanhSachKhachHang.Location = new System.Drawing.Point(74, 417);
            this.btnDanhSachKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnDanhSachKhachHang.Name = "btnDanhSachKhachHang";
            this.btnDanhSachKhachHang.Size = new System.Drawing.Size(755, 128);
            this.btnDanhSachKhachHang.TabIndex = 3;
            this.btnDanhSachKhachHang.Text = "Danh Sách Khách Hàng";
            this.btnDanhSachKhachHang.UseVisualStyleBackColor = false;
            this.btnDanhSachKhachHang.Click += new System.EventHandler(this.btnDanhSachKhachHang_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(18, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 10);
            this.panel1.TabIndex = 0;
            // 
            // frmQuanLyShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(896, 629);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDanhSachKhachHang);
            this.Controls.Add(this.btnDanhSachHoaDon);
            this.Controls.Add(this.btnLapHoaDon);
            this.Name = "frmQuanLyShop";
            this.Text = "frmQuanLyShop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLapHoaDon;
        private System.Windows.Forms.Button btnDanhSachHoaDon;
        private System.Windows.Forms.Button btnDanhSachKhachHang;
        private System.Windows.Forms.Panel panel1;
    }
}