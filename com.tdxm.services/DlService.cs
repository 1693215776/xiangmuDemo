using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using com.tdxm.model;
using com.tdxm.reping;
namespace com.tdxm.services
{
   public class DlService
    {
        /// <summary>
        /// 条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<register> GetByWhere(Expression<Func<register, bool>> where) 
        {
            var repository = new DlRepository();
          return  repository.GetByWhere(where);
        }

        public List<register> GetByWhereDesc<Tkey>(Expression<Func<register, bool>> where, Expression<Func<register, Tkey>> orderBy, ref int pageIndex, ref int pageCount, ref int count, int pageSize)
        {
            var repository = new DlRepository();
            return repository.GetByWhereDesc(where, orderBy, ref pageIndex, ref pageCount, ref count, pageSize);
        }


        public static register Login(string userName, string pwd)
        {
            return DlRepository.Login(userName, pwd);
        }
        }
}
