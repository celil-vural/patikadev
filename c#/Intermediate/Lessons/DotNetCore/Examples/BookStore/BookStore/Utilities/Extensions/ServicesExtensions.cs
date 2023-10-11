using Entity.Concrete.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Concrete.Authors;
using Repository.Concrete.Books;
using Repository.Concrete.Ef;
using Repository.Concrete.Genres;
using Repository.Concrete.Users;
using Repository.Contracts;
using Repository.Contracts.Authors;
using Repository.Contracts.Books;
using Repository.Contracts.Genres;
using Repository.Contracts.Users;
using Services.Concrete;
using Services.Concrete.Authors;
using Services.Concrete.Books;
using Services.Concrete.Genres;
using Services.Concrete.Users;
using Services.Contracts;
using Services.Contracts.Authors;
using Services.Contracts.Books;
using Services.Contracts.Genres;
using Services.Contracts.Users;

namespace BookStore.Utilities.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EfRepositoryContext>(
                options =>
                {
                    options.UseSqlServer(
                        configuration.GetConnectionString("sqlConnection"),
                        b =>
                        {
                            b.MigrationsAssembly("BookStore");
                            b.EnableRetryOnFailure();
                        })
                    .EnableSensitiveDataLogging();
                }
            );
        }

        public static void ConfigureIoc(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerService, ConsoleLogger>();

            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IGenreRepository, GenreRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IRepositoryBase<Book>, BookRepository>();
            services.AddScoped<IRepositoryBase<Genre>, GenreRepository>();
            services.AddScoped<IRepositoryBase<Author>, AuthorRepository>();
            services.AddScoped<IRepositoryBase<User>, UserRepository>();

            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IGenreService, GenreService>();
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IUserService, UserService>();

        }
    }
}