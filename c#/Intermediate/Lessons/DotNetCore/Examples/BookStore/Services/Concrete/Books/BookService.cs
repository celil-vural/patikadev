using AutoMapper;
using BookStore.Core.CrossCuttingConcerns.Aspects.Postsharp.ValidationAspect;
using Entity.Concrete.Dtos.Books;
using Entity.Concrete.Models;
using Repository.Contracts.Books;
using Services.Contracts.Books;
using Services.ValidationRules.FluentValidation.Books;

namespace Services.Concrete.Books
{
    public class BookService : BaseService<Book, BookDto>, IBookService
    {
        public BookService(IBookRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        { }
        [FluentValidationAspect(typeof(BooksCreateValidator))]
        public override int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion)
        {
            return base.CreateWithDto(dtoForInsertion);
        }
        [FluentValidationAspect(typeof(BooksUpdateValidator))]
        public override TDto Update<TDto>(TDto dto)
        {
            return base.Update(dto);
        }
        [FluentValidationAspect(typeof(BookDeleteValidator))]
        public override void Delete(int id)
        {

            base.Delete(id);
        }

        [FluentValidationAspect(typeof(BookGetByIdValidator))]
        public override BookDto? GetWithId(int id)
        {
            return base.GetWithId(id);
        }
    }
}
