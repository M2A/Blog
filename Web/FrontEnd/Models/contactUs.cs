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
    public class contactUs
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string reason { get; set; }
        public string comment { get; set; }
        public int authorID { get; set; }
        public virtual author author { get; set; }
    }
}