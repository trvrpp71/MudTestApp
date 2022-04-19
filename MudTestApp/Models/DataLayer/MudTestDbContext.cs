using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MudTestApp.Models.DataLayer
{
    public partial class MudTestDbContext : DbContext
    {
        public MudTestDbContext()
        {
        }

        public MudTestDbContext(DbContextOptions<MudTestDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MsysCompactError> MsysCompactErrors { get; set; }
        public virtual DbSet<TblCompound> TblCompounds { get; set; }
        public virtual DbSet<TblMain> TblMains { get; set; }
        public virtual DbSet<TblTestResult> TblTestResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name=DefaultContext");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<MsysCompactError>(entity =>
            {
                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblCompound>(entity =>
            {
                entity.HasKey(e => e.CompoundId)
                    .HasName("tblCompounds$PK__tblCompo__574E8CF826EC7CB5");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblMain>(entity =>
            {
                entity.HasKey(e => e.Mt)
                    .HasName("tblMain$PK__tblMain__26F652666E19B6B7");

                entity.Property(e => e.DateIn).HasPrecision(0);

                entity.Property(e => e.DateOut).HasPrecision(0);

                entity.Property(e => e.ReceivedDate).HasPrecision(0);

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TimeIn).HasPrecision(0);

                entity.Property(e => e.TimeOut).HasPrecision(0);
            });

            modelBuilder.Entity<TblTestResult>(entity =>
            {
                entity.HasKey(e => e.TestId)
                    .HasName("tblTestResults$PK__tblTestR__8CC331007E26B75F");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
