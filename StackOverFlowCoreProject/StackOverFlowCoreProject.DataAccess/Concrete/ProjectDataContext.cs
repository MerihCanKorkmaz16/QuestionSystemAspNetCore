using Microsoft.EntityFrameworkCore;
using StackOverFlowCoreProject.Entities.Concrete;
using StackOverFlowCoreProject.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverFlowCoreProject.DataAccess.Concrete
{
    public partial class ProjectDataContext:DbContext
    {
      
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Soru> Soru { get; set; }
        public virtual DbSet<Yorumlar> Yorumlar { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=CASPER;Database=Stackoverflow;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Soru>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.SoruDetay)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Soru)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Soru_Category");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Soru)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Soru_AspNetUsers");

                entity.HasOne(d => d.Yorum)
                    .WithMany(p => p.Soru)
                    .HasForeignKey(d => d.YorumId)
                    .HasConstraintName("FK_Soru_Yorumlar");
            });

            modelBuilder.Entity<Yorumlar>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.YorumDetay)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
