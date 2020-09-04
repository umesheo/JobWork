using JobWork.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobWork.Controllers
{
    public class ListTaskController : Controller
    {
        // GET: ListTask
        private dbContext dbCon = new dbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult assignTask(string TaskName)
        {

            ViewBag.TaskName = dbCon.AssignTasks.ToList();
            if (String.IsNullOrEmpty(TaskName))
            {

                return View();
            }
            var Task = dbCon.AssignTasks
               .OrderBy(x => x.TaskName).Where(x => x.TaskName == TaskName).ToList();
            return View(Task);
        }
    }
}