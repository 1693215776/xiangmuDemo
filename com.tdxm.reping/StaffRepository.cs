using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using System.Linq.Expressions;

namespace com.tdxm.reping
{
   public class StaffRepository:cangguan<staff>
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
            warehousing_systemEntities entities = new warehousing_systemEntities();
            //条件总记录数
            count = entities.staff.Where(where).Count();
            pageCount = count == 0 ? 1 : (count % pageSize == 0 ? count / pageSize : count / pageSize + 1);
            //最小页为1
            if (pageIndex <= 1) pageIndex = 1;
            //最大页为总页数
            else if (pageIndex >= pageCount) pageIndex = pageCount;
            //过滤行
            var filterCount = (pageIndex - 1) * pageSize;

            return entities.staff.Where(where).OrderByDescending(orderBy).Skip(filterCount).Take(pageSize).ToList();
        }
    }
}
