using FluentValidation;

namespace Services.ValidationRules.FluentValidation.Authors
{
    internal class AuthorGetWithIdValidator : AbstractValidator<int>
    {
        public AuthorGetWithIdValidator()
        {
            RuleFor(x => x).GreaterThan(0);
        }
    }
}
