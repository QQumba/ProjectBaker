using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ProjectBaker.DAL.Configurations;
using ProjectBaker.Domain.Entities;

namespace ProjectBaker.DAL
{
    internal class ProjectBakerDbContext : DbContext
    {
        /// <summary>
        /// for testing
        /// </summary>
        static ProjectBakerDbContext()
        {
            System.Data.Entity.Database.SetInitializer(new ProjectBakersDbContextTestingInitializer());
        }

        internal IDbSet<Comment> Comments { get; set; }
        internal IDbSet<Job> Jobs { get; set; }
        internal IDbSet<Project> Projects { get; set; }
        internal IDbSet<ProjectAccount> ProjectAccounts { get; set; }
        internal IDbSet<ProjectParticipant> Participants { get; set; }
        internal IDbSet<Review> Reviews { get; set; }
        internal IDbSet<Role> Roles { get; set; }
        internal IDbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfigurations());
        }
    }
}