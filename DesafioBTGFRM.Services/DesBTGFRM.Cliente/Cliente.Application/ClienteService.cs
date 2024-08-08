
using Cliente.Domain;
using Cliente.Infrastructure.RabbitMQ;

namespace Cliente.Application
{
    public class ClienteService : IClienteService
    {
        private IRabbitMQService rabbitMQService;

        public ClienteService(IRabbitMQService _rabbitMQService)
        {
            rabbitMQService = _rabbitMQService; 
        }

        public void EnviarMensagemFila(string fila, string mensagem)
        {
            rabbitMQService.MessageProducer(fila, mensagem);
        }
    }
}
