using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Login
{
    class DBOption
    {
        static string path = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Administrator\Desktop\05登录-加密版\Login\users.mdf;Integrated Security=True;Connect Timeout=30";
        static public bool writeDB(Users u)
        {
            bool result = false;
            SqlConnection conn = null;
            SqlCommand comm = null;
            try
            {
                conn = new SqlConnection(path);
                conn.Open();
                comm = new SqlCommand("INSERT INTO users VALUES ('" + u.UserName + "','" + u.Password + "')", conn);
                if (comm.ExecuteNonQuery() > 0)
                {
                    result = true;
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
            return result;
        }
        static public bool readDB(Users u)
        {
            bool result = false;
            SqlConnection conn = null;
            conn = new SqlConnection(path);
            conn.Open();
            try
            {
                SqlCommand comm = new SqlCommand("select * from users", conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader.GetString(0) == u.UserName && reader.GetString(1) == u.Password)
                        {
                            result = true;
                            return result;
                        }
                    }
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
            return result;
        }

        static public bool readDB(string userName)
        {
            bool result = false;
            SqlConnection conn = null;
            conn = new SqlConnection(path);
            conn.Open();
            try
            {
                SqlCommand comm = new SqlCommand("select * from users", conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader.GetString(0) == userName)
                        {
                            result = true;
                            return result;
                        }
                    }
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
            return result;
        }

        static public bool updateDB(Users u)
        {
            bool result = false;
            SqlConnection conn = null;
            conn = new SqlConnection(path);
            conn.Open();
            try
            {
                SqlCommand comm = new SqlCommand("update users set Password = '" + u.Password + "' where UserName = '" + u.UserName + "'", conn);
                if (comm.ExecuteNonQuery() > 0)
                {
                    result = true;
                    return result;
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
            return result;
        }
    }
}

