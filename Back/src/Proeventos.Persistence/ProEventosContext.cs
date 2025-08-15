using Microsoft.EntityFrameworkCore;
using Proeventos.Domain;

namespace Proeventos.Persistence
{
    public class ProEventosContext : DbContext
    {
        public ProEventosContext(DbContextOptions<ProEventosContext> options) : base(options) { }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Palestrante> Palestrantes { get; set; }
        public DbSet<PalestranteEvento> PalestrantesEventos { get; set; }
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<RedeSocial> RedesSociais { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PalestranteEvento>()
                .HasKey(pe => new { pe.EventoId, pe.PalestranteId });
            modelBuilder.Entity<PalestranteEvento>()
                .HasOne(pe => pe.Evento)
                .WithMany(e => e.PalestrantesEventos)
                .HasForeignKey(pe => pe.EventoId);
            modelBuilder.Entity<PalestranteEvento>()
                .HasOne(pe => pe.Palestrante)
                .WithMany(p => p.PalestrantesEventos)
                .HasForeignKey(pe => pe.PalestranteId);
        }
    }
}
