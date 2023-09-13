using Repositoriy.Concrate.Ef;

namespace BookStore.BookOperations.GetBooks
{
    public class GetBooksQuery
    {
        private readonly EfRepositoryContext _context;
        public GetBooksQuery(EfRepositoryContext context)
        {
            _context = context;
        }
    }
}