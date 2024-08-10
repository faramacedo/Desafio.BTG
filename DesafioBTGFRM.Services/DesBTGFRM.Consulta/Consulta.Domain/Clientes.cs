using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Consulta.Domain
{
    public class Clientes
    {
        public int Id { get; internal set; }
        public int CodigoCliente { get; set; }
        public string Nome { get; set; }
        public string TipoPessoa { get; set; }
        public string Documento { get; set; }
        public string TipoDocumento { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }

        private Clientes(int id, int codigoCliente, string nome, string tipoPessoa, string documento, string tipoDocumento, DateTime dataCadastro, DateTime? dataAlteracao)
        {
            Id = id;
            CodigoCliente = codigoCliente;
            Nome = nome;
            TipoPessoa = tipoPessoa;
            Documento = documento;
            TipoDocumento = tipoDocumento;
            DataCadastro = dataCadastro;
            DataAlteracao = dataAlteracao;
        }
        public static Clientes Cadastrar(Clientes clientes)
        {
            return new Clientes(clientes.Id, clientes.CodigoCliente, clientes.Nome, clientes.TipoPessoa, clientes.Documento, clientes.TipoDocumento, clientes.DataCadastro, clientes.DataAlteracao);
        }
    }
}
