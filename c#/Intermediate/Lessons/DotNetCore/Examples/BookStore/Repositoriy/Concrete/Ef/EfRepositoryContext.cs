using Entity.Concrete.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.Concrete.Ef
{
    public class EfRepositoryContext : DbContext
    {
        public EfRepositoryContext(DbContextOptions<EfRepositoryContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(
                new()
                {
                    Id = 1,
                    Title = "Lean Startup",
                    GenreId = 1,//Personal Growth
                    PageCount = 224,
                    PublishDate = new DateTime(2001, 06, 12)
                },
                new()
                {
                    Id = 2,
                    Title = "Herland",
                    GenreId = 2,//Sciene Fiction
                    PageCount = 224,
                    PublishDate = new DateTime(2010, 05, 23)
                },
                new()
                {

                    Id = 3,
                    Title = "Herland",
                    GenreId = 2,//Sciene Fiction
                    PageCount = 224,
                    PublishDate = new DateTime(2002, 12, 21)
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
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
