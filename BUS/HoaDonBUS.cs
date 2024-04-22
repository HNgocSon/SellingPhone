using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonBUS
    {
        private HoaDonDAL hdDAL = new HoaDonDAL();
        public List<HoaDonDTO> LayDanhSachHoaDon()
        {
            return hdDAL.LayDanhSachHoaDon();
        }
        public bool ThemHD(HoaDonDTO hd)
        {
            return hdDAL.ThemHD(hd);
        }
        // Cập nhật tài khoản
        public bool CapNhatHD(HoaDonDTO hd)
        {
            return hdDAL.CapNhatHD(hd);
        }
        // Xóa tài khoản
        public bool XoaHD(int MaHD)
        {
            return hdDAL.XoaHD(MaHD);
        }
        // Tìm kiếm tài khoản
        public List<HoaDonDTO> TimHD(int maHD)
        {
            return hdDAL.TimHD(maHD);
        }
    }
}
