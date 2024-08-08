using Cliente.Domain;

namespace Cliente.Application;

public interface IClienteService
{
    public void EnviarMensagemFila(string fila, string mensagem);
}
