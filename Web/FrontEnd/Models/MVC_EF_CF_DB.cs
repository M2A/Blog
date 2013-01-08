using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Yara.Blog.Web.FrontEnd.MVC_EF_CodeFirst.Models
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