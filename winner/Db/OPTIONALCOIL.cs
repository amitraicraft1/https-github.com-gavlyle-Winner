//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace winner.Db
{
    using System;
    using System.Collections.Generic;
    
    public partial class OPTIONALCOIL
    {
        public int id { get; set; }
        public Nullable<int> CARTRIDGESID { get; set; }
        public string voltage { get; set; }
        public string price { get; set; }
        public string imgurl { get; set; }
    
        public virtual CARTRIDGE CARTRIDGE { get; set; }
    }
}