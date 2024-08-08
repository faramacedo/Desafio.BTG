using Cliente.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cliente.Infrastructure.Database.EntityTypes
{
    internal class ClienteEntityTypeConfiguration : IEntityTypeConfiguration<Clientes>
    {
        void IEntityTypeConfiguration<Clientes>.Configure(EntityTypeBuilder<Clientes> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CodigoCliente).IsRequired(true);
            builder.Property(x => x.Nome).IsUnicode(false).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.Documento).IsUnicode(false).HasMaxLength(30).IsRequired(true);
        }
    }
}
