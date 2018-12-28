using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTrackerBase.Data;
using IssueTrackerBase.Objects;
using IssueTrackerBase.Utils;

namespace IssueTrackerBase.Model
{
    public class KanbanBoard
    {
        public List<AllAgileBoardListObjects> GetAllAgileBoards()
        {
            var result = new List<AllAgileBoardListObjects>();
            try
            {
                using (var context = new IssueTrackerEntities())
                {
                    result = (from agile in context.AgileBoards.Where(i => i.IsActive)
                              from agileProject in context.AgileBoardProjectMappers.Where(i => i.IsActive && i.AgileBoardId == agile.AgileBoardId)
                              from project in context.Projects.Where(i => i.IsActive && i.ProjectId == agileProject.ProjectId)
                              from admin in context.AgileBoardAdminMappers.Where(i => i.AgileBoardId == agile.AgileBoardId)
                              from adminUserName in context.Users.Where(i => i.IsActive && i.UserId == admin.AdminUserId)
                              select new AllAgileBoardListObjects()
                              {
                                  AgileBoardId = agile.AgileBoardId,
                                  AgileBoardName = agile.AgileBoardName,
                                  Admin = adminUserName.DisplayName,
                                  ProjectName = project.ProjectName
                              }).OrderBy(j => j.AgileBoardName).ToList();
                }
            }
            catch (Exception ex)
            { }

            return result;
        }

        public KanbanBoardResult GetTaskListForKanbanBoard(int agileBoardId)
        {
            var result = new KanbanBoardResult();
            result.TaskListResult = new List<KanbanBoardObjects>();
            try
            {
                using (var context = new IssueTrackerEntities())
                {
                    var res = (from agile in context.AgileBoards.Where(i => i.IsActive && i.AgileBoardId == agileBoardId) select agile).FirstOrDefault();
                    if (res != null)
                    {
                        result.AgileBoardId = res.AgileBoardId;
                        result.AgileBoardName = res.AgileBoardName;
                        result.SwimlanesBy = (res.SwimlanesBy != null) ? GetSwimlaneName((int)res.SwimlanesBy) : "None";
                    }

                    result.TaskListResult = (from task in context.IssueDetails.Where(i => i.IsActive)
                                             from issueType in context.IssueTypes.Where(i => i.IsActive && i.IssueTypeId == task.IssueTypeId)
                                             from status in context.Statuses.Where(i => i.IsActive && i.StatusId == task.StatusId)
                                             from assginee in context.Users.Where(i => i.UserId == task.AssigneeId)
                                             select new KanbanBoardObjects()
                                             {
                                                 IssueId = task.IssueId,
                                                 TaskId = task.TaskId,
                                                 Title = task.Title,
                                                 StoryPointsInDecmial = task.StoryPoints,
                                                 IssueType = issueType.IssueTypeName,
                                                 Status = status.StatusName,
                                                 Assignee = assginee.DisplayName
                                             }).ToList();


                    if (result.TaskListResult != null && result.TaskListResult.Count > 0)
                    {
                        result.TaskListResult.ForEach(i => i.StoryPoint = (i.StoryPointsInDecmial != null) ? Helper.GetStoryPointInString(i.StoryPointsInDecmial.Value) : null);
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return result;
        }

        public string GetSwimlaneName(int id)
        {
            if (id == (int)SwimlanesEnum.Assginee)
                return SwimlanesEnum.Assginee.ToString();
            else if (id == (int)SwimlanesEnum.Engineer)
                return SwimlanesEnum.Engineer.ToString();
            else if (id == (int)SwimlanesEnum.IssueType)
                return SwimlanesEnum.IssueType.ToString();
            else if (id == (int)SwimlanesEnum.None)
                return SwimlanesEnum.None.ToString();
            else if (id == (int)SwimlanesEnum.ProjectName)
                return SwimlanesEnum.ProjectName.ToString();
            else if (id == (int)SwimlanesEnum.StoryPoint)
                return SwimlanesEnum.StoryPoint.ToString();
            else
                return SwimlanesEnum.None.ToString();
        }
    }
}
