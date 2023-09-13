using Entities.Concrete.Model;
using Repositoriy.Concrete.Ef;

namespace Repositories.Concrete.Books
{
    public class BookRepository : RepositoryBase<Book>
    {
        public BookRepository(EfRepositoryContext context) : base(context)
        {
        }
    }
}
