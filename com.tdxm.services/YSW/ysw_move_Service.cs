using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using com.tdxm.reping.YSW;

namespace com.tdxm.services.YSW
{
  public  class ysw_move_Service:BaseService<move>
    {
        public bool Update(move ck)
        {
            var repository = new ysw_move_Repsitory ();
            return repository.Update(ck);
        }
        public static int DelInStorage(move pc, int id)
        {
            return ysw_move_Repsitory.DelInStorage(pc, id);
        }

    }
}
