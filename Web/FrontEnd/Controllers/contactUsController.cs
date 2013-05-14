using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yara.Blog.Web.FrontEnd.MVC_EF_CodeFirst.Models;

namespace Yara.Blog.Web.FrontEnd.Controllers
{
    public class contactUsController : Controller
    {
        //
        // GET: /contactUs/
        MVC_EF_CF_DB _db ;
        public contactUsController()
        {
            _db = new MVC_EF_CF_DB();
        }

        public ActionResult List() 
        {
            return PartialView("contactList", _db.contacts.ToList());
        }
        //
        // GET: /contactUs/Create
        [HttpGet]
        public ActionResult Create()
        {
            contactUs cu = new contactUs();
            return View(cu);
        } 

        //
        // POST: /contactUs/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                contactUs cu = new contactUs()
                {
                    //authorID = Convert.ToInt32(Request["authorID"]),
                    comment = Request["comment"],
                    email = Request["email"],
                    name = Request["name"],
                    reason = Request["reason"]
                };
                _db.contacts.Add(cu);
                _db.SaveChanges();

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }
        
        
    }
}
