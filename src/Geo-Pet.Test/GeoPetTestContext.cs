using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using project_geopet.Models;
using project_geopet.Controllers;
using project_geopet.Data;

namespace project_geopet.Test;

public class GeoPetTestContext<TEntryPoint> : WebApplicationFactory<Program> where TEntryPoint : Program
{

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        _ = builder.ConfigureServices(services =>
        {
            var descriptor = services.SingleOrDefault(
                d => d.ServiceType ==
                    typeof(DbContextOptions<GeoPetContext>));
            if (descriptor != null)
                services.Remove(descriptor);
            services.AddDbContext<GeoPetContext>(options =>
            {
                options.UseInMemoryDatabase("db");
            });
            var sp = services.BuildServiceProvider();
            using var scope = sp.CreateScope();
            using var appContext = scope.ServiceProvider.GetRequiredService<GeoPetContext>();
            try
            {

                appContext.Database.EnsureDeleted();

                appContext.Database.EnsureCreated();

                appContext.CaringPersons.AddRange(
                    new CaringPerson {Id = Guid.NewGuid(), Cep = "13178060", Email = "test1@test.com", Name = "test1", Password = "testsenha", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
                    new CaringPerson {Id = Guid.NewGuid(), Cep = "13178060", Email = "test2@test.com", Name = "test2", Password = "testsenha", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
                    new CaringPerson {Id = Guid.NewGuid(), Cep = "13178060", Email = "test3@test.com", Name = "test3", Password = "testsenha", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now}
                );

                appContext.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
        });
    }
}