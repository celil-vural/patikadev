using AutoMapper;
using BookStore.Core.CrossCuttingConcerns.Aspects.Postsharp.ValidationAspect;
using Entity.Concrete.Dtos.Author;
using Entity.Concrete.Models;
using Repository.Contracts;
using Services.Contracts.Authors;
using Services.ValidationRules.FluentValidation.Authors;

namespace Services.Concrete.Authors
{
    public class AuthorService : BaseService<Author, DtoAuthor>, IAuthorService
    {
        public AuthorService(IRepositoryBase<Author> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }

        [FluentValidationAspect(typeof(AuthorCreateValidator))]
        public override int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion)
        {
            return base.CreateWithDto(dtoForInsertion);
        }
        [FluentValidationAspect(typeof(AuthorCreateValidator))]
        public override TDtoForUpdate Update<TDtoForUpdate>(TDtoForUpdate dto)
        {
            return base.Update(dto);
        }
        [FluentValidationAspect(typeof(AuthorDeleteValidator))]
        public override void Delete(int id)
        {
            base.Delete(id);
        }

        [FluentValidationAspect(typeof(AuthorGetWithIdValidator))]
        public override DtoAuthor? GetWithId(int id)
        {
            return base.GetWithId(id);
        }
    }
}
