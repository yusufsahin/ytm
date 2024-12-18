
using Microsoft.Extensions.DependencyInjection;
using Storium.Domain.Categories;
using Storium.Domain.Products;
using Storium.Domain.Users;
using Storium.Infrastructure.Context;
using Storium.Infrastructure.Repositories;

using Storium.Domain.Orders;


namespace Storium.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>();


            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            return services; 
        }
    }
}
