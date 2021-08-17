using Omdb.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Omdb.DAL.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> List();
        IQueryable<T> ListQueryable();
        List<T> List(Expression<Func<T, bool>> filter = null);// filter null
        int Insert(T entity);
        int Update(T entity);
        int Delete(T entity);
        T Find(Expression<Func<T, bool>> filter = null);
    }
}
