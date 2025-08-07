using System.ComponentModel.DataAnnotations;

namespace store_system_backend.Models
{
    public class Menu
    {
        [Key]
        public int IdMenu { get; set; }
        public string? Name { get; set; }
        public string? Icon { get; set; }
        public string? Url { get; set; }
    }
}
