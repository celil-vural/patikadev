using Entity.Concrete.Models;
using Repository.Concrete.Ef;
using Repository.Contracts.Users;

namespace Repository.Concrete.Users
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(EfRepositoryContext context) : base(context)
        {
        }
    }
}
