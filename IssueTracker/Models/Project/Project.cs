using IssueTrackerBase.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IssueTracker.Models.Project
{
    public class Project
    {
        public void CreateProject( String Projectkey,String ProjectName,int ProjectLead) {
            var Entity = new IssueTrackerEntities();
            using (var sa = new IssueTrackerEntities())
            {
               IssueTrackerBase.Data.Project  pro = new IssueTrackerBase.Data.Project();
                pro.ProjectKey = Projectkey;
                pro.ProjectName = ProjectName;
                pro.ProjectLeadUserId = ProjectLead;
                pro.CreatedBy = 1;
                pro.CreatedDate= DateTime.Now;
                pro.ModifiedBy = 1;
                pro.ModifiedDate= DateTime.Now;

                sa.Projects.Add(pro);
                sa.SaveChanges();
            }
}
      public List<ProjectDetails>GetProjectList() {

            var Entity = new IssueTrackerEntities();

            var ProjectDetailsData = from projects in Entity.Projects join Users in Entity.Users on projects.ProjectLeadUserId equals Users.UserId
                                     where  projects.IsActive == true && Users.IsActive == true 
                                     select new ProjectDetails
                                    {
                                        Projectkey = projects.ProjectKey,
                                        ProjectName = projects.ProjectName,
                                      ProjectLead = Users.DisplayName,
                                      //  ProjectComponents = components.PriorityName,
 
                                    };
            List<ProjectDetails> selectedCollection = ProjectDetailsData.ToList();
            return selectedCollection;
        }

        public List<Components> ComponentList()
        {
            var Entity = new IssueTrackerEntities();

            var ComponentsListData = from components in Entity.Components
                                     join projects in Entity.Projects on components.ProjectId equals projects.ProjectId
                                     join users in Entity.Users on components.LeadId equals users.UserId
                                     where projects.IsActive == true && users.IsActive == true && components.IsActive == true
                                     select new Components
                                     {
                                         ComponentName = components.ComponentName,
                                         ProjectName = projects.ProjectName,
                                         LeadName = users.DisplayName,

                                         modifyDate = components.ModifiedDate
                                     };


            List<Components> component = ComponentsListData.ToList();
            return component;
        }


    }

    public class Components
    {
        public String ComponentName { get; set; }
        public String ProjectName { get; set; }
        public String LeadName { get; set; }

        public DateTime modifyDate { get; set; }

    }

    public partial class  ProjectDetails {
        public String Projectkey { get; set; }
        public String ProjectName { get; set; }
        public String ProjectLead { get; set; }
        public String ProjectComponents { get; set; }
       
        public bool IsActive { get; set; }

 
    }
    public class projectform {
        public String Projectkey { get; set; }
        public String ProjectName { get; set; }
        public String ProjectLead { get; set; }
        public int ProjectLeadId { get; set; }
        public bool IsActive { get; set; }
        public int createdBy { get; set; }
        public int updatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    } 
}