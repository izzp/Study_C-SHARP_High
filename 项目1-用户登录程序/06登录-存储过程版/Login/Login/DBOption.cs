using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data;

namespace Login
{
    class DBOption
    {

        static string path = @"Data Source=506_65;Initial Catalog=users;Integrated Security=True";
        public static int writeDBPro(Users u)
        {
            SqlConnection conn = null;
            try
            {
               
                conn = new SqlConnection(path);
                conn.Open();
                SqlCommand comm = new SqlCommand("PRO_Register", conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("@user", SqlDbType.NVarChar, 50).Value = u.UserName;
                comm.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = u.Password;
                return comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
       static public  int readDBPro(Users u)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(path);
                conn.Open();
                SqlCommand comm = new SqlCommand("PRO_Login", conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("@user", SqlDbType.NVarChar, 50).Value = u.UserName;
                comm.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = u.Password;
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                    return 1;
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}

