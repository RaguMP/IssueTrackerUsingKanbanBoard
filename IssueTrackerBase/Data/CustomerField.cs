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
    
    public partial class CustomerField
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerField()
        {
            this.CustomeFieldValueMappers = new HashSet<CustomeFieldValueMapper>();
            this.IssuesCustomFieldValueMappers = new HashSet<IssuesCustomFieldValueMapper>();
            this.ProjectCustomFieldMappers = new HashSet<ProjectCustomFieldMapper>();
        }
    
        public int CustomFieldId { get; set; }
        public string CustomerFieldName { get; set; }
        public int TypeId { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public int IsActive { get; set; }
    
        public virtual CustomeFieldType CustomeFieldType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomeFieldValueMapper> CustomeFieldValueMappers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssuesCustomFieldValueMapper> IssuesCustomFieldValueMappers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectCustomFieldMapper> ProjectCustomFieldMappers { get; set; }
    }
}
