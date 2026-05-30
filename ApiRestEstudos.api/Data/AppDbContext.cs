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
    }
}