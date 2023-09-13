using Entities.Common;
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
        public HashSet<BooksViewModel> Handle()
        {
            var books = _context.Books.OrderBy(e => e.Id).ToHashSet();
            HashSet<BooksViewModel> vm = new HashSet<BooksViewModel>();
            foreach (var book in books)
            {
                vm.Add(new BooksViewModel()
                {
                    Title = book.Title,
                    PageCount = book.PageCount,
                    PublishDate = book.PublishDate.Date.ToString("dd/MM/yyyy"),
                    Genre = ((GenreEnum)book.GenreId).ToString()
                });
            }
            return vm;
        }
    }
    public class BooksViewModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
        public string Genre { get; set; }
    }
}