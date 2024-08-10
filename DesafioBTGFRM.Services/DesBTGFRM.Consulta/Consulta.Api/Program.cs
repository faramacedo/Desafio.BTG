using Consulta.Application;
using Consulta.Infrastructure.Database;
using Consulta.Infrastructure.RabbitMQ;
using Microsoft.EntityFrameworkCore;

namespace Consulta.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IClientesService, ClienteService>();
            builder.Services.AddScoped<IRabbitMQService, RabbitMQService>();

            builder.Services.AddDbContext<AppDbContext>
            (options =>
                options.UseMySql(builder.Configuration
                    .GetConnectionString("ServiceDb"),
                        ServerVersion.AutoDetect(new MySqlConnector.MySqlConnection(
                            builder.Configuration
                                .GetConnectionString("ServiceDb")
                        )
                    )
                )
            );
            builder.Configuration.GetConnectionString("ServiceDb");

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
