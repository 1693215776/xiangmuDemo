using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tdxm.model;
namespace com.tdxm.reping
{
  public  class lzypandian
    {
        /// <summary>
        /// 计量单位下拉列表，盘点里面的
        /// </summary>
        /// <returns></returns>
        public List<unit> GetAll()
        {
            var entities = new warehousing_systemEntities();
            List <unit> list = entities.unit.ToList();
            //list.checktypeid
            return list;
        }
        public bool Add(check tb_Bill)
        {
            var entities = new warehousing_systemEntities();
            entities.check.Add(tb_Bill);
            return entities.SaveChanges() > 0;
        }
    }
}
