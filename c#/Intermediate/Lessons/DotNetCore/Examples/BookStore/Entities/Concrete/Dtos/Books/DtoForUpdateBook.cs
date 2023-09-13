namespace Entities.Concrete.Dtos.Books
{
    public class DtoForUpdateBook
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int GenreId { get; set; }
    }
}
