using Microsoft.Extensions.DependencyInjection;
using RabbitMq.Studies.Service.BaseImplementations;
using RabbitMq.Studies.Service.Decorators;

namespace RabbitMq.Studies.Service.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddService(this IServiceCollection services)
    {
        //services.AddSingletonDecorator<IClasseBase, ClasseBase, ClasseBaseDecoratorPrimeira, ClasseBaseDecoratorSegunda>();

        services.AddSingleton<IServicoUm, ServicoUm>();
        services.AddSingleton<IServicoDois, ServicoDois>();


        //services.AddKeyedSingleton<IClasseBase, ClasseBase>("original");
        //services.AddKeyedSingleton<IClasseBase, ClasseBaseDecoratorPrimeira>("primeira");
        //services.AddKeyedSingleton<IClasseBase, ClasseBaseDecoratorSegunda>("segunda");

        return services;
    }

    //public static IServiceCollection AddSingletonDecorator<InterfaceUsada, ClasseBaseUsada, PrimeiroDecorator, SegundoDecorator>(
    //    this IServiceCollection services)
    //    where InterfaceUsada : class
    //    where ClasseBaseUsada : class, InterfaceUsada
    //    where PrimeiroDecorator : class, InterfaceUsada
    //    where SegundoDecorator : class, InterfaceUsada
    //{
    //    services.AddKeyedSingleton<InterfaceUsada, ClasseBaseUsada>("original");
    //    services.AddKeyedSingleton<IClasseBase, ClasseBaseDecoratorPrimeira>("primeira");
    //    services.AddKeyedSingleton<IClasseBase, ClasseBaseDecoratorSegunda>("segunda");

    //    return services;
    //}
}
