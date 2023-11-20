using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DBEasyStock.Entity;

namespace DataLayer.DBEasyStock.Configuration
{
    public class TransactionItemConfig : IEntityTypeConfiguration<TransactionItem>
    {

        public void Configure(EntityTypeBuilder<TransactionItem> modelBuilder)
        {
            modelBuilder.HasKey("ProductId", "TransactionId");
            modelBuilder.Property(b => b.TransactionType).IsRequired().HasColumnType("char(2)");
            modelBuilder.Property(b => b.ProductId).IsRequired().HasColumnType("int");
            modelBuilder.Property(b => b.LocationId).IsRequired().HasColumnType("int");
            modelBuilder.Property(b => b.Qty).IsRequired().HasColumnType("Decimal(18,2)");
            modelBuilder.Property(b => b.Price).IsRequired().HasColumnType("Decimal(18,2)");

            //one to many relation between Product and TransactionItems. Satu produk bisa ada di banyak item transaksi
            modelBuilder
               .HasOne(b => b.Product)
               .WithMany(b => b.TransactionItems).HasForeignKey(b => b.ProductId);

            //one to many relation between Transaction and TransactionItem. Satu transaksi bisa mempunyai banyak item transaksi
            modelBuilder
               .HasOne(b => b.Transaction)
               .WithMany(b => b.TransactionItems).HasForeignKey(b => b.TransactionId);

            //one to many relation between Location and TransactionItems. Satu Lokasi bisa banyak item transaksi
            modelBuilder
               .HasOne(b => b.Location)
               .WithMany(b => b.TransactionItems).HasForeignKey(b => b.LocationId);


        }
    }
}