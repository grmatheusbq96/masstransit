using Microsoft.Extensions.DependencyInjection;

namespace RabbitMq.Studies.Service.Abstract;

public abstract class ClasseBaseAbstract([FromKeyedServices("original")] IClasseBase classeBase) : IClasseBase
{
    private readonly IClasseBase _classeBase = classeBase;

    public virtual void EscreverMensagemBoasVindas() => _classeBase.EscreverMensagemBoasVindas();
}
