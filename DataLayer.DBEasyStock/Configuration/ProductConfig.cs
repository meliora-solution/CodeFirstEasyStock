using DataLayer.DBEasyStock.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DBEasyStock.Configuration
{

    public class ProductConfig : IEntityTypeConfiguration<Product>
    {


        public void Configure(EntityTypeBuilder<Product> modelBuilder)
        {
            modelBuilder.HasKey(b => b.Id);
            // jangan buat AutoNumber 

            // jangan buat AutoNumber 
            modelBuilder.Property<int>("Id")
              .ValueGeneratedNever()
              .HasColumnType("int");

            modelBuilder.Property(b => b.Name).IsRequired().HasColumnType("varchar(50)");
            modelBuilder.HasIndex(b => b.Name).IsUnique(true);

            modelBuilder.Property(b => b.SKU).IsRequired().HasColumnType("varchar(20)");
            modelBuilder.HasIndex(b => b.SKU).IsUnique(true);

            modelBuilder.Property(b => b.Image).IsRequired(false).HasColumnType("varchar(200)");
            modelBuilder.Property(b => b.UnitPrice).IsRequired().HasColumnType("Decimal(18,2)");


            modelBuilder.Property(b => b.Description).IsRequired(false).HasColumnType("varchar(200)");

            //one to many relation between product and category. Satu category bisa di banyak product 
            modelBuilder
               .HasOne(b => b.Category)
               .WithMany(b => b.Products).HasForeignKey(b => b.CategoryId);

            //  one to many relation between unit and product. Satu unit bisa di banyak product
            modelBuilder
               .HasOne(b => b.Unit)
               .WithMany(b => b.Products).HasForeignKey(b => b.UnitId);


        }
    }

}
