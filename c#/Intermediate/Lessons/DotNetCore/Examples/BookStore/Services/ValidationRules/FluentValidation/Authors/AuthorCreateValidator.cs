using Entity.Concrete.Dtos.Author;
using FluentValidation;

namespace Services.ValidationRules.FluentValidation.Authors
{
    internal class AuthorCreateValidator : AbstractValidator<DtoForCreateAuthor>
    {
        public AuthorCreateValidator()
        {
            RuleFor(x => x.BirthDate).NotEmpty().LessThan(DateTime.Now.Date);
            RuleFor(x => x.Name).NotEmpty().MinimumLength(4);
            RuleFor(x => x.Surname).NotEmpty().MinimumLength(4);
        }
    }
}
