using RabbitMQ.Client;
using System.Text;

namespace Cliente.Infrastructure.RabbitMQ
{
    public class RabbitMQService : IRabbitMQService, IDisposable
    {
        public void MessageProducer(string fila, string message)
        {
            var factory = new ConnectionFactory { HostName = "localhost" };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            channel.QueueDeclare(queue: fila,
                                durable: false,
                                exclusive: false,
                                autoDelete: false,
                                arguments: null);

            var body = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(exchange: string.Empty,
                                 routingKey: fila,
                                 basicProperties: null,
                                 body: body);

        }

        public bool MessageConsumer(string message)
        {
            bool result = false;
            var index = message.IndexOf(":");
            var acao = message.Substring(0, index);
            var messsage = message.Substring(index + 1, message.Length - index - 1);

            switch (acao)
            {
                case "CadastraCliente":

                    result = true;
                    break;
                case "AtualizarCliente":
                    result = false;
                    break;
                default:
                    break;
            }
            return result;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
