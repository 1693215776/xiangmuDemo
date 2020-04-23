using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using System.Linq.Expressions;
namespace com.tdxm.reping
{
   public class DlRepository
    {
        /// <summary>
        /// 条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<register> GetByWhere(Expression<Func<register, bool>> where)
        {
            var entities = new warehousing_systemEntities();
            return  entities.register.Where(where).ToList();
        }

        public List<register> GetByWhereDesc<Tkey>(Expression<Func<register, bool>> where, Expression<Func<register, Tkey>> orderBy, ref int pageIndex, ref int pageCount, ref int count, int pageSize)
        {
            var entities = new warehousing_systemEntities();
            count = entities.register.Where(where).Count();
            pageCount = count == 0 ? 1 : (count % pageSize == 0 ? count / pageSize : count / pageSize + 1);
            if (pageIndex <= 1) pageIndex = 1;
            else if (pageIndex >= pageCount) pageIndex = pageCount;
            var filterCount = (pageIndex - 1) * pageSize;
            return entities.register.Where(where).OrderByDescending(orderBy).Skip(filterCount).Take(pageSize).ToList();
        }

        public static register Login(string userName, string pwd)
        {
            warehousing_systemEntities entity = new warehousing_systemEntities();
            var obj = from p in entity.register where p.login == userName && p.password == pwd select p;
            if (obj.Count() > 0)
            {
                return obj.First();
            }

            return null;



        }
    }
}
