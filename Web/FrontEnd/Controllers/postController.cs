using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yara.Blog.Data;
using Yara.Blog.Domain;
using Yara.Blog.Domain.ViewModels.FrontEnd.PostModels;

namespace Yara.Blog.Web.FrontEnd.Controllers
{
    public class postController : Controller
    {
        private Repository<post> _postRepository;

        public postController()
        {
            _postRepository = new Repository<post>(new BlogDBEntities());
        }

        //
        // GET: /post/
        public ActionResult List()
        {
            var objPosts = _postRepository.GetAll();
            List<PostViewModel> posts = new List<PostViewModel>();
            foreach (var item in objPosts)
            {
                PostViewModel post = new PostViewModel();
                post.postID = item.postID;
                post.Title = item.Title;
                post.Text = item.Text;
                post.authorName = item.author.lastName;
                post.Created = item.Created;
                posts.Add(post);
            }
            return View(posts);
        }
        //
        // GET: /post/Details/5
        //public ActionResult post(int) 
        //{

        //}
        public ActionResult Details(int id)
        {
            post myPost = _postRepository.Get(p => p.postID == id);
            PostViewModel postView = new PostViewModel()
            {
                authorName = myPost.author.lastName,
                Created =myPost.Created,
                postID = myPost.postID,
                Text = myPost.Text,
                Title = myPost.Title
            };
            return View(postView);
        }
        //
        // GET: /post/Create
        [HttpGet]
        public ActionResult Create()
        {
            var post = new CreateViewModel();
            return View(post);
        }
        //
        // POST: /post/Create
        [HttpPost]
        public ActionResult Create(CreateViewModel post)
        {
            try
            {
                post myPost = new post()
                {
                    Title = post.Title,
                    Text = post.Text,
                    authorID = 1,
                    Created = DateTime.Now,
                };
                _postRepository.Add(myPost);
                _postRepository.Save();
                return RedirectToAction("List");
            }
            catch(Exception ex)
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
