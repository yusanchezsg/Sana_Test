using Microsoft.EntityFrameworkCore;
using WebShopSana.MODELS.Models;

namespace WebShopSana.DAL.Context
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<ProductCategories> ProductCategories { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
}
