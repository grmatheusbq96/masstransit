using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitMq.Studies.Service.Decorator;

namespace RabbitMq.Studies.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModeloController(IModelo modelo) : ControllerBase
    {
        private readonly IModelo _modelo = modelo;

        [HttpPost]
        public IActionResult FazerAcao()
        {
            _modelo.FazerAcao(1);

            return Ok();
        }
    }
}
