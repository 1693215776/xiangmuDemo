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
  public  class lzypandians
    {/// <summary>
    /// 计量单位下拉列表，盘点里面的
    /// </summary>
    /// <returns></returns>
        public List<unit> GetAll()
        {
            var tt = new lzypandian();
            return tt.GetAll();
        }
        public bool Add(check tb_Bill)
        {
            var repository = new lzypandian();
            return repository.Add(tb_Bill);
        }
    }
}
