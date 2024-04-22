using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietHoaDonBUS
    {
        private ChiTietHoaDonDAL cthdDAL = new ChiTietHoaDonDAL();
        public List<ChiTietHoaDonDTO> LayDanhSachCTHD()
        {
            return cthdDAL.LayDanhSachCTHD();
        }
        public bool ThemCTHD(ChiTietHoaDonDTO cthd)
        {
            return cthdDAL.ThemCTHD(cthd);
        }
        // Cập nhật tài khoản
        public bool CapNhatCTHD(ChiTietHoaDonDTO cthd)
        {
            return cthdDAL.CapNhatCTHD(cthd);
        }
        // Xóa tài khoản
        public bool XoaCTHD(int MaCTHD)
        {
            return cthdDAL.XoaCTHD(MaCTHD);
        }
        // Tìm kiếm tài khoản
        public List<ChiTietHoaDonDTO> TimCTHD(int maCTHD)
        {
            return cthdDAL.TimCTHD(maCTHD);
        }
    }
}

