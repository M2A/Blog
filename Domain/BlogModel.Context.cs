﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yara.Blog.Domain
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BlogDBEntities : DbContext
    {
        public BlogDBEntities()
            : base("name=BlogDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<author> authors { get; set; }
        public DbSet<comment> comments { get; set; }
        public DbSet<contactU> contactUs { get; set; }
        public DbSet<post> posts { get; set; }
    }
}
