using Microsoft.EntityFrameworkCore;

namespace MarioTask.Models
{
    public class MarioDBContext : DbContext
    {
        public MarioDBContext(DbContextOptions<MarioDBContext> options) : base(options)
        {
        }
        public DbSet<TeamUser> TeamUsers { get; set; }
        public DbSet<CharacterUser> CharacterUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamUser>()
                .HasKey(t => new { t.TeamUserID });

            modelBuilder.Entity<CharacterUser>()
                .HasKey(c => new { c.CharacterID });

            modelBuilder.Entity<TeamUser>()
            .HasMany(c => c.CharacterList)
            .WithOne(c => c.TeamUserRIFNavigation)
            .HasForeignKey(c => c.TeamUserRIF);

            modelBuilder.Entity<CharacterUser>()
                .HasOne(t => t.TeamUserRIFNavigation)
                .WithMany(c => c.CharacterList)
                .HasForeignKey(t => t.TeamUserRIF)
                .IsRequired(false);
        }
    }
}
