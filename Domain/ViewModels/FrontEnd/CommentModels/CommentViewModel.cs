using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yara.Blog.Domain.ViewModels.FrontEnd.CommentModels
{
    public class CommentViewModel
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public int postID { get; set; }
    }
}
