using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using com.tdxm.reping;
using System.Linq.Expressions;
namespace com.tdxm.services
{/// <summary>
/// 移库下拉列表
/// </summary>
  public  class lzyyikus
    {
        public List<movetype> GetAll()
        {
            var tt = new lzyyiku();
            return tt.GetAll();
        }

        public bool Add(move tb_Bill)
        {
            var repository = new lzyyiku();
            return repository.Add(tb_Bill);
        }
    }
}
