using System;
using System.ComponentModel.DataAnnotations;

namespace MVCUserRoles.Models
{
    public class StudentProfile
    {
        

            [Key]
        public int StudentId { get; set; }

        public string StudentName { get; set; }
        public String SubjectAssign { get; set; }

        public string City { get; set; }

        public String Address { get; set; }
    }
}
    
