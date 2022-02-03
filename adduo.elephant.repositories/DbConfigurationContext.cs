using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace adduo.elephant.repositories
{
    public static class DbConfigurationContext
    {
        public static void AddDatabaseContext(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<ElephantContext>(option => option.UseInMemoryDatabase("local"));
            var connectionString = configuration.GetConnectionString("elephant");
            services.AddDbContext<ElephantContext>(option => option.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

        }
    }
}
