using Microsoft.EntityFrameworkCore;
using Mobile_Application_Sales_Site.Models;

namespace Mobile_Application_Sales_Site.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "iOSApp", DisplayOrder = 1 },
                new Category { Id = 2, Name = "AndroidApp", DisplayOrder = 1 }

                );
        }
    }
}
