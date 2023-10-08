using Entity.Concrete.Dtos.Author;
using Entity.Concrete.Models;

namespace Services.Contracts.Authors
{
    public interface IAuthorService : IBaseService<Author, DtoAuthor>
    {
    }
}
