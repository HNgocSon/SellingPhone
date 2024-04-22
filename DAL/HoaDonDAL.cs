using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL
    {
        public List<HoaDonDTO> LayDanhSachHoaDon()
        {
            List<HoaDonDTO> dsHD = new List<HoaDonDTO>();
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM HoaDon", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    HoaDonDTO hoadonDTO = new HoaDonDTO();
                    hoadonDTO.MaHD = reader.GetInt32(0);
                    hoadonDTO.NgayLap = reader.GetDateTime(1);
                    hoadonDTO.MaNhanVien = reader.GetInt32(2);
                    hoadonDTO.TrangThai = reader.GetInt32(3);
                    hoadonDTO.TongTien = reader.GetInt32(4);
                    hoadonDTO.TenKhachHang = reader.GetString(5);
                    dsHD.Add(hoadonDTO);
                }
                reader.Close();
            }
            return dsHD;
        }
        public bool ThemHD(HoaDonDTO hd)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("INSERT INTO HoaDon (MaHD, NgayLap, MaNhanVien, TrangThai,TongTien, TenKhachHang) VALUES(@MaHD, @NgayLap, @MaNhanVien, @TrangThai, @TongTien, @TenKhachHang)", connection);
                command.Parameters.AddWithValue("@MaHD", hd.MaHD);
                command.Parameters.AddWithValue("@NgayLap", hd.NgayLap);
                command.Parameters.AddWithValue("@MaNhanVien", hd.MaNhanVien);
                command.Parameters.AddWithValue("@TrangThai", hd.TrangThai);
                command.Parameters.AddWithValue("@TongTien", hd.TongTien);
                command.Parameters.AddWithValue("@TenKhachHang", hd.TenKhachHang);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Hàm cập nhật tài khoản
        public bool CapNhatHD(HoaDonDTO hd)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("UPDATE HoaDon SET MaHD=@MaHD, NgayLap=@NgayLap, MaNhanVien=@MaNhanVien, TrangThai=@TrangThai, TongTien=@TongTien, TenKhachHang=@TenKhachHang WHERE MaHD=@MaHD", connection);
                command.Parameters.AddWithValue("@MaHD", hd.MaHD);
                command.Parameters.AddWithValue("@NgayLap", hd.NgayLap);
                command.Parameters.AddWithValue("@MaNhanVien", hd.MaNhanVien);
                command.Parameters.AddWithValue("@TrangThai", hd.TrangThai);
                command.Parameters.AddWithValue("@TongTien", hd.TongTien);
                command.Parameters.AddWithValue("@TenKhachHang", hd.TenKhachHang);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public bool XoaHD(int MaHD)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("DELETE FROM HoaDon WHERE MaHD=@MaHD", connection);
                command.Parameters.AddWithValue("@MaHD", MaHD);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }

        }
        public List<HoaDonDTO> TimHD(int maHD)
        {
            List<HoaDonDTO> dsHD = new List<HoaDonDTO>();

            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM HoaDon WHERE MaHD LIKE @MaHD", connection);
                command.Parameters.AddWithValue("@MaHD", "%" + maHD+ "%");
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    HoaDonDTO hoadonDTO = new HoaDonDTO();
                    hoadonDTO.MaHD = reader.GetInt32(0);
                    hoadonDTO.NgayLap = reader.GetDateTime(1);
                    hoadonDTO.MaNhanVien = reader.GetInt32(2);
                    hoadonDTO.TrangThai = reader.GetInt32(3);
                    hoadonDTO.TongTien = reader.GetInt32(4);
                    hoadonDTO.TenKhachHang = reader.GetString(5);
                    dsHD.Add(hoadonDTO);
                }

                reader.Close();
            }

            return dsHD;
        }
    
}
}
