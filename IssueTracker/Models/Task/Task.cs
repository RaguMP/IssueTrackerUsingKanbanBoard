using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IssueTrackerBase.Data;



namespace IssueTracker.Models.Task
{
    public class Task
    {
    public List<IssueListDetails> GetIssueList()
        {

            var TaskEntity = new IssueTrackerEntities();

            var IssueDetailsData = (from IssueDetails in TaskEntity.IssueDetails
                                    join components in TaskEntity.Components on IssueDetails.ComponentId equals components.ComponentId
                                    join priorities in TaskEntity.Priorities on IssueDetails.PriorityId equals priorities.PriorityId
                                    join IssueTypes in TaskEntity.IssueTypes on IssueDetails.IssueTypeId equals IssueTypes.IssueTypeId
                                    join Statuses in TaskEntity.Statuses on IssueDetails.StatusId equals Statuses.StatusId
                                    where IssueDetails.IsActive == true && components.IsActive == true && IssueTypes.IsActive == true && Statuses.IsActive == true && priorities.IsActive == 1
                                    select new IssueListDetails
                                    {
                                        TaskId = IssueDetails.IssueId,
                                        TaskIdName = IssueDetails.TaskId,
                                        Title = IssueDetails.Title,
                                        PriorityName = priorities.PriorityName,
                                        ProjectStatus = Statuses.StatusName,
                                        ComponentsName = components.ComponentName,
                                        DueDate = IssueDetails.DueDate.ToString()

                                        }).ToList();
            
            return IssueDetailsData;
        }
    }
    public class IssueListDetails {
        public int TaskId { get; set; }
        public String TaskIdName { get; set; }

        public String Title { get; set; }

        public string PriorityName { get; set;}
         
        public String ProjectStatus { get; set;}

        public String ComponentsName { get; set; }

        public String DueDate { get; set; }
        

    }
 
}