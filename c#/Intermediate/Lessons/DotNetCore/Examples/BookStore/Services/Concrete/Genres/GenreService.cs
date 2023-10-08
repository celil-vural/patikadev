using AutoMapper;
using Entity.Concrete.Dtos.Genre;
using Entity.Concrete.Models;
using Repository.Contracts.Genres;
using Services.Contracts.Genres;

namespace Services.Concrete.Genres
{
    public class GenreService : BaseService<Genre, GenreDto>, IGenreService
    {
        public GenreService(IGenreRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }
    }
}
