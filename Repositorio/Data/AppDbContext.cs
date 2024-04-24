using Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Conductor> Conductor { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> op) : base(op)
        {

        }

    }
}
