using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yara.Blog.Domain.ViewModels.FrontEnd.CommentModels
{
    public class ListViewModel
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public int postID { get; set; }
        public List<CommentViewModel> comments { get; set; }
    }
}
