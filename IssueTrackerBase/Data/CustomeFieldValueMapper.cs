//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IssueTrackerBase.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomeFieldValueMapper
    {
        public int MapperId { get; set; }
        public int CustomerFieldId { get; set; }
        public Nullable<int> IntegerValue { get; set; }
        public Nullable<decimal> DeceimalValue { get; set; }
        public string TextValue { get; set; }
        public Nullable<System.DateTime> DateValue { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    
        public virtual CustomerField CustomerField { get; set; }
    }
}
