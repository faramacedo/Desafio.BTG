using Cliente.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Cliente.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        private readonly IClienteService clienteService;
        public TesteController(IClienteService _clienteService)
        {
            clienteService = _clienteService;
        }

        /// <summary>
        ///     Enviar mensagem
        /// </summary>
        [Route("mensagem")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IActionResult> MensagemTeste()
        {

            clienteService.EnviarMensagemFila("Clientes", "Oi papai");
            return Ok(true);
        }
    }
}
