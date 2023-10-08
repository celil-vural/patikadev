using Entity.Contracts;

namespace Services.Contracts
{
    public interface IBaseService<TEntity, TDto> where TEntity : class, IEntity, new() where TDto : new()
    {
        int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion) where TDtoForInsertion : new();
        void Delete(int id);
        void GetNotFoundExceptions(TEntity? entity);
        TDtoForUpdate? GetEntity<TDtoForUpdate>(int id) where TDtoForUpdate : new();
        IEnumerable<TDto>? GetHashSet();
        TDtoForUpdate Update<TDtoForUpdate>(TDtoForUpdate dto);
        TDto? GetWithId(int id);
    }
}
