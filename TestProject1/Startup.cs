using Infrastructure.Test;
using Microsoft.Extensions.DependencyInjection;

namespace TestProject1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddInMemoryStorage();
        }
    }
}
