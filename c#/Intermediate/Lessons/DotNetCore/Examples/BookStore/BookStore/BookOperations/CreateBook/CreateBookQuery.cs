using Entities;
using Repositoriy.Concrate.Ef;

namespace BookStore.BookOperations.CreateBook
{
    public class CreateBookQuery
    {
        private readonly EfRepositoryContext _context;
        public CreateBookQuery(EfRepositoryContext context)
        {

            _context = context;

        }
        public CreateBookModel Model { get; set; };
        public void Handle()
        {
            var book = _context.Books.FirstOrDefault(e => e.Title == Model.Title);
            if (book is not null)
            {
                throw new InvalidOperationException("Kitap zaten mevcut.");
            }
            book = new Book()
            {
                Title = Model.Title,
                GenreId = Model.GenreId,
                PageCount = Model.PageCount,
                PublishDate = Model.PublishDate.Date
            };
            _context.Books.Add(book);
            _context.SaveChanges();
        }
        public class CreateBookModel
        {
            public string Title { get; set; } = string.Empty;
            public int GenreId { get; set; }
            public int PageCount { get; set; }
            public DateTime PublishDate { get; set; }
        }
    }
}
