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
    public class ContactConfig : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> modelBuilder)
        {
            modelBuilder.HasKey(b => b.Id);
            // jangan buat AutoNumber 
            modelBuilder.Property<int>("Id")
              .ValueGeneratedNever()
              .HasColumnType("int");

            modelBuilder.Property(b => b.ContactType).IsRequired().HasColumnType("char(1)");
            modelBuilder.Property(b => b.Name).IsRequired().HasColumnType("varchar(50)");
            modelBuilder.HasIndex(b => b.Name).IsUnique(true);

            modelBuilder.Property(b => b.Address).IsRequired(false).HasColumnType("varchar(200)");
            modelBuilder.Property(b => b.Phone).IsRequired(false).HasColumnType("varchar(15)");
            modelBuilder.Property(b => b.Description).IsRequired(false).HasColumnType("varchar(200)");


        }
    }
}
