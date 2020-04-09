using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace xiangmu.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult AAAAA()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult sss()
        {
            return View();
        }
        public ActionResult ad()
        {
            return View();
        }

        public ActionResult swlsq()
        {
            return View();
        }

        public ActionResult sj()
        {
            return View();
        }

    }
}