namespace DataLayer.DBEasyStock.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public string Image { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }
        public int UnitId { get; set; }
        public bool IsActived { get; set; }

        // Navigation Class
        public Unit Unit { get; set; }
        public Category Category { get; set; }
        public ICollection<Stock> Stocks { get; set; }
        public ICollection<SupplierProduct> SupplierProducts { get; set; }
        public ICollection<TransactionItem> TransactionItems { get; set; }
    }
}
