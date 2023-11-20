using DataLayer.DBEasyStock.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.DBEasyStock.Configuration
{
    public class UnitConfig : IEntityTypeConfiguration<Unit>
    {

        public void Configure(EntityTypeBuilder<Unit> modelBuilder)
        {
            modelBuilder.HasKey(b => b.Id);
            // jangan buat AutoNumber 

            // jangan buat AutoNumber 
            modelBuilder.Property<int>("Id")
              .ValueGeneratedNever()
              .HasColumnType("int");

            modelBuilder.HasIndex(b => b.Name).IsUnique(true);
            modelBuilder.Property(b => b.Name).IsRequired().HasColumnType("varchar(50)");

        }
    }
}
