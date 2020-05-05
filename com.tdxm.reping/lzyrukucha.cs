using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using System.Linq.Expressions;
namespace com.tdxm.reping
{
 public   class lzyrukucha
    {
        /// 入库查看条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<stockmanagement> GetByWhere(Expression<Func<stockmanagement, bool>> where)
        {
            var entities = new warehousing_systemEntities();
            return entities.stockmanagement.Where(where).ToList();
        } /// 出库查看条件查询
          /// </summary>
          /// <param name="where"></param>
          /// <returns></returns>
        public List<Warehousemanagement> GetByWhere2(Expression<Func<Warehousemanagement, bool>> where)
        {
            var entities = new warehousing_systemEntities();
            return entities.Warehousemanagement.Where(where).ToList();
        } /// 报损查看条件查询
          /// </summary>
          /// <param name="where"></param>
          /// <returns></returns>
        public List<damage> GetByWhere3(Expression<Func<damage, bool>> where)
        {
            var entities = new warehousing_systemEntities();
            return entities.damage.Where(where).ToList();
        }
        /// 移库查看条件查询
          /// </summary>
          /// <param name="where"></param>
          /// <returns></returns>
        public List<move> GetByWhere4(Expression<Func<move, bool>> where)
        {
            var entities = new warehousing_systemEntities();
            return entities.move.Where(where).ToList();
        }
        /// 盘点查看条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<check> GetByWhere5(Expression<Func<check, bool>> where)
        {
            var entities = new warehousing_systemEntities();
            return entities.check.Where(where).ToList();
        } 
          /// 退货查看条件查询
          /// </summary>
          /// <param name="where"></param>
          /// <returns></returns>
        public List<salesreturn> GetByWhere6(Expression<Func<salesreturn, bool>> where)
        {
            var entities = new warehousing_systemEntities();
            return entities.salesreturn.Where(where).ToList();
        }
     
        public List<stockmanagement> GetAll()
        {
            var entities = new warehousing_systemEntities();
            return entities.stockmanagement.ToList();
        }
    }
}
