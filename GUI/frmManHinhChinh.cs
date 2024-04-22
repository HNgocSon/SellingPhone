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
    public partial class frmManHinhChinh : Form
    {
        private TaiKhoanDTO taiKhoanDTO;

        public frmManHinhChinh(TaiKhoanDTO taiKhoanDTO)
        {
            InitializeComponent();
            this.taiKhoanDTO = taiKhoanDTO;
        }
        void phanquyen() {
            //Hiển thị lên Label
            lblTen.Text = "Tên: " + taiKhoanDTO.HoTen;
            if (taiKhoanDTO.Quyen == 1)
                lblQuyen.Text = "Quyền: Quản Lý";
            else
            if (taiKhoanDTO.Quyen == 2)
                lblQuyen.Text = "Quyền: Nhân Viên Bán Hàng";
            //Nếu tài khoản có quyền nhân viên thì ẩn 
            //các button mà nhân viên không được phép sử dụng
            if (taiKhoanDTO.Quyen == 2)
            {
                btnNhanvien.Visible = false;
                btnBangTaiKhoan.Visible = false;
                btnNhacungcap.Visible = false;
                btnNhanvien.Visible=false;
            }
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
        }

        private void frmManHinhChinh_Load(object sender, EventArgs e)
        {
            phanquyen();
        }

        private void btnBangTaiKhoan_Click(object sender, EventArgs e)
        {
            frmBangTaiKhoan f = new frmBangTaiKhoan();
            f.Show();
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.Show();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            frmBanGiay f = new frmBanGiay();
            f.Show();
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            frmHoaDon f=new frmHoaDon();   
            f.Show();
        }

        private void btnCTHD_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDon f=new frmChiTietHoaDon();
            f.Show();
        }

        private void btnNhacungcap_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f=new frmNhaCungCap();
            f.Show();
        }

        private void lblQuyen_Click(object sender, EventArgs e)
        {

        }
    }
}
