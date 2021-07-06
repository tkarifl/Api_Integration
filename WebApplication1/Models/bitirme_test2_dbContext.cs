using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class bitirme_test2_dbContext : DbContext
    {
        public bitirme_test2_dbContext()
        {
        }

        public bitirme_test2_dbContext(DbContextOptions<bitirme_test2_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GgUserInfo> GgUserInfo { get; set; }
        public virtual DbSet<ProductsGg> ProductsGg { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=bitirme_test2_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<GgUserInfo>(entity =>
            {
                entity.ToTable("gg_user_info");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ApiKey)
                    .IsRequired()
                    .HasColumnName("api_key")
                    .HasMaxLength(100);

                entity.Property(e => e.RolePassword)
                    .IsRequired()
                    .HasColumnName("role_password")
                    .HasMaxLength(100);

                entity.Property(e => e.RoleUsername)
                    .IsRequired()
                    .HasColumnName("role_username")
                    .HasMaxLength(100);

                entity.Property(e => e.SecretKey)
                    .IsRequired()
                    .HasColumnName("secret_key")
                    .HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ProductsGg>(entity =>
            {
                entity.ToTable("products_gg");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasColumnName("image_url")
                    .HasMaxLength(300);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(100);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
