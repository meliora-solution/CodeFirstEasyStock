using System.ComponentModel.DataAnnotations;

namespace DataLayer.DBEasyStock.Entity
{
    public class SupplierProduct
    {
        public int ProductId { get; set; }
        public int SupplierId { get; set; }

        public Product Product { get; set; }
        public Contact Contact { get; set; }
    }
}
