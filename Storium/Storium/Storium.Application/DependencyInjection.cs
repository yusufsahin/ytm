
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Storium.Domain.Abstraction;

namespace Storium.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(
            this IServiceCollection services)
        {
            services.AddMediatR(cfr =>
            {
                cfr.RegisterServicesFromAssemblies(
                    Assembly.GetExecutingAssembly(),
                    typeof(Entity).Assembly);
            });

            return services;
        }
    }
}
