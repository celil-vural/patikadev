using AutoMapper;
using BookStore.BookOperations.CreateBook;
using BookStore.BookOperations.GetBookDetail;
using BookStore.BookOperations.UpdateBook;
using Entities.Common;
using Entities.Concrete.Dtos.Book;
using Entities.Concrete.Model;

namespace BookStore.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, DtoForGetBooks>()
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => ((GenreEnum)src.GenreId).ToString()));
            CreateMap<Book, UpdateBookModel>().ReverseMap();
            CreateMap<Book, CreateBookModel>().ReverseMap();
            CreateMap<Book, BookDetailViewModel>()
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => ((GenreEnum)src.GenreId).ToString()))
                .ReverseMap();

        }
    }
}
