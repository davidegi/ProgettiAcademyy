using Microsoft.EntityFrameworkCore;

namespace NasaInfo.Models
{
    public class NasaContext : DbContext
    {
        //... opzioni costruttore per la configurazione di EF

        public DbSet<OggettoCeleste> OggettoCelestes { get; set; }
        public DbSet<Sistema> Sistemas { get; set; }
        public DbSet<Oggetto_Sistema> OggettosSistemas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Oggetto_Sistema>().HasKey(i => new { i.SistemaRif, i.OggettoRif });

            modelBuilder.Entity<Oggetto_Sistema>()
                .HasOne(os => os.ogg)
                .WithMany(o => o.ElencoOggSis)
                .HasForeignKey(os => os.OggettoRif);

            modelBuilder.Entity<Oggetto_Sistema>()
               .HasOne(os => os.sis)
               .WithMany(s => s.ElencoOggSis)
               .HasForeignKey(os => os.SistemaRif);
        }
    }
}
