using Cliente.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cliente.Infrastructure.Database.EntityTypes
{
    internal class TipoPessoaEntityTypeConfiguration : IEntityTypeConfiguration<TipoPessoa>
    {
        void IEntityTypeConfiguration<TipoPessoa>.Configure(EntityTypeBuilder<TipoPessoa> builder)
        {
            builder.ToTable("TipoPessoa");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CodigoTipoPessoa).IsRequired(true);
            builder.Property(x => x.Descricao).IsUnicode(false).HasMaxLength(30).IsRequired(true);
            
            builder.HasData(new TipoPessoa(1, 1, "Física"));
            builder.HasData(new TipoPessoa(2, 2, "Juridica"));
        }

    }
}
