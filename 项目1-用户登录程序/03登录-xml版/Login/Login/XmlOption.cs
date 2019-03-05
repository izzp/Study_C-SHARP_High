using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Login
{
    class XmlOption
    {
        /// <summary>
        /// 把用户信息写入Xml
        /// </summary>
        /// <param name="user">要注册的用户信息</param>
        /// <returns>true:写入成功；false：写入失败</returns>
        static public bool writerFile(Users u)
        {
            bool result = false;
            XElement users = XElement.Load(@"..\..\users.xml");
            try
            {
                users.Add(new XElement("user",
                                   new XElement("name", u.UserName),
                                   new XElement("password", u.Password)));
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                users.Save(@"..\..\users.xml");
            }
            return result;
        }
        /// <summary>
        /// 去Xml中读取用户
        /// </summary>
        /// <param name="u">要读取的用户信息</param>
        /// <returns>true:读取成功；false：读取失败</returns>
        static public bool readFile(Users u)
        {
            bool result = false;
            XElement users = XElement.Load(@"..\..\users.xml");
            try
            {
                foreach (var v in users.Elements())
                {
                    if (v.Element("name").Value == u.UserName)
                    {
                        if (v.Element("password").Value == u.Password)
                        {
                            result = true;
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
                users.Save(@"..\..\users.xml");
            }
            return result;
        }

        static public bool readFile(string userName)
        {
            bool result = false;
            XElement users = XElement.Load(@"..\..\users.xml");
            try
            {
                foreach (var v in users.Elements())
                {
                    if (v.Element("name").Value == userName)
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
                users.Save(@"..\..\users.xml");
            }
            return result;
        }
    }
}

