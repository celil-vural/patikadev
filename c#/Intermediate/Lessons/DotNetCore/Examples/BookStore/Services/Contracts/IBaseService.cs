using Entities.Contracts;

namespace Services.Contracts
{
    public interface IBaseService<TEntity> where TEntity : class, IEntity, new()
    {
        int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion) where TDtoForInsertion : new();
        void Delete(int id);
        void GetNotFoundExceptions(TEntity? entity);
        TDtoForUpdate? GetEntity<TDtoForUpdate>(int id) where TDtoForUpdate : new();
        IEnumerable<TDto>? GetHashSet<TDto>();
        void Update<TDto>(TDto dto);
        TDto? GetWithId<TDto>(int id);
    }
}
