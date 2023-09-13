using Entities.Concrete.Dtos.Books;
using FluentValidation;

namespace Services.ValidationRules.FluentValidation.Books
{
    internal class BooksCreateValidator : AbstractValidator<DtoForCreateBook>
    {
        public BooksCreateValidator()
        {

        }
    }
}
