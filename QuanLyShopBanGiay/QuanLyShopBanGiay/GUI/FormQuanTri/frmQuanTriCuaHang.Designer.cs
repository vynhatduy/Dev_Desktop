namespace QuanLyShopBanGiay.GUI.FormQuanTri
{
    partial class frmQuanTriCuaHang
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
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(234)))));
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongKe.Location = new System.Drawing.Point(79, 412);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(755, 128);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(62, 88);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 28);
            this.panel1.TabIndex = 0;
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(255)))), ((int)(((byte)(55)))));
            this.btnQuanLyNhanVien.FlatAppearance.BorderSize = 0;
            this.btnQuanLyNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNhanVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(79, 221);
            this.btnQuanLyNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(755, 128);
            this.btnQuanLyNhanVien.TabIndex = 1;
            this.btnQuanLyNhanVien.Text = "Quản Lý Nhân Viên";
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = false;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // frmQuanTriCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(896, 629);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQuanLyNhanVien);
            this.Name = "frmQuanTriCuaHang";
            this.Text = "Quản Trị Cửa Hàng";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuanLyNhanVien;
    }
}