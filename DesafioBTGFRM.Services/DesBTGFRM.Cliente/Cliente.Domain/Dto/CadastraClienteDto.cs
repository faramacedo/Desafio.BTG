namespace Cliente.Domain.Dto
{
    public class CadastraClienteDto
    {
        public int CodigoCliente { get; set; }
        public string Nome { get; set; }
        public int TipoPessoaId { get; set; }
        public string Documento { get; set; }
        public int TipoDocumentoId { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
