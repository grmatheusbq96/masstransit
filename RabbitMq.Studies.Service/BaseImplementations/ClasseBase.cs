namespace RabbitMq.Studies.Service.BaseImplementations;

public class ClasseBase : IClasseBase
{
    public void EscreverMensagemBoasVindas()
    {
        Console.WriteLine("Aqui é realizada a tarefa original, que não pode ser alterada.");
        Console.WriteLine();
    }
}
