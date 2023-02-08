using Domain;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Test
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInMemoryStorage(this IServiceCollection services)
        {
            services.AddSingleton<IStorage, InMemoryStorage>();
            return services;
        }
    }
}