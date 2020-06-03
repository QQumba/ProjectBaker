using ProjectBaker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBaker.Domain.Repositories
{
	interface IUserRepository : IRepository<User>
	{
		User GetByEmail(string email);
	}
}
