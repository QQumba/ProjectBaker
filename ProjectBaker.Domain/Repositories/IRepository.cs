using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBaker.Domain.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();

        List<TEntity> PageAll(int skip, int take);

        TEntity FindById(int id);

        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}