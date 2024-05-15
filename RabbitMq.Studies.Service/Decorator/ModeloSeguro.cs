using Microsoft.Extensions.DependencyInjection;

namespace RabbitMq.Studies.Service.Decorator;

public class ModeloSeguro([FromKeyedServices("modelo-real")] IModelo modelo) : IModelo
{
    private readonly IModelo _modelo = modelo;

    public async Task FazerAcao(int numeroTentativa)
    {
		Comecar:
		try
		{
			await _modelo.FazerAcao(numeroTentativa);
		}
		catch (Exception)
		{
			if (numeroTentativa <= 5)
			{
                numeroTentativa++;

				Console.WriteLine("Ocorreu um problema ao buscar o serviço, vamos tentar mais uma vez. Aguarde mais 1 segundo");
                Console.WriteLine();

                await Task.Delay(TimeSpan.FromSeconds(1));
				goto Comecar;
			}
			throw;
		}
    }
}
