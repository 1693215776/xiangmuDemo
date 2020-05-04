using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace xiangmu.FuZhu
{
    public class FuZhu
    {

        int leixings = 0;
        public int leixing
        {
            get { return leixings; }
            set { leixings = value; }
        }
        public int RuKuDanHao { get; set; }
        //DateTime? start = DateTime.Now.AddDays(-7);
        public DateTime? Stratdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int pageindex { get; set; }
        public string  clientname { get; set; }
        public int cktypeid { get; set; }

        public int auditname { get; set; }

    }
}