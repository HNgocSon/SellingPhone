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
    public partial class frmHoaDon : Form
    {
        private HoaDonBUS HoaDonBUS;
        public frmHoaDon()
        {
            InitializeComponent();
            HoaDonBUS=new HoaDonBUS();
        }
        private void LoadDataGridView()
        {
            dgv_hoadon.DataSource =HoaDonBUS.LayDanhSachHoaDon();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cuahang_bangiayDataSet2.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.cuahang_bangiayDataSet2.HoaDon);
            LoadDataGridView();
        }

        private void dgv_hoadon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
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

        private void dgv_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_hoadon.Rows[e.RowIndex];
                txtMahd.Text = row.Cells["MaHD"].Value.ToString();
                dtp_Ngaylap.Text = row.Cells["NgayLap"].Value.ToString();
                txtMaNV.Text = row.Cells["MaNhanVien"].Value.ToString();
                cbb_TrangThai.Text = (row.Cells["TrangThai"].Value.ToString() == "1") ? "Hoạt động" : "Không hoạt động";
                txtTongtien.Text = row.Cells["TongTien"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKhachHang"].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            HoaDonDTO hd = new HoaDonDTO();
            hd.MaHD = int.Parse(txtMahd.Text);
            hd.NgayLap = dtp_Ngaylap.MaxDate;
            hd.MaNhanVien =int.Parse(txtMaNV.Text);
            hd.TrangThai = cbb_TrangThai.SelectedIndex;
            hd.TongTien = int.Parse(txtTongtien.Text);
            hd.TenKhachHang = txtTenKH.Text;
            

            if (HoaDonBUS.ThemHD(hd))
            {
                MessageBox.Show("Thêm hóa đơn thành công");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Thêm hóa đơn thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            HoaDonDTO hd = new HoaDonDTO();
            hd.MaHD = int.Parse(txtMahd.Text);
            hd.NgayLap = dtp_Ngaylap.MaxDate;
            hd.MaNhanVien = int.Parse(txtMaNV.Text);
            hd.TrangThai = cbb_TrangThai.SelectedIndex;
            hd.TongTien = int.Parse(txtTongtien.Text);
            hd.TenKhachHang = txtTenKH.Text;

            if (HoaDonBUS.CapNhatHD(hd))
            {
                MessageBox.Show("Cập nhật hóa đơn thành công");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Cập nhật hóa đơn thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int MaHD = int.Parse(txtMahd.Text);

            if (HoaDonBUS.XoaHD(MaHD))
            {
                MessageBox.Show("Xóa Hóa ĐƠn thành công");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Xóa Hóa Đơn thất bại");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int maHD = int.Parse(txtTim.Text);
            dgv_hoadon.DataSource = HoaDonBUS.TimHD(maHD);
        }

        private void dgv_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
