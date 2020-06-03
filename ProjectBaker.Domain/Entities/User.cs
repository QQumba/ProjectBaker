using System.Collections.Generic;
using System.Security.Principal;

namespace ProjectBaker.Domain.Entities
{
    public class User : BaseEntity
    {
        public string HashedPassword { get; set; }
        public string Email { get; set; }
        public string ExternalLogin { get; set; }
        public bool HasEmailConfirmed { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public uint Age { get; set; }
        public string County { get; set; }

        public IList<Role> Roles { get; set; }
    }
}