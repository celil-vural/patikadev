using Entity.Concrete.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Repository.Concrete.Ef
{
    public class EfRepositoryContext : DbContext
    {
        public EfRepositoryContext(DbContextOptions<EfRepositoryContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Author>().HasData(
                new Author()
                {
                    Id = 1,
                    Name = "Celil",
                    Surname = "Vural",
                    BirthDate = new DateTime(2000, 10, 29)
                }
                );
            modelBuilder.Entity<Genre>().HasData(
                new()
                {
                    Id = 1,
                    IsActive = true,
                    Name = "PersonalGrowth"
                },
                new()
                {
                    Id = 2,
                    IsActive = true,
                    Name = "ScienceFiction"
                },
                new()
                {
                    Id = 3,
                    IsActive = true,
                    Name = "Novel"
                }
            );
            modelBuilder.Entity<Book>().HasData(
                new()
                {
                    Id = 1,
                    Title = "Lean Startup",
                    GenreId = 1,
                    AuthorId = 1,
                    PageCount = 224,
                    PublishDate = new DateTime(2001, 06, 12)
                },
                new()
                {
                    Id = 2,
                    Title = "Herland",
                    GenreId = 2,
                    AuthorId = 1,
                    PageCount = 224,
                    PublishDate = new DateTime(2010, 05, 23)
                },
                new()
                {

                    Id = 3,
                    Title = "Herland",
                    GenreId = 2,
                    AuthorId = 1,
                    PageCount = 224,
                    PublishDate = new DateTime(2002, 12, 21)
                }
            );

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
