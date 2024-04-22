using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBus
    {
        private NhanVienDAL nhanvienDAL = new NhanVienDAL();

        
        // Lấy danh sách tài khoản
        public List<NhanVienDTO> LayDanhSachNhanVien()
        {
            return nhanvienDAL.LayDanhSachNhanVien();
        }
        // Thêm tài khoản
        public bool ThemNhanVien(NhanVienDTO nhanVien)
        {
            return nhanvienDAL.ThemNhanVien(nhanVien);
        }
        // Cập nhật tài khoản
        public bool CapNhatNhanVien(NhanVienDTO nhanVien)
        {
            return nhanvienDAL.CapNhatNhanVien(nhanVien);
        }
        // Xóa tài khoản
        public bool XoaNhanVien(int MaNV)
        {
            return nhanvienDAL.XoaNhanVien(MaNV);
        }
        // Tìm kiếm tài khoản
        public List<NhanVienDTO> TimKiemNhanVien(string nhanVien)
        {
            return nhanvienDAL.TimKiemNhanVien(nhanVien);
        }

    }
}
