using Entities.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete.Model
{
    public class Book : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int GenreId { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
