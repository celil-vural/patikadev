namespace Entity.Concrete.Dtos.Author
{
    public record DtoAuthor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
