using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using System.Linq.Expressions;

namespace com.tdxm.reping
{/// <summary>
 /// 这里是productmanagement的增删改查(产品表)
 /// </summary>
    public class lzyrukuinsert
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
            warehousing_systemEntities entities = new warehousing_systemEntities();
            //OrderBy 升序
            //OrderByDescending  降序
            //计算过滤行数
            //总行数
            count = entities.productmanagement.Where(where).Count();
            //总页数
            pageCount = count == 0 ? 1 : (count % pageSize == 0 ? count / pageSize : count / pageSize + 1);

            if (pageIndex <= 1) pageIndex = 1;  //当传入当前页为不合法值，逻辑判断默认值
            if (pageIndex >= pageCount) pageIndex = pageCount;
            var filterCount = (pageIndex - 1) * pageSize;
            return entities.productmanagement.Where(where).OrderBy(orderBy).Skip(filterCount).Take(pageSize).ToList();
        }

        /// <summary>
        /// 添加 
        /// </summary>
        /// <param name="tb_Bill"></param>
        /// <returns></returns>
        public bool Add(productmanagement tb_Bill)
        {
            var entities = new warehousing_systemEntities();
            entities.productmanagement.Add(tb_Bill);
            return entities.SaveChanges() > 0;
        }
        /// <summary>
        /// 条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<productmanagement> GetByWhere(Expression<Func<productmanagement, bool>> where)
        {
            var entities = new warehousing_systemEntities();
            return entities.productmanagement.Where(where).ToList();
        }

        /// <summary>
        /// 修改 
        /// </summary>
        /// <param name="tb_Bill"></param>
        /// <returns></returns>
        public bool Update(productmanagement tb_Bill)
        {
            var entities = new warehousing_systemEntities();
            entities.Entry(tb_Bill).State = System.Data.Entity.EntityState.Modified;
            return entities.SaveChanges() > 0;
        }
        // <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            warehousing_systemEntities entities = new warehousing_systemEntities();
            var removeAnimal = entities.productmanagement.Find(id);
            entities.productmanagement.Remove(removeAnimal);

            return entities.SaveChanges() > 0;
        }
    }
}
    
   

