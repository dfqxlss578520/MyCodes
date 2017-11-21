using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjectTest.Ninject
{
    public class NinjectMessage:IMessageProvider
    {
        public string GetMessage()
        {
            return "这是使用Ninject技术访问的信息";
        }
    }
}