using DataLayer.DBEasyStock.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.DBEasyStock.Configuration
{


    public class SupplierProductConfig : IEntityTypeConfiguration<SupplierProduct>
    {
        public void Configure(EntityTypeBuilder<SupplierProduct> modelBuilder)
        {
            modelBuilder.HasKey(b => new { b.ProductId, b.SupplierId });

            //one to many relation between product and SupplierProduct. 
            modelBuilder
               .HasOne(b => b.Product)
               .WithMany(b => b.SupplierProducts).HasForeignKey(b => b.ProductId);

            //one to many relation between supplier and SupplierProduct. 
            modelBuilder
               .HasOne(b => b.Contact)
               .WithMany(b => b.SupplierProducts).HasForeignKey(b => b.SupplierId);

        }
    }
}
