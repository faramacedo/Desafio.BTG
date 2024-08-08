using Cliente.Application;
using Cliente.Domain;
using Cliente.Domain.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Cliente.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        [Route("/cadastar")]
        public async Task<IActionResult> CadastrarCliente([FromBody]CadastraClienteDto clientes)
        { 
            var cliente = await _clienteService.CadastrarCliente(clientes);
            return Created();
        }
    }
}
