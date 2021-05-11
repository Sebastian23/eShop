using eShop.Application.Common.RepositoryInterfaces;
using eShop.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace eShop.Infrastructure
{
    public static class Bootstrapper
    {
        public static void RegisterInfrastructure(this IServiceCollection services)
        {
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }
    }
}