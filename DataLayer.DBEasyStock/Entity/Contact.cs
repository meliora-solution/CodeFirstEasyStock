namespace DataLayer.DBEasyStock.Entity
{
    public class Contact
    {
        public int Id { get; set; }
        public string ContactType { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<SupplierProduct> SupplierProducts { get; set; }
    }
}
