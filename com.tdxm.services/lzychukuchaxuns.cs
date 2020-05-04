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
 public   class lzychukuchaxuns
    {/// <summary>
    /// 出库类型表查询
    /// </summary>
    /// <returns></returns>
        public List<cktype> GetAll()
        {
            var tt = new lzychukuchaxun();
            return tt.GetAll();
        }
        /// <summary>
        /// 出库客户条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<client> GetByWhere(Expression<Func<client, bool>> where)
        {
            var repository = new lzychukuchaxun();
            return repository.GetByWhere(where);
        }
        /// <summary>
        /// 出库产品表查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<productmanagement> GetByWhere(Expression<Func<productmanagement, bool>> where)
        {
            var repository = new lzychukuchaxun();
            return repository.chuku(where);
        }            
        /// <summary>
        /// 出库商品新增数据 
        /// </summary>
        /// <param name="tb_Bill"></param>
        /// <returns></returns>
       
        public bool Add(Warehousemanagement tb_Bill)
        {
            var repository = new lzychukuchaxun();
            return repository.Add(tb_Bill);
        }
        /// <summary>
        /// 出库客户新增数据 
        /// </summary>
        /// <param name="tb_Bill"></param>
        /// <returns></returns>
        public bool Add2(OutStorage tb_Bill)
        {
            var repository = new lzychukuchaxun();
            return repository.Add2(tb_Bill);
        }

    }
}
