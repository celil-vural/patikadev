using AutoMapper;
using Entity.Concrete.Dtos.Author;
using Entity.Concrete.Dtos.Books;
using Entity.Concrete.Dtos.Genre;
using Entity.Concrete.Models;

namespace BookStore.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<Book, DtoForGetBooks>().ReverseMap();
            CreateMap<Book, DtoForUpdateBook>().ReverseMap();
            CreateMap<Book, DtoForCreateBook>().ReverseMap();
            CreateMap<Book, DtoForGetBookDetail>().ReverseMap();

            CreateMap<Genre, GenreDto>().ReverseMap();
            CreateMap<Genre, DtoForCreateGenre>().ReverseMap();
            CreateMap<Genre, DtoForUpdateGenre>().ReverseMap();

            CreateMap<Author, DtoAuthor>().ReverseMap();
            CreateMap<Author, DtoForUpdateAuthor>().ReverseMap();
            CreateMap<Author, DtoForCreateAuthor>().ReverseMap();
        }
    }
}
