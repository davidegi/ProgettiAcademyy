using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GestioneFerramenta.Models;

public partial class FerramentaDbContext : DbContext
{
    public FerramentaDbContext()
    {
    }

    public FerramentaDbContext(DbContextOptions<FerramentaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ferramentum> Ferramenta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ACADEMY2024-17\\SQLEXPRESS;Database=FerramentaDB;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ferramentum>(entity =>
        {
            entity.HasKey(e => e.FerramentaId).HasName("PK__Ferramen__2BCC3049542F82FB");

            entity.Property(e => e.FerramentaId).HasColumnName("ferramentaId");
            entity.Property(e => e.Categoria)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("categoria");
            entity.Property(e => e.Codice)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("codice");
            entity.Property(e => e.Creazione).HasColumnName("creazione");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descrizione");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Prezzo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("prezzo");
            entity.Property(e => e.Quantita).HasColumnName("quantita");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
