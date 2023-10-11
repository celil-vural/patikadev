using Entity.Contracts;
using Microsoft.EntityFrameworkCore;
using Repository.Concrete.Ef;
using Repository.Contracts;
using System.Linq.Expressions;

namespace Repository.Concrete
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class, IEntity, new()
    {
        protected readonly EfRepositoryContext _context;
        protected RepositoryBase(EfRepositoryContext context)
        {
            _context = context;
        }
        public virtual int Add(TEntity entity, bool trackChanges = false)
        {
            var entry = _context.Set<TEntity>().Add(entity);
            SaveChanges();
            return entry.Entity.Id;
        }

        public virtual void Delete(TEntity entity, bool trackChanges = false)
        {
            _context.Set<TEntity>().Remove(entity);
            SaveChanges();
        }

        public virtual TEntity? Get(Expression<Func<TEntity, bool>> filter, bool trackChanges = false)
        {
            return trackChanges
            ? _context.Set<TEntity>().Where(filter).SingleOrDefault()
            : _context.Set<TEntity>().AsNoTracking().Where(filter).SingleOrDefault();
        }


        public virtual IEnumerable<TEntity>? GetHashSet(bool trackChanges = false)
        {
            return trackChanges
                ? _context.Set<TEntity>().ToHashSet()
                : _context.Set<TEntity>().AsNoTracking().ToHashSet();
        }

        public virtual TEntity? GetWithId(int id, bool trackChanges = false)
        {
            return Get((r) => r.Id == id);
        }

        public virtual void SaveChanges()
        {
            _context.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            SaveChanges();
        }
    }
}
