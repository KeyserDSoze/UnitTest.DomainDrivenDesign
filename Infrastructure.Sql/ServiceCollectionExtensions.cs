using Domain;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Sql
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSqlStorage(this IServiceCollection services)
        {
            services.AddSingleton<IStorage, SqlStorage>();
            return services;
        }
    }
}