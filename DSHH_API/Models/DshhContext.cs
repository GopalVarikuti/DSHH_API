using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DSHH_API.Models;

public partial class DshhContext : DbContext
{
    public DshhContext()
    {
    }

    public DshhContext(DbContextOptions<DshhContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Stat> Stats { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB; Database=DSHH;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Stat>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Amountcollected).HasColumnName("amountcollected");
            entity.Property(e => e.Description)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Helpedbypeople).HasColumnName("helpedbypeople");
            entity.Property(e => e.Noofevents).HasColumnName("noofevents");
            entity.Property(e => e.Volunteers).HasColumnName("volunteers");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
