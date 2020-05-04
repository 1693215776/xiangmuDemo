using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using com.tdxm.reping;
namespace com.tdxm.services
{
   public class CanGuanService:BaseService<stockmanagement>
    {
        public bool Update(stockmanagement tb)
        {
            var repository = new CanGuanRepsitory();
            return repository.Update(tb);
        }
        public static int DelInStorage(stockmanagement pc, int id)
        {
            return CanGuanRepsitory.DelInStorage(pc, id);
        }
    }
}
