using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietHoaDonDAL
    {
        public List<ChiTietHoaDonDTO> LayDanhSachCTHD()
        {
            List<ChiTietHoaDonDTO> dsCTHD = new List<ChiTietHoaDonDTO>();
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM ChiTietHoaDon", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChiTietHoaDonDTO cthdDTO = new ChiTietHoaDonDTO();
                    cthdDTO.MaCTHD = reader.GetInt32(0);
                    cthdDTO.MaHD = reader.GetInt32(1);
                    cthdDTO.MaGiay = reader.GetInt32(2);
                    cthdDTO.Size = reader.GetInt32(3);
                    cthdDTO.SoLuong = reader.GetInt32(4);
                    cthdDTO.DonGia = reader.GetInt32(5);
                    cthdDTO.GiaGoc = reader.GetInt32(6);
                    cthdDTO.KhuyenMai = reader.GetInt32(7);
                    cthdDTO.ThanhTien = reader.GetInt32(8);
                    dsCTHD.Add(cthdDTO);
                }
                reader.Close();
            }
            return dsCTHD;
        }
        public bool ThemCTHD(ChiTietHoaDonDTO cthd)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("INSERT INTO ChiTietHoaDon(MaCTHD, MaHD, MaGiay, Size, SoLuong, DonGia,GiaGoc, KhuyenMai,ThanhTien) VALUES(@MaCTHD, @MaHD, @MaGiay, @Size, @SoLuong, @DonGia,@GiaGoc, @KhuyenMai,@ThanhTien)", connection);
                command.Parameters.AddWithValue("@MaCTHD", cthd.MaCTHD);
                command.Parameters.AddWithValue("@MaHD", cthd.MaHD);
                command.Parameters.AddWithValue("@MaGiay", cthd.MaGiay);
                command.Parameters.AddWithValue("@Size", cthd.Size);
                command.Parameters.AddWithValue("@SoLuong", cthd.SoLuong);
                command.Parameters.AddWithValue("@DonGia", cthd.DonGia);
                command.Parameters.AddWithValue("@GiaGoc", cthd.GiaGoc);
                command.Parameters.AddWithValue("@KhuyenMai", cthd.KhuyenMai);
                command.Parameters.AddWithValue("@ThanhTien", cthd.ThanhTien);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Hàm cập nhật tài khoản
        public bool CapNhatCTHD(ChiTietHoaDonDTO cthd)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("UPDATE ChiTietHoaDon SET MaCTHD=@MaCTHD, MaHD=@MaHD, MaGiay=@MaGiay, Size=@Size, SoLuong=@SoLuong, DonGia=@DonGia,GiaGoc=@GiaGoc, KhuyenMai=@KhuyenMai,ThanhTien=@ThanhTien WHERE MaCTHD=@MaCTHD", connection);
                command.Parameters.AddWithValue("@MaCTHD", cthd.MaCTHD);
                command.Parameters.AddWithValue("@MaHD", cthd.MaHD);
                command.Parameters.AddWithValue("@MaGiay", cthd.MaGiay);
                command.Parameters.AddWithValue("@Size", cthd.Size);
                command.Parameters.AddWithValue("@SoLuong", cthd.SoLuong);
                command.Parameters.AddWithValue("@DonGia", cthd.DonGia);
                command.Parameters.AddWithValue("@GiaGoc", cthd.GiaGoc);
                command.Parameters.AddWithValue("@KhuyenMai", cthd.KhuyenMai);
                command.Parameters.AddWithValue("@ThanhTien", cthd.ThanhTien);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public bool XoaCTHD(int MaCTHD)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("DELETE FROM ChiTietHoaDon WHERE MaCTHD=@MaCTHD", connection);
                command.Parameters.AddWithValue("@MaCTHD", MaCTHD);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }

        }
        public List<ChiTietHoaDonDTO> TimCTHD(int maCTHD)
        {
            List<ChiTietHoaDonDTO> dsCTHD = new List<ChiTietHoaDonDTO>();

            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM ChiTietHoaDon WHERE MaCTHD LIKE @MaCTHD", connection);
                command.Parameters.AddWithValue("@MaCTHD", "%" + maCTHD + "%");
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ChiTietHoaDonDTO cthdDTO = new ChiTietHoaDonDTO();
                    cthdDTO.MaCTHD = reader.GetInt32(0);
                    cthdDTO.MaHD = reader.GetInt32(1);
                    cthdDTO.MaGiay = reader.GetInt32(2);
                    cthdDTO.Size = reader.GetInt32(3);
                    cthdDTO.SoLuong = reader.GetInt32(4);
                    cthdDTO.DonGia = reader.GetInt32(5);
                    cthdDTO.GiaGoc = reader.GetInt32(6);
                    cthdDTO.KhuyenMai = reader.GetInt32(7);
                    cthdDTO.ThanhTien = reader.GetInt32(8);
                    dsCTHD.Add(cthdDTO);
                }
                reader.Close();
            }
            return dsCTHD;

        }
    }
}
