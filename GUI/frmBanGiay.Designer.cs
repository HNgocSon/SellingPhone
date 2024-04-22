
namespace GUI
{
    partial class frmBanGiay
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
            this.txtMaGiay = new System.Windows.Forms.TextBox();
            this.txtTenGiay = new System.Windows.Forms.TextBox();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.txtMancc = new System.Windows.Forms.TextBox();
            this.txtHinh = new System.Windows.Forms.TextBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.dgvBanGiay = new System.Windows.Forms.DataGridView();
            this.TenGiay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGiay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuahang_bangiayDataSet1 = new GUI.cuahang_bangiayDataSet1();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.ptB_giay = new System.Windows.Forms.PictureBox();
            this.cuahang_bangiayDataSet = new GUI.cuahang_bangiayDataSet();
            this.cuahangbangiayDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giayTableAdapter = new GUI.cuahang_bangiayDataSet1TableAdapters.GiayTableAdapter();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanGiay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_bangiayDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_giay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_bangiayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahangbangiayDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Giày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên giày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã NCC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hình";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã Loại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 214);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Trạng thái";
            // 
            // txtMaGiay
            // 
            this.txtMaGiay.Location = new System.Drawing.Point(129, 48);
            this.txtMaGiay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaGiay.Name = "txtMaGiay";
            this.txtMaGiay.Size = new System.Drawing.Size(188, 26);
            this.txtMaGiay.TabIndex = 1;
            // 
            // txtTenGiay
            // 
            this.txtTenGiay.Location = new System.Drawing.Point(129, 99);
            this.txtTenGiay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenGiay.Name = "txtTenGiay";
            this.txtTenGiay.Size = new System.Drawing.Size(188, 26);
            this.txtTenGiay.TabIndex = 1;
            // 
            // txt_Gia
            // 
            this.txt_Gia.Location = new System.Drawing.Point(129, 202);
            this.txt_Gia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(188, 26);
            this.txt_Gia.TabIndex = 1;
            // 
            // txtMancc
            // 
            this.txtMancc.Location = new System.Drawing.Point(423, 45);
            this.txtMancc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMancc.Name = "txtMancc";
            this.txtMancc.Size = new System.Drawing.Size(238, 26);
            this.txtMancc.TabIndex = 1;
            // 
            // txtHinh
            // 
            this.txtHinh.Location = new System.Drawing.Point(423, 92);
            this.txtHinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.Size = new System.Drawing.Size(238, 26);
            this.txtHinh.TabIndex = 1;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Không hoạt động",
            "Hoạt động"});
            this.cboTrangThai.Location = new System.Drawing.Point(424, 201);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(237, 28);
            this.cboTrangThai.TabIndex = 3;
            // 
            // dgvBanGiay
            // 
            this.dgvBanGiay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanGiay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenGiay,
            this.Size,
            this.Gia,
            this.MaNCC,
            this.MaGiay,
            this.Hinh,
            this.MaLoai,
            this.TrangThai});
            this.dgvBanGiay.Location = new System.Drawing.Point(22, 322);
            this.dgvBanGiay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBanGiay.Name = "dgvBanGiay";
            this.dgvBanGiay.RowHeadersWidth = 51;
            this.dgvBanGiay.Size = new System.Drawing.Size(1107, 306);
            this.dgvBanGiay.TabIndex = 5;
            this.dgvBanGiay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanGiay_CellClick);
            this.dgvBanGiay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanGiay_CellContentClick);
            this.dgvBanGiay.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBanGiay_CellFormatting);
            this.dgvBanGiay.SelectionChanged += new System.EventHandler(this.dgvBanGiay_SelectionChanged);
            this.dgvBanGiay.Click += new System.EventHandler(this.dgvBanGiay_Click);
            // 
            // TenGiay
            // 
            this.TenGiay.DataPropertyName = "TenGiay";
            this.TenGiay.HeaderText = "Tên Giày";
            this.TenGiay.MinimumWidth = 6;
            this.TenGiay.Name = "TenGiay";
            this.TenGiay.Width = 125;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Size";
            this.Size.MinimumWidth = 6;
            this.Size.Name = "Size";
            this.Size.Width = 125;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 125;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Width = 125;
            // 
            // MaGiay
            // 
            this.MaGiay.DataPropertyName = "MaGiay";
            this.MaGiay.HeaderText = "Mã Giày";
            this.MaGiay.MinimumWidth = 6;
            this.MaGiay.Name = "MaGiay";
            this.MaGiay.Width = 125;
            // 
            // Hinh
            // 
            this.Hinh.DataPropertyName = "Hinh";
            this.Hinh.HeaderText = "Hình";
            this.Hinh.MinimumWidth = 8;
            this.Hinh.Name = "Hinh";
            this.Hinh.Width = 150;
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Mã Loại";
            this.MaLoai.MinimumWidth = 8;
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.Width = 150;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 8;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 150;
            // 
            // giayBindingSource
            // 
            this.giayBindingSource.DataMember = "Giay";
            this.giayBindingSource.DataSource = this.cuahang_bangiayDataSet1;
            // 
            // cuahang_bangiayDataSet1
            // 
            this.cuahang_bangiayDataSet1.DataSetName = "cuahang_bangiayDataSet1";
            this.cuahang_bangiayDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(794, 286);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(238, 26);
            this.txtTim.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Pink;
            this.btnTim.BackgroundImage = global::GUI.Properties.Resources.khung_vien_dep_21;
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTim.Location = new System.Drawing.Point(794, 214);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(135, 73);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightPink;
            this.btnThem.BackgroundImage = global::GUI.Properties.Resources.khung_vien_dep_21;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Location = new System.Drawing.Point(794, 5);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(135, 66);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Pink;
            this.btnSua.BackgroundImage = global::GUI.Properties.Resources.khung_vien_dep_21;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Location = new System.Drawing.Point(794, 72);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(135, 68);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Pink;
            this.btnXoa.BackgroundImage = global::GUI.Properties.Resources.khung_vien_dep_21;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Location = new System.Drawing.Point(794, 140);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(135, 73);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BackColor = System.Drawing.Color.Pink;
            this.btnChonAnh.BackgroundImage = global::GUI.Properties.Resources.eff40a8c761c70f2a5e9d4b96cb75f69;
            this.btnChonAnh.Location = new System.Drawing.Point(1226, 359);
            this.btnChonAnh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(172, 80);
            this.btnChonAnh.TabIndex = 8;
            this.btnChonAnh.Text = "Chọn Ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // ptB_giay
            // 
            this.ptB_giay.Location = new System.Drawing.Point(1172, 40);
            this.ptB_giay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptB_giay.Name = "ptB_giay";
            this.ptB_giay.Size = new System.Drawing.Size(256, 291);
            this.ptB_giay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptB_giay.TabIndex = 7;
            this.ptB_giay.TabStop = false;
            // 
            // cuahang_bangiayDataSet
            // 
            this.cuahang_bangiayDataSet.DataSetName = "cuahang_bangiayDataSet";
            this.cuahang_bangiayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cuahangbangiayDataSetBindingSource
            // 
            this.cuahangbangiayDataSetBindingSource.DataSource = this.cuahang_bangiayDataSet;
            this.cuahangbangiayDataSetBindingSource.Position = 0;
            // 
            // giayTableAdapter
            // 
            this.giayTableAdapter.ClearBeforeFill = true;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(129, 146);
            this.txtSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(188, 26);
            this.txtSize.TabIndex = 1;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(424, 146);
            this.txtMaLoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(238, 26);
            this.txtMaLoai.TabIndex = 1;
            // 
            // frmBanGiay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.a858cbe1870aefa51bc6785df6c4560f;
            this.ClientSize = new System.Drawing.Size(1442, 692);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.ptB_giay);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvBanGiay);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.txt_Gia);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.txtMaLoai);
            this.Controls.Add(this.txtHinh);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtTenGiay);
            this.Controls.Add(this.txtMancc);
            this.Controls.Add(this.txtMaGiay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBanGiay";
            this.Text = "frmBanGiay";
            this.Load += new System.EventHandler(this.frmBanGiay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanGiay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_bangiayDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_giay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_bangiayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahangbangiayDataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtMaGiay;
        private System.Windows.Forms.TextBox txtTenGiay;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.TextBox txtMancc;
        private System.Windows.Forms.TextBox txtHinh;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.DataGridView dgvBanGiay;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.PictureBox ptB_giay;
        private System.Windows.Forms.Button btnChonAnh;
        private cuahang_bangiayDataSet cuahang_bangiayDataSet;
        private System.Windows.Forms.BindingSource cuahangbangiayDataSetBindingSource;
        private cuahang_bangiayDataSet1 cuahang_bangiayDataSet1;
        private System.Windows.Forms.BindingSource giayBindingSource;
        private cuahang_bangiayDataSet1TableAdapters.GiayTableAdapter giayTableAdapter;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGiay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}