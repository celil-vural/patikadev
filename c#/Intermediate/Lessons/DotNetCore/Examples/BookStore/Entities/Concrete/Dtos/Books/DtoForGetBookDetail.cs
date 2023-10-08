namespace Entity.Concrete.Dtos.Books
{
    public record DtoForGetBookDetail
    {
        public int Id { get; init; }
        public string Title { get; init; }
        public string Genre { get; init; }
        public int AuthorId { get; init; }
        public int PageCount { get; init; }
        public string PublishDate { get; init; }
    }
}
