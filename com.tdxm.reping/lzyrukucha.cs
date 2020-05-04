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
        /// 条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<stockmanagement> GetByWhere(Expression<Func<stockmanagement, bool>> where)
        {
            var entities = new warehousing_systemEntities();
            return entities.stockmanagement.Where(where).ToList();
        }

        public List<stockmanagement> GetAll()
        {
            var entities = new warehousing_systemEntities();
            return entities.stockmanagement.ToList();
        }
    }
}
