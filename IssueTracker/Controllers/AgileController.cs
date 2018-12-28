using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IssueTracker.Controllers
{
    public class AgileController : Controller
    {
        [Authorize]
        [HttpGet]
        public ActionResult GetAllAgileBoardDetails()
        {
            var res = new IssueTrackerBase.Model.KanbanBoard().GetAllAgileBoards();
            ViewBag.AgileBoardListResult = res;
            return View("/Views/Agile/_agileBoardGrid.cshtml");
        }

        [Authorize]
        [HttpGet]
        public ActionResult GetAgileBoard(int id)
        {
            var res = new IssueTrackerBase.Model.KanbanBoard().GetTaskListForKanbanBoard(id);
            ViewBag.TaskListResult = res.TaskListResult;
            ViewBag.AgileBoardTile = res.AgileBoardName;
            ViewBag.AgileBoardId = res.AgileBoardId;
            ViewBag.SwimlaneBy = res.SwimlanesBy;
            return View("/Views/Agile/_agileBoard.cshtml");
        }

		[Authorize]
        [HttpGet]
        public ActionResult GetAgileBoardSettings(int id, string settingstype = "")
        {
            ViewBag.AgileBoardId = id;
            ViewBag.ConfigType = settingstype;
            return View("/Views/Agile/_agileBoardSettings.cshtml");
        }
    }
}