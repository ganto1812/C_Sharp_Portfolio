using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects
        public ActionResult Page(string file)
        {
            ViewBag.Title = file;
            return View(file);
        }
    }
}