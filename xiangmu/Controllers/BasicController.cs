using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using com.tdxm.model;
using com.tdxm.services;

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
        /// <summary>
        /// 客户管理
        /// </summary>
        public ActionResult clientQuery()
        {
            return View();
        }
        /// <summary>
        /// 计量单位
        /// </summary>
        public ActionResult meterageQuery()
        {
            return View();
        }
        /// <summary>
        /// 产品类别
        /// </summary>
        public ActionResult productQuery()
        {
            return View();
        }
        /// <summary>
        /// 产品管理
        /// </summary>
        public ActionResult Productmanagement()
        {
            return View();
        }

        public ActionResult StaffAdd()
        {
            return View();
        }

        public ActionResult supplierAdd()
        {
            return View();
        }

        public ActionResult clientAdd()
        {
            return View();
        }

        public ActionResult productAdd()
        {
            return View();
        }
        public ActionResult meterageAdd()
        {
            return View();
        }

        public ActionResult ProductmanagementAdd()
        {
            return View();
        }

        public ActionResult StaffDelete()
        {
            return View();
        }


    }
}