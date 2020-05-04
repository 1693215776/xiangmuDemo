using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;

namespace com.tdxm.reping
{
 public   class lzytuihuo
    {
        /// <summary>
        /// 退货类型下拉列表查询
        /// </summary>
        /// <returns></returns>
        public List<salestype> GetAll()
        {
            var entities = new warehousing_systemEntities();
            return entities.salestype.ToList();
        }

        /// <summary>
        /// 退货商品添加 
        /// </summary>
        /// <param name="tb_Bill"></param>
        /// <returns></returns>
        public bool Add(salesreturn tb_Bill)
        {
            var entities = new warehousing_systemEntities();
            entities.salesreturn.Add(tb_Bill);
            return entities.SaveChanges() > 0;
        }
    }
}
