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
    
    public partial class technical
    {
        public int technicalId { get; set; }
        public Nullable<int> studentId { get; set; }
        public string courseName { get; set; }
        public Nullable<double> sscAggregate { get; set; }
        public Nullable<double> hscAggregate { get; set; }
        public Nullable<double> enggAggregate { get; set; }
        public Nullable<int> noOfBacklog { get; set; }
        public Nullable<int> noOfYearDrop { get; set; }
        public Nullable<int> appliedCompany { get; set; }
    
        public virtual student student { get; set; }
    }
}
