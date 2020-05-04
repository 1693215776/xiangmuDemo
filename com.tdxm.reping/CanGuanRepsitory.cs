using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
namespace com.tdxm.reping
{
  public class CanGuanRepsitory:cangguan<stockmanagement>
    {
        /// <summary>
        /// 修改 
        /// </summary>
        /// <param name="stockmanagement"></param>
        /// <returns></returns>
        public bool Update(stockmanagement tb)
        {
            var entities = new warehousing_systemEntities();
            entities.Entry(tb).State = System.Data.Entity.EntityState.Modified;
            return entities.SaveChanges() > 0;
        }
        public static int DelInStorage(stockmanagement pc, int id)
        {
            warehousing_systemEntities entity = new warehousing_systemEntities();
            var obj = (from p in entity.stockmanagement where p.Inid == id select p).First();
            obj.IsDelete = pc.IsDelete;
            return entity.SaveChanges();
        }
    }
}
