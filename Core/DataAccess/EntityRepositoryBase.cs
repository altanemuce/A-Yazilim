using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    public class EntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext
    {

        protected TContext Context { get; }
        public EntityRepositoryBase(TContext context)
        {
            Context = context;
        }
        public DbSet<TEntity> Table => Context.Set<TEntity>();
        public async Task<TEntity> Add(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Added;
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            await Context.SaveChangesAsync();
            return entity;
        }

        public IQueryable<TEntity> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return query;
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter, bool tracking = true)
        {
            var query = Table.Where(filter);
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return query;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
           Context.Entry(entity).State= EntityState.Modified;
            await Context.SaveChangesAsync();
            return entity;
        }
    }
}
