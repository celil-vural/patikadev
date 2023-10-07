using FluentValidation;

namespace Services.ValidationRules.FluentValidation.Books
{
    internal class BookGetByIdValidator : AbstractValidator<int>
    {
        public BookGetByIdValidator()
        {
            RuleFor(i => i).GreaterThan(0);
        }
    }
}
