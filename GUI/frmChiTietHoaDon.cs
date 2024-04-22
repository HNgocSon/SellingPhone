using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmChiTietHoaDon : Form
    {
        private ChiTietHoaDonBUS ChiTietHoaDonBUS;
        public frmChiTietHoaDon()
        {
            InitializeComponent();
            ChiTietHoaDonBUS = new ChiTietHoaDonBUS();
        }
        private void LoadDataGridView()
        {
            dgvCTHD.DataSource = ChiTietHoaDonBUS.LayDanhSachCTHD();
        }
        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cuahang_bangiayDataSet4.ChiTietHoaDon' table. You can move, or remove it, as needed.
            this.chiTietHoaDonTableAdapter.Fill(this.cuahang_bangiayDataSet4.ChiTietHoaDon);
            LoadDataGridView();

        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCTHD.Rows[e.RowIndex];
                txtMacthd.Text = row.Cells["MaCTHD"].Value.ToString();
                txtMahd.Text = row.Cells["MaHD"].Value.ToString();
                txtMagiay.Text = row.Cells["MaGiay"].Value.ToString();
                txtSize.Text = row.Cells["Size"].Value.ToString();
                txtSoluong.Text = row.Cells["SoLuong"].Value.ToString();
                txtDongia.Text = row.Cells["DonGia"].Value.ToString();
                txtGiagoc.Text = row.Cells["GiaGoc"].Value.ToString();
                txtKhuyenmai.Text = row.Cells["KhuyenMai"].Value.ToString();
                txtThanhtien.Text = row.Cells["ThanhTien"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ChiTietHoaDonDTO cthd = new ChiTietHoaDonDTO();
            cthd.MaCTHD = int.Parse(txtMacthd.Text);
            cthd.MaHD = int.Parse(txtMahd.Text);
            cthd.MaGiay = int.Parse(txtMagiay.Text);
            cthd.Size = int.Parse(txtSize.Text);
            cthd.SoLuong = int.Parse(txtSoluong.Text);
            cthd.DonGia = int.Parse(txtDongia.Text);
            cthd.GiaGoc = int.Parse(txtGiagoc.Text);
            cthd.KhuyenMai = int.Parse(txtKhuyenmai.Text);
            cthd.ThanhTien = int.Parse(txtThanhtien.Text);



            if (ChiTietHoaDonBUS.ThemCTHD(cthd))
            {
                MessageBox.Show("Thêm cthd thành công");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Thêm cthd thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int MaCTHD = int.Parse(txtMacthd.Text);

            if (ChiTietHoaDonBUS.XoaCTHD(MaCTHD))
            {
                MessageBox.Show("Xóa cthd thành công");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Xóa cthd thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ChiTietHoaDonDTO cthd = new ChiTietHoaDonDTO();
            cthd.MaCTHD = int.Parse(txtMacthd.Text);
            cthd.MaHD = int.Parse(txtMahd.Text);
            cthd.MaGiay = int.Parse(txtMagiay.Text);
            cthd.Size = int.Parse(txtSize.Text);
            cthd.SoLuong = int.Parse(txtSoluong.Text);
            cthd.DonGia = int.Parse(txtDongia.Text);
            cthd.GiaGoc = int.Parse(txtGiagoc.Text);
            cthd.KhuyenMai = int.Parse(txtKhuyenmai.Text);
            cthd.ThanhTien = int.Parse(txtThanhtien.Text);

            if (ChiTietHoaDonBUS.CapNhatCTHD(cthd))
            {
                MessageBox.Show("Cập nhật cthd thành công");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Cập nhật cthd thất bại");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int maCTHD = int.Parse(txtTim.Text);
            dgvCTHD.DataSource = ChiTietHoaDonBUS.TimCTHD(maCTHD);
        }

        private void txtThanhtien_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            double donGia = double.Parse(txtDongia.Text);
            double khuyenMai = double.Parse(txtKhuyenmai.Text);
            int soLuong = int.Parse(txtSoluong.Text);

            double tongTien = (donGia - khuyenMai) * soLuong;

            txtThanhtien.Text = tongTien.ToString();
        }
    }
}
