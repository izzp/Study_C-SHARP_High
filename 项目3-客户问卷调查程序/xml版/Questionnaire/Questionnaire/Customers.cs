using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questionnaire
{
    class Customers
    {
        string name;//姓名
        string gender;//性别
        string impression;//印象
        string satisfaction;//满意的方面
        string service; //服务
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Impression
        {
            get { return impression; }
            set { impression = value; }
        }
        public string Satisfaction
        {
            get { return satisfaction; }
            set { satisfaction = value; }
        }
        public string Service
        {
            get { return service; }
            set { service = value; }
        }
    }
}
