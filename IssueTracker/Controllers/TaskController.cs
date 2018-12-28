using System;
using System.Configuration;
using System.Web;
using System.Web.Mvc;
using IssueTracker.Models;
using IssueTracker.Models.Task;


using IssueTrackerBase.Data;

namespace IssueTracker.Controllers
{
    public class TaskController : Controller
    {
        [Authorize]
        public ActionResult TaskDetail(string taskId)
        {
            ViewBag.TaskId = taskId;
            var taskDetails = new TaskModel().GetTaskDetails(taskId);

            return View(taskDetails);
        }
        public ActionResult Index()
        {
            Task task = new Models.Task.Task();
            var IssueDetailsList = task.GetIssueList();
            ViewBag.AgileBoardListResult = IssueDetailsList;
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        //POST: IssueDetails/Create
        //To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IssueId,TaskId,Title,ComponentId,IssueTypeId,PriorityId,Description,StatusId,EngineerId,AssigneeId,ReportingPersionId,ReleaseVerionId,StoryPoints,DueDate,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate,ResolutionId,ClosedDate,IsActive")] Models.IssueDetail issueDetail)
        {
            if (ModelState.IsValid)
            {
                //db.IssueDetails.Add(issueDetail);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(issueDetail);
        }

        
    }
}