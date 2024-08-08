namespace Cliente.Domain.Dto
{
    public  class AlteraClienteDto
    {
        public int Id { get; internal set; }
        public string Nome { get; set; }
        public int TipoPessoaId { get; set; }
        public string Documento { get; set; }
        public int TipoDocumentoId { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
