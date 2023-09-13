using Microsoft.EntityFrameworkCore;
using Repositoriy.Concrate.Ef;

namespace BookStore.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EfRepositoryContext>(
            options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("sqlConnection"), b => b.MigrationsAssembly("BookStore"));

            }
            );
        }
    }
}