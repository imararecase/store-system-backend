using System.ComponentModel.DataAnnotations;

namespace store_system_backend.Models
{
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int IdCategory { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool State { get; set; }
        public string? ImageUrl { get; set; }
    }
}
