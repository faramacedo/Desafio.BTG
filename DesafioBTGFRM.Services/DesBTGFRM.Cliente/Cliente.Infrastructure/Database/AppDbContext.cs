using Cliente.Domain;
using Cliente.Infrastructure.Database.EntityTypes;
using Microsoft.EntityFrameworkCore;


namespace Cliente.Infrastructure.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<TipoDocumento> TipoDocumento { get; set; }
        public DbSet<TipoPessoa> TipoPessoa { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TipoDocumentoEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TipoPessoaEntityTypeConfiguration());
        }
    }
}
