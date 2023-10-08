using Entity.Concrete.Dtos.Books;
using Entity.Concrete.Models;

namespace Services.Contracts.Books
{
    public interface IBookService : IBaseService<Book, BookDto>
    {
    }
}
