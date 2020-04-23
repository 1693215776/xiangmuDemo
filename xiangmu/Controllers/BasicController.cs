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
        /// <summary>
        /// 库位管理 添加
        /// </summary>
        /// <returns></returns>
        public ActionResult StaffAdd()
        {
            return View();
        }
        /// <summary>
        /// 供应商管理 添加
        /// </summary>
        /// <returns></returns>
        public ActionResult supplierAdd()
        {
            return View();
        }
        /// <summary>
        /// 客户管理 添加
        /// </summary>
        public ActionResult clientAdd()
        {
            return View();
        }
        /// <summary>
        /// 产品类别 添加
        /// </summary>
        public ActionResult productAdd()
        {
            return View();
        }
        /// <summary>
        /// 计量单位 添加
        /// </summary>
        public ActionResult meterageAdd()
        {
            return View();
        }
        /// <summary>
        /// 产品管理 添加
        /// </summary>
        public ActionResult ProductmanagementAdd()
        {
            return View();
        }
        /// <summary>
        /// 客户管理 修改
        /// </summary>
        public ActionResult clientUpd() 
        {
            return View();
        }

        /// <summary>
        /// 计量单位 修改
        /// </summary>
        public ActionResult meterageUpd() 
        {
            return View(); 
                
        }
        /// <summary>
        /// 产品类别 修改
        /// </summary>
        public ActionResult productUpd() 
        {
            return View();
        }
        /// <summary>
        /// 产品管理 修改
        /// </summary>
        public ActionResult ProductmanagementUpd()
        {
            return View();
        }
        /// <summary>
        /// 库位管理 修改
        /// </summary>
        /// <returns></returns>
        public ActionResult StaffUpd()
        {
            return View();
        }
        /// <summary>
        /// 供应商管理 修改
        /// </summary>
        /// <returns></returns>
        public ActionResult supplierUpd()
        {
            return View();
        }
        /// <summary>
        /// 库位管理 删除
        /// </summary>
        /// <returns></returns>
        public ActionResult StaffDelete()
        {
            return View();
        }
        /// <summary>
        /// 供应商管理 删除
        /// </summary>
        /// <returns></returns>
        public ActionResult supplierDelete()
        {

            return View();
        }
        /// <summary>
        /// 客户管理 删除
        /// </summary>
        public ActionResult clientDelete()
        {
            return View();
        }
        /// <summary>
        /// 计量单位 删除
        /// </summary>
        public ActionResult meterageDelete()
        {
            return View();
        }
        /// <summary>
        /// 产品类别 删除
        /// </summary>
        public ActionResult productDelete()
        {
            return View();
        }
        /// <summary>
        /// 产品管理 删除
        /// </summary>
        public ActionResult ProductmanagementDelete()
        {
            return View();
        }
    }
}