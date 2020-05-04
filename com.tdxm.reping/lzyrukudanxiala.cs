using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
namespace com.tdxm.reping
{
 public   class lzyrukudanxiala
    {/// <summary>
    /// 这里是入库类型表(做下拉列表)
    /// </summary>
    /// <returns></returns>
        public List<Storagetype> GetAll()
        {
            var entities = new warehousing_systemEntities();
            return entities.Storagetype.ToList();
        }
    }
}
