using AutoMapper;
using Entities.Contracts;
using Repositories.Contracts;
using Services.Contracts;

namespace Services.Concrete
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly IRepositoryBase<TEntity> _baseRepository;
        private readonly IMapper _mapper;
        protected BaseService(IRepositoryBase<TEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public virtual int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion) where TDtoForInsertion : new()
        {
            TEntity entity = _mapper.Map<TEntity>(dtoForInsertion);
            return _baseRepository.Add(entity);
        }
        public virtual void Delete(int id)
        {
            var entity = _baseRepository.GetWithId(id);
            GetNotFoundExceptions(entity);
            _baseRepository.Delete(entity!);
        }
        public virtual TDto? GetWithId<TDto>(int id)
        {
            var entity = _baseRepository.GetWithId(id);
            GetNotFoundExceptions(entity);
            var dto = _mapper.Map<TDto>(entity);
            return dto;
        }
        public virtual IEnumerable<TDto>? GetHashSet<TDto>()
        {
            var entities = _baseRepository.GetHashSet();
            var dto = _mapper.Map<IEnumerable<TDto>>(entities);
            return dto;
        }
        public void GetNotFoundExceptions(TEntity? entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity not found");
            }
        }

        public TDtoForUpdate? GetEntity<TDtoForUpdate>(int id) where TDtoForUpdate : new()
        {
            var entity = _baseRepository.GetWithId(id);
            var dto = _mapper.Map<TDtoForUpdate>(entity);
            return dto;
        }
        public virtual void Update<TDto>(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            GetNotFoundExceptions(entity);
            _baseRepository.Update(entity);
        }
    }
}
