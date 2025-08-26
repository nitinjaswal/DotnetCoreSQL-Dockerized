using Microsoft.EntityFrameworkCore;

namespace Product.API
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProductModel> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().HasData(
                new ProductModel { Id = 1, Name = "Product 1" },
                new ProductModel { Id = 2, Name = "Product 2" }
            );
        }
    }
}
