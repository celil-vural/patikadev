namespace Entity.Concrete.Dtos.Genre
{
    public class GenreDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public bool IsActive { get; set; }
    }
}
