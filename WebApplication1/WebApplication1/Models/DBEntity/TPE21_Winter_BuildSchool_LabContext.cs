using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication1.Models.DBEntity
{
    public partial class TPE21_Winter_BuildSchool_LabContext : DbContext
    {
        public TPE21_Winter_BuildSchool_LabContext()
        {
        }

        public TPE21_Winter_BuildSchool_LabContext(DbContextOptions<TPE21_Winter_BuildSchool_LabContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("data source=.;initial catalog=TPE21_Winter_BuildSchool_Lab;integrated security=True;MultipleActiveResultSets=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_CI_AS");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.HasComment("商品Id");

                entity.Property(e => e.Id).HasComment("商品Id");

                entity.Property(e => e.ImgUrl).HasComment("商品圖片");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("商品名稱");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("商品單價");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
