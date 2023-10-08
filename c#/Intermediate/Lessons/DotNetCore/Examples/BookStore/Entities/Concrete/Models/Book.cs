using Entity.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete.Models
{
    public class Book : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Author Author { get; set; }
    }
}
