using Entity.Contracts;

namespace Entity.Concrete.Models
{
    public class Author : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual IEnumerable<Book> Books { get; set; }
    }
}
