using AppChurch.Data.Repositories;
using AppChurch.Domain.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AppChurch.Ioc.Dependences
{
    public static class DepedencyInjection
    {
        public static void AddDepencies(this IServiceCollection services)
        {
            AddRepositoryDependency(services);
        }

        private static void AddRepositoryDependency(IServiceCollection services)
        {
            services.AddScoped<IMembroRepository, MembroRepository>();
        }
    }
}
