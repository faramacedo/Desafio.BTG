using Cliente.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cliente.Infrastructure.Database.EntityTypes
{
    internal class TipoDocumentoEntityTypeConfiguration: IEntityTypeConfiguration<TipoDocumento>
    {
        void IEntityTypeConfiguration<TipoDocumento>.Configure(EntityTypeBuilder<TipoDocumento> builder)
        {
            builder.ToTable("TipoDocumento");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CodigoTipoDocumento).IsRequired(true);
            builder.Property(x => x.Descricao).IsUnicode(false).HasMaxLength(30).IsRequired(true);
            
            builder.HasData(new TipoDocumento(1, 1, "CPF"));
            builder.HasData(new TipoDocumento(2, 2, "CNPJ"));
        }
    }
}
