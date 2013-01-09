using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yara.Blog.Web.FrontEnd.MVC_EF_CodeFirst.Models;

namespace Yara.Blog.Web.FrontEnd.Controllers
{
    public class authorController : Controller
    {
        MVC_EF_CF_DB _db; 

        public authorController()
        {
            _db = new MVC_EF_CF_DB();
        }
        //
        // GET: /author/

        public ActionResult List()
        {
            var authors = _db.authors;
            return View(authors);
        }

        //
        // GET: /author/Details/5

        public ActionResult Details(int id)
        {
            author Author =_db.authors.First(a => a.authorID == id);
            return View(Author);
        }

        //
        // GET: /author/Create

        public ActionResult Create()
        {
            author Author = new author();
            return View(Author);
        } 

        //
        // POST: /author/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /author/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /author/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /author/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /author/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }
    }
}
