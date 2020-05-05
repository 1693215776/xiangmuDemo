using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using System.Linq.Expressions;
using com.tdxm.reping;
namespace com.tdxm.services
{/// <summary>
/// 查看所有的
/// </summary>
 public   class lzyrukuchas
    {

        /// <summary>
        /// 入库条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<stockmanagement> GetByWhere(Expression<Func<stockmanagement, bool>> where)
        {
            var repository = new lzyrukucha();
            return repository.GetByWhere(where);
        }
        /// <summary>
        /// 出库条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<Warehousemanagement> GetByWhere2(Expression<Func<Warehousemanagement, bool>> where)
        {
            var repository = new lzyrukucha();
            return repository.GetByWhere2(where);
        }
        /// <summary>
        /// 报损条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<damage> GetByWhere3(Expression<Func<damage, bool>> where)
        {
            var repository = new lzyrukucha();
            return repository.GetByWhere3(where);
        }
        /// <summary>
        /// 移库条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<move> GetByWhere4(Expression<Func<move, bool>> where)
        {
            var repository = new lzyrukucha();
            return repository.GetByWhere4(where);
        }
        /// <summary>
        /// 盘点条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<check> GetByWhere5(Expression<Func<check, bool>> where)
        {
            var repository = new lzyrukucha();
            return repository.GetByWhere5(where);
        }
        /// <summary>
        /// 退货条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<salesreturn> GetByWhere6(Expression<Func<salesreturn, bool>> where)
        {
            var repository = new lzyrukucha();
            return repository.GetByWhere6(where);
        }
        public List<stockmanagement> GetAll()
        {
            var tt = new lzyrukucha();
            return tt.GetAll();
        }
    }
}
