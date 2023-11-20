namespace DataLayer.DBEasyStock.Entity
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public string PaymentType { get; set; }
        public string Invoice { get; set; }
        public int? ContactId { get; set; }
        public string Description { get; set; }

        public bool IsPosted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public Contact Contact { get; set; }
        public ICollection<TransactionItem> TransactionItems { get; set; }


    }
}
