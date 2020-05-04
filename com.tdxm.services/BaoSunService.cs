using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using com.tdxm.reping;
namespace com.tdxm.services
{
   public class BaoSunService:BaseService<damage>
    {
        public bool Update(damage ck)
        {
            var repository = new BaoSunRepsitory();
            return repository.Update(ck);
        }
        public static int DelInStorage(damage pc, int id)
        {
            return BaoSunRepsitory.DelInStorage(pc, id);
        }
    }
}
