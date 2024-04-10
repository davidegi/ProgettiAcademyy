
using NasaInfo.Models;
using NasaInfo.Repositories;
using NasaInfo.Services;

namespace NasaInfo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            #region
            builder.Services.AddDbContext<NasaContext>(options => options.UseSqlService(
                builder.Configuration.GetConnectionString("DefaultConnection")
                ));
            builder.Services.AddScoped<IRepo<OggettoCeleste>, OggettoRepo>();
            builder.Services.AddScoped<OggettoService>();
            builder.Services.AddScoped<IRepo<Sistema>, SistemaRepo>();
            builder.Services.AddScoped<SistemaService>();

            #endregion

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
