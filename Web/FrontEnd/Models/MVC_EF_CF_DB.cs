using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

<<<<<<< HEAD
namespace MVC_EF_CodeFirst.Models
=======
namespace Yara.Blog.Web.FrontEnd.MVC_EF_CodeFirst.Models
>>>>>>> 0359986b98a1f3760886b0d44ce0437ea1f0e886
{
    public class MVC_EF_CF_DB : DbContext
    {
        public DbSet<post> posts { get; set; }
        public DbSet<comment> comments { get; set; }
        public DbSet<author> authors { get; set; }
        public DbSet<contactUs> contacts { get; set; }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}