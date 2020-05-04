using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
namespace com.tdxm.reping
{
  public  class BaoSunRepsitory:cangguan<damage>
    {
        public bool Update(damage ck)
        {
            var entities = new warehousing_systemEntities();
            entities.Entry(ck).State = System.Data.Entity.EntityState.Modified;
            return entities.SaveChanges() > 0;
        }
        public static int DelInStorage(damage pc, int id)
        {
            warehousing_systemEntities entity = new warehousing_systemEntities();
            var obj = (from p in entity.damage where p.bid == id select p).First();
            obj.IsDelete = pc.IsDelete;
            return entity.SaveChanges();
        }

    }
}
