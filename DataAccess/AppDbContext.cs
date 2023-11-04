using DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

public class AppDbContext : DbContext
{ 
    public AppDbContext() : base(GetOptions())
    {
      
    }

    private static DbContextOptions<AppDbContext> GetOptions()
    {
        var _cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        return new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(_cadena)
            .Options;
    }

    public DbSet<Cliente> Clientes { get; set; }

    public DbSet<Inmueble> Inmuebles { get; set; }

    public DbSet<InmuebleVisita> InmueblesVisitas { get; set; }

    public DbSet<Propietario> Propietarios { get; set; }
}