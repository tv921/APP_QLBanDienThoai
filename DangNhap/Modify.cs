using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBDT.DangNhap
{
    class Modify
    {
        public Modify()
        {

        }
        SqlCommand SqlCommand; //dung de truy van cac cau lenh insert, update, delete, ...
        SqlDataReader dataReader; //dung de doc du lieu trong bang

        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = DANGKY.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = SqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }

            return taiKhoans;

        }
        public void Command(string query)//dung de dang ky tai khoan
        {
            using (SqlConnection sqlConnection = DANGKY.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand = new SqlCommand(query, sqlConnection);
                SqlCommand.ExecuteNonQuery();//thuc thi cau truy van
                sqlConnection.Close();
            }
        }
    }
}
