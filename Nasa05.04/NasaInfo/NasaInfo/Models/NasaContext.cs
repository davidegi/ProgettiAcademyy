using Microsoft.EntityFrameworkCore;

namespace NasaInfo.Models
{
    public class NasaContext : DbContext
    {
        //... opzioni costruttore per la configurazione di EF

        public DbSet<OggettoCeleste> OggettoCelestes { get; set; }
        public DbSet<Sistema> Sistemas{ get; set; }
        public DbSet<OCeleste_Sistema> OCeleste_Sistemas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OggettoCeleste>().HasKey(i => new {i.SistemaRif})
        }
    }
}
