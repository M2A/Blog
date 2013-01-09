using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

<<<<<<< HEAD
namespace MvcApplication1.Controllers
=======
namespace Yara.Blog.Web.FrontEnd.Controllers
>>>>>>> 0359986b98a1f3760886b0d44ce0437ea1f0e886
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
