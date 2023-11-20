using DataLayer.DBEasyStock.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.DBEasyStock.Configuration
{
    public class StockConfig : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> modelBuilder)
        {
            modelBuilder.HasKey(b => new { b.ProductId, b.LocationId });
            modelBuilder.Property(b => b.Qty).IsRequired(true).HasColumnType("Decimal(18,2)");

            //one to many relation between product and Stock. Satu produk bisa di banyak stock (stok adalah penghubung antara produk dan lokasi) 
            modelBuilder
               .HasOne(b => b.Product)
               .WithMany(b => b.Stocks).HasForeignKey(b => b.ProductId);

            //one to many relation between location and Stock.(stok adalah penghubung antara produk dan lokasi)
            modelBuilder
               .HasOne(b => b.Location)
               .WithMany(b => b.Stocks).HasForeignKey(b => b.LocationId);

        }
    }
}
