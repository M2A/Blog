using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yara.Blog.Web.FrontEnd.MVC_EF_CodeFirst.Models;

namespace Yara.Blog.Web.FrontEnd.Controllers
{
    public class postController : Controller
    {
        MVC_EF_CF_DB _db = new MVC_EF_CF_DB();
        //
        // GET: /post/
        public ActionResult List()
        {
            List<post> model = _db.posts.ToList();
            return View(model);
        }
        //
        // GET: /post/Details/5
        //public ActionResult post(int) 
        //{
            
        //}
        public ActionResult Details(int id)
        {
            var post = _db.posts.First(p=> p.postID == id);
            return View(post);
        }
        //
        // GET: /post/Create
        [HttpGet]
        public ActionResult Create()
        {
            var post = new post();
            return View(post);
        } 
        //
        // POST: /post/Create
        [HttpPost]
        [Authorize]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                _db.posts.Add(new post()
                {
                    Title = Request["title"],
                    Created = DateTime.Now,
                    authorID = Convert.ToInt32(Request["authorID"]),
                    Text = Request["text"],
                    ImageUrl = ""
                });
                _db.SaveChanges();
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }
        //
        // GET: /post/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            return View();
        }
        //
        // POST: /post/Edit/5
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
        // GET: /post/Delete/5
        [Authorize]
        public ActionResult Delete(int id)
        {
            return View();
        }
        //
        // POST: /post/Delete/5
        [HttpPost]
        [Authorize]
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
