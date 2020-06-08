using DenpendencyInjection.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenpendencyInjection.Relize
{
    public class Test : ITest
    {
        public string name { get; set; }
        public string password { get; set; }

        public Test()
        {
            this.name = "admin";
            this.password = "123456";
        }

        public string Login()
        {
            string str = "姓名：" + name + " 密码：" + password;
            return str;
        }
    }
}
