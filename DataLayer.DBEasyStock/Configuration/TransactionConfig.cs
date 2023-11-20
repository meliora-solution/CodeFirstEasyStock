using DataLayer.DBEasyStock.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DataLayer.DBEasyStock.Configuration
{
    public class TransactionConfig : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> modelBuilder)
        {
            modelBuilder.HasKey(b => b.Id);
            // jangan buat AutoNumber 

            // jangan buat AutoNumber 
            modelBuilder.Property<int>("Id")
              .ValueGeneratedNever()
              .HasColumnType("int");

            modelBuilder.Property(b => b.TransactionDate).IsRequired().HasColumnType("DateTime");
            modelBuilder.Property(b => b.PaymentType).IsRequired().HasColumnType("char(1)");
            modelBuilder.Property(b => b.Invoice).IsRequired().HasColumnType("varchar(20)");

            modelBuilder.Property(b => b.ContactId).IsRequired(false).HasColumnType("int");
            modelBuilder.Property(b => b.Description).IsRequired().HasColumnType("varchar(2000)");
            modelBuilder.Property(b => b.CreatedBy).IsRequired().HasColumnType("varchar(256)");
            modelBuilder.Property(b => b.CreatedAt).IsRequired().HasColumnType("DateTime");



        }
    }
}
