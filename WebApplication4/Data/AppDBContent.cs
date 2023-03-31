using Microsoft.EntityFrameworkCore;
using WebApplication4.Data.Models;

namespace WebApplication4.Data
{
    public class AppDBContent : DbContext
    {

        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) { }

        public DbSet<Car> Car { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<ShopCarItem> ShopCarItem { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<OrderDetails> OrderDetails { get; set; }

    }
}
