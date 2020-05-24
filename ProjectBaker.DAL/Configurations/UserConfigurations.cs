using System.Data.Entity.ModelConfiguration;
using ProjectBaker.Domain.Entities;

namespace ProjectBaker.DAL.Configurations
{
    internal class UserConfigurations : EntityTypeConfiguration<User>
    {
        internal UserConfigurations()
        {
            ToTable("User");
        }
    }
}