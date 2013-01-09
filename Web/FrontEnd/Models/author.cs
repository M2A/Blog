using System;
namespace Yara.Blog.Web.FrontEnd.MVC_EF_CodeFirst.Models
{
    public class author
    {
        public int authorID{ get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime enrollmentDate { get; set; }
    }
}