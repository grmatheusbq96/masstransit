using Microsoft.Extensions.DependencyInjection;
using RabbitMq.Studies.Service.Abstract;

namespace RabbitMq.Studies.Service.Decorators;

public class ClasseBaseDecoratorPrimeira([FromKeyedServices("original")] IClasseBase classeBase) : ClasseBaseAbstract(classeBase), IClasseBase
{
    public override void EscreverMensagemBoasVindas()
    {
        Console.WriteLine("Tarefa de numero 2 adicionada e chama a tarefa original.");
        Console.WriteLine("Chamando tarefa original...");
        base.EscreverMensagemBoasVindas();
    }
}