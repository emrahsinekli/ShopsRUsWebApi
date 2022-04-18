
using ShopsRUs.Domains;
using ShopsRUs.Domains.Entities;
using System.Data.Entity;

namespace ShopsRUs.DAL
{
    public class ApiContext : DbContext
    {
        public ApiContext() : base("ApiContext") { }

        public DbSet<DiscountTypes> DiscountTypes { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
