using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using xiangmu.Models.RequestDto;
using com.tdxm.model;
using com.tdxm.services;
using System.Linq.Expressions;
namespace xiangmu.Controllers
{
    public class FLRController : Controller
    {
        // GET: FLR
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult dl()
        {
            return View();
        }
       

        public ActionResult sy()
        {
            return View();
        }
        public ActionResult Login(string name, string pwd)
        {
            var obj = DlService.Login(name, pwd);
            if (obj != null)
            {
                //将对象保存到session
                Session["user"] = obj;
                return Json(1, JsonRequestBehavior.AllowGet);
            }
            return Json(0, JsonRequestBehavior.AllowGet);
        }

    }
}