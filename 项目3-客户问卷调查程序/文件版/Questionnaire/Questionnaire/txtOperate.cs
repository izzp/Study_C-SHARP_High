using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    class txtOperate
    {
        static string path = @"../../customer.txt";
        public static bool Writer(Customers cs)
        {
            bool result = false;
            StreamWriter sw = null;
            string line = cs.Name + '\t' + cs.Gender + '\t' + cs.Impression + '\t' + cs.Satisfaction + '\t' + cs.Service;
            try
            {
                sw = new StreamWriter(path, true, Encoding.UTF8);
                sw.WriteLine(line);
                sw.Close();
            }
            catch (Exception ex)
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
