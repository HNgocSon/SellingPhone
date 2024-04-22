using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
   
            public int MaNV { get; set; }
            public string HoNV { get; set; }
            public string TenNV { get; set; }
            public string DCHI { get; set; }
            public string TaiKhoan { get; set; }
            public string MatKhau { get; set; }
            public DateTime NgayVaoLam { get; set; }
            public int MaChucVu { get; set; }
            public int TrangThai { get; set; }
         
    }
}
