using eShop.Application.ServiceInterfaces;
using eShop.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace eShop.Application
{
    public static class Bootstrapper
    {
        public static void RegisterApplication(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
        }
    }
}