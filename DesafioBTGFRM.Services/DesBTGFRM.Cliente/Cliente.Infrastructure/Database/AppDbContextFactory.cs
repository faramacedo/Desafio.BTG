using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Cliente.Infrastructure.Database
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        private readonly IConfiguration _configuration;
        
        public AppDbContextFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public AppDbContext CreateDbContext(string[] args)
        {
            var connectionString = "server=localhost;uid=BTGFRM;pwd=Qr0@94BTG#7;database=BTGFRM.Clientes";
            var serverVersion = ServerVersion.AutoDetect(new MySqlConnector.MySqlConnection(connectionString));

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySql(connectionString, serverVersion);

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
