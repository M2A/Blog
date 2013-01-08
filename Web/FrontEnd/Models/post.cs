using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yara.Blog.Web.FrontEnd.MVC_EF_CodeFirst.Models
{
    public class post
    {
        public int postID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int authorID { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Created { get; set; }
        public virtual author author { get; set; }
    }
}