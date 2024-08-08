namespace Cliente.Domain
{
    public class TipoDocumento
    {
        public int Id { get; }
        public int CodigoTipoDocumento { get; }
        public string Descricao { get; }
        public TipoDocumento() { }
        public TipoDocumento(int id, int codigoTipoDocumento, string descricao)
        {
            this.Id = id;
            this.CodigoTipoDocumento = codigoTipoDocumento;
            this.Descricao = descricao;
        }
    }
}