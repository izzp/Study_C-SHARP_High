using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Questionnaire
{
    class XMLOperate
    {
 static string path = @"../../customers.xml";
        public static bool Writer(Customers cs)
        {
            bool result = false;
            try
            {
                XElement customers = XElement.Load(path);
                customers.Add("customers",
                        new XElement("客户",
                                new XElement("name", cs.Name),
                                new XElement("gender", cs.Gender),
                                new XElement("impression", cs.Impression),
                                new XElement("satisfaction", cs.Satisfaction),
                                new XElement("service", cs.Service)
                            )
                    );
                customers.Save(path);

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                result = true;
            }
            return result;
        }
    }
}
