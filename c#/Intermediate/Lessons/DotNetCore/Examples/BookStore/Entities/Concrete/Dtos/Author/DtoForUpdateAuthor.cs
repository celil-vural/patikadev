namespace Entity.Concrete.Dtos.Author
{
    public record DtoForUpdateAuthor
    {
        public String Name { get; init; }
        public String Surname { get; init; }
        public DateTime BirthDate { get; init; }
    }
}
