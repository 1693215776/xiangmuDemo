using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace xiangmu.FuZhu
{
    public class RuKuFuZhu
    {
        public int RKDanHao { get; set; }
        public DateTime? Stratdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int pageindex { get; set; }
        public string supplierName { get; set; }
        public int typeid { get; set; }

        public int auditname { get; set; }
    }
   
}