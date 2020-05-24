using System.Data.Entity;

namespace ProjectBaker.DAL
{
    internal class ProjectBakersDbContextTestingInitializer : DropCreateDatabaseAlways<ProjectBakerDbContext>
    {
        protected override void Seed(ProjectBakerDbContext context)
        {
            //place for logging
        }
    }
}