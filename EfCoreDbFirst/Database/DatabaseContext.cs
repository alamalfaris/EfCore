using Microsoft.EntityFrameworkCore;
using Models;

namespace EfCoreDbFirst.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__Product__3214EC07D68EE17B");

                entity.ToTable("Products");

                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Name");

                entity.Property(e => e.Information)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Information");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CreatedBy");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime").HasColumnName("CreatedTime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UpdatedBy");

                entity.Property(e => e.UpdatedTime).HasColumnType("datetime").HasColumnName("UpdatedTime");

            });
        }
    }
}
