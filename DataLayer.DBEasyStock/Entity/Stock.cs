using System.ComponentModel.DataAnnotations;

namespace DataLayer.DBEasyStock.Entity
{
    public class Stock
    {
        public int LocationId { get; set; }
        public int ProductId { get; set; }
        public decimal Qty { get; set; }
        public Product Product { get; set; }
        public Location Location { get; set; }

    }
}
