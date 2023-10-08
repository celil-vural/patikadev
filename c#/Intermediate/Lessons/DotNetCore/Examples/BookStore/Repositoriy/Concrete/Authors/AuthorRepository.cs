using Entity.Concrete.Models;
using Repository.Concrete.Ef;
using Repository.Contracts.Authors;

namespace Repository.Concrete.Authors
{
    public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
    {
        public AuthorRepository(EfRepositoryContext context) : base(context)
        { }
    }
}
