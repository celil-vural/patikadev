using FluentValidation;

namespace Services.ValidationRules.FluentValidation.Books
{
    internal class BookDeleteValidator : AbstractValidator<int>
    {
        public BookDeleteValidator()
        {
            RuleFor(i => i).GreaterThan(0);
        }
    }
}
