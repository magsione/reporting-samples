using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Blazor_UI_and_Report_Viewer.Data
{
    public partial class AdventureContext : DbContext
    {
        public AdventureContext()
        {
        }

        public AdventureContext(DbContextOptions<AdventureContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Product { get; set; }

        public virtual DbSet<ProductSubCategory> ProductSubCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_Product_Name")
                    .IsUnique();

                entity.HasOne(p => p.ProductSubcategory)
                    .WithMany(sc => sc.Products)
                    .HasForeignKey(p => p.ProductSubcategoryID);
            });

            modelBuilder.Entity<ProductSubCategory>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_ProductSubcategory_Name")
                    .IsUnique();

                entity.HasOne(sc => sc.ParentProductCategory)
                    .WithMany(c => c.SubCategories)
                    .HasForeignKey(sc => sc.ProductCategoryId);
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_ProductCategory_Name")
                    .IsUnique();

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
