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
    
    public partial class CARTRIDGESProduct
    {
        public int id { get; set; }
        public Nullable<int> CARTRIDGESID { get; set; }
        public string productnumber { get; set; }
        public string name { get; set; }
        public string imgurl { get; set; }
        public string maxpressure { get; set; }
        public string maxpressureunit { get; set; }
        public string maxflow { get; set; }
        public string cavitytooling { get; set; }
        public string intallationtorque { get; set; }
        public string intallationtorqueunit { get; set; }
        public string weight { get; set; }
        public string fluidtemp { get; set; }
    
        public virtual CARTRIDGE CARTRIDGE { get; set; }
    }
}