//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class post
    {
        public post()
        {
            this.comments = new HashSet<comment>();
        }
    
        public int postID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int authorID { get; set; }
        public string ImageUrl { get; set; }
        public System.DateTime Created { get; set; }
    
        public virtual author author { get; set; }
        public virtual ICollection<comment> comments { get; set; }
    }
}