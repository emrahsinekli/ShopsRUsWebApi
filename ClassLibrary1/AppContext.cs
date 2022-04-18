using Microsoft.EntityFrameworkCore;
using ShopsRUs.Data.Configurations;
using ShopsRUs.Domains;

namespace ShopsRUs.DAL
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SeedUserData());

            modelBuilder.ApplyConfiguration(new SeedDiscountData());
            modelBuilder.ApplyConfiguration(new SeedInvoiceData());
            modelBuilder.ApplyConfiguration(new SeedInvoiceDetailsData());
        }

        public DbSet<DiscountTypes> DiscountType { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetails> InvoiceDetails { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
