using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using System.Linq.Expressions;
using com.tdxm.reping;
namespace com.tdxm.services
{
 public   class lzyrukuchas
    {

        /// <summary>
        /// 条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<stockmanagement> GetByWhere(Expression<Func<stockmanagement, bool>> where)
        {
            var repository = new lzyrukucha();
            return repository.GetByWhere(where);
        }
        public List<stockmanagement> GetAll()
        {
            var tt = new lzyrukucha();
            return tt.GetAll();
        }
    }
}
