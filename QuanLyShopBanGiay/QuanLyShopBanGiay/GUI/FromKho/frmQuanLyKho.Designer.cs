namespace QuanLyShopBanGiay.GUI.FromKho
{
    partial class frmQuanLyKho
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
            this.btnNhapKho = new System.Windows.Forms.Button();
            this.btnDanhSachHangTon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNhapKho.FlatAppearance.BorderSize = 0;
            this.btnNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapKho.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNhapKho.Location = new System.Drawing.Point(71, 151);
            this.btnNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(755, 128);
            this.btnNhapKho.TabIndex = 1;
            this.btnNhapKho.Text = "Nhập Kho";
            this.btnNhapKho.UseVisualStyleBackColor = false;
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // btnDanhSachHangTon
            // 
            this.btnDanhSachHangTon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnDanhSachHangTon.FlatAppearance.BorderSize = 0;
            this.btnDanhSachHangTon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachHangTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachHangTon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDanhSachHangTon.Location = new System.Drawing.Point(71, 350);
            this.btnDanhSachHangTon.Margin = new System.Windows.Forms.Padding(4);
            this.btnDanhSachHangTon.Name = "btnDanhSachHangTon";
            this.btnDanhSachHangTon.Size = new System.Drawing.Size(755, 128);
            this.btnDanhSachHangTon.TabIndex = 2;
            this.btnDanhSachHangTon.Text = "Danh Sách Hàng Tồn Kho";
            this.btnDanhSachHangTon.UseVisualStyleBackColor = false;
            this.btnDanhSachHangTon.Click += new System.EventHandler(this.btnDanhSachHangTon_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(189, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 37);
            this.panel1.TabIndex = 0;
            // 
            // frmQuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(896, 629);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNhapKho);
            this.Controls.Add(this.btnDanhSachHangTon);
            this.Name = "frmQuanLyKho";
            this.Text = "Quản Lý Kho";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNhapKho;
        private System.Windows.Forms.Button btnDanhSachHangTon;
        private System.Windows.Forms.Panel panel1;
    }
}