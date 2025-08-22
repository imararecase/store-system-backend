using Microsoft.EntityFrameworkCore;
using store_system_backend.Models;

namespace store_system_backend.DbContexts
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext() { }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories {get; set; }
        public DbSet<Product> Products {get; set; }
    }
}
