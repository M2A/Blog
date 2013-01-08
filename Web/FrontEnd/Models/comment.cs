using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Yara.Blog.Web.FrontEnd.MVC_EF_CodeFirst.Models
{
    public class comment : IValidatableObject
    {
        public int commentID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public int postID { get; set; }
        //public int authorID { get; set; }
        public virtual post post { get; set; }
        //public virtual author author { get; set; }

        public IEnumerable<ValidationResult> 
            Validate(ValidationContext validationContext)
        {
            var field = new[] { "Created" };
            if( Created > DateTime.Now)
            {
                yield return new ValidationResult("نمی تواند مربوط به اینده باشد!");
            }
            if (Created < DateTime.Now.AddYears(-1))
            {
                yield return new ValidationResult("نمی تواند خیلی گذشته باشد!");
            }
            if (String.IsNullOrEmpty(Text)) 
            {
                yield return new ValidationResult("این مقدار نمی تواند خالی باشد.", field);
            }
        }
    }
}