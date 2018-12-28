using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IssueTracker.Models
{


    public partial class IssueDetail
    {
        public int IssueId { get; set; }
        public string TaskId { get; set; }
        public string Title { get; set; }
        public int ComponentId { get; set; }
        public int IssueTypeId { get; set; }
        public int PriorityId { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public int EngineerId { get; set; }
        public int AssigneeId { get; set; }
        public int ReportingPersionId { get; set; }
        public Nullable<int> ReleaseVerionId { get; set; }
        public Nullable<decimal> StoryPoints { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<int> ResolutionId { get; set; }
        public Nullable<System.DateTime> ClosedDate { get; set; }
        public bool IsActive { get; set; }
    }
}