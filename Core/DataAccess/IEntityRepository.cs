using Core.Entities.Abstract;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T> GetAll(Expression<Func<T, bool>> filter, bool tracking = true);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
    }
}
