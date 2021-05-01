
using Microsoft.EntityFrameworkCore;

namespace webapi_sqlserver.Data
{

	public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }
        public DbSet <Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(
                new Product { Id = 1, Name = "X-caverna", Price = 7.95M, Description = "iiiiiiiiiiiii" },
                new Product { Id = 2, Name = "X-balda", Price = 2.45M, Description = "oooktkotjtjue" },
                new Product { Id = 3, Name = "X-tudo Duplo", Price = 6.25M, Description = "oiaeoihaehoiea" }
                );
        }
        
    }
}