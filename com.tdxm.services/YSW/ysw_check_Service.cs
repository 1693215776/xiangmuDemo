using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using com.tdxm.reping;
using com.tdxm.reping.YSW;

namespace com.tdxm.services.YSW
{
   public class ysw_check_Service:BaseService<check>
    {
        public bool Update(check ck)
        {
            var repository = new  ysw_check_Repsitory();
            return repository.Update(ck);
        }
        public static int DelInStorage(check pc, int id)
        {
            return ysw_check_Repsitory.DelInStorage(pc, id);
        }
    }
}
