using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ProjectBaker.Identity
{
    public class UserStore 
        : IUserStore<AppUser>
        , IUserEmailStore<AppUser>
        , IUserPasswordStore<AppUser>
        , IUserLoginStore<AppUser>
    {
        public Task AddLoginAsync(AppUser user, UserLoginInfo login, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> CreateAsync(AppUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> DeleteAsync(AppUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> FindByLoginAsync(string loginProvider, string providerKey, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetEmailAsync(AppUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GetEmailConfirmedAsync(AppUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IList<UserLoginInfo>> GetLoginsAsync(AppUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetNormalizedEmailAsync(AppUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetNormalizedUserNameAsync(AppUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetPasswordHashAsync(AppUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserIdAsync(AppUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserNameAsync(AppUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> HasPasswordAsync(AppUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task RemoveLoginAsync(AppUser user, string loginProvider, string providerKey, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetEmailAsync(AppUser user, string email, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetEmailConfirmedAsync(AppUser user, bool confirmed, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetNormalizedEmailAsync(AppUser user, string normalizedEmail, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetNormalizedUserNameAsync(AppUser user, string normalizedName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetPasswordHashAsync(AppUser user, string passwordHash, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetUserNameAsync(AppUser user, string userName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(AppUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}