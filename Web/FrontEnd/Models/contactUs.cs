using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_EF_CodeFirst.Models
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