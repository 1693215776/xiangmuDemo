using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using com.tdxm.reping;
using System.Linq.Expressions;
namespace com.tdxm.services
{
 public   class lzybaosuns
    {/// <summary>
     /// 报损类型下拉列表查询
     /// </summary>
     /// <returns></returns>
        public List<damagetype> GetAll()
        {
            var tt = new lzybaosun();
            return tt.GetAll();
        }
        public bool Add(damage tb_Bill)
        {
            var repository = new lzybaosun();
            return repository.Add(tb_Bill);
        }
    }
}
