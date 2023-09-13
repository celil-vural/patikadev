using Entities.Common;
using Repositoriy.Concrate.Ef;

namespace BookStore.BookOperations.GetBookDetail
{
    public class GetBookDetailQuery
    {
        private readonly EfRepositoryContext _context;
        public int BookId { get; set; }
        public GetBookDetailQuery(EfRepositoryContext context)
        {
            _context = context;
        }
        public BookDetailViewModel Handle()
        {
            var book = _context.Books.FirstOrDefault(e => e.Id == BookId);
            if (book is null)
            {
                throw new InvalidOperationException("Kitap bulunamadı.");
            }
            BookDetailViewModel vm;
            vm = new BookDetailViewModel()
            {
                Title = book.Title,
                Genre = ((GenreEnum)book.GenreId).ToString(),
                PageCount = book.PageCount,
                PublishDate = book.PublishDate.Date.ToString("dd/MM/yyyy")
            };
            return vm;
        }
    }
    public class BookDetailViewModel
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
    }
}
