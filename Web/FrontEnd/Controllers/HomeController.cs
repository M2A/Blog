using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Yara.Blog.Web.FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return RedirectToAction("List", "post");
            //ViewBag.Message = "Welcome to ASP.NET MVC!";

            //return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
