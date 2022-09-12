using Microsoft.Extensions.DependencyInjection;
using Shop.Application.Services;
using Shop.Domain.Interfaces;
using Shop.Infra.Data.Repositories;

namespace Shop.Infra.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Product
            services.AddScoped<IProductService, ProductService>(); // Application
            services.AddScoped<IProductRepository, ProductRepository>(); //Domain and Repositories
        }
    }
}
