using Microsoft.EntityFrameworkCore;
using ProVentos.API.Models;

namespace ProVentos.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Evento> Eventos { get; set; }
    }
}
