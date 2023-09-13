using Microsoft.EntityFrameworkCore;

namespace LinqPractices
{
    public class LinqDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseInMemoryDatabase(databaseName: "LinqDatabase");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 1,
                    Name = "Ayşe",
                    Surname = "Yılmaz",
                    ClassId = 1
                }
            );
        }
    }
}