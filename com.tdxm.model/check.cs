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
    
    public partial class check
    {
        public int checkid { get; set; }
        public Nullable<int> checktypeid { get; set; }
        public Nullable<int> correlationid { get; set; }
        public Nullable<int> stateid { get; set; }
        public string zdpeople { get; set; }
        public string czfs { get; set; }
        public System.DateTime AddTime { get; set; }
    
        public virtual audit audit { get; set; }
        public virtual checktype checktype { get; set; }
        public virtual pdodd pdodd { get; set; }
    }
}
