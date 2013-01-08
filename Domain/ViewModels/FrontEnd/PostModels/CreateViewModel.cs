using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yara.Blog.Domain.ViewModels.FrontEnd.PostModels
{
    public class CreateViewModel
    {
        [Display(Name = "Post Title")]
        public string Title { get; set; }
        [Display(Name = "Post Content")]
        public string Text { get; set; }
    }
}
