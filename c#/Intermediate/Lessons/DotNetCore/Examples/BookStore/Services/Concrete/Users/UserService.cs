using AutoMapper;
using Entity.Concrete.Dtos.Users;
using Entity.Concrete.Models;
using Repository.Contracts.Users;
using Services.Contracts.Users;

namespace Services.Concrete.Users
{
    public class UserService : BaseService<User, DtoUser>, IUserService
    {
        private readonly IUserRepository repository;
        public UserService(IUserRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            repository = baseRepository;
        }

        public override int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion)
        {
            var dto = dtoForInsertion as DtoForCreateUser;
            var user = repository.Get(u => u.Email.Equals(dto.Email));
            if (user != null)
            {
                throw new InvalidOperationException("Bu mail de bir user zaten mevcut.");
            }
            return base.CreateWithDto(dtoForInsertion);
        }
    }
}
