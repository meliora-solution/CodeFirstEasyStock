using DataLayer.DBEasyStock.Configuration;
using DataLayer.DBEasyStock.Entity;
using Microsoft.EntityFrameworkCore;


namespace DataLayer.DBEasyStock.Context
{
    public class EasyStockContext : DbContext
    {
        public EasyStockContext(DbContextOptions<EasyStockContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ContactConfig());
            modelBuilder.ApplyConfiguration(new LocationConfig());


            modelBuilder.ApplyConfiguration(new ProductConfig());

            modelBuilder.ApplyConfiguration(new StockConfig());
            modelBuilder.ApplyConfiguration(new SupplierProductConfig());
            modelBuilder.ApplyConfiguration(new TransactionConfig());
           modelBuilder.ApplyConfiguration(new TransactionItemConfig());

            modelBuilder.ApplyConfiguration(new UnitConfig());

            //Default value for Location.

            modelBuilder.Entity<Location>().HasData(
                   new Location { Id = 1, Name = "Default" }
               );

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(
           DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<Location> Locations { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Stock> Stocks { get; set; } = null!;

        public virtual DbSet<SupplierProduct> SupplierProducts { get; set; } = null!;
        public virtual DbSet<Transaction> Transactions { get; set; } = null!;
        public virtual DbSet<TransactionItem> TransactionItems { get; set; } = null!;
        public virtual DbSet<Unit> Units { get; set; } = null!;

    }


}
