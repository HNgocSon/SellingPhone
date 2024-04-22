namespace GUI
{
    partial class frmNhaCungCap
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
            this.txtMancc = new System.Windows.Forms.TextBox();
            this.txtTenncc = new System.Windows.Forms.TextBox();
            this.txtDchi = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuahang_bangiayDataSet3 = new GUI.cuahang_bangiayDataSet3();
            this.nhaCungCapTableAdapter = new GUI.cuahang_bangiayDataSet3TableAdapters.NhaCungCapTableAdapter();
            this.cbbTrangthai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_bangiayDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NCC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên NCC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số ĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "EMAIL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Trạng Thái";
            // 
            // txtMancc
            // 
            this.txtMancc.Location = new System.Drawing.Point(87, 26);
            this.txtMancc.Name = "txtMancc";
            this.txtMancc.Size = new System.Drawing.Size(193, 26);
            this.txtMancc.TabIndex = 1;
            // 
            // txtTenncc
            // 
            this.txtTenncc.Location = new System.Drawing.Point(87, 74);
            this.txtTenncc.Name = "txtTenncc";
            this.txtTenncc.Size = new System.Drawing.Size(193, 26);
            this.txtTenncc.TabIndex = 1;
            // 
            // txtDchi
            // 
            this.txtDchi.Location = new System.Drawing.Point(87, 124);
            this.txtDchi.Name = "txtDchi";
            this.txtDchi.Size = new System.Drawing.Size(193, 26);
            this.txtDchi.TabIndex = 1;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(390, 25);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(193, 26);
            this.txtSdt.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(390, 71);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 26);
            this.txtEmail.TabIndex = 1;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(797, 174);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(193, 26);
            this.txtTim.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(663, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 32);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(663, 74);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 32);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(663, 124);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 32);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(663, 171);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(119, 32);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvNCC
            // 
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.DCHI,
            this.SDT,
            this.EMAIL,
            this.TrangThai});
            this.dgvNCC.Location = new System.Drawing.Point(60, 263);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowHeadersWidth = 62;
            this.dgvNCC.RowTemplate.Height = 28;
            this.dgvNCC.Size = new System.Drawing.Size(953, 237);
            this.dgvNCC.TabIndex = 3;
            this.dgvNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellClick);
            this.dgvNCC.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNCC_CellFormatting);
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MANCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.MinimumWidth = 8;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Width = 150;
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên NCC";
            this.TenNCC.MinimumWidth = 8;
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.Width = 150;
            // 
            // DCHI
            // 
            this.DCHI.DataPropertyName = "DCHI";
            this.DCHI.HeaderText = "Địa Chỉ";
            this.DCHI.MinimumWidth = 8;
            this.DCHI.Name = "DCHI";
            this.DCHI.Width = 150;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SỐ ĐT";
            this.SDT.MinimumWidth = 8;
            this.SDT.Name = "SDT";
            this.SDT.Width = 150;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "MAIL";
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.MinimumWidth = 8;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Width = 150;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 8;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 150;
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.cuahang_bangiayDataSet3;
            // 
            // cuahang_bangiayDataSet3
            // 
            this.cuahang_bangiayDataSet3.DataSetName = "cuahang_bangiayDataSet3";
            this.cuahang_bangiayDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // cbbTrangthai
            // 
            this.cbbTrangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTrangthai.FormattingEnabled = true;
            this.cbbTrangthai.Items.AddRange(new object[] {
            "Không hoạt động",
            "Hoạt động"});
            this.cbbTrangthai.Location = new System.Drawing.Point(390, 124);
            this.cbbTrangthai.Name = "cbbTrangthai";
            this.cbbTrangthai.Size = new System.Drawing.Size(201, 28);
            this.cbbTrangthai.TabIndex = 4;
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.cach_chup_giay_dep_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 577);
            this.Controls.Add(this.cbbTrangthai);
            this.Controls.Add(this.dgvNCC);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.txtDchi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtTenncc);
            this.Controls.Add(this.txtMancc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNhaCungCap";
            this.Text = "frmNhaCungCap";
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_bangiayDataSet3)).EndInit();
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
        private System.Windows.Forms.TextBox txtMancc;
        private System.Windows.Forms.TextBox txtTenncc;
        private System.Windows.Forms.TextBox txtDchi;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvNCC;
        private cuahang_bangiayDataSet3 cuahang_bangiayDataSet3;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private cuahang_bangiayDataSet3TableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.ComboBox cbbTrangthai;
    }
}