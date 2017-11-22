using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NinjectTest.Ninject;
using Ninject;
using NinjectTest.Helper;      //引入ninject。

namespace NinjectTest.Controllers
{
    public class HomeController : Controller
    {
        private IMessageProvider _messageProvider;
        public HomeController()
        {
            //初始化ninject。
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IMessageProvider>().To<NinjectMessage>();
            this._messageProvider = ninjectKernel.Get<IMessageProvider>();

            LogHelper.WriteLog(typeof(HomeController), "依赖注入了");
        }

        public HomeController(IMessageProvider messageProvider)
        {
            this._messageProvider = messageProvider;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            ViewBag.message = _messageProvider.GetMessage();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
