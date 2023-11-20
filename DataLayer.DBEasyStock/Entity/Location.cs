namespace DataLayer.DBEasyStock.Entity
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Stock> Stocks { get; set; }
        public ICollection<TransactionItem> TransactionItems { get; set; }

    }
}
