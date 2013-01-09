using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yara.Blog.Web.FrontEnd.MVC_EF_CodeFirst.Models;

namespace MvcIntro.Controllers
{
    public class commentController : Controller
    {
        MVC_EF_CF_DB _db;
        
        public commentController()
        {
            _db = new MVC_EF_CF_DB();
        }
        //
        // GET: /comment/

        public ActionResult List(long postId)
        {
            // "commentCtrl" is PartialView name
            return PartialView("commentCtrl", _db.comments.Where(c => c.postID == postId).ToList());
        }
        [HttpPost]
        public ActionResult add(int postId, comment newComment)
        {
            newComment.Created = DateTime.Now;
            newComment.postID = postId;
            //_db.comments.Add(new comment()
            //{
            //    postID = postId,
            //    Text = Request["text"],
            //    Title = Request["title"],
            //    Created = DateTime.Now
            //}
            //    );
                _db.comments.Add(newComment);
                _db.SaveChanges();
            
            return RedirectToAction("Details", "post", new { id = postId });
        }
        //
        // GET: /comment/Details/5

        public ActionResult Details(long id)
        {
            return View();
        }

        //
        // GET: /comment/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /comment/Create

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
        // GET: /comment/Edit/5

        [Authorize]
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /comment/Edit/5

        [HttpPost]
        [Authorize]
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
        // GET: /comment/Delete/5

        [Authorize]
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /comment/Delete/5

        [HttpPost]
        [Authorize]
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
