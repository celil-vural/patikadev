using Entity.Concrete.Models;
using Repository.Concrete.Ef;
using Repository.Contracts.Books;

namespace Repository.Concrete.Books
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(EfRepositoryContext context) : base(context)
        {
        }
    }
}
