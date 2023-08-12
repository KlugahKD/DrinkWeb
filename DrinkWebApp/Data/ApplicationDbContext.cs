using DrinkWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DrinkWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          modelBuilder.Entity<Category>().HasData(
              new Category { Id = 1, Name = "Baileys", DisplayOrder  = 1 },
              new Category { Id = 2, Name = "Fanta", DisplayOrder = 2 },
              new Category { Id = 3, Name = "Coke", DisplayOrder = 3 }
              );
        }
    }
}
