using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using System.Linq.Expressions;
using System.Data.Entity;

namespace com.tdxm.reping
{
   public class cangguan<T> where T : class
    {
        DbContext dbContext = null;
        public DbContext MyDbContext
        {
            get
            {
                if (dbContext == null)
                {
                    dbContext = new DbContext("name=warehousing_systemEntities");
                }
                return dbContext;
            }
        }

        /// <summary>
        /// 获取所有商品信息
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            return MyDbContext.Set<T>().ToList();
        }

        /// <summary>
        /// 条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<T> GetByWhere(Expression<Func<T, bool>> where, bool pr = true)
        {
            warehousing_systemEntities ss = new warehousing_systemEntities();
            ss.Configuration.ProxyCreationEnabled = false;
            return MyDbContext.Set<T>().Where(where).ToList();
        }

        /// <summary>
        /// 条件升序查询 带分页 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<T> GetByWhereAsc<orderByT>
       (Expression<Func<T, bool>> where, Expression<Func<T, orderByT>> orderBy, ref int pageIndex, ref int pageCount, ref int count, int pageSize)
        {
            count = MyDbContext.Set<T>().Where(where).Count(); //总条数
            pageCount = count % pageSize == 0 ? count / pageSize : count / pageSize + 1; //总页数
            if (pageIndex <= 1 || count == 0) pageIndex = 1;
            else if (pageIndex >= pageCount) pageIndex = pageCount;

            var filterCount = (pageIndex - 1) * pageSize;
            return MyDbContext.Set<T>().Where(where).OrderBy(orderBy).Skip(filterCount).Take(pageSize).ToList();
        }
        //skip;跳出，过滤指定行数  take 获取指定行数记录

        /// <summary>
        /// 条件降序查询 带分页 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<T> GetByWhereDesc<orderByT>(Expression<Func<T, bool>> where, Expression<Func<T, orderByT>> orderBy, ref int pageIndex, ref int count, ref int pageCount, int pageSize)
        {
            count = MyDbContext.Set<T>().Where(where).Count(); //总条数
            pageCount = count % pageSize == 0 ? count / pageSize : count / pageSize + 1; //总页数
            if (pageIndex <= 1 || count == 0) pageIndex = 1;
            else if (pageIndex >= pageCount) pageIndex = pageCount;

            var filterCount = (pageIndex - 1) * pageSize;
            return MyDbContext.Set<T>().Where(where).OrderByDescending(orderBy).Skip(filterCount).Take(pageSize).ToList();
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add(T model)
        {
            MyDbContext.Entry<T>(model).State = EntityState.Added;
            var result = MyDbContext.SaveChanges();
            return result > 0;
        }

        /// <summary>
        /// 修改
        /// 修改的实体 必须主键有值
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(T model)
        {
            MyDbContext.Entry<T>(model).State = EntityState.Modified;
            var result = MyDbContext.SaveChanges();
            return result > 0;
        }


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Delete(T model)
        {
            MyDbContext.Entry<T>(model).State = EntityState.Deleted;
            var result = MyDbContext.SaveChanges();
            return result > 0;
        }
    }
   
}

