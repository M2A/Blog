using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

<<<<<<< HEAD
namespace MVC_EF_CodeFirst.Models
=======
namespace Yara.Blog.Web.FrontEnd.MVC_EF_CodeFirst.Models
>>>>>>> 0359986b98a1f3760886b0d44ce0437ea1f0e886
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