﻿using Entity.Concrete.Dtos.Books;
using FluentValidation;

namespace Services.ValidationRules.FluentValidation.Books
{
    internal class BooksCreateValidator : AbstractValidator<DtoForCreateBook>
    {
        public BooksCreateValidator()
        {
            RuleFor(b => b.GenreId).GreaterThan(0);
            RuleFor(b => b.AuthorId).GreaterThan(0);
            RuleFor(b => b.PageCount).GreaterThan(0);
            RuleFor(b => b.PublishDate.Date).NotEmpty().LessThan(DateTime.Now.Date);
            RuleFor(b => b.Title).NotEmpty().MinimumLength(4);
        }
    }
}
