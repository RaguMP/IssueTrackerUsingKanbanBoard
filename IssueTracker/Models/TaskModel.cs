using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IssueTrackerBase.Data;
using System.Web.Mvc;

namespace IssueTracker.Models
{
    public class TaskModel
    {
        public TaskDetails GetTaskDetails(string TaskId)
        {
            TaskDetails task = new TaskDetails();

            using (var taskEntities = new IssueTrackerEntities())
            {
                task = (from details in taskEntities.IssueDetails
                        where details.TaskId == TaskId && details.IsActive
                        join component in taskEntities.Components on details.ComponentId equals component.ComponentId
                        where component.IsActive
                        join issueType in taskEntities.IssueTypes on details.IssueTypeId equals issueType.IssueTypeId
                        where issueType.IsActive
                        join priotity in taskEntities.Priorities on details.PriorityId equals priotity.PriorityId
                        where priotity.IsActive == 1
                        join status in taskEntities.Statuses on details.StatusId equals status.StatusId
                        where status.IsActive
                        join engineer in taskEntities.Users on details.EngineerId equals engineer.UserId
                        where engineer.IsActive
                        join reporter in taskEntities.Users on details.ReportingPersionId equals reporter.UserId
                        where reporter.IsActive
                        join assignee in taskEntities.Users on details.AssigneeId equals assignee.UserId
                        where assignee.IsActive
                        join version in taskEntities.ReleaseVersions on details.ReleaseVerionId equals version.ReleaseVersionId
                        select new TaskDetails()
                        {
                            IssueID = details.IssueId,
                            TaskId = details.TaskId,
                            Title = details.Title,
                            ComponentId = details.ComponentId,
                            ComponentName = component.ComponentName,
                            IssueTypeId = details.IssueTypeId,
                            IssueTypeName= issueType.IssueTypeName,
                            PriorityId = details.PriorityId,
                            PriorityName = priotity.PriorityName,
                            Description = details.Description,
                            StatusId = details.StatusId,
                            StatusName = status.StatusName,
                            EngineerId = details.EngineerId,
                            EngineerName = engineer.DisplayName,
                            ReporterId = details.ReportingPersionId,
                            ReporterName = reporter.DisplayName,
                            AssigneeId = details.AssigneeId,
                            AssigneeName = assignee.DisplayName,
                            //ReleaseVersionId = (int)details.ReleaseVerionId,
                            ReleaseVersionName = version.VersionName,
                            //StoryPoints = (int)details.StoryPoints,
                            DueDate = (DateTime)details.DueDate,
                            CreatedDate = (DateTime)details.CreatedDate,
                            ModifiedDate = (DateTime)details.ModifiedDate
                        }).FirstOrDefault();
            }

            return task;
        }

        /// <summary>
        /// Gets the key name list
        /// </summary>
        /// <returns>Return key type list</returns>
        public static SelectList GetAdminList()
        {
            var keyTypes = new TaskModel().GetAdmin();
            return keyTypes;
        }

        public SelectList GetAdmin()
        {
            using (var context = new IssueTrackerEntities())
            {
                var adminList = (from users in context.Users
                                   where users.IsActive && users.RoleId == 1
                                   select users).ToDictionary(a => a.UserId, b => b.DisplayName);

                adminList.OrderBy(k => k.Value);

                return new SelectList(adminList, "Key", "Value");
            }
        }

        /// <summary>
        /// Gets the key name list
        /// </summary>
        /// <returns>Return key type list</returns>
        public static SelectList GetProjectList()
        {
            var keyTypes = new TaskModel().GetProject();
            return keyTypes;
        }

        public SelectList GetProject()
        {
            using (var context = new IssueTrackerEntities())
            {
                var proectList = (from project in context.Projects
                                 where project.IsActive
                                 select project).ToDictionary(a => a.ProjectId, b => b.ProjectName);

                proectList.OrderBy(k => k.Value);

                return new SelectList(proectList, "Key", "Value");
            }
        }

    }


    public class TaskDetails
    {
        public int IssueID { get; set; }

        public string TaskId { get; set; }

        public string Title { get; set; }

        public int ComponentId { get; set; }

        public string ComponentName { get; set; }

        public int IssueTypeId { get; set; }

        public string IssueTypeName { get; set; }

        public int PriorityId { get; set; }

        public string PriorityName { get; set; }

        public string Description { get; set; }

        public int StatusId { get; set; }

        public string StatusName { get; set; }

        public int EngineerId { get; set; }

        public string EngineerName { get; set; }

        public int AssigneeId { get; set; }

        public string AssigneeName { get; set; }

        public int ReporterId { get; set; }

        public string ReporterName { get; set; }

        public int ReleaseVersionId { get; set; }

        public string ReleaseVersionName { get; set; }

        public int StoryPoints { get; set; }

        public DateTime DueDate { get; set; }

        public int CreatedById { get; set; }

        public string CreatedByName { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

    }

    public class UserModel
    {
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}