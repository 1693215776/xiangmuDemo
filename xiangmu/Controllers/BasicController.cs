using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using com.tdxm.model;
using com.tdxm.services;
using System.Linq.Expressions;

namespace xiangmu.Controllers
{
    public class BasicController : Controller
    {
        // GET: Basic
        public ActionResult Index()
        {
            return View();
        }
        public int PageSize
        {
            get { return 2; }
        }

        /// <summary>
        /// 库位管理
        /// </summary>
        /// <returns></returns>
        public ActionResult StaffQuery()
        {
            var service= new StaffService();
            var list = service.GetAll();
            ViewBag.Staff = list;
            return View();

        }

        public ActionResult GetStaff(int typeId, string name, int pageIndex)
        {
            var service = new StaffService();
            //组合条件
            Expression<Func<staff, bool>> where = item => true;

            //if (typeId != 0)
            //{
            //    //当类型不是全部选中项，则按照类型组合条件
            //    where = where.And(item => item.TypeId.Equals(typeId));
            //}
            //if (!string.IsNullOrEmpty(name))
            //{
            //    //当文本框不为空值时，则加 名称作为条件
            //    where = where.And(item => item.Name.IndexOf(name) != -1);
            //}
            var pageCount = 0;
            var count = 0;
            var list = service.GetByWhereDesc(where, item => item.staffid, ref pageIndex, PageSize, ref pageCount, ref count);
            //var list = service.GetByWhere(where);
            //返回数据
            //Actionresult  常用响应类型  ViewResult ContentResult JsonResult
            // Json数据格式 { 名称:值 } 数组 [{},{}]
            // 格式转换
            var newFormatList = list.Select(item => new { Id = item.staffid, Name = item.staffName, Iphone = item.iphone, Departmentid = item.departmentid, Roleid = item.roleid, Clerkid = item.clerkid, Logins = item.logins });

            //将数据构建打包给前台
            var result = new
            {
                PageIndex = pageIndex,
                PageCount = pageCount,
                Count = count,
                StafflInfies = newFormatList
            };

            return Json(result, JsonRequestBehavior.AllowGet);
        }


        public ActionResult StaffAdd()
        {
            var service = new StaffService();
            var listTypes = service.GetAll();

            //构建下拉框绑定数据格式化数据
            ViewBag.TypeId = new SelectList(listTypes, "Id", "Name");

            return View();
        }


        //public ActionResult GetStaffAdd()
        //{

        //}


        /// <summary>
        /// 供应商管理
        /// </summary>
        /// <returns></returns>
        public ActionResult supplierQuery()
        {
            //var = new 
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