namespace Entity.Concrete.Dtos.Books
{
    public record DtoForGetBooks
    {
        public int Id { get; init; }
        public string Title { get; init; } = string.Empty;
        public int GenreId { get; init; }
        public int AuthorId { get; init; }
        public int PageCount { get; init; }
        public string PublishDate { get; init; } = string.Empty;
    }
}
