namespace GUI
{
    partial class frmHoaDon
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
            this.txtMahd = new System.Windows.Forms.TextBox();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.dgv_hoadon = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuahang_bangiayDataSet2 = new GUI.cuahang_bangiayDataSet2();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.dtp_Ngaylap = new System.Windows.Forms.DateTimePicker();
            this.btnXoa = new System.Windows.Forms.Button();
            this.hoaDonTableAdapter = new GUI.cuahang_bangiayDataSet2TableAdapters.HoaDonTableAdapter();
            this.cbb_TrangThai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_bangiayDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày Lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã NV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trạng Thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng Tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên KH";
            // 
            // txtMahd
            // 
            this.txtMahd.Location = new System.Drawing.Point(104, 26);
            this.txtMahd.Name = "txtMahd";
            this.txtMahd.Size = new System.Drawing.Size(177, 26);
            this.txtMahd.TabIndex = 1;
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(397, 73);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(177, 26);
            this.txtTongtien.TabIndex = 1;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(104, 123);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(177, 26);
            this.txtMaNV.TabIndex = 1;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(397, 123);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(177, 26);
            this.txtTenKH.TabIndex = 1;
            // 
            // dgv_hoadon
            // 
            this.dgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.NgayLap,
            this.MaNhanVien,
            this.TrangThai,
            this.TongTien,
            this.TenKhachHang});
            this.dgv_hoadon.Location = new System.Drawing.Point(32, 226);
            this.dgv_hoadon.Name = "dgv_hoadon";
            this.dgv_hoadon.RowHeadersWidth = 62;
            this.dgv_hoadon.RowTemplate.Height = 28;
            this.dgv_hoadon.Size = new System.Drawing.Size(1162, 267);
            this.dgv_hoadon.TabIndex = 2;
            this.dgv_hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoadon_CellClick);
            this.dgv_hoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoadon_CellContentClick);
            this.dgv_hoadon.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_hoadon_CellFormatting);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.MinimumWidth = 8;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 150;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.MinimumWidth = 8;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 150;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.MinimumWidth = 8;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Width = 150;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 8;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 150;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 8;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 150;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên KH";
            this.TenKhachHang.MinimumWidth = 8;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Width = 150;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.cuahang_bangiayDataSet2;
            // 
            // cuahang_bangiayDataSet2
            // 
            this.cuahang_bangiayDataSet2.DataSetName = "cuahang_bangiayDataSet2";
            this.cuahang_bangiayDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(617, 30);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(95, 33);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(617, 73);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(95, 33);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(530, 173);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(95, 33);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(631, 173);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(177, 26);
            this.txtTim.TabIndex = 1;
            // 
            // dtp_Ngaylap
            // 
            this.dtp_Ngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Ngaylap.Location = new System.Drawing.Point(104, 76);
            this.dtp_Ngaylap.Name = "dtp_Ngaylap";
            this.dtp_Ngaylap.Size = new System.Drawing.Size(176, 26);
            this.dtp_Ngaylap.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(617, 112);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 33);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // cbb_TrangThai
            // 
            this.cbb_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TrangThai.FormattingEnabled = true;
            this.cbb_TrangThai.Items.AddRange(new object[] {
            "Không Hoạt Động",
            "Hoạt Động"});
            this.cbb_TrangThai.Location = new System.Drawing.Point(397, 21);
            this.cbb_TrangThai.Name = "cbb_TrangThai";
            this.cbb_TrangThai.Size = new System.Drawing.Size(187, 28);
            this.cbb_TrangThai.TabIndex = 5;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 534);
            this.Controls.Add(this.cbb_TrangThai);
            this.Controls.Add(this.dtp_Ngaylap);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_hoadon);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.txtMahd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_bangiayDataSet2)).EndInit();
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
        private System.Windows.Forms.TextBox txtMahd;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.DataGridView dgv_hoadon;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.DateTimePicker dtp_Ngaylap;
        private System.Windows.Forms.Button btnXoa;
        private cuahang_bangiayDataSet2 cuahang_bangiayDataSet2;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private cuahang_bangiayDataSet2TableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.ComboBox cbb_TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
    }
}