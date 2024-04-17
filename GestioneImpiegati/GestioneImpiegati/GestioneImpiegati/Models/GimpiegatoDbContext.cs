using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GestioneImpiegati.Models;

public partial class GimpiegatoDbContext : DbContext
{
    public GimpiegatoDbContext()
    {
    }

    public GimpiegatoDbContext(DbContextOptions<GimpiegatoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CittaResidenza> CittaResidenzas { get; set; }

    public virtual DbSet<Impiegato> Impiegatos { get; set; }

    public virtual DbSet<ProvinciaResidenza> ProvinciaResidenzas { get; set; }

    public virtual DbSet<Reparto> Repartos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ACADEMY2024-17\\SQLEXPRESS;Database=GimpiegatoDB;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CittaResidenza>(entity =>
        {
            entity.HasKey(e => e.CittaResidenzaId).HasName("PK__Citta_Re__3A180AB04CF0D6EF");

            entity.ToTable("Citta_Residenza");

            entity.Property(e => e.CittaResidenzaId).HasColumnName("citta_residenzaID");
            entity.Property(e => e.Citta)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("citta");
        });

        modelBuilder.Entity<Impiegato>(entity =>
        {
            entity.HasKey(e => e.ImpiegatoId).HasName("PK__Impiegat__C7A20D12D7560F75");

            entity.ToTable("Impiegato");

            entity.HasIndex(e => e.Matricola, "UQ__Impiegat__2C2751BA1CBB27C2").IsUnique();

            entity.Property(e => e.ImpiegatoId).HasColumnName("impiegatoID");
            entity.Property(e => e.CittaResidenza)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("citta_residenza");
            entity.Property(e => e.Cognome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("cognome");
            entity.Property(e => e.DataNascita).HasColumnName("data_nascita");
            entity.Property(e => e.IndirizzoResidenza)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("indirizzo_residenza");
            entity.Property(e => e.Matricola)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("matricola");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.ProvinciaResidenza)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("provincia_residenza");
            entity.Property(e => e.Reparto)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("reparto");
            entity.Property(e => e.Ruolo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ruolo");
        });

        modelBuilder.Entity<ProvinciaResidenza>(entity =>
        {
            entity.HasKey(e => e.ProvinciaResidenzaId).HasName("PK__Provinci__C7E2EC3D4C56422A");

            entity.ToTable("Provincia_Residenza");

            entity.Property(e => e.ProvinciaResidenzaId).HasColumnName("provincia_residenzaID");
            entity.Property(e => e.CittaRif).HasColumnName("cittaRIF");
            entity.Property(e => e.Provincia)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("provincia");

            entity.HasOne(d => d.CittaRifNavigation).WithMany(p => p.ProvinciaResidenzas)
                .HasForeignKey(d => d.CittaRif)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Provincia__citta__45F365D3");
        });

        modelBuilder.Entity<Reparto>(entity =>
        {
            entity.HasKey(e => e.RepartoId).HasName("PK__Reparto__612C4F36E136824A");

            entity.ToTable("Reparto");

            entity.Property(e => e.RepartoId).HasColumnName("repartoID");
            entity.Property(e => e.TipoReparto)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("tipo_reparto");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
