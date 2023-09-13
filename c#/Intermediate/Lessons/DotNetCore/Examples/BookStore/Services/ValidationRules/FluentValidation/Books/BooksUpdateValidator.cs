using Entities.Concrete.Dtos.Books;
using FluentValidation;

namespace Services.ValidationRules.FluentValidation.Books
{
    internal class BooksUpdateValidator : AbstractValidator<DtoForUpdateBook>
    {
        public BooksUpdateValidator()
        {

        }
    }
}
