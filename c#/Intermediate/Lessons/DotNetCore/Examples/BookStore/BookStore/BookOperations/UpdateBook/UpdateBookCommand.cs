using AutoMapper;
using Repositoriy.Concrate.Ef;

namespace BookStore.BookOperations.UpdateBook
{
    public class UpdateBookCommand
    {
        private readonly EfRepositoryContext _context;
        public int BookId { get; set; }
        private readonly IMapper _mapper;
        public UpdateBookModel Model { get; set; }
        public UpdateBookCommand(EfRepositoryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Handle()
        {
            var book = _context.Books.FirstOrDefault(e => e.Id == BookId);
            if (book is null)
            {
                throw new InvalidOperationException("Güncellenecek kitap bulunamadı.");
            }
            book = _mapper.Map(Model, book);
            _context.SaveChanges();
        }
    }
    public class UpdateBookModel
    {
        public string Title { get; set; } = string.Empty;
        public int GenreId { get; set; }
    }
}
