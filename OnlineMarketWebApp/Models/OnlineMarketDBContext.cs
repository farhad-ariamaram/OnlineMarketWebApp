using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace OnlineMarketWebApp.Models
{
    public partial class OnlineMarketDBContext : DbContext
    {
        public OnlineMarketDBContext()
        {
        }

        public OnlineMarketDBContext(DbContextOptions<OnlineMarketDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Banner> Banners { get; set; }
        public virtual DbSet<HomeProduct> HomeProducts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=OnlineMarketDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Banner>(entity =>
            {
                entity.ToTable("Banner");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HomeProduct>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Lprice).HasColumnName("LPrice");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SubmitDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Slider>(entity =>
            {
                entity.ToTable("Slider");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SubText)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
