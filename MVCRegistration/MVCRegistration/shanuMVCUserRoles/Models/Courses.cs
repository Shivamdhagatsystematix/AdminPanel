using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace MVCUserRoles.Models
{
    public class Courses
    {
        [Key]
        public int CourseId { get; set; }


       [Required]
        public string CourseName { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}