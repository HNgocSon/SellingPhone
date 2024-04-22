using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public int MaHD { get; set; }
        public DateTime NgayLap { get; set; }

        public int MaNhanVien { get; set; }
        public int TrangThai { get; set; }
        public int TongTien { get; set; }
        public string TenKhachHang { get; set; }

    }
}
