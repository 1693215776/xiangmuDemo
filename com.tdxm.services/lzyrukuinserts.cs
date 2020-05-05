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
 /// 这里是productmanagement的增删改查(产品表)
 /// </summary>
    public class lzyrukuinserts
    {
        /// <summary>
        /// 查询 带分页 带排序
        /// </summary>
        /// <typeparam name="Tkey"></typeparam>
        /// <param name="where"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageCount"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<productmanagement> GetByWhereAsc<Tkey>(Expression<Func<productmanagement, bool>> where, Expression<Func<productmanagement, Tkey>> orderBy, ref int pageIndex, int pageSize, ref int pageCount, ref int count)
        {
            var repository = new lzyrukuinsert();
            return repository.GetByWhereAsc(where, orderBy, ref pageIndex, pageSize, ref pageCount, ref count);
        }
        /// <summary>
        /// 添加 
        /// </summary>
        /// <param name="tb_Bill"></param>
        /// <returns></returns>
        public bool Add(productmanagement tb_Bill)
        {
            var repository = new lzyrukuinsert();
            return repository.Add(tb_Bill);
        }
        /// <summary>
        /// 条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<productmanagement> GetByWhere(Expression<Func<productmanagement, bool>> where)
        {
            var repository = new lzyrukuinsert();
            return repository.GetByWhere(where);
        }
        /// <summary>
        /// 修改 
        /// </summary>
        /// <param name="tb_Bill"></param>
        /// <returns></returns>
        public bool Update(productmanagement tb_Bill)
        {
            var repository = new lzyrukuinsert();
            return repository.Update(tb_Bill);
        }
        // <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            var repository = new lzyrukuinsert();
            return repository.Delete(id);
        }
    }
}

