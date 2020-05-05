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
/// 这里是供应商表
/// </summary>
  public  class lzyrukugyss
    {
        /// <summary>
        /// 条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<supplier> GetByWhere(Expression<Func<supplier, bool>> where)
        {
            var repository = new lzyrukugys();
            return repository.GetByWhere(where);
        }
    }
}
