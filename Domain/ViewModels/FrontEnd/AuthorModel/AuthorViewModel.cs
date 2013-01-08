using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yara.Blog.Domain.ViewModels.FrontEnd.AuthorModel
{
    public class AuthorViewModel
    {
        public int authorID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime enrollmentDate { get; set; }
    }
}
