using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using System.Linq.Expressions;
using com.tdxm.reping;
namespace com.tdxm.services
{
  public  class lzyrukudaninserts
    {
        /// <summary>
        /// 添加 
        /// </summary>
        /// <param name="tb_Bill"></param>
        /// <returns></returns>
        public bool Add(stockmanagement tb_Bill)
        {
            var repository = new lzyrukudaninsert();
            return repository.Add(tb_Bill);
        }

        public bool add2(productbiao tb_Bill)
        {
            var repository = new lzyrukudaninsert();
            return repository.Add2(tb_Bill);
        }
    }
}
