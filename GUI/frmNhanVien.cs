using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;


namespace GUI
{
    public partial class frmNhanVien : Form
    {
       

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cuahang_bangiayDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.cuahang_bangiayDataSet.NhanVien);
            LoadDataGridView();
        }
       
            private NhanVienBus NhanVienBus;
            public frmNhanVien()
            {
                InitializeComponent();
                NhanVienBus = new NhanVienBus();
            }
            private void LoadDataGridView()
            {
                dgv_nhanvien.DataSource = NhanVienBus.LayDanhSachNhanVien();
            }
           
           
           

            
           
     

            private void dgv_nhanvien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
            {
               
                if (e.ColumnIndex == 8 && e.Value != null)
                {
                    int trangThai = (int)e.Value;
                    if (trangThai == 1)
                    {
                        e.Value = "Hoạt động";
                    }
                    else if (trangThai == 0)
                    {
                        e.Value = "Không hoạt động";
                    }
                }
            }

           

        private void dgv_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_nhanvien.Rows[e.RowIndex];
                txtManv.Text = row.Cells["MaNV"].Value.ToString();
                txtHonv.Text = row.Cells["HoNV"].Value.ToString();
                txtTennv.Text = row.Cells["TenNV"].Value.ToString();
                txtDchi.Text = row.Cells["DCHI"].Value.ToString();
                txTaikhoan.Text = row.Cells["TaiKhoan"].Value.ToString();
                txtMatkhau.Text = row.Cells["MatKhau"].Value.ToString();
                dtime_lam.Text=row.Cells["NgayVaoLam"].Value.ToString();
                txtMachucvu.Text = row.Cells["MaChucVu"].Value.ToString();
                cboTrangThai.Text = (row.Cells["TrangThai"].Value.ToString() == "1") ? "Hoạt động" : "Không hoạt động";
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            NhanVienDTO nhanVien = new NhanVienDTO();
            nhanVien.MaNV = int.Parse(txtManv.Text);
            nhanVien.HoNV = txtHonv.Text;
            nhanVien.TenNV = txtTennv.Text;
            nhanVien.DCHI = txtDchi.Text;
            nhanVien.TaiKhoan = txTaikhoan.Text;
            nhanVien.MatKhau = txtMatkhau.Text;
            nhanVien.NgayVaoLam = dtime_lam.MaxDate;
            nhanVien.MaChucVu = int.Parse(txtMachucvu.Text);
            nhanVien.TrangThai = cboTrangThai.SelectedIndex;

            if (NhanVienBus.ThemNhanVien(nhanVien))
            {
                MessageBox.Show("Thêm nhân viên thành công");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {

            NhanVienDTO nhanVien = new NhanVienDTO();
            nhanVien.MaNV = int.Parse(txtManv.Text);
            nhanVien.HoNV = txtHonv.Text;
            nhanVien.TenNV = txtTennv.Text;
            nhanVien.DCHI = txtDchi.Text;
            nhanVien.TaiKhoan = txTaikhoan.Text;
            nhanVien.MatKhau = txtMatkhau.Text;
            nhanVien.NgayVaoLam = dtime_lam.MaxDate;
            nhanVien.MaChucVu = int.Parse(txtMachucvu.Text);
            nhanVien.TrangThai = cboTrangThai.SelectedIndex;

            if (NhanVienBus.CapNhatNhanVien(nhanVien))
                {
                    MessageBox.Show("Sửa nhân viên thành công");
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Sửa nhân viên thất bại");
                }
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
           
                int MaNV = int.Parse(txtManv.Text);

                if (NhanVienBus.XoaNhanVien(MaNV))
                {
                    MessageBox.Show("Xóa nhân viên thành công");
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại");
                }
            
        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            string nhanVien = txtTim.Text;
            dgv_nhanvien.DataSource = NhanVienBus.TimKiemNhanVien(nhanVien);
        }
    }
    }

