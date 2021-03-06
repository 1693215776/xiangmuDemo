﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace xiangmu.Models.RequestDto
{
    public class KuweiQueryRequestDto
    {
        private int pageIndex = 1;
        public int PageIndex
        {
            get { return pageIndex; }
            set { pageIndex = value; }
        }
        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount { get; set; }
        /// <summary>
        /// 总条数
        /// </summary>
        public int Count { get; set; }

        public string Name { get; set; }

        private DateTime startDate = DateTime.Now.AddDays(-7);
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        private DateTime endDate = DateTime.Now;
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }



    }
}