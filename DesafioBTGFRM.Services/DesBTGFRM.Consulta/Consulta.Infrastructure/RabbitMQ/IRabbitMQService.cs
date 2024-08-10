namespace Consulta.Infrastructure.RabbitMQ
{
    public interface IRabbitMQService
    {
        public void MessageProducer(string fila, string message);
        public bool MessageConsumer(string message);

    }
}
