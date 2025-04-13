using Clothes.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Clothes.Services.ProductAPI.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                ProductName = "Samosa",
                Price = 15,
                Description = "Quisque vel lacus ac mangna. <br/> Vestr",
                ImageUrl= "https://placehold.co/603x403",
                CategoryName= "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                ProductName = "Paneer Tikka",
                Price = 13.99,
                Description = "Quisque vel lacus ac mangna. <br/> Vestr",
                ImageUrl = "https://placehold.co/603x403",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                ProductName = "Sweet Pie",
                Price = 10,
                Description = "Quisque vel lacus ac mangna. <br/> Vestr",
                ImageUrl = "https://placehold.co/603x403",
                CategoryName = "Dessert"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                ProductName = "Clothes",
                Price = 25,
                Description = "Quisque vel lacus ac mangna. <br/> Vestr",
                ImageUrl = "https://placehold.co/603x403",
                CategoryName = "Dessert"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                ProductName = "Pav Bhaji",
                Price = 15.99,
                Description = "Quisque vel lacus ac mangna. <br/> Vestr",
                ImageUrl = "https://placehold.co/603x403",
                CategoryName = "Entree"
            });
        }
    }
}
