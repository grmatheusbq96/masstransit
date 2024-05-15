using Microsoft.Extensions.DependencyInjection;
using RabbitMq.Studies.Service.Decorator;

namespace RabbitMq.Studies.Service.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddService(this IServiceCollection services)
    {
        services.AddKeyedSingleton<IModelo, Modelo>("modelo-real");
        services.AddSingleton<IModelo, ModeloSeguro>();

        return services;
    }
}
