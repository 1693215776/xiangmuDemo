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
    
    public partial class productmanagement
    {
        public int meteringid { get; set; }
        public string Cpid { get; set; }
        public string commodityname { get; set; }
        public Nullable<int> ceiling { get; set; }
        public Nullable<int> floor { get; set; }
        public string price { get; set; }
        public Nullable<int> productid { get; set; }
        public Nullable<int> metering { get; set; }
        public Nullable<int> warehouseid { get; set; }
        public Nullable<int> clientid { get; set; }
        public string kuWeiTypeName { get; set; }
        public Nullable<int> kucui { get; set; }
        public Nullable<int> ordernum { get; set; }
        public string BatchNum { get; set; }
        public Nullable<int> inprice { get; set; }
        public Nullable<double> amount { get; set; }
        public string pici { get; set; }
    
        public virtual unit unit { get; set; }
        public virtual product product { get; set; }
        public virtual unit unit1 { get; set; }
    }
}
