namespace GUI
{
    partial class frmNhanVien
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.txtHonv = new System.Windows.Forms.TextBox();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.txtDchi = new System.Windows.Forms.TextBox();
            this.txTaikhoan = new System.Windows.Forms.TextBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtMachucvu = new System.Windows.Forms.TextBox();
            this.dtime_lam = new System.Windows.Forms.DateTimePicker();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.dgv_nhanvien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVaoLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuahang_bangiayDataSet = new GUI.cuahang_bangiayDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.nhanVienTableAdapter = new GUI.cuahang_bangiayDataSetTableAdapters.NhanVienTableAdapter();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_bangiayDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ NV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên NV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Vào làm";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tài Khoản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã Chức Vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mật Khẩu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(622, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Trạng Thái";
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(112, 22);
            this.txtManv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(175, 26);
            this.txtManv.TabIndex = 1;
            // 
            // txtHonv
            // 
            this.txtHonv.Location = new System.Drawing.Point(112, 55);
            this.txtHonv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHonv.Name = "txtHonv";
            this.txtHonv.Size = new System.Drawing.Size(175, 26);
            this.txtHonv.TabIndex = 1;
            // 
            // txtTennv
            // 
            this.txtTennv.Location = new System.Drawing.Point(112, 96);
            this.txtTennv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(175, 26);
            this.txtTennv.TabIndex = 1;
            // 
            // txtDchi
            // 
            this.txtDchi.Location = new System.Drawing.Point(112, 144);
            this.txtDchi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDchi.Name = "txtDchi";
            this.txtDchi.Size = new System.Drawing.Size(175, 26);
            this.txtDchi.TabIndex = 1;
            // 
            // txTaikhoan
            // 
            this.txTaikhoan.Location = new System.Drawing.Point(431, 22);
            this.txTaikhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txTaikhoan.Name = "txTaikhoan";
            this.txTaikhoan.Size = new System.Drawing.Size(175, 26);
            this.txTaikhoan.TabIndex = 1;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(431, 55);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(175, 26);
            this.txtMatkhau.TabIndex = 1;
            // 
            // txtMachucvu
            // 
            this.txtMachucvu.Location = new System.Drawing.Point(431, 150);
            this.txtMachucvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMachucvu.Name = "txtMachucvu";
            this.txtMachucvu.Size = new System.Drawing.Size(175, 26);
            this.txtMachucvu.TabIndex = 1;
            // 
            // dtime_lam
            // 
            this.dtime_lam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtime_lam.Location = new System.Drawing.Point(431, 98);
            this.dtime_lam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtime_lam.Name = "dtime_lam";
            this.dtime_lam.Size = new System.Drawing.Size(181, 26);
            this.dtime_lam.TabIndex = 2;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Không hoạt động",
            "Hoạt Động"});
            this.cboTrangThai.Location = new System.Drawing.Point(721, 21);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(195, 28);
            this.cboTrangThai.TabIndex = 3;
            // 
            // dgv_nhanvien
            // 
            this.dgv_nhanvien.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoNV,
            this.TenNV,
            this.DCHI,
            this.TaiKhoan,
            this.MatKhau,
            this.NgayVaoLam,
            this.MaChucVu,
            this.TrangThai});
            this.dgv_nhanvien.Location = new System.Drawing.Point(27, 209);
            this.dgv_nhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_nhanvien.Name = "dgv_nhanvien";
            this.dgv_nhanvien.RowHeadersWidth = 62;
            this.dgv_nhanvien.RowTemplate.Height = 28;
            this.dgv_nhanvien.Size = new System.Drawing.Size(1390, 256);
            this.dgv_nhanvien.TabIndex = 4;
            this.dgv_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhanvien_CellClick);
            this.dgv_nhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhanvien_CellContentClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 150;
            // 
            // HoNV
            // 
            this.HoNV.DataPropertyName = "HoNV";
            this.HoNV.HeaderText = "Họ NV";
            this.HoNV.MinimumWidth = 8;
            this.HoNV.Name = "HoNV";
            this.HoNV.Width = 150;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.MinimumWidth = 8;
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 150;
            // 
            // DCHI
            // 
            this.DCHI.DataPropertyName = "DCHI";
            this.DCHI.HeaderText = "Địa Chỉ";
            this.DCHI.MinimumWidth = 8;
            this.DCHI.Name = "DCHI";
            this.DCHI.Width = 150;
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.DataPropertyName = "TaiKhoan";
            this.TaiKhoan.HeaderText = "Tài Khoản";
            this.TaiKhoan.MinimumWidth = 8;
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.Width = 150;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.MinimumWidth = 8;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Width = 150;
            // 
            // NgayVaoLam
            // 
            this.NgayVaoLam.DataPropertyName = "NgayVaoLam";
            this.NgayVaoLam.HeaderText = "Ngày Vào Làm";
            this.NgayVaoLam.MinimumWidth = 8;
            this.NgayVaoLam.Name = "NgayVaoLam";
            this.NgayVaoLam.Width = 150;
            // 
            // MaChucVu
            // 
            this.MaChucVu.DataPropertyName = "MaChucVu";
            this.MaChucVu.HeaderText = "Mã Chức Vụ";
            this.MaChucVu.MinimumWidth = 8;
            this.MaChucVu.Name = "MaChucVu";
            this.MaChucVu.Width = 150;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 8;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 150;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.cuahang_bangiayDataSet;
            // 
            // cuahang_bangiayDataSet
            // 
            this.cuahang_bangiayDataSet.DataSetName = "cuahang_bangiayDataSet";
            this.cuahang_bangiayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(670, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tìm";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(721, 99);
            this.txtTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(175, 26);
            this.txtTim.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(1033, 25);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 44);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(1033, 79);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 44);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(1033, 129);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 44);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = " Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTim.Location = new System.Drawing.Point(918, 81);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 44);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click_1);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.khung_vien_dep_211;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1429, 598);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgv_nhanvien);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.dtime_lam);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.txtMachucvu);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txTaikhoan);
            this.Controls.Add(this.txtDchi);
            this.Controls.Add(this.txtTennv);
            this.Controls.Add(this.txtHonv);
            this.Controls.Add(this.txtManv);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_bangiayDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.TextBox txtHonv;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.TextBox txtDchi;
        private System.Windows.Forms.TextBox txTaikhoan;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtMachucvu;
        private System.Windows.Forms.DateTimePicker dtime_lam;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.DataGridView dgv_nhanvien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btn_Xoa;
        private cuahang_bangiayDataSet cuahang_bangiayDataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private cuahang_bangiayDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVaoLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}