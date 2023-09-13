using AutoMapper;
using Entities;
using Repositoriy.Concrate.Ef;

namespace BookStore.BookOperations.CreateBook
{
    public class CreateBookCommand
    {
        private readonly EfRepositoryContext _context;
        private readonly IMapper _mapper;
        public CreateBookCommand(EfRepositoryContext context, IMapper mapper)
        {

            _context = context;
            _mapper = mapper;
        }
        public CreateBookModel Model { get; set; }
        public void Handle()
        {
            var book = _context.Books.FirstOrDefault(e => e.Title == Model.Title);
            if (book is not null)
            {
                throw new InvalidOperationException("Kitap zaten mevcut.");
            }
            book = _mapper.Map<Book>(Model);
            _context.Books.Add(book);
            _context.SaveChanges();
        }
    }
    public class CreateBookModel
    {
        public string Title { get; set; } = string.Empty;
        public int GenreId { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
