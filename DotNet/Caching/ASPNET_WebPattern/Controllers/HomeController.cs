using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET_WebPattern.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (WebContextCache.UserContextData == null)
                WebContextCache.Load();

            if (WebRuntimeCache.UserGetRuntimeData == null)
                WebRuntimeCache.Load();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}