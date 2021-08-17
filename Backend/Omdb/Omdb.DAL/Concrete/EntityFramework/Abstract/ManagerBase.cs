using Omdb.DAL.Abstract;
using Omdb.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Omdb.DAL.Concrete.EntityFramework.Abstract
{
    public abstract class ManagerBase<T> : IEntityRepository<T> where T : class, IEntity, new()
    {
        private EfEntityRepositoryBase<T, OmdbContext> repositoryBase = new EfEntityRepositoryBase<T, OmdbContext>();

        public int Delete(T entity)
        {
            return repositoryBase.Delete(entity);
        }

        public T Find(Expression<Func<T, bool>> filter = null)
        {
            return repositoryBase.Find(filter);
        }

        public int Insert(T entity)
        {
            return repositoryBase.Insert(entity);
        }

        public List<T> List()
        {
            return repositoryBase.List();
        }

        public List<T> List(Expression<Func<T, bool>> filter = null)
        {
            return repositoryBase.List(filter);
        }

        public IQueryable<T> ListQueryable()
        {
            return repositoryBase.ListQueryable();
        }

        public int Update(T entity)
        {
            return repositoryBase.Update(entity);
        }

    }
}
