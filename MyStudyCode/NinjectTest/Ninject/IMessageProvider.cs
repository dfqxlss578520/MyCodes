using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest.Ninject
{
    public interface IMessageProvider
    {
        /// <summary>
        /// 获取信息。
        /// </summary>
        /// <returns></returns>
        string GetMessage();
    }
}
