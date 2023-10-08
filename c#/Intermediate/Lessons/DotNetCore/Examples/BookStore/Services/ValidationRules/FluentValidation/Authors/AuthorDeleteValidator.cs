using FluentValidation;

namespace Services.ValidationRules.FluentValidation.Authors
{
    internal class AuthorDeleteValidator : AbstractValidator<int>
    {
        public AuthorDeleteValidator()
        {
            RuleFor(x => x).GreaterThan(0);
        }
    }
}
