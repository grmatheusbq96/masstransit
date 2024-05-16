using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitMq.Studies.Service;
using RabbitMq.Studies.Service.BaseImplementations;
using RabbitMq.Studies.Service.Decorators;

namespace RabbitMq.Studies.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecoratorDemoController(
        [FromKeyedServices("original")] IClasseBase classeBase,
        [FromKeyedServices("primeira")] IClasseBase decoratorPrimeira,
        [FromKeyedServices("segunda")] IClasseBase decoratorSegunda) : ControllerBase
    {
        private readonly IClasseBase _classeBase = classeBase;
        private readonly IClasseBase _decoratorPrimeira = decoratorPrimeira;
        private readonly IClasseBase _decoratorCompleto = decoratorSegunda;

        [HttpPost]
        public IActionResult Demo()
        {
            IClasseBase classeBase = new ClasseBase();
            Console.WriteLine("Teste instanciando classe base, sem nenhuma camada de decorator:");
            classeBase.EscreverMensagemBoasVindas();

            classeBase = new ClasseBaseDecoratorPrimeira(new ClasseBase());
            Console.WriteLine("Teste instanciando classe base, com uma camada de decorator:");
            classeBase.EscreverMensagemBoasVindas();

            classeBase = new ClasseBaseDecoratorSegunda(new ClasseBaseDecoratorPrimeira(new ClasseBase()));
            Console.WriteLine("Teste instanciando classe base, com duas camadas de decorator:");
            classeBase.EscreverMensagemBoasVindas();

            Console.WriteLine("Teste utilizando injeção de dependencia, sem nenhuma camada de decorator:");
            _classeBase.EscreverMensagemBoasVindas();

            Console.WriteLine("Teste utilizando injeção de dependencia, com uma camada de decorator:");
            _decoratorPrimeira.EscreverMensagemBoasVindas();

            Console.WriteLine("Teste utilizando injeção de dependencia, com duas camadas de decorator:");
            _decoratorCompleto.EscreverMensagemBoasVindas();

            //var decoratorCompleto = new ClasseBaseDecoratorSegunda(new ClasseBaseDecoratorPrimeira(new ClasseBase()));
            //decoratorCompleto.EscreverMensagemBoasVindas();

            //_decoratorCompleto.EscreverMensagemBoasVindas();

            return Ok();
        }
    }
}
