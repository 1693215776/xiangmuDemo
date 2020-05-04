using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using System.Linq.Expressions;
namespace com.tdxm.reping
{
 public   class lzybaosun
    {/// <summary>
    /// 报损类型下拉列表查询
    /// </summary>
    /// <returns></returns>
        public List<damagetype> GetAll()
        {
            var entities = new warehousing_systemEntities();
            return entities.damagetype.ToList();
        }

        /// <summary>
        /// 出库商品添加 
        /// </summary>
        /// <param name="tb_Bill"></param>
        /// <returns></returns>
        public bool Add(damage tb_Bill)
        {
            var entities = new warehousing_systemEntities();
            entities.damage.Add(tb_Bill);
            return entities.SaveChanges() > 0;
        }
    }
}
