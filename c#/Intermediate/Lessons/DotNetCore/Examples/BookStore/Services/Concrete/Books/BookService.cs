using AutoMapper;
using Entities.Concrete.Model;
using Repositories.Contracts.Books;

namespace Services.Concrete.Books
{
    public class BookService : BaseService<Book>
    {
        private readonly IBookRepository _baseRepository;
        public BookService(IBookRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        { }
    }
}
