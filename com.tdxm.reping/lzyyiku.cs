using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
namespace com.tdxm.reping
{
 public   class lzyyiku
    {
        public List<movetype> GetAll()
        {
            var entities = new warehousing_systemEntities();
            return entities.movetype.ToList();
        }
        /// <summary>
        /// 出库商品添加 
        /// </summary>
        /// <param name="tb_Bill"></param>
        /// <returns></returns>
        public bool Add(move tb_Bill)
        {
            var entities = new warehousing_systemEntities();
            entities.move.Add(tb_Bill);
            return entities.SaveChanges() > 0;
        }
    }
}
