using Microsoft.EntityFrameworkCore;
using ApiRestEstudos.Api.Models;

namespace ApiRestEstudos.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasData(
                new Location { Id = 1, Nome = "Cristo Redentor", Categoria = "Turismo", Latitude = -22.9519, Longitude = -43.2105 },
                new Location { Id = 2, Nome = "Pao de Acucar", Categoria = "Turismo", Latitude = -22.9489, Longitude = -43.1576 },
                new Location { Id = 3, Nome = "Praia de Copacabana", Categoria = "Praia", Latitude = -22.9711, Longitude = -43.1823 },
                new Location { Id = 4, Nome = "Praia de Ipanema", Categoria = "Praia", Latitude = -22.9868, Longitude = -43.2006 },
                new Location { Id = 5, Nome = "Maracana", Categoria = "Estadio", Latitude = -22.9122, Longitude = -43.2302 },
                new Location { Id = 6, Nome = "Jardim Botanico", Categoria = "Parque", Latitude = -22.9669, Longitude = -43.2243 },
                new Location { Id = 7, Nome = "Parque Lage", Categoria = "Parque", Latitude = -22.9602, Longitude = -43.2109 },
                new Location { Id = 8, Nome = "Arpoador", Categoria = "Praia", Latitude = -22.9894, Longitude = -43.1917 },
                new Location { Id = 9, Nome = "Pedra da Gavea", Categoria = "Trilha", Latitude = -22.9974, Longitude = -43.2742 },
                new Location { Id = 10, Nome = "Quinta da Boa Vista", Categoria = "Parque", Latitude = -22.9072, Longitude = -43.2231 }
            );
        }
    }
}