using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class FileOption
    {
        static string path = @"../../users.txt";
        /// <summary>
        /// 把用户信息写入文件
        /// </summary>
        /// <param name="line">要写入的用户信息</param>
        /// <returns>true:写入成功；false：写入失败</returns>
        static public bool writerFile(Users u)
        {
            bool result = false;
            string line = u.UserName + "\t" + u.Password;
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(path, true, Encoding.GetEncoding("utf-8"));
                sw.WriteLine(line);
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sw.Close();
            }
            return result;

        }
        /// <summary>
        /// 去文件读取用户
        /// </summary>
        /// <param name="u">要读取的用户信息</param>
        /// <returns>true:读取成功；false：读取失败</returns>
        static public bool readFile(Users u)
        {
            bool result = false;
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(path, Encoding.GetEncoding("utf-8"));
                string[] str;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    str = line.Split('\t');
                    if (str[0] == u.UserName && str[1] == u.Password)
                    {
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sr.Close();
            }
            return result;
        }
        static public bool readFile(string userName)
        {
            bool result = false;
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(path, Encoding.GetEncoding("utf-8"));
                string[] str;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    str = line.Split('\t');
                    if (str[0] == userName)
                    {
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sr.Close();
            }
            return result;
        }
    }
}

