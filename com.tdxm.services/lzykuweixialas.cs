using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using com.tdxm.reping;


namespace com.tdxm.services
{/// <summary>
/// 这里是库位类型表查询（做下拉列表用）
/// </summary>
 public   class lzykuweixialas
    {
        public List<kuweitype> GetAll()
        {
            var tt = new lzykuweixiala();
            return tt.GetAll();
        }
    }
}
