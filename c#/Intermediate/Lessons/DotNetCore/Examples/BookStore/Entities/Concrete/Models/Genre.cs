using Entity.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete.Models
{
    public class Genre : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public bool IsActive { get; set; } = true;
        public virtual IList<Book> Books { get; set; }
    }
}
