namespace Entities.Concrete.Dtos.Book
{
    public record DtoForGetBooks
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Genre { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; } = string.Empty;
    }
}
