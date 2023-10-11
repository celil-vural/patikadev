using Entity.Concrete.Dtos.Users;
using Entity.Concrete.Models;

namespace Services.Contracts.Users
{
    public interface IUserService : IBaseService<User, DtoUser>
    {
    }
}
