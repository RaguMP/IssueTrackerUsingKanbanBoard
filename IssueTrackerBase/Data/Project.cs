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
    
    public partial class Project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Project()
        {
            this.AgileBoardProjectMappers = new HashSet<AgileBoardProjectMapper>();
            this.Components = new HashSet<Component>();
            this.ProjectComponentMappers = new HashSet<ProjectComponentMapper>();
            this.ProjectCustomFieldMappers = new HashSet<ProjectCustomFieldMapper>();
            this.ProjectPermissionMappers = new HashSet<ProjectPermissionMapper>();
            this.ReleaseVersionProjectMappers = new HashSet<ReleaseVersionProjectMapper>();
        }
    
        public int ProjectId { get; set; }
        public string ProjectKey { get; set; }
        public string ProjectName { get; set; }
        public Nullable<int> ProjectLeadUserId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgileBoardProjectMapper> AgileBoardProjectMappers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Component> Components { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectComponentMapper> ProjectComponentMappers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectCustomFieldMapper> ProjectCustomFieldMappers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectPermissionMapper> ProjectPermissionMappers { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual User User2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReleaseVersionProjectMapper> ReleaseVersionProjectMappers { get; set; }
    }
}