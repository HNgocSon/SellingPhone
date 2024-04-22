using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaCungCapBUS
    {
        private NhaCungCapDAL nccDAL = new NhaCungCapDAL();
        public List<NhaCungCapDTO> LayDanhSachNCC()
        {
            return nccDAL.LayDanhSachNCC();
        }
        public bool ThemNCC(NhaCungCapDTO ncc)
        {
            return nccDAL.ThemNCC(ncc);
        }
        // Cập nhật tài khoản
        public bool CapNhatNCC(NhaCungCapDTO ncc)
        {
            return nccDAL.CapNhatNCC(ncc);
        }
        // Xóa tài khoản
        public bool XoaNCC(int MANCC)
        {
            return nccDAL.XoaNCC(MANCC);
        }
        // Tìm kiếm tài khoản
        public List<NhaCungCapDTO> TimKiemNCC(string tenncc)
        {
            return nccDAL.TimKiemNCC(tenncc);
        }
    }
}
