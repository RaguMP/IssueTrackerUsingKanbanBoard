using IssueTracker.Models.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IssueTracker.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        [Authorize]
        public ActionResult ProjectList()
        {
            Project project = new Models.Project.Project();
            ViewBag.AgileBoardListResult = project.GetProjectList();
            return View();
        }


        [HttpPost]
        public ActionResult Create([Bind(Include = "Projectkey,ProjectLeadId,ProjectName")]projectform projectForm) {
            Project project = new Project();
            String Projectkey = projectForm.Projectkey;
            int ProjectLead = projectForm.ProjectLeadId;
            String ProjectName = projectForm.ProjectName;
            project.CreateProject(Projectkey, ProjectName, ProjectLead);

            return RedirectToAction("ProjectList");
        }

        [Authorize]
        public ActionResult Component()
        {
            Project project = new Models.Project.Project();
            ViewBag.AgileBoardListResult = project.ComponentList();
            return View();
        }


        //public JsonResult ProjectDetails()//[Bind(Prefix = "$OrderId")]int IssueId
        //{
        //    Project project = new Models.Project.Project();

        //    List<ProjectDetails> ProjectDetailsList = new List<ProjectDetails>();
        //    ProjectDetailsList = project.GetProjectList();
        //    return this.Json(new { result = ProjectDetailsList, count = ProjectDetailsList.Count }, JsonRequestBehavior.AllowGet);
        //}
    }
}