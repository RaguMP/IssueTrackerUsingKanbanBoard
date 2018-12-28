﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IssueTrackerEntities : DbContext
    {
        public IssueTrackerEntities()
            : base("name=IssueTrackerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AgileBoard> AgileBoards { get; set; }
        public virtual DbSet<AgileBoardAdminMapper> AgileBoardAdminMappers { get; set; }
        public virtual DbSet<AgileBoardProjectMapper> AgileBoardProjectMappers { get; set; }
        public virtual DbSet<Component> Components { get; set; }
        public virtual DbSet<CustomeFieldType> CustomeFieldTypes { get; set; }
        public virtual DbSet<CustomeFieldValueMapper> CustomeFieldValueMappers { get; set; }
        public virtual DbSet<CustomerField> CustomerFields { get; set; }
        public virtual DbSet<EpicIssueMapper> EpicIssueMappers { get; set; }
        public virtual DbSet<IssueDetail> IssueDetails { get; set; }
        public virtual DbSet<IssuesCustomFieldValueMapper> IssuesCustomFieldValueMappers { get; set; }
        public virtual DbSet<IssueType> IssueTypes { get; set; }
        public virtual DbSet<Priority> Priorities { get; set; }
        public virtual DbSet<ProjectComponentMapper> ProjectComponentMappers { get; set; }
        public virtual DbSet<ProjectCustomFieldMapper> ProjectCustomFieldMappers { get; set; }
        public virtual DbSet<ProjectPermissionMapper> ProjectPermissionMappers { get; set; }
        public virtual DbSet<ProjectRole> ProjectRoles { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ReleaseVersion> ReleaseVersions { get; set; }
        public virtual DbSet<ReleaseVersionProjectMapper> ReleaseVersionProjectMappers { get; set; }
        public virtual DbSet<Resolution> Resolutions { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Workflow> Workflows { get; set; }
        public virtual DbSet<WorkFlowStatu> WorkFlowStatus { get; set; }
        public virtual DbSet<WorkFlowTransaction> WorkFlowTransactions { get; set; }
    }
}
