using Entity.Concrete.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Concrete.Ef.Config
{
    internal class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);
            builder.HasOne(b => b.Author).WithMany().HasForeignKey(b => b.AuthorId);
            builder.HasOne(b => b.Genre).WithMany().HasForeignKey(b => b.GenreId);
        }
    }
}
