using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using com.tdxm.reping;
using System.Linq.Expressions;

namespace com.tdxm.services
{
   public class StaffService:BaseService<staff>
    {
        /// <summary>
        /// 分页查询
        /// 降序排序
        /// </summary>
        /// <typeparam name="Tkey">排序字段类型</typeparam>
        /// <param name="where">条件</param>
        /// <param name="orderBy">排序字段</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">页码</param>
        /// <returns></returns>
        public List<staff> GetByWhereDesc<Tkey>(Expression<Func<staff, bool>> where, Expression<Func<staff, Tkey>> orderBy, ref int pageIndex, int pageSize, ref int pageCount, ref int count)
        {
            var repository = new StaffRepository();
            return repository.GetByWhereDesc(where, orderBy, ref pageIndex, pageSize, ref pageCount, ref count);
        }
    }
}
