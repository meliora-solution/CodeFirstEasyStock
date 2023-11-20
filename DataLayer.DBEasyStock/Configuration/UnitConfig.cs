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
