namespace GUI
{
    partial class frmManHinhChinh
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
            this.btnBangTaiKhoan = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnHoadon = new System.Windows.Forms.Button();
            this.btnNhacungcap = new System.Windows.Forms.Button();
            this.btnCTHD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBangTaiKhoan
            // 
            this.btnBangTaiKhoan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBangTaiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBangTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.btnBangTaiKhoan.Location = new System.Drawing.Point(24, 11);
            this.btnBangTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBangTaiKhoan.Name = "btnBangTaiKhoan";
            this.btnBangTaiKhoan.Size = new System.Drawing.Size(115, 74);
            this.btnBangTaiKhoan.TabIndex = 8;
            this.btnBangTaiKhoan.Text = "Tài Khoản";
            this.btnBangTaiKhoan.UseVisualStyleBackColor = false;
            this.btnBangTaiKhoan.Click += new System.EventHandler(this.btnBangTaiKhoan_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBanHang.Location = new System.Drawing.Point(24, 245);
            this.btnBanHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(115, 74);
            this.btnBanHang.TabIndex = 6;
            this.btnBanHang.Text = "Bán Hàng";
            this.btnBanHang.UseVisualStyleBackColor = false;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNhanvien.Location = new System.Drawing.Point(24, 89);
            this.btnNhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(115, 74);
            this.btnNhanvien.TabIndex = 7;
            this.btnNhanvien.Text = "Nhân Viên";
            this.btnNhanvien.UseVisualStyleBackColor = false;
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Location = new System.Drawing.Point(213, 105);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(63, 20);
            this.lblQuyen.TabIndex = 5;
            this.lblQuyen.Text = "Quyền :";
            this.lblQuyen.Click += new System.EventHandler(this.lblQuyen_Click);
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(213, 51);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(48, 20);
            this.lblTen.TabIndex = 4;
            this.lblTen.Text = "Tên : ";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Blue;
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(140, 508);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(136, 42);
            this.btnDangXuat.TabIndex = 9;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnHoadon
            // 
            this.btnHoadon.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnHoadon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHoadon.Location = new System.Drawing.Point(24, 324);
            this.btnHoadon.Name = "btnHoadon";
            this.btnHoadon.Size = new System.Drawing.Size(115, 67);
            this.btnHoadon.TabIndex = 10;
            this.btnHoadon.Text = "Hóa Đơn";
            this.btnHoadon.UseVisualStyleBackColor = false;
            this.btnHoadon.Click += new System.EventHandler(this.btnHoadon_Click);
            // 
            // btnNhacungcap
            // 
            this.btnNhacungcap.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNhacungcap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNhacungcap.Location = new System.Drawing.Point(24, 173);
            this.btnNhacungcap.Name = "btnNhacungcap";
            this.btnNhacungcap.Size = new System.Drawing.Size(115, 67);
            this.btnNhacungcap.TabIndex = 10;
            this.btnNhacungcap.Text = "Nhà Cung Cấp";
            this.btnNhacungcap.UseVisualStyleBackColor = false;
            this.btnNhacungcap.Click += new System.EventHandler(this.btnNhacungcap_Click);
            // 
            // btnCTHD
            // 
            this.btnCTHD.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCTHD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCTHD.Location = new System.Drawing.Point(24, 410);
            this.btnCTHD.Name = "btnCTHD";
            this.btnCTHD.Size = new System.Drawing.Size(115, 67);
            this.btnCTHD.TabIndex = 10;
            this.btnCTHD.Text = "Chi Tiết Hóa Đơn";
            this.btnCTHD.UseVisualStyleBackColor = false;
            this.btnCTHD.Click += new System.EventHandler(this.btnCTHD_Click);
            // 
            // frmManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources._0da5449cad6628d8943ccee6c745a196;
            this.ClientSize = new System.Drawing.Size(441, 599);
            this.Controls.Add(this.btnNhacungcap);
            this.Controls.Add(this.btnCTHD);
            this.Controls.Add(this.btnHoadon);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnBangTaiKhoan);
            this.Controls.Add(this.btnBanHang);
            this.Controls.Add(this.btnNhanvien);
            this.Controls.Add(this.lblQuyen);
            this.Controls.Add(this.lblTen);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmManHinhChinh";
            this.Text = "frmManHinhChinh";
            this.Load += new System.EventHandler(this.frmManHinhChinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBangTaiKhoan;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnNhanvien;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnHoadon;
        private System.Windows.Forms.Button btnNhacungcap;
        private System.Windows.Forms.Button btnCTHD;
    }
}