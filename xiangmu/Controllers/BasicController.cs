using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace xiangmu.Controllers
{
    public class BasicController : Controller
    {
        // GET: Basic
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 库位管理
        /// </summary>
        /// <returns></returns>
        public ActionResult StaffQuery()
        {
            return View();
        }
        /// <summary>
        /// 供应商管理
        /// </summary>
        /// <returns></returns>
        public ActionResult supplierQuery()
        {
            return View();
        }



    }
}