using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using com.tdxm.reping;
namespace com.tdxm.services
{
   public class ChuKuService:BaseService<Warehousemanagement>
    {
        public bool Update(Warehousemanagement ck)
        {
            var repository = new ChuKuRepsitory();
            return repository.Update(ck);
        }
        public static int DelInStorage(Warehousemanagement pc, int id)
        {
            return ChuKuRepsitory.DelInStorage(pc, id);
        }
    }
}
