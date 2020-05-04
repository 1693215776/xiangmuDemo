using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using com.tdxm.model;
using com.tdxm.services;
using System.Linq.Expressions;
using xiangmu.Models.RequestDto;

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
        public ActionResult KuweiQuery() 
        {
            var service = new KuweiService();
            var list = service.GetAll();
            ViewBag.Kuwei = list;
            return View();
        }

        public ActionResult GetKuweis(KuweiQueryRequestDto requestDto)
        {
            var service = new KuweiService();
            //组合条件
            Expression<Func<kuwei, bool>> where = item => true;

            if (!string.IsNullOrEmpty(requestDto.Name))
            {
                where = where.And(item => item.kuweiname.IndexOf(requestDto.Name) != -1);
            }
            where = where.And(item => item.AddTime >= requestDto.StartDate && item.AddTime <= requestDto.EndDate);

            var pageCount = 0;
            var count = 0;
            var pageIndex = requestDto.PageIndex;
            var list = service.GetByWhereAsc(where, item => item.AddTime, ref pageIndex, ref count, ref pageCount, PageSize);
            //var list = service.GetByWhere(where);
            //返回数据
            //Actionresult  常用响应类型  ViewResult ContentResult JsonResult
            // Json数据格式 { 名称:值 } 数组 [{},{}]
            // 格式转换
            var newFormatList = list.Select(item => new { Id = item.kuweiid, Name = item.kuweiname, Warehouseid = item.warehouseid, KuWeiTypeid = item.kuWeiTypeid, Forbidden = item.forbidden, Defaults = item.defaults, AddTime = item.AddTime.ToString("yyyy-MM-dd HH:mm:ss") });

            //将数据构建打包给前台
            var result = new
            {
                PageIndex = pageIndex,
                PageCount = pageCount,
                Count = count,
                KuweilInfies = newFormatList
            };

            return Json(result, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 库位添加
        /// </summary>
        /// <returns></returns>
        public ActionResult KuweiAdd()
        {
            return View();
        }



        /// <summary>
        /// 供应商管理
        /// </summary>
        /// <returns></returns>
        public ActionResult supplierQuery()
        {
            var service= new supplierService();

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