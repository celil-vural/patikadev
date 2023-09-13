namespace Entities.Concrete.Dtos.Books
{
    public class DtoForCreateBook
    {
        public string Title { get; set; } = string.Empty;
        public int GenreId { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
