using Microsoft.EntityFrameworkCore;
namespace BookStore
{
    public class BookStoreDBContext : DbContext
    {
        public BookStoreDBContext(DbContextOptions<BookStoreDBContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(
                new()
                {
                    Title = "Lean Startup",
                    GenreId = 1,//Personal Growth
                    PageCount = 224,
                    PublishDate = new DateTime(2001, 06, 12)
                },
                new()
                {
                    Title = "Herland",
                    GenreId = 2,//Sciene Fiction
                    PageCount = 224,
                    PublishDate = new DateTime(2010, 05, 23)
                },
                new()
                {
                    Title = "Herland",
                    GenreId = 2,//Sciene Fiction
                    PageCount = 224,
                    PublishDate = new DateTime(2002, 12, 21)
                }
            );
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}