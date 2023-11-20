using DataLayer.DBEasyStock.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DBEasyStock.Configuration
{
    public class LocationConfig : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> modelBuilder)
        {
            modelBuilder.HasKey(b => b.Id);
            // jangan buat AutoNumber 
            modelBuilder.Property<int>("Id")
              .ValueGeneratedNever()
              .HasColumnType("int");
            modelBuilder.Property(b => b.Name).IsRequired().HasColumnType("varchar(50)");
            modelBuilder.HasIndex(b => b.Name).IsUnique(true);
        }

    }



}
