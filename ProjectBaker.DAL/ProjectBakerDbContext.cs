using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using ProjectBaker.Domain.Entities;

namespace ProjectBaker.DAL
{
    public class ProjectBakerDbContext : DbContext
    {
        static ProjectBakerDbContext()
        {
           
        }

        internal DbSet<Comment> Comments { get; set; }
        internal DbSet<Job> Jobs { get; set; }
        internal DbSet<Project> Projects { get; set; }
        internal DbSet<ProjectAccount> ProjectAccounts { get; set; }
        internal DbSet<ProjectParticipant> Participants { get; set; }
        internal DbSet<Review> Reviews { get; set; }
        internal DbSet<Role> Roles { get; set; }
        internal DbSet<User> Users { get; set; }
       
    }
}