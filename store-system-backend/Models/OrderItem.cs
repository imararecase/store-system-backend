using System.ComponentModel.DataAnnotations;

namespace store_system_backend.Models
{
    public class OrderItem
    {
        [Key]
        public int IdOrderItem { get; set; }
        public int IdProduct { get; set; }
        public string? Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotal { get; set; }
        public int IdOrder { get; set; }
        public Order? Order { get; set; }
    }
}
