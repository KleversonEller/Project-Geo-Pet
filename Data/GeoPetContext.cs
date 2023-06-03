using Microsoft.EntityFrameworkCore;
using project_geopet.Models;

namespace project_geopet.Data;

public class GeoPetContext : DbContext
{
    public DbSet<CaringPerson> CaringPersons {get; set;}
    public DbSet<Pet> Pets {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(connectionString: "DataSource=./Data/app.db;Cache=Shared");
    }
}