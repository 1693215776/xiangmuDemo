using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;

namespace com.tdxm.reping
{
   public class ChuKuRepsitory:cangguan<Warehousemanagement>
    {
        public bool Update(Warehousemanagement ck)
        {
            var entities = new warehousing_systemEntities();
            entities.Entry(ck).State = System.Data.Entity.EntityState.Modified;
            return entities.SaveChanges() > 0;
        }
        public static int DelInStorage(Warehousemanagement pc, int id)
        {
            warehousing_systemEntities entity = new warehousing_systemEntities();
            var obj = (from p in entity.Warehousemanagement where p.ckid == id select p).First();
            obj.IsDelete = pc.IsDelete;
            return entity.SaveChanges();
        }
    }
}
