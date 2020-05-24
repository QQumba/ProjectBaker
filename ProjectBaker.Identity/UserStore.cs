using System;
using Microsoft.AspNetCore.Identity;

namespace ProjectBaker.Identity
{
    public class UserStore : 
        IUserStore<ApplicationUser>,
        IRoleStore<IdentityRole>
    {
    }
}