//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class job
    {
        public int jobId { get; set; }
        public Nullable<int> companyId { get; set; }
        public string location { get; set; }
        public string technology { get; set; }
        public Nullable<int> salary { get; set; }
        public string designation { get; set; }
        public Nullable<double> sscAggregate { get; set; }
        public Nullable<double> hscAggregate { get; set; }
        public Nullable<double> enggAggregate { get; set; }
    
        public virtual company company { get; set; }
    }
}
