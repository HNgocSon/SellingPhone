using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
       

        public List<NhanVienDTO> LayDanhSachNhanVien()
        {
            List<NhanVienDTO> dsSach = new List<NhanVienDTO>();
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM NhanVien", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    NhanVienDTO nhanvienDTO = new NhanVienDTO();
                    nhanvienDTO.MaNV = reader.GetInt32(0);
                    nhanvienDTO.HoNV = reader.GetString(1);
                    nhanvienDTO.TenNV = reader.GetString(2);
                    nhanvienDTO.DCHI = reader.GetString(3);
                    nhanvienDTO.TaiKhoan = reader.GetString(4);
                    nhanvienDTO.MatKhau = reader.GetString(5);
                    nhanvienDTO.NgayVaoLam = reader.GetDateTime(6);
                    nhanvienDTO.MaChucVu = reader.GetInt32(7);
                    nhanvienDTO.TrangThai = reader.GetInt32(8);
                    dsSach.Add(nhanvienDTO);
                }
                reader.Close();
            }
            return dsSach;
        }

        public bool ThemNhanVien(NhanVienDTO nhanVien)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("INSERT INTO NhanVien (MaNV, HoNV, TenNV, DCHI, TaiKhoan,MatKhau,NgayVaoLam,MaChucVu, TrangThai) VALUES(@MaNV,@HoNV, @TenNV,@DCHI,@TaiKhoan,@MatKhau,@NgayVaoLam,@MaChucVu, @TrangThai)", connection);
                command.Parameters.AddWithValue("@MaNV", nhanVien.MaNV);
                command.Parameters.AddWithValue("@HoNV", nhanVien.HoNV);
                command.Parameters.AddWithValue("@TenNV", nhanVien.TenNV);
                command.Parameters.AddWithValue("@DCHI", nhanVien.DCHI);
                command.Parameters.AddWithValue("@TaiKhoan", nhanVien.TaiKhoan);
                command.Parameters.AddWithValue("@MatKhau", nhanVien.MatKhau);
                command.Parameters.AddWithValue("@NgayVaoLam", nhanVien.NgayVaoLam);
                command.Parameters.AddWithValue("@MaChucVu", nhanVien.MaChucVu);
                command.Parameters.AddWithValue("@TrangThai", nhanVien.TrangThai);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Hàm cập nhật tài khoản
        public bool CapNhatNhanVien(NhanVienDTO nhanVien)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("UPDATE NhanVien SET HoNV=@HoNV,TenNV=@TenNV,DCHI=@DCHI, TaiKhoan=@TaiKhoan, MatKhau=@MatKhau, NgayVaoLam=@NgayVaoLam,MaChucVu=@MaChucVu, TrangThai=@TrangThai WHERE MaNV=@MaNV", connection);
                command.Parameters.AddWithValue("@MaNV", nhanVien.MaNV);
                command.Parameters.AddWithValue("@HoNV", nhanVien.HoNV);
                command.Parameters.AddWithValue("@TenNV", nhanVien.TenNV);
                command.Parameters.AddWithValue("@DCHI", nhanVien.DCHI);
                command.Parameters.AddWithValue("@TaiKhoan", nhanVien.TaiKhoan);
                command.Parameters.AddWithValue("@MatKhau", nhanVien.MatKhau);
                command.Parameters.AddWithValue("@NgayVaoLam", nhanVien.NgayVaoLam);
                command.Parameters.AddWithValue("@MaChucVu", nhanVien.MaChucVu);
                command.Parameters.AddWithValue("@TrangThai", nhanVien.TrangThai);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public bool XoaNhanVien(int MaNV)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("DELETE FROM NhanVien WHERE MaNV=@MaNV", connection);
                command.Parameters.AddWithValue("@MaNV", MaNV);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }

        }
        public List<NhanVienDTO> TimKiemNhanVien(string nhanVien)
        {
            List<NhanVienDTO> dsNhanVien= new List<NhanVienDTO>();

            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM NhanVien WHERE TaiKhoan LIKE @TaiKhoan", connection);
                command.Parameters.AddWithValue("@TaiKhoan", "%" + nhanVien + "%");
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    NhanVienDTO nhanvienDTO = new NhanVienDTO();
                    nhanvienDTO.MaNV = reader.GetInt32(0);
                    nhanvienDTO.HoNV = reader.GetString(1);
                    nhanvienDTO.TenNV = reader.GetString(2);
                    nhanvienDTO.DCHI = reader.GetString(3);
                    nhanvienDTO.TaiKhoan = reader.GetString(4);
                    nhanvienDTO.MatKhau = reader.GetString(5);
                    nhanvienDTO.NgayVaoLam = reader.GetDateTime(6);
                    nhanvienDTO.MaChucVu = reader.GetInt32(7);
                    nhanvienDTO.TrangThai = reader.GetInt32(8);
                    dsNhanVien.Add(nhanvienDTO);
                }

                reader.Close();
            }

            return dsNhanVien;
        }

    } 
}

