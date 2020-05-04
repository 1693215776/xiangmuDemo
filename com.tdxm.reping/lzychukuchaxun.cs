using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using System.Linq.Expressions;
namespace com.tdxm.reping
{/// <summary>
 /// 出库类型表(做下拉列表)
 /// </summary>
    public class lzychukuchaxun
    {/// <summary>
    /// 出库类型表查询
    /// </summary>
    /// <returns></returns>
        public List<cktype> GetAll()
        {
            var entities = new warehousing_systemEntities();
            return entities.cktype.ToList();
        }
        /// <summary>
        /// 条件查询 出库客户表查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<client> GetByWhere(Expression<Func<client, bool>> where)
        {
            var entities = new warehousing_systemEntities();
            return entities.client.Where(where).ToList();
        }
        /// <summary>
        /// 出库产品表查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<productmanagement> chuku(Expression<Func<productmanagement, bool>> where)
        {
            var entities = new warehousing_systemEntities();
            return entities.productmanagement.Where(where).ToList();
        }/// <summary>
        /// 产品表无条件查询
        /// </summary>
        /// <returns></returns>
        public List<productmanagement> GetAll2()
        {
            var entities = new warehousing_systemEntities();
            return entities.productmanagement.ToList();
        }

        /// <summary>
        /// 出库商品新增 
        /// </summary>
        /// <param name="tb_Bill"></param>
        /// <returns></returns>
        public bool Add(Warehousemanagement tb_Bill)
        {
            var entities = new warehousing_systemEntities();
            entities.Warehousemanagement.Add(tb_Bill);
            return entities.SaveChanges() > 0;
        }

        /// <summary>
        /// 出库客户添加 
        /// </summary>
        /// <param name="tb_Bill"></param>
        /// <returns></returns>
        public bool Add2(OutStorage tb_Bill)
        {
            var entities = new warehousing_systemEntities();
            entities.OutStorage.Add(tb_Bill);
            return entities.SaveChanges() > 0;
        }





    }
}
