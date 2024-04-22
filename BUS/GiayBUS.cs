using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class GiayBUS
    {
        private GiayDAL giayDAL = new GiayDAL();
        public List<GiayDTO> LayDanhSachGiay()
        {
            return giayDAL.LayDanhSachGiay();
        }
        public bool ThemGiay(GiayDTO giay)
        {
            return giayDAL.ThemGiay(giay);
        }
        // Cập nhật tài khoản
        public bool CapNhatGiay(GiayDTO giay)
        {
            return giayDAL.CapNhatGiay(giay);
        }
        // Xóa tài khoản
        public bool XoaGiay(int MaNV)
        {
            return giayDAL.XoaGiay(MaNV);
        }
        // Tìm kiếm tài khoản
        public List<GiayDTO> TimGiay(string tenGiay)
        {
            return giayDAL.TimGiay(tenGiay);
        }
    }
}
