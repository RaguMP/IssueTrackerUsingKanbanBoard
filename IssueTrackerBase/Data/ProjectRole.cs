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
    
    public partial class ProjectRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProjectRole()
        {
            this.ProjectPermissionMappers = new HashSet<ProjectPermissionMapper>();
        }
    
        public int ProjectRoleId { get; set; }
        public string ProjectRoleName { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectPermissionMapper> ProjectPermissionMappers { get; set; }
    }
}
