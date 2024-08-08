namespace Cliente.Domain
{
    public class TipoPessoa
    {
        public int Id { get; }
        public int CodigoTipoPessoa { get; }
        public string Descricao { get; }
        public TipoPessoa() { }
        public TipoPessoa(int id, int codigoTipoPessoa, string descricao)
        {
            this.Id = id;
            this.CodigoTipoPessoa = codigoTipoPessoa;
            this.Descricao = descricao;
        }

    }
}