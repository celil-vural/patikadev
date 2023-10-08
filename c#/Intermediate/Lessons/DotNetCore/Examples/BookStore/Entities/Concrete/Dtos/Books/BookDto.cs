namespace Entity.Concrete.Dtos.Books
{
    public record BookDto
    {
        public int Id { get; init; }
        public string Title { get; init; } = string.Empty;
        public int GenreId { get; init; }
        public int AuthorId { get; init; }
        public int PageCount { get; init; }
        public DateTime PublishDate { get; init; }
    }
}
