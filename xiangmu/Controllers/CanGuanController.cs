using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using com.tdxm.model;
using xiangmu.FuZhu;

using System.Linq.Expressions;
using com.tdxm.services;
using com.tdxm.services.YSW;
using com.tdxm.reping;

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
        #region 入库的增删改

        public ActionResult DelInStorageRK(stockmanagement pc, int id)
        {
            pc.IsDelete = 1;
            return Json(CanGuanRepsitory.DelInStorage(pc, id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult RuKu()
        {
            var service = new ysw_storagetype_Service();
            var model = service.GetByWhere(item => true);
            model.Insert(0, new Storagetype() { typeid = 9999, typename = "全部" });
            ViewBag.Type = new SelectList(model, "typeid", "typename");
          
            return View();
        }
      
          
         
       
        public ActionResult RuKuCha(FuZhu.RuKuFuZhu rkfz, int aid)
        {
            Expression<Func<stockmanagement, bool>> where = item => item.AddTime >= rkfz.Stratdate && item.AddTime <= rkfz.Enddate&&item.IsDelete==0 ;
            if (rkfz.RKDanHao != 0)
            {
                where = where.And(item => item.Inid == rkfz.RKDanHao);
            }

            if (!string.IsNullOrEmpty(rkfz.supplierName))
            {
                where = where.And(item => item.supplier.supplierName.IndexOf(rkfz.supplierName) != -1);
            }
            if (rkfz.typeid != 9999)
            {
                where = where.And(item => item.Storagetype.typeid.Equals(rkfz.typeid));
            }
            if (aid != 0)
            {
                where = where.And(item => item.stateid == aid);
            }

            var pageindex = rkfz.pageindex;
            var count = 0;
            var pageCount = 0;
            var service = new CanGuanService();

            var fenyes = service.GetByWhereAsc(where, item => item.AddTime, ref pageindex, ref pageCount, ref count, 2);

            var newformlist = fenyes.Select(item => new { Inid = item.Inid, typename = item.Storagetype.typename, supname = item.supplier.supplierName, Cpid = item.Cpid, Count = item.Count, money = item.money, auditname = item.audit.auditname, zdpeople = item.zdpeople, czfs = item.czfs, ProductNames = item.supname,AddTime = Convert.ToDateTime(item.AddTime).ToString("yyyy-MM-dd")});
            
            var fwResult = new
            {
                PageIndex = pageindex,
                PageCount = pageCount,
                Count = count,
                fwaction = newformlist
            };
            return Json(fwResult, JsonRequestBehavior.AllowGet);
        }

        public ActionResult RuKuInsert()
        {

            return View();
        }

        public ActionResult Update(int id)
        {
            var service = new CanGuanService();
            var model = service.GetByWhere(item => item.Inid.Equals(id)).SingleOrDefault();
            return View(model);
        }
       
        public ActionResult RuKuUpdate(stockmanagement a) {
            var service = new CanGuanService();
            var model = service.GetByWhere(item => item.Inid.Equals(a.Inid)).SingleOrDefault();
            //hou.Name = model.Name;
            //hou.Mianji = model.Mianji;
            //hou.Fwhx = model.Fwhx;
            //hou.Zhaoxiang = model.Zhaoxiang;
            //hou.Louceng = model.Louceng;
            //hou.Dianti = model.Dianti;
            //hou.YueZuj = model.YueZuj;
            //hou.Wuyefei = model.Wuyefei;
            a.AddTime = DateTime.Now;
           
            var Updatelist = service.Update(a);

            var UpdateResult = new
            {
                UpdateAPI = Updatelist,
                Msg = Updatelist ? "修改成功!" : "修改失败！"
            };
            return Json(UpdateResult, JsonRequestBehavior.AllowGet);
     
        }

        #endregion

        #region 出库增删改查
        public ActionResult Ckdelete(Warehousemanagement pc, int id)
        {
            pc.IsDelete = 1;
            return Json(ChuKuService.DelInStorage(pc, id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult ChuKuCha(FuZhu.FuZhu fz,int aid)
        {
            Expression<Func<Warehousemanagement, bool>> where = item =>item.AddTime >= fz.Stratdate && item.AddTime <= fz.Enddate&&item.IsDelete==0;
            if (fz.RuKuDanHao != 0)
            {
                where = where.And(item => item.ckid == fz.RuKuDanHao);
            }
            if (!string.IsNullOrEmpty(fz.clientname))
            {
                where = where.And( item => item.supplierid.IndexOf(fz.clientname) != -1);
            }
            if (fz.cktypeid != 9999)
            {
                where = where.And(item => item.cktypeid.Equals(fz.cktypeid));
            }
           
            if (aid != 0)
            {
                where = where.And(item => item.stateid==aid);
            }
            var pageindex = fz.pageindex;
            var count = 0;
            var pageCount = 0;
            var service = new ChuKuService();

            var fenyes = service.GetByWhereAsc(where, item => item.AddTime, ref pageindex, ref pageCount, ref count, 2);

            var newformlist = fenyes.Select(item => new { ckid = item.ckid, ckname = item.cktypeid, clientname = item.supplierid, correlationid = item.correlationid, count = item.count, money = item.money, auditname = item.stateid, czfs = item.czfs, zdpeople = item.zdpeople,kuname=item.khname,AddTime = Convert.ToDateTime(item.AddTime).ToString("yyyy-MM-dd") });
            var fwResult = new
            {
                PageIndex = pageindex,
                PageCount = pageCount,
                Count = count,
                fwaction = newformlist
            };
            return Json(fwResult, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ChuKu()
        {
            var service = new ysw_cktype_Service();
            var model = service.GetByWhere(item => true);
           model.Insert(0, new cktype() { cktypeid = 9999, ckname = "全部" });
           ViewBag.Type = new SelectList(model, "cktypeid", "ckname");
            return View();
        }
       

        public ActionResult ChuKuInsert()
        {
            return View();
        }
        public ActionResult ChuKuUpdate(int id)
        {
            var service = new ChuKuService();
            var model = service.GetByWhere(item => item.ckid.Equals(id)).SingleOrDefault();

            //var services = new houseLxBLL();
            //var models = services.getAll(item => true);
            //ViewBag.Fwhx = new SelectList(models, "Id", "Names", model.Fwhx);
            return View(model);
        }
        public ActionResult ChuKuUpdatea(Warehousemanagement a)
        {
            var service = new ChuKuService();
            var model = service.GetByWhere(item => item.ckid.Equals(a.ckid)).SingleOrDefault();
            //hou.Name = model.Name;
            //hou.Mianji = model.Mianji;
            //hou.Fwhx = model.Fwhx;
            //hou.Zhaoxiang = model.Zhaoxiang;
            //hou.Louceng = model.Louceng;
            //hou.Dianti = model.Dianti;
            //hou.YueZuj = model.YueZuj;
            //hou.Wuyefei = model.Wuyefei;
            a.AddTime = DateTime.Now;

            var Updatelist = service.Update(a);

            var UpdateResult = new
            {
                UpdateAPI = Updatelist,
                Msg = Updatelist ? "修改成功!" : "修改失败！"
            };
            return Json(UpdateResult, JsonRequestBehavior.AllowGet);

        }
        #endregion
        #region 报损操作


        //public ActionResult BSupdate(damage pc, int id)
        //{
        //    pc.IsDelete = 1;
        //    return Json(BaoSunService.BSupdate(pc, id), JsonRequestBehavior.AllowGet);
        //}
        public ActionResult DelInStorage1(damage pc, int id)
        {
            pc.IsDelete = 1;
            return Json(BaoSunService.DelInStorage(pc, id), JsonRequestBehavior.AllowGet);
        }

        public ActionResult BSupdateCha(int id)
        {
            var service = new BaoSunService();
            var model = service.GetByWhere(item => item.bid.Equals(id)).SingleOrDefault();

            //var services = new houseLxBLL();
            //var models = services.getAll(item => true);
            //ViewBag.Fwhx = new SelectList(models, "Id", "Names", model.Fwhx);
            return View(model);
        }
        public ActionResult BSupdate(damage a)
        {
            var service = new BaoSunService();
            var model = service.GetByWhere(item => item.bid.Equals(a.bid)).SingleOrDefault();
            //hou.Name = model.Name;
            //hou.Mianji = model.Mianji;
            //hou.Fwhx = model.Fwhx;
            //hou.Zhaoxiang = model.Zhaoxiang;
            //hou.Louceng = model.Louceng;
            //hou.Dianti = model.Dianti;
            //hou.YueZuj = model.YueZuj;
            //hou.Wuyefei = model.Wuyefei;
            a.addtime = DateTime.Now;

            var Updatelist = service.Update(a);

            var UpdateResult = new
            {
                UpdateAPI = Updatelist,
                Msg = Updatelist ? "修改成功!" : "修改失败！"
            };
            return Json(UpdateResult, JsonRequestBehavior.AllowGet);

        }
        public ActionResult BaoSun()
        {
          
            return View();
        }

        public ActionResult BaoSunCha(FuZhu.BaoSunFuZhu bsfz,int aid)
        {
            Expression<Func<damage, bool>> where = item => item.addtime >= bsfz.Stratdate && item.addtime <= bsfz.Enddate && item.IsDelete == 0 ;
            if (bsfz.BaoSunDanHao != 0)
            {
                where = where.And(item => item.bid == bsfz.BaoSunDanHao);
            }
            if (aid != 0)
            {
                where = where.And(item => item.stateid == aid);
            }
            var pageindex = bsfz.pageindex;
            var count = 0;
            var pageCount = 0;
            var service = new BaoSunService();

            var fenyes = service.GetByWhereAsc(where, item => item.addtime, ref pageindex, ref pageCount, ref count, 2);

            var newformlist = fenyes.Select(item => new { bid = item.bid, damagetypename = item.damagetypeid, correlationname = item.correlationid, quantity = item.quantity, auditname = item.stateid, addpeople = item.addpeople, AddTime = Convert.ToDateTime(item.addtime).ToString("yyyy-MM-dd") });



            var fwResult = new
            {
                PageIndex = pageindex,
                PageCount = pageCount,
                Count = count,
                fwaction = newformlist
            };
            return Json(fwResult, JsonRequestBehavior.AllowGet);

        }
        public ActionResult BaoSunInsert()
        {

            return View();
        }
        #endregion
        public ActionResult DelInStorage(move pc, int id)
        {
            pc.IsDelete = 1;
            return Json(ysw_move_Service.DelInStorage(pc, id), JsonRequestBehavior.AllowGet);
        }
    

        public ActionResult YKupdateCha(int id)
        {
            var service = new ysw_move_Service();
            var model = service.GetByWhere(item => item.mid.Equals(id)).SingleOrDefault();

            //var services = new houseLxBLL();
            //var models = services.getAll(item => true);
            //ViewBag.Fwhx = new SelectList(models, "Id", "Names", model.Fwhx);
            return View(model);


        }
        public ActionResult YKupdate(move a)
        {
            var service = new ysw_move_Service();
            var model = service.GetByWhere(item => item.mid.Equals(a.mid)).SingleOrDefault();
            //hou.Name = model.Name;
            //hou.Mianji = model.Mianji;
            //hou.Fwhx = model.Fwhx;
            //hou.Zhaoxiang = model.Zhaoxiang;
            //hou.Louceng = model.Louceng;
            //hou.Dianti = model.Dianti;
            //hou.YueZuj = model.YueZuj;
            //hou.Wuyefei = model.Wuyefei;
            a.addtime = DateTime.Now;

            var Updatelist = service.Update(a);

            var UpdateResult = new
            {
                UpdateAPI = Updatelist,
                Msg = Updatelist ? "修改成功!" : "修改失败！"
            };
            return Json(UpdateResult, JsonRequestBehavior.AllowGet);

        }
        public ActionResult YiKu()
        {
            return View();
        }
        public ActionResult YiKuCha(YiKuFuZhu ykfz,int aid) {
            Expression<Func<move, bool>> where = item => item.addtime >= ykfz.Stratdate && item.addtime <= ykfz.Enddate && item.IsDelete ==0;
            if (ykfz.YiKuDanHao != 0)
            {
                where = where.And(item => item.mid == ykfz.YiKuDanHao);
            }
            if (aid != 0)
            {
                where = where.And(item => item.stateid == aid);

            }

            var pageindex = ykfz.pageindex;
            var count = 0;
            var pageCount = 0;
            var service = new ysw_move_Service();

            var fenyes = service.GetByWhereAsc(where, item => item.addtime, ref pageindex, ref pageCount, ref count, 2);

            var newformlist = fenyes.Select(item => new { mid = item.mid, movetypename = item.movetype.movetypename, ykname = item.ykodd.ykname, count = item.count, moveperson = item.moveperson, auditname = item.audit.auditname, AddTime = Convert.ToDateTime(item.addtime).ToString("yyyy-MM-dd") });



            var fwResult = new
            {
                PageIndex = pageindex,
                PageCount = pageCount,
                Count = count,
                fwaction = newformlist
            };
            return Json(fwResult, JsonRequestBehavior.AllowGet);

        }
        public ActionResult YiKuInsert()
        {
            return View();
        }




        public ActionResult PDdelete(check pc, int id)
        {
            pc.IsDelete = 1;
            return Json(ysw_check_Service.DelInStorage(pc, id), JsonRequestBehavior.AllowGet);
        }

        public ActionResult PDupdateCha(int id)
        {
            var service = new ysw_check_Service();
            var model = service.GetByWhere(item => item.checkid.Equals(id)).SingleOrDefault();

            //var services = new houseLxBLL();
            //var models = services.getAll(item => true);
            //ViewBag.Fwhx = new SelectList(models, "Id", "Names", model.Fwhx);
            return View(model);


        }
        public ActionResult PDupdate(check a)
        {
            var service = new ysw_check_Service();
            var model = service.GetByWhere(item => item.checkid.Equals(a.checkid)).SingleOrDefault();
            //hou.Name = model.Name;
            //hou.Mianji = model.Mianji;
            //hou.Fwhx = model.Fwhx;
            //hou.Zhaoxiang = model.Zhaoxiang;
            //hou.Louceng = model.Louceng;
            //hou.Dianti = model.Dianti;
            //hou.YueZuj = model.YueZuj;
            //hou.Wuyefei = model.Wuyefei;
            a.AddTime = DateTime.Now;

            var Updatelist = service.Update(a);

            var UpdateResult = new
            {
                UpdateAPI = Updatelist,
                Msg = Updatelist ? "修改成功!" : "修改失败！"
            };
            return Json(UpdateResult, JsonRequestBehavior.AllowGet);

        }
        public ActionResult PanDian()
        {
            return View();
        }
        public ActionResult PanDianCha(PanDianFuZhu pdfz,int aid) {
            Expression<Func<check, bool>> where = item => item.AddTime >= pdfz.Stratdate && item.AddTime <= pdfz.Enddate&&item.IsDelete==0;
            if (pdfz.PanDanDanHao != 0)
            {
                where = where.And(item => item.checkid == pdfz.PanDanDanHao);
            }
            if (aid != 0)
            {
                where = where.And(item => item.stateid == aid);

            }

            var pageindex = pdfz.pageindex;
            var count = 0;
            var pageCount = 0;
            var service = new ysw_check_Service();

            var fenyes = service.GetByWhereAsc(where, item => item.AddTime, ref pageindex, ref pageCount, ref count, 2);

            var newformlist = fenyes.Select(item => new { checkid = item.checkid, checktypename = item.checktypeid, pdname = item.correlationid, auditname = item.stateid, zdpeople = item.zdpeople, czfs=item.czfs, AddTime = Convert.ToDateTime(item.AddTime).ToString("yyyy-MM-dd") });



            var fwResult = new
            {
                PageIndex = pageindex,
                PageCount = pageCount,
                Count = count,
                fwaction = newformlist
            };
            return Json(fwResult, JsonRequestBehavior.AllowGet);
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