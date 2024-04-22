using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAL
{
    public class GiayDAL
    {
        public List<GiayDTO> LayDanhSachGiay()
        {
            List<GiayDTO> dsSach = new List<GiayDTO>();
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM GIAY", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    GiayDTO giayDTO = new GiayDTO();
                    giayDTO.MaGiay = reader.GetInt32(0);
                    giayDTO.TenGiay = reader.GetString(1);
                    giayDTO.Size = reader.GetInt32(2);
                    giayDTO.Gia = reader.GetInt32(3);
                    giayDTO.MaNCC = reader.GetInt32(4);
                    giayDTO.Hinh = reader.GetString(5);
                    giayDTO.MaLoai = reader.GetInt32(6);
                    giayDTO.TrangThai = reader.GetInt32(7);
                    dsSach.Add(giayDTO);
                }
                reader.Close();
            }
            return dsSach;
        }
        public bool ThemGiay(GiayDTO giay)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("INSERT INTO Giay (MaGiay, TenGiay, Size, Gia, MaNCC, Hinh, MaLoai, TrangThai) VALUES(@MaGiay, @TenGiay, @Size, @Gia, @MaNCC, @Hinh, @MaLoai, @TrangThai)", connection);
                command.Parameters.AddWithValue("@MaGiay", giay.MaGiay);
                command.Parameters.AddWithValue("@TenGiay", giay.TenGiay);
                command.Parameters.AddWithValue("@Size", giay.Size);
                command.Parameters.AddWithValue("@Gia", giay.Gia);
                command.Parameters.AddWithValue("@MaNCC", giay.MaNCC);
                command.Parameters.AddWithValue("@Hinh", giay.Hinh);
                command.Parameters.AddWithValue("@MaLoai", giay.MaLoai);
                command.Parameters.AddWithValue("@TrangThai", giay.TrangThai);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Hàm cập nhật tài khoản
        public bool CapNhatGiay(GiayDTO giay)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("UPDATE Giay SET MaGiay=@MaGiay, TenGiay=@TenGiay, Size=@Size, Gia=@Gia, MaNCC=@MaNCC, Hinh=@Hinh, MaLoai=@MaLoai, TrangThai=@TrangThai WHERE MaGiay=@MaGiay", connection);
                command.Parameters.AddWithValue("@MaGiay", giay.MaGiay);
                command.Parameters.AddWithValue("@TenGiay", giay.TenGiay);
                command.Parameters.AddWithValue("@Size", giay.Size);
                command.Parameters.AddWithValue("@Gia", giay.Gia);
                command.Parameters.AddWithValue("@MaNCC", giay.MaNCC);
                command.Parameters.AddWithValue("@Hinh", giay.Hinh);
                command.Parameters.AddWithValue("@MaLoai", giay.MaLoai);
                command.Parameters.AddWithValue("@TrangThai", giay.TrangThai);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public bool XoaGiay(int MaGiay)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("DELETE FROM Giay WHERE MaGiay=@MaGiay", connection);
                command.Parameters.AddWithValue("@MaGiay", MaGiay);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }

        }
        public List<GiayDTO> TimGiay(string tenGiay)
        {
            List<GiayDTO> dsGiay = new List<GiayDTO>();

            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Giay WHERE TenGiay LIKE @TenGiay", connection);
                command.Parameters.AddWithValue("@TenGiay", "%" + tenGiay + "%");
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    GiayDTO giayDTO = new GiayDTO();
                    giayDTO.MaGiay = reader.GetInt32(0);
                    giayDTO.TenGiay = reader.GetString(1);
                    giayDTO.Size = reader.GetInt32(2);
                    giayDTO.Gia = reader.GetInt32(3);
                    giayDTO.MaNCC = reader.GetInt32(4);
                    giayDTO.Hinh = reader.GetString(5);
                    giayDTO.MaLoai = reader.GetInt32(6);
                    giayDTO.TrangThai = reader.GetInt32(7);
                    dsGiay.Add(giayDTO);
                }

                reader.Close();
            }

            return dsGiay;
        }
    }   
}
