using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RabbitMq.Studies.Service.Decorator;

public class Modelo : IModelo
{
    public async Task FazerAcao(int numeroDaTentativa)
    {

        Random random = new Random();

        int randomNumber = random.Next(1, 101);

        if (randomNumber <= 70)
        {
            Console.WriteLine($"Serviço fora do ar para tentativa {numeroDaTentativa}! Aguarde 1 segundo.");
            await Task.Delay(TimeSpan.FromSeconds(1));

            throw new Exception("Serviço fora do ar!");
        }
        else
        {
            Console.WriteLine($"Ação será feita na tentativa {numeroDaTentativa}! Aguarde 2 segundos.");
            await Task.Delay(TimeSpan.FromSeconds(2));
            Console.WriteLine("Obrigado por participar!");
            Console.WriteLine();
        }
    }
}
