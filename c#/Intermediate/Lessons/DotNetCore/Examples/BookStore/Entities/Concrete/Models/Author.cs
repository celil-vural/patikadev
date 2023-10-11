using Entity.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete.Models
{
    public class Author : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
