using Entity.Contracts;
using System.Linq.Expressions;

namespace Repository.Contracts
{
    public interface IRepositoryBase<TEntity> where TEntity : class, IEntity, new()
    {
        IEnumerable<TEntity>? GetHashSet(bool trackChanges = false);
        TEntity? Get(Expression<Func<TEntity, bool>> filter, bool trackChanges = false);
        TEntity? GetWithId(int id, bool trackChanges = false);
        int Add(TEntity entity, bool trackChanges = false);
        void Update(TEntity entity);
        void Delete(TEntity entity, bool trackChanges = false);
        void SaveChanges();
    }
}
