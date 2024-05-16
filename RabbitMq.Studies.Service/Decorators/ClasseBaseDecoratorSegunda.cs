using Microsoft.Extensions.DependencyInjection;
using RabbitMq.Studies.Service.Abstract;

namespace RabbitMq.Studies.Service.Decorators;

public class ClasseBaseDecoratorSegunda([FromKeyedServices("primeira")]IClasseBase classeBase) : ClasseBaseAbstract(classeBase), IClasseBase
{
    public override void EscreverMensagemBoasVindas()
    {
        Console.WriteLine("Tarefa de numero 3 adicionada e chama as duas tarefas que estão encapsuladas.");
        Console.WriteLine("Chamando próxima tarefa na cadeia de tarefas...");
        base.EscreverMensagemBoasVindas();
    }
}
