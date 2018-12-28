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
    
    public partial class ReleaseVersion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReleaseVersion()
        {
            this.IssueDetails = new HashSet<IssueDetail>();
            this.ReleaseVersionProjectMappers = new HashSet<ReleaseVersionProjectMapper>();
        }
    
        public int ReleaseVersionId { get; set; }
        public string VersionName { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<bool> IsReleased { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<System.DateTime> ReleaseDate { get; set; }
        public bool IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssueDetail> IssueDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReleaseVersionProjectMapper> ReleaseVersionProjectMappers { get; set; }
    }
}
