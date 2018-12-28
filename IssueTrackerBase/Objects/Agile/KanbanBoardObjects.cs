using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackerBase.Objects
{
    public enum SwimlanesEnum
    {
        Assginee = 1,
        Engineer,
        IssueType,
        ProjectName,
        StoryPoint,
        None
    }

    public class KanbanBoardResult
    {
        public int AgileBoardId { get; set; }
        public string AgileBoardName { get; set; }

        public string SwimlanesBy { get; set; }
        public List<KanbanBoardObjects> TaskListResult { get; set; }
    }

    public class KanbanBoardObjects
    {
        public int IssueId { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string TaskId { get; set; }
        public string Title { get; set; }
        public string IssueType { get; set; }
        public string Status { get; set; }
        public string Assignee { get; set; }
        public string Engineer { get; set; }
        public string StoryPoint { get; set; }
        public decimal? StoryPointsInDecmial { get; set; }
    }

    public class AllAgileBoardListObjects
    {
        public int AgileBoardId { get; set; }
        public string AgileBoardName { get; set; }
        public string Admin { get; set; }
        public string ProjectName { get; set; }
    }
}
