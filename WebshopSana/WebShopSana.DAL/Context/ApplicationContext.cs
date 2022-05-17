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
    }
}
