using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
using com.tdxm.reping;

namespace com.tdxm.services
{
  public  class lzyrukudanxialas
    {
        public List<Storagetype> GetAll()
        {
            var tt = new lzyrukudanxiala();
            return tt.GetAll();
        }
    }
}
