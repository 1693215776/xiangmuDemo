using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using com.tdxm.reping;

namespace com.tdxm.services
{/// <summary>
 /// 这里是入库类别表查询(product)
 /// </summary>
    public class lzyleibieinserts
    {
        public List<product> GetAll()
        {
            var tt = new lzyleibieinsert();
            return tt.GetAll();
        }
    }
}
