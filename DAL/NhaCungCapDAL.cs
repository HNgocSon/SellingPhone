using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaCungCapDAL
    {
        public List<NhaCungCapDTO> LayDanhSachNCC()
        {
            List<NhaCungCapDTO> dsncc = new List<NhaCungCapDTO>();
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM NhaCungCap", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //MANCC,TenNCC, DCHI, SDT,  MAIL, TrangThai
                    NhaCungCapDTO nccDTO = new NhaCungCapDTO();
                    nccDTO.MANCC = reader.GetInt32(0);
                    nccDTO.TenNCC = reader.GetString(1);
                    nccDTO.DCHI = reader.GetString(2);
                    nccDTO.SDT = reader.GetString(3);
                    nccDTO.MAIL = reader.GetString(4);
                    nccDTO.TrangThai = reader.GetInt32(5);
                    dsncc.Add(nccDTO);
                }
                reader.Close();
            }
            return dsncc;
        }

        public bool ThemNCC(NhaCungCapDTO ncc)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("INSERT INTO  NhaCungCap(MANCC,TenNCC, DCHI, SDT,  MAIL, TrangThai) VALUES(@MANCC,@TenNCC, @DCHI, @SDT,  @MAIL, @TrangThai)", connection);
                command.Parameters.AddWithValue("@MANCC", ncc.MANCC);
                command.Parameters.AddWithValue("@TenNCC", ncc.TenNCC);
                command.Parameters.AddWithValue("@DCHI", ncc.DCHI);
                command.Parameters.AddWithValue("@SDT", ncc.SDT);
                command.Parameters.AddWithValue("@MAIL", ncc.MAIL);
                command.Parameters.AddWithValue("@TrangThai", ncc.TrangThai);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Hàm cập nhật tài khoản
        public bool CapNhatNCC(NhaCungCapDTO ncc)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("UPDATE NhanVien SET MANCC=@MANCC,TenNCC=@TenNCC, DCHI=@DCHI, SDT=@SDT,  MAIL=@MAIL, TrangThai=@TrangThai WHERE MANCC=@MANCC", connection);
                command.Parameters.AddWithValue("@MANCC", ncc.MANCC);
                command.Parameters.AddWithValue("@TenNCC", ncc.TenNCC);
                command.Parameters.AddWithValue("@DCHI", ncc.DCHI);
                command.Parameters.AddWithValue("@SDT", ncc.SDT);
                command.Parameters.AddWithValue("@MAIL", ncc.MAIL);
                command.Parameters.AddWithValue("@TrangThai", ncc.TrangThai);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public bool XoaNCC(int MANCC)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("DELETE FROM NhaCungCap WHERE MANCC=@MANCC", connection);
                command.Parameters.AddWithValue("@MANCC", MANCC);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }

        }
        public List<NhaCungCapDTO> TimKiemNCC(string tenncc)
        {
            List<NhaCungCapDTO> dsncc = new List<NhaCungCapDTO>();

            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM NhaCungCap WHERE TenNCC LIKE @TenNCC", connection);
                command.Parameters.AddWithValue("@TenNCC", "%" + tenncc + "%");
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    NhaCungCapDTO nccDTO = new NhaCungCapDTO();
                    nccDTO.MANCC = reader.GetInt32(0);
                    nccDTO.TenNCC = reader.GetString(1);
                    nccDTO.DCHI = reader.GetString(2);
                    nccDTO.SDT = reader.GetString(3);
                    nccDTO.MAIL = reader.GetString(4);
                    nccDTO.TrangThai = reader.GetInt32(5);
                    dsncc.Add(nccDTO);
                }

                reader.Close();
            }

            return dsncc;
        }
    }
}
