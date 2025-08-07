using System.ComponentModel.DataAnnotations;

namespace store_system_backend.Models
{
    public class Category
    {
        [Key]
        public int IdCategory { get; set; }
        public string? Name { get; set; }
    }
}
