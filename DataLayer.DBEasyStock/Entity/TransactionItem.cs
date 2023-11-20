using System.ComponentModel.DataAnnotations;

namespace DataLayer.DBEasyStock.Entity
{
    public class TransactionItem
    {

        public int ProductId { get; set; }
        public int TransactionId { get; set; }
        public string TransactionType { get; set; }
        public int LocationId { get; set; }
        public decimal Qty { get; set; }
        public decimal Price { get; set; }

        public Product Product { get; set; }
        public Location Location { get; set; }
        public Transaction Transaction { get; set; }


    }
}
