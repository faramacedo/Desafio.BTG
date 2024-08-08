namespace Cliente.Domain;

public class Clientes
{

    public int Id { get; internal set; }
    public int CodigoCliente { get; set; }
    public string Nome { get; set; }
    public int TipoPessoaId { get; set; }
    public TipoPessoa TipoPessoa { get; set; }
    public string Documento { get; set; }
    public int TipoDocumentoId { get; set; }
    public TipoDocumento TipoDocumento { get; set; }
    public DateTime DataCadastro { get; set; }
    public DateTime? DataAlteracao { get; set; }

    private Clientes(int id, int codigoCliente, string nome, int tipoPessoaId, string documento, int tipoDocumentoId, DateTime dataCadastro, DateTime? dataAlteracao)
    {
        Id = id;
        CodigoCliente = codigoCliente;
        Nome = nome;
        TipoPessoaId = tipoPessoaId;
        Documento = documento;
        TipoDocumentoId = tipoDocumentoId;
        DataCadastro = dataCadastro;
        DataAlteracao = dataAlteracao;
    }

    public static Clientes Cadastrar(int id, int codigoCliente, string nome, int tipoPessoaId, string documento, int tipoDocumentoId)
    {
        return new Clientes(0, codigoCliente, nome, tipoPessoaId, documento, tipoDocumentoId, DateTime.Now, null);
    }
    public void Atualizar(int id, int codigoCliente, string nome, int tipoPessoaId, string documento, int tipoDocumentoId)
    {
        Id = id;
        CodigoCliente = codigoCliente;
        Nome = nome;
        TipoPessoaId = tipoPessoaId;
        Documento = documento;
        TipoDocumentoId = tipoDocumentoId;
        DataAlteracao = DateTime.Now;
    }
}
