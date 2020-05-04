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
  public  class lzytuihuos
    {
        /// <summary>
        /// 报损类型下拉列表查询
        /// </summary>
        /// <returns></returns>
        public List<salestype> GetAll()
        {
            var tt = new lzytuihuo();
            return tt.GetAll();
        }
        public bool Add(salesreturn tb_Bill)
        {
            var repository = new lzytuihuo();
            return repository.Add(tb_Bill);
        }
    }
}
