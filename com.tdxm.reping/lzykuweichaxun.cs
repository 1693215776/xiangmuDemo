using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using System.Linq.Expressions;

namespace com.tdxm.reping
{/// <summary>
/// 这里是库位管理表查询()
/// </summary>
 public   class lzykuweichaxun
    {
        /// <summary>
        /// 条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<kuwei> GetByWhere(Expression<Func<kuwei, bool>> where)
        {
            var entities = new warehousing_systemEntities();
            return entities.kuwei.Where(where).ToList();
        }
    }
}
