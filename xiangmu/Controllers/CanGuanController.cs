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
    public class CanGuanController : Controller
    {
        // GET: CanGuan      
        public ActionResult zhuye()
        {
            return View();
        }

        public ActionResult RuKu()
        {
            return View();
        }

        public ActionResult lzycha()
        {
            var tt = new lzyrukuchas();
            var kuwe = tt.GetAll();
            var newform = kuwe.Select(item => new { Inid = item.Inid, typeid = item.Storagetype.typename, supplierid = item.supplierid, stateid = item.audit.auditname, supname = item.supname, ContactName = item.ContactName, Cpid = item.Cpid, zdpeople = item.zdpeople, AddTime = item.AddTime, phone = item.phone, beizhu = item.beizhu, cpname = item.cpname, BarCode = item.BarCode, BatchNum = item.BatchNum, pici = item.pici, num = item.num, Count = item.Count, money = item.money, kuwei = item.kuwei });
            var result = new
            {
                qq = newform
            };
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult chaxun(int inid)
        {
            var tt = new lzyrukuchas();
            Expression<Func< stockmanagement, bool>> where = item => true;
            if (inid != 0)
            {
                where = where.And(item => item.Inid == inid);
            }
            var list = tt.GetByWhere(where);
            var newform = list.Select(item => new { Inid = item.Inid, typeid = item.typeid, supplierid=item.Storagetype.typename, stateid=item.audit.auditname, supname=item.supname, ContactName=item.ContactName, Cpid=item.Cpid, zdpeople=item.zdpeople, AddTime=item.AddTime, phone=item.phone,beizhu=item.beizhu, cpname=item.cpname, BarCode=item.BarCode, BatchNum=item.BatchNum,pici=item.pici, num=item.num,Count=item.Count, money=item.money, kuwei=item.kuwei });
            var result = new
            {
                qq = newform
            };
            return Json(result, JsonRequestBehavior.AllowGet);

        }


        /// <summary>
        /// 产品表
        /// </summary>
        /// <param name="productbiao"></param>
        /// <returns></returns>
     
        public ActionResult rukuinserts(stockmanagement stockmanagement)
        {
            var xz = new lzyrukudaninserts();
         
            stockmanagement.czfs = "电脑";
            stockmanagement.IsDelete = 1;
            stockmanagement.stateid = 1;
           
          
            var ss = xz.Add(stockmanagement);
            var result = new
            {
                ActionResult = ss,
                Msg = ss ? "添加成功" : "添加失败"
            };
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 林子洋入库库位管理
        /// </summary>
        /// <returns></returns>
        public ActionResult lzyrukukuweiguanli(int leixing,string name)
        {
            var cangku = new lzykuweichaxuns();
            Expression<Func<kuwei, bool>> where = item => true;
            if (leixing != 0)
            {
                where = where.And(item => item.kuWeiTypeid==leixing);
            }
            if (!string.IsNullOrEmpty(name))
            {
                where = where.And(item => item.kuweiname.IndexOf(name) != -1);
            }
            var list = cangku.GetByWhere(where);
            var newform = list.Select(item => new { kuweiid = item.kuweiid, kuweiname = item.kuweiname, kuWeiTypeid = item.kuweitype.kuWeiTypename, forbidden = item.forbidden, defaults = item.defaults });
            var result = new
            {
                qq = newform
            };
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 入库类别
        /// </summary>
        /// <param name="leixing"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public ActionResult lzyruku(int leixing,string name)
        {
            var service = new lzyrukuinserts();
            Expression<Func<productmanagement, bool>> where = item => true;
            if (leixing != 0)
            {
                where = where.And(item => item.productid==leixing);
            }
            if (!string.IsNullOrEmpty(name))
            {
                where = where.And(item => item.commodityname.IndexOf(name) != -1);  
            }

            var list = service.GetByWhere(where);
            var newlformatlist = list.Select(item => new { Cpid = item.Cpid, commodityname = item.commodityname, productid = item.product.productname, metering = item.unit.name, price = item.price });

            var result = new
            {
                ss = newlformatlist
            };


            return Json(result, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 供应商表
        /// </summary>
        /// <returns></returns>
        public ActionResult lzyrukugongyingshang(string name)
        {
            var gg = new lzyrukugyss();
            Expression<Func<supplier, bool>> where = item => true;
            if (!string.IsNullOrEmpty(name))
            {
                where = where.And(item => item.supplierName.IndexOf(name) != -1);
            }
            var list = gg.GetByWhere(where);

            var newlformatlists = list.Select(item => new { supplierid = item.supplierid, supplierName = item.supplierName, contacts=item.contacts, phone = item.phone, Email = item.email, address = item.address });

            var result = new
            {
                re = newlformatlists
            };
            return Json(result, JsonRequestBehavior.AllowGet);
        }

       
        public ActionResult RuKuInsert()
        {
            //库位管理表
            var ku = new lzykuweixialas();
            var kuwe = ku.GetAll();
            kuwe.Insert(0, new kuweitype() { kuWeiTypeid = 0, kuWeiTypename = "请选择库位类型" });

            //入库单类型
            var danhao = new lzyrukudanxialas();
            var hao = danhao.GetAll();
            hao.Insert(0, new Storagetype() { typeid = 0, typename = "请选择入库单类型" });
          
            //类别表
            var xiala = new lzyleibieinserts();
            var qq = xiala.GetAll();
            qq.Insert(0, new product() { productid = 0, productname = "请选择类别" });       
            ViewBag.leixing = qq;
            ViewBag.kuweileixing = kuwe;
            ViewBag.rukudan = hao;
            return View();
            
        }
    

        public ActionResult ChuKu()
        {

            return View();
        }

        /// <summary>
        /// 出库客户表查询
        /// </summary>
        /// <returns></returns>
        public ActionResult kehuchaxun(string name)
        {
            var kh = new lzychukuchaxuns();
            Expression<Func<client, bool>> where = item => true;
            if (!string.IsNullOrEmpty(name))
            {
                where = where.And(item => item.clientname.IndexOf(name) != -1);
            }
            var list = kh.GetByWhere(where);
            var newlformatlistss = list.Select(item => new { clientid=item.clientid, clientname=item.clientname,phone=item.phone, email = item.email, address=item.address,beizhu=item.beizhu });

            var result = new
            {
                re = newlformatlistss
            };
            return Json(result, JsonRequestBehavior.AllowGet);

          
        }
        /// <summary>
        /// 出库产品表查询
        /// </summary>
        /// <returns></returns>
        public ActionResult chanping(string cpid)
        {
            var cp = new lzychukuchaxuns();
            Expression<Func<productmanagement, bool>> where = item => true;
            if (!string.IsNullOrEmpty(cpid))
            {
                where = where.And(item => item.Cpid.IndexOf(cpid) != -1);
            }
            var list = cp.GetByWhere(where);
            var newlformatlistss = list.Select(item => new { meteringid=item.meteringid, commodityname = item.commodityname, Cpid = item.Cpid, pici = item.pici, kuWeiTypeName = item.kuWeiTypeName, kucui = item.kucui, price=item.price, amount=item.amount, BatchNum=item.BatchNum });
            var result = new
            {
                
                re = newlformatlistss
            };
            return Json(result, JsonRequestBehavior.AllowGet);

        }

        public ActionResult chanping2(string cpid)
        {
            var cp = new lzychukuchaxuns();
            Expression<Func<productmanagement, bool>> where = item => true;
            if (!string.IsNullOrEmpty(cpid))
            {
                where = where.And(item => item.Cpid.IndexOf(cpid) != -1);
            }
            var list = cp.GetByWhere(where);
            var newlformatlistss = list.Select(item => new { commodityname = item.commodityname, Cpid = item.Cpid, meteringid = item.meteringid, pici = item.pici, price = item.price, amount=item.amount, BatchNum=item.BatchNum,/*出库数*/kuWeiTypeName=item.kuWeiTypeName, productid = item.unit.name });
            var result = new
            {
                re = newlformatlistss
            };
            return Json(result, JsonRequestBehavior.AllowGet);

        }

        /// <summary>
        /// 出库客户表新增
        /// </summary>
        /// <returns></returns>
     

        public ActionResult shopping(Warehousemanagement Warehousemanagement)
        {
            var xz2 = new lzychukuchaxuns();
            Warehousemanagement.IsDelete = 1;
            Warehousemanagement.stateid = 1;
            Warehousemanagement.czfs = "电脑";
        

            var ss = xz2.Add(Warehousemanagement);
            var result = new
            {
                ActionResult = ss,
                M = ss ? "添加成功" : "添加失败"
            };
            return Json(result, JsonRequestBehavior.AllowGet);
        }


        public ActionResult ChuKuInsert()
        {
            var ck = new lzychukuchaxuns();
            var qq = ck.GetAll();
            qq.Insert(0, new cktype() { cktypeid = 0, ckname = "请选择出货单类型" });
            ViewBag.chuku = qq;
            return View();
        }

        public ActionResult BaoSun()
        {
            return View();
        }

        public ActionResult baosun1(damage damage)
        {
            var xz2 = new lzybaosuns();
            damage.bsr = "坤坤";
            damage.stateid = 1;
            damage.IsDelete = 1;
            damage.czfs = "电脑";

            var ss = xz2.Add(damage);
            var result = new
            {
                ActionResult = ss,
                M = ss ? "添加成功" : "添加失败"
            };
            return Json(result, JsonRequestBehavior.AllowGet);
          
        }
        public ActionResult BaoSunInsert()
        {
            var ck = new lzybaosuns();
            var qq = ck.GetAll();
            qq.Insert(0, new damagetype() { damagetypeid = 0, damagetypename = "请选择报损类型" });
            ViewBag.baosun = qq;
            return View();
        }
        public ActionResult YiKu()
        {
            return View();
        }

        public ActionResult yiku1(move move)
        {
            var tt = new lzyyikus();
            move.bsr = "坤坤";
            move.stateid = 1;
            move.IsDelete = 1;
            move.czfs = "电脑";
            var ss = tt.Add(move);
            var result = new
            {
                ActionResult = ss,
                M = ss ? "添加成功" : "添加失败"
            };
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public ActionResult YiKuInsert()
        {
            var ck = new lzyyikus();
            var qq = ck.GetAll();
            //qq.Insert(0, new movetype() { movetypeid = 0, movetypename = "请选择移库类型" });
            ViewBag.yiku = qq;
            return View();
        }
        public ActionResult PanDian()
        {
            return View();
        }
        /// <summary>
        /// 盘点查询
        /// </summary>
        /// <param name="commodityname"></param>
        /// <param name="metering"></param>
        /// <returns></returns>
        public ActionResult pandianchanping(string commodityname, int metering)
        {
            var cp = new lzychukuchaxuns();
            Expression<Func<productmanagement, bool>> where = item => true;
            if (!string.IsNullOrEmpty(commodityname))
            {
                where = where.And(item => item.commodityname.IndexOf(commodityname) != -1);
            }
            if (metering != 0)
            {
                where = where.And(item => item.metering==metering);
            }
          
            var list = cp.GetByWhere(where);
            var newlformatlistss = list.Select(item => new { meteringid = item.meteringid, commodityname = item.commodityname, Cpid = item.Cpid, pici = item.pici, kuWeiTypeName = item.kuWeiTypeName, kucui = item.kucui, productid=item.unit.name, metering=item.metering, price=item.price, BatchNum=item.BatchNum });
            var result = new
            {
                re = newlformatlistss
            };
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult pandianxinzeng(check check)
        {
            var xz2 = new lzypandians();
            check.bsr = "坤坤";
            check.stateid = 1;
            check.IsDelete = 1;
            check.czfs = "电脑";
            check.checktypeid = "产品盘点";

            var ss = xz2.Add(check);
            var result = new
            {
                ActionResult = ss,
                M = ss ? "添加成功" : "添加失败"
            };
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public ActionResult PanDianInsert()
        {
            var tt = new lzypandians();
            var qq = tt.GetAll();
            qq.Insert(0, new unit() { metering = 0, name = "请选择单位" });
            ViewBag.danwen = qq;
            return View();
         
        }
        public ActionResult TuiHuo()
        {
            return View();
        }
        public ActionResult tuihuo2(salesreturn salesreturn )
        {
            var xz2 = new lzytuihuos();
            salesreturn.bsr = "坤坤";
            salesreturn.stateid = 1;
            salesreturn.IsDelete = 1;
            salesreturn.czfs = "电脑";
          

            var ss = xz2.Add(salesreturn);
            var result = new
            {
                ActionResult = ss,
                M = ss ? "添加成功" : "添加失败"
            };
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public ActionResult TuiHuoInsert()
        {
            var tt = new lzytuihuos();
            var qq = tt.GetAll();
            qq.Insert(0, new salestype() { thtypeid = 0, thtypename = "请选择出库单类型" });
            ViewBag.tuihuo = qq;
            return View();
           
        }
    }
}