using Cliente.Domain;
using Cliente.Domain.Dto;

namespace Cliente.Application;

public interface IClienteService
{
    public Task<Clientes> CadastrarCliente(CadastraClienteDto clientes);
    public Task<Clientes> AtualizarCliente(Clientes clientes);
}
