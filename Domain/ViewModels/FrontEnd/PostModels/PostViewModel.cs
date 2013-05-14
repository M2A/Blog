using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yara.Blog.Domain.ViewModels.FrontEnd.PostModels
{
    public class PostViewModel
    {
        public int postID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string authorName { get; set; }
        public DateTime Created { get; set; }
    }
}
