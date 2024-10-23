using AppChurch.Domain.Request.Command;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using AppChurch.Domain.Request.Query;

namespace AppChurch.Ioc.Dependences
{
    public static class MediatrExtension
    {
        public static void AddMediatRApi(this IServiceCollection services)
        {
            //services.AddMediatR(typeof(CreateMembroRequest).Assembly);
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(CreateMembroRequest).Assembly));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(UpdateMembroRequest).Assembly));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(MembrosGetByIdQuery).Assembly));
        }
    }
}
