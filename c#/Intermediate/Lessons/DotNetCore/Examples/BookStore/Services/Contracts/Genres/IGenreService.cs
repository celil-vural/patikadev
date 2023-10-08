using Entity.Concrete.Dtos.Genre;
using Entity.Concrete.Models;

namespace Services.Contracts.Genres
{
    public interface IGenreService : IBaseService<Genre, GenreDto>
    {
    }
}
