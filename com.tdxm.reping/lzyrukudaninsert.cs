using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using System.Linq.Expressions;


namespace com.tdxm.reping
{
    /// <summary>
    /// 整个新增过程
    /// </summary>
   public class lzyrukudaninsert
    {
        /// <summary>
        /// 添加 
        /// </summary>
        /// <param name="tb_Bill"></param>
        /// <returns></returns>
        public bool Add(stockmanagement tb_Bill)
        {
            var entities = new warehousing_systemEntities();
            entities.stockmanagement.Add(tb_Bill);
            return entities.SaveChanges() > 0;
        }

        public bool Add2(productbiao tb_Bill)
        {
            var entities = new warehousing_systemEntities();
            entities.productbiao.Add(tb_Bill);
            return entities.SaveChanges() > 0;
        }
    }
}
