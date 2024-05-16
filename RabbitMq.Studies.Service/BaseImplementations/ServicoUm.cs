namespace RabbitMq.Studies.Service.BaseImplementations;

public class ServicoUm(IServicoDois servicoDois) : IServicoUm
{
    private readonly IServicoDois _servicoDois = servicoDois;

    public void RealizarTarefaQueEstaDentroDeServicoDois()
    {
        _servicoDois.RealizarTarefa();
    }
}

public interface IServicoUm
{
    public void RealizarTarefaQueEstaDentroDeServicoDois();
}

public class ServicoDois : IServicoDois
{
    public void RealizarTarefa()
    {
        Console.WriteLine("Tarefa do serviço dois.");
    }
}

public interface IServicoDois
{
    public void RealizarTarefa();
}