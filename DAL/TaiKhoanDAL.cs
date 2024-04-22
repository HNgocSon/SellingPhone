using System.Collections.Generic;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class TaiKhoanDAL
    {
        public TaiKhoanDTO DangNhap(string taiKhoan, string matKhau)
        {
            TaiKhoanDTO taiKhoanDTO = null;

            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM TAIKHOAN WHERE TaiKhoan=@TaiKhoan AND MatKhau=@MatKhau", connection);
                command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                command.Parameters.AddWithValue("@MatKhau", matKhau);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    taiKhoanDTO = new TaiKhoanDTO();
                    taiKhoanDTO.MaTaiKhoan = reader.GetInt32(0);
                    taiKhoanDTO.HoTen = reader.GetString(1);
                    taiKhoanDTO.TaiKhoan = reader.GetString(2);
                    taiKhoanDTO.MatKhau = reader.GetString(3);
                    taiKhoanDTO.Quyen = reader.GetInt32(4);
                    taiKhoanDTO.TrangThai = reader.GetInt32(5);
                }

                reader.Close();
            }

            return taiKhoanDTO;
        }
        public List<TaiKhoanDTO> LayDanhSachTaiKhoan()
        {
            List<TaiKhoanDTO> dsTaiKhoan = new List<TaiKhoanDTO>();

            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM TAIKHOAN", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();
                    taiKhoanDTO.MaTaiKhoan = reader.GetInt32(0);
                    taiKhoanDTO.HoTen = reader.GetString(1);
                    taiKhoanDTO.TaiKhoan = reader.GetString(2);
                    taiKhoanDTO.MatKhau = reader.GetString(3);
                    taiKhoanDTO.Quyen = reader.GetInt32(4);
                    taiKhoanDTO.TrangThai = reader.GetInt32(5);
                    dsTaiKhoan.Add(taiKhoanDTO);
                }

                reader.Close();
            }

            return dsTaiKhoan;
        }
        public bool ThemTaiKhoan(TaiKhoanDTO taiKhoan)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("INSERT INTO TAIKHOAN(MaTaiKhoan,HoTen, TaiKhoan, MatKhau, Quyen, TrangThai) VALUES(@MaTaiKhoan,@HoTen, @TaiKhoan, @MatKhau, @Quyen, @TrangThai)", connection);
                command.Parameters.AddWithValue("@MaTaiKhoan", taiKhoan.MaTaiKhoan);
                command.Parameters.AddWithValue("@HoTen", taiKhoan.HoTen);
                command.Parameters.AddWithValue("@TaiKhoan", taiKhoan.TaiKhoan);
                command.Parameters.AddWithValue("@MatKhau", taiKhoan.MatKhau);
                command.Parameters.AddWithValue("@Quyen", taiKhoan.Quyen);
                command.Parameters.AddWithValue("@TrangThai", taiKhoan.TrangThai);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Hàm cập nhật tài khoản
        public bool CapNhatTaiKhoan(TaiKhoanDTO taiKhoan)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("UPDATE TAIKHOAN SET HoTen=@HoTen, TaiKhoan=@TaiKhoan, MatKhau=@MatKhau, Quyen=@Quyen, TrangThai=@TrangThai WHERE MaTaiKhoan=@MaTaiKhoan", connection);
                command.Parameters.AddWithValue("@MaTaiKhoan", taiKhoan.MaTaiKhoan);
                command.Parameters.AddWithValue("@HoTen", taiKhoan.HoTen);
                command.Parameters.AddWithValue("@TaiKhoan", taiKhoan.TaiKhoan);
                command.Parameters.AddWithValue("@MatKhau", taiKhoan.MatKhau);
                command.Parameters.AddWithValue("@Quyen", taiKhoan.Quyen);
                command.Parameters.AddWithValue("@TrangThai", taiKhoan.TrangThai);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public bool XoaTaiKhoan(int maTaiKhoan)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("DELETE FROM TAIKHOAN WHERE MaTaiKhoan=@MaTaiKhoan", connection);
                command.Parameters.AddWithValue("@MaTaiKhoan", maTaiKhoan);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }

        }
        public List<TaiKhoanDTO> TimKiemTaiKhoan(string taiKhoan)
        {
            List<TaiKhoanDTO> dsTaiKhoan = new List<TaiKhoanDTO>();

            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM TAIKHOAN WHERE TaiKhoan LIKE @TaiKhoan", connection);
                command.Parameters.AddWithValue("@TaiKhoan", "%" + taiKhoan + "%");
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();
                    taiKhoanDTO.MaTaiKhoan = reader.GetInt32(0);
                    taiKhoanDTO.HoTen = reader.GetString(1);
                    taiKhoanDTO.TaiKhoan = reader.GetString(2);
                    taiKhoanDTO.MatKhau = reader.GetString(3);
                    taiKhoanDTO.Quyen = reader.GetInt32(4);
                    taiKhoanDTO.TrangThai = reader.GetInt32(5);
                    dsTaiKhoan.Add(taiKhoanDTO);
                }

                reader.Close();
            }

            return dsTaiKhoan;
        }

    }
}
