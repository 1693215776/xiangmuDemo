//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.tdxm.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class salesreturn
    {
        public int sid { get; set; }
        public Nullable<int> thid { get; set; }
        public Nullable<int> thnumber { get; set; }
        public Nullable<int> correlationid { get; set; }
        public Nullable<int> stateid { get; set; }
        public string czfs { get; set; }
        public System.DateTime AddTime { get; set; }
        public string beizhu { get; set; }
        public string bsr { get; set; }
        public string ProductName { get; set; }
        public string BarCode { get; set; }
        public Nullable<int> meteringid { get; set; }
        public string guige { get; set; }
        public string leibie { get; set; }
        public string pici { get; set; }
        public string kuwei { get; set; }
        public Nullable<int> IsDelete { get; set; }
        public Nullable<int> Chukushuliang { get; set; }
        public string phone { get; set; }
        public string lxr { get; set; }
        public string Address { get; set; }
        public string khid { get; set; }
        public string Khname { get; set; }
        public string zdpeople { get; set; }
    
        public virtual audit audit { get; set; }
        public virtual salestype salestype { get; set; }
    }
}
