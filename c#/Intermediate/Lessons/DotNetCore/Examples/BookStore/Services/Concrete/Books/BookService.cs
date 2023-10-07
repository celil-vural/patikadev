using AutoMapper;
using BookStore.Core.CrossCuttingConcerns.Aspects.Postsharp.ValidationAspect;
using Entities.Concrete.Model;
using Repositories.Contracts.Books;
using Services.ValidationRules.FluentValidation.Books;

namespace Services.Concrete.Books
{
    public class BookService : BaseService<Book>
    {
        private readonly IBookRepository _baseRepository;
        public BookService(IBookRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        { }
        [FluentValidationAspect(typeof(BooksCreateValidator))]
        public override int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion)
        {
            return base.CreateWithDto(dtoForInsertion);
        }
        [FluentValidationAspect(typeof(BooksUpdateValidator))]
        public override void Update<TDto>(TDto dto)
        {
            base.Update(dto);
        }
        [FluentValidationAspect(typeof(BookDeleteValidator))]
        public override void Delete(int id)
        {
            base.Delete(id);
        }
        [FluentValidationAspect(typeof(BookGetByIdValidator))]
        public override TDto? GetWithId<TDto>(int id) where TDto : default
        {
            return base.GetWithId<TDto>(id);
        }
    }
}
