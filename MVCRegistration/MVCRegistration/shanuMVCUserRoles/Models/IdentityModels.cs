﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MVCUserRoles.Controllers;

namespace MVCUserRoles.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(): base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Teachers> AddRemoveTeacher { get; set; }
        public DbSet<StudentProfile> StudentProfile { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

      

        //public System.Data.Entity.DbSet<MVCUserRoles.Models.Subject> Subjects { get; set; }
    }
}