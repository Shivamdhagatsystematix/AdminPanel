using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCUserRoles.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }

        [Required]

        public  string SubjectName { get; set; }

        //Foreign key for Course
        public int CourseId { get; set; }
        public virtual Courses Courses { get; set; }

        //public virtual ICollection<AddRemoveTeachers> AddRemoveTeachers { get; set; }
    }
}