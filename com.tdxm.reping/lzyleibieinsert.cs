using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;

namespace com.tdxm.reping
{/// <summary>
 /// 这里是入库类别表查询(product)
 /// </summary>
    public class lzyleibieinsert
    {
        public List<product>GetAll()
        {
            var entities = new warehousing_systemEntities();
            return entities.product.ToList();
        }
    }
}
