using Consulta.Domain;
using Consulta.Infrastructure.Database;

namespace Consulta.Application
{
    public class ClienteService : IClientesService
    {
        private readonly AppDbContext _context;
        public ClienteService(AppDbContext context)
        {
            _context = context;
        }
        public void CadastraAlteraCliente(Clientes clientes)
        {
            var cliente = _context.Clientes.Where(c => c.CodigoCliente == clientes.CodigoCliente).FirstOrDefault();
            if (cliente != null)
            {
                cliente.Nome = clientes.Nome == null ? String.Empty : clientes.Nome;
                cliente.TipoPessoa = clientes.TipoPessoa == null ? string.Empty : clientes.TipoPessoa;
                cliente.TipoDocumento = clientes.TipoDocumento == null ? string.Empty : clientes.TipoDocumento;
                cliente.Documento = clientes.Documento == null ? string.Empty : clientes.Documento;
                cliente.DataAlteracao = DateTime.Now;

            }
            else
            {
                Clientes.Cadastrar(clientes);
            }
            _context.SaveChanges();
        }
    }
}
