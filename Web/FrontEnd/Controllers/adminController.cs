using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yara.Blog.Web.FrontEnd.MVC_EF_CodeFirst.Models;

namespace Yara.Blog.Web.FrontEnd.Controllers
{
    public class adminController : Controller
    {
        //
        // GET: /admin/
        MVC_EF_CF_DB _db;

        public adminController()
        {
            _db = new MVC_EF_CF_DB();
        }
        public ActionResult GetPostsList()
        {
            var posts = _db.posts.ToList();
            return View(posts);
        }

        //
        // GET: /admin/Details/5

        public ActionResult postDetails(int id)
        {
            return RedirectToAction("Details", "post", new { postID = id});
        }

        //
        // GET: /admin/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /admin/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /admin/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /admin/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /admin/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /admin/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
