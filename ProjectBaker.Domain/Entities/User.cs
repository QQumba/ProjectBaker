using System.Collections.Generic;

namespace ProjectBaker.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string HashedPassword { get; set; }
        public string Email { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public uint Age { get; set; }
        public string County { get; set; }

        public IList<Role> Roles { get; set; }
    }
}