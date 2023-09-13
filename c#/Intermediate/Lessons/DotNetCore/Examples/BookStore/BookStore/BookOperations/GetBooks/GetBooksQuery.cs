using AutoMapper;
using Repositoriy.Concrate.Ef;

namespace BookStore.BookOperations.GetBooks
{
    public class GetBooksQuery
    {
        private readonly EfRepositoryContext _context;
        private readonly IMapper _mapper;
        public GetBooksQuery(EfRepositoryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public HashSet<BooksViewModel> Handle()
        {
            var books = _context.Books.OrderBy(e => e.Id).ToHashSet();
            HashSet<BooksViewModel> vm = _mapper.Map<HashSet<BooksViewModel>>(books);
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