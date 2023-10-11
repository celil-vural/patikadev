namespace Entity.Concrete.Dtos.Author
{
    public record DtoForCreateAuthor
    {
        public String Name { get; init; }
        public String Surname { get; init; }
        public DateTime BirthDate { get; init; }

    }
}
