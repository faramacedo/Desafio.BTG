
namespace Cliente.Infrastructure.RabbitMQ
{
    public interface IRabbitMQService
    {
        public void MessageProducer(string fila, string mensagem);
        public bool MessageConsumer(string message);
    }
}
