using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCUserRoles.Models
{
    public class join
    {
        [Key]
        public int Id { get; set; }

        public int SubjectId { get; set; }
        public int TeacherId { get; set; }

        //Foreign key for join table 

        public virtual Subject Subjects { get; set; }
        public virtual Teachers AddRemoveTeachers { get; set; }

    }
}