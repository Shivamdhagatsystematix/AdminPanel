using System;
using System.ComponentModel.DataAnnotations;

namespace MVCUserRoles.Models
{
    public class AddRemoveTeachers
    {

        [Key]
        public int TeacherId { get; set; }

        public string TeacherName { get; set; }
        public String SubjectAssign { get; set; }

        public string City { get; set; }

        public String Address { get; set; }

        //Foreign key for Subject
        public int SubjectId { get; set; }



        //public virtual Subject Subject { get; set; }
    }
}
