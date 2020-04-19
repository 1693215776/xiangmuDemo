using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using com.tdxm.model;
using com.tdxm.services;



namespace xiangmu.Controllers
{
    public class CanGuanController : Controller
    {
        // GET: CanGuan
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult zhuye()
        {
            return View();
        }

     
        
        public ActionResult RuKu()
        {
            var service = new CanGuanService();
          var list=  service.GetAll();
            ViewBag.list = list;
            return View();
        }
        public ActionResult RuKuInsert()
        {

            return View();
        }
        public ActionResult ChuKu()
        {
            return View();

        }

        public ActionResult ChuKuInsert()
        {
            return View();
        }

        public ActionResult BaoSun()
        {
            return View();
        }
        public ActionResult BaoSunInsert()
        {

            return View();
        }
        public ActionResult YiKu()
        {
            return View();
        }
        public ActionResult YiKuInsert()
        {
            return View();
        }
        public ActionResult PanDian()
        {
            return View();
        }
        public ActionResult PanDianInsert()
        {
            return View();
        }
        public ActionResult TuiHuo()
        {
            return View();
        }
        public ActionResult TuiHuoInsert()
        {
            return View();
        }
    }
}