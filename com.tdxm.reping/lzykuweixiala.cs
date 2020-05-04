using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
namespace com.tdxm.reping
{/// <summary>
/// 库位类型表(做下拉列表)
/// </summary>
  public  class lzykuweixiala
    {
        public List<kuweitype> GetAll()
        {
            var entities = new warehousing_systemEntities();
            return entities.kuweitype.ToList();
        }
    }
}
