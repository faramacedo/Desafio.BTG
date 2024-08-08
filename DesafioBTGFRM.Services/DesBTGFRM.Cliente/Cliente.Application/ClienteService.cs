
using Cliente.Domain;
using Cliente.Domain.Dto;
using Cliente.Infrastructure.Database;
using Cliente.Infrastructure.RabbitMQ;
using Newtonsoft.Json;
using System.Text.Json;

namespace Cliente.Application
{
    public class ClienteService : IClienteService
    {
        private IRabbitMQService rabbitMQService;
        private AppDbContext context;

        public ClienteService(IRabbitMQService _rabbitMQService, AppDbContext appDbContext)
        {
            rabbitMQService = _rabbitMQService;
            context = appDbContext;
        }

        private void EnviarMensagemFila(string fila, string mensagem)
        {
            rabbitMQService.MessageProducer(fila, mensagem);
        }
        public async Task<Clientes> CadastrarCliente(CadastraClienteDto clientes)
        {
            var cliente = Clientes.Cadastrar(0, clientes.CodigoCliente, clientes.Nome, clientes.TipoPessoaId, clientes.Documento, clientes.TipoDocumentoId);
            context.Clientes.Add(cliente);
            context.SaveChanges();
            
            var clienteJson = JsonConvert.SerializeObject(cliente);
            EnviarMensagemFila("Clientes",$"CadastraCliente:{clienteJson}");
            EnviarMensagemFila("Consultas", $"CadastraCliente:{clienteJson}");

            return cliente;
        }

        public async Task<Clientes> AtualizarCliente(Clientes clientes)
        {
            throw new NotImplementedException();
        }
    }
}
