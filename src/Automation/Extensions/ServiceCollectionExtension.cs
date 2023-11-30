using DesafioAeC.AluraRPA.Data.Repositories;
using DesafioAeC.Automation.Data;
using DesafioAeC.Automation.Domain.Interfaces;
using DesafioAeC.Automation.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DesafioAeC.AluraRPA.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection ConfiureServices(this IServiceCollection services)
        {
            return services
                .AddDatabase()
                .AddDI();
        }

        private static IServiceCollection AddDatabase(this IServiceCollection services)
        {
            return services
                .AddDbContext<AppDbContext>(options =>
                {
                    options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AluraRPA;Trusted_Connection=True;");
                });
        }

        private static IServiceCollection AddDI(this IServiceCollection services)
        {
            return services
                .AddScoped<ISearchService, SearchService>()
                .AddTransient<ISearchResultRepository, SearchResultRepository>();
        }
    }
}
