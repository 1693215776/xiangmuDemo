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
/// 这里是库位管理表查询
/// </summary>
  public  class lzykuweichaxuns
    {
        /// <summary>
        /// 条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<kuwei> GetByWhere(Expression<Func<kuwei, bool>> where)
        {
            var repository = new lzykuweichaxun();
            return repository.GetByWhere(where);
        }
    }
}
