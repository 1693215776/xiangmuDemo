using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using System.Linq.Expressions;
namespace com.tdxm.reping
{/// <summary>
/// 查询供应商表
/// </summary>
  public  class lzyrukugys
    {
        // <summary>
        /// 条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<supplier> GetByWhere(Expression<Func<supplier, bool>> where)
        {
            var entities = new warehousing_systemEntities();
            return entities.supplier.Where(where).ToList();
        }
    }
}
