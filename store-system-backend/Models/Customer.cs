﻿using System.ComponentModel.DataAnnotations;

namespace store_system_backend.Models
{
    public class Customer
    {
        [Key]
        public int IdCustomer { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Dni { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}
