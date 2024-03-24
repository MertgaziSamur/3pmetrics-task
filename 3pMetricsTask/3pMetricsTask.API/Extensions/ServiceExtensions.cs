using _3pMetricsTask.Repositories.Contracts;
using _3pMetricsTask.Repositories.EfCore;
using _3pMetricsTask.Services;
using _3pMetricsTask.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace _3pMetricsTask.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlConnection"));
            });
        }
        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }
        public static void ConfigureServiceManager(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
        }
    }
}
