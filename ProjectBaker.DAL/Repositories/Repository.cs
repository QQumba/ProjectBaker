using Microsoft.EntityFrameworkCore;
using ProjectBaker.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectBaker.DAL.Repositories
{
	internal class Repository<TEntity> : IRepository<TEntity> where TEntity : Domain.Entities.BaseEntity
	{
		private ProjectBakerDbContext _context;
		private DbSet<TEntity> _set;

		internal Repository(ProjectBakerDbContext context)
		{
			_context = context;
		}

		protected DbSet<TEntity> Set
		{
			get { return _set ?? (_set = _context.Set<TEntity>()); }
		}
		public void Add(TEntity entity)
		{
			Set.Add(entity);
		}

		public TEntity FindById(int id)
		{
			return Set.First(e => e.Id == id);
		}

		public List<TEntity> GetAll()
		{
			return Set.ToList();
		}

		public List<TEntity> PageAll(int skip, int take)
		{
			return Set.Skip(skip).Take(take).ToList();
		}

		public void Remove(TEntity entity)
		{
			Set.Remove(entity);
		}

		public void Update(TEntity entity)
		{
			var entry = _context.Entry(entity);
			if (entry.State == EntityState.Detached)
			{
				Set.Attach(entity);
				entry = _context.Entry(entity);
			}
			entry.State = EntityState.Modified;
		}
	}
}
